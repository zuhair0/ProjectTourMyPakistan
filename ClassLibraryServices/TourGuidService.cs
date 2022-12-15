using ClassLibraryModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryServices
{
    public class TourGuidService : ITourGuidService
    {
        private readonly HttpClient _httpClient;

        public TourGuidService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<List<TourGuideRegistrationModel>> GetTourGuides()
        {
            return await _httpClient.GetFromJsonAsync<List<TourGuideRegistrationModel>>("api/TourGuide/GetTourGuides");
        }

        public async Task<TourGuideRegistrationModel> SaveTourGuide()
        {
            return await _httpClient.GetFromJsonAsync<TourGuideRegistrationModel>("api/TourGuide/SaveTourGuide");
        }
    }
}
