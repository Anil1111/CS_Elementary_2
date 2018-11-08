class ListStack
{
    List<int> list = new List<int>();

    public void Push(int value)
    {
        list.Add(value);
    }

    public int Pop()
    {
        if (list.Count == 0) throw new InvalidOperationException();

        var result = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);

        return result;
    }
}