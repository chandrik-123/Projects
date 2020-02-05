using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IT_BCP_POA_MVC_V1._0.Models
{
    public class Tx_Poa
    {
        [Key]
        public int request_no { get; set; }
        public int req_no { get; set; }
        [Required]
        public string request_date { get; set; }
        [Required]
        public string requestor { get; set; }
        [Required]
        public int token_no { get; set; }
        [Required]
        public int pow_appr_id { get; set; }
        public string appr_name { get; set; }

        [Required]
        public int event_id { get; set; }

        [Required]
        public string create_dt { get; set; }
        [Required]

        public string created_by { get; set; }
        [Required]
        public string mod_dt { get; set; }
        [Required]

        public string mod_by { get; set; }
        [Required]
        public string tx_status { get; set; }
        [Required]
        public int entity_id { get; set; }
        public int func_id { get; set; }
        [Required]
        public int pow_type_id { get; set; }
        [Required]
        public int pow_no { get; set; }
        [Required]
        public int pow_id { get; set; }
        [Required]
        public string Status { get; set; }
        public int approver_id { get; set; }
        public string comments { get; set; }
        // public TX_POA_Appr app { get; set; }
        // public MST_POA_Entity mST_POA_Entity { get; set; }
    }

    public class TX_POA_efpp
    {
        [Key]
        public int eid { get; set; }
        [Required]
        public int req_no { get; set; }
        [Required]
        public int pow_type_id { get; set; }
        [Required]
        public int func_id { get; set; }
        [Required]
        public int entity_id { get; set; }
        [Required]
        public int pow_no { get; set; }
        [Required]
        public string create_dt { get; set; }
        public string created_by { get; set; }
        public string mod_dt { get; set; }
        public string mod_by { get; set; }
        public string mst_status { get; set; }
        public string current_status { get; set; }
        public string next_status { get; set; }
        //  public string mst_status { get; set; }

    }
    public class TX_EMPs
    {
        [Key]


        public int req_no { get; set; }
        public string requestor { get; set; }
        public string req_date { get; set; }
        public int token_no { get; set; }
        public string employee_name { get; set; }
        public string status { get; set; }
        public string appr_name { get; set; }
    }
    public class MST_POA_Entity
    {

        [Key]
        [Required(ErrorMessage = "please enter id")]
        public int entity_id { get; set; }
        [Required]
        public string entity_name { get; set; }
        [Required]
        public string dept_name { get; set; }
        [Required]
        public int loc_id { get; set; }
        [Required]
        public int div_id { get; set; }
        [Required]
        public int dept_id { get; set; }
        [Required]
        public string create_dt { get; set; }
        [Required]
        public string created_by { get; set; }
        [Required]
        public string mod_dt { get; set; }
        [Required]
        public string mod_by { get; set; }
        [Required]
        public string mst_status { get; set; }
        [Required]
        public string current_status { get; set; }
        [Required]
        public string next_status { get; set; }

    }


    public class MST_POA_Function
    {
        [Key]
        public int func_id { get; set; }
        [Required]
        public int entity_id { get; set; }

        [Required]
        public string func_name { get; set; }
        [Required]
        public string dept_name { get; set; }
        [Required]
        public int loc_id { get; set; }
        [Required]
        public int div_id { get; set; }
        [Required]
        public int dept_id { get; set; }
        [Required]
        public string create_dt { get; set; }
        [Required]
        public string created_by { get; set; }
        [Required]
        public string mod_dt { get; set; }
        [Required]
        public string mod_by { get; set; }
        [Required]
        public string mst_status { get; set; }


    }

    public class MST_POA_Powertype
    {
        [Key]
        public int pow_type_id { get; set; }
        [Required]
        public string pow_type { get; set; }
        [Required]
        public DateTime create_dt { get; set; }
        [Required]
        public string created_by { get; set; }
        [Required]
        public DateTime mod_dt { get; set; }
        [Required]
        public string mod_by { get; set; }

    }

    //public class ViewModel
    //{
    //    public IEnumerable<Tx_Poa> tx_s { get; set; }
    //    public IEnumerable<MST_POA_Entity> MST_s { get; set; }
    //    public IEnumerable<MST_POA_Function> Functions_s { get; set; }
    //    public IEnumerable<MST_POA_Power> power_s { get; set; }
    //    public IEnumerable<MST_POA_Powertype> powertype_s { get; set; }
    //    public IEnumerable<TX_POA_Appr> approvers { get; set; }
    //}
    public class ViewModel
    {
        public Tx_Poa tx_s { get; set; }
        public MST_POA_Entity MST_s { get; set; }
        public MST_POA_Function Functions_s { get; set; }
        public MST_POA_Power power_s { get; set; }
        public MST_POA_Powertype powertype_s { get; set; }
        public TX_POA_Appr approvers { get; set; }
        public MST_POA_loc location { get; set; }
        public MST_POA_Div division { get; set; }
        public MST_POA_Dept departement { get; set; }
        public MST_POA_Emplevel Emplevel { get; set; }
        public TX_POA_Power txtpower { get; set; }
        public TX_EMPs emps { get; set; }
        public TX_POA_efpp ehistory { get; set; }
    }

    public class MST_POA_Power
    {
        [Key]
        public int pow_no { get; set; }
        [Required]
        public string pow_name { get; set; }
        [Required]
        public string pow_descp { get; set; }
        [Required]
        public int pow_type_id { get; set; }
        [Required]
        public int emp_levl_id { get; set; }
        [Required]
        public DateTime create_dt { get; set; }
        [Required]
        public string created_by { get; set; }
        [Required]
        public DateTime mod_dt { get; set; }
        [Required]
        public string mod_by { get; set; }
        [Required]
        public bool? mst_status { get; set; }
        [Required]
        public string current_status { get; set; }

    }
    public class TX_POA_Appr
    {
        [Key]
        public int pow_appr_id { get; set; }
        //[Required(ErrorMessage = "Request No is Required")]
        //public int request_no { get; set; }
        [Required(ErrorMessage = "Token No is Required")]
        public int token { get; set; }
        [Required]
        public string appr_name { get; set; }
        [Required]
        public string create_dt { get; set; }
        [Required]
        public string created_by { get; set; }
        [Required]
        public string mod_dt { get; set; }
        [Required]
        public string mod_by { get; set; }
        //  public int request_no { get; set; }
        [Required]
        public string comments { get; set; }
        public int approver_id { get; set; }

    }

    public class TX_POA_Power
    {
        [Key]
        public int pow_id { get; set; }
        public string loc { get; set; }
        public string div { get; set; }
        //public int pow_no { get; set; }
        public string pow_descp { get; set; }
        public string pow_type { get; set; }
        public DateTime create_dt { get; set; }
        public string created_by { get; set; }
        public DateTime mod_dt { get; set; }
        public string mod_by { get; set; }
        public string tx_status { get; set; }
    }


    public class MST_POA_Div
    {
        [Key]
        public int div_id { get; set; }
        public string div_name { get; set; }
    }
    public class MST_POA_loc
    {
        public int loc_id { get; set; }
        public string loc_name { get; set; }
    }
    public class MST_POA_Dept
    {
        public int dept_id { get; set; }
        public string dept_name { get; set; }

    }
    public class MST_POA_Emplevel
    {
        [Key]
        public int emp_levl_id { get; set; }
        public string emp_levl { get; set; }
        public DateTime create_dt { get; set; }
        public string created_by { get; set; }
        public DateTime mod_dt { get; set; }
        public string mod_by { get; set; }
    }
}


