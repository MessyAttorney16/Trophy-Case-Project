using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using TrophyTest.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;




namespace TrophyTest.Services
{
    public class JsonFileTrophyService
    {
        public JsonFileTrophyService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "Json", "Master.json"); }
        }

        public IEnumerable<Trophy> GetTrophys()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Trophy[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true

                    });


            }
                



        }


    }
}
