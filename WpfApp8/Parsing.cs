using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8
{
    class Parsing
    {
        private WebResponse response;
        private WebRequest request;
        private string site;
        private string adress = "https://zvooq.pro/artists/";
        private List<string> name = new List<string>();
        private List<string> url = new List<string>();

        public string getSite(string nameSound)
        {
            request = WebRequest.Create(adress + nameSound);
            response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            site = reader.ReadToEnd();
            response.Close();
            return site;
        }

        public List<string> generationList()
        {
            name.Clear();
            int index = 0;
            while (index != -1)
            {
                index = site.IndexOf("data-title");
                if (index != -1)
                {
                    site = site.Remove(0, index + 12);
                    name.Add(site.Remove(site.IndexOf("\"")));
                }
            }
            return name;
        }
    }
}
