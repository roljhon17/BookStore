using System;
using System.Threading.Tasks;

namespace Acme.BookStore.Authors
{
    internal interface IAuthorRepository
    {
        Task GetAsync(Guid id);
    }
}