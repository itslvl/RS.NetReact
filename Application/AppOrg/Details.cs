using Application.Core;
using Domain;
using MediatR;
using Persistence;

namespace Application.AppOrg
{
    public class Details
    {
        public class Query : IRequest<Result<Org>>
        {
            public Guid Id { get; set; }
        }
        public class Handler : IRequestHandler<Query, Result<Org>>
        {
            private readonly AppDbContext _context;
            public Handler(AppDbContext context)
            {
                _context = context;
            }

            public async Task<Result<Org>> Handle(Query request, CancellationToken cancellationToken)
            {
                var ret = await _context.Org.FindAsync(request.Id);
                return Result<Org>.Success(ret);
                // if (ret == null) return NotFound(); 
                // return ret;

            }
        }
    }
}