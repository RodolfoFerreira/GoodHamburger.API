﻿using GoodHamburger.Domain.DTO.OrderProduct;

namespace GoodHamburger.Domain.DTO.Order
{
    public record UpdateOrderDto
    {
        public int Id { get; set; }
        public string CustomerName { get; set; } = string.Empty;
        public List<CreateOrderProductDto> OrderProducts { get; set; } = [];
    }
}
