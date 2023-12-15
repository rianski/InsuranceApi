using Insurance.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Core.Interfaces
{
    public interface ICompanyService
    {
        CompanyDTO GetCompany(int id);
    }
}
