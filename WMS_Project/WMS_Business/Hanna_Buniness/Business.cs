using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using WMS_DataAccess.Hanna_DataAccess;
using WMS_Models;
using WMS_Models.HannaModel;
using System.Linq;
using Dapper;
using System.Data;
using WMS_Models.Pro_Models;

namespace WMS_Business.Hanna_Buniness
{
    public class Business : IBLL
    {
        IDAL dal;
        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="_idal"></param>
        public Business(IDAL _idal)
        {
            dal = _idal;
        }
        #region 仓库信息  列表展示显示
        /// <summary>
        /// 仓库信息列表展示显示
        /// </summary>
        /// <typeparam name="T">实现的model</typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<WarehouseModelAll> warehouseModelShow()
        {
            string sql = $"select a.Warehouse_Num,a.Warehouse_Name,a.Warehouse_Ctime,b.WarehouseType_Name,c.DepartmentName,a.Warehouse_IsUse,a.Warehouse_Address,a.Warehouse_Area,a.Warehouse_Manager,a.Warehouse_ManagerPhone from WarehouseTB a join WarehouseType b on a.Warehouse_TypeID = b.WarehouseType_ID join DepartmentTB c on a.Warehouse_DepartID = c.Id";
            return dal.GetAllList<WarehouseModelAll>(sql).ToList();
        }
        #endregion

        #region 单表查询  下拉框绑定  仓库管理  仓库类型 
        /// <summary>
        /// 下拉框绑定  仓库管理  仓库类型
        /// </summary>
        /// <returns></returns>
        public List<WarehouseTypeModel> warehouseTypeShow()
        {
            return dal.GetOneList<WarehouseTypeModel>().ToList();
        }
        #endregion

        #region 单表查询  下拉框绑定  仓库管理  仓库部门类型
        public List<DepartmentTBModel> departmentTBBind()
        {
            return dal.GetOneList<DepartmentTBModel>().ToList();
        }
        #endregion

        #region 多表联查  仓库管理 多条件查询仓库信息
        /// <summary>
        /// 仓库管理信息查询
        /// </summary>
        /// <param name="warenum">仓库编号</param>
        /// <param name="warename">仓库名称</param>
        /// <param name="waredep">部门信息</param>
        /// <param name="waretype">仓库类型</param>
        /// <returns></returns>
        List<WarehouseModelAll> IBLL.warehouseModelSelectShow(string warenum, string warename, string waredep, string waretype)
        {
            string sql = $"select a.Warehouse_Num,a.Warehouse_Name,a.Warehouse_Ctime,b.WarehouseType_Name,c.DepartmentName,a.Warehouse_IsUse,a.Warehouse_Address,a.Warehouse_Area,a.Warehouse_Manager,a.Warehouse_ManagerPhone from WarehouseTB a join WarehouseType b on a.Warehouse_TypeID = b.WarehouseType_ID join DepartmentTB c on a.Warehouse_DepartID = c.Id where 1=1";
            //判断仓库编号是否为空
            if (!string.IsNullOrEmpty(warenum))
            {
                sql += $" and a.Warehouse_Num='" + warenum + "'";
            }
            //判断仓库名称是否为空
            if (!string.IsNullOrEmpty(warename))
            {
                sql += $" and a.Warehouse_Name='" + warename + "'";
            }
            if (!string.IsNullOrEmpty(waredep))
            {
                sql += $" and b.WarehouseType_Name='" + waredep + "'";
            }
            if (!string.IsNullOrEmpty(waretype))
            {
                sql += $" and c.DepartmentName='" + waretype + "'";
            }
            return dal.GetAllList<WarehouseModelAll>(sql).ToList();
        }
        #endregion
    }
}
