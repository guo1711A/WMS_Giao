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
    public class RuKuController : ControllerBase
    {
        RuKuBusiness bll = new RuKuBusiness();

        //入库查询  api/ruku/RKSearch?name=RKD10003  
        [HttpGet]
        public List<WMS_Models.CoLinModel.PutStorageModel> RkSearch(string name, string jlid, string sid)
        {
            WMS_Models.CoLinModel.PutStorageModel m = new WMS_Models.CoLinModel.PutStorageModel { PuName = name, JlName = jlid, SName = sid };
            return bll.Search(m);
        }
        //入库高级查询  api/ruku/searchs?name=rkd10003&jlid=8e7580bf56dc&sid=88707a9f5b37&punum=GYS202001&puname=华为科技
        [HttpGet]
        public List<WMS_Models.CoLinModel.PutStorageModel> RkSearchs(string name, string jlid, string sid, string punum, string puname)
        {
            WMS_Models.CoLinModel.PutStorageModel m = new WMS_Models.CoLinModel.PutStorageModel { PuName = name, JlName = jlid, SName = sid, PuAuditNum = punum, PuSupplierName = puname };
            return bll.Searchs(m);
        }  
        //显示入库表 api/ruku/RKShow
        [HttpGet]
        public List<WMS_Models.CoLinModel.PutStorageModel> RkShow()
        {
            return bll.RkShow();
        }
        //显示入库类型 api/ruku/RKTShow
        [HttpGet]
        public List<RulibraryModel> RKTShow()
        {
            return bll.Show<RulibraryModel>();
        }
        //删除入库表 api/ruku/Delete
        [HttpPost]
        public int Delete(PutStorageModel id)
        {
            return bll.Delete(id);
        }
        ////入库表分页
        //[HttpGet]
        //public ActionResult<PutStorageModel> Pager(int PageSize, int PageIndex)
        //{
        //    IDbConnection db = AbstrtionDAL.GetSql();
        //    var param = new DynamicParameters();
        //    param.Add("@TabeName", "PutStorage");
        //    param.Add("@FileName", "*");
        //    param.Add("@Orderby", "Puid");
        //    param.Add("@where", "");
        //    param.Add("@PageSize", PageSize);
        //    param.Add("@PageIndex", PageIndex);
        //    int total = 0;
        //    param.Add("@TableCount", 0, DbType.Int32, ParameterDirection.Output);
        //    //  db.Query<List<StudentModels>>("Proc_Pager",)
        //    var res2 = db.Query<PutStorageModel>("FenYe", param, null, true, null, CommandType.StoredProcedure).ToList();//res2.Count = 80
        //    total = param.Get<int>("@TableCount");  //Execute count = 80
        //    return Ok(new { data = res2, total = total });
        //}
    }
}