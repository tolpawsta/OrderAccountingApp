using CSVGenerateApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CSVGenerateApp.Impl;

namespace CSVGenerateApp.Assistante
{
    class ScvFileCreator:IFileCreator
    {
        private const int CountTasks= 4;
        private ICollection<string> _customers;
        private ICollection<string> _products;
        private ICollection<decimal> _amounts;
        private ICollection<string> _managers;
        private DirectoryInfo _sourceDir;
        private string _castomersFileName = ConfigurationManager.AppSettings.Get("CastomersFileName");
        private string _productsFileName = ConfigurationManager.AppSettings.Get("ProductsFileName");
        private string _amountsFileName = ConfigurationManager.AppSettings.Get("AmountsFileName");
        private string _managersFileName = ConfigurationManager.AppSettings.Get("ManagersFileName");
        public ScvFileCreator()
        {
            _customers = new List<string>();
            _products = new List<string>();
            _amounts = new List<decimal>();
            _managers = new List<string>();
        }

        public ScvFileCreator(DirectoryInfo sourceDir):this()
        {
            _sourceDir = sourceDir;
        }

        public void Create(IFileable file)
        {
            
        }
        public IFileable CreateScvFile()
        {
            Task<string>[] tasks = new Task<string>[CountTasks];
            for (int i = 0; i < tasks.Length; i++)
            {
                //tasks[i]=Task<string>.
            }
            IFileable file = new CsvFile();
            return file;
        }
        private bool FileExists(string fileName)
        {
            return File.Exists($"{_sourceDir}\\{fileName}");
        }
        private List<string> ReadFile(object pathFile)
        {
            if (!FileExists((string)pathFile))
            {
                throw new FileNotFoundException($"File by path {pathFile} not found!");
            }
            List<string> temp = new List<string>();
            using (var reader = new StreamReader((string) pathFile))
            {
                string line = String.Empty;
                while ((line=reader.ReadLine())!=null)
                {
                    temp.Add(line);
                }
            }
            return temp;
        }
    }
}
