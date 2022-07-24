using Microsoft.EntityFrameworkCore;
using TourCompany.Data;
using TourCompany.Interface;
using TourCompany.Models;

namespace TourCompany.Services
{
    public class TourCompanyService : ITourCompanyService
    {
        private readonly AppDbContext dbContext;

        public TourCompanyService(AppDbContext appDbContext)
        {
            dbContext = appDbContext;
        }

        public async Task Add(PontosTuristicos pontosTuristico)
        {
            await dbContext.AddAsync(pontosTuristico);
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(PontosTuristicos pontosTuristico)
        {
            dbContext.Update(pontosTuristico);
            await dbContext.SaveChangesAsync();
        }

        public async Task Delete(PontosTuristicos pontosTuristico)
        {
            dbContext.Remove(pontosTuristico);
            await dbContext.SaveChangesAsync();
        }

        public async Task<PontosTuristicos> GetBy(Guid id)
        {
            var pontosTuristico = await dbContext.PontosTuristicos.FirstOrDefaultAsync(c => c.Id == id);

            return pontosTuristico;
        }

        public async Task <List<PontosTuristicos>> FindAll()
        {
            var pontosTuristicos = await dbContext.PontosTuristicos.ToListAsync();

            return pontosTuristicos;
        }
    }
}
