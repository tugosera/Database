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

namespace Database
{
    public partial class Form1 : Form
    {
        SqlConnection conn= new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void Nimi_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database_DataSet.Tooded' table. You can move, or remove it, as needed.
            this.toodedTableAdapter.Fill(this.database_DataSet.Tooded);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void NaitaAndmet()
        {
            this.toodedTableAdapter.Fill(this.database_DataSet.Tooded);
        }

        private void lisa_btn_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("Insert into Toode(Nimetus, Kogus, Hind) Values (@toode,@kogus,@hind)", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmet();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga");
                }
            }
        }
    }
}
