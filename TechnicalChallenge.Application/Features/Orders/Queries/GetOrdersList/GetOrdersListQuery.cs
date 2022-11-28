using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TechnicalChallenge.Application.Models;

namespace TechnicalChallenge.Application.Features.Orders.Queries
{
    public class GetOrdersListQuery : IRequest<OrderResponse>
    {
        public int OrderId { get; set; }

        public GetOrdersListQuery(int orderId)
        {
            OrderId = orderId;
        }
    }
}
