using ManageOrdersApp.BLL.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagerOrdersApp.BL.Impl
{
    public class CsvFileReader
    {
        private static int _indexOrderDate=0;
        private static int _indexCustomer = 1;
        private static int _indexProduct = 2;
        private static int _indexAmount= 3;
        private string _pathFile;
        public char Dilimiter { get; set; } = ';';
        private string[] _orderValues;
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
                Regex r = new Regex(@"\w+_\d{8}$");
                if (r.IsMatch(managerDataFromFileName))
                {
                    throw new Exception("Invalid file name");
                }
                Manager manager = new Manager();
                manager.LastName = GetManagerLastName(managerDataFromFileName);
                return manager;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void GetObject(string sourceLine)
        {
            int countDilimiter = new Regex($@"{Dilimiter}").Matches(sourceLine).Count;
            if (countDilimiter>3)
            {
                throw new FormatException("Uncorrect record");
            }
           _orderValues=sourceLine.Split(new char[] { Dilimiter },StringSplitOptions.RemoveEmptyEntries);
        }
        public Product GetProduct()
        {

            return new Product() { Name = _orderValues[_indexProduct]?.Trim()};
        }

        private string GetFileName(string pathFile)
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
        private decimal ParceToDecimal(string source)
        {
            return decimal.Parse(source.Replace(",", "."));
        }
        private string GetManagerLastName(string source)
        {
            return source.Split('_')[0];
            
        }private DateTime GetReportDate(string source)
        {
            string[] managerData = source.Split('_');
            return DateTime.Parse(managerData[1]);
        }
    }
}
