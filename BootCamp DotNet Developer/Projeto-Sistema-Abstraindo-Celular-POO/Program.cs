using Projeto_Sistema_Abstraindo_Celular_POO.Models;

Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo M14", imei: "145826", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n*****************");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "89652356", modelo: "Modelo I12", imei: "842365", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ITunes");