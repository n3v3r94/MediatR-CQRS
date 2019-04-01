using MediatR;

namespace SimelERP.Application.Test.Query.GetTest
{
    public class GetTestQuery : IRequest<TestViewModel>
    {
        public int Id { get; set; }

    }
}
