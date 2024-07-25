using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincraAssessment.TestUtils
{
    public class JsonReader
    {
        public string GetTestData(string tokenKey)
        {
            string JsonFile = File.ReadAllText(ConfigurationManager.AppSettings["testDataFilePath"]);

            var JsonObject = JToken.Parse(JsonFile);

            return JsonObject.SelectToken(tokenKey).Value<string>();

        }

    }
}
