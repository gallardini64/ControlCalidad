using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.InfraestructuraTransversal.Seguridad
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Rol Rol { get; set; }

        public Usuario(int id, string username, string password, string email, Rol rol)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            Rol = rol;
        }

    }
}
