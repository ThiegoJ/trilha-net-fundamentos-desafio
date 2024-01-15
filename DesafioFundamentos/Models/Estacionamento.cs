namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        readonly decimal pInicial = 0;
        readonly decimal pPorHora = 0;
        readonly List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            pInicial = precoInicial;
            pPorHora = precoPorHora;
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
                ListarVeiculos();
                Console.WriteLine("Digite a placa do veículo para remover:");
                string placa = Console.ReadLine();

                 if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                if (int.TryParse(Console.ReadLine(), out int horasEstacionado))
                {
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTE AQUI*
                    decimal valorTotal = pInicial + (pPorHora * horasEstacionado);
                    Console.WriteLine($"Valor total a ser pago pelo estacionamento: R$ {valorTotal}");
                    // TODO: Remover a placa digitada da lista de veículos
                    // *IMPLEMENTE AQUI*
                    veiculos.Remove(placa);
                    Console.WriteLine($"Veículo com placa: {placa} removido com sucesso!");
                }
                else
                {
                    Console.WriteLine("O veículo com a placa inserida não está registrado no estacionamento. Verifique a placa e tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
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