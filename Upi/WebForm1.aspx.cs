using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Upi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresarEstudiante_Click(object sender, EventArgs e)
        {
            string connectionStringEmpleados = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaConexion1"].ConnectionString;
            int cantAgregados = 0;
            SqlConnection conexion = new SqlConnection(connectionStringEmpleados);
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO ESTUDIANTE (CODIGO, NOMBRE) VALUES ('"+ txtCodigoEstudiante.Text + "', '" + txtNombreEstudiante.Text + "')", conexion);
            cantAgregados = comando.ExecuteNonQuery();
            conexion.Close();
            lblEstadoInsertar.Text = (cantAgregados > 0 ? "Estudiante creado!" : "Error al ingresar estudiante...");
        }
    }
}