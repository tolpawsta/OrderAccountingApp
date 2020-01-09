using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerOrdersApp.BL.Impl
{
    public class CsvFileReader
    {
        private string _pathFile;
        public string Dilimiter { get; set; } = ";";  
        public CsvFileReader(string pathFile)
        {
            _pathFile = pathFile;
        }
        
        public Manager GetManager()
        {
            try
            {
                string fileName = GetFileName(_pathFile);
                string managerDataFromFileName = Path.GetFileNameWithoutExtension(fileName);

            }
            catch (Exception)
            {

                throw;
            }
        }
        private String GetFileName(string pathFile)
        {

            return Path.GetFileName(pathFile);
        }
        private void GetCustomerFirstLastNames(out string firstName, out string lastName, string source)
        {
            string[] names = source.Split(' ');
            firstName = names[0];
            lastName = names[1];
        }

        private DateTime ParceToDate(string source)
        {
            return DateTime.Parse(source);
        }
        private Decimal ParceToDecimal(string source)
        {
            return decimal.Parse(source.Replace(",", "."));
        }
        private String GetManagerLastName(string source)
        {
            return source.Split('_')[0];
            
        }private DateTime GetReportDate(string source)
        {
            string[] managerData = source.Split('_');
            return DateTime.Parse(managerData[1]);
        }
    }
}
