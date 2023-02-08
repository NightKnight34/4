using System;
using System.Runtime.Intrinsics.X86;
        var DateList = new List<string>() { "06.01.2077", "08.01.2077", "13.01.2077", "23.01.2077" };

var ZametkaNameList = new List<string>()
    {
        "  Сходить к врачу.\n",
        "  Поехать на зачёт\n",
        "  Убить чудовище.\n",
        "  Помнить про заказ \n"
    };

var ZametkaDiscriptionList = new List<List<string>>();
ZametkaDiscriptionList.Add(new List<string>() { "Принять таблетки от простуды" });
ZametkaDiscriptionList.Add(new List<string>() { "Набрать 70% за тест." });
ZametkaDiscriptionList.Add(new List<string>() { "Сходить за посылкой в Киров." });
ZametkaDiscriptionList.Add(new List<string>() { "Киров репортин." });

int DateNomer = 1;
int CursPos = 1;
bool NegrPashet = true;
Console.WriteLine("Нажмите стрелку влево.");
do
{
    ConsoleKeyInfo key = Console.ReadKey();

    if (key.Key == ConsoleKey.UpArrow)
    {
        if (CursPos > 1)
        {
            CursPos--;
        }
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (CursPos < 5)
        {
            CursPos++;
        }
    }

    else if (key.Key == ConsoleKey.RightArrow)
    {
        if ((DateNomer + 1) < DateList.Count())
        {
            DateNomer = DateNomer + 1;
        }
    }

    else if (key.Key == ConsoleKey.LeftArrow)
    {
        if (DateNomer > 0)
        {
            DateNomer--;
        }
    }

    else if (key.Key == ConsoleKey.T)
    {
        Console.Clear();
        Console.WriteLine("Напишите название заметки:");
        ZametkaNameList[DateNomer] = ZametkaNameList[DateNomer] + "  " + Console.ReadLine() + "\n";
        ZametkaDiscriptionList[DateNomer].Add("");
    }

    else if (key.Key == ConsoleKey.Y)
    {
        NewData();
    }

    else if (key.Key == ConsoleKey.Enter)
    {
        ChangeOpisanie();
    }


    else if (key.Key == ConsoleKey.Escape)
    {
        NegrPashet = false;
    }
    Console.Clear();
    Console.WriteLine(DateList[DateNomer]);
    Console.WriteLine(ZametkaNameList[DateNomer]);
    Console.SetCursorPosition(0, CursPos);
    Console.WriteLine("->");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("[ Y ] - чтобы добавить новую дату.");
    Console.WriteLine("[ T ] - чтобы добавить новую заметку.");

}
while (NegrPashet == true);
{
    Console.Clear();
    Console.WriteLine("Программа завершена...");
}
void NewData()
{
    Console.Clear();
    Console.WriteLine("Введите будущую дату:");
    DateList.Add(Console.ReadLine());
    ZametkaNameList.Add("  ");
    ZametkaDiscriptionList.Add(new List<string>() { });
}
void ChangeOpisanie()
{
    Console.Clear();
    Console.WriteLine(ZametkaNameList[DateNomer]);
    Console.WriteLine("Описание:");
    Console.WriteLine(ZametkaDiscriptionList[DateNomer][CursPos - 1]);
    Console.WriteLine(" ");
    Console.WriteLine(" -=-=-=-=-=-=-=-=-=-=-=-=-=-");
    Console.WriteLine("Дата: " + DateList[DateNomer]);
    Console.WriteLine(" ");
    Console.WriteLine("[ U ] - изменить описание.");
    Console.WriteLine(" ");
    while (Console.ReadKey().Key != ConsoleKey.Backspace)
    {
        if (Console.ReadKey().Key == ConsoleKey.U)
        {
            Console.Clear();
            Console.WriteLine("Введите новое описание:");
            ZametkaDiscriptionList[DateNomer][CursPos - 1] = Console.ReadLine();
            break;
        }
        continue;
    }
}