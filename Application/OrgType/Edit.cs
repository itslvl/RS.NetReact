using AutoMapper;
using Domain.R;
using MediatR;
using Persistence;

namespace Application.OrgType
{
    public class Edit
    {
        public class Command : IRequest
        {
            public ROrgType ROrgType { get; set; }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly AppDbContext _context;
            private readonly IMapper _mapper;
            public Handler(AppDbContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var r = await _context.ROrgType.FindAsync(request.ROrgType.Id);
                // r.Definition = request.ROrgType.Definition ?? r.Definition;
                _mapper.Map(request.ROrgType, r);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }
        }
    }
}