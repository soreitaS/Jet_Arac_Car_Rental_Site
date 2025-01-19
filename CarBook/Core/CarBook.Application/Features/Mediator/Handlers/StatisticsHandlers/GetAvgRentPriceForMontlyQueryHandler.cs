using CarBook.Application.Features.Mediator.Queries.StatisticsQueries;
using CarBook.Application.Features.Mediator.Results.StatisticsResults;
using CarBook.Application.Interfaces.StatisticsInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetAvgRentPriceForMontlyQueryHandler : IRequestHandler<GetAvgRentPriceForMontlyQuery, GetAvgRentPriceForMontlyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAvgRentPriceForMontlyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAvgRentPriceForMontlyQueryResult> Handle(GetAvgRentPriceForMontlyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAvgRentPriceForMontly();
            return new GetAvgRentPriceForMontlyQueryResult
            {
                AvgRentPriceForMontly = value
            };
        }
    
    }
}
