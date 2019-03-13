using Fizzler.Systems.HtmlAgilityPack;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Net;

namespace TrendRepoCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlDoc = new HtmlDocument();
            const string url = "https://github.com/trending";
            WebClient webClient = new WebClient();
            string htmlString = webClient.DownloadString(url);
            htmlDoc.LoadHtml(htmlString);

            var trendReposLiNode = htmlDoc.DocumentNode.QuerySelectorAll("ol.repo-list>li");

           
            int i =1;
            foreach (var li in trendReposLiNode)
            {
                var title = li.QuerySelector("div.d-inline-block>h3>a")?.Attributes["href"].Value ?? string.Empty;
                var desc = li.QuerySelector("div.py-1>p")?.InnerText.Trim() ?? string.Empty;
                var programLang = li.QuerySelector("[itemprop]")?.InnerText.Trim() ?? string.Empty;

                Console.WriteLine($"{i}. {title}");
                Console.WriteLine(desc);
                Console.WriteLine($"Lang:{programLang}");
                i++;
            }
            Console.ReadLine();
        }
    }
}
