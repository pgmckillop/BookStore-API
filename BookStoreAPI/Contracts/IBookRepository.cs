using BookStoreAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI.Contracts
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
    }
}
