using Insurance.Infrastructure.Context;
using Insurance.Infrastructure.Entities;
using Insurance.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        public CompanyRepository()
        {
            CompanyCollection = InsuranceStore.InMemoryCompanies;
        }

        IEnumerable<Company> CompanyCollection { get; }

        public Company GetCompany(int id) => CompanyCollection.SingleOrDefault(x => x.Id == id);
    }
}
