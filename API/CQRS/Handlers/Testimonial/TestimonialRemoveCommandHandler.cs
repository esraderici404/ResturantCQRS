using API.CQRS.Commands.testimonial;
using Cqrs_dal.Context;
using Cqrs_dal.CQRS.Commands;
using MediatR;

namespace API.CQRS.Handlers.Testimonial
{
    public class TestimonialRemoveCommandHandler : IRequestHandler<TestimonialRemoveCommand>
    {
        private readonly ResutrantContext context;

        public TestimonialRemoveCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task Handle(TestimonialRemoveCommand request, CancellationToken cancellationToken)
        {
            var value = await context.Testimonials.FindAsync(request.Id);
            if (value == null)
            {
                context.Testimonials.Remove(value);
                await context.SaveChangesAsync();
            }
           
        }
       
    }
}

