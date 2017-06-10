using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkScreenOrder.DAL
{
    public interface IApparelRepo
    {
        IEnumerable<Apparel> GetApparel();
        void AddApparel(Apparel apparel);
    }
}
