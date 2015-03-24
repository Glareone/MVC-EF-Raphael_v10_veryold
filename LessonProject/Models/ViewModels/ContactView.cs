using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace LessonProject.Models.ViewModels
{
    public class ContactView
    {

        public DateTime Time { get; set; }
        public Dictionary<DateTime,string> AllMessages { get; set; }
        [Required(ErrorMessage = "Введите Сообщение")]
        public string Message { get; set; }
     
    }
}