using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Play.Catalog.Service.Entities
{
    public interface IEntity
    {
        Guid Id { get; init; }

    }
}