using ProyectoBase.Dominio.Contratos;
using ProyectoBase.InfraestructuraTransversal.Seguridad;
using ProyectoBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace ProyectoBase.Presentadores
{
    public class PresentadorAcceso : PresentadorBase<IVistaAcceso>
    {
        public EventHandler<Sesion> InicioSesion;
        public PresentadorAcceso(EventHandler<Sesion> suscriptor)
        {
            InicioSesion += suscriptor;
        }
        public void Ingresar(string username, string password)
        {
            InicioSesion?.Invoke(this, FactoriaDeSesiones.Instance.IniciarSesion(buscarUsuario(username), password));
        }
        private Usuario buscarUsuario(string username)
        {
            SqlConnection con = new SqlConnection(
             @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\4to Año\Ingeniería de Software\TPN° 1\Codigo\ProyectoBase.Datos\DB\ControlCalidadDB.mdf;Integrated Security=True");
            con.Open();
            string sql = "SELECT Us.[Id], Us.[Username], Us.[Password],Us.[Email], Us.[Rol_Id], r.[Nombre] " +
                "FROM Usuario AS Us INNER JOIN Rol AS r ON Us.[Rol_Id] = r.[Id] where Username = @username1;"; 
            
            var comando = new SqlCommand(sql, con);
            comando.Parameters.AddWithValue("username1", username);
            var resultado = comando.ExecuteReader();
            resultado.Read();
            Usuario u = new Usuario(Int32.Parse(resultado[0].ToString()),
                                resultado[1].ToString(),
                                resultado[2].ToString(),
                                resultado[3].ToString(),
                                new Rol(Int32.Parse(resultado[4].ToString()), resultado[5].ToString()));

            con.Close();
            return u;
        }


    }
}
