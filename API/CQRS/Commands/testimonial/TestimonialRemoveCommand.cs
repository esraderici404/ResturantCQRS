using MediatR;

namespace API.CQRS.Commands.testimonial
{
    public class TestimonialRemoveCommand : IRequest
    {
        public TestimonialRemoveCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
