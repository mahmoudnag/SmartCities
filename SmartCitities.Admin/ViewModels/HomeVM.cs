using Azure.Core;
using SmartCities.Core.Models;

namespace SmartCitities.Admin.ViewModels
{
    public class HomeVM
    {
        public Company Company { get; set; }
        public List<ProjectVM> Projects { get; set; }
        public List<ContactRequests> Requests { get; set; }

    }
}
