using Application.Core;
using AutoMapper;
using Domain.R;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.OrgType
{
    public class Edit
    {
        public class Command : IRequest<Result<Unit>>
        {
            public ROrgType ROrgType { get; set; }
        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(a => a.ROrgType).SetValidator(new OrgTypeValidator());
            }
        }
        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly AppDbContext _context;
            private readonly IMapper _mapper;
            public Handler(AppDbContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var r = await _context.ROrgType.FindAsync(request.ROrgType.Id);
                if (r == null) return null;
                // r.Definition = request.ROrgType.Definition ?? r.Definition;
                _mapper.Map(request.ROrgType, r);
                var ret = await _context.SaveChangesAsync() > 0;
                if (!ret) return Result<Unit>.Failure("Fail to update organization type");
                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}