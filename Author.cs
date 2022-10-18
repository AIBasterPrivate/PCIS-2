using System.ComponentModel.DataAnnotations;

namespace PCIS_2
{
    internal class Author
    {
        [Key]
        public int ID { get; set; }
        public string firstname { get; set; } = null!;
        public string lastname { get; set; } = null!;
    }
}
