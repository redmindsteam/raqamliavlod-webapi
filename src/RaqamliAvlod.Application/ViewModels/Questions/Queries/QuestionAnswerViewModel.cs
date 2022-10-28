﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaqamliAvlod.Application.ViewModels.Questions.Queries;

public class QuestionAnswerViewModel
{
    public string Description { get; set; } = String.Empty;
    public bool HasReplied { get; set; }

    public long QuestionId { get; set; }

    public long? ParentId { get; set; }
}
