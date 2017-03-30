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
    public partial class CrearUsuario : Form
    {
      
        public CrearUsuario()
        {
            InitializeComponent();
            refreshdata();
          

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == string.Empty && txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Alguno de los campos Usuario y Password estan vacios");

            }

          //  if () { }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("insert into Users(NameUser, Password,UserTypeId)values(@NameUser, @Password,@UserTypeId)", con);

                DataTable ds = new DataTable();
                cmd.Parameters.AddWithValue("@NameUser", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@UserTypeId", cbxTypeUser.SelectedIndex);

                con.Open();
                int i = cmd.ExecuteNonQuery();

                con.Close();
                //dataGridView1.Update();
                //dataGridView1.Refresh();
                if (i != 0)
                {
                    //this.dataGridView1.Update();
                    //this.dataGridView1.Refresh();
                    
                    MessageBox.Show("Usuario creado!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message+"CAMPOS VACIOS");
            }

        }

        private void cbxTypeUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if (cbxTypeUser == null) { MessageBox.Show("YEA"); };

        }
        public void refreshdata()
        {
            DataRow dr;

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
            //SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-RBGA42V; Initial Catalog = ProyectoOctavoUserTypes; Integrated Security = True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from TypeUser", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { 0, "--Select TypeUser--" };
            dt.Rows.InsertAt(dr, 0);

            cbxTypeUser.ValueMember = "UserTypeId";

            cbxTypeUser.DisplayMember = "NameTypeUser";
            cbxTypeUser.DataSource = dt;

            con.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menus.MenuSuperUser ss = new Menus.MenuSuperUser();
            ss.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoOctavoUserTypesDataSet.Users' table. You can move, or remove it, as needed.
          //  this.usersTableAdapter.Fill(this.proyectoOctavoUserTypesDataSet.Users);

        }
    }
}
