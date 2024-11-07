using System.Xml.Serialization;

namespace APP
{
    class Program
    {
        static void Main()
        {
            // ИДЗ 1 Задача 16 уровень 1
            // Console.WriteLine("Введите трёхзначное число");
            // int x = Convert.ToInt32(Console.ReadLine());
            // if (x >= 100 && x <= 999){
            //     string xstr = x.ToString();
            //     string newxstr = xstr[1].ToString() + xstr[0].ToString() + xstr[2].ToString();
            //     int newx = Convert.ToInt32(newxstr);
            //     Console.WriteLine(newx);
            //     Console.ReadLine();
            //}


            // ИДЗ 1 Задача 16 уровень 2
            // Console.WriteLine("Введите четырехзначное число");
            // int x = Convert.ToInt32(Console.ReadLine());
            // if (x >= 1000 && x <= 9999)
            // {
            //     string xstr = x.ToString();
            //     string newxstr = xstr[1].ToString() + xstr[0].ToString() + xstr[3].ToString() + xstr[2].ToString();
            //     int newx = Convert.ToInt32(newxstr);
            //     Console.WriteLine(newx);
            // }


        //     ИДЗ 2 Задача 16 уровень 1
        //     Console.WriteLine("Введите день года");
        //     int k = Convert.ToInt32(Console.ReadLine());
        //     if (k >= 1 && k<=365)
        //     {
        //      int dow = (k - 1) % 7;
        //         if (dow == 5 || dow == 6)
        //         {
        //             Console.WriteLine($"День {k} выходной");
        //         }
        //         else
        //         {
        //             Console.WriteLine($"День {k} рабочий");
        //         }
        //    } 

            // ИДЗ 1 Уровень 2 исправил
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 1000 || number > 9999)
            {
                Console.WriteLine("Число должно быть четырехзначным.");
                return;
            }


        int firstDigit = number / 1000;       
        int secondDigit = (number / 100) % 10; 
        int thirdDigit = (number / 10) % 10;   
        int fourthDigit = number % 10;         


        int newNumber = secondDigit * 1000 + firstDigit * 100 + fourthDigit * 10 + thirdDigit;


        Console.WriteLine(newNumber);

        

            
            

        }
    }
}
