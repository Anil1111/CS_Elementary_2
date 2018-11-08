class QueueItem
{
    public int Value { get; set; }
    public QueueItem Next { get; set; }
}

class Queue
{
    QueueItem head;
    QueueItem tail;

    public void Enqueue(int value)
    {
        var item = new QueueItem { Value = value };

        if (head == null)
            head = tail = item;
        else
        {
            tail.Next = item;
            tail = item;
        }
    }

    public int Dequeue()
    {
        if (head == null)
            throw new InvalidOperationException();
        var result = head.Value;
        head = head.Next;

        if (head == null) tail = null;

        return result;
    }
}