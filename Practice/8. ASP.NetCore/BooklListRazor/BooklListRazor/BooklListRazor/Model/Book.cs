using System.ComponentModel.DataAnnotations;

namespace BooklListRazor.Model
{
    public class Book
    {
        [Key]
        public  int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Auther { get; set; }

        public string ISBN { get; set; }

    }
}
