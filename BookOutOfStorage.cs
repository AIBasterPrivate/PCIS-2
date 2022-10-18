using Microsoft.EntityFrameworkCore;

namespace PCIS_2
{
    [Keyless]
    internal class BookOutOfStorage
    {
        public int BookID { get; set; }
        public int LibraryUserID { get; set; }
        public DateTime TakeAwayTime { get; set; }
        public DateTime GiveAwayTime { get; set; }
        public bool IsReturned { get; set; }
    }
}
