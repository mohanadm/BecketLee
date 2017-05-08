using System.Collections.Generic;
using BecketLee.Models;

namespace BecketLee.Data
{
    public abstract class RepositoryBase<T>
    {
        protected BecketLeeContext _context;

        public RepositoryBase(BecketLeeContext context)
        {
            _context = context;
        }

        public abstract IEnumerable<T> Get();
    }
}