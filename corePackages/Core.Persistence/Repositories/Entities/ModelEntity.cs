using Core.Persistence.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Entities
{
    public class ModelEntity<TTranslation> : Entity, IModelEntity
        where TTranslation : ITranslationEntity
    {

        public ModelEntity()
        {
            Translations = new List<TTranslation>();
        }


        public virtual List<TTranslation> Translations { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
    public class ModelEntity : Entity, IModelEntity
    {
      

        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
