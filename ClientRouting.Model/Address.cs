using BaseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRouting.Model
{
    public class Address :BaseObject
    {
        public string StreetName { get; set; }
        public string City { get; set; }
        public Jurisdiction Jurisdiction { get; set; }
    }
}
