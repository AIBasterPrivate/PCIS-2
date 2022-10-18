using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCIS_2
{
    internal class BookOutOfStorage
    {
        public int BookID { get; set; }
        public int LibraryUserID { get; set; }
        public DateTime TakeAwayTime { get; set; }
        public DateTime GiveAwayTime { get; set; }
        public bool IsReturned { get; set; }
    }
}
