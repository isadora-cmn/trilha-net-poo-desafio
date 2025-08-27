using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");






// Nokia n1= new Nokia (numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
// n1.Ligar();
// n1.ReceberLigacao();
// n1.InstalarAplicativo("WhatsApp");

// Console.WriteLine();

// Iphone p1 = new Iphone("9876-5432", "Apple", "iPhone 15", 128, "iOS 17");
// p1.Ligar();
// p1.ReceberLigacao();
// p1.InstalarAplicativo("Instagram");

// Console.WriteLine();

