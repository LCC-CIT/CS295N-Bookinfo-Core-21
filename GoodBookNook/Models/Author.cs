using System;
using System.ComponentModel.DataAnnotations;

namespace GoodBookNook.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
