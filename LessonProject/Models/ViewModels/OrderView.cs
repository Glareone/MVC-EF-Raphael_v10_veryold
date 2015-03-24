using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LessonProject.Models.ViewModels
{
    public class OrderView
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Введите Ваше Имя")]
        public string Name { get; set; }
         [Required(ErrorMessage = "Введите Ваш Телефон")]
        public string PhoneNumber { get; set; }
        public int StartHour { get; set; }
        public int StopHour { get; set; }

        public IEnumerable<SelectListItem> StartTimeSelectList
        {
            get
            {
                for (int i = 10; i <= 19 ; i++)
                {
                    yield return new SelectListItem
                    {
                        Value = i.ToString(),
                        Text = i.ToString(),
                        Selected = StartHour == i
                    };
                }
            }
        }

        public IEnumerable<SelectListItem> StopTimeSelectList
        {
            get
            {
                for (int i = 11; i <= 23; i++)
                {
                    yield return new SelectListItem
                    {
                        Value = i.ToString(),
                        Text = i.ToString(),
                        Selected = StopHour == i
                    };
                }
            }
        }






    }
}