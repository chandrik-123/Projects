using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_BCP_POA_MVC_V1._0.Interface;
using IT_BCP_POA_MVC_V1._0.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace IT_BCP_POA_MVC_V1._0.Concrete
{
    public class Tx_poaConcrete : ITx_Poa
    {

        ApplicationDBContext db = new ApplicationDBContext();



        public List<TX_EMPs> GetEmployeList(int abc1)
        {

            var teenAgerStudents = db.emps.Where(s => s.token_no == abc1)
                                  .ToList<TX_EMPs>();

            return teenAgerStudents;
        }

        public int gettokenno(int tokenno)
        {
            var xmyTable = (from ymyTable in db.Poas
                            where ymyTable.token_no == tokenno
                            select new { ymyTable.request_no, ymyTable.request_date, ymyTable.requestor }).FirstOrDefault();
            //if(xmyTable >0)
            //{
            if (xmyTable != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }


        public List<MST_POA_Entity> GetEntityList()
        {
            //int  id = 1;
            try
            {
                // var cd = db.Entities.Where(s => s. entity_id)ToList());

                var cd = db.Entities.OrderBy(a => a.entity_name).ToList();

                return cd;




            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public List<MST_POA_Power> GetPowers()
        {
            try
            {
                var Powerss = db.Power.OrderBy(a => a.pow_name).ToList();
                return Powerss;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MST_POA_Powertype> GetPowerType()
        {
            try
            {
                var PowersType = db.Powertype.OrderBy(a => a.pow_type).ToList();
                return PowersType;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<TX_EMPs> GetApproverlist(int txtapproverid)
        {

            var data = db.emps.Where(s => s.token_no == txtapproverid)
                                   .ToList();
            //List<string> ab = new List<string>();
            


                return data;


        }


        //public int GetApproverlist(int txtapproverid)
        //{
        //    List<int> list = new List<int>();
        //    //var data = db.emps.Where(s => s.token_no == txtapproverid)
        //    //                       .ToList();
        //    var data = db.emps.Where(c => c.token_no == txtapproverid).OrderBy(a => a.appr_name).ToList();

        //    if (data.Count == 0)
        //    {

        //        return 0;

        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}
        //if (list == null)
        //{
        //    list.Add(txtapproverid);
        //}
        //else
        //{

        //    var chk = list.Contains(txtapproverid);












        //= employedata.EmpAddress,
        //employeemailid = employedata.EmpEmailId,



        //var vnlist = from up in db.emps
        //             where up.token_no == txtapproverid
        //             select new
        //             {
        //                 up.token_no,
        //                 up.appr_name

        //             };
        //foreach (var item in vnlist)
        //{
        //    TX_EMPs temp = new TX_EMPs();
        //    temp.token_no = item.token_no;
        //    temp.appr_name = item.appr_name;

        //    list.Add(temp);
        //    bool result = list.Contains(temp);
        //}









        public List<MST_POA_Power> getpowersbyid(int id)
        {
            int pow_type_id;
            List<MST_POA_Power> a1 = new List<MST_POA_Power>();

            var data = db.Power.Where(c => c.pow_type_id == id).OrderBy(a => a.pow_name).ToList();
            pow_type_id = Convert.ToInt32(id);

            return data;

        }
        public List<MST_POA_Function> GetFunction(int fn_id)
        {
            try
            {
                int entity_id;
                var data = db.Function.Where(c => c.entity_id == fn_id).OrderBy(a => a.func_name).ToList();
                entity_id = Convert.ToInt32(fn_id);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }






        //public List<TX_EMPs> getvaluesbaseduponid(int id)
        //{
        //    //int pow_type_id;
        //    List<TX_EMPs> a1 = new List<TX_EMPs>();

        //    var data = db.emps.Where(c => c.token_no == id).ToList();
        //    // = Convert.ToInt32(id);

        //    return data;

        //}

        public int InsertPOA(Tx_Poa id)
        {
            return 1;
        }

        public int GetEmployees(int id)
        {
            var xmyTable = (from ymyTable in db.emps
                            where ymyTable.token_no == id
                            select new { ymyTable.req_no, ymyTable.req_date, ymyTable.requestor }).FirstOrDefault();
            //if(xmyTable >0)
            //{

            if (xmyTable != null)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }

    }
}

