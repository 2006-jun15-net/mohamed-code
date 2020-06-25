using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Serialization
{
    class Program
    {
        static async void Main(string[] args)
        {
            List<playerStats> data;


            string filePath = "../../../data.json";

            try
            {
                string initialJson = File.ReadAllText(filePath);
                data = JsonConvert.DeserializeObject<List<playerStats>>(initialJson);
            }
            catch (FileNotFoundException)
            {
                data = GetInitialData();
            }




            string json = ConvertToJson(data);
            WriteStringToFileAsync(filePath, json);
        }

        public async static void WriteStringToFileAsync(string filePath, string json)
        {
            FileStream fileStream = null;
            try
            {

                //File.WriteAllText(filePath, json);
                fileStream = new FileStream(filePath, FileMode.Create);

            }
            catch (IOException ex)
            {
                Console.WriteLine($"error writing file: {ex.Message}");
            }
            finally
            {
               fileStream?.Dispose();
            }

        }

        public static string ConvertToJson(List<playerStats> data)
        {
            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        private static List<playerStats> GetInitialData()
        {
            return new List<playerStats>
            {
                new playerStats()
                {
                    Name = "Lebron James",
                    FreeThrowPercentage = 65,
                    PointsPerGame = 25,
                    ArcLocations = new Dictionary<int, double>
                    {
                        [-150] = 30,
                        [-120] = 30,
                        [-90] = 30
                    }
                },
                new playerStats()
                {
                    Name = "Lebron James",
                    FreeThrowPercentage = 65,
                    PointsPerGame = 25,
                    ArcLocations = new Dictionary<int, double>
                    {
                        [-150] = 30,
                        [-120] = 30,
                        [-90] = 30
                    }
                },
                new playerStats()
                {
                    Name = "Lebron James",
                    FreeThrowPercentage = 65,
                    PointsPerGame = 25,
                    ArcLocations = new Dictionary<int, double>
                    {
                        [-150] = 30,
                        [-120] = 30,
                        [-90] = 30
                    }
                },
            };
        }
    }
}
