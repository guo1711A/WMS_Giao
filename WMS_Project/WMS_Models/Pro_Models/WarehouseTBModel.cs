using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WMS_Models.Pro_Models
{
	 public class WarehouseTBModel
	 {
		/// <summary>
		/// 仓库ID
		/// </summary>
		public Guid  Warehouse_ID { get; set; }
		/// <summary>
		/// 仓库编号
		/// </summary>
		public string  Warehouse_Num { get; set; }
		/// <summary>
		/// 仓库名称
		/// </summary>
		public string  Warehouse_Name { get; set; }
		/// <summary>
		/// 仓库类型ID
		/// </summary>
		public string  Warehouse_TypeID { get; set; }
		/// <summary>
		/// 仓库是否禁用
		/// </summary>
		public string  Warehouse_IsUse { get; set; }
		/// <summary>
		/// 仓库地址
		/// </summary>
		public string  Warehouse_Address { get; set; }
		/// <summary>
		/// 仓库面积
		/// </summary>
		public string  Warehouse_Area { get; set; }
		/// <summary>
		/// 创建仓库时间
		/// </summary>
		public DateTime  Warehouse_Ctime { get; set; }
		/// <summary>
		/// 仓库负责人名称
		/// </summary>
		public string  Warehouse_Manager { get; set; }
		/// <summary>
		/// 仓库负责人联系电话
		/// </summary>
		public string  Warehouse_ManagerPhone { get; set; }
		/// <summary>
		/// 仓库租赁结束时间
		/// </summary>
		public DateTime  Warehouse_Etime { get; set; }
		/// <summary>
		/// 仓库租赁时间
		/// </summary>
		public string  Warehouse_Time { get; set; }
		/// <summary>
		/// 仓库所属部门ID
		/// </summary>
		public string  Warehouse_DepartID { get; set; }
		/// <summary>
		/// 仓库租赁开始事件
		/// </summary>
		 public DateTime  Warehouse_Btime { get; set; }
	 }
}
