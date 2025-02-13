using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaLogin;

namespace TeladeLogin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'loginDataSet.logar'. Você pode movê-la ou removê-la conforme necessário.
            this.logarTableAdapter.Fill(this.loginDataSet.logar);

            this.reportViewer1.RefreshReport();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var myForm = new Form3();
            myForm.Show();
            this.Hide();
        }
    }
}
