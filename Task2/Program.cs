using System;

class Program
{
    static int TasksCount = 7;
    static void Main(string[] args)
    {
        Program app = new Program();
        app.Run();
    }

    private void Run()
    {
        while (true)
        {
            int TaskNumber = 0;

            try
            {
                Console.WriteLine($"Введите номер задачи 1/{TasksCount}: ");
                TaskNumber = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex + "\n Попробуйте снова!");
                continue;
            }

            switch (TaskNumber)
            {
                case 1:
                    FirstTask();
                    break;
                case 2:
                    SecondTask();
                    break;
                case 3:
                    ThirdTask();
                    break;
                case 4:
                    FourTask();
                    break;
                case 5:
                    FiveTask();
                    break;
                case 6:
                    SixTask();
                    break;
                case 7:
                    SevenTask();
                    break;
                default:
                    Console.WriteLine($"Попробуйте ввести номер задачи. Их кол-во: {TasksCount}");
                    break;
            }
        }
    }

    private void FirstTask() // Упражнение 1 с сайта https://metanit.com/sharp/practice/1.1.php
    {
        int firstNum = 0;
        int secondNum = 0;
        Console.WriteLine("Сейчас будем сравнивать числа. Введите первое число:");
        try
        {
            firstNum = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ты должен вводить именно цифру!!!");
            return;
        }
        Console.WriteLine("Теперь введите второе число:");
        try
        {
            secondNum = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ты должен вводить именно цифру!!!");
            return;
        }
        if (firstNum == secondNum)
        {
            Console.WriteLine($"Цифры одинаковы {firstNum} = {secondNum}");
        }
        else if (firstNum > secondNum)
        {
            Console.WriteLine($"Первое число {firstNum} больше второго {secondNum}");
        }
        else if (firstNum < secondNum)
        {
            Console.WriteLine($"Первое число {firstNum} меньше второго {secondNum}");
        }
    }

    private void SecondTask() // Упражнение 2 с сайта https://metanit.com/sharp/practice/1.1.php
    {
        int firstValue = 0;

        try
        {
            Console.WriteLine("Введите число: ");
            firstValue = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex + "\n Попробуйте снова!");
            return;
        }

        if (firstValue > 5 && firstValue < 10)
        {
            Console.WriteLine($"Число '{firstValue}' больше 5 и меньше 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число!");
        }
    }

    private void ThirdTask() // Упражнение 3 с сайтa https://metanit.com/sharp/practice/1.1.php
    {
        int userValue = 0;

        Console.WriteLine("Введите ваше число:");
        try
        {
            userValue = Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка! Вы ввели не число! \n {ex}");
            return;
        }
        if(userValue == 5 || userValue == 10)
        {
            Console.WriteLine("Число либо равно 5, либо равно 10");
        }
        else
        {
            Console.WriteLine("Неизвестное число");
        }
    }

    private void FourTask() // Упражнение 4 с сайтa https://metanit.com/sharp/practice/1.1.php
    {
        decimal userValue = 0;

        Console.WriteLine("Введите сколько хотите внести в банк под проценты: ");

        try
        {
            userValue = Convert.ToDecimal(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ты должен вводить именно число! Если число с разделителем, то вводить нужно 'запятую' 390,5 ");
            return;
        }

        if(userValue < 100)
        {
            userValue += (userValue / 100) * 5;
        }
        else if(userValue >= 100 && userValue <= 200)
        {
            userValue += (userValue / 100) * 7;
        }
        else if(userValue > 200)
        {
            userValue += (userValue / 100) * 10;
        }
        Console.WriteLine($"Ваш вклад с процентами составляет: {userValue}");
    }
    private void FiveTask() // Упражнение 5 с сайтa https://metanit.com/sharp/practice/1.1.php
    {
        decimal userValue = 0;

        Console.WriteLine("Введите сколько хотите внести в банк под проценты: ");

        try
        {
            userValue = Convert.ToDecimal(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ты должен вводить именно число! Если число с разделителем, то вводить нужно 'запятую' 390,5 ");
            return;
        }

        if(userValue < 100)
        {
            userValue += (userValue / 100) * 5;
        }
        else if(userValue >= 100 && userValue <= 200)
        {
            userValue += (userValue / 100) * 7;
        }
        else if(userValue > 200)
        {
            userValue += (userValue / 100) * 10;
        }
        userValue += 15;
        Console.WriteLine($"Ваш вклад с процентами и с доп.бонусами (+15) составляет: {userValue}");
    }

    private void SixTask() // Упражнение 6 с сайтa https://metanit.com/sharp/practice/1.1.php
    {
        int userValue = 0;
        Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");

        try 
        {
            userValue = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Нужно вводить именно число только из заданного диапазона 1-3");
        }

        switch (userValue)
        {
            case 1:
                Console.WriteLine("Вы выбрали Сложение");
                break;
            case 2:
                Console.WriteLine("Вы выбрали Вычитание");
                break;
            case 3:
                Console.WriteLine("Вы выбрали Умножение");
                break;
            default:
                Console.WriteLine("Число находится вне диапазона 1-3");
                break;
        }
    }
    private void SevenTask() // Упражнение 7 с сайтa https://metanit.com/sharp/practice/1.1.php
    {
        int userValue = 0;
        int result = 0;
        Console.WriteLine("Введите первое число: ");
        int value1 = 0,value2 = 0;

        try 
        {
            value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            value2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            userValue = Convert.ToInt32(Console.ReadLine());

        }
        catch
        {
            Console.WriteLine("Нужно вводить именно число только из заданного диапазона 1-3");
            return;
        }

        switch (userValue)
        {
            case 1:
                result = value1 + value2;
                Console.WriteLine($"Сложение чисел {value1}+{value2}={result}");
                break;
            case 2:
                result = value1 - value2;
                Console.WriteLine($"Вычитание чисел {value1}-{value2}={result}");
                break;
            case 3:
                result = value1 * value2;
                Console.WriteLine($"Умножение чисел {value1}*{value2}={result}");
                break;
            default:
                Console.WriteLine("Число находится вне диапазона 1-3");
                break;
        }
    }
}