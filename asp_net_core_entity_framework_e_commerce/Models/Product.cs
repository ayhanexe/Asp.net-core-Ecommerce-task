namespace asp_net_core_entity_framework_e_commerce.Models
{
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Brand brandId { get; set; }
        public Category categoryId { get; set; }
    }
}
