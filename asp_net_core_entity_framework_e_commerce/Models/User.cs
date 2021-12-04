namespace asp_net_core_entity_framework_e_commerce.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string tel { get; set; }
        public string addressOne { get; set; }
        public string addressTwo { get; set; }
        public string profileImageUrl { get; set; }
        public Role userRole { get; set; }
    }
}
