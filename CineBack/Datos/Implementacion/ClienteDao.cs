using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CineBack.Datos.Implementacion
{
    public class ClienteDao : IClienteDao
    {
        public Cliente GetCliente(int id_usuario)
        {
            throw new NotImplementedException();
        }

        public Usuario LogearCliente(string usuario, string pass)
        {
            Usuario user = new Usuario();
            SqlConnection con = HelperDao.GetInstancia().ObtenerConexion();
            try
            {
                con.Open();
                SqlCommand cmdLogin = new SqlCommand();
                cmdLogin.Connection = con;
                cmdLogin.CommandType = CommandType.StoredProcedure;
                cmdLogin.CommandText = "SP_LOGIN";
                cmdLogin.Parameters.AddWithValue("@usuario", usuario);
                cmdLogin.Parameters.AddWithValue("@pass", pass);

                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@id_usuario";
                paramId.SqlDbType = SqlDbType.Int;
                paramId.Direction = ParameterDirection.Output;
                cmdLogin.Parameters.Add(paramId);

                SqlParameter paramRol = new SqlParameter("@rol", SqlDbType.VarChar, 10);
                paramRol.Direction = ParameterDirection.Output;
                cmdLogin.Parameters.Add(paramRol);

                cmdLogin.ExecuteNonQuery();

                int id_usuario = (int)paramId.Value;
                string rol = paramRol.Value.ToString();

                if (id_usuario != 0)
                {
                    DataTable tabla = new DataTable();
                    SqlCommand cmdCliente = new SqlCommand();
                    cmdCliente.Connection = con;
                    cmdCliente.CommandType = CommandType.StoredProcedure;
                    cmdCliente.CommandText = "SP_TRAER_CLIENTE";
                    cmdCliente.Parameters.AddWithValue("@id_usuario", id_usuario);

                    tabla.Load(cmdCliente.ExecuteReader());

                    foreach (DataRow fila in tabla.Rows)
                    {
                        user.Rol = rol;
                        user.Cliente.IdCliente = int.Parse(fila["id_cliente"].ToString());
                        user.Cliente.Nombre = fila["nombre"].ToString();
                        user.Cliente.Apellido = fila["apellido"].ToString();
                        user.Cliente.Contacto = fila["contacto"].ToString();
                        user.Cliente.Dni = int.Parse(fila["dni"].ToString());
                        int tipo_cliente = int.Parse(fila["id_tipo_cliente"].ToString());
                        switch (tipo_cliente)
                        {
                            case 1:
                                user.Cliente.TipoCliente = Tipos_Cliente.Niño;
                                break;
                            case 2:
                                user.Cliente.TipoCliente = Tipos_Cliente.Joven;
                                break;
                            case 3:
                                user.Cliente.TipoCliente = Tipos_Cliente.Adulto;
                                break;
                            case 4:
                                user.Cliente.TipoCliente = Tipos_Cliente.Jubilado;
                                break;
                            default:
                                user.Cliente.TipoCliente = Tipos_Cliente.Niño;
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            finally 
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return user;
        }


        public bool RegistrarCliente(Usuario usuario)
        {
            bool resultado = true;
            SqlConnection conexion = HelperDao.GetInstancia().ObtenerConexion();
            SqlTransaction transaccion = null;
            try
            {
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                SqlCommand cmdUsuario = new SqlCommand();
                cmdUsuario.Connection = conexion;
                cmdUsuario.Transaction = transaccion;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "SP_NUEVO_USUARIO";
                cmdUsuario.Parameters.AddWithValue("@user", usuario.User);
                cmdUsuario.Parameters.AddWithValue("@pass", usuario.Pass);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id_usuario";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmdUsuario.Parameters.Add(param);

                cmdUsuario.ExecuteNonQuery();

                int id_usuario = (int)param.Value;

                SqlCommand cmdCliente = new SqlCommand();
                cmdCliente.Connection = conexion;
                cmdCliente.Transaction = transaccion;
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "SP_NUEVO_CLIENTE";
                cmdCliente.Parameters.AddWithValue("@nombre", usuario.Cliente.Nombre);
                cmdCliente.Parameters.AddWithValue("@apellido", usuario.Cliente.Apellido);
                cmdCliente.Parameters.AddWithValue("@dni", usuario.Cliente.Dni);
                cmdCliente.Parameters.AddWithValue("@contacto", usuario.Cliente.Contacto);
                cmdCliente.Parameters.AddWithValue("@id_tipo_cliente", usuario.Cliente.TipoCliente);
                cmdCliente.Parameters.AddWithValue("@id_usuario", id_usuario);

                cmdCliente.ExecuteNonQuery();

                transaccion.Commit();
            }
            catch
            {
                if (transaccion != null)
                {
                    transaccion.Rollback();
                    resultado = false;
                }
            }

            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }

            return resultado;
        }

        public bool UsuarioExistente(string usuario)
        {
            bool existente = true;
            DataTable tabla = HelperDao.GetInstancia().ConsultarConParam("SP_USUARIO_EXISTENTE", new Parametro("@usuario", usuario));
            if (tabla.Rows.Count > 0)
            {
                existente = false;
            }
            return existente;
        }







        //public bool EliminarCliente(Cliente cliente)
        //{

        //}
    }
}
