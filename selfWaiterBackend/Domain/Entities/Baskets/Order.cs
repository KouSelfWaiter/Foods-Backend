using Core.Persistence.Entities;

namespace Domain.Entities.Baskets
{
    public class Order: ModelEntity
    {
        public string Note { get; set; }
        public string OrderCode { get; set; }
        public Basket Basket { get; set; }
        public bool IsCompleted { get; set; }
    }
}