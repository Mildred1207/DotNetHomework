﻿using System;
using System.Collections;
using System.Collections.Concurrent;
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
        public event Action<Crawler,int,string, string> PageDownload;

        //已经下载和没有下载的URL,key处放URL,value处放是否爬取成功
        public ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();

        //待下载的队列
        private ConcurrentQueue<string> pending = new ConcurrentQueue<string>();

        //URL检测表达式，用于在HTML文本中查找URL
        public static readonly string UrlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";

        //URL解析表达式
        public static readonly string urlParseRegex = @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";

        public string HostFilter { get; set; }//主机过滤规则
        public string FileFilter { get; set; }//文件过滤规则
        public int MaxPage { get; set; }//最大下载数量
        public string StartURL { get; set; }//起始网址
        public Encoding HtmlEncoding { get; set; }//网页编码
        public ConcurrentDictionary<string, bool> DownloadedPages { get => urls; }

        public Crawler()
        {
            MaxPage = 100;
            HtmlEncoding = Encoding.UTF8;
        }

        public void Start()
        {
            urls.Clear();
            pending = new ConcurrentQueue<string>();
            pending.Enqueue(StartURL);
            List<Task> tasks = new List<Task>();
            int finishCount = 0;//已完成的任务数
            PageDownload += (crawler, index, url, info) => { finishCount++; };

            while (tasks.Count < MaxPage)
            {
                if (!pending.TryDequeue(out string url))
                {
                    if (finishCount < tasks.Count)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                int index = tasks.Count;
                Task task = Task.Run(() => DownloadAndParse(url, index));
                tasks.Add(task);
            }

            Task.WaitAll(tasks.ToArray()); //等待剩余任务全部执行完毕
            CrawlerStop(this);
        }

        //url为待处理的网址
        private void DownloadAndParse(string url, int index)
        {
            try
            {
                string html = DownLoad(url, index);
                urls[url] = true;
                Parse(html, url);//解析,并加入新的链接
                PageDownload(this, index, url, "是");
            }
            catch (Exception ex)
            {
                PageDownload(this, index, url, "错误:" + ex.Message);
            }
        }
       
        private string DownLoad(string url, int index)
        {
            WebClient webClient = new WebClient();
            webClient.Encoding = HtmlEncoding;
            string html = webClient.DownloadString(url);
            File.WriteAllText(index + ".html", html, Encoding.UTF8);
            return html;
        }

        private void Parse(string html, string pageUrl)
        {
            var matches = new Regex(UrlDetectRegex).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "") continue;
                linkUrl = FixUrl(linkUrl, pageUrl);

                Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (file == "") file = "index.html";

                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !urls.ContainsKey(linkUrl))
                {
                    pending.Enqueue(linkUrl);
                    urls.TryAdd(linkUrl, false);
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
