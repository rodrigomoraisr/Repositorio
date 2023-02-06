using Entities.Entitities;
using Infrastructure.Repository.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryProduct : RepositoryGenerics<Produto>, IProduto
    {
    }
}
