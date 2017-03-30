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
    public partial class CrearPrivilegio : Form
    {
        public CrearPrivilegio()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNamePrivilegio.Text == string.Empty /*&& cbxType.Text == string.Empty*/)
            {
                MessageBox.Show("Alguno de los campos Usuario y Password estan vacios");

            }
            try
            {
              
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
              

                DataTable ds = new DataTable();
                if (chkbActivoOrNot.Checked)
                { SqlCommand cmd = new SqlCommand("insert into Privilegios(NamePrivilegio, StatusPrivilegio)values(@NamePrivilegio,1)", con);
                    cmd.Parameters.AddWithValue("@NamePrivilegio", txtNamePrivilegio.Text);
                    cmd.Parameters.AddWithValue("1", chkbActivoOrNot.Checked);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Saved");
                    }

                }
                else {
                    SqlCommand cmd = new SqlCommand("insert into Privilegios(NamePrivilegio, StatusPrivilegio)values(@NamePrivilegio,0)", con);
                    cmd.Parameters.AddWithValue("@NamePrivilegio", txtNamePrivilegio.Text);
                    cmd.Parameters.AddWithValue("0", chkbActivoOrNot.Checked);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();

                    con.Close();

                    if (i != 0)
                    {
                        MessageBox.Show(i + "Data Saved ");
                    }
                }
                //cmd.Parameters.AddWithValue("@UderTypeId", cbxType.Text);
                //cmd.Parameters.AddWithValue("@UserTypeId", cbxTypeUser.SelectedIndex);

                //con.Open();
                //int i = cmd.ExecuteNonQuery();

                //con.Close();

                //if (i != 0)
                //{
                //    MessageBox.Show(i + "Data Saved");
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "CAMPOS VACIOS");
            }

        }
        //public void refreshdata()
        //{
        //    if (chkbActivoOrNot.Checked == true)
        //    {
        //        MessageBox.Show("true");
        //        //if (chkbActivoOrNot.Checked)
        //        //{
        //        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
        //        SqlCommand cmd2 = new SqlCommand("insert into Privilegios(StatusPrivilegio)values(1)", con);
        //        cmd2.Parameters.AddWithValue("1", cbxType);
        //        //}
        //    }
        //}
        private void chkbActivoOrNot_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menus.MenuSuperUser ss = new Menus.MenuSuperUser();
            ss.Show();
        }

        private void CrearPrivilegio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoOctavoUserTypesDataSet.Privilegios' table. You can move, or remove it, as needed.
         //   this.privilegiosTableAdapter.Fill(this.proyectoOctavoUserTypesDataSet.Privilegios);

        }
    }
}
