using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RestAspNet5.Hypermedia
{
    public class HypermediaFilter : ResultFilterAttribute
    {
        private readonly HypermediaFilterOptions _hypermediaFilterOptions;

        public HypermediaFilter(HypermediaFilterOptions hypermediaFilterOptions)
        {
            _hypermediaFilterOptions = hypermediaFilterOptions;
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            FormatResult(context);
            base.OnResultExecuting(context);
        }

        private void FormatResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult objectResult)
            {
                var formatter = _hypermediaFilterOptions.ContentResponseList.FirstOrDefault(r => r.CanFormat(context));

                if (formatter != null)
                {
                    Task.FromResult(formatter.Format(context));
                }
            }
        }
    }
}