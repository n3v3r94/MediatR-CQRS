using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SimelERP.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimelERP.Application.Test.Query.GetTest
{
    public class GetTestQueryHandler : MediatR.IRequestHandler<GetTestQuery, TestViewModel>
    {
        private readonly SimelERPDbContext db;
        private readonly IMapper mapper;

        public GetTestQueryHandler(SimelERPDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }



        public async Task<TestViewModel> Handle(GetTestQuery request, CancellationToken cancellationToken)
        {
            var test = mapper.Map<TestViewModel>(await db
                .TestERPs.Where(p => p.TestERPId  == request.Id)
                .SingleOrDefaultAsync(cancellationToken));

            if (test == null)
            {
                throw new NotFoundException(nameof(test), request.Id);
            }

            // TODO: Set view model state based on user permissions.
           

            return test;

        }
    }
}
