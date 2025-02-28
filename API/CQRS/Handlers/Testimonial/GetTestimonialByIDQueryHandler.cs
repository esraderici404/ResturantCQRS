using API.CQRS.Queries.Testimonial;
using API.CQRS.Results.Testimonial;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Testimonial
{
    public class GetTestimonialByIDQueryHandler : IRequestHandler<GetTestimonialByIDQuery, TestimonialByIDResult>
    {
        private readonly ResutrantContext context;

        public GetTestimonialByIDQueryHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<TestimonialByIDResult> Handle(GetTestimonialByIDQuery request, CancellationToken cancellationToken)
        {
            var testimonial = await context.Testimonials.FindAsync(request.Id);
            
                return new TestimonialByIDResult
                {
                    TestimonialID = testimonial.TestimonialID,
                   TestimonialDescription = testimonial.TestimonialDescription,
                   TestimonialNamesurname = testimonial.TestimonialNamesurname,
                   TestimonialImage = testimonial.TestimonialImage,
                   TestimonialProfession = testimonial.TestimonialProfession
                };
           
        }
    }
}
