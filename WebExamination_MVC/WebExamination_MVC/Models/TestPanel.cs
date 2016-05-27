using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebExamination_MVC.Models
{
    public class Test
    {
        public string ID { get; set; }                   // ID Теста
        public string Name { get; set; }                 // Имя теста
        public string Description { get; set; }          // Описание теста
        public List<Question> Questions { get; set; }    // Список вопросов
        public TimeSpan? Duration { get; set; }          // Выделяемое время на сдачу теста
        public DateTime CreationDate { get; set; }       // Дата создания теста
        public bool IsOpen { get; set; }                 // Открыт ли тест.        
        public DateTime DateOfOpen { get; set; }         // Задать даты когда тест доступен для решения
        public DateTime DateOfClose { get; set; }        // Конец даты доступа к тесту.
    }

    public enum QuestionType
    {
        RadioButton,
        CheckBox,
        TextArea
    }

    public class Question
    {
        public string Description { get; set; }
        public QuestionType QuestionType { get; set; }
        public IList<Answer> Answers { get; set; }

        public string ImagePath { get; set; }
    }

    public class Answer
    {
        public string Description { get; set; }
        public bool IsCorrect { get; set; }
        public string ImagePath { get; set; }
        
    }
}