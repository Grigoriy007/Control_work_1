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