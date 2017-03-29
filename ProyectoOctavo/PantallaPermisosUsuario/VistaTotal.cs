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
    public partial class VistaTotal : Form
    {
        public VistaTotal()
        {
            InitializeComponent();
            cargardatagridview();
        }
        public void cargardatagridview()
        {
            string cadenaconexion = @"Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True";
            SqlConnection con = new SqlConnection();
            //variable de tipo Sqlcommand
            SqlCommand comando = new SqlCommand();
            //variable SqlDataReader para leer los datos
            SqlDataReader dr;
            con.ConnectionString = cadenaconexion;
            comando.Connection = con;
            //declaramos el comando para realizar la busqueda
            comando.CommandText = "select Users.NameUser , Privilegios.NamePrivilegio, TypeUser.NameTypeUser, Privilegios.StatusPrivilegio from Users inner join TypeUser on Users.UserTypeId = TypeUser.UderTypeId inner join Privilegios on Users.UserTypeId = Privilegios.UderTypeId";
            //especificamos que es de tipo Text
            comando.CommandType = CommandType.Text;
            //se abre la conexion
            con.Open();
            //limpiamos los renglones de la datagridview
            dataGridView1.Rows.Clear();
            //a la variable DataReader asignamos  el la variable de tipo SqlCommand
            dr = comando.ExecuteReader();
            //el ciclo while se ejecutará mientras lea registros en la tabla
            while (dr.Read())
            {
            
                int renglon1 = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon1].Cells["StatusPrivilegio"].Value = dr.GetInt32(dr.GetOrdinal("StatusPrivilegio"));
               dataGridView1.Rows[renglon1].Cells["NamePrivilegio"].Value = dr.GetString(dr.GetOrdinal("NamePrivilegio"));
                dataGridView1.Rows[renglon1].Cells["NameTypeUser"].Value = dr.GetString(dr.GetOrdinal("NameTypeUser")).ToString();
                dataGridView1.Rows[renglon1].Cells["NameUser"].Value = dr.GetString(dr.GetOrdinal("NameUser")).ToString();
               // dataGridView1.Rows[renglon1].Cells["usuarioPerfil"].Value = dr.GetString(dr.GetOrdinal("usuarioPerfil")).ToString();

            }
            
            con.Close();
        }
        private void VistaTotal_Load(object sender, EventArgs e)
        {

        }
    }
}
