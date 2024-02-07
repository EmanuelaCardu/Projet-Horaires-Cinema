using System;
using System.Collections.Generic;
using System.Text;

namespace Shared_Projet_Cinema.Repositories
{
    public interface IDiffusionRepository<Entity>: ICRUDRepository<Entity, int> where Entity : class
    {
    }
}
