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

namespace TelaLogin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string usuario = tbxusuario.Text;
            string email = tbxemail.Text;
            string nome = tbxnome.Text;
            string senha = tbxsenha.Text;
            string connectionString = "Server=DESKTOP-7SPC5NO\\SQLEXPRESS;Database=Login;Integrated Security=True;";
            
            string query = "INSERT INTO Logar (usuario, email, nome, senha) VALUES (@usuario, @email, @nome, @senha)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Dados registrados com sucesso!");
                    var myForm = new Form1();
                    myForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar os dados: " + ex.Message);
                }
            }



         
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            var myForm = new Form1();
            myForm.Show();
            this.Hide();
        }

        private void tbxusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}