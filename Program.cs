using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double summa, percent, interval, total, income, EC;
           
            Console.WriteLine("Введите сумму денег на вклад");
            summa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите годовой процент по вкладу");
            percent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите интервал времени вклада в месяцах");
            interval = Convert.ToDouble(Console.ReadLine());

            income = summa*percent*interval/(12*100);
            total = income+summa;
            EC = (Math.Pow((1+percent/(100*12)), interval)-1)*12*100/interval;

            Console.WriteLine("Итоговая сумма: " + total );
            Console.WriteLine("Доход: " + income );
            Console.WriteLine("Эффективный процент доходности вклада: " + Math.Round(EC, 3)); 
        }
    }
}
