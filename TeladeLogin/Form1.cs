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

namespace TelaLogin
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txbusuario.Text;
            string senha = txbsenha.Text;
            string connectionString = "Server=DESKTOP-7SPC5NO\\SQLEXPRESS;Database=Login;Integrated Security=True;";
            string query = "SELECT COUNT(*) FROM logar WHERE usuario = @usuario AND senha = @senha";

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                    con.Open(); 

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        
                        int count = (int)cmd.ExecuteScalar();

                        
                        if (count > 0)
                        {
                            MessageBox.Show("Login realizado com sucesso!");
                            var myForm = new TeladeLogin.Form3();
                            myForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos. Tente novamente.");
                        }
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new Form2();
            myForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbsenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
