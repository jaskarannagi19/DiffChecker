using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiffChecker.Model
{
    public class JobModel
    {
        public Job[] JobClass { get; set; }
    }
    public class Job
    {
        public string title { get; set; }
        //public string date { get; set; }
        //public string referencenumber { get; set; }
        //public string url { get; set; }



        //public string company { get; set; }
        //public string city { get; set; }
        //public string state { get; set; }
        //public string country { get; set; }
        //public string postalcode { get; set; }
        //public string salary { get; set; }
        //public string education { get; set; }
        //public string jobtype { get; set; }
        //public string officeid { get; set; }
        //public string categories { get; set; }
        //public string vakgebied { get; set; }
        //public string functions { get; set; }
        //public string experience { get; set; }
        //public string vacancy_reason { get; set; }
        public string description { get; set; }
        //public string sponsored { get; set; }
        //public string budget { get; set; }
        //public string email { get; set; }
    }


}

