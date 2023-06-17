using Application.AppValidator;
using Application.Core;
using AutoMapper;
using Domain;
using DomainDto;
using FluentValidation;
using MediatR;
using Persistence;

namespace Application.AppAgama
{
    public class Edit
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Agama Agama { get; set; }
        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(a => a.Agama).SetValidator(new AgamaValidator());
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
                var r = await _context.Agama.FindAsync(request.Agama.Id);
                if (r == null) return null;
                // r.Kode = request.Agama.Kode;
                // r.Deleted = request.Agama.Deleted;
                // r.Uraian = request.Agama.Uraian;
                // r.TimeStamp = request.Agama.TimeStamp;
                // r.Definition = request.ROrgType.Definition ?? r.Definition;
                // Agama r1 = _mapper.Map<r>(request.Agama);
                // AgamaDto A = new AgamaDto();
                // _mapper.Map(request.Agama, r, opt => opt.Ignore(x => x.Uraian));
                // _context.Agama.Update(request.Agama);
                // Object.Assign(r, request.Agama);
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Agama, Agama>();
                });
                var mapper = new Mapper(config);

                // // Melakukan pemetaan nilai properti
                mapper.Map(request.Agama, r) ;
                _context.Agama.Update(r);

                var ret = await _context.SaveChangesAsync() > 0;
                if (!ret) return Result<Unit>.Failure("Fail to update organization");
                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}