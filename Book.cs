using System.ComponentModel.DataAnnotations;

namespace PCIS_2
{
    internal class Book
    {
        [Key]
        public int ID { get; set; }
        public string BookName { get; set; } = null!; 
        public int AuthorID { get; set; }
        public float Price { get; set; }

        public Author Author { get; set; } = null!;
    }
}
