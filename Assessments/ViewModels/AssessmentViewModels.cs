﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assessments.ViewModels.AssessmentViewModels
{
    public class AssessmentIndexViewModel
    {
        public List<AssessmentListItem> AvailableAssessments { get; set; }
    }

    public  class AssessmentListItem
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public bool Started { get; set; }
        public List<AnswerCategoryListItem> Categories { get; set; }
    }

    public class ConductAssessmentViewModel
    {
        public int CategoryID { get; set; }
        public List<AnswerQuestonViewModel> Questions { get; set; }
        public AnswerQuestonViewModel Question { get; set; }
    }

    public class AnswerQuestonViewModel
    {
        public int ID { get; set; }
        public string QuestionHeading { get; set; }
        public string QuestionBody { get; set; }
        public string Comment { get; set; }
        public List<AnswerLevelListItem> Levels { get; set; }
    }

    public class AnswerCheckoffItem
    {
        public int ID { get; set; }
        public int LevelID { get; set; }
        public string Wording { get; set; }
        public bool Checked { get; set; }
    }

    public class AnswerCategoryListItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Started { get; set; }
    }

    public class AnswerLevelListItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<AnswerCheckoffItem> CheckoffItems { get; set; }
    }
}