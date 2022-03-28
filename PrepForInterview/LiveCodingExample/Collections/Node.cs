namespace Collections
{
    /// <summary>
    /// Node class will hold the data and the next location
    /// </summary>
    /// <typeparam name="T">The datatype the node is holding</typeparam>
    public class Node<T>
    {
        //Points to the next node
        public Node<T>? Next { get; set; }

        //The Actual data of this node
        public T Data { get; set; }

        public Node()
        { }

        public Node(T p_data)
        {
            Data = p_data;
        }
    }
}