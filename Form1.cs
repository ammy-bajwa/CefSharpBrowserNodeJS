using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharpBrowserNodeJS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser brower;
        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings browserSettings = new CefSettings();
            Cef.Initialize(browserSettings);
            brower = new ChromiumWebBrowser("https://www.google.com");
            this.pContainer.Controls.Add(brower);
            brower.Dock = DockStyle.Fill;
        }
    }
}
