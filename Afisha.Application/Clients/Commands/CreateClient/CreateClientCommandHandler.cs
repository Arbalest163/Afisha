using Afisha.Application.Interfaces;
using Afisha.Domain;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Afisha.Application.Clients.Commands.CreateClient
{
    public class CreateClientCommandHandler
        : IRequestHandler<CreateClientCommand, Guid>
    {
        private readonly IAfishaDbContext _dbContext;
        public CreateClientCommandHandler(IAfishaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = new Client
            {
                Id = Guid.NewGuid(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                MiddleName = request.MiddleName,
                Birthday = request.Birthday,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };

            await _dbContext.Clients.AddAsync(client, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);
            return client.Id;
        }
    }
}
