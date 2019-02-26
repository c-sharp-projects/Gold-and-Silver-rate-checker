using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornaments_Rate_Checker
{
    class Rate
    {
        public Rate()
        {

        }

        public String GoldRate(String Url)
        {
            String sRet = null;
            WebClient web = new WebClient();
            String html = web.DownloadString(Url);
            String data = html.Substring(html.LastIndexOf("<td>10 gram</td>"), 150);

            data = data.Replace("<td>", "");
            data = data.Replace("</td>", "");
            data = data.Replace(" ", "");
            data = data.Replace("&#8377;", "₹");
            String[] arr = data.Split('\n');
            sRet = arr[0] +" Today " + arr[1] + " Yesterday " + arr[2];

            return sRet;
        }

        public String SilverRate(String Url)
        {
            String sRet = null;
            WebClient web = new WebClient();
            String html = web.DownloadString(Url);
            String data = html.Substring(html.LastIndexOf("<td>1 Kg</td>"), 150);

            data = data.Replace("<td>", "");
            data = data.Replace("</td>", "");
            data = data.Replace(" ", "");
            data = data.Replace("&#8377;", "₹");
            String[] arr = data.Split('\n');
            sRet = arr[0] + " Today " + arr[1] + " Yesterday " + arr[2];

            return sRet;
        }
    }
}
