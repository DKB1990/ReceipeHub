using ChefDheeraj.Database.Interfaces;
using ChefDheeraj.Database.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ChefDheeraj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReceipeController : ControllerBase
    {
        private readonly IRepository<Receipe> _chefRepository;
        private readonly ILogger<ReceipeController> _logger;

        public ReceipeController(ILogger<ReceipeController> logger, IRepository<Receipe> chefRepository)
        {
            _logger = logger;
            _chefRepository = chefRepository;
        }

        [HttpGet]
        public IList<Receipe> GetAll()
        {
            try
            {
                return _chefRepository.GetAllAsync().Result.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("GetById")]
        public Receipe GetById(string receipeId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(receipeId))
                    throw new ArgumentException("Bad Request");

                Expression<Func<Receipe, bool>> expression = x => x.Id == receipeId;
                return _chefRepository.GetByIdAsync(expression).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public Receipe Save([FromBody] Receipe receipe)
        {
            try
            {
                if (receipe == null) throw new ArgumentException("Bad Request");
                return _chefRepository.SaveAsync(receipe).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
