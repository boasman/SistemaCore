using SistemaCore.Modelos.Interventions.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCore.Modelos.Interventions
{
    public class RespIntervention
    {

        public int scheduled_date { get; set; }
        public int status { get; set; }
        public string description { get; set; }
        public object notes { get; set; }
        public object email { get; set; }
        public string master_company_code { get; set; }
        public string master_company_id { get; set; }
        public string insured_name { get; set; }
        public string id { get; set; }
        public string case_reference { get; set; }
        public string case_id { get; set; }
        public object address { get; set; }
        public string handymanPhone { get; set; }
        public string slave_user_desc { get; set; }
        public bool anon { get; set; }
        public string code { get; set; }
        public string handyman_id { get; set; }
        public string remote_url { get; set; }
        public string url { get; set; }
        public List<object> notification_ids { get; set; }


        //public string id { get; set; }
        //public string code { get; set; }
        //public string case_id { get; set; }
        //public string case_reference { get; set; }
        //public string address { get; set; }
        //public string master_company_id { get; set; }
        //public string master_company_code { get; set; }
        //public string agent_id { get; set; }
        //public string master_user_desc { get; set; }
        //public string handyman_id { get; set; }
        //public bool handyman_status { get; set; }
        //public string remote_web_device { get; set; }
        //public int anon { get; set; }
        //public bool smsReceived { get; set; }
        //public int type { get; set; }
        //public string description { get; set; }
        //public int status { get; set; }
        //public int scheduled_date { get; set; }
        //public int startedAt { get; set; }
        //public int lastCallTime { get; set; }
        //public int callLength { get; set; }
        //public string comments { get; set; }
        //public string notes { get; set; }
        //public string createdBy { get; set; }
        //public string updatedBy { get; set; }
        //public int createdAt { get; set; }
        //public int updateAt { get; set; }
        //public List<Image> images { get; set; }
        //public List<Video> videos { get; set; }
        //public List<Document> documents { get; set; }
        //public object email { get; set; }
        //public string insured_name { get; set; }
        //public string handymanPhone { get; set; }
        //public string slave_user_desc { get; set; }
        //public string remote_url { get; set; }
        //public string url { get; set; }
        //public List<object> notification_ids { get; set; }
    }
}
