﻿using System;
using System.Collections.Generic;
using System.Text;
using WebCoreApp.Application.ViewModels.Blog;
using WebCoreApp.Utilities.Dtos;

namespace WebCoreApp.Application.Interfaces
{
    public interface IPageService : IDisposable
    {
        void Add(PageViewModel pageVm);

        void Update(PageViewModel pageVm);

        void Delete(int id);

        List<PageViewModel> GetAll();

        PagedResult<PageViewModel> GetAllPaging(string keyword, int page, int pageSize);

        PageViewModel GetByAlias(string alias);

        PageViewModel GetById(int id);

        void SaveChanges();

    }
}
