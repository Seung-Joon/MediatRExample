using MediatR;

namespace MediatRExample.Queries
{
    public class GetLotInformationQuery : IRequest<GetLotInformationResponse>
    {
        public string LotId {get; set;}
    }
}