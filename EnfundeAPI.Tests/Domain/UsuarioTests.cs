using EnfundeAPI.Domain.Entities;
using Xunit;

namespace EnfundeAPI.Tests.Domain
{
    public class UsuarioTests
    {
        [Fact]
        public void Usuario_DeberiaEstarActivoAlCrearse()
        {
            var usuario = new Usuario("Jhon", "jhon@correo.com", "operario");

            Assert.True(usuario.Activo);
        }

        [Fact]
        public void Usuario_Desactivar_DeberiaCambiarActivoAFalso()
        {
            var usuario = new Usuario("Jhon", "jhon@correo.com", "operario");
            usuario.Desactivar();

            Assert.False(usuario.Activo);
        }
    }
}