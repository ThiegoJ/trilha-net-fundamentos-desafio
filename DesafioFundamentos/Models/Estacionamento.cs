namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // Implementado!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Implementado!

            if (veiculos.Any())
            {
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = Console.ReadLine();

                if (veiculos.Any())
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    string entrada = Console.ReadLine();

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                    // Implementado!

                    try
                    {
                        int horas = int.Parse(entrada);
                        decimal valorTotal = precoInicial + precoPorHora * horas;

                        veiculos.Remove(placa);

                        Console.WriteLine($"O veículo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Por favor, digite um valor válido para as horas.");
                    }

                    // TODO: Remover a placa digitada da lista de veículos
                    // Implementado

                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }

            // Verifica se o veículo existe

        }
        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // Implementado!
                foreach (var i in veiculos)
                {
                    Console.WriteLine(i.ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}