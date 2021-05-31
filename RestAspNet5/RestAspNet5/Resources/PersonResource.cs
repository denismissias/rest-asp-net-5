using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RestAspNet5.Hypermedia;

namespace RestAspNet5.Resources
{
    public class PersonResource : ISupportHypermedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }
        
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}