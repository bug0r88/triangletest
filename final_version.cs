static double TriangleP(double a, double b, double c)//функция периметра
{
    double P = a + b + c;
    return P;
}
static double TriangleS(double a, double b, double c)//функция площади
{
    double P = a + b + c;
    double p = (a + b + c)/2;
    double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    return S;
}
bool err = false;//флаг для определения ошибки
Console.WriteLine("===Программа-тест для треугольника===");
Console.WriteLine("Введите стороны треуголньника");
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
    if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA ){
        err = true;
        Console.WriteLine("ОШИБКА!!! Превышено допустимое ограничение!");}
    if (sideA == 0 || sideB == 0 || sideC == 0){
        err = true;
        Console.WriteLine("ОШИБКА!!! Введён Ноль!");}
    if(!err)    
        Console.WriteLine($"~Периметр:{TriangleP(sideA, sideB, sideC)}\n~Площадь:{TriangleS(sideA, sideB, sideC)}");
    if((sideA == sideB && sideA == sideC && sideB == sideC)&&!err){
        System.Console.WriteLine("Треугольник равносторонний\n");
    }else if((sideA == sideB || sideA == sideC || sideB == sideC)&&!err){
        System.Console.WriteLine("Треугольник равнобедренный\n");
    }else{
        if(!err&&(sideA!=sideB && sideA!=sideC && sideB!= sideC)){
            System.Console.WriteLine("Треугольник разнасторонний\n");}
        else{
            System.Console.WriteLine("Невозможно определить треугольник!\n");}
    }
}
catch (FormatException)
{
    Console.WriteLine("ОШИБКА!!! Невeрный формат ввода!");
}
finally{
    Console.WriteLine("Программа завершена");
}
