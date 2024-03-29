﻿using System;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.WebApi.Model
{
    public class ItemImage
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDelete { get; set; }
    }
}
