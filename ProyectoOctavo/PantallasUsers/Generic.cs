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


namespace ProyectoOctavo.PantallasUsers
{
    public partial class Generic : Form
    {
        int IdUser;
        Button[] array_botton;
        DataTable dt;
        public Generic(int IdUser)
        {
            InitializeComponent();
            this.IdUser = IdUser;
        }

        private void Generic_Load(object sender, EventArgs e)
        {
            cargar_permisos();
        }
        System.Data.SqlClient.SqlConnection con;
        public void cargar_permisos()
        {
            string sql = @"select IdPrivilegio , NamePrivilegio from Privilegios where IdPrivilegio in (
            Select IdPrivilegio from TypeUser where UderTypeId = 
			(Select UserTypeId from Users where IdUser = @IdUser))";


            con = new System.Data.SqlClient.SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True";
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.SelectCommand.Parameters.AddWithValue("@IdUser", IdUser);
            dt = new DataTable();
            da.Fill(dt);
            con.Close();

            /*for (int i = 0; i < dt.Rows.Count; i++ )
            {
                DataRow dr = dt.Rows[i];
                MessageBox.Show(dr["nombre"].ToString());
            }*/
            /////////
            array_botton = new Button[dt.Rows.Count];
            addcontrol();

        }
        private void addcontrol()
        {
            int x = 100, y = 100;
            int xy = 0;

            for (int i = 0; i < array_botton.Length; i++)
            {
                DataRow dr = dt.Rows[i];

                array_botton[i] = new Button();
                array_botton[i].Width += array_botton[i].Width;
                array_botton[i].Height += array_botton[i].Height;

                if (xy < 3)
                {
                    array_botton[i].Location = new System.Drawing.Point(x, y);
                    x = x + 15 + array_botton[i].Width;
                }
                else
                {
                    xy = -1;
                    x = 100;
                    y = y + (15 + array_botton[i].Height);
                    array_botton[i].Location = new System.Drawing.Point(x, y);
                }
                array_botton[i].Text = dr["NamePrivilegio"].ToString();

                array_botton[i].Click += new System.EventHandler(botondinamic);
                this.Controls.Add(array_botton[i]);
                xy++;
            }
        }
        private void botondinamic(object sender, System.EventArgs e)
        {
            MessageBox.Show( this.ActiveControl.Text);
        }

      
    }
}
