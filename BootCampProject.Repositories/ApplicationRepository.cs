using BootCampProject.Entities;

namespace BootCampProject.Repositories
{
    public class ApplicantRepository : EfRepositoryBase<Applicant>, IApplicantRepository
    {
        public ApplicantRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
