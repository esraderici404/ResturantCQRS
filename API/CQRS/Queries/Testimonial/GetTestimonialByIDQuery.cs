using API.CQRS.Results.Testimonial;
using Cqrs_dal.CQRS.Results.Food;
using MediatR;

namespace API.CQRS.Queries.Testimonial
{
    public class GetTestimonialByIDQuery : IRequest<TestimonialByIDResult>
    {
        public GetTestimonialByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
