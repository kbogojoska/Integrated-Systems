﻿using EShop.Domain.Domain;
using EShop.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Repository.Implementation
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Order> entities;
        string errorMessage = string.Empty;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Order>();
        }
        public List<Order> getAllOrders()
        {
            return entities
                .Include(z => z.Owner)
                .Include(z => z.ProductInOrders)
                .Include("ProductInOrders.OrderedProduct")
                .ToListAsync().Result;
        }

        public Order getOrderDetails(BaseEntity model)
        {
            return entities
               .Include(z => z.Owner)
               .Include(z => z.ProductInOrders)
               .Include("ProductInOrders.OrderedProduct")
               .SingleOrDefaultAsync(z => z.Id == model.Id).Result ?? throw new Exception("Order not found");
        }
    }
}
