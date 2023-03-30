using Application.Core;
using Domain.R;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.OrgType
{
    public class Create
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
            public Handler(AppDbContext context)
            {
                _context = context;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                _context.ROrgType.Add(request.ROrgType);
                var ret = await _context.SaveChangesAsync() > 0;
                if (!ret) return Result<Unit>.Failure("Fail to create Organization Type");
                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}