using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.CQRS.Queries.CarQueries
{
    public class GetCarByIdOuery
    {
        public int Id { get; set; }

        public GetCarByIdOuery(int id)
        {
            Id = id;
        }
    }
}
