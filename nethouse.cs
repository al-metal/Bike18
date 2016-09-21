using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Bike18
{
    class nethouse
    {
        public CookieContainer cookieNethouse(string login, string password)
        {
            CookieContainer cookie = new CookieContainer();
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create("https://nethouse.ru/signin");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:44.0) Gecko/20100101 Firefox/44.0";
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.CookieContainer = cookie;
            byte[] ms = Encoding.ASCII.GetBytes("login=" + login + "&password=" + password + "&quick_expire=0&submit=%D0%92%D0%BE%D0%B9%D1%82%D0%B8");
            req.ContentLength = ms.Length;
            Stream stre = req.GetRequestStream();
            stre.Write(ms, 0, ms.Length);
            stre.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            return cookie;
        }
    }
}
