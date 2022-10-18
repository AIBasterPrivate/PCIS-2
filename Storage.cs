using Microsoft.EntityFrameworkCore;

namespace PCIS_2
{
    [Keyless]
    internal class Storage
    {
        public int BookId { get; set; }
        public int AbsoluteAmount { get; set; }
        public int CurrentAmount { get; set; }

        public Book Book { get; set; } = null!;
    }
}
