// string text = "Привет, C#!";

// char letter = 'П';
// char digit = '7';
// char space = ' ';
string text = "Код 2026";
// Console.WriteLine(text.Length);
// Console.WriteLine(text[0]);
// Console.WriteLine(text[text.Length - 1]);

// if (text.Length > 0)
// {
//     Console.WriteLine($"Первый символ: {text[0]}");
// }

// foreach (char symbol in text)
// {
//     Console.WriteLine(symbol);
// }

// for (int i = 0; i < text.Length; i++)
// {
//     Console.WriteLine($"{i}: {text[i]}");
// }

// int CountCharacter(string text, char target)
// {
//     int count = 0;

//     foreach (char symbol in text)
//     {
//         if (symbol == target)
//         {
//             count++;
//         }
//     }

//     return count;
// }

// Console.WriteLine(CountCharacter("мама", 'м'));
// Console.WriteLine(CountCharacter("Код 2026", ' '));
// Console.WriteLine(CountCharacter("", 'а'));

int CountCharacter(string text, char target)
{
    int count = 0;

    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == target)
        {
            count++;
        }
    }

    return count;
}

CountCharacter(text, '6');