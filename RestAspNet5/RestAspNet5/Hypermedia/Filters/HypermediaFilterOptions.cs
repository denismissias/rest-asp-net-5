using System.Collections.Generic;

namespace RestAspNet5.Hypermedia
{
    public class HypermediaFilterOptions
    {
        public List<IResponse> ContentResponseList { get; set; } = new List<IResponse>();
    }
}