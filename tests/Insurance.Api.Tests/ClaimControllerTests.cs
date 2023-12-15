using Insurance.Api.Controllers;
using Insurance.Core.Interfaces;
using Insurance.Core.Models;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace Insurance.Api.Tests
{
    public class ClaimControllerTests
    {
        public ClaimControllerTests()
        {
            Controller = new ClaimController(ClaimService);
        }

        private ClaimController Controller { get; }

        private IClaimService ClaimService { get; }
            = Substitute.For<IClaimService>();

        [Fact]
        public void GetClaimsForCompany_ReturnsOkResponse()
        {
            // Arrange
            int companyId = 1;

            ClaimService.GetCompanyClaims(companyId).Returns(
                new List<ClaimDTO> {
                    new ClaimDTO(
                    "TS-1234",
                    companyId,
                    new DateTime(),
                    new DateTime(),
                    "test4",
                    1,
                    true)
                }
               );

            // Act
            var response = Controller.GetClaimsForCompany(companyId);

            // Assert
            Assert.IsType<OkObjectResult>(response);
        }

        [Fact]
        public void GetClaimsForCompany_ReturnsNotFoundResponse()
        {
            // Arrange
            int companyId = 1;

            // Act
            var response = Controller.GetClaimsForCompany(companyId);

            // Assert
            Assert.IsType<NotFoundObjectResult>(response);
        }

        [Fact]
        public void GetClaimForCompany_ReturnsOkResponse()
        {
            // Arrange
            int companyId = 1;
            string ucr = "TS-1234";

            ClaimService.GetCompanyClaim(companyId, ucr).Returns(new ClaimDTO(
                ucr,
                companyId,
                new DateTime(),
                new DateTime(),
                "test4",
                1,
                true));

            // Act
            var response = Controller.GetClaimForCompany(companyId, ucr);

            // Assert
            Assert.IsType<OkObjectResult>(response);
        }

        [Fact]
        public void GetClaimForCompany_ReturnsNotFoundResponse()
        {
            // Arrange
            int companyId = 1;
            string ucr = "TS-1234";

            // Act
            var response = Controller.GetClaimForCompany(companyId, ucr);

            // Assert
            Assert.IsType<NotFoundObjectResult>(response);
        }
    }
}
