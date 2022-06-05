using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProyectoNotas;
using System.Collections.Generic;

namespace NotasPrueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void pruebaValoresCorrectos()
        {
            List<int> notas = new List<int>();

            notas.Add(0);
            notas.Add(5);
            notas.Add(9);
            notas.Add(3);
            notas.Add(7);
            notas.Add(4);
            notas.Add(8);

            double mediaEsperada = 5.143;
            int suspensosEsperados = 3;
            int aprobadosEsperados = 1;
            int notablesesperados = 2;
            int sobresalienteEsperados = 1;

        }
    }
}
