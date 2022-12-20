using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibraryModel;
using ClassLibraryDAL;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourGuideController : ControllerBase
    {
        [HttpGet]
        [Route("GetTourGuides")]
        public async Task<JsonResult> GetTourGuides()
        {
            List<TourGuideRegistrationModel> tourGuides = new List<TourGuideRegistrationModel>();

            tourGuides = TourGuideRegistrationDAL.GetTourGuideRegistrations();
            if (tourGuides.Count > 0)
            {
                return new JsonResult(tourGuides);
            }
            else
            {
                return new JsonResult("Data not found");
            }   
        }
        [HttpPost]
        [Route("SaveTourGuide")]
        public async Task<JsonResult> SaveTourGuide()
        {
            TourGuideRegistrationModel tourGuide = new TourGuideRegistrationModel();
            int i = TourGuideRegistrationDAL.SaveTourGuideRegistration(tourGuide);
            if (i == 1)
            {
                return new JsonResult(tourGuide);
            }
            else
            {
                return new JsonResult("Not saved");
            }
        }
    }
}
