using MapsterMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechnicalChallenge.Application.Contracts.Persistence;
using TechnicalChallenge.Application.Models;

namespace TechnicalChallenge.Application.Features.Orders.Queries
{
    public class GetOrdersListQueryHandler : IRequestHandler<GetOrdersListQuery, OrderResponse>
    {
        private readonly IOrderRepositoryAsync _orderRepositoryAsync;
        private readonly IMapper _mapper;

        public GetOrdersListQueryHandler(IOrderRepositoryAsync orderRepository, IMapper mapper)
        {
            _orderRepositoryAsync = orderRepository;
            _mapper = mapper;
        }

        public async Task<OrderResponse> Handle(GetOrdersListQuery request, CancellationToken cancellationToken)
        {
            var orderList = await _orderRepositoryAsync.GetOrderByIdAsync(request.OrderId);
            return _mapper.Map<OrderResponse>(orderList);
        }
    }
}
