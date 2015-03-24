using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LessonProject.Model;
using Ninject;
using LessonProject.Models.ViewModels;
using LessonProject.Models;

namespace LessonProject.Areas.Default.Controllers
{
    public class HomeController : DefaultController
    {
        public ActionResult Index(string strControlPage)
        {
            if (strControlPage == null)
            {
                ViewBag.strControlPage = "";
            }
            else
            {
                ViewBag.strControlPage = strControlPage;
            }
            
            return View();
        }

        public ActionResult UserLogin()
        {
            return View(CurrentUser);
        }
        [HttpGet]
        public ActionResult PersonalInfo()
        {
            ViewBag.avatarpath = String.Format("../Content/themes/pics/{0}.jpg", CurrentUser.ID);
            return View(CurrentUser);
        }
        [HttpPost]
        public ActionResult PersonalInfo(string str)
        {
            ViewBag.avatarpath = String.Format("../Content/themes/pics/{0}.jpg", CurrentUser.ID);
            return View(CurrentUser);
        }

        public ActionResult AboutUs()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Graphic()
        {
            int Days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            ViewBag.Days = Days;
            ViewBag.datetime = DateTime.Now;
            return View();
        }
        [HttpPost]
        public ActionResult Graphic(List<string> data)
        {
            //сделаем временную заглушку.
            if (DateTime.Now.Day.ToString() == data[0] && StaticOrder.ID.Count()!=0)
            {
                ViewBag.transportinfo = "в этот день запланированы перевозки, посмотрите отчеты";
                ViewBag.Count = StaticOrder.starttime.Count();
                ViewBag.starttimemas = StaticOrder.starttime;
                ViewBag.stoptimemas = StaticOrder.stoptime;
                ViewBag.datetime = DateTime.Now;
                ViewBag.Days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            }
            else
            {
                string str = String.Format("на {0} число перевозок не запланировано", data[0]);
                ViewBag.transportinfo = str;
                ViewBag.datetime = DateTime.Now;
                ViewBag.Days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            }
            
            
            //ViewBag.abouttransport = str;
            /*
            int Days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            ViewBag.Days = Days;
            ViewBag.datetime = DateTime.Now;
            */
             return View();
        }

        public ActionResult News()
        {
            return View();
        }
        [HttpGet]
        public ActionResult NewOrder() //заказ перевозки новым пользователем
        {
            var newOrderView = new OrderView();
            ViewBag.CurUser = CurrentUser;
            return View(newOrderView);
        }
        [HttpPost]
        public ActionResult NewOrder(OrderView orderview) //заказ перевозки новым пользователем
        {
            if (orderview.StartHour < DateTime.Today.Hour)
            {
                ViewBag.Message = "Ваш заказ не принят, проверьте время заказа";
            }
            else if (orderview.Name != null && orderview.PhoneNumber != null)
            {
                StaticOrder.ID.Add(CurrentUser.ID);
                //StaticOrder.ID.Add(orderview.ID);
                StaticOrder.phonenumber.Add(orderview.PhoneNumber);
                StaticOrder.clientname.Add(orderview.Name);
                var startdate = DateTime.Today;
                startdate = startdate.AddHours((double)orderview.StartHour);
                StaticOrder.starttime.Add(startdate);
                var stopdate = DateTime.Today;
                stopdate = stopdate.AddHours((double)orderview.StopHour);
                StaticOrder.stoptime.Add(stopdate);
                StaticOrder.cost.Add((orderview.StopHour-orderview.StartHour)*260000);
                //StaticOrder.starttime.Add(orderview.StartHour);
                //StaticOrder.stoptime.Add(orderview.StopHour);
                ViewBag.Message = "Ваш заказ принят, свяжитесь с диспетчером для уточнения деталей";
            }
            else
            {
                ViewBag.Message = "Ваш заказ не принят";
            }
            return View(orderview);
        }

        public ActionResult Orders()
        {
            if (StaticOrder.ID.Count != 0)
            {
                ViewBag.ID = StaticOrder.ID;
                ViewBag.Name = StaticOrder.clientname;
                ViewBag.Phonenumber = StaticOrder.phonenumber;
                ViewBag.Starttime = StaticOrder.starttime;
                ViewBag.Stoptime = StaticOrder.stoptime;
                ViewBag.Cost = StaticOrder.cost;
            }
            else
            {
                ViewBag.Message = "Заказы в базе данных отсутствуют";
            }
            
                return View(CurrentUser); //подумать что здесь вернуть
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Newmessages = StaticInfo.contactchat;
            ViewBag.Count = StaticInfo.contactchat.Count;
            return View();
        }
        [HttpPost]
        public ActionResult Contact(List<string> Message)
        {
            StaticInfo.contactchat.Add(DateTime.Now, Message[0]);
            ViewBag.Newmessages = StaticInfo.contactchat;
            ViewBag.Count = StaticInfo.contactchat.Count;

            //Globalstring.Add(ViewBag.Newmessage);
            //cacheforchat.Add(DateTime.Now, contactView.Message);
            //contactView.AllMessages = cacheforchat;
            return View();
        }

        [HttpGet]
        public ActionResult Contactwithdriver()
        {
            ViewBag.Newmessages = StaticInfo.contactchatwithdriver;
            ViewBag.Count = StaticInfo.contactchat.Count;
            return View(CurrentUser);
        }
        [HttpPost]
        public ActionResult Contactwithdriver(List<string> Message)
        {
            StaticInfo.contactchatwithdriver.Add(DateTime.Now, Message[0]);
            ViewBag.Newmessage = StaticInfo.contactchatwithdriver;
            ViewBag.Count = StaticInfo.contactchatwithdriver.Count;
            return View(CurrentUser);
        }
        public ActionResult Report()
        {
            return View();
        }

    }
}
