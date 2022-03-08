using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Inesia
{
    [Serializable]
    public class MovieStar
    {
        public DateTime? dateOfBirth { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Sex { get; set; }
        public string? Nationality { get; set; }

        public void actor()
        {
            DateTime currentDate = DateTime.Now;
            DateTime bday = Convert.ToDateTime(this.dateOfBirth);
            Console.WriteLine(this.Name + " " + this.Surname);
            Console.WriteLine(this.Sex);
            Console.WriteLine(this.Nationality);
            Console.WriteLine(currentDate.Year - bday.Year);
        }
    }
}