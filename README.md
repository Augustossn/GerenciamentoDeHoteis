# Sistema de Gerenciamento de Hotéis

## Descrição
Este é um sistema básico de gerenciamento de hotéis desenvolvido em C# utilizando o ambiente de desenvolvimento Visual Studio. O sistema permite adicionar quartos, fazer e cancelar reservas, e listar os quartos disponíveis.

## Funcionalidades

- **Adicionar Quartos:** Permite adicionar novos quartos ao sistema, especificando o número do quarto, tipo e preço por noite.
- **Fazer Reserva:** Permite reservar um quarto disponível, alterando seu status para indisponível.
- **Cancelar Reserva:** Permite cancelar uma reserva, tornando o quarto disponível novamente.
- **Listar Quartos Disponíveis:** Exibe todos os quartos que estão disponíveis para reserva, junto com suas informações detalhadas.

## Instruções de Uso

### Adicionar Quartos
1. Utilize o método `AdicionarQuarto` para adicionar novos quartos ao hotel.
2. Cada quarto deve ter um número único, tipo (por exemplo, "Duplo", "Simples", "Suite") e preço por noite.

### Fazer Reserva
1. Utilize o método `FazerReserva` para reservar um quarto disponível.
2. A reserva altera o status do quarto para indisponível.

### Cancelar Reserva
1. Utilize o método `CancelarReserva` para cancelar uma reserva existente.
2. A reserva cancelada altera o status do quarto para disponível novamente.

### Listar Quartos Disponíveis
1. Utilize o método `ListarQuartosDisponíveis` para listar todos os quartos disponíveis no hotel.

## Exemplo de uso junto com o programa
