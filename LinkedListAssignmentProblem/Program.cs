namespace LinkedListAssignmentProblem
{
    class Progam
    {
        public static void Main(string[] args)
        {
            //Creating the Object of LinkedList Class
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(56);
            linkedList.Append(30);
            linkedList.Display();
            linkedList.Add(70);
            linkedList.Display();
        }
    }
}
