using System.ComponentModel.DataAnnotations;

namespace PCIS_2
{
    internal class Book
    {
        [Key]
        public int Id { get; set; }
        public string BookName { get; set; } = null!; 
        public int AuthorId { get; set; }
        public double Price { get; set; }

        public Author Author { get; set; } = null!;
    }
}
