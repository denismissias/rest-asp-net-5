using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RestAspNet5.Hypermedia
{
    public interface ISupportHypermedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
    
}