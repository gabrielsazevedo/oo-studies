﻿using oo_studies.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oo_studies.Service
{
    internal class Servico
    {
        public void Calcular(IRemuneravel funcionario)
        {
            decimal saldo;
            saldo = funcionario.Remuneracao();
            Console.WriteLine(saldo);
        }
        public bool ValidarFuncionario(string nomeFuncionario, string vinculoEmpregaticio, string matricula)
        {
            if (string.IsNullOrEmpty(nomeFuncionario) ||
                string.IsNullOrEmpty(vinculoEmpregaticio) ||
                string.IsNullOrEmpty(matricula))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
