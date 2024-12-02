using Npgsql;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace ResponsiJunPro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=ResponsiJunpro";

        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sql = @"select * from st_insert(:_nama,:_departemen)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", textNama.Text);
                cmd.Parameters.AddWithValue("_departemen", InputDepart.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil Input", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonLoadTable.PerformClick();
                    textNama.Text = InputDepart.Text = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonLoadTable_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                DGV.DataSource = null;
                sql = "select * from st_select()";
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                DGV.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Salah Di button Load" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = DGV.Rows[e.RowIndex];
                textNama.Text = r.Cells["_nama"].Value.ToString();
                InputDepart.Text = r.Cells["_departemen"].Value.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilihlah Baris", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                sql = @"select * FROM st_update(:_id,:_nama,:_departemen)";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", textNama.Text);
                cmd.Parameters.AddWithValue("_departemen", InputDepart.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil update", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    buttonLoadTable.PerformClick();
                    textNama.Text = InputDepart.Text = null;
                    r = null;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Salah Di button Update" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Pilihlah Baris", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                conn.Open();

                sql = @"select * from st_delete(:_id)";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("_id", r.Cells["_id"].Value.ToString());
                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Berhasil Delete", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    buttonLoadTable.PerformClick();
                    textNama.Text = InputDepart.Text = null;
                    r = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Salah Di button Delete" + ex.Message, "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}