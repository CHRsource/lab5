#pragma warning disable
using System.Text;

// задание 1

//Console.WriteLine("Введите имена через пробел:");
//string names = Console.ReadLine();
//string[] names_list = names.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine("Имена, стоящие раньше имени \"Маша\":");
//for (int i = 0; i < names_list.Length & names_list[i] != "Маша"; i++)
//    Console.WriteLine(names_list[i]);


// задание 2

//Console.WriteLine("Введите строку:");
//string str = Console.ReadLine();
//int count = 0;
//for (int i = 0; i < str.Length - 1; i++)
//{
//    if (str[i] == ' ') count = 0;
//    else count += 1;
//    if (count == 4 & str[i + 1] == ' ')
//    {
//        str = str.Remove(i - 3, i + 1);
//        str = str.Insert(i - 3, "love_is");
//        i += 3;
//    }
//}
//if (count == 3 & str[str.Length - 1] != ' ')
//    str = str.Replace(str.Substring(str.Length - 4), "love_is");
//Console.WriteLine(str);


// задание 3

//Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите строку:");
//string str = Console.ReadLine();
//if (n < str.Length)
//{
//    for (int i = 0; i <= str.Length; i += n)
//    {
//        str = str.Insert(i, ":)");
//        i += 2;
//    }
//}
//Console.WriteLine(str);


// задание 4

//Console.WriteLine("Введите строку:");
//string str = Console.ReadLine();
//char[] sep = { ' ', ',', ';', ':', '.' };
//string[] str_list = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
//int min_index = 0, max_index = 0;
//for (int i = 1; i < str_list.Length; i++)
//{
//    if (str_list[i].Length > str_list[max_index].Length)
//        max_index = i;
//    if (str_list[i].Length < str_list[min_index].Length)
//        min_index = i;
//}
//string res = string.Join(", ", Enumerable.Repeat(str_list[min_index], str_list[min_index].Length));
//res += ", ";
//res += string.Join(", ", Enumerable.Repeat(str_list[max_index], str_list[max_index].Length));
//Console.WriteLine(res);


// задание 5

//Console.WriteLine("Введите строку:");
//string str = Console.ReadLine();
//char[] sep = { ' ', ',', ';', ':', '.' };
//string[] str_list = str.Split(sep, StringSplitOptions.RemoveEmptyEntries);
//str_list = str_list.Distinct().ToArray();
//Console.WriteLine(string.Join(' ', str_list));


// задание 6

//StringBuilder text = new();
//Console.WriteLine("Вводите строки");
//while (true)
//{
//    string str = Console.ReadLine();
//    if (str == "") break;
//    string[] strings = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//    for (int i = 0; i < strings.Length; i++)
//    {
//        if (i % 3 == 0) text.Append(strings[i]);
//        else if (i % 3 == 1)
//        {
//            for (int j = strings[i].Length - 1; j >= 0; j--)
//                text.Append(strings[i][j]);
//        }
//        if (i % 3 != 2 & i != strings.Length - 1) text.Append(" ");
//    }
//    text.Append(". ");
//}
//Console.WriteLine(text);


// задание 7

string str = "Киев Нью-Йорк Амстердам Вена Мельбурн";
string[] str_list = str.Split(' ');
StringBuilder result = new(str_list[0]);
char lastletter = char.ToLower(str_list[0][str_list[0].Length - 1]);
for (int i = 1; i < str_list.Length; i++) {
    for (int j = 1; j < str_list.Length; j++)
    {
        string current = str_list[j];
        char firstletter = char.ToLower(current[0]);
        if (lastletter == firstletter) {
            result.Append(" ");
            result.Append(current);
            lastletter = char.ToLower(current[current.Length - 1]);
        }
    }
}
Console.WriteLine(result);
