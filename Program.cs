Quadrado q1 = new Quadrado(10.0);
Quadrado q2 = new Quadrado(5.5);

Console.WriteLine(q1.Lado);
Console.WriteLine(q2.Lado);

q1.Lado = 11.0;
Console.WriteLine(q1.Lado);

Console.WriteLine(q1.Area);
Console.WriteLine(q1.Perimetro);

Console.WriteLine(q2.Area);
Console.WriteLine(q2.Perimetro);

Console.WriteLine("------");

Retangulo r1 = new Retangulo(7.0, 3.0);

Console.WriteLine(r1.Base);
Console.WriteLine(r1.Altura);

r1.Base = 12.0;
Console.WriteLine(r1.Base);

Console.WriteLine(r1.Area);
Console.WriteLine(r1.Perimetro);

