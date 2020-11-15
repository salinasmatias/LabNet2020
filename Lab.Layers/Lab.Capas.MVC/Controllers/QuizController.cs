using Lab.Capas.MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Lab.Capas.MVC.Controllers
{
    public class QuizController : Controller
    {
        // GET: Quiz
        public ActionResult Index()
        {
            string response = getHttp();
            QuizApiView quiz = JsonConvert.DeserializeObject<QuizApiView>(response);
            return View(quiz.results);
        }

        public ActionResult GetScore(IList<Result> results)
        {
            int correctAnswers = 0;
            foreach(var question in results)
            {
                if(question.correct_answer == question.userResponse)
                {
                    correctAnswers++;
                    question.userResponse = "Correct";
                }
                else
                {
                    question.userResponse = "Wrong";
                }
            }
            TempData["UserScore"] = correctAnswers;
            TempData["Results"] = results;

            return View("Index");
        }

        public static string getHttp()
        {
            WebRequest oRequest = WebRequest.Create("https://opentdb.com/api.php?amount=10&category=15&type=boolean");
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return sr.ReadToEnd().Trim();
        }
    }
}