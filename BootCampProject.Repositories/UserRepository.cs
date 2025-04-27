using BootCampProject.Entities;

namespace BootCampProject.Repositories
{
    public class UserRepository : EfRepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
