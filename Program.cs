using DesafioPOO.Models;

// Implementado: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "12345678", modelo: "Nokia", imei: "72647828", memoria: 128);
Console.WriteLine($"Numero: {nokia.Numero} \nModelo: {nokia.Modelo} \nIMEI: {nokia.IMEI} \nMemória: {nokia.Memoria}");
nokia.Ligar();
nokia.InstalarAplicativo("Twitter");

Console.WriteLine("\nSmartphone Iphone:");
Iphone iphone = new Iphone(numero: "12345678", modelo: "Iphone", imei: "72647828", memoria: 128);
Console.WriteLine($"Numero: {iphone.Numero} \nModelo: {iphone.Modelo} \nIMEI: {iphone.IMEI} \nMemória: {iphone.Memoria}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Twitter");