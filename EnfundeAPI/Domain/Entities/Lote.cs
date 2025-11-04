using System;
using System.Collections.Generic;

namespace EnfundeAPI.Domain.Entities
{
    public class Lote
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Nombre { get; private set; } = string.Empty;
        public string Ubicacion { get; private set; } = string.Empty;
        public int AreaM2 { get; private set; }
        public string Responsable { get; private set; } = string.Empty;

        // EF navigation
        public ICollection<Racimo> Racimos { get; private set; } = new List<Racimo>();

        // Constructor protegido para EF Core
        protected Lote() { }

        // Constructor explícito para lógica de negocio
        public Lote(string nombre, string ubicacion, int areaM2, string responsable)
        {
            Nombre = nombre;
            Ubicacion = ubicacion;
            AreaM2 = areaM2;
            Responsable = responsable;
        }
    }
}