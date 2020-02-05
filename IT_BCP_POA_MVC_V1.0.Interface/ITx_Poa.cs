using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_BCP_POA_MVC_V1._0.Models;


namespace IT_BCP_POA_MVC_V1._0.Interface
{
  public  interface ITx_Poa
    {
        //List<TX_EMPs> getvaluesbaseduponid(int id);
        List<TX_EMPs> GetEmployeList(int abc1);
        //List<Tx_Poa> GetEmployeList1(int id);
        //List<Tx_Poa> getdatas();
       // List<TX_POA_Appr> Getapp();
        int gettokenno(int tokenno);
        List<MST_POA_Entity> GetEntityList();
        List<MST_POA_Function> GetFunction(int fn_id);
        List<MST_POA_Power> GetPowers();
        List<MST_POA_Powertype> GetPowerType();
        List<TX_EMPs> GetApproverlist(int approvername);
       // int GetApproverlist(int txtapproverid);
        int  InsertPOA(Tx_Poa id);
        List<MST_POA_Power> getpowersbyid(int id);
       // int getapproverlist(int txtapproverid);
        int GetEmployees(int id);
        //int Insert_Approval_Details(string std,string approvername, string comment,string mydata);
    }
}
