static double TriangleP(double a, double b, double c)
{
    double P = a + b + c;
    return P;
}
static double TriangleS(double a, double b, double c)
{
    double P = a + b + c;
    double p = (a + b + c)/2;
    double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    return S;
}
bool err = false;
Console.WriteLine("===Программа-тест для треугольника===");
Console.WriteLine("Введите стороны треуголньника с максимальным значением 50");
try
{
    Console.Write("Сторона а: ");
    double sideA = Convert.ToDouble(Console.ReadLine());
    Console.Write("Сторона b: ");
    double sideB = Convert.ToDouble(Console.ReadLine());
    Console.Write("Сторона c: ");
    double sideC = Convert.ToDouble(Console.ReadLine());
    if (sideA < 0 || sideB < 0 || sideC < 0){
        err = true;
        Console.WriteLine("ОШИБКА!!! Отрицательное значение!");}
    if (sideA > 50 || sideB > 50 || sideC > 50){
        err = true;
        Console.WriteLine("ОШИБКА!!! Превышено допустимое ограничение!");}
    if (sideA == 0 || sideB == 0 || sideC == 0){
        err = true;
        Console.WriteLine("ОШИБКА!!! Введён Ноль!");}
    if(!err)    
        Console.WriteLine($"Периметр:{TriangleP(sideA, sideB, sideC)}\nПлощадь:{TriangleS(sideA, sideB, sideC)}");
    if((sideA == sideB && sideA == sideC && sideB == sideC)&&!err){
        System.Console.WriteLine("Треугольник равносторонний");
    }else if((sideA == sideB || sideA == sideC || sideA == sideC)&&!err){
        System.Console.WriteLine("Треугольник равнобедренный");
    }else{
        if(!err){
            System.Console.WriteLine("Треугольник разносторонний");}
        else{
            System.Console.WriteLine("Невозможно определить треугольник");}
    }
}
catch (FormatException)
{
    Console.WriteLine("ОШИБКА!!! Неврный формат ввода");
}
finally{
    Console.WriteLine("Программа завершена");
}
