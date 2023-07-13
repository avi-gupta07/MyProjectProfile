using MyProjectProfile.DBModel;
using MyProjectProfile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProjectProfile.Controllers
{
    [RoutePrefix("ABCompanyURL") ]
    public class MyProfileHomeController : Controller
    {
        // GET: MyProfileHome
        [Route("Profile/")]
        public ActionResult Index()
        {
            Session["Message"] = "This message is from the session that will show LoggedIn userId";
            ProfileDBContext profileDBContext = new ProfileDBContext();
            Profile_Table_DTO profile_table = new Profile_Table_DTO();

            List<Greeting> greeting = profileDBContext.Greetings.ToList();
            List<SelectListItem> selectGreetingListItems = new List<SelectListItem>();

            foreach (Greeting greet in greeting)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text= greet.Gretting_Name,
                    Value = greet.GreetingID.ToString(),
                };

                selectGreetingListItems.Add(selectList);
            }

            List<Industry_Worked> industry_worked = profileDBContext.Industry_Worked.ToList();  
            List<SelectListItem> selectIndustry_workedList = new List<SelectListItem>();

            foreach (Industry_Worked industry_w in industry_worked)
            {
                SelectListItem selectList = new SelectListItem()
                {
                    Text = industry_w.Industry_name,
                    Value = industry_w.Industry_id.ToString()
                };

                selectIndustry_workedList.Add(selectList);
            }


            List<Terms_Conditions> tc = profileDBContext.Terms_Conditions.ToList();

            CompleteProfile cp = new CompleteProfile() {
                ProfileTable= profile_table,
                Greeting= selectGreetingListItems,
                Industry_Worked= selectIndustry_workedList,
                Terms_Conditions= tc
            };



            return View(cp);
        }

        [HttpPost]
        [Route("PostProfile")]
        public ActionResult Index(CompleteProfile cp,HttpPostedFileBase Profile_Resume)
        {

            string path = Server.MapPath("~/App_Data/Profile_Resumes");
            string fileName = Path.GetFileName(Profile_Resume.FileName);
            string full_path = Path.Combine(path, fileName);

           Profile_Resume.SaveAs(full_path);

            // return View();
            return RedirectToAction("Profile", "ABCompanyURL");     
        } 
    }
}