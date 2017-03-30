﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace ProyectoOctavo
{
    public partial class Entrar : MetroForm
    {
       // int ;
        SqlConnection con = new SqlConnection();

        string cs = "Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True";
        public Entrar()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-RBGA42V;Initial Catalog=ProyectoOctavoUserTypes;Integrated Security=True";
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
if (txtUser.Text == "" || txtContrasenna.Text == "")
            {
                MessageBox.Show("Please provide UserName and Password");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from Users where NameUser=@nameuser and Password=@password", con);
                cmd.Parameters.AddWithValue("@nameuser", txtUser.Text);
                cmd.Parameters.AddWithValue("@password", txtContrasenna.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataTable ds = new DataTable();
                adapt.Fill(ds);
                con.Close();
                // int count = ds.Tables[0].Rows.Count;
                SqlConnection con2 = new SqlConnection(cs);
                SqlCommand cmd2 = new SqlCommand("Select IdUser from Users where NameUser=@nameuser and Password=@password", con2);
                cmd2.Parameters.AddWithValue("@nameuser", txtUser.Text);
                cmd2.Parameters.AddWithValue("@password", txtContrasenna.Text);
                con2.Open();
                int IdUser = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                con2.Close();
                //If count is equal to 1, than show frmMain form
                if (ds.Rows.Count == 1)
                {
                    switch (ds.Rows[0]["UserTypeId"] as int?)
                    {
                        case 1:
                            {
                                this.Hide();
                               Menus.MenuSuperUser ss = new Menus.MenuSuperUser();
                                ss.Show();
                                // MessageBox.Show("MAMALON");
                               

                                break;
                            }
                        //case 2:
                        //    {
                        //        this.Hide();
                        //        PantallasUsers.DashboardVendedor ss = new PantallasUsers.DashboardVendedor();
                        //        ss.Show();

                        //        break;
                        //    }
                        default:
                            {
                              //  MessageBox.Show("NOTBABY");
                                PantallasUsers.Generic alta = new PantallasUsers.Generic(IdUser);
                                this.Hide();
                                alta.Show();
                                break;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Algo esta mal, revisa tus datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
