using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NewNotebook
{
  public partial class PrintInfo : Form
  {
        string DataFileName = @"C:\PDApractice\WASAP.txt";
        public PrintInfo()
        {
          
            InitializeComponent();
            
            if (CheckExistDataFile())
            {
                string text = ReadDataFile();
                PrintInfomation.Text = text;
            }
            else
            {
                MessageBox.Show("자료가 없습니다.",empt);
            }

        }
        string empt = "실패";
    
        private bool CheckExistDataFile()
        {
            bool exist = File.Exists(DataFileName);
            return exist;
        }

        private string ReadDataFile()
        {
            string text = System.IO.File.ReadAllText(DataFileName);
            return text;
        }

    }

}
