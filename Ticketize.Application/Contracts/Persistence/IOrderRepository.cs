﻿using Ticketize.Domain.Entities;

namespace Ticketize.Application.Contracts.Persistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
