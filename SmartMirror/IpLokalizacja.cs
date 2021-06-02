using System;
using System.Net;
using System.IO;
using System.Xml;
using System.Collections.Specialized;

namespace SmartMirror
{
    public class IpLokalizacja
    {
        public string getMiasto()
        {
            string ipAdres = getIP();
            string Miasto;
            string output = getIPRequest("http://ip-api.com/xml/" + ipAdres);

            XmlDocument ipInfoXML = new XmlDocument();
            ipInfoXML.LoadXml(output);
            XmlNodeList responseXML = ipInfoXML.GetElementsByTagName("query");

            NameValueCollection dataXML = new NameValueCollection();

            dataXML.Add(responseXML.Item(0).ChildNodes[5].InnerText, responseXML.Item(0).ChildNodes[4].Value);

            Miasto = responseXML.Item(0).ChildNodes[5].InnerText.ToString(); // 5 element XML - miasto

            return Miasto;
        }

        public string getIPRequest(string url)
        {

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();

            StreamReader responseStream = new StreamReader(objResponse.GetResponseStream());
            string responseRead = responseStream.ReadToEnd();

            responseStream.Close();
            responseStream.Dispose();

            return responseRead;
        }

        public string getIP()
        {
            String adres = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                adres = stream.ReadToEnd();
            }

            int first = adres.IndexOf("Address: ") + 9;
            int last = adres.LastIndexOf("</body>");
            adres = adres.Substring(first, last - first);

            return adres;
        }

    }
}
