using SilkScreenOrder.DAL;
using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SilkScreenOrder.Controllers
{
    public class ApparelController : ApiController
    {
        readonly IApparelRepo _apparelRepo;

        public ApparelController(IApparelRepo apparelRepo)
        {
            _apparelRepo = apparelRepo;
        }

        [Route("api/apparel")]
        [HttpGet]
        public IEnumerable<Apparel> GetApparel()
        {
            var showAllApparel = _apparelRepo.GetApparel();
            return showAllApparel;
        }

        [Route("api/apparel")]
        [HttpPost]
        public void AddApparel(Apparel apparel)
        {
            _apparelRepo.AddApparel(apparel);
        }
    }
}
