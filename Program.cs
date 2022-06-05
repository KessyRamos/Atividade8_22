double n1 = 10;
double n2 = 100;
double v;

Console.WriteLine("Calcular a subtração de dois valores!!!");

v = n1 - n2;

if( v < 0){
    Console.WriteLine($"Valor negativo! O valor é: {v}");
}else if(v > 0){
    Console.WriteLine($"Valor positivo! O valor é: {v}");
}else {
    Console.WriteLine("Valor Zero!");
}
