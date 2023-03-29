using Domain.R;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.OrgType
{
    public class List
    {
        public class Query : IRequest<List<ROrgType>> { }

        public class Handler : IRequestHandler<Query, List<ROrgType>>
        {
            public readonly AppDbContext _context ;
            public Handler(AppDbContext context)
            {
                _context = context;
            }

            public async Task<List<ROrgType>> Handle(Query request, CancellationToken cancellationToken)
            {
                return  await _context.ROrgType.ToListAsync();
            }
        }
    }
}