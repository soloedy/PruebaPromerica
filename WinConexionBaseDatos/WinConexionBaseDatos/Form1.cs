using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinConexionBaseDatos
{
    public partial class Prueba : Form
    {
        
        public Prueba()
        {
            InitializeComponent();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                // SE REALIZA CONEXIÓN CON BASE DE DATOS.
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString.ToString());
                SqlCommand cmd = new SqlCommand();
                DataSet dtsDatos = new DataSet();
                SqlDataAdapter sqlDa;
                conexion.Open();
                // REALIZA CONSULTA HACIA BASE DE DATOS.
                cmd.CommandText = "SELECT * FROM datos.dbo.datos_tarjeta";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                sqlDa = new SqlDataAdapter(cmd);
                sqlDa.Fill(dtsDatos);

                // VALIDA SI LA CONSULTA DEVOLVIÓ RESULTADOS.
                if (dtsDatos.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Número de filas - " + dtsDatos.Tables[0].Rows.Count);
                }
                else
                {
                    MessageBox.Show("La consulta no devolvió resultados.");
                }

                // CERRAMOS CONEXIÓN CON BASE DE DATOS.
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en proceso de conexión y consulta hacia base de datos. " + ex.Message);
            }
        }

        // ESTE MISMO PROCESO SE PUEDE REALIZAR PARA EL CRUD COMPLETO.
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // SE REALIZA CONEXIÓN CON BASE DE DATOS.
                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.ConnectionString.ToString());
                SqlCommand cmd = new SqlCommand();
                DataSet dtsDatos = new DataSet();
                SqlDataAdapter sqlDa;
                conexion.Open();
                // REALIZA LA TAREA HACIA BASE DE DATOS.
                cmd.CommandText = "DELETE FROM datos.dbo.datos_tarjeta";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                sqlDa = new SqlDataAdapter(cmd);

                // DEVUELVE EL NÚMERO DE FILAS AFECTADAS POR EL DELETE.
                cmd.CommandText = "SELECT @@ROWCOUNT AS 'FilasAfectadas'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexion;

                sqlDa = new SqlDataAdapter(cmd);
                sqlDa.Fill(dtsDatos);

                // VALIDA CUANTAS FILAS FUERON AFECTADAS.
                if (dtsDatos.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Número de filas afectadas - " + dtsDatos.Tables[0].Rows[0]);
                }
                else
                {
                    MessageBox.Show("La consulta no afectó ninguna de las filas.");
                }

                // CERRAMOS CONEXIÓN CON BASE DE DATOS.
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en proceso de conexión y consulta hacia base de datos. " + ex.Message);
            }
        }
    }
}
