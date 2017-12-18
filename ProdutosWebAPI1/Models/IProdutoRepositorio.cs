using System.Collections.Generic;

namespace ProdutosWebAPI.Models
{
    public interface IProdutoRepositorio
    {
        IEnumerable<Produto> All { get; }
        Produto Find(int id);
        void Insert(Produto item);
        void Update(Produto item);
        void Delete(int id);
    }
}
