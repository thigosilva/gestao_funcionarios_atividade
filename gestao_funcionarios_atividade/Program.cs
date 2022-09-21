using System;

namespace gestao_funcionarios_atividade
{
    class Program
    {
        public Cargos(int id, string cargoNome)
        {
            id = id;
            CargoNome = cargoNome;
        }

        public string CargoNome { get; }
    }
}
