using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
int count = 0;
Console.WriteLine("С тех таинственных мгновений\r\nДо сегодняшнего дня\r\nХоровод стихотворений\r\nВ стенах лет ведёт меня.\r\n\r\nНе могу сорваться в дали,\r\nВ очарованном кругу\r\nГоспожой моей печали\r\nНаглядеться не могу.\r\n\r\nНе могу сказать я другу\r\nДружбы верные слова,\r\nИ ведёт меня по кругу\r\nЭта школьница Судьба.");
Console.WriteLine("Введите Слово которое нужно найти");
string leng = Console.ReadLine();
leng = leng.ToLower();
string res = @"Input.txt";
StreamReader sr = new StreamReader(res);
string r = sr.ReadToEnd();
bool result = Regex.IsMatch(r, leng);
Console.WriteLine($"Поиск слова {leng}");
if (result)
{
    String[] words = r.Split(new char[] { ' ', ',' });

    foreach (var word in words)
    {
        if (leng == word.ToLower())
            count++;
    }
    Console.WriteLine(count);
}
else
{
    Console.WriteLine("Совпадений нет");
}