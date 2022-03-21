using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperLibrary.Models
{
    public class Dct_Docent
    {
        public int CampusNr { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public Campus Campus { get; set; }

        public override string ToString()
        {
            return $"{CampusNr} {Voornaam} { Familienaam} {Campus} ";
        }
    }
}
