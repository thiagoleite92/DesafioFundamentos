namespace DesafioFundamentos.Models
{
    public class Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        private readonly decimal precoInicial = precoInicial;
        private readonly decimal precoPorHora = precoPorHora;
        private readonly List<string> veiculos = [];

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.Equals(placa, StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine(
                    "Um veículo já foi cadastrado com essa placa. Verifique sua placa e tente de novo."
                );
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo estacionado.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.Equals(placa, StringComparison.CurrentCultureIgnoreCase)))
            {
                Console.WriteLine(
                    "Digite a quantidade de horas que o veículo permaneceu estacionado:"
                );

                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0;

                valorTotal = precoInicial + (precoPorHora * horas);

                veiculos.Remove(placa);

                Console.WriteLine(
                    $"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}"
                );
            }
            else
            {
                Console.WriteLine(
                    "Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente"
                );
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Os veículos estacionados são:");

                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
