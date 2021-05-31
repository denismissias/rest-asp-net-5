using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RestAspNet5.Hypermedia
{
    public interface IResponse
    {
        bool CanFormat(ResultExecutingContext context);

        Task Format(ResultExecutingContext context);
    }
    
}