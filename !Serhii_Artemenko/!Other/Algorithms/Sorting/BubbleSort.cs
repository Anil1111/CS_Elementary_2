for (int i = array.Length - 1; i > 0; i--)
{
    for (int j = 1; j <= i; j++)
        if (array[j] < array[j - 1])
        {
            var temp = array[j];
            array[j] = array[j - 1];
            array[j - 1] = temp;
        }
}