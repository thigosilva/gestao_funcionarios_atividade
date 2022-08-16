﻿using System;
using System.Linq;

namespace GerenciamentoFuncionario.Comuns.Modelos
{
    public class Funcionario : EntidadeBase
    {

        public Funcionario(int id, string nomeCompleto, int cargoId,
            bool eBebedorCafe = false)
        {
            Id = id;
            NomeCompleto = nomeCompleto;
            CargoId = cargoId;
            EBebedorCafe = eBebedorCafe;
            DataEntrada = DateTime.Now;
        }

        private string _nomeCompleto;

        public string NomeCompleto
        {
            get { return _nomeCompleto; }
            set {
                var pedacosNome = value.Trim().Split(" ");
                PrimeiroNome = pedacosNome[0];
                UltimoNome = pedacosNome.Last();
                _nomeCompleto = value;
            }
        }

        public int CargoId { get; protected set; }
        public bool EBebedorCafe { get; protected set; }
        public string PrimeiroNome { get; protected set; }
        public string UltimoNome { get; protected set; }
        public DateTimeOffset DataEntrada { get; protected set; }
    }

    public class Teste{
        public void Testando()
        {
            var funcLucas = new Funcionario(1,"Lucas", 1, true);
            var funcEmerson = new Funcionario(2,"Emerson", 1);
            
        }
    }
}
