using SeasNve.Common.Model.PersistData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dashboard.ViewModel
{
    public class HomeModel
    {
        public List<CRMPersistData> data { get; set; }
        public int Count { get; set; }
        public int RedCount { get; set; }
        public int YellowCount { get; set; }
    }
}
