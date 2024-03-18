using System;
using Xunit;
using Prime.Servicos;

namespace Prime.TesteUnitario.Servicos
{
    public class ServicoPrime_ValidaPrimeTeste
    {
        [Fact]
        public void ValidaPrime_Input_RetornaFalso()
        {
            var servicoPrime = new ServicoPrime();
            bool resultado = servicoPrime.ValidaPrime(1);
            Assert.False(resultado, "Não sou cliente prime");
        }
    }
}
