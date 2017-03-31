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
            FirstDrop();
            refreshdata();
        }

        private void DarTipoAUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoOctavoUserTypesDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.proyectoOctavoUserTypesDataSet.Users);
            // TODO: This line of code loads data into the 'proyectoOctavoUserTypesDataSet.Users' table. You can move, or remove it, as needed.
            //  this.usersTableAdapter.Fill(this.proyectoOctavoUserTypesDataSet.Users);


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
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
            SqlCommand cmd = new SqlCommand("select TypeUser.NameTypeUser from TypeUser inner join Users on '"+comboBox1.SelectedIndex +"' = TypeUser.UderTypeId", con);
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
        public void FirstDrop()
        {
            DataRow dr;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RBGA42V; Initial Catalog = ProyectoOctavoUserTypes; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            //dr = dt.NewRow();

            //dt.Rows.InsertAt(dr, 0);

            comboBox1.ValueMember = "UserTypeId";

            comboBox1.DisplayMember = "NameUser";
            comboBox1.DataSource = dt;

            con.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menus.MenuSuperUser ss = new Menus.MenuSuperUser();
            ss.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
