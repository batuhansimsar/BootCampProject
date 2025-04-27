using BootCampProject.Entities;

namespace BootCampProject.Repositories
{
    public class InstructorRepository : EfRepositoryBase<Instructor>, IInstructorRepository
    {
        public InstructorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
