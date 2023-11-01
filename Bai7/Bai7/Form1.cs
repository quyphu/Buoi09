using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bai7
{
    public partial class QLKhoa : Form
    {
        KetNoi kn = new KetNoi();
        SqlConnection consql;
        public QLKhoa()
        {
            InitializeComponent();
            consql = kn.connect;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btnMK_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (consql.State == ConnectionState.Closed)
                {
                    consql.Open();

                }
                string insertString;
                insertString = "insert into MaKhoa values('" + txtMaKhoa.Text + "',N'" + txtTenKhoa.Text + "')";
                SqlCommand cmd = new SqlCommand(insertString, consql);
                cmd.ExecuteNonQuery();
                if (consql.State == ConnectionState.Open)
                {
                    consql.Close();
                }

                MessageBox.Show("Thanh Cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That Bai");
            }
        }
    }
}
