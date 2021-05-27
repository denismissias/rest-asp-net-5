using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAspNet5.Model
{
    [Table("books")]
    public class Book : Entity
    {        
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }
}