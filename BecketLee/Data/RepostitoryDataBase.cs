namespace BecketLee.Data
{
    public abstract class RepostitoryDataBase<T> 
    {
        protected BecketLeeDbContext _context;

        public RepostitoryDataBase(BecketLeeDbContext context)
        {
            _context = context;
        }


    }

}