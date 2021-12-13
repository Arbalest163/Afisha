using Afisha.Application.Interfaces;
using AutoMapper;
using MediatR;
using System;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Afisha.Application.Common.Exceptions;
using Afisha.Domain;

namespace Afisha.Application.Clients.Queries.GetClientList
{
    public class GetClientListQueryHandler
        : IRequestHandler<GetClientListQuery, ClientListVm>
    {
        private readonly IAfishaDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetClientListQueryHandler(IAfishaDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<ClientListVm> Handle(GetClientListQuery request,
            CancellationToken cancellationToken)
        {
            if (request.Query != null)
            {
                var clientQuery = await _dbContext.Clients
                        .Where(p => p.FirstName.Contains(request.Query, StringComparison.OrdinalIgnoreCase) ||
                                p.LastName.Contains(request.Query, StringComparison.OrdinalIgnoreCase) ||
                                p.MiddleName.Contains(request.Query, StringComparison.OrdinalIgnoreCase))
                        .ProjectTo<ClientDto>(_mapper.ConfigurationProvider)
                        .ToListAsync(cancellationToken);
                if (clientQuery.Count == 0)
                {
                    throw new NotFoundException(nameof(Client), request.Query);
                }
                return new ClientListVm { Clients = clientQuery };
            }
            else
            {
                var clientAll = await _dbContext.Clients
                        .ProjectTo<ClientDto>(_mapper.ConfigurationProvider)
                        .ToListAsync(cancellationToken);

                return new ClientListVm { Clients = clientAll };
            }
        }
    }
}
