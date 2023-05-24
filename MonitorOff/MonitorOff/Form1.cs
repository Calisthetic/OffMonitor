using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorOff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Opacity = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            SetMonitorState(MonitorState.Off);

            Thread.Sleep(10000);

            SetMonitorState(MonitorState.On);

            Application.Exit();

        }
        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, IntPtr wParam, IntPtr lParam);

        private static void SetMonitorState(MonitorState state)
        {
            SendMessage(0xFFFF, 0x112, (IntPtr)0xF170, (IntPtr)(int)state);
        }

        private enum MonitorState
        {
            On = -1,
            Off = 2,
            StandBy = 1
        }
    }
}
