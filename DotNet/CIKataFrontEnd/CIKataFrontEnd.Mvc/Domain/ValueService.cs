using System;
using System.Net.Http;

namespace CIKataFrontEnd.Mvc.Domain
{
    public class ValueService
    {
        public string GetValueFromApi()
        {
            var returnValue = string.Empty;

            using (var client = new HttpClient())
            {
                HttpResponseMessage response = null;

                try
                {
                    response = client.GetAsync("http://localhost:8001/api/values").Result;
                }
                catch (Exception e)
                {
                    return $"That did NOT Work! Message: {e.Message}";
                }

                returnValue = response.Content.ReadAsStringAsync().Result;
            }

            return returnValue;
        }
    }
}