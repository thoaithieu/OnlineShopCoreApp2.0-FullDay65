﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreApp.Application.ViewModels.Common;

namespace WebCoreApp.Models
{
    public class ContactPageViewModel
    {
        public ContactViewModel Contact { set; get; }
        public FeedbackViewModel Feedback { set; get; }
    }
}
