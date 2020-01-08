using ManageOrdersApp.Core.Interfaces;
using ManagerOrdersApp.BL.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerOrdersApp.BLL
{
    public class ReaderService:IReaderService
    {
        private IFileReader _reader;
        private IUnitOfWork _unitOfWork;
        public void Begin(string pathFile)
        {

        }
    }
}
