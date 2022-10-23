
//receive ,subscriber
namespace Event_Delegate
{
    public class Doctor
    {
        public void onTaskCreated(object source, EventArgs args)
        {
            Console.WriteLine($"Doctor object receive");

        }
    }
}
