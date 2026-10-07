using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentFeedbackMVC.Models
{
    public class Feedback
    {
        public string EnrollmentNo
        {
            get; set;
        }
        public string StudentName
        {
            get; set;
        }
        public string Subject
        {
            get; set;
        }
        public string Rating
        {
            get; set;
        }
        public string Comments
        {
            get; set;
        }
    }
}