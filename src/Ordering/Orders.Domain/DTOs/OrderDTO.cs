using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Domain.DTOs
{
    public class OrderDTO
    {
        public Guid ProductId { get; set; }
        public Guid UserId { get; set; }
        public string PaymentType { get; set; }
        public string OrderStatus { get; set; }
    }
}
