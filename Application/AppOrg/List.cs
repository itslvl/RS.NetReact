using System.Text.Json;
using System.Text.Json.Serialization;
using Application.Core;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;
using AutoMapper.QueryableExtensions;

namespace Application.AppOrg
{
    public class List
    {
        public class Query : IRequest<Result<List<OrgDto>>> { }

        public class Handler : IRequestHandler<Query, Result<List<OrgDto>>>
        {
            private readonly AppDbContext _context;
            private readonly IMapper _mapper;
            public Handler(AppDbContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Result<List<OrgDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                var r = await _context.Org
                    .ProjectTo<OrgDto>(_mapper.ConfigurationProvider)
                    .ToListAsync(cancellationToken);


                // var destination = source.AsQueryable()
                //     .ProjectTo<DestinationClass>(mapper.ConfigurationProvider)
                //     .ToList();



                return Result<List<OrgDto>>.Success(r);


                // var orders = await _dbContext.Orders
                // .Include(o => o.OrderItems)
                // .Where(o => o.OrderNumber.StartsWith("ORD"))
                // .ProjectTo<OrderDto>(_mapper.ConfigurationProvider)
                // .ToListAsync();


                // return Result<List<Org>>.Success(await _context.Org.Include(o => o.OrgType).ToListAsync(cancellationToken));
            }
        }
    }
}