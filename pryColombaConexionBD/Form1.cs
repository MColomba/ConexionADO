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
                clsConexionBD c = new clsConexionBD();

                string query = "SELECT Nombre FROM Productos";

                SqlCommand command = new SqlCommand(query, c.connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lvw.Items.Add(reader["Nombre"].ToString());
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
                clsConexionBD c = new clsConexionBD();

                string query = "SELECT * FROM Contactos";

                SqlCommand command = new SqlCommand(query, c.connection);
                using (SqlDataReader reader = command.ExecuteReader())
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
