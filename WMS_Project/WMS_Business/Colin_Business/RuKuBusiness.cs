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
        public List<PutStorageModel> Search(PutStorageModel m)
        {
            string sql = "select * from PutStorage where PuName= @PuName and Jlid =@Jlid and Sid= @Sid ";
            return dal.Search<PutStorageModel, PutStorageModel>(sql, m);
        }
        //入库高级查询
        public List<PutStorageModel> Searchs(PutStorageModel m)
        {
            string sql = "select * from PutStorage where PuName= @PuName and Jlid =@Jlid and Sid= @Sid and PuAuditNum=@PuAuditNum and PuSupplierName=PuSupplierName";
            return dal.Search<PutStorageModel, PutStorageModel>(sql, m);
        } 
        //入库表显示
        public List<WMS_Models.CoLinModel.PutStorageModel> RkShow()
        {
            string sql = "select put.puid,put.puname,pro.prname,pro.PrNumber,put.PuBatch,spe.spname,put.PuName,jli.StName,rul.jlname,put.PuSupplierName,put.PuPrepared,sta.SName,put.PuAudit,put.PuAuditTime from PutStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join Rulibrary rul on  put.jlid = rul.jlid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid";
            return dal.Shows<WMS_Models.CoLinModel.PutStorageModel>(sql);
        }


    }
}
