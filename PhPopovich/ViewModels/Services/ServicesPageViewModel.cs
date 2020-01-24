using System.Collections.Generic;
using PhPopovich.Models;
using PhPopovich.Models.Pages;
using PhPopovich.ViewModels.Common;

namespace PhPopovich.ViewModels.Services
{
    public class ServicesPageViewModel : PartialPageViewModel<ServicesPageModel>
    {
        public ServicesPageViewModel()
        {
            
        }

        public ServicesPageViewModel(ServicesPageModel servicesPageModel) : base(servicesPageModel)
        {
            
        }
        
        public List<ServiceModel> ServiceModels { get; set; }
    }
}
