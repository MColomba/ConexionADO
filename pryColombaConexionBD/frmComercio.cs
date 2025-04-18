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

namespace pryColombaConexionBD
{
    public partial class frmComercio : Form
    {
        public frmComercio()
        {
            InitializeComponent();
        }

        public void ArmaLvwProductos()
        {
            lvw.Columns.Clear();
            lvw.Columns.Add("Nombre", "Nombre");
        }
        public void ArmaLvwContactos()
        {
            lvw.Columns.Clear();
            lvw.Columns.Add("Nombre", "Nombre");
            lvw.Columns.Add("Apellido", "Apellido");
            lvw.Columns.Add("Telefono", "Telefono");
            lvw.Columns.Add("Correo", "Correo");
            lvw.Columns.Add("Categoria", "Categoria");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ArmaLvwProductos();
            try
            {
                clsConexionBD objConnection = new clsConexionBD();

                string strQuery = "SELECT Nombre FROM Productos";

                SqlCommand objCommand = new SqlCommand(strQuery, objConnection.GetConnection());
                using (SqlDataReader reader = objCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lvw.Items.Add("Nombre", reader["Nombre"].ToString(), null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            ArmaLvwContactos();
            try
            {
                clsConexionBD objConnection = new clsConexionBD();

                string strQuery = "SELECT * FROM Contactos";

                SqlCommand objCommand = new SqlCommand(strQuery, objConnection.GetConnection());
                using (SqlDataReader reader = objCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lvw.Items.Add("Nombre", reader["Nombre"].ToString(), null);
                        lvw.Items.Add("Apellido", reader["Apellido"].ToString(), null);
                        lvw.Items.Add("Telefono", reader["Telefono"].ToString(), null);
                        lvw.Items.Add("Correo", reader["Correo"].ToString(), null);
                        lvw.Items.Add("Categoria", reader["Categoria"].ToString(), null);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
