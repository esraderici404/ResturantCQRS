using API.CQRS.Results.Service;
using MediatR;

namespace API.CQRS.Queries.Service
{
    public class GetServiceByIDQuery : IRequest<ServiceByIDResult>
    {
        public GetServiceByIDQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
