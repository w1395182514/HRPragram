using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOC;
using IHRDAL;
using IHRBLL;
using System.Data;

namespace HRBLL
{
   public class major_changeBLL:Imajor_changeBLL
    {
        Imajor_changeDAL imd = IOCcotainer.Createmajor_changeDAO();

        public DataTable CX1()
        {
            return imd.CX1();
        }

        public DataTable CX2()
        {
            return imd.CX2();
        }
    }
}
