using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Screenshots
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

        private void takeScreen_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(400);
            SendKeys.SendWait("{PRTSC}");
            System.Drawing.Image img = System.Windows.Forms.Clipboard.GetImage();
            string currentDirectory = string.Empty;
            if (!string.IsNullOrEmpty(txbPath.Text) && Directory.Exists(txbPath.Text))
            {
                currentDirectory = txbPath.Text;
            }
            else
            {
                currentDirectory = @"C:\Users\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1] + @"\Pictures\Screenshots";
                if (!Directory.Exists(currentDirectory))
                    Directory.CreateDirectory(currentDirectory);
            }
            DateTime timeNow = DateTime.Now;
            string fileName = timeNow.Year + "-" + timeNow.Month + "-" + timeNow.Day + " " + timeNow.Hour + timeNow.Minute + timeNow.Second;
            using (Stream s = new FileStream(currentDirectory + @"\" + fileName + ".jpg", FileMode.Create, FileAccess.Write))
                img.Save(s, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.Show();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(400);
            SendKeys.SendWait("{PRTSC}");
            System.Drawing.Image img = System.Windows.Forms.Clipboard.GetImage();
            string currentDirectory = string.Empty;
            if (!string.IsNullOrEmpty(txbPath.Text) && Directory.Exists(txbPath.Text))
            {
                currentDirectory = txbPath.Text;
            }
            else
            {
                currentDirectory = @"C:\Users\" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1] + @"\Pictures\Screenshots";
                if (!Directory.Exists(currentDirectory))
                    Directory.CreateDirectory(currentDirectory);
            }
            DateTime timeNow = DateTime.Now;
            string fileName = timeNow.Year + "-" + timeNow.Month + "-" + timeNow.Day + " " + timeNow.Hour + timeNow.Minute + timeNow.Second;
            using (Stream s = new FileStream(currentDirectory + @"\" + fileName + ".jpg", FileMode.Create, FileAccess.Write))
                img.Save(s, System.Drawing.Imaging.ImageFormat.Jpeg);
            this.Show();
        }
    }
}
