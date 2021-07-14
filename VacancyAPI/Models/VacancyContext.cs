using Microsoft.EntityFrameworkCore;

namespace VacancyAPI.Models
{
    public class VacancyContext : DbContext
    {
        public VacancyContext(DbContextOptions<VacancyContext> options)
            : base(options)
        {
            
        }

        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ActiveVacancy> ActiveVacancies { get; set; }
    }
}