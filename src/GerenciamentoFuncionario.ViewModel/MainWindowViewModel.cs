using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System;
using System.Collections.ObjectModel;

namespace GerenciamentoFuncionario.ViewModel
{

    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IFuncionarioProvedorDados _funcionarioProvedorDados;
        private readonly ICargoProvedorDados _cargoProvedorDados;
        private FuncionarioViewModel _funcionarioSelecionadoViewModel;

        public MainWindowViewModel(IFuncionarioProvedorDados funcionarioProvedorDados,
            ICargoProvedorDados cargoProvedorDados)
        {
            _funcionarioProvedorDados = funcionarioProvedorDados;
            _cargoProvedorDados = cargoProvedorDados;
        }

        public ObservableCollection<FuncionarioViewModel> Funcionarios { get; } = new();
        public ObservableCollection<Cargo> Cargos { get; } = new();


        public FuncionarioViewModel FuncionarioSelecionado
        {
            get => _funcionarioSelecionadoViewModel;
            set
            {
                if (_funcionarioSelecionadoViewModel != value)
                {
                    _funcionarioSelecionadoViewModel = value;
                    RaisePropertyChanged();
                }
            }
        }

        //public bool FuncionarioEstaSelecionado => FuncionarioSelecionado != null;

        public void Carregar()
        {
            CarregaFuncionarios();
            CarregaCargos();
        }

        private void CarregaCargos()
        {
            throw new NotImplementedException();
        }

        private void CarregaFuncionarios()
        {
            var funcionarios = _funcionarioProvedorDados.CarregaFuncionarios();
        }
    }
}
