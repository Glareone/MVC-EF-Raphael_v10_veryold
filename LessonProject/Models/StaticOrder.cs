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
    public static class StaticOrder
    {
       public static List<int> ID = new List<int>();
       public static List<string> clientname = new List<string>();
       public static List<string> phonenumber = new List<string>();
       public static List<DateTime> starttime = new List<DateTime>();
       public static List<DateTime> stoptime = new List<DateTime>();
       public static List<int> cost = new List<int>();


    }
}