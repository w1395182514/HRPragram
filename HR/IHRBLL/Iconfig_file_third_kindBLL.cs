using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHRBLL
{
   public interface Iconfig_file_third_kindBLL
    {
        List<config_file_third_kindModel> FTKAll();


        int FTAdd(config_file_third_kindModel t);


        //查询I级机构名称绑定下拉框
        DataTable CX1();

        //查询II级机构名称绑定下拉框
        DataTable CX2();
    }
}
