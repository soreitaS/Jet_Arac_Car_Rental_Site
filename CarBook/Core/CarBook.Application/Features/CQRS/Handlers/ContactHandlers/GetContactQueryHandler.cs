﻿using CarBook.Application.Features.CQRS.Results.BrandResults;
using CarBook.Application.Features.CQRS.Results.ContactResults;
using CarBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace CarBook.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetContactQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactQueryResult
            {
                ContactID = x.ContactID,
                Name = x.Name,
                SendDate = x.SendDate,
                Subject = x.Subject,
                Message = x.Message,
                Email = x.Email
            }).ToList();
        }
    }
}
