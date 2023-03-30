using Application.Core;
using Domain.R;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.OrgType
{
    public class List
    {
        public class Query : IRequest<Result<List<ROrgType>>> { }

        public class Handler : IRequestHandler<Query, Result<List<ROrgType>>>
        {
            public readonly AppDbContext _context ;
            public Handler(AppDbContext context)
            {
                _context = context;
            }

            public async Task<Result<List<ROrgType>>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Result<List<ROrgType>>.Success(await _context.ROrgType.ToListAsync(cancellationToken));
            }
        }
    }
}