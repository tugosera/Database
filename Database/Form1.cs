using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }
        int ID = 0;

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        { ID = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
          Nimetus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Nimetus"].Value;
          Nimetus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Kogus"].Value;
          Nimetus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Hind"].Value;
        }


            //ID = (int)dataGridview1.Rows[e.RowIndex].Cells["Id"].Value;
            //Nimetus_txt.Text = dataGridview1.Rows[e.RowIndex].Cells["Nimetus"].Value;
            //Nimetus_txt.Text = dataGridview1.Rows[e.RowIndex].Cells["Kogus"].Value;
            //Nimetus_txt.Text = dataGridview1.Rows[e.RowIndex].Cells["Hind"].Value;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Toode SET Nimetus=@toode, Kogus=@kogus, Hind=@hind) WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmet();
                    MessageBox.Show("Andmed edukalt uuendatud");
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }

        OpenFileDialog open;
        SaveFileDialog save;
        string extension;
        private void otsipilt_btn_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\opilane.TTHK\Pictures\";
            open.Multiselect = false;
            open.Filter = "Images Files(*.jpeg;*.png;*.bmp;*.jpg)| *.jpeg;*.png;*.bmp;*.jpg";
            FileInfo fileInfo= new FileInfo(@"C:\Users\opilane.TTHK\Pictures\"+open.FileName);
            if (open.ShowDialog()==DialogResult.OK && Nimetus_txt.Text!=null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\..\Pildid");
                string extension=Path.GetExtension(open.FileName);
                save.FileName = Nimetus_txt.Text+extension;
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);
                if (save.ShowDialog()==DialogResult.OK && Nimetus_txt != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    pictureBox1.Image = Image.FromFile(save.FileName);
                }
            }
        }
    }
}
