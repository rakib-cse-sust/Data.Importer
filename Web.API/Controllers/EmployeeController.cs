using Application.Contracts.Infrastructure;
using Application.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public EmployeeController(
            ILogger<EmployeeController> logger,
            IRepositoryWrapper repository,
            IMapper mapper)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllEmployee")]
        public async Task<IActionResult> Get()
        {
            var employees = await _repository.Employee.GetAll();
            return Ok(_mapper.Map<List<EmployeeViewModel>>(employees));
        }
    }
}