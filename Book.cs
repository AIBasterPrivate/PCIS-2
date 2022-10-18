using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS_2
{
    internal class Book
    {
        public int ID { get; set; }
        public string BookName { get; set; } = null!; 
        public int AuthorID { get; set; }
        public float Price { get; set; }
    }
}
