using System.Threading;
using System.Threading.Tasks;
using MediatR;


namespace MediatRExample.Queries
{
    public class GetLotInformationHandler : IRequestHandler<GetLotInformationQuery, GetLotInformationResponse>
    {
        public async Task<GetLotInformationResponse> Handle(GetLotInformationQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new GetLotInformationResponse() 
            {
                CustId="TEST"
            });
        }
    }
}