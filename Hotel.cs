public class Quarto
{
    public int Numero { get; set; }
    public string Tipo { get; set; }
    public double PreçoPorNoite { get; set; }
    public bool Disponivel { get; set; }

    public Quarto(int numero, string tipo, double preçoPorNoite)
    {
        Numero = numero;
        Tipo = tipo;
        PreçoPorNoite = preçoPorNoite;
        Disponivel = true;
    }
}
public class Reserva
{
    public Quarto Quarto { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }
    public string HóspedeNome { get; set; }
    public double ValorTotal { get; private set; }
    public Reserva(Quarto quarto, DateTime dataEntrada, DateTime dataSaida, string hóspedeNome)
    {
        Quarto = quarto;
        DataEntrada = dataEntrada;
        DataSaida = dataSaida;
        HóspedeNome = hóspedeNome;
        ValorTotal = CalcularValorTotal();
    }
    private double CalcularValorTotal()
    {
        int numeroDeNoites = (DataSaida - DataEntrada).Days;
        return numeroDeNoites * Quarto.PreçoPorNoite;
    }
}
public class Hotel
{
    private List<Quarto> quartos;

    public Hotel()
    {
        quartos = new List<Quarto>();
    }
    public void AdicionarQuarto(Quarto novoQuarto)
    {
        var quartoExistente = quartos.Find(q => q.Numero == novoQuarto.Numero);
        if (quartoExistente != null)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Já existe um quarto com este número.");
            return;
        }
        quartos.Add(novoQuarto);
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Quarto adicionado com sucesso.");
    }
    public void FazerReserva(Quarto quarto)
    {
        var quartoParaReservar = quartos.Find(q => q.Numero == quarto.Numero);
        if (quartoParaReservar != null && quartoParaReservar.Disponivel)
        {
            quartoParaReservar.Disponivel = false;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Reserva feita para o quarto {quartoParaReservar.Numero}");
        }
        else
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Quarto {quarto.Numero} não está disponível para reserva.");
        }
    }
    public void CancelarReserva(Quarto quarto)
    {
        var quartoParaCancelar = quartos.Find(q => q.Numero == quarto.Numero);
        if (quartoParaCancelar != null && !quartoParaCancelar.Disponivel)
        {
            quartoParaCancelar.Disponivel = true;
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Reserva cancelada para o quarto {quartoParaCancelar.Numero}");
        }
        else
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Quarto {quarto.Numero} não está reservado.");
        }
    }
    public void ListarQuartosDisponíveis()
    {
        foreach (var quarto in quartos)
        {
            if (quarto.Disponivel)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"Quarto {quarto.Numero} - Tipo: {quarto.Tipo}, Preço por Noite: {quarto.PreçoPorNoite:C}, Disponível: {quarto.Disponivel}");
            }
        }
    }
}