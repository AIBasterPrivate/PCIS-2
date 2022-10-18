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

        public Book Book { get; set; } = null!;
        public LibraryUser LibraryUser { get; set; } = null!;
    }
}
