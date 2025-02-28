using API.CQRS.Results.Testimonial;
using Cqrs_dal.CQRS.Results.Food;
using MediatR;

namespace API.CQRS.Queries.Testimonial
{
    public class ListTestimonialQuery : IRequest<List<TestimonialResult>>
    {

    }
}
