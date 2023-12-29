using DesafioPOO.Models;
using sistemaCelularPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia smartphone1 = new(numero: "123456789", modelo: "tijolão", imei: "abc123", memoria: 32);
Iphone smartphone2 = new(numero: "987654321", modelo: "i13", imei: "bcd456", memoria: 64);
Samsung smartphone3 = new(numero: "246810121", modelo: "a13", imei: "mdf768", memoria: 128);

// métodos

Console.WriteLine("Smartphone Nokia: 📞");
smartphone1.Ligar();
smartphone1.ReceberLigacao();
smartphone1.InstalarAplicativo(nomeApp: "jogo da cobrinha", modelo: smartphone1.Modelo);

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: 📱");
smartphone2.Ligar();
smartphone2.ReceberLigacao();
smartphone2.InstalarAplicativo(nomeApp: "whatsapp", modelo: smartphone2.Modelo);

Console.WriteLine("\n");

Console.WriteLine("Smartphone Samsung: 📱");
smartphone3.Ligar();
smartphone3.ReceberLigacao();
smartphone3.InstalarAplicativo(nomeApp: "instagram", modelo: smartphone3.Modelo);

