using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;

namespace RestAspNet5.Hypermedia
{
    public abstract class ContentResponse<T> : IResponse where T : ISupportHypermedia
    {
        public ContentResponse() { }

        protected abstract Task FormatModel(T content, IUrlHelper urlHelper);

        public bool CanFormat(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult okObjectResult)
                return CanFormat(okObjectResult.Value.GetType());

            return false;
        }
        
        public async Task Format(ResultExecutingContext context)
        {
            var urlHelper = new UrlHelperFactory().GetUrlHelper(context);

            if (context.Result is OkObjectResult okObjectResult)
            {
                if (okObjectResult.Value is T model)
                    await FormatModel(model, urlHelper);
                else if (okObjectResult.Value is List<T> collection)
                {
                    ConcurrentBag<T> bag = new ConcurrentBag<T>(collection);
                    Parallel.ForEach(bag, (element) =>
                    {
                        FormatModel(element,urlHelper);
                    });
                }
            }
            await Task.FromResult<object>(null);
        }

        private bool CanFormat(Type contentType)
        {
            return contentType == typeof(T) || contentType == typeof(List<T>);
        }
    }
}