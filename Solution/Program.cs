string[] FindLength(string[] find1)
{

    int count = default;
    for (int i = 0; i < find1.Length; i++)
    {
        if (find1[i].Length <= 3)
        {
            count++;
        }
    }

    string[] find2 = new string[count];

    return find2;
}

string[] FindAnswer(string[] finder, string[] answer)
{

    int count = default;
    for (int i = 0; i < finder.Length; i++)
    {
        if (finder[i].Length <= 3)
        {
            answer[count] = finder[i];
            count++;
        }

    }
    return answer;

}

void PrintArray(string[] final)
{
    Console.Write("[ ");
    for (int i = 0; i < final.Length; i++)
    {
        if (i < final.Length - 1) Console.Write($"{final[i]},  ");
        else Console.Write($"{final[i]}");
    }
    Console.Write(" ]");
}

string[] Array1 = new string[8] { "hello", "2", "world", ":-)", "-2", "yes", "strong", "ok" };