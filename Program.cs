using DesafioPOO.Models;

//Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smarthphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smarthphone Iphone:");
Smartphone iphone = new Iphone(numero: "56789", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
