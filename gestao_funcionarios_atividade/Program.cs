using System;
using System.IO;
using System.Threading.Tasks;

namespace gestao_funcionarios_atividade
{
    class Program
    {
        private static object acessoii0;

        public static object ListCEP { get; private set; }
        public static object JsonConvert { get; private set; }

        static async Task Main(string[] args)
        {
            string filePath = @"C:\Users\USUÁRIO\source\repos\Caso der Tudo errado";
            var ObjetoDados = JsonConvert.SerializeObject(ListCEP);
            await File.WriteAllTextAsync(filePath, ObjetoDados);
            Console.WriteLine("Dados Salvos com Sucesso !!!");acessoii0
        }
    }
}
