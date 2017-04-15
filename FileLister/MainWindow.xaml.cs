using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace FileLister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            string[] files = Directory.GetFiles(filename.Text);
            //string[] dir = Directory.GetDirectories();
            foreach (string f in files)//string d in dir
            {
                filelist.AppendText(f.ToString()+"\n");
            }
        }

        private void filename_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
