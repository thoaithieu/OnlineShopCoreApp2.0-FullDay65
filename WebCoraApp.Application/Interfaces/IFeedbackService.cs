﻿using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Application.ViewModels.Common;
using WebCoreApp.Utilities.Dtos;

namespace WebCoreApp.Application.Interfaces
{
    public interface IFeedbackService
    {
        void Add(FeedbackViewModel feedbackVm);

        void Update(FeedbackViewModel feedbackVm);

        void Delete(int id);

        List<FeedbackViewModel> GetAll();

        PagedResult<FeedbackViewModel> GetAllPaging(string keyword, int page, int pageSize);

        FeedbackViewModel GetById(int id);

        void SaveChanges();
    }
}
