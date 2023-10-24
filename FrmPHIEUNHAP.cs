using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformQuanLyKho
{
    public partial class FrmPHIEUNHAP : Form
    {
        Connect connect = new Connect();
         public FrmPHIEUNHAP()
        {
            InitializeComponent();
            Load();
        }
        void Load ()
        {
            connect.Moketnoi();
            LoaddulieuvaobangPHIEUNHAP();
            Loaddulieuvaotextbox();
        }
        void LoaddulieuvaobangPHIEUNHAP()
        {
            string query = "SELECT * FROM PHIEUNHAP";
            dtgvPHIEUNHAP.DataSource = connect.bangDulieu(query);
        }

        void Loaddulieuvaotextbox()
        {
            txtsophieu.DataBindings.Add(new Binding("Text", dtgvPHIEUNHAP.DataSource, "SOPHIEU"));
        }


    }
}
