using asp_net_core_entity_framework_e_commerce.Models;
using System.Collections.Generic;

namespace asp_net_core_entity_framework_e_commerce.viewModels
{
    public class HomeIndexViewModel
    {
        public List<Product> products { get; set; }
        public List<User> users { get; set; }
        public List<Role> roles { get; set; }
        public List<Category> categories { get; set; }
        public List<Brand> brands { get; set; }
    }
}
