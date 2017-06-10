using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SilkScreenOrder.DAL
{
    public interface IDesignRepo
    {
        void AddDesign(Design design);

        IEnumerable<Design> GetDesigns();

        Design GetDesignById(int designId);
    }
}
