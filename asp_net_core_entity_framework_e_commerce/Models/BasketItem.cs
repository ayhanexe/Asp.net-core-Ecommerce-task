namespace asp_net_core_entity_framework_e_commerce.Models
{
    public class BasketItem
    {
        public int id { get; set; }
        public Product productId { get; set; }
        public Basket basketId { get; set; }
    }
}
