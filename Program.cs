using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123-456", modelo: "Modelo 1", imei: "111111", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "123-456", modelo: "Modelo 1", imei: "111111", memoria: 8);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");