using System.ComponentModel.DataAnnotations;

namespace PCIS_2
{
    internal class Author
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
    }
}
