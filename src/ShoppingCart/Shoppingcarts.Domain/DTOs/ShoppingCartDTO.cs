using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppingcarts.Domain.DTOs
{
    public class ShoppingCartDTO
    {
        public string CartName { get; set; }
        public string Photo { get; set; }
        public string Price { get; set; }
        public DateTimeOffset DateOfManufacture { get; set; }
        public DateTimeOffset ExpirationDate { get; set; }
    }
}
