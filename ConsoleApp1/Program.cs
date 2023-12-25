//Лаб 5.2 Высокий 20

Console.WriteLine("Введите предложение: ");
string sentence = Console.ReadLine();
string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
bool longWord = false;
foreach (string word in words)
{
    if (word.Length >= 10)
    {
        longWord = true;
        break;
    }
}
if (longWord)
{
    Console.WriteLine($"Да, в предложении есть слово длиной более 10 символов.");
}
else
{
    Console.WriteLine($"Нет, в предложении нет слова длиной более 10 символов.");
}