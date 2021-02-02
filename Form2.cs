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
using System.IO;
using System.Diagnostics;

namespace Academia
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

        private void buttoncadalu_Click(object sender, EventArgs e)
        {
            string StrConnection = Properties.Settings.Default.;
            SqlConnection objConnection = new SqlConnection();
            objConnection.ConnectionString = StrConnection;
            objConnection.Open();
        }
        string inserir = "insert into insc (nome,categoria) values('" + textBoxcadalu.Text + "' ,'" + textBoxdatnas.Text + "' , '" + textBoxendeAluno.Text +"' , '" + )";
        SqlCommand objComando = new SqlCommand(inserir, objConnection);
        objComando.ExecuteNonQuery();
    }
}
