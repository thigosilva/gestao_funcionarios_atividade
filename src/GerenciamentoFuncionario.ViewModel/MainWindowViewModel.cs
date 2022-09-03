using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using GerenciamentoFuncionario.ViewModel.Comandos;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace GerenciamentoFuncionario.ViewModel
{

    public class MainWindowViewModel : ViewModelBase
    {
        private readonly IFuncionarioProvedorDados _funcionarioProvedorDados;
        private readonly ICargoProvedorDados _cargoProvedorDados;
        private FuncionarioViewModel _funcionarioSelecionadoViewModel;

        public DelegarComando ComandoCarregar { get; }
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

        public MainWindowViewModel(IFuncionarioProvedorDados funcionarioProvedorDados,
            ICargoProvedorDados cargoProvedorDados)
        {
            _funcionarioProvedorDados = funcionarioProvedorDados;
            _cargoProvedorDados = cargoProvedorDados;

            ComandoCarregar = new DelegarComando(Carregar);
        }

        public void Carregar()
        {
            CarregaFuncionarios();
            CarregaCargos();
        }

        private void CarregaCargos()
        {
            //throw new NotImplementedException();
        }

        private void CarregaFuncionarios()
        {
            var funcionarios = _funcionarioProvedorDados.CarregaFuncionarios();

            //foreach (var f in funcionarios)
            //{
            //    Funcionarios.Add(
            //        new FuncionarioViewModel(
            //            new FuncionarioModel
            //            {
            //                NomeCompleto = f.NomeCompleto,
            //                CargoId = f.CargoId,
            //                EBebedorCafe = f.EBebedorCafe
            //            }, _funcionarioProvedorDados)
            //        );
            //}

            funcionarios.ToList().ForEach(f =>
            {
                Funcionarios.Add(
                    new FuncionarioViewModel(
                        new FuncionarioModel
                        {
                            NomeCompleto = f.NomeCompleto,
                            CargoId = f.CargoId,
                            EBebedorCafe = f.EBebedorCafe
                        }, _funcionarioProvedorDados)
                    );
            });

        }
    }
}
