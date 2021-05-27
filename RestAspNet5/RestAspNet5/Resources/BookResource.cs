using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAspNet5.Resources
{
    public class BookResource
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime LaunchDate { get; set; }
    }
}