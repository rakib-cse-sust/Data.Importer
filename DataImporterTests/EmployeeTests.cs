using System;
using Xunit;
using Moq;
using Domain.Entities;
using Application.Contracts.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace DataImporterTests
{
    public class EmployeeTests
    {
        private readonly Mock<IRepositoryBase<Employee>> _mockEmployeeRepository;

        public EmployeeTests()
        {
            _mockEmployeeRepository = new Mock<IRepositoryBase<Employee>>();
        }

        [Fact]
        public void Add_Emplyee_Success()
        {
            var employeeGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var employees = new List<Employee>
            {
                new Employee
                {
                    Id = employeeGuid,
                    FirstName = "Rakib",
                    LastName ="Khan",
                    OrganisationNumber="B0788D2F"
                }
            };

            _mockEmployeeRepository.Setup(repo => repo.GetAll())
                .ReturnsAsync(employees);

            var result = _mockEmployeeRepository.Object.GetAll().Result.Count();

            Assert.Equal(1, result);
        }
    }
}
