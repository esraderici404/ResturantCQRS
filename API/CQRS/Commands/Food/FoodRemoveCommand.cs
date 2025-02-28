using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cqrs_dal.CQRS.Commands
{
    public class FoodRemoveCommand : IRequest
    {
        public FoodRemoveCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
