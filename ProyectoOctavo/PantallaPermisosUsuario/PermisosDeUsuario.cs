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
    public partial class PermisosDeUsuario : Form
    {
        public PermisosDeUsuario()
        {
            InitializeComponent();
        }

        private void PermisosDeUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoOctavoUserTypesDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.proyectoOctavoUserTypesDataSet.Users);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Privilegios", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
  bool result;
            int numberOfCalls;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
              
                foreach (DataRow dr in dt.Rows)
                {
                    result = Int32.TryParse(dr["StatusPrivilegio"].ToString(), out numberOfCalls);
                }
                checkedListBox1.Items.Add(dt.Rows[i]["NamePrivilegio"].ToString());
                //if (dt.Rows[i].ItemArray.)
                //{ }
                checkedListBox1.SetItemChecked(i, true);
              
                //if (listBox1.SelectedIndex != 0)
                 //{

                //    checkedListBox1.Items.Add(dt.Rows[i]["NamePrivilegio"].ToString());
                //    checkedListBox1.SetItemChecked(i, true);
                //}

                //

            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
