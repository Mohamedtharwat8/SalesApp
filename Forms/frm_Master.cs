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
    public partial class frm_Master : Form
    {
        public frm_Master()
        {
            InitializeComponent();
        }


        public virtual void Save()
        {
         }
        public virtual void New()
        {
        }
        public virtual void Delete()
        {
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Save();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            New();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Delete();
        }

        private void frm_Master_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Save();

            }
            if (e.KeyCode == Keys.F2)
            {
                New();

            }
            if (e.KeyCode == Keys.F3)
            {
                Delete();

            }
        }
    }
}
