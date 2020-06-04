﻿using Dermayon.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pos.Customer.WebApi.Application.Commands
{
    public class DeleteProductCommand : ICommand
    {
        public Guid ProductId{ get; set; }
    }
}
