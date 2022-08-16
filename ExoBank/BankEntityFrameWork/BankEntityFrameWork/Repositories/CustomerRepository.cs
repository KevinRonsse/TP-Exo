using BankEntityFrameWork.Classes;
using BankEntityFrameWork.Tools;

namespace BankEntityFrameWork.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public CustomerRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public override bool Create(Customer element)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(Customer element)
        {
            throw new NotImplementedException();
        }

        public override Customer Find(Predicate<Customer> predicate)
        {
            throw new NotImplementedException();
        }

        public override List<Customer> FindAll(Predicate<Customer> predicate)
        {
            throw new NotImplementedException();
        }

        public override bool Update()
        {
            throw new NotImplementedException();
        }
    }
}
