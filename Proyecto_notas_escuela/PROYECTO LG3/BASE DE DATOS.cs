using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace PROYECTO_LG3
{
    public class BASE_DE_DATOS
    {
        readonly string cadena = "Data Source=DESKTOP-7NHJLP2; Initial Catalog=Proyecto; User ID=sa; Password=honduras";

        //ENTRADA DEL LOGIN
        public bool validarusuario(string usuario, string contraseña)
        {
            bool uservalido = false;
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append("  SELECT 1 FROM USUARIOS   ");
                consultaSQL.Append("  WHERE  USUARIO=@usuario AND CONTRASEÑA=@contraseña; ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {

                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@usuario", SqlDbType.NVarChar, 50).Value = usuario;
                        comando.Parameters.Add("@contraseña", SqlDbType.NVarChar, 50).Value = contraseña;

                        uservalido = Convert.ToBoolean(comando.ExecuteScalar());
                    }
                }

            }
            catch (Exception)
            {


            }
            return uservalido;

        }

        //TABLAS DE PROGRAMA
        public DataTable seccion()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append("  SELECT * FROM  SECCION   ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return tabla;
        }

        public DataTable status()
        {
            DataTable tabla2 = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append("  SELECT * FROM  STATUS   ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr2 = comando.ExecuteReader();
                        tabla2.Load(dr2);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return tabla2;
        }

        public DataTable grado()
        {
            DataTable tabla3 = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append("  SELECT * FROM  GRADO   ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr3 = comando.ExecuteReader();
                        tabla3.Load(dr3);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
            return tabla3;
        }

        //Insertar la informacion en la base de datos
        public bool InsertarDatos(string codigo, string nombre, string profesor, int idgrado, int idseccion, int notafinal, int idstatus)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO ESCUELA ");
                consultaSQL.Append(" VALUES (@Codigo, @Nombre, @Profesor, @Idgrado, @Idseccion, @Notafinal, @Idstatus); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 50).Value = codigo;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@Profesor", SqlDbType.NVarChar, 50).Value = profesor;
                        comando.Parameters.Add("@Idgrado", SqlDbType.Int).Value = idgrado;
                        comando.Parameters.Add("@Idseccion", SqlDbType.Int).Value = idseccion;
                        comando.Parameters.Add("@Notafinal", SqlDbType.Int).Value = notafinal;
                        comando.Parameters.Add("@Idstatus", SqlDbType.Int).Value = idstatus;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Listar las tablas para ingresar la informacion
        public DataTable ListarDatos()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT E.CODIGO, E.NOMBRE, E.PROFESOR, D.GRADO, S.SECCION, E.NOTAFINAL, ST.STATUS FROM ESCUELA E ");
                consultaSQL.Append(" INNER JOIN GRADO D ON D.ID = E.IDGRADO ");
                consultaSQL.Append(" INNER JOIN SECCION S ON S.ID = E.IDSECCION ");
                consultaSQL.Append(" INNER JOIN STATUS ST ON ST.ID = E.IDSTATUS ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {
            }
            return tabla;
        }

        //Editar los datos ya ingresados
        public bool EditarDatos(string codigo, string nombre, string profesor, int idgrado, int idseccion, int notafinal, int idstatus)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE ESCUELA ");
                consultaSQL.Append(" SET NOMBRE = @Nombre, PROFESOR = @Profesor, IDGRADO = @Idgrado, IDSECCION = @Idseccion, NOTAFINAL = @Notafinal, IDSTATUS = @Idstatus ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 50).Value = codigo;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 50).Value = nombre;
                        comando.Parameters.Add("@Profesor", SqlDbType.NVarChar, 50).Value = profesor;
                        comando.Parameters.Add("@Idgrado", SqlDbType.Int).Value = idgrado;
                        comando.Parameters.Add("@Idseccion", SqlDbType.Int).Value = idseccion;
                        comando.Parameters.Add("@Notafinal", SqlDbType.Int).Value = notafinal;
                        comando.Parameters.Add("@Idstatus", SqlDbType.Int).Value = idstatus;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Eliminar datos
        public bool EliminarDatos(string codigo)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" DELETE FROM ESCUELA ");
                consultaSQL.Append(" WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 50).Value = codigo;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
