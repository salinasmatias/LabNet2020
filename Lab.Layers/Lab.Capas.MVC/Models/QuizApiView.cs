using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.Capas.MVC.Models
{
    public class QuizApiView
    {
        public int response_code { get; set; }
        public IList<Result> results { get; set; }
    }
    public class Result
    {
        public string category { get; set; }
        public string type { get; set; }
        public string difficulty { get; set; }
        [AllowHtml]
        public string question { get; set; }
        public string correct_answer { get; set; }
        public IList<string> incorrect_answers { get; set; }
        public string userResponse { get; set; } = "test";
    }
}