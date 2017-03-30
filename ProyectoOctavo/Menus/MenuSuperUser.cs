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

namespace ProyectoOctavo.Menus
{
    public partial class MenuSuperUser : Form
    {
        public MenuSuperUser()
        {
            InitializeComponent();
            

        }

        private void txtPermisos_Click(object sender, EventArgs e)
        {
            this.Hide();
         PantallaPermisosUsuario.PermisosDeUsuario ss = new PantallaPermisosUsuario.PermisosDeUsuario();
        ss.Show();
        }

        private void txtUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPermisosUsuario.CrearUsuario ss = new PantallaPermisosUsuario.CrearUsuario();
            ss.Show();
        }

        private void txtTipoDeUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPermisosUsuario.CrearTipoDeUsuario ss = new PantallaPermisosUsuario.CrearTipoDeUsuario();
            ss.Show();

        }

        private void txtSalir_Click(object sender, EventArgs e)
        {
            Close();
     
        }

        private void btnPrivilegio_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPermisosUsuario.CrearPrivilegio ss = new PantallaPermisosUsuario.CrearPrivilegio();
            ss.Show();

        }

        private void MenuSuperUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoOctavoUserTypesDataSet.Users' table. You can move, or remove it, as needed.
           // this.usersTableAdapter.Fill(this.proyectoOctavoUserTypesDataSet.Users);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPermisosUsuario.VistaTotal ss = new PantallaPermisosUsuario.VistaTotal();
            ss.Show();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtDarTipoUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPermisosUsuario.DarTipoAUsuario ss = new PantallaPermisosUsuario.DarTipoAUsuario();
            ss.Show();

        }
    }
}
