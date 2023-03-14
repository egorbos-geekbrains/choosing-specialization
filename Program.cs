// Вспомогательные функции
string[]? GetValues()
{
    Console.Write($"\nВведите элементы разделяя пробелом: ");
    var values = Console.ReadLine()?.Split(" ").ToArray();
    return values;
}

//
Console.Clear();

var array = GetValues();
var filtered = string.Empty;

while (array is null || array.Length < 2)
{
    array = GetValues();
}

foreach (var item in array)
{
    if (item.Length < 4)
    {
        filtered += $"{item}\n";
    }
}

var result = filtered.Split('\n', StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"Результат: [{string.Join(", ", result)}]");