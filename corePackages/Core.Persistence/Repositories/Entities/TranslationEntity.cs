using Core.Applicaiton.Enums;
using Core.Persistence.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories.Entities
{
    public class TranslationEntity<TModel> : Entity, ITranslationEntity
        where TModel : IModelEntity
    {
    
        public Guid RelationId { get; set; }
        public TModel Relation { get; set; }
        public TranslationCode TranslationCode { get; set; }

    }
}
