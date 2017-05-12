namespace BecketLee.Data
{
    public abstract class RepostitoryDataBase<T> 
    {
        protected BecketLeeContext _context;

        public RepostitoryDataBase(BecketLeeContext context)
        {
            _context = context;
        }


    }

}