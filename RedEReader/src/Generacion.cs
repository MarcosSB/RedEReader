using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace RedEReader
{
    class Generacion
    {
        public static string GetGeneracion()
        {
            string url = RedEConstants.BaseUrl + "/" + RedEConstants.lang+ "/datos/generacion/estructura-generacion?start_date=2019-01-01T00:00&end_date=2019-01-31T22:00&time_trunc=day";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try
            {
                using (WebResponse response = request.GetResponse())
                {
                    using (Stream strReader = response.GetResponseStream())
                    {
                        if (strReader == null) return string.Empty;
                        using (StreamReader objReader = new StreamReader(strReader))
                        {
                            string responseBody = objReader.ReadToEnd();
                            return responseBody;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Handle error
                return string.Empty;
            }
        }
    }
}
