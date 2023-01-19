using DevExpress.XtraEditors;
using SalesApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp.Forms
{
    public partial class frm_Stores : XtraForm
    {
        DAL.Store store;
        DAL.dbDataContext db = new DAL.dbDataContext();
        public frm_Stores()
        {
            InitializeComponent();
            New();
        }
        public frm_Stores(int id)
        {
            InitializeComponent();

            store = db.Stores.Where(s => s.ID == id).FirstOrDefault();
            GetData();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        void Save()
        {
            if (textEdit1.Text.Trim() == string.Empty)
            {
                textEdit1.ErrorText = "برجاء ادخال الاسم  ";
                return;

            }

            if (store.ID == 0)
                db.Stores.InsertOnSubmit(store);
            else
                db.Stores.Attach(store);

            SetData();
            db.SubmitChanges();

            XtraMessageBox.Show("تم الحفظ بنجاح");
        }
        void GetData()
        {
            textEdit1.Text = store.Name;
        }
        void SetData()
        {
            store.Name = textEdit1.Text;
        }
        void New()
        {
            store = new DAL.Store();

            GetData();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (XtraMessageBox.Show("هل تريد الحذف") == DialogResult.Yes)
            {
                var db = new DAL.dbDataContext();
                db.Stores.Attach(store);
                db.Stores.DeleteOnSubmit(store);
                db.SubmitChanges();
                XtraMessageBox.Show("تم الحذف بنجاح");
                New();
            }

        }
    }
}
