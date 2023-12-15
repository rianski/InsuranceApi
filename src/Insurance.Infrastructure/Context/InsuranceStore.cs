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
    }
}
