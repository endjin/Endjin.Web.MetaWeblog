namespace Endjin.Web.MetaWeblog.Integration.Specs.Helpers
{
    using System.Diagnostics;
    using System.IO;
    using System.Net.Http;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;

    using Endjin.Web.MetaWeblog.Domain.XmlRpc;

    public static class Print
    {
        public static void HttpRequestMessage(HttpRequestMessage request)
        {
            using (var stream = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof(RequestTop));
                RequestTop requestTop = request.Content.ReadAsAsync<RequestTop>().Result;
                serializer.Serialize(XmlWriter.Create(stream), requestTop);
                string message = Encoding.UTF8.GetString(stream.ToArray());
                Debug.WriteLine(message);
                stream.Flush();
            }
        }

        public static void HttpResponseMessage(HttpResponseMessage response)
        {
            var result = response.Content.ReadAsStringAsync().Result;
            Debug.WriteLine(result);
            //using (var stream = new MemoryStream())
            //{
            //    var result = response.Content.ReadAsAsync<T>().Result;

            //    var serializer = new XmlSerializer(typeof(T));
            //    serializer.Serialize(XmlWriter.Create(stream), result);
            //    string message = Encoding.UTF8.GetString(stream.ToArray());
            //    Debug.WriteLine(message);
            //    stream.Flush();
            //}
        }
    }
}