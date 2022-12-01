using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryModel
{
    public class TourPackageModel
    {
        public int PKG_Id { get; set; }
        public int Tour_Guide_ID { get; set; }
        public string? PKG_Title { get; set; }
        public string? PKG_Duration { get; set; }
        public string? PKG_Pricing { get; set; }
        public string? PKG_From_City { get; set; }
        public string? PKG_To_City { get; set; }

    }
}
