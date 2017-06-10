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
    public class DesignController : ApiController
    {
        readonly IDesignRepo _designRepo;

        public DesignController(IDesignRepo designRepo)
        {
            _designRepo = designRepo;
        }

        //[Route("api/design")]
        //[HttpGet]
        //public GetDesignById(Design designId)
        //{

        //}

        [Route("api/design")]
        [HttpGet]
        public IEnumerable<Design> GetDesigns()
        {
            var showAllDesigns = _designRepo.GetDesigns();
            return showAllDesigns;
        }

        [Route("api/design")]
        [HttpPost]
        public void AddDesign(Design newDesign)
        {
            _designRepo.AddDesign(newDesign);
        }

    }
}
