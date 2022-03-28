namespace Collections
{
    public class Stack<T>
    {
        //How do we store the data?
        //Array way is one option
        //Node way is one option

        public Node<T> Top { get; set; }

        //Push a new data in our node
        public void Push(T p_value)
        {
            Node<T> newNode = new Node<T>(p_value);

            newNode.Next = Top;

            Top = newNode;
            // throw new NotImplementedException();
        }

        public T Pop()
        {
            if (Top == null)
            {
                throw new InvalidOperationException();
            }
            
            Node<T> popNode = Top;

            //We are setting our top node to be the previous node   
            Top = Top.Next;

            return popNode.Data;
        }


        public T Peek()
        {
            if (Top == null)
            {
                throw new InvalidOperationException();
            }

            return Top.Data;
        }
    }
}