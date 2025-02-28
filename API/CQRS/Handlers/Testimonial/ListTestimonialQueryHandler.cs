using API.CQRS.Queries.Testimonial;
using API.CQRS.Results.Testimonial;
using Cqrs_dal.Context;
using Cqrs_dal.CQRS.Queries.food;
using Cqrs_dal.CQRS.Results.Food;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace API.CQRS.Handlers.Testimonial
{
    public class ListTestimonialQueryHandler : IRequestHandler<ListTestimonialQuery, List<TestimonialResult>>
    {
        private readonly ResutrantContext context;

        public ListTestimonialQueryHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<List<TestimonialResult>> Handle(ListTestimonialQuery request, CancellationToken cancellationToken)
        {
            return await context.Testimonials.Select(x => new TestimonialResult
            {
                TestimonialID = x.TestimonialID,
                TestimonialDescription = x.TestimonialDescription,
                TestimonialNamesurname = x.TestimonialNamesurname,
                TestimonialProfession = x.TestimonialProfession,
                TestimonialImage = x.TestimonialImage
            }).ToListAsync();
        }
    }
}
