using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebExamination_MVC.Models;

namespace WebExamination_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        // Test block
        #region Test Block
        [HttpGet]
        public ViewResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Registration(UserRegistrationResponse user)
        {
            // Нужно отправить данные нового гостя no электронной почте 
            // организатору вечеринки.
            return View("Thanks", user);
        }

        public ViewResult TestCreation()
        {
            return View();
        }

        [HttpPost]
        public void TestCreation(Test test)
        {
            Response.Write("ID: " + test.ID);                    // вывод айдишника теста
            Response.Write("<br />");
            Response.Write("Test Name: " + test.Name);           // вывод имени теста
            Response.Write("<br />");
            Response.Write("Test Desc: " + test.Description);    // вывод описания теста
            Response.Write("<br />");
            foreach (var quest in test.Questions)
            {
                // Response.Write(test.Questions[0].Description);
                // вывод вопроса и его типа
                if (quest != null)
                {
                    Response.Write("Question: " + quest.Description); Response.Write("  QuestionType: " + quest.QuestionType);
                    Response.Write("<br />");
                }

                try
                {
                    // вывод ответов пренадлежащих этому вопросу
                    foreach (var answer in quest.Answers)
                    {
                        if (answer != null)
                        {
                            Response.Write("Answer: " + answer.Description);
                            Response.Write("IsCorrectAnswer?: " + answer.IsCorrect);
                            Response.Write("<br />");
                        }
                    }
                }
                catch { }
            }
            Response.Write("<br />");
            //    Response.Write(test.Questions[0].Answers[0].Description);

            Response.Write("<br />");
            Response.Write(test.Duration);                      // длительность прохождения теста
            Response.Write("<br />");
            //  Response.Write(test.IsOpen);                        // открыт ли тест
            Response.Write("<br />");
            Response.Write("Test Creation Date: " + (test.CreationDate = DateTime.Now));

        }
        #endregion
    }
}
