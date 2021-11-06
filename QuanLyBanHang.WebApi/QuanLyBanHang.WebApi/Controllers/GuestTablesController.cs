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
    public class GuestTablesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GuestTablesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<GuestTable> Get()
        {
            return _context.GuestTables.ToList();
        }
    }
}
