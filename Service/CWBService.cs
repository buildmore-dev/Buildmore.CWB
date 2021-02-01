using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using HtmlAgilityPack;
using Newtonsoft.Json;

using Buildmore.Model;
using Buildmore.Entity;

namespace Buildmore.CWB.Service
{
    public class CWBService : ICWBService
    {
        private readonly ILogger logger;

        public CWBService()
        {
        }


        public CWBService(ILogger<CWBService> logger)
        {
            this.logger = logger;
        }


        public async Task<IList<DataItemForCWB>> Get(string cityId)
        {
            string baseUrl = @"https://opendata.cwb.gov.tw/api/v1/rest/datastore/F-D0047-{0}?Authorization=CWB-7EDEA68D-9A46-4B11-AD46-BB533D540ED7&format=JSON&elementName=T,RH&sort=time";
            IList<DataItemForCWB> result = new List<DataItemForCWB>();

            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(string.Format(baseUrl, cityId));
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Temperture data = JsonConvert.DeserializeObject<Temperture>(responseBody);

                if (data.Records != null && data.Records.Locations.Count > 0)
                {
                    foreach (LocationElement item in data.Records.Locations[0].Location)
                    {
                        // 行政區
                        DataItemForCWB temp = new DataItemForCWB();
                        temp.Country = "台灣";
                        temp.City = data.Records.Locations[0].LocationsName;
                        temp.Station = item.LocationName;

                        foreach (WeatherElement item2 in item.WeatherElement)
                        {
                            switch (item2.ElementName)
                            {
                                // 溫度
                                case "T":
                                    if (item2.Time.Count > 0 && item2.Time[0].ElementValue.Count > 0)
                                    {
                                        temp.DataTime = item2.Time[0].DataTime;
                                        temp.TemperatureC = item2.Time[0].ElementValue[0].Value;
                                    }
                                    break;

                                // 濕度
                                case "RH":
                                    if (item2.Time.Count > 0 && item2.Time[0].ElementValue.Count > 0)
                                    {
                                        temp.DataTime = item2.Time[0].DataTime;
                                        temp.Humidity = Convert.ToInt32(item2.Time[0].ElementValue[0].Value);
                                    }
                                    break;


                                // 舒適指數
                                case "CI":


                                    break;


                                // 六小時降雨機率
                                case "PoP6h":
                                    if (item2.Time.Count > 0 && item2.Time[0].ElementValue.Count > 0)
                                    {
                                        temp.DataTime = item2.Time[0].DataTime;
                                        temp.RainFall = Convert.ToInt32(item2.Time[0].ElementValue[0].Value);
                                    }
                                    break;

                            }
                        }
                        result.Add(temp);

                    }
                }


                

            }
            catch (Exception e)
            {
                logger.LogError(e.Message);
            }

            return result;

        }
    }
}
