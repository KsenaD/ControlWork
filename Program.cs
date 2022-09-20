string [] Array = new string [3]{"один", "два", "2022"};
List<string> Result = new List<string>();
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length<=3)
    {
        Result.Add(Array[i]);
    }
}
Console.Write ($"Массив из строк, длина которых меньше или равна 3 символам: ");
for (int i = 0; i < Result.Count; i++)
{
Console.Write (Result[i] + " ");
}
