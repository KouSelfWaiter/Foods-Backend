using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Entities
{
    public class Entity:IEntity
    {

        public Guid Id { get; set; }    
    }
}
