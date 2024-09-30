using SmartCities.Core.Models;

namespace SmartCitities.WebSite.ViewModels
{
    public class ContainerVM
    {
        public List<Product > Products { get; set; }
        public List<Team> Teams { get; set; }
        public int CountClients { get; set; }
        public int CountProjects { get; set; }

        public List<Project> projects { get; set; }
        public  Company company { get; set; }
        public List<Client> Clients { get; set; }

    }
}
