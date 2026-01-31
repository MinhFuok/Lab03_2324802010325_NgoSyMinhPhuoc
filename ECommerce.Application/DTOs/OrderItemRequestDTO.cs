using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Application.DTOs
{
    public class OrderItemRequestDTO
    {
        [Required]
        public int ProductId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng ít nhất phải là 1.")]
        public int Quantity { get; set; }
    }
}