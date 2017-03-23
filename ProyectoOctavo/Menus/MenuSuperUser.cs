using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
           PantallaPermisosUsuario.PermisosSuperUsuario ss = new PantallaPermisosUsuario.PermisosSuperUsuario();
            ss.Show();
        }
    }
}
