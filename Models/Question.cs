using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionNair.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public List<Option> Options { get; set; }

        public List<Answer> Answers { get; set; }
    }
}
