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
    public class RolesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RolesController(ApplicationDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Get All List Roles
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Role> Get()
        {
            return _context.Roles.ToList();
        }

        /// <summary>
        /// Get Role By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Id")]
        public Role Get([FromQuery] int id)
        {
            return _context.Roles.Where(s => s.Id == id).FirstOrDefault();
        }
        /// <summary>
        /// Add New Role
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        [HttpPost]
        public Role Post([FromForm] Role role)
        {
            _context.Add(role);
            _context.SaveChanges();
            return role;
        }

    }
}
