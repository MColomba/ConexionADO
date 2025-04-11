using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryColombaConexionBD
{
    internal class clsConexionBD
    {
        public string strConnection = "Server=localhost;Database=Comercio;Trusted_Connection=True;";
        public SqlConnection objConnection { get; set; }

        public clsConexionBD()
        {
            objConnection = new SqlConnection(strConnection);
            
                try
                {
                    objConnection.Open();
                    MessageBox.Show("✅ Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al conectar: " + ex.Message);
                }
            
        }
    }
}
