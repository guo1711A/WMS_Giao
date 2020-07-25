using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS_Business.Colin_Business;
using WMS_Models.Pro_Models;

namespace WMS_Project.Controllers.Colin_Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChuKuController : ControllerBase
    {
        ChuKuBusiness bll = new ChuKuBusiness();
        //出库查询   
        [HttpGet]
        public List<WMS_Models.CoLinModel.GoStorageModel> CKSearch(string name, string jlid, string sid)
        {
            WMS_Models.CoLinModel.GoStorageModel m = new WMS_Models.CoLinModel.GoStorageModel { GoName = name, GlName = jlid, SName = sid };
            return bll.Search(m);
        }
        //出库高级查询  
        [HttpGet]
        public List<WMS_Models.CoLinModel.GoStorageModel> CKSearchs(string name, string jlid, string sid, string punum, string puname)
        {
            WMS_Models.CoLinModel.GoStorageModel m = new WMS_Models.CoLinModel.GoStorageModel { GoName = name, GlName = jlid, SName = sid, GoAuditNum = punum, GoSupplierName = puname };
            return bll.Searchs(m);
        }
        //显示出库表 api/Chuku/RKShow
        [HttpGet]
        public List<WMS_Models.CoLinModel.GoStorageModel> CkShow()
        {
            return bll.CkShow();
        }
        //显示出库类型 api/Chuku/RKTShow
        [HttpGet]
        public List<GLibraryModel> CKTShow()
        {
            return bll.Show<GLibraryModel>();
        }


    }
}