using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework9
{
	class Crawler
	{
        public event Action<Crawler> CrawlerStop;
        public event Action<Crawler,string, string> PageDownload;

        //已经下载和没有下载的URL,key处放URL,value处放是否爬取成功
        public Dictionary<string, bool> urls = new Dictionary<string, bool>();

        //待下载的队列
        private Queue<string> pending = new Queue<string>();

        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";

        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";

        public string HostFilter { get; set; }//主机过滤规则
        public string FileFilter { get; set; }//文件过滤规则
        public int MaxPage { get; set; }//最大下载数量
        public string StartURL { get; set; }//起始网址
        public Encoding HtmlEncoding { get; set; }//网页编码
        public Dictionary<string, bool> DownloadedPages { get => urls; }

        public Crawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        public void Start()
		{
            urls.Clear();
            pending.Clear();
            pending.Enqueue(StartURL);

            while (urls.Count < MaxPage && pending.Count > 0)
            {
                string url = pending.Dequeue();
                try
                {
                    string html = DownLoad(url); 
                    urls[url] = true;
                    PageDownload(this, url, "是");
                    Parse(html, url);
                }
                catch (Exception ex)
                {
                    PageDownload(this, url, "错误:" + ex.Message);
                }
            }
            CrawlerStop(this);
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = urls.Count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                PageDownload(this, url, "错误:" + ex.Message);
                return "";
            }
        }

        //解析,并加入新的链接
        private void Parse(string html, string pageUrl)
        {
            var matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, pageUrl);//转绝对路径
                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;//解析出host
                string file = linkUrlMatch.Groups["file"].Value;//解析出file
                if (file == "")
                {
                    file = "index.html";
                }
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter) && !urls.ContainsKey(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                    urls.Add(linkUrl, false);
                }
            }
        }

        //将相对路径转为绝对路径
        static private string FixUrl(string url, string baseUrl)
        {
            if (url.Contains("://"))
            {
                return url;
            }
            if (url.StartsWith("//"))
            {
                return "http:" + url;
            }
            if (url.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(baseUrl, urlParseRegex);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + url.Substring(1) : site + url;
            }

            if (url.StartsWith("../"))
            {
                url = url.Substring(3);
                int idx = baseUrl.LastIndexOf('/');
                return FixUrl(url, baseUrl.Substring(0, idx));
            }

            if (url.StartsWith("./"))
            {
                return FixUrl(url.Substring(2), baseUrl);
            }

            int end = baseUrl.LastIndexOf("/");
            return baseUrl.Substring(0, end) + "/" + url;
        }
    }
}
