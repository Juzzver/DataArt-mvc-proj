using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExaminationMVC.Models
{
    public class Test
    {
        public string ID { get; set; }                   // ID Теста
        public string Name { get; set; }                 // Имя теста
        public string Description { get; set; }             // Описание теста
        public List<Question> Questions { get; set; }    // Список вопросов
        public TimeSpan? Duration { get; set; }          // Выделяемое время на сдачу теста
        public DateTime CreationDate { get; set; }       // Дата создания теста
        public bool IsOpen { get; set; }                 // Открыт ли тест.        

    }

    public enum QuestionType
    {
        RadioButton = 0,
        CheckBox = 1
    }

    public class Question
    {
        public string Description { get; set; }
        public QuestionType QuestionType { get; set; }
        public IList<Answer> Answers { get; set; }
    }

    public class Answer
    {
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
        
    }

    /*public class Question
    {
        public List<Answer> Answers { get; set; }
        public Answer CorrectAnswer { get; set; }
        public string QustionDesc { get; set; }
        public bool Image { get; set; }
        
    }

    public class Answer
    {
        public string AnswerDesc { get; set; }
        public bool RadioButton { get; set; }
        public bool CheckBox { get; set; }
   //     public bool CorrectAnswer { get; set; }
        
    }*/
}