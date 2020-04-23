using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        ChromiumWebBrowser browser;
        private void Form1_Load(object sender, EventArgs e)
        {
            CefSettings browserSettings = new CefSettings();
            Cef.Initialize(browserSettings);
            browser = new ChromiumWebBrowser("http://localhost:3000/");
            browser.Dock = DockStyle.Fill;
            browser.JavascriptObjectRepository.Register("boundAsync", new BoundObject(), true);
            this.pContainer.Controls.Add(browser);
        }

        public class BoundObject
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
        }
    }
}
