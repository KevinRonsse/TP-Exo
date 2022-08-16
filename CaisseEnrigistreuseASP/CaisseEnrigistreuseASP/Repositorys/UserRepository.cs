using CaisseEnrigistreuseASP.Models;
using CaisseEnrigistreuseASP.Services;

namespace CaisseEnrigistreuseASP.Repositorys
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DataContextService dataContextService) : base(dataContextService)
        {

        }

        public override bool Add(User entity)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public override User Find(Func<User, bool> predicate)
        {
            return _dataContextService.Users.ToList().FirstOrDefault(u => predicate(u));
        }

        public override List<User> FindAll(Func<User, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
