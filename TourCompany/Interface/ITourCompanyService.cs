using TourCompany.Models;

namespace TourCompany.Interface
{
    public interface ITourCompanyService
    {
        Task Add(PontosTuristicos pontosTuristico);

        Task Update(PontosTuristicos pontosTuristico);

        Task Delete(PontosTuristicos pontosTuristico);

        Task<PontosTuristicos> GetBy(Guid id);

        Task<List<PontosTuristicos>> FindAll();
    }
}
