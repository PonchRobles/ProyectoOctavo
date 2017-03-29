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
            refreshData2();
        }






        public void refreshData2()
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
            SqlCommand cmd2 = new SqlCommand("select * from Users", con2);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            for (int x = 0; x < dt2.Rows.Count; x++)
            {

                checkedListBox3.Items.Add(dt2.Rows[x]["NameUser"].ToString());
                //int row;
                //bool result;
                //foreach (DataRow dr in dt2.Rows)
                //{
                //    result = Int32.TryParse(dr["NameUser"].ToString(), out row);
                //    var n = dr.ItemArray.ToList();

                //    // if (checkedListBox3.SelectedIndex) { }
                //    checkedListBox2.SetItemChecked(x, true);

                //}
                // checkedListBox3.SetItemChecked(x, true);


            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
            SqlCommand cmd2 = new SqlCommand("select * from TypeUser", con2);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            for (int x = 0; x < dt2.Rows.Count; x++)
            {
                foreach (var xenial in checkedListBox2.Items)
                {
                    if (xenial.ToString() != string.Empty)
                    {
                        switch (dt2.Rows[0]["UderTypeId"] as string)
                        {
                            case "Admon":
                                {
                                    checkedListBox2.Items.Add(dt2.Rows[x]["NameTypeUser"].ToString());
                                    checkedListBox2.SetItemChecked(x, true);
                                    break;
                                }
                            default:
                                {
                                    MessageBox.Show("NOTBABY");
                                    break;
                                }
                        }
                    }
                }

                //for (int i = 0; i < checkedListBox1.Items.Count; i++)
                //{
                //    if ((string)checkedListBox1.Items[i] == value)
                //    {
                //        checkedListBox1.SetItemChecked(i, true);
                //    }
                //}
                // int row;
                //bool result;
                //foreach (DataRow dr in dt2.Rows)
                //{
                //    result = Int32.TryParse(dr["NameTypeUser"].ToString(), out row);
                //        var n=   dr.ItemArray.ToList();
                //    if (result)
                //    {


                //        checkedListBox2.SetItemChecked(x, true);
                //    }
                //    else {
                //        checkedListBox2.SetItemChecked(x, false);
                //    }
                //}
                // checkedListBox2.SetItemChecked(x, true);


            }

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(@"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True");
            SqlCommand cmd2 = new SqlCommand("select * from Privilegios", con2);
            SqlDataAdapter sda2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            for (int x = 0; x < dt2.Rows.Count; x++)
            {

                checkedListBox1.Items.Add(dt2.Rows[x]["NamePrivilegio"].ToString());
            }
        }

        private void PermisosDeUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoOctavoUserTypesDataSet.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter.Fill(this.proyectoOctavoUserTypesDataSet.Users);

        }
    }
}
