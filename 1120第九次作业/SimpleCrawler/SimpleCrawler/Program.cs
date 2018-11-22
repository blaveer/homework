using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    /*
     * -K key 键对象
     *-V value 值对象
     *-int hash 键对象的hash值
     *-Entry entry 指向链表中下一个Entry对象，可为null，表示当前Entry对象在链表尾部
     */
    class Crawler
    {

        private Hashtable urls = new Hashtable();
        private int count = 0;
        static void Main(string[] args)       //args=System.String[];args.Length=0
        {

            Stopwatch stopwatch = new Stopwatch();



            //Action[] actions = { crawler.Crawl };
            stopwatch.Start();
            Crawler crawlerNor = new Crawler();
            string startUrlNor = "http://www.cnblogs.com/dstang2000";
            crawlerNor.urls.Add(startUrlNor, false); //加入初始页面
            crawlerNor.CrawlNor();
            // new Thread(crawler.Crawl).Start(); //开始爬行
            stopwatch.Stop();
            Console.WriteLine("普通爬行方式用时" + stopwatch.ElapsedMilliseconds);
            stopwatch.Restart();
            Crawler crawlerPal = new Crawler();
            string startUrlPalPal = "http://www.cnblogs.com/dstang2000";
            crawlerPal.urls.Add(startUrlPalPal, false); //加入初始页面
            crawlerPal.CrawlNor();
            // new Thread(crawler.Crawl).Start(); //开始爬行
            stopwatch.Stop();
            Console.WriteLine("普通爬行方式用时" + stopwatch.ElapsedMilliseconds);

        }
        private void CrawlNor()
        {
            count = 0;
            Console.WriteLine("......开始爬行了......");
            lock (this)
            {
                while (true)
                {
                    string current = null;
                    //Parallel.ForEach(urls.Keys, () =>
                    //{

                    //}

                    //    );

                    foreach (string url in urls.Keys)
                    {
                        if ((bool)urls[url])
                        {
                            continue;
                        }
                        current = url;
                    }
                    if (current == null || count > 50)
                    {
                         break;
                    }
                    Console.WriteLine((count+1)+"爬行" + current + "页面！");
                    string html = DownLoad(current);    //下载
                    urls[current] = true;
                    count++;
                    ParseNor(html);
                }
            }
        }
        private void CrawlPal()
        {
            count = 0;
            Console.WriteLine("......开始爬行了......");
            lock (this)
            {
                while (true)
                {
                    string current = null;
                    //Parallel.ForEach(urls.Keys, () =>
                    //{

                    //}

                    //    );

                    foreach (string url in urls.Keys)
                    {
                        if ((bool)urls[url])
                        {
                            continue;
                        }
                        current = url;
                    }
                    if (current == null || count > 50)
                    {
                        break;
                    }
                    Console.WriteLine((count + 1) + "爬行" + current + "页面！");
                    string html = DownLoad(current);    //下载
                    urls[current] = true;
                    count++;
                    ParsePal(html);
                }
            }
        }

        public void ParseNor(string html)
        {
            lock (this)
            {
                string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
                MatchCollection matches = new Regex(strRef).Matches(html);      //strRef    要匹配的正则表达式模式。
                                                                                //创建一个MatchCollection用于存储匹配strRef的表达式，而匹配的源信息来自html;
                foreach (Match match in matches)
                {
                    //Substring，参数是一个int数据，从此实例检索子字符串。 子字符串在指定的字符位置开始并一直到该字符串的末尾。
                    //返回结果是    与此实例中在 startIndex 处开头的子字符串等效的一个字符串；如果 System.String.Empty 等于此实例的长度，则为 startIndex。
                    strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\'', '#', ' ', '>');
                    //Trim是string 中的函数，是删去一些内容 ，函数参数是一个char类型的数组
                    if (strRef.Length == 0)
                    {
                        continue;
                    }
                    if (urls[strRef] == null)
                    {
                        urls[strRef] = false;     //执行完这句后该hash table里有两个元素
                                                  //就是上一行，大概相当于一条添加语句
                    }
                }
            }
            
        }
        public void ParsePal(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);      //strRef    要匹配的正则表达式模式。
                                                                            //创建一个MatchCollection用于存储匹配strRef的表达式，而匹配的源信息来自html;

            List<Match> mat = new List<Match>();
            foreach (Match match in matches)
            {
                mat.Add(match);
            }
            Parallel.For(0, matches.Count, i =>
              {
                  strRef = matches[i].Value.Substring(matches[i].Value.IndexOf('=') + 1).Trim('"', '\'', '#', ' ', '>');
                  if (strRef.Length == 0)
                  {
                      //continue;
                  }
                  else if (urls[strRef] == null)
                  {
                      urls[strRef] = false;
                  }
              }
            );
        }
        public string DownLoad(string url)
        {
            lock (this)
            {
                try
                {
                    WebClient webClient = new WebClient
                    {
                        Encoding = Encoding.UTF8
                    };
                    string html = webClient.DownloadString(url);

                    string fileName = count.ToString() + ".html";
                    File.WriteAllText(fileName, html, Encoding.UTF8); // fileName 要写入的文件。html要写入文件的字符串,Encoding.UTF8应用于字符串的编码

                    return html;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "";
                }

            }
        }
    }
}
