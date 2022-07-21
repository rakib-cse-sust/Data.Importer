using Application.Contracts.Infrastructure;
using Application.Exceptions;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;
        private readonly ICsvImporter _csvImporter;

        public ImportController(
            ILogger<EmployeeController> logger,
            IRepositoryWrapper repository,
            IMapper mapper,
            ICsvImporter csvImporter)
        {
            _logger = logger;
            _repository = repository;
            _mapper = mapper;
            _csvImporter = csvImporter;
        }

        [HttpPost(Name = "ImportData")]
        public async Task<ActionResult> Post([FromBody] string filepath)
        {
            if (filepath == null)
                throw new NotFoundException("File path");

            var data = _csvImporter.GetImportedData(filepath);

            await _repository.Organisation.AddRange(_mapper.Map<List<Organisation>>(data.Organisations));
            await _repository.Employee.AddRange(_mapper.Map<List<Employee>>(data.Employees));

            return Ok();
        }
    }
}
