namespace LinkedListAssignmentProblem
{
    class Progam
    {
        public static void Main(string[] args)
        {
            //Creating the Object of LinkedList Class
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Add(56);
            linkedList.Add(70);
            linkedList.Display();
            linkedList.AddingAtParticularPosition(2, 30);
            linkedList.Display();
            linkedList.RemoveFirstNode();
            linkedList.Display();
        }
    }
}
