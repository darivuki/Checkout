﻿using Domain.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Persistence
{
    public interface IOrderRepository : IRepository<Order>
    {
    }
}
