using ProjectPractice.Domain.Entities.Public;
using ProjectPractice.Domain.Interfaces.Repositories.Public;
using ProjectPractice.Infrastructure.Repositories.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPractice.Infrastructure.Repositories.Public
{
    public class BrandRepository : NPRepository<Brand, int>, IBrandRepository
    {
        private readonly FirstContext _context;
        public BrandRepository(FirstContext context) : base(context) {
            _context = context; 
        }
    }
}
