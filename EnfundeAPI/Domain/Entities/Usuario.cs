using System;
using System.Collections.Generic;

namespace EnfundeAPI.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; } = Guid.NewGuid();

        public string Nombre { get; private set; } = string.Empty;
        public string Correo { get; private set; } = string.Empty;
        public string Rol { get; private set; } = string.Empty; // operario, supervisor, admin
        public bool Activo { get; private set; } = true;

        // EF navigation
        public ICollection<Racimo> EnfundesRealizados { get; private set; } = new List<Racimo>();
        public ICollection<Racimo> CosechasRealizadas { get; private set; } = new List<Racimo>();

        protected Usuario() { }

        public Usuario(string nombre, string correo, string rol)
        {
            Nombre = nombre;
            Correo = correo;
            Rol = rol;
        }

        public void Desactivar() => Activo = false;
        public void Activar() => Activo = true;
    }
}