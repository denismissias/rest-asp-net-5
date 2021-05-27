using System.Collections.Generic;

namespace RestAspNet5.Mapper
{
    public interface IMapper<From, To>
    {
        To Map(From from);

        List<To> Map(List<From> from);
    }
}