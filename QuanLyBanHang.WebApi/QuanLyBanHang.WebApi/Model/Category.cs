using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.WebApi.Model
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
