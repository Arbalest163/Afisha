using MediatR;

namespace Afisha.Application.Clients.Queries.GetClientList
{
    public class GetClientListQuery : IRequest<ClientListVm>
    {
        public string Query { get; set; }
    }
}
