using NuGet.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
namespace DependencyChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists(@"C:\Users\uer\source\repos\DependencyChecker\bin\Debug\Dependency.dat")){
                var lines = File.ReadAllLines(@"C:\Users\uer\source\repos\DependencyChecker\bin\Debug\Dependency.dat");
                List<string> lst = new List<string>();
                string[] stringArray = System.IO.File.ReadAllLines(@"C:\Users\uer\source\repos\DependencyChecker\bin\Debug\Dependency.dat");
                foreach (string example in stringArray)
                {
                    lst.Add(example.Trim().ToString());
                }
                DirectoryInfo d = new DirectoryInfo(@"C:\Program Files (x86)\Default Company Name\Foldio-Desktop-Setup");
                FileInfo[] Files = d.GetFiles("*.*"); 
                List<string> str2 = new List<string>();
                foreach (FileInfo file in Files)
                {
                    str2.Add(file.Name.ToString());
                }

                int flag = 0;
                foreach (string str in lst)
                {
                    flag = 0;
                    //lst.Find(str);
                    foreach (string str3 in str2)
                    {
                        if (str.Equals(str3))
                        {
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Dependencyc "+str+" Not Found in Installation Dir. Repair Application Installation to continue.");
                        break;
                    }
                }
                if (flag!=1)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Dependency Not Found. Repair Application Installation to continue.");
            }
            
        }
    }
}
