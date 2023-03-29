using Domain.R;
using MediatR;
using Persistence;

namespace Application.OrgType
{
    public class Create
    {
        public class Command :  IRequest 
        {
            public ROrgType ROrgType { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly AppDbContext _context;
            public Handler(AppDbContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.ROrgType.Add(request.ROrgType);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}