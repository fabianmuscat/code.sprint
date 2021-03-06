using System.Collections.Generic;

namespace Application.ViewModels
{
    public class QuestionViewModel
    {
        public string QuestionType { get; set; }
        public string QuestionText { get; set; }
        public string Category { get; set; }

        public List<AnswerViewModel> Answers { get; set; }
    }
}