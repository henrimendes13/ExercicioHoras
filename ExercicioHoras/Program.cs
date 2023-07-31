int n, horas, resto, minutos, segundos;

Console.WriteLine("digite a quantidade de segundos: ");

n = int.Parse(Console.ReadLine());
horas = n / 3600;
resto = n % 3600;
minutos = resto / 60;
segundos = resto % 60;

Console.Write("Resultado em horas: " + horas + ":" + minutos + ":" + segundos);

