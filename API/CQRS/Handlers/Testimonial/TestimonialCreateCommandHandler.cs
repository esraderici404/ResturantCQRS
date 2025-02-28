using API.CQRS.Commands.testimonial;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Testimonial
{
    public class TestimonialCreateCommandHandler : IRequestHandler<TestimonialCreateCommand>
    {
        private readonly ResutrantContext context;

        public TestimonialCreateCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task Handle(TestimonialCreateCommand request, CancellationToken cancellationToken)
        {
            context.Testimonials.Add(new Dal.Testimonial
            {
                TestimonialDescription = request.TestimonialDescription,
                TestimonialImage = request.TestimonialImage,
                TestimonialNamesurname = request.TestimonialNamesurname,
                TestimonialProfession = request.TestimonialProfession
            });
          await   context.SaveChangesAsync();
        }
    }
}
