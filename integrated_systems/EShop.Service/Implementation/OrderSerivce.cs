﻿using EShop.Domain.Domain;
using EShop.Repository.Interface;
using EShop.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public List<Order> getAllOrders()
        {
            return this._orderRepository.getAllOrders();
        }

        public Order getOrderDetails(BaseEntity model)
        {
            return this._orderRepository.getOrderDetails(model);
        }
    }
}
