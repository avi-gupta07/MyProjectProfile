using MyProjectProfile.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProjectProfile.Models
{
    public class CompleteProfile
    {
        public Profile_Table_DTO ProfileTable { get; set; }
        public List<SelectListItem> Greeting { get; set; }
        public List<SelectListItem> Industry_Worked { get; set; }

        public List<Terms_Conditions> Terms_Conditions { get; set; }


       


    }
}