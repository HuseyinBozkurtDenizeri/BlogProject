using BlogProject.Models.Entities.Concrrete;

namespace BlogProject.WEB.Models.VMs
{
    public class GetProfileVM
    {
        // AppUSer için
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }

        // Article için
        public List<Article> Articles { get; set; }

        // Category için
        public List<Category> Categories { get; set; }

    }
}
