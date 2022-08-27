using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSEventApp.Core.Base;
using TSEventApp.Core.IRepository.Base;
using TSWebApp.Infrastructure.Data;

namespace TSEventApp.Infrastructure.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly EventContext _eventContext;

        public Repository(EventContext eventContext)
        {
            this._eventContext = eventContext ?? throw new ArgumentNullException(nameof(eventContext)); ;
        }
    }
}
