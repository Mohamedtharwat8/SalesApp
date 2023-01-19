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
    public partial class frm_StoresLis : XtraForm
    {
        DAL.Store store;

        public frm_StoresLis()
        {
            InitializeComponent();
        }

        private void frm_StoresLis_Load(object sender, EventArgs e)
        {
            RefreshData();

            gridView1.OptionsBehavior.Editable= false;
            gridView1.Columns["ID"].Visible = false;
            gridView1.Columns["ID"].Caption = "الاسم";
            gridView1.DoubleClick += GridView1_DoubleClick;

        }

        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            id=   Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));


            frm_Stores frm = new frm_Stores(id);
            frm.Show();

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshData();
        }

        void RefreshData()
        {
            var db = new DAL.dbDataContext();

            gridControl1.DataSource = db.Stores;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Stores frm = new frm_Stores();
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var db = new DAL.dbDataContext();
            //db.Stores.Attach(store);
            //db.Stores.DeleteOnSubmit(store);
            //db.SubmitChanges();
            //XtraMessageBox.Show("تم الحذف بنجاح");
            //RefreshData();

        }
    }
}
