using System;
using System.Collections.Generic;
using System.IO;
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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace ScreenshotFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Bitmap img = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void takeScreen_Click(object sender, RoutedEventArgs e)
        {
            //this.Hide();
            //System.Threading.Thread.Sleep(400);
            //SendKeys.SendWait("{PRTSC}");
            //System.Drawing.Image img = System.Windows.Forms.Clipboard.GetImage();
            //using (Stream s = new FileStream(currentDirectory + @"\" + fileName + ".jpg", FileMode.Create, FileAccess.Write))
            //    img.Save(s, System.Drawing.Imaging.ImageFormat.Jpeg);
            //this.Show();
            this.Hide();
            TakeScreenshot();
            this.Show();
        }

        private string Bebebe(int num)
        {
            if (num / 10 == 0)
            {
                return "0" + num;
            }
            return num.ToString();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            this.Hide();
            TakeScreenshot();
            this.Show();
        }

        private void TakeScreenshot()
        {
            System.Threading.Thread.Sleep(400);
            Graphics gr = Graphics.FromImage(img as System.Drawing.Image);
            gr.CopyFromScreen(0, 0, 0, 0, img.Size);

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
            string fileName = timeNow.Year
                + "-" + Bebebe(timeNow.Month)
                + "-" + Bebebe(timeNow.Day)
                + " " + Bebebe(timeNow.Hour)
                + Bebebe(timeNow.Minute)
                + Bebebe(timeNow.Second);
            using (Stream s = new FileStream(currentDirectory + @"\" + fileName + ".jpg", FileMode.Create, FileAccess.Write))
                img.Save(s, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
