using System.Collections.Generic;

namespace RestAspNet5.Hypermedia
{
    public class HyperMediaLink
    {
        private string href;

        public string Rel { get; set; }

        public string Href 
        { 
            get
            {
                object _lock = new object();
                lock(_lock)
                {
                    return href.Replace("%2F", "/");
                }
            }
            set
            {
                href = value;
            }
        }

        public string Type { get; set; }

        public string Action { get; set; }
    }
}