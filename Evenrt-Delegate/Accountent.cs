
//receive ,subscriber
namespace Event_Delegate
{

    public class Accountent
    {

        public void onTaskCreated(object source, TaskeventArgs args)
        {
            Console.WriteLine($"Accounting object receive : {args.Task.Title}");
            
        }


    }
}
