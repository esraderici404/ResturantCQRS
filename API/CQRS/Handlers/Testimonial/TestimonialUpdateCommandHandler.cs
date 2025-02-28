using System;
using System.Collections.Generic;
using System.Linq;
using API.CQRS.Commands.testimonial;
using API.CQRS.Results.Testimonial;

using System.Threading.Tasks;
using Cqrs_dal.Context;
using MediatR;

namespace API.CQRS.Handlers.Testimonial
{
    public class TestimonialUpdateCommandHandler : IRequestHandler<TestimonialUpdateCommand, TestimonialUpdate>
    {
        private readonly ResutrantContext context;

        public TestimonialUpdateCommandHandler(ResutrantContext context)
        {
            this.context = context;
        }

        public async Task<TestimonialUpdate> Handle(TestimonialUpdateCommand request, CancellationToken cancellationToken)
        {
           var values = await context.Testimonials.FindAsync(request.TestimonialID);
          
            if (values == null)
            {

                return null;
            }


            values.TestimonialDescription = request.TestimonialDescription;
            values.TestimonialProfession = request.TestimonialProfession;   
            values.TestimonialNamesurname = request.TestimonialNamesurname;

            await context.SaveChangesAsync(); // Değişiklikleri kaydet

            var result = new TestimonialUpdate
            {
                TestimonialID = request.TestimonialID,
                TestimonialDescription = request.TestimonialDescription,
                TestimonialImage = request.TestimonialImage,
                TestimonialNamesurname = request.TestimonialNamesurname,
                TestimonialProfession = request.TestimonialProfession

            };

            return result;
        }
    }
}
