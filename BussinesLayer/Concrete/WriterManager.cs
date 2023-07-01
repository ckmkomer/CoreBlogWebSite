using BussinesLayer.Abstract;
using EnttiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        public void TAdd(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public Writer TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Writer> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            throw new NotImplementedException();
        }
    }
}
