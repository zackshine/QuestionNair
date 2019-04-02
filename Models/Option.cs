using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionNair.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
