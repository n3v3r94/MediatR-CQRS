using MediatR;
using Microsoft.EntityFrameworkCore;
using SimelERP.Application.Test.Query.GetTest;
using SimelERP.Persistence;
using SimerERP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimelERP.Application.Test.Query.Commands
{
    public class UdateTestCommandHandler : IRequestHandler<UpdateTestCommand, Unit>
    {

        private readonly SimelERPDbContext db;

        public UdateTestCommandHandler (SimelERPDbContext db)
        {
            this.db = db;
        }

        public async Task<Unit> Handle(UpdateTestCommand request, CancellationToken cancellationToken)
        {
            var test = await db.TestERPs.SingleAsync(x => x.TestERPId == request.TestERPId, cancellationToken);

            if (test == null)
            {
                throw new NotFoundException(nameof(TestERP), request.TestERPId);
            }

            test.Name = request.Name;
            test.Text = request.Text;

            db.TestERPs.Update(test);

            await db.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
