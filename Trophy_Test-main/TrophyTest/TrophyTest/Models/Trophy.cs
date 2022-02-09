using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace TrophyTest.Models
{
    public class Trophy
    {
        public int Id { get; set; }

        public int Year { get; set; }
        public string? Sport { get; set; }

        public string? Division { get; set; }

        public string? Place { get; set; }

        public string? Class { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Trophy>(this);
           
        

    }

    //"Year": 1999,
    //"Sport": "Baseball",
    //"Division": "Clarence Cannon Conference",
    //"Place": "Champions",
    //"Class": "Boys"

}
