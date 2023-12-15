using Insurance.Api.Controllers;
using Insurance.Core.Interfaces;
using Insurance.Core.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using Xunit;

namespace Insurance.Api.Tests
{
    public class CompanyControllerTests
    {
        public CompanyControllerTests()
        {
            Controller = new CompanyController(CompanyService);
        }

        private CompanyController Controller { get; }

        private ICompanyService CompanyService { get; }
            = Substitute.For<ICompanyService>();

        [Fact]
        public void Get_ReturnsOkResponse()
        {
            // Arrange
            int id = 1;

            CompanyService.GetCompany(id).Returns(new CompanyDTO(
                1,
                "test",
                "test2",
                "test3",
                "test4",
                "test5",
                "test 6",
                true, new DateTime()));

            // Act
            var response = Controller.Get(id);

            // Assert
            Assert.IsType<OkObjectResult>(response);
        }

        [Fact]
        public void Get_ReturnsNotFoundResponse()
        {
            // Arrange
            int id = 1;

            // Act
            var response = Controller.Get(id);

            // Assert
            Assert.IsType<NotFoundObjectResult>(response);
        }
    }
}