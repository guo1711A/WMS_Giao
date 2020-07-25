
using System;
using System.Collections.Generic;
using System.Text;
using WMS_DataAccess.Colin_DataAccess;

namespace WMS_Business.Colin_Business
{
    public class PanDianBusiness:TypeBusiness
    {
        SqlDbHelper dal = new SqlDbHelper();
        //盘点查询
        public List<WMS_Models.CoLinModel.CheckStorageModel> Search(WMS_Models.CoLinModel.CheckStorageModel m)
        {
            string sql = "select put.Chid,put.ChName,sta.sname,rul.ClName,  put.ChRelevance,put.chPrepared, put.ChPreparedTime from CheckStorage put join Clibrary rul on  put.Clid = rul.Clid join State sta on put.Sid = sta.Sid where 1=1 ";
            if (!string.IsNullOrEmpty(m.ChName))
            {
                sql += $" and PuName= @ChName ";
            }
            if ((m.ChPreparedTime)!=null)
            {
                sql += $" and Jlid =@ChPreparedTime ";
            }
            if (!string.IsNullOrEmpty(m.Sid))
            {
                sql += $" and Sid= @Sid ";
            }
            //string sql = "select * from PutStorage where PuName= @PuName and Jlid =@Jlid and Sid= @Sid ";
            return dal.Search<WMS_Models.CoLinModel.CheckStorageModel, WMS_Models.CoLinModel.CheckStorageModel>(sql, m);
        } 
        //盘点表详情显示
        public List<WMS_Models.CoLinModel.CheckStorageModel> PDXQShow()
        {
            string sql = " select put.Chid,put.ChName,pro.prname,pro.PrNumber,put.ChAddres,put.ChBatch,spe.spname,put.CHNumber,jli.StName,put.ChTake,rul.ClName,put.ChRelevance,put.chPrepared,sta.SName,put.ChProfit,put.ChPreparedTime from CheckStorage put join ProductsTB pro on put.Prid = pro.prid join Specification spe on put.spid = spe.spid join Clibrary rul on  put.Clid = rul.Clid join State sta on put.Sid = sta.Sid join jlibrary jli on put.Stid = jli.Stid";
            return dal.Shows<WMS_Models.CoLinModel.CheckStorageModel>(sql);
        }
        //盘点表显示
        public List<WMS_Models.CoLinModel.CheckStorageModel> PDShow()
        {
            string sql = "  select put.Chid,put.ChName,sta.sname,rul.ClName,  put.ChRelevance,put.chPrepared, put.ChPreparedTime from CheckStorage put join Clibrary rul on  put.Clid = rul.Clid join State sta on put.Sid = sta.Sid ";
            return dal.Shows<WMS_Models.CoLinModel.CheckStorageModel>(sql);
        }
    }
}
