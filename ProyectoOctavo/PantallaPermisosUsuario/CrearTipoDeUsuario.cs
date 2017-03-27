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

namespace ProyectoOctavo.PantallaPermisosUsuario
{
    public partial class CrearTipoDeUsuario : Form
    {
        public CrearTipoDeUsuario()
        {
            InitializeComponent();
        }

        private void txtTypeUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
             SqlCommand cmd = new SqlCommand("insert into TypeUser (NameTypeUser)values(@NameTypeUser)", con);
           
            DataTable ds = new DataTable();
            cmd.Parameters.AddWithValue("@NameTypeUser", txtTypeUserName.Text);
           

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menus.MenuSuperUser ss = new Menus.MenuSuperUser();
            ss.Show();
        }
    }
}
