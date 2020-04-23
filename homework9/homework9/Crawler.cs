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

namespace homework9
{
    class Crawler
    {
        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;
        private Hashtable urls = new Hashtable();
        private int count = 0;
        

        public void Start(string startUrl)
        {
            urls.Add(startUrl, false);//加入初始页面
        }

        public void Crawl()
        {
            //Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                //Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                PageDownloaded(this, current, "success");
                count++;
                //Console.WriteLine(html);
                if (Regex.IsMatch(html, @"<!DOCTYPE html>"))
                    Parse(html, current);//解析,并加入新的链接
                //Console.WriteLine("爬行结束");
                CrawlerStopped(this);
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string root)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                //Console.WriteLine(match);
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                
                strRef = UrlChange(strRef, root);
                if (strRef.Length == 0) continue;
                if (Regex.IsMatch(strRef, @"www.cnblogs.com/"))
                    if (urls[strRef] == null) urls[strRef] = false;
            }
        }

        //将相对路径转为绝对路径
        static private string UrlChange(string url, string baseUrl)
        {
            string urlParseRegex = @"^(?<site>https?://(?<host>[\w\d.]+)(:\d+)?($|/))([\w\d]+/)*(?<file>[^#?]*)";
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

                return UrlChange(url, baseUrl.Substring(0, idx));
            }

            int end = baseUrl.LastIndexOf("/");
            return baseUrl.Substring(0, end) + "/" + url;
        }
    }
}

