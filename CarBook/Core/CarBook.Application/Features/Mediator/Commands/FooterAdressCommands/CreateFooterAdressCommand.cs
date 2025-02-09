﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Features.Mediator.Commands.FooterAdressCommands
{
    public class CreateFooterAdressCommand :IRequest
    {
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
    }
}
