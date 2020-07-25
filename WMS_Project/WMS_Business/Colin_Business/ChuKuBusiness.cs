
using System;
using System.Collections.Generic;
using System.Text;
using WMS_DataAccess.Colin_DataAccess;
using WMS_Models.Pro_Models;

namespace WMS_Business.Colin_Business
{
    public class ChuKuBusiness:TypeBusiness
    {

        SqlDbHelper dal = new SqlDbHelper();
        //出库查询
        public List<WMS_Models.CoLinModel.GoStorageModel> Search(WMS_Models.CoLinModel.GoStorageModel m)
        {
            string sql = "select put.goid,put.goname,pro.prname,pro.PrNumber,put.goBatch,spe.spname,put.goNumber,jli.StName, rul.GlName,put.GoSupplierName,put.GoPrepared,sta.SName, put.GoAudit,put.GoAuditTime from GoStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join GLibrary rul on  put.Glid = rul.Glid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid where 1=1 ";
            if (!string.IsNullOrEmpty(m.GoName))
            {
                sql += $" and PuName= @GoName ";
            }
            if (!string.IsNullOrEmpty(m.Glid))
            {
                sql += $" and Jlid =@Glid ";
            }
            if (!string.IsNullOrEmpty(m.Sid))
            {
                sql += $" and Sid= @Sid ";
            }
            //string sql = "select * from PutStorage where PuName= @PuName and Jlid =@Jlid and Sid= @Sid ";
            return dal.Search<WMS_Models.CoLinModel.GoStorageModel, WMS_Models.CoLinModel.GoStorageModel>(sql, m);
        }
        //出库高级查询
        public List<WMS_Models.CoLinModel.GoStorageModel> Searchs(WMS_Models.CoLinModel.GoStorageModel m)
        {
            string sql = "select put.goid,put.goname,pro.prname,pro.PrNumber,put.goBatch,spe.spname,put.goNumber,jli.StName, rul.GlName,put.GoSupplierName,put.GoPrepared,sta.SName, put.GoAudit,put.GoAuditTime from GoStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join GLibrary rul on  put.Glid = rul.Glid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid where 1=1 ";
            if (!string.IsNullOrEmpty(m.GoName))
            {
                sql += $" and PuName= @GoName ";
            }
            if (!string.IsNullOrEmpty(m.Glid))
            {
                sql += $" and Jlid =@Jlid ";
            }
            if (!string.IsNullOrEmpty(m.Sid))
            {
                sql += $" and Sid= @Sid ";
            }
            if (!string.IsNullOrEmpty(m.GoAuditNum))
            {
                sql += $" and PuAuditNum=@GoAuditNum ";
            }
            if (!string.IsNullOrEmpty(m.GoSupplierName))
            {
                sql += $" PuSupplierName=@GoSupplierName ";
            }
            // string sql = "select * from PutStorage where PuName= @PuName and Jlid =@Jlid and Sid= @Sid and PuAuditNum=@PuAuditNum and PuSupplierName=PuSupplierName";
            return dal.Search<WMS_Models.CoLinModel.GoStorageModel, WMS_Models.CoLinModel.GoStorageModel>(sql, m);
        }
        //出库表显示
        public List<WMS_Models.CoLinModel.GoStorageModel> CkShow()
        {
            string sql = "select put.goid,put.goname,pro.prname,pro.PrNumber,put.goBatch,spe.spname,put.goNumber,jli.StName, rul.GlName,put.GoSupplierName,put.GoPrepared,sta.SName, put.GoAudit,put.GoAuditTime from GoStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join GLibrary rul on  put.Glid = rul.Glid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid";
            return dal.Shows<WMS_Models.CoLinModel.GoStorageModel>(sql);
        }
        //出库表详情显示
        public List<WMS_Models.CoLinModel.GoStorageModel> CkXQShow()
        {
            string sql = " select put.Goid,put.GoName,pro.prname,pro.PrNumber,put.GoAddres,put.GoAuditPeople,put.GoBatch,spe.spname,put.GoNumber,jli.StName,put.GoSupplierName,put.GoAuditNum,rul.GlName,put.GoPrepared,sta.SName,put.GoAuditPeople,put.GoTotalPrice,put.GoPreparedTime,put.GoSupplierName from GoStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join GLibrary rul on put.Glid = rul.Glid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid ";
            return dal.Shows<WMS_Models.CoLinModel.GoStorageModel>(sql);
        }
    }
}
