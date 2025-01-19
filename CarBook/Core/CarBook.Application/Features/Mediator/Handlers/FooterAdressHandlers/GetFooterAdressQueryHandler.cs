﻿using CarBook.Application.Features.Mediator.Queries.FooterAdressQueries;
using CarBook.Application.Features.Mediator.Results.FooterAdressResults;
using CarBook.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace CarBook.Application.Features.Mediator.Handlers.FooterAdressHandlers
{
    public class GetFooterAdressQueryHandler : IRequestHandler<GetFooterAdressQuery, List<GetFooterAdressQueryResult>>
    {
        private readonly IRepository<FooterAdress> _repository;

        public GetFooterAdressQueryHandler(IRepository<FooterAdress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAdressQueryResult>> Handle(GetFooterAdressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFooterAdressQueryResult
            {
                Adress = x.Adress,
                Description = x.Description,
                FooterAdressId = x.FooterAdressId,
                Mail = x.Mail,
                Phone = x.Phone
            }).ToList();    
        }
    }
}
