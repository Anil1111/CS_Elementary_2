class ListQueue
{
    List<int> list = new List<int>();

    public void Enqueue(int value)
    {
        list.Add(value);
    }

    public int Dequeue()
    {
        if (list.Count == 0) throw new InvalidOperationException();

        var result = list[0];
        list.RemoveAt(0);

        return result;
    }

}