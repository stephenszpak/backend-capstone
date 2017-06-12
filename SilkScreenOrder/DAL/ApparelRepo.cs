using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SilkScreenOrder.Models;

namespace SilkScreenOrder.DAL
{
    public class ApparelRepo : IApparelRepo
    {
        readonly AppContext _context;

        public ApparelRepo(AppContext context)
        {
            _context = context;
        }

        
        public void AddApparel(Apparel apparel)
        {
            _context.Apparel.Add(apparel);
            _context.SaveChanges();
        }

        public Apparel DeleteApparel(int apparelId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Apparel> GetApparel()
        {
            return _context.Apparel;
        }
    }
}