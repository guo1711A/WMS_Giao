using System;
using System.Collections.Generic;
using System.Text;
using WMS_DataAccess.Colin_DataAccess;
using WMS_Models.Pro_Models;

namespace WMS_Business.Colin_Business
{
    public class RuKuBusiness:TypeBusiness
    {
        SqlDbHelper dal = new SqlDbHelper();
        //入库查询
        public List<WMS_Models.CoLinModel.PutStorageModel> Search(WMS_Models.CoLinModel.PutStorageModel m)
        {
            string sql = "select put.puid,put.puname,pro.prname,pro.PrNumber,put.PuBatch,spe.spname,put.puNumber,jli.StName,rul.jlname,put.PuSupplierName,put.PuPrepared,sta.SName,put.PuAudit,put.PuAuditTime from PutStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join Rulibrary rul on  put.jlid = rul.jlid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid where 1=1 ";
            if (!string.IsNullOrEmpty(m.PuName))
            {
                sql += $" and PuName= @PuName ";
            }
            if (!string.IsNullOrEmpty(m.Jlid))
            {
                sql += $" and Jlid =@Jlid ";
            }
            if (!string.IsNullOrEmpty(m.Sid))
            {
                sql += $" and Sid= @Sid ";
            }
            //string sql = "select * from PutStorage where PuName= @PuName and Jlid =@Jlid and Sid= @Sid ";
            return dal.Search<WMS_Models.CoLinModel.PutStorageModel, WMS_Models.CoLinModel.PutStorageModel>(sql, m);
        }
        //入库高级查询
        public List<WMS_Models.CoLinModel.PutStorageModel> Searchs(WMS_Models.CoLinModel.PutStorageModel m)
        {
            string sql = "select put.puid,put.puname,pro.prname,pro.PrNumber,put.PuBatch,spe.spname,put.puNumber,jli.StName,rul.jlname,put.PuSupplierName,put.PuPrepared,sta.SName,put.PuAudit,put.PuAuditTime from PutStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join Rulibrary rul on  put.jlid = rul.jlid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid where 1=1 ";
            if (!string.IsNullOrEmpty(m.PuName))
            {
                sql += $" and PuName= @PuName ";
            }
            if (!string.IsNullOrEmpty(m.Jlid))
            {
                sql += $" and Jlid =@Jlid ";
            }
            if (!string.IsNullOrEmpty(m.Sid))
            {
                sql += $" and Sid= @Sid ";
            }
            if (!string.IsNullOrEmpty(m.PuAuditNum))
            {
                sql += $" and PuAuditNum=@PuAuditNum ";
            }
            if (!string.IsNullOrEmpty(m.PuSupplierName))
            {
                sql += $" PuSupplierName=@PuSupplierName ";
            }
           // string sql = "select * from PutStorage where PuName= @PuName and Jlid =@Jlid and Sid= @Sid and PuAuditNum=@PuAuditNum and PuSupplierName=PuSupplierName";
            return dal.Search<WMS_Models.CoLinModel.PutStorageModel, WMS_Models.CoLinModel.PutStorageModel>(sql, m);
        }
        //入库表显示 
        public List<WMS_Models.CoLinModel.PutStorageModel> RkShow()
        {
            string sql = "select put.puid,put.puname,pro.prname,pro.PrNumber,put.PuBatch,spe.spname,put.puNumber,jli.StName,rul.jlname,put.PuSupplierName,put.PuPrepared,sta.SName,put.PuAudit,put.PuAuditTime from PutStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join Rulibrary rul on  put.jlid = rul.jlid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid";
            return dal.Shows<WMS_Models.CoLinModel.PutStorageModel>(sql);
        }
        //入库详情显示
        public List<WMS_Models.CoLinModel.PutStorageModel> RkXQShow()
        {
            string sql = "select put.puid, put.puName, pro.prname, pro.PrNumber, put.puAddres, put.PuAuditPeople,put.puBatch, spe.spname, put.puNumber, jli.StName, put.PuSupplierName, put.PuAuditNum,rul.jlName, put.puPrepared, sta.SName, put.PuAuditPeople, put.PuTotalPrice,put.puPreparedTime, put.PuSupplierName from PutStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join Rulibrary rul on put.jlid = rul.jlid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid";
            return dal.Shows<WMS_Models.CoLinModel.PutStorageModel>(sql);
        }

    }
}
