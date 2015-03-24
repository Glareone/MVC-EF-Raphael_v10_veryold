using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LessonProject.Model;
using Ninject;
using LessonProject.Models.ViewModels;
using LessonProject.Models;
using LessonProject.Areas.Default.Controllers;

namespace LessonProject.Models
{
    public static class StaticInfo
    {
        public static int[] info=new int[100];
        public static Dictionary<DateTime,string> contactchat=new Dictionary<DateTime,string>();
        public static Dictionary<DateTime, string> contactchatwithdriver = new Dictionary<DateTime, string>();
        public static Dictionary<int, List<int>> UserOrders = new Dictionary<int, List<int>>();
        public static Dictionary<int, string> Info_about_Order = new Dictionary<int, string>();
    }
}