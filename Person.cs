using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS_2
{
    internal class Person
    {
        public int ID { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Middlename { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public DateTime Birthsday { get; set; }
        public string PhoneNumber { get; set; } = null!;
    }
}
