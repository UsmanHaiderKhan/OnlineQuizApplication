﻿using System.ComponentModel.DataAnnotations;

namespace OnlineQuizClasses.QuizManagement
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Question Statement")]
        public string Questions { get; set; }
        [Required]
        public string Option1 { get; set; }
        [Required]
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        [Required]
        public string CorrectAnswer { get; set; }

        public Quiz Quiz { get; set; }
    }
}
