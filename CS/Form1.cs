using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraRichEdit;
using DevExpress.XtraBars.Docking2010.Views;

namespace ChildStandaloneForm
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            tabbedView1.FloatingDocumentContainer = DevExpress.XtraBars.Docking2010.Views.FloatingDocumentContainer.DocumentsHost;
        }

        List<BaseDocument> docs = new List<BaseDocument>();
        private void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {
            MyBrowser wb = new MyBrowser();
            wb.Dock = DockStyle.Fill;
            wb.TitleChanged += wb_TitleChanged;
            docs.Add(e.Document);
            e.Control = wb;
        }

        private Document FindDocument(object documentControl)
        {
            foreach (Document doc in docs)
                if (doc.Control == documentControl)
                    return doc;
            return null;
        }

        void wb_TitleChanged(object sender, EventArgs e)
        {
            tabbedView1.ActiveDocument.Caption = (tabbedView1.ActiveDocument.Control as MyBrowser).Title;
            Document activeFloatDoc = FindDocument(sender); // for floating documents
            if (activeFloatDoc != null)
                activeFloatDoc.Caption = (sender as MyBrowser).Title;
        }
    }
}
