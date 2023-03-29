using Domain.R;
using MediatR;
using Persistence;

namespace Application.OrgType
{
    public class Details
    {
        public class Query : IRequest<ROrgType>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, ROrgType>
        {
            private readonly AppDbContext _context;
            public Handler(AppDbContext context)
            {
                _context = context;
            }

            public async Task<ROrgType> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.ROrgType.FindAsync(request.Id);
            }
        }
    }
}