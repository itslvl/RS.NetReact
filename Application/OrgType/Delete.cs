using MediatR;
using Persistence;

namespace Application.OrgType
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
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
                var r = await _context.ROrgType.FindAsync(request.Id);
                _context.Remove(r);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}