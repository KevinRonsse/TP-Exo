using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Tools;
using Microsoft.EntityFrameworkCore;

namespace BankEntityFrameWork.Repositories
{
    public class AccountRepository : BaseRepository<Account>
    {
        public AccountRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public override bool Create(Account element)
        {
            _dataContext.Accounts.Add(element);
            return _dataContext.SaveChanges() > 0;
        }

        public override bool Delete(Account element)
        {
            throw new NotImplementedException();
        }

        public override Account Find(Predicate<Account> predicate)
        {
            return _dataContext.Accounts.Include(p => p.Customer).Include(c => c.Operations).ToList().FirstOrDefault((e) => predicate(e));
        }

        public override List<Account> FindAll(Predicate<Account> predicate)
        {
            return _dataContext.Accounts.Include(p => p.Customer).Include(c => c.Operations).Where((e) => predicate(e)).ToList();
        }

        public override bool Update()
        {
            return _dataContext.SaveChanges() > 0;
        }
    }
}