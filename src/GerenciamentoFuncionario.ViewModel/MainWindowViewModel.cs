using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System.Collections.ObjectModel;

namespace GerenciamentoFuncionario.ViewModel
{

    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IFuncionarioProvedorDados _funcionarioProvedorDados;
        //controlar os cargos
        private readonly FuncionarioViewModel _funcionarioViewModel;
        private FuncionarioModel _funcionarioSelecionado;

        public MainWindowViewModel(IFuncionarioProvedorDados funcionarioProvedorDados)
        {
            _funcionarioProvedorDados = funcionarioProvedorDados;
        }

        public ObservableCollection<FuncionarioViewModel> Funcionarios { get; } = new();
        public ObservableCollection<Cargo> Cargos { get; } = new();


        public FuncionarioModel FuncionarioSelecionado
        {
            get => _funcionarioSelecionado;
            set
            {
                if (_funcionarioSelecionado != value)
                {
                    _funcionarioSelecionado = value;
                    RaisePropertyChanged();
                }
            }
        }

        //CONTINUAR

    }
}
