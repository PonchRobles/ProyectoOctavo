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
    public partial class DarTipoAUsuario : Form
    {
        public DarTipoAUsuario()
        {
            InitializeComponent();
            refreshdata();
        }

        private void DarTipoAUsuario_Load(object sender, EventArgs e)
        {
          

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            //if (txtUsuario.Text == string.Empty && txtPassword.Text == string.Empty)
            //{
            //    MessageBox.Show("Alguno de los campos Usuario y Password estan vacios");

            //}

            //  if () { }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into UserWithTypeUserAndPrivilegios ( IdTyperUser,Idprivilegio)values(@IdTyperUser, @Idprivilegio)", con);

                DataTable ds = new DataTable();
              //  cmd.Parameters.AddWithValue("@IdUser", comboBox1.SelectedIndex);

                cmd.Parameters.AddWithValue("@IdTyperUser", comboBox2.SelectedIndex);
                cmd.Parameters.AddWithValue("@Idprivilegio", comboBox3.SelectedIndex);

                con.Open();
                int i = cmd.ExecuteNonQuery();

                con.Close();
                
                if (i != 0)
                {

                    MessageBox.Show("Nueva Relacion Creada");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "CAMPOS VACIOS");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshdata();
        }
        public void refreshdata()
        {
            DataRow dr;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RBGA42V; Initial Catalog = ProyectoOctavoUserTypes; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select TypeUser.NameTypeUser from TypeUser inner join Users on '"+comboBox1.SelectedValue +"' = TypeUser.UderTypeId", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //dr = dt.NewRow();
           
            //dt.Rows.InsertAt(dr, 0);

            comboBox2.ValueMember = "UserTypeId";

            comboBox2.DisplayMember = "NameTypeUser";
            comboBox2.DataSource = dt;

            con.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menus.MenuSuperUser ss = new Menus.MenuSuperUser();
            ss.Show();
        }
    }
}
