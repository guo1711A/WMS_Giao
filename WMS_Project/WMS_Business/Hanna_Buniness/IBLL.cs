using System;
using System.Collections.Generic;
using System.Text;
using WMS_Models;

namespace WMS_Business.Hanna_Buniness
{
    public interface IBLL
    {

        /// <summary>
        /// 反射显示仓库管理信息列表  仓库管理
        /// </summary>
        /// <returns></returns>
        public List<WMS_Models.HannaModel.WarehouseModelAll> warehouseModelShow();
        /// <summary>
        /// 绑定下拉框  仓库类型展示下拉框  仓库管理
        /// </summary>
        /// <returns></returns>
        public List<WMS_Models.Pro_Models.WarehouseTypeModel> warehouseTypeShow();
        /// <summary>
        /// 绑定下拉框  部门展示下拉框    仓库管理
        /// </summary>
        /// <returns></returns>
        public List<WMS_Models.Pro_Models.DepartmentTBModel> departmentTBBind();
        /// <summary>
        /// 仓库管理信息查询
        /// </summary>
        /// <param name="warenum">仓库编号</param>
        /// <param name="warename">仓库名称</param>
        /// <param name="waredep">部门信息</param>
        /// <param name="waretype">仓库类型</param>
        /// <returns></returns>
        public List<WMS_Models.HannaModel.WarehouseModelAll> warehouseModelSelectShow(string warenum, string warename, string waredep, string waretype);

    }
}
