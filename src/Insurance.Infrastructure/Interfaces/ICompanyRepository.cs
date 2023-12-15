using Insurance.Infrastructure.Entities;

namespace Insurance.Infrastructure.Interfaces
{
    public interface ICompanyRepository
    {
        Company GetCompany(int id);
    }
}
