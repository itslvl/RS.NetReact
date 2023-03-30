using Application.Core;
using Domain.R;
using MediatR;
using Persistence;

namespace Application.OrgType
{
    public class Details
    {
        public class Query : IRequest<Result<ROrgType>>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Result<ROrgType>>
        {
            private readonly AppDbContext _context;
            public Handler(AppDbContext context)
            {
                _context = context;
            }

            public async Task<Result<ROrgType>> Handle(Query request, CancellationToken cancellationToken)
            {
                var ret = await _context.ROrgType.FindAsync(request.Id);
                return Result<ROrgType>.Success(ret);
                // if (ret == null) return NotFound(); 
                // return ret;

            }
        }
    }
}