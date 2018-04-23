using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChildStandaloneForm
{
    public partial class MyBrowser : UserControl
    {
        const int topIndent = 30;
        const string startPage = "http://www.google.com";
        public MyBrowser()
        {
            InitializeComponent();
            SubscribeWebBrowserEvents();
            LoadNewDocument(startPage);
            buttonEdit1.KeyDown += new KeyEventHandler(buttonEdit1_KeyDown);
            this.Resize += new EventHandler(MyBrowser_Resize);
            this.Disposed += new EventHandler(MyBrowser_Disposed);
        }

        void MyBrowser_Disposed(object sender, EventArgs e)
        {
            webBrowser1.Dispose();
        }

        void MyBrowser_Resize(object sender, EventArgs e)
        {
            webBrowser1.Width = this.Width - 6;
            webBrowser1.Height = this.Height - topIndent;
        }

        void buttonEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadNewDocument(buttonEdit1.Text);
        }

        private void SubscribeWebBrowserEvents()
        {
            webBrowser1.DocumentTitleChanged += new EventHandler(webBrowser1_DocumentTitleChanged);
            webBrowser1.CanGoBackChanged += new EventHandler(webBrowser1_CanGoBackChanged);
            webBrowser1.CanGoForwardChanged += new EventHandler(webBrowser1_CanGoForwardChanged);
        }

        void webBrowser1_CanGoForwardChanged(object sender, EventArgs e)
        {
            btnForward.Enabled = webBrowser1.CanGoForward;
        }

        void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            btnBack.Enabled = webBrowser1.CanGoBack;
        }
        void webBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            SetTitle(webBrowser1.DocumentTitle);
            buttonEdit1.Text = Convert.ToString(webBrowser1.Url);
        }

        // Fields...
        private string _Title;

        public string Title { get { return _Title; } }

        public event EventHandler TitleChanged;

        protected virtual void OnTitleChangedEvent()
        {
            if (TitleChanged != null)
                TitleChanged(this, EventArgs.Empty);
        }

        private void SetTitle(string s)
        {
            _Title = s;
            OnTitleChangedEvent();
        }

        private void LoadNewDocument(string address)
        {
            if (String.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                webBrowser1.Navigate(new Uri(address));
                buttonEdit1.Text = address;
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            LoadNewDocument(buttonEdit1.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            LoadNewDocument(buttonEdit1.Text);
        }
    }
}
