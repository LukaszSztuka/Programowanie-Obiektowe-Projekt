using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
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
            string ipAddress = getIP();
            string strReturnVal;
            string ipResponse = getIPRequest("http://ip-api.com/xml/" + ipAddress);

            XmlDocument ipInfoXML = new XmlDocument();
            ipInfoXML.LoadXml(ipResponse);
            XmlNodeList responseXML = ipInfoXML.GetElementsByTagName("query");

            NameValueCollection dataXML = new NameValueCollection();

            dataXML.Add(responseXML.Item(0).ChildNodes[5].InnerText, responseXML.Item(0).ChildNodes[4].Value);

            strReturnVal = responseXML.Item(0).ChildNodes[5].InnerText.ToString(); // 5 element XML - miasto

            return strReturnVal;
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
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }

    }
}
