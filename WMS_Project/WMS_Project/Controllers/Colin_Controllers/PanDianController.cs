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
    public class PanDianController : ControllerBase
    {
        PanDianBusiness bll = new PanDianBusiness();
        //盘点查询  api/pandian/PDSearch?name=  
        [HttpGet]
        public List<WMS_Models.CoLinModel.CheckStorageModel> PDSearch(string name, DateTime jlid, string sid)
        {
            WMS_Models.CoLinModel.CheckStorageModel m = new WMS_Models.CoLinModel.CheckStorageModel { ChName = name, ChPreparedTime = jlid, SName = sid };
            return bll.Search(m);
        } 
        //显示盘点表 api/PANDIAN/RKShow
        [HttpGet]
        public List<WMS_Models.CoLinModel.CheckStorageModel> PDShow()
        {
            return bll.PDShow();
        }
        //显示盘点表 api/PANDIAN/RKShow
        [HttpGet]
        public List<WMS_Models.CoLinModel.CheckStorageModel> PDXQShow()
        {
            return bll.PDXQShow();
        }
        //显示盘点类型 api/PANDAIN/PDTShow
        [HttpGet]
        public List<ClibraryModel> PDTShow()
        {
            return bll.Show<ClibraryModel>();
        }

    }
}