using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;

namespace GerenciamentoFuncionario.ViewModel
{
    public partial class FuncionarioViewModel : ViewModelBase
    {
        private readonly IFuncionarioProvedorDados _funcionarioProvedorDados;
        private readonly FuncionarioModel _funcionarioModel;

        public FuncionarioViewModel(FuncionarioModel funcionarioModel, IFuncionarioProvedorDados funcionarioProvedorDados)
        {
            _funcionarioProvedorDados = funcionarioProvedorDados;
            _funcionarioModel = funcionarioModel;
        }

        public string NomeCompleto
        {
            get => _funcionarioModel.NomeCompleto;
            set
            {
                if (_funcionarioModel.NomeCompleto != value)
                {
                    _funcionarioModel.NomeCompleto = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(PodeSalvar));
                }
            }
        }

        public int CargoId
        {
            get => _funcionarioModel.CargoId;
            set
            {
                if (_funcionarioModel.CargoId != value)
                {
                    _funcionarioModel.CargoId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool EBebedorCafe
        {
            get => _funcionarioModel.EBebedorCafe;
            set
            {
                if (_funcionarioModel.EBebedorCafe != value)
                {
                    _funcionarioModel.EBebedorCafe = value;
                    RaisePropertyChanged();
                }
            }
        }

        public bool PodeSalvar => !string.IsNullOrWhiteSpace(NomeCompleto);

        public void Salvar()
        {
            _funcionarioProvedorDados.SalvaFuncionario(
                new Funcionario(
                    _funcionarioModel.NomeCompleto,
                    _funcionarioModel.CargoId,
                    _funcionarioModel.EBebedorCafe)
            );
        }
    }
}
