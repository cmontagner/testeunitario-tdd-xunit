﻿using Prime.Servicos;

namespace Prime.TesteUnitario.Servicos
{
    public class ServicoPrime_ValidaPrimeTeste
    {
        private readonly ServicoPrime _servicoPrime;

        public ServicoPrime_ValidaPrimeTeste()
        { 
            _servicoPrime = new ServicoPrime();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void ValidaPrime_Input_RetornaFalso(int value)
        {
            bool resultado = _servicoPrime.ValidaPrime(value);
            Assert.False(resultado, "Não sou cliente prime");
        }
    }
}
