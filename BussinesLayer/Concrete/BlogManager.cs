using BussinesLayer.Abstract;
using EnttiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        public void TAdd(Blog t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Blog t)
        {
            throw new NotImplementedException();
        }

        public Blog TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Blog> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }
    }
}
