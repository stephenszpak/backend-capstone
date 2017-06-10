using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilkScreenOrder.DAL
{
    public class DesignRepo : IDesignRepo
    {
        readonly AppContext _context;

        public DesignRepo(AppContext context)
        {
            _context = context;
        }

        public void AddDesign(Design design)
        {
            _context.Designs.Add(design);
            _context.SaveChanges();
        }

        public Design GetDesignById(int designId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Design> GetDesigns()
        {
            return _context.Designs;
        }
    }
}