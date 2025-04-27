using BootCampProject.Core;
using BootCampProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCampProject.Repositories
{
    public interface IApplicantRepository : IRepository<Applicant>, IAsyncRepository<Applicant>
    {
    }
}
