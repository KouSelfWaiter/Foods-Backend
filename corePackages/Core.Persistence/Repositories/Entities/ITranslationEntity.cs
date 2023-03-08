using Core.Applicaiton.Enums;
using Core.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories.Entities
{
    public interface ITranslationEntity:IEntity
    {
        public TranslationCode TranslationCode { get; set; }
    }
}
