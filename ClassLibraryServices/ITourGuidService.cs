using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel; 

namespace ClassLibraryServices
{
    public interface ITourGuidService
    {

        Task<TourGuideRegistrationModel> SaveTourGuide();
        Task<List<TourGuideRegistrationModel>> GetTourGuides();
    }
}
