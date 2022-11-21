using System.ComponentModel.DataAnnotations;

namespace PCIS_2
{
    internal class Person
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string? Middlename { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public DateTime Birthday { get; set; }
        public string PhoneNumber { get; set; } = null!;
    }
}
