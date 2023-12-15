using Insurance.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Infrastructure.Context
{
    public static class InsuranceStore
    {
        public static IEnumerable<Company> InMemoryCompanies { get; } = new List<Company>
        {
            new Company {
                Id = 1,
                Name = "Linde",
                Address1 = "Harrogate Road",
                Address2 = "Apartment 115",
                Address3 = "Eccleshill",
                Postcode = "BD2 3HD",
                Country = "England",
                InsuranceEndDate = new DateTime(2025, 2, 1),
                Active = true
            },
            new Company {
                Id = 2,
                Name = "Criteo",
                Address1 = "90 Rue Victor Hugo",
                Address2 = "Corbeil-essonnes",
                Address3 = "lle-de-France",
                Postcode = "91100",
                Country = "France",
                Active = false,
                InsuranceEndDate = new DateTime(2022, 3, 5)
            },
            new Company {
                Id = 3,
                Name = "Allianz",
                Address1 = "Paderborner Strasse 17",
                Address2 = "Gackenbach",
                Address3 = "Rheinland-Pfalz",
                Postcode = "56412",
                Country = "Germany",
                Active = true,
                InsuranceEndDate = new DateTime(2024, 7, 20)
            },
        };

        public static IList<Claim> InMemoryClaims { get; } = new List<Claim>
        {
            new Claim
            {
                UCR = "DS-1234",
                CompanyId = 1,
                ClaimDate = new DateTime(2023, 11, 1),
                LossDate = new DateTime(2023, 10, 25),
                AssuredName = "Admiral",
                IncurredLoss = 18000,
                Closed = false
            },
            new Claim
            {
               UCR = "GC-1324",
               CompanyId = 1,
               ClaimDate = new DateTime(2023, 12, 1),
               LossDate = new DateTime(2023, 11, 5),
               AssuredName = "Admiral",
               IncurredLoss = 23250,
               Closed = false
            },
            new Claim
            {
               UCR = "DS-2134",
               CompanyId = 2,
               ClaimDate = new DateTime(2023, 12, 1),
               LossDate = new DateTime(2023, 11, 5),
               AssuredName = "Macif",
               IncurredLoss = 750,
               Closed = false
            },
            new Claim
            {
               UCR = "DS-3124",
               CompanyId = 3,
               ClaimDate = new DateTime(2023, 9, 1),
               LossDate = new DateTime(2023, 7, 3),
               AssuredName = "AOK",
               IncurredLoss = 500,
               Closed = false
            },
            new Claim
            {
               UCR = "GC-3214",
               CompanyId = 3,
               ClaimDate = new DateTime(2023, 10, 1),
               LossDate = new DateTime(2023, 9, 7),
               AssuredName = "AOK",
               IncurredLoss = 10000,
               Closed = false
            },
            new Claim
            {
                UCR = "GC-3421",
                CompanyId = 3,
                ClaimDate = new DateTime(2022, 5, 9),
                LossDate = new DateTime(2022, 5, 1),
                AssuredName = "AOK",
                IncurredLoss = 200,
                Closed = true
            },
        };

        public static IEnumerable<ClaimType> InMemoryClaimTypes { get; } = new List<ClaimType>
        {
            new ClaimType {Id = 1, Name = "General Claims"},
            new ClaimType {Id = 2, Name = "Death In Service"},
            new ClaimType {Id = 3, Name = "Natural Disaster"}
        };
    }
}
