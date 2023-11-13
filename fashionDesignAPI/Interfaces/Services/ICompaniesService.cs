using fashionDesign.Dto.Companies.Request;
using fashionDesign.Dto.Companies.Response;

namespace fashionDesign.Interfaces.Services
{
    public interface ICompaniesService
    {
        Task<CompaniesResponse> CreateAsync(PostCompanies company);
        Task<CompaniesResponse> UpdateAsync(int id, PutCompanies company);
        Task<bool> DeleteAsync(int id);
        Task<CompaniesResponse> GetByIdAsync(int id);
    }
}
