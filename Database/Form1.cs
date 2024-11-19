using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net.NetworkInformation;

namespace Database
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Database_;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void lisa_btn_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new SqlCommand("INSERT INTO tooded(nimetus, kogus, hind, img) VALUES (@nimetus, @kogus, @hind, @Picture)", connection);
            command.Parameters.AddWithValue("@nimetus", Nimetus_txt.Text);
            command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
            command.Parameters.AddWithValue("@hind", Hind_txt.Text);

            //openFileDialog.Filter = "Bitmap Image (*.bmp)|*.bmp|Metafile Image (*.wmf)|*.wmf|Icon (*.ico)|*.ico|JPEG Image (*.jpg;*.jpeg)|*.jpg;*.jpeg|GIF Image (*.gif)|*.gif|PNG Image (*.png)|*.png";

            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
            //    command.Parameters.AddWithValue("@Picture", imageBytes);
            //    command.ExecuteNonQuery();
            //}

            //connection.Close();
            //productsTableAdapter.Fill(productsDataSet.Products);
        }
        int ID = 0;

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Nimetus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Nimetus"].Value.ToString();
            Nimetus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Kogus"].Value.ToString();
            Nimetus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Hind"].Value.ToString();
            try 
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), dataGridView1.Rows[e.RowIndex].Cells["Pilt"].Value.ToString()));
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), "pilt.png"));
            }
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
                    connection.Open();
                    command = new SqlCommand("UPDATE toode SET Nimetus=@toode, Kogus=@kogus, Hind=@hind) WHERE Id=@id", connection);
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    command.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    command.ExecuteNonQuery();

                    connection.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Nimetus_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
