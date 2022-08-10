namespace GerenciamentoFuncionario.Comuns.Modelos
{
    public class Cargo
    {
        public Cargo(int id, string cargoNome)
        {
            Id = id;
            CargoNome = cargoNome;
        }

        public int Id { get; protected set; }
        public string CargoNome { get; protected set; }
    }
}
