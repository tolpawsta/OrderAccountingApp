using CSVGenerateApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVGenerateApp
{
    public partial class CSVGenerateAppForm : Form
    {
        
        private string _defaultPathDir = $@"{Application.StartupPath}\{ConfigurationManager.AppSettings.Get("PathSourceDirectory")}";
        private int _defaultCountOfFiles;
        private string _carrentPathDir = String.Empty;
        private int _currentCountOfFiles;
        IFileCreator fileCreator;
        public CSVGenerateAppForm()
        {
            InitializeComponent();
            this.Load += CSVGenerateAppForm_Load;
            txtPath2Souce4CsvFile.TextChanged += TxtPathToTargetCsv_TextChanged;
            txtCountFiles.TextChanged += TxtCountFiles_TextChanged;
            btnGenerate.Click += BtnGenerate_Click;
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtPathToTargetCsv_TextChanged(object sender, EventArgs e)
        {
            TextBox activeTextBox = (TextBox)sender;


            if (String.IsNullOrEmpty(activeTextBox.Text))
            {
                _carrentPathDir = _defaultPathDir;
                txtPath2Souce4CsvFile.Text = _carrentPathDir;

            }
            _carrentPathDir = txtPath2Souce4CsvFile.Text;

        }
        private void TxtCountFiles_TextChanged(object sender, EventArgs e)
        {
            TextBox activeTextBox = (TextBox)sender;
            int countOfFiles;
            bool isNumber = int.TryParse(activeTextBox.Text, out countOfFiles);
            if (String.IsNullOrEmpty(activeTextBox.Text) || !isNumber || countOfFiles <= 0)
            {
                _currentCountOfFiles = _defaultCountOfFiles;
                txtCountFiles.Text = _currentCountOfFiles.ToString();

            }
            else
            {

                _carrentPathDir = txtCountFiles.Text;
            }
        }

        private void CSVGenerateAppForm_Load(object sender, EventArgs e)
        {
            _carrentPathDir = _defaultPathDir;
            txtPath2Souce4CsvFile.Text = _carrentPathDir;
            int.TryParse(ConfigurationManager.AppSettings.Get("CountOfFiles"), out _defaultCountOfFiles);
            _currentCountOfFiles = _defaultCountOfFiles;
            txtCountFiles.Text = _currentCountOfFiles.ToString();
           
        }
    }
}
