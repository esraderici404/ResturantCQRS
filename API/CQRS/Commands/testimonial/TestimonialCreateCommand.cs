using MediatR;

namespace API.CQRS.Commands.testimonial
{
    public class TestimonialCreateCommand : IRequest
    {
        public string TestimonialNamesurname { get; set; }
        public string TestimonialDescription { get; set; }
        public string TestimonialProfession { get; set; }
        public string? TestimonialImage { get; set; }
    }
}
