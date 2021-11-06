using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyBanHang.WebApi.Data;
using QuanLyBanHang.WebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyBanHang.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsIamgesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemsIamgesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<ItemImage> Get()
        {
            return _context.ItemImages.ToList();
        }
    }
}
