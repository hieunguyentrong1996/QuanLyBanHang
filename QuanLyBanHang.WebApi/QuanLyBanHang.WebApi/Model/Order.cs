using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanHang.WebApi.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int OrderNumber { get; set; }
        public int Description { get; set; }
        public bool Voided { get; set; }
        public double TotalPrice { get; set; }
        public double PaidAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
        public virtual IList<OrderItem> OrderItem { get; set; }
    }
}
