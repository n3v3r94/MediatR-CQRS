using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimelERP.Application.Test.Query.Commands
{
   public class UpdateTestCommand : IRequest
    {
        public int TestERPId { get; set; }

        public string Name { get; set; }

        public string Text { get; set; }
    }
}
