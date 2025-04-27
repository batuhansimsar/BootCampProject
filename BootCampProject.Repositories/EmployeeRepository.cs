using BootCampProject.Entities;

namespace BootCampProject.Repositories
{
    public class EmployeeRepository : EfRepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
