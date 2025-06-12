public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        else
        {
            return;
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
        else
        {
            return true;
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (Left is null && Right is null)
        {
            return 1;
        }

        int leftHeight = Left is not null ? Left.GetHeight() : 0;
        int rightHeight = Right is not null ? Right.GetHeight() : 0;

        if (leftHeight > rightHeight)
        {
            return leftHeight + 1;
        }
        else
        {
            return rightHeight + 1;
        }
    }
}