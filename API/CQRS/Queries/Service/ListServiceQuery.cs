using API.CQRS.Results.Service;
using MediatR;

namespace API.CQRS.Queries.Service
{
    public class ListServiceQuery : IRequest<List<ServiceResult>>
    {
    }
}
