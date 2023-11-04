using ProjectPractice.Domain.Entities.Public;
using ProjectPractice.Domain.Interfaces.Repositories.Public;
using ProjectPractice.Infrastructure.Repositories.Generic;

namespace ProjectPractice.Infrastructure.Repositories.Public
{
    public class UserRepository: NPRepository<User, int>, IUserRepository 
    {
        private readonly FirstContext _context;
        public UserRepository(FirstContext context) :base(context) {
            _context = context;
        }
    }
}
