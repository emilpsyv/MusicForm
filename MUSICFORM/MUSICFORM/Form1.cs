using System.Data.SqlClient;

namespace MUSICFORM
{
    public partial class Form1 : Form
    {
        const string ConnectionString = "Server=DESKTOP-742DB1G;Database=TASK3;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "NAME");
            dataGridView1.Columns.Add("surname", "SURNAME");
            dataGridView1.Columns.Add("birthday", "BIRTHDAY");
            dataGridView1.Columns.Add("gender", "GENDER");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDatas();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            string surname = surnameInpute.Text;
            DateTime birthday = Convert.ToDateTime(birthdayDate.Text);
            string gender = MaleButton.Checked ? "male" : "female"; ;

            InsertDatas(name, surname, birthday, gender);

            nameInput.Text = "";
            surnameInpute.Text = "";
            birthdayDate.Text = "";

            GetDatas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool InsertDatas(string name, string surname, DateTime birthday, string gender)
        {

            using SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"INSERT INTO Artists VALUES (N'{name}',N'{surname}','{birthday}','{gender}')", conn);
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void ResetTable()
        {
            dataGridView1.Rows.Clear();
        }
        public void GetDatas()
        {
            ResetTable();
            using SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand("SELECT * FROM Artists ", conn);
            using SqlDataReader datas = command.ExecuteReader();
            while (datas.Read())
            {
                dataGridView1.Rows.Add(datas[0], datas[1], datas[2], datas[3], datas[4]);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var data = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string id = data.Cells[0].Value.ToString();
            Delete(id);
            GetDatas();
        }
        void Delete(string id)
        {
            using SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"DELETE Artists WHERE ID={id} ", conn);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("silindi");
            }
            else 
            {
                MessageBox.Show("xeta bas verdi");
            }
        }
    }
}
