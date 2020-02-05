using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using IT_BCP_POA_MVC_V1._0.Concrete;
using IT_BCP_POA_MVC_V1._0.Interface;
using IT_BCP_POA_MVC_V1._0.Models;
using System.Data.SqlClient;
using System.Data;
using Newtonsoft.Json;

namespace IT_BCP_POA_MVC_V1._0.Controllers
{
    public class POAController : Controller
    {

        private ITx_Poa _tx_Poa;
        public POAController(ITx_Poa tx_Poa)
        {
            _tx_Poa = tx_Poa;
        }

        public ActionResult CreationPoa()
        {

            var abc1 = TempData["abc"] as int?;
            var bc = TempData["a1"] as string;
            Tx_Poa tx_Poa = new Tx_Poa();
            if (abc1 != null)
            {
                var a = _tx_Poa.GetEmployeList(Convert.ToInt32(abc1));
                var b = _tx_Poa.GetEmployees(Convert.ToInt32(abc1));
                var c = _tx_Poa.GetEntityList();
                //var app = _tx_Poa.Getapp();
                // var fun = _tx_Poa.GetFunction();
                var powertype = _tx_Poa.GetPowerType();
                var power = _tx_Poa.GetPowers();
                var approverlist = _tx_Poa.GetApproverlist(Convert.ToInt32(abc1));
                if (b == 1)
                {
                    ViewBag.holdtokenvalue = abc1;

                    Tx_Poa a1 = new Tx_Poa();
                    ViewBag.message = a;
                    ViewBag.entity = c;
                    // ViewBag.app = app;
                    // ViewBag.function = fun;
                    ViewBag.Power = power;
                    ViewBag.powertype = powertype;
                    ViewBag.approvers = approverlist;
                    // ViewBag.data = app;
                    // ViewBag.data = bid;

                    // ViewBag.message = empdata;


                    return View();
                }
                else
                {
                    var d = _tx_Poa.GetEntityList();
                    ViewBag.entity = d;
                    //var fun1 = _tx_Poa.GetFunction();
                    // ViewBag.function = fun1;
                    var pow = _tx_Poa.GetPowers();
                    ViewBag.power = pow;
                    var powertypes = _tx_Poa.GetPowerType();
                    ViewBag.powertype = powertypes;
                    var approvers = _tx_Poa.GetApproverlist(Convert.ToInt32(abc1));
                    ViewBag.approver = approvers;
                    var empdatas = _tx_Poa.GetEmployees(Convert.ToInt32(abc1));
                    ViewBag.message = empdatas;
                    //var tempdata = _tx_Poa.getvaluesbaseduponid(Convert.ToInt32( abc1));
                    //ViewBag.data = tempdata;
                    //var approver = _tx_Poa.Insert_Approval_Details();
                    if (ViewBag.message == 0)
                    {
                        ViewBag.message = null;
                        ViewBag.alert = 1;
                    }


                    return View();
                }
            }
            else
            {


                var d = _tx_Poa.GetEntityList();
                ViewBag.entity = d;
                //var fun1 = _tx_Poa.GetFunction();
                //ViewBag.function = fun1;
                var power = _tx_Poa.GetPowers();
                ViewBag.power = power;
                var powertypes = _tx_Poa.GetPowerType();
                ViewBag.powertype = powertypes;
                var approvers = _tx_Poa.GetApproverlist(Convert.ToInt32(abc1));
                ViewBag.approver = approvers;
                var empdatas = _tx_Poa.GetEmployees(Convert.ToInt32(abc1));
                ViewBag.message = empdatas;
                //var tempdata = _tx_Poa.getvaluesbaseduponid(Convert.ToInt32(abc1));
                //ViewBag.data = tempdata;



                ViewBag.message = null;


                //var approvers = _tx_Poa.GetApproverlist( );
                //ViewBag.powertype = approvers;
                return View();
            }
        }
        [HttpPost]
        public ActionResult CreationPoa(int id)
        {
            string approvername = "chandrika";
            var a = _tx_Poa.GetEmployeList(Convert.ToInt32(id));

            var empdatas = _tx_Poa.GetEmployees(Convert.ToInt32(id));
            ViewBag.message = a;


            //var approver = _tx_Poa.GetApproverlist(approvername);
            //ViewBag.app = approver;
            //string ids = "1";
            var c = _tx_Poa.GetEntityList();

            Tx_Poa a1 = new Tx_Poa();
            //id = Convert.ToInt32(a1.token_no);
            SelectList list = new SelectList("entity_id", "entity_name");
            SelectList list1 = new SelectList("func_id", "func_name");
            SelectList list2 = new SelectList("pow_type_id", "pow_type");
            SelectList list3 = new SelectList("pow_no", "pow_name");
            // ViewData["entity"] = c.AsEnumerable();
            // ViewBag.entity = list;
            //TempData["abc"] = abc;
            // ViewBag.entity = c;
            int abc = id;
            TempData["abc"] = id;
            //var abc2 = TempData["a1"] as string;
            // ViewBag.approver = abc2;

            //return RedirectToAction("CreationPoa", "POA");

            return RedirectToAction("CreationPoa", "POA");
            //return  View();

            // return View(a1);
        }
        [HttpGet]
        public ActionResult GetEntity()
        {
            string abc = "1";
            //ViewData["Submarkets"] = new SelectList(_tx_Poa.GetEntityList());


            var data = _tx_Poa.GetEntityList();
            SelectList list = new SelectList(data, "entity_id", "entity_name");
            ViewBag.entity = list;
            TempData["abc"] = abc;

            // return RedirectToAction("CreationPoa", "POA");
            return View(data);
            // var abcd= _tx_Poa.GetApproverlist();


        }

        [HttpGet]
        public JsonResult getapprovalist(int id)
        {
            var approverlist = _tx_Poa.GetApproverlist(id);
            ViewBag.list = approverlist;

            return Json(approverlist, JsonRequestBehavior.AllowGet);
        }


        public JsonResult getpowerbypowertypeid(int id)
        {
            //string id = "ad";
            //pwertype ids should be same in cshtml and here
            var c = _tx_Poa.getpowersbyid(id).ToList();
            return Json(c, JsonRequestBehavior.AllowGet);
        }

        public JsonResult getfunctionsbyid(int id)
        {
            var c = _tx_Poa.GetFunction(id).ToList();
            return Json(c, JsonRequestBehavior.AllowGet);
        }

        //[HttpPost]
        //public JsonResult Create(Tx_Poa id)
        //{
        //    ApplicationDBContext db1 = new ApplicationDBContext();



        //        Tx_Poa employee = new Tx_Poa {
        //            request_no = id.request_no,
        //            request_date = id.request_date,
        //            requestor = id.requestor,
        //            token_no = id.token_no,
        //            entity_id = id.entity_id,
        //            func_id = id.func_id,
        //            pow_type_id = id.pow_type_id,
        //            pow_id = id.pow_id,
        //            pow_appr_id = id.pow_appr_id,
        //            tx_status = id.tx_status,

        //            created_by = "c",
        //            //tx_status=id.tx_status

        //            //entity_name=id.entity_name

        //        };
        //        //  var abc = _tx_Poa.InsertPOA(employee);
        //        db1.Poas.Add(employee);
        //        db1.SaveChanges();
        //        return Json(employee, JsonRequestBehavior.AllowGet);


        //        //var a=  _tx_Poa.GetEntityList().ToList();
        //        //  //ApplicationDBContext db1 = new ApplicationDBContext();
        //        //  //db1.Poas.Add(id);
        //        //  //db1.SaveChanges();
        //        //  string message = "success";
        //        //  // Tx_Poa tx_Poa = new Tx_Poa();
        //        //  //var datainsert = _tx_Poa.InsertPOA(id);

        //        //  return Json(a, JsonRequestBehavior.AllowGet);


        //    }





        [HttpPost]
        public JsonResult InsertEntityHistory(string mydata)
        {

            int Userid = 0;
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var item = JsonConvert.DeserializeObject<List<TX_POA_efpp>>(mydata);
            //dynamic item = serializer.Deserialize<Tx_Poa>(mydata);

            TX_POA_efpp poa = new TX_POA_efpp();
            foreach (var obj in item)
            {
                poa.entity_id = obj.entity_id;
                poa.func_id = obj.func_id;
                poa.pow_type_id = obj.pow_type_id;
                poa.pow_no = obj.pow_no;
                poa.req_no = obj.req_no;
                poa.create_dt = obj.create_dt;
                poa.created_by = obj.created_by;
                poa.mod_dt = obj.mod_dt;
                poa.mod_by = obj.mod_by;
                poa.mst_status = obj.mst_status;
                var connectionString = ConfigurationManager.ConnectionStrings["entityFramework"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "Insert into TX_POA_efpp (req_no,entity_id,func_id,pow_type_id,pow_no,create_dt,created_by,mod_dt,mod_by,mst_status) values(@req_no,@entity_id,@func_id,@pow_type_id,@pow_no,@create_dt,@created_by,@mod_dt,@mod_by,@mst_status)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@req_no", poa.req_no);
                        cmd.Parameters.AddWithValue("@entity_id", poa.entity_id);
                        cmd.Parameters.AddWithValue("@func_id", poa.func_id);
                        cmd.Parameters.AddWithValue("@pow_type_id", poa.pow_type_id);


                        cmd.Parameters.AddWithValue("@pow_no", poa.pow_no);
                        cmd.Parameters.AddWithValue("@create_dt", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@created_by", poa.created_by);
                        cmd.Parameters.AddWithValue("@mod_dt", DateTime.Now.ToString());



                        cmd.Parameters.AddWithValue("@mod_by", poa.mod_by);
                        cmd.Parameters.AddWithValue("@mst_status", "true");


                        cmd.ExecuteNonQuery();

                    }


                }



            }
            Userid = 1;
            return Json(Userid, JsonRequestBehavior.AllowGet);
        }




        [HttpPost]

        public JsonResult InsertApprovaldeatails1(string appdetails)
        {

            int Userid = 0;

            TX_POA_Appr poa = new TX_POA_Appr();

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            var item = JsonConvert.DeserializeObject<List<TX_POA_Appr>>(appdetails);

            var connectionString = ConfigurationManager.ConnectionStrings["entityFramework"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))

            {
                conn.Open();

                string sql = "SELECT max(pow_appr_id) as pow_appr_id FROM TX_POA_Appr";

                using (SqlCommand cmd = new SqlCommand(sql, conn))

                {
                    using (SqlDataReader reader = cmd.ExecuteReader())

                    {
                        while (reader.Read())

                        {
                              

                            if ((reader["pow_appr_id"]) == DBNull.Value)

                            {
                                TempData["data"] = 1;
                            }

                            else

                            {
                                TempData["data"] = (reader["pow_appr_id"]);

                            }
                        }

                    }

                }
                foreach (var obj in item)

                {

                    poa.token = obj.token;

                    poa.appr_name = obj.appr_name;

                    poa.comments = obj.comments;
                    string query = "Insert into TX_POA_Appr(token,appr_name,comments) values(@token, @appr_name,@comments)";

                    using (SqlCommand cmd1 = new SqlCommand(query, conn))

                    {
                        cmd1.Parameters.AddWithValue("@token", poa.token);

                        cmd1.Parameters.AddWithValue("@appr_name", poa.appr_name);

                        cmd1.Parameters.AddWithValue("@comments", poa.comments);

                        cmd1.Parameters.AddWithValue("@create_dt", DateTime.Now.ToString());

                        cmd1.Parameters.AddWithValue("@mod_dt", DateTime.Now.ToString());
                        cmd1.ExecuteNonQuery();

                    }

                }

            }

            Userid = 1;

            return Json(Userid, JsonRequestBehavior.AllowGet);

        }


        [HttpPost]

        public JsonResult Create(string mydatas)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["entityFramework"].ConnectionString;


            int previousid=  int.Parse(TempData["data"].ToString());
           // var previousid = TempData["data"] as string;
            int pre = 0;
            if (previousid ==1)
            {
                previousid = 1;
            }
            else
            {

            //if (previousid ==0)

                    previousid= previousid + 1;



            }

            int lastid = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                string sql = "SELECT max(pow_appr_id) as pow_appr_id FROM TX_POA_Appr";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    {
                        while (reader.Read())
                        {
                            lastid = Convert.ToInt32(reader["pow_appr_id"]);
                        }
                    }
                }
            }

            int Userid = 0;

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var item = JsonConvert.DeserializeObject<List<Tx_Poa>>(mydatas);
            Tx_Poa poa = new Tx_Poa();
            for (int i = previousid; i <= lastid; i++)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {

                    conn.Open();
                    string query = "Insert into TX_POA (approver_id,req_no,request_date, requestor,token_no,pow_appr_id,event_id,create_dt,created_by,mod_dt,mod_by,tx_status) values(@approver_id,@req_no,@request_date, @requestor, @token_no, @pow_appr_id, @event_id, @create_dt, @created_by, @mod_dt, @mod_by, @tx_status)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@request_date", item[0].request_date);
                        cmd.Parameters.AddWithValue("@requestor", item[0].requestor);
                        cmd.Parameters.AddWithValue("@req_no", item[0].req_no);
                        cmd.Parameters.AddWithValue("@token_no", item[0].token_no);
                        cmd.Parameters.AddWithValue("@pow_appr_id", i);
                        cmd.Parameters.AddWithValue("@event_id", item[0].event_id);
                        cmd.Parameters.AddWithValue("@create_dt", DateTime.Now.ToString());
                        //string created_by = "chandrika";
                        cmd.Parameters.AddWithValue("@created_by", item[0].created_by);
                        cmd.Parameters.AddWithValue("@mod_dt", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@mod_by", item[0].mod_by);
                        cmd.Parameters.AddWithValue("@tx_status", item[0].tx_status);
                        cmd.Parameters.AddWithValue("@approver_id", item[0].approver_id);
                        cmd.ExecuteNonQuery();
                    }

                }

            }
            Userid = 1;
            return Json(Userid, JsonRequestBehavior.AllowGet);
        }

    }



}











