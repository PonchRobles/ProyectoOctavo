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
            //SqlConnection con = new SqlConnection("Data Source=NiluNilesh;Integrated Security=True");  
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");

            // SqlCommand cmd = new SqlCommand("Select * from Users where NameUser=@nameuser and Password=@password", con);
            //  SqlCommand cmd = new SqlCommand("sp_insert", con);
            SqlCommand cmd = new SqlCommand("insert into Users(NameUser, Password,UserTypeId)values(@NameUser, @Password,@UserTypeId)", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            DataTable ds = new DataTable();
            cmd.Parameters.AddWithValue("@NameUser", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
         cmd.Parameters.AddWithValue("@UserTypeId",cbxTypeUser.SelectedIndex);

            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show(i + "Data Saved");
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
    }
}
