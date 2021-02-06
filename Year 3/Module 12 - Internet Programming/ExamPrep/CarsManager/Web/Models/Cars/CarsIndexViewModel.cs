using System.Collections;
using System.Collections.Generic;
using Web.Models.Shared;

namespace Web.Models.Cars
{
    public class CarsIndexViewModel
    {
        public PagerViewModel Pager { get; set; }

        public ICollection<CarsViewModel> Items { get; set; }
    }
}
