using System.ComponentModel.DataAnnotations;

namespace PCIS_2
{
    internal class LibraryUser
    {
        [Key]
        public int ID { get; set; }
        public int PersonID { get; set; }
    }
}
