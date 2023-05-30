using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_PHAU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=DESKTOP-OOVA1AR\SQLEXPRESS;Initial Catalog=QL_THU_VIEN;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        SqlDataReader docdulieu;
        int i = 0;
        DataTable dt;
        private void Form1_Load(object sender, EventArgs e)
        {
            loadSV();
            loadNV();
        }
        private void loadSV()
        {
            ketnoi = new SqlConnection(chuoiketnoi);

            ketnoi.Open();
            sql = "select* from SINH_VIEN ";
            hienthi();
            dataGridView1.DataSource = dt;
            ketnoi.Close();
        }
        public void hienthi()
        {
            thuchien = new SqlCommand(sql, ketnoi);
            docdulieu = thuchien.ExecuteReader();
            dt = new DataTable();
            dt.Load(docdulieu);

        }


        public void xoa()
        {
            TXTMSSV.Clear();
            TXTTENSV.Clear();
            TXTMALOP.Clear();
            TXTTENLOP.Clear();

        }
        String masv, mk, mp;


        public void loadNV()
        {
            ketnoi = new SqlConnection(chuoiketnoi);

            ketnoi.Open();
            sql = "select* from NHAN_VIEN ";
            hienthi();
            dataGridView2.DataSource = dt;
            ketnoi.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void themsv_Click_1(object sender, EventArgs e)
        {
            string masv = TXTMSSV.Text;
            string HOTENSV = TXTTENSV.Text;
            string MALOP = TXTMALOP.Text;
            string TENLOP = TXTTENLOP.Text;



            // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

            ketnoi.Open();

            sql = @"insert into SINH_VIEN
	        values 
            (N'" + masv + "' , N'" + HOTENSV + "' , N'" + MALOP + "'  , N'" + TENLOP + "')";
            MessageBox.Show("THÊM THÀNH CÔNG!!");

            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();

            ketnoi.Close();

            loadSV();
        }

        private void suasv_Click_1(object sender, EventArgs e)
        {

            // Lấy tất cả thông tin muốn thêm
            string masv = TXTMSSV.Text;
            string HOTENSV = TXTTENSV.Text;
            string MALOP = TXTMALOP.Text;
            string TENLOP = TXTTENLOP.Text;
            // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

            string sql = @"update SINH_VIEN
	     SET
            MSSV =N'" + masv + "' ,Ten_sinh_vien=  N'" + HOTENSV + "' ,Ma_lop= N'" + MALOP + "'  ,Ten_lop= N'" + TENLOP + "'  where MSSV='" + masv + "'";
            Console.WriteLine(sql);
            ketnoi.Open();
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            xoa();
            ketnoi.Close();

            loadSV();
        }

        private void themnv_Click(object sender, EventArgs e)
        {
            try
            {

                string MANV = TXTMANV.Text;
                string TENNV = TXTTENNV.Text;
                string CHUCVU = TXTCHUCVU.Text;




                // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

                ketnoi.Open();

                sql = @"insert into NHAN_VIEN
	        values 
            (N'" + MANV + "' , N'" + TENNV + "' , N'" + CHUCVU + "')";

                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LỖI");
                return;
            }

            ketnoi.Close();
            loadNV();
            MessageBox.Show("THÊM THÀNH CÔNG!!");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void xoanv_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string MANVCanXoa = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();

                ketnoi.Open();
                string lenhxoa = "delete from NHAN_VIEN where Ma_the_nhan_vien ='" + MANVCanXoa + "'";

                thuchien = new SqlCommand(lenhxoa, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();

                loadNV();
            }
        }

        private void suanv_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                string maNVSua = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
              //  MessageBox.Show(maNVSua);
                   // Lấy tất cả thông tin muốn thêm
                string MANV = TXTMANV.Text;
                string TENNV = TXTTENNV.Text;
                string CHUCVU = TXTCHUCVU.Text;
                // check gia tri nguời dùng nhập có đúng không - ví dụ là nhập chưa đủ thông tin:

                string sql = @"update NHAN_VIEN
	     SET
           Ma_the_nhan_vien =N'" + MANV + "' ,Ten_nhan_vien=  N'" + TENNV + "' ,Chuc_vu= N'" + CHUCVU + "' where Ma_the_nhan_vien='" + maNVSua + "'";
                Console.WriteLine(sql);
                ketnoi.Open();
                thuchien = new SqlCommand(sql, ketnoi);
                thuchien.ExecuteNonQuery();
                xoa();
                ketnoi.Close();

                loadNV();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void xoasv_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string masvCanXoa = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                ketnoi.Open();
                string lenhxoa = "delete from SINH_VIEN where MSSV ='" + masvCanXoa + "'";

                thuchien = new SqlCommand(lenhxoa, ketnoi);
                thuchien.ExecuteNonQuery();
                ketnoi.Close();

                loadSV();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            masv = row.Cells[0].Value.ToString();
        }


    }
}
