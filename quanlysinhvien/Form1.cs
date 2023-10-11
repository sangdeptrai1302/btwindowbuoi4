using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
{
    public partial class Form1 : Form
    {
        string flag;
        DataTable dtSv;
        
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable createtable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("masv");
            dt.Columns.Add("tensv");
            dt.Columns.Add("ngaysinh");
            dt.Columns.Add("khoa");
            dt.Columns.Add("lop");
            dt.Columns.Add("diachi");
            dt.Columns.Add("gioitinh");
            return dt;

        }
       
        public void khoacontrol()
        {
            btadd.Enabled = true;
            btdelete.Enabled = true;
            btedit.Enabled = true;
            btnluu.Enabled = false;
            btclose.Enabled = true;
            //btluu.Enabled = true;


            
            txtmasv.ReadOnly = true; 
            txtten.ReadOnly = true;
       //    dtngaysinh.ReadOnly = true;
            txtkhoa.ReadOnly = true;
            txtlop.ReadOnly = true;
            txtdc.ReadOnly = true;
            txtgioitinh.ReadOnly = true;

            btadd.Focus();
        }
        public void mocontrol()
        {
            btadd.Enabled = false;
            btdelete.Enabled = false;
            btedit.Enabled = false;
            btnluu.Enabled = true;
            btclose.Enabled = true;

            txtmasv.ReadOnly = false;
            txtten.ReadOnly = false;
          //  txtngaysinh.ReadOnly = false;
            txtkhoa.ReadOnly = false;
            txtlop.ReadOnly = false;
            txtdc.ReadOnly = false;
            txtgioitinh.ReadOnly = false;

            txtmasv.Focus();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("bạn có muốn xóa sinh viên này không ?", "cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)== DialogResult.Yes)
            {

                dtSv.Rows.RemoveAt(index);
                dataGridSinhVienn.DataSource = dtSv;
                dataGridSinhVienn.RefreshEdit();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            khoacontrol();
            dtSv = createtable();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            mocontrol();
            flag = "add";

            txtmasv.Text = "";
            txtten.Text = "";
             
            txtkhoa.Text = "";
            txtlop.Text = "";
            txtdc.Text = "";
            txtgioitinh.Text = "";
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            mocontrol();
            flag = "edit";

        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if(checkData())
                {
                    dtSv.Rows.Add(txtmasv.Text, txtten.Text, dtngaysinh.Value, txtkhoa.Text, txtlop.Text, txtdc.Text,txtgioitinh.Text);
                    dataGridSinhVienn.DataSource = dtSv;
                    dataGridSinhVienn.RefreshEdit();

                }
            }
            else if (flag == "edit")
            {
                if(checkData())
                {
                    dtSv.Rows[index][0] = txtmasv.Text;
                    dtSv.Rows[index][1] = txtten.Text;
                    dtSv.Rows[index][2] = dtngaysinh.Value;
                    dtSv.Rows[index][3] = txtkhoa.Text;
                    dtSv.Rows[index][4] = txtlop.Text;
                    dtSv.Rows[index][5] = txtdc.Text;
                    dtSv.Rows[index][6] = txtgioitinh.Text;

                    dataGridSinhVienn.DataSource = dtSv;
                    dataGridSinhVienn.RefreshEdit();

                }
            }
            khoacontrol();
        }
        public bool checkData()
        {
            if(string.IsNullOrWhiteSpace(txtmasv.Text))
            {
                MessageBox.Show("bạn chưa nhập mã ssinh  viên", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmasv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtten.Text))
            {
                MessageBox.Show("bạn chưa nhập tên ssinh  viên", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtten.Focus();
                return false;
            }
            return true;
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show(
               "bạn có chắc chắn muốn thoát ?",
               "confirm",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
               );
            if (cc == DialogResult.Yes)
                Close();
            else if (cc == DialogResult.No)
                MessageBox.Show("OK Bạn ,mời bạn tiếp tục chương trình");
        }
    }
}
