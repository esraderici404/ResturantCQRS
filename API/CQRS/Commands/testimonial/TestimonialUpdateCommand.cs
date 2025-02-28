using API.CQRS.Results.Testimonial;
using Cqrs_dal.CQRS.Results.Food;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.CQRS.Commands.testimonial
{
    public class TestimonialUpdateCommand : IRequest<TestimonialUpdate>
    {
        public int TestimonialID { get; set; }
        public string TestimonialNamesurname { get; set; }
        public string TestimonialDescription { get; set; }
        public string TestimonialProfession { get; set; }
        public string? TestimonialImage { get; set; }
    }
}
