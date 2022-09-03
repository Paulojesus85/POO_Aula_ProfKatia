using Aula2_RA6322501;

Filme filme1 = new Filme();

Entrada entrada1 = new Entrada();


filme1.Receber();


Console.WriteLine("Digite o número da poltrona desejada: ");
entrada1.SetPoltrona(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine("Digite o dia desejado para a apresentação: ");
entrada1.SetData(Console.ReadLine());
Console.WriteLine("Digite a hora desejada para a apresentação: ");
entrada1.SetHora(Console.ReadLine());
Console.WriteLine("Digite o valor a ser pago: ");
entrada1.SetValor(Convert.ToDouble(Console.ReadLine()));


filme1.Mostrar();


Console.WriteLine($"Informações da Entrada: Valor: R${entrada1.GetValor()}, Poltrona: {entrada1.GetPoltrona()}, Data: {entrada1.GetData()} e Hora: {entrada1.GetHora()}");

Console.ReadKey();
