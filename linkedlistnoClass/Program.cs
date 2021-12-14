// See https://aka.ms/new-console-template for more information

using linkedlistnoClass;

MyLinkedList list = new MyLinkedList();

A:
Console.WriteLine("1.Add Element\n2.Delete Element\n3.Show Element");
int reply = Convert.ToInt32(Console.ReadLine());
try
{
    switch (reply)
    {
        case 1:
            Console.WriteLine("How many Element Are you going to put in Stack?");
            int Count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Count; i++)
            {
                Console.WriteLine("Enter The element : ");
                var element = Console.ReadLine();
                list.AddNode(element);
            }

            break;
        case 2:
            Console.WriteLine("Which Element do you wish to delete ?");
            int elementindex = Convert.ToInt32(Console.ReadLine());
            list.DeleteNode(elementindex);
            break;
        case 3:
            Console.WriteLine("********************************************************\n\n\n");
            list.ShowList();
            Console.WriteLine("\n\n\n*****************************************************\n");
            break;

    }
}
catch (Exception e)
{
    Console.WriteLine(e);
    throw;
}
goto A;