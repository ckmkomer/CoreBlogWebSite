﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EnttiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository:GenericRepository<Blog>,IBlogDal
    {
    }
}
