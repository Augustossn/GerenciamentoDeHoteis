
class Program
{
    static void Main()
    {
        Hotel hotel = new Hotel();

        hotel.AdicionarQuarto(new Quarto(101, "Duplo", 150.0));
        hotel.AdicionarQuarto(new Quarto(102, "Simples", 100.0));
        hotel.AdicionarQuarto(new Quarto(103, "Suite", 200.0));

        hotel.ListarQuartosDisponíveis();

        Quarto quartoParaReserva = new Quarto(101, "Duplo", 150.0);
        hotel.FazerReserva(quartoParaReserva);

        hotel.FazerReserva(quartoParaReserva);

        hotel.CancelarReserva(quartoParaReserva);

        hotel.ListarQuartosDisponíveis();
    }
}
