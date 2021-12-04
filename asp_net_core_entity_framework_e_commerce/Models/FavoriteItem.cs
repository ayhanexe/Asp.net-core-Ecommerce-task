namespace asp_net_core_entity_framework_e_commerce.Models
{
    public class FavoriteItem
    {
        public int id { get; set; }
        public Product productId { get; set; }
        public Favorite favoriteId { get; set; }
    }
}
