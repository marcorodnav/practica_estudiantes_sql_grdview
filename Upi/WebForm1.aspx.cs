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
            updateGrdEstudiantes();
        }

        protected void btnIngresarEstudiante_Click(object sender, EventArgs e)
        {
            string codigoInsertar = txtCodigoEstudiante.Text;
            string nombreInsertar = txtNombreEstudiante.Text;
            string connectionStringEmpleados = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaConexion1"].ConnectionString;
            int cantAgregados = 0;
            SqlConnection conexion = new SqlConnection(connectionStringEmpleados);
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO ESTUDIANTE (CODIGO, NOMBRE) VALUES ('"+ codigoInsertar + "', '" + nombreInsertar + "')", conexion);
            cantAgregados = comando.ExecuteNonQuery();
            conexion.Close();
            lblEstadoInsertar.Text = (cantAgregados > 0 ? "Estudiante "+ nombreInsertar+ " creado!" : "Error al ingresar estudiante con codigo: "+ codigoInsertar +"...");
            updateGrdEstudiantes();
        }

        protected void btnBorrarEstudiante_Click(object sender, EventArgs e)
        {
            string codigoBorrar = txtCodigoEstudiante.Text;
            string connectionStringEmpleados = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaConexion1"].ConnectionString;
            int cantAgregados = 0;
            SqlConnection conexion = new SqlConnection(connectionStringEmpleados);
            conexion.Open();
            SqlCommand comando = new SqlCommand("DELETE FROM ESTUDIANTE WHERE CODIGO = '" + codigoBorrar + "'", conexion);
            cantAgregados = comando.ExecuteNonQuery();
            conexion.Close();
            lblEstadoInsertar.Text = (cantAgregados > 0 ? "Estudiante con codigo: "+ codigoBorrar +" borrado!" : "Error al borrar estudiante...");
            updateGrdEstudiantes();
        }

        protected void btnActualizarEstudiante_Click(object sender, EventArgs e)
        {
            string codigoActualizar = txtCodigoEstudiante.Text;
            string nombreActualizar = txtNombreEstudiante.Text;
            string connectionStringEmpleados = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaConexion1"].ConnectionString;
            int cantAgregados = 0;
            SqlConnection conexion = new SqlConnection(connectionStringEmpleados);
            conexion.Open();
            SqlCommand comando = new SqlCommand("UPDATE ESTUDIANTE SET NOMBRE = '" + nombreActualizar + "' WHERE CODIGO = '"+ codigoActualizar +"'", conexion);
            cantAgregados = comando.ExecuteNonQuery();
            conexion.Close();
            lblEstadoInsertar.Text = (cantAgregados > 0 ? "Estudiante con codigo: " + codigoActualizar + " actualizado!" : "Error al actualizar estudiante...");
            updateGrdEstudiantes();
        }

        protected void updateGrdEstudiantes()
        {
            string connectionStringEmpleados = System.Configuration.ConfigurationManager.ConnectionStrings["cadenaConexion1"].ConnectionString;
            SqlDataAdapter Adp = new SqlDataAdapter("SELECT * FROM ESTUDIANTE", connectionStringEmpleados);
            System.Data.DataTable Dt = new System.Data.DataTable();
            Adp.Fill(Dt);
            grdViewEstudiante.DataSource = Dt;
            grdViewEstudiante.DataBind();
        }
    }
}