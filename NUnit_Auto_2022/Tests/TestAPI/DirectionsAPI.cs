using NUnit.Framework;
using NUnit_Auto_2022.Utilities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NUnit_Auto_2022.Tests.TestAPI
{
    class DirectionsAPI
    {
        RestClient client = new RestClient();
        
        string to = "Mangalia";
        string from = "Bucharest";
        //string url = "http://www.mapquestapi.com/directions/v2/route?key=F77jGMkbkE9nGW2K4OGSMfisLOtmVC78&to=Mangalia&from=Bucharest";

        private string GetUrl(string queryParams)
        {
            return String.Format("{0}{1}", FrameworkConstants.GetApiUrl(), queryParams);
        }

        private static IEnumerable<TestCaseData> GetRequestData()
        {
            string path = "TestData\\TestDataAPI\\directionsData.csv";
            var lines = File.ReadAllLines(path).Select(a => a.Split(','));
            string[] header = lines.ElementAt(0).ToArray();
            for (int i = 1; i < lines.Count(); i++)
            {
                var currentValues = lines.ElementAt(i).ToArray();
                Dictionary<string, string> queryParams = new Dictionary<string, string>();
                for (int j = 0; j < currentValues.Count(); j++)
                {
                    queryParams.Add(header[j], currentValues[j]);
                }
                yield return new TestCaseData(queryParams);
            }
        }

        [Test, TestCaseSource("GetRequestData")]
        public void Test01(Dictionary<string, string> queryParams)
        {
            string url = GetUrl(Utils.ConvertDictionaryToQuery(queryParams));
            var request = new RestRequest(url, Method.Get);
            var response = client.GetAsync(request);
            var responseContent = response.Result.Content;
            //Console.WriteLine(responseContent);
            //Console.WriteLine(Utils.Decrypt(FrameworkConstants.apikeyEncrypt+"==","btauto2022"));
            Console.WriteLine(url);
        }
    }
}
