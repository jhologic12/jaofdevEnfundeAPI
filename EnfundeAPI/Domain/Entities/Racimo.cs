using System;

namespace EnfundeAPI.Domain.Entities
{
    public class Racimo
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public Guid LoteId { get; private set; }
        public DateTime FechaEnfunde { get; private set; } = DateTime.UtcNow;
        public string ColorCinta { get; private set; } = string.Empty;
        public string Estado { get; private set; } = "enfunde";
        public DateTime? FechaCosecha { get; private set; }
        public Guid? OperarioEnfundeId { get; private set; }
        public Guid? OperarioCosechaId { get; private set; }

        // EF navigation properties
        public Lote Lote { get; private set; } = null!;
        public Usuario OperarioEnfunde { get; private set; } = null!;
        public Usuario OperarioCosecha { get; private set; } = null!;

        protected Racimo() { }

        public Racimo(Guid loteId, DateTime fechaEnfunde, string colorCinta, Guid operarioEnfundeId)
        {
            LoteId = loteId;
            FechaEnfunde = fechaEnfunde;
            ColorCinta = colorCinta;
            Estado = "enfunde";
            OperarioEnfundeId = operarioEnfundeId;
        }

        public int EdadSemanas => (int)Math.Floor((DateTime.UtcNow - FechaEnfunde).TotalDays / 7);

        public void MarcarListo()
        {
            if (Estado == "enfunde" && EdadSemanas >= 11)
                Estado = "listo";
        }

        public void RegistrarCosecha(DateTime fechaCosecha, Guid operarioCosechaId)
        {
            FechaCosecha = fechaCosecha;
            OperarioCosechaId = operarioCosechaId;
            Estado = "cosechado";
        }
    }
}