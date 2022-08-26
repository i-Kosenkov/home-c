Console.Write("Введите пятизначное число: ");
bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

if (!isNum_x || x <= 9999 || x > 99999)
{
    Console.WriteLine("Ошибка ввода");
    return;
}

bool isPalindrome(int Number)
{
    int OriginalNumber = Number;
    int Reverse = 0;
    while (Number > 0)
    {
        Reverse = Reverse + (Number % 10);
        Number = Number / 10;
        Reverse = Reverse * 10;
    }
    Reverse = Reverse / 10;
    if (OriginalNumber == Reverse)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write($"Число палиндром? {isPalindrome(x)}");