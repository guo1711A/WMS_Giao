using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WMS_Models;
using WMS_Business;

namespace WMS_Project.Controllers.Hanna_Controllers
{
    [Route("api")]
    [ApiController]
    public class HannaController : ControllerBase
    {
        WMS_Business.Hanna_Buniness.IBLL bll;
        /// <summary>
        /// 依赖注入bll
        /// </summary>
        /// <param name="_ibll"></param>
        public HannaController(WMS_Business.Hanna_Buniness.IBLL _ibll)
        {
            bll = _ibll;
        }
        #region 仓库信息展示列表
        /// <summary>
        /// 仓库信息展示列表
        /// </summary>
        /// <returns></returns>
        [Route("wareallshow")]
        [HttpGet]
        public List<WMS_Models.HannaModel.WarehouseModelAll> warehouseModelShow()
        {
            return bll.warehouseModelShow();
        }
        #endregion

        #region 单表查询  下拉框绑定  仓库管理  仓库类型 
        /// <summary>
        /// 下拉框绑定  仓库管理  仓库类型 
        /// </summary>
        /// <returns></returns>
        [Route("waretypebind")]
        [HttpGet]
        public List<WMS_Models.Pro_Models.WarehouseTypeModel> warehouseTypeShow()
        {
            return bll.warehouseTypeShow();
        }
        #endregion

        #region 单表查询  下拉框绑定  仓库管理  部门类型
        /// <summary>
        /// 单表查询  下拉框绑定  仓库管理  部门类型
        /// </summary>
        /// <returns></returns>
        [Route("waredepbind")]
        [HttpGet]
        public List<WMS_Models.Pro_Models.DepartmentTBModel> departmentTBBind()
        {
            return bll.departmentTBBind();
        }
        #endregion

        #region 多表联查  仓库管理 多条件查询仓库信息
        [HttpGet]
        [Route("wareselect")]
        public List<WMS_Models.HannaModel.WarehouseModelAll> warehouseModelSelectShow(string warenum, string warename, string waredep, string waretype)
        {
            return bll.warehouseModelSelectShow(warenum, warename, waredep, waretype);
        }
        #endregion







    }
}
