// See https://aka.ms/new-console-template for more information
using Task = Event_Delegate.Task;

/*
/*why use event 
 * 1- A mechanism  for communication between object
 * 2- used in building loosely coupled app
 * 3- extending app
 * used with method only .. not intersting how much service there but method 
 * how connection with spetial method -which method connect between all services connect this is delegate responsabilty .
 * 
 *Delegate : 
 *1- Agreement / contract between publisher and subcriber  
 *2- Determines the signature of the event handler method in subscriber
 */

public class  TaskeventArgs : EventArgs
{
    public Task Task { get; set; }
}
//publisher ,sender


public class HeadEmployees

{
    //1- define a delegate
    //2- define a event based on that delegate 
    //3-raise th event


    //eventHandler
    //evetHandler<TEventArgs>

   // public delegate void TaskCreatedEventHandler(object resource , TaskeventArgs args); //insted of EventArgs
  // public event TaskCreatedEventHandler TaskCreated;
    public event EventHandler<TaskeventArgs> TaskCreated;


    public   void SendTask(Task task)
    {
        Console.WriteLine("Start ....!");
        //Doctor _serviceDoctor = new();
        //Accountent _serviceAccount = new();
        //_serviceDoctor.send(_task);
        //_serviceAccount.send(_task);
        onTaskCreated(task);
    }

    protected virtual void onTaskCreated(Task task)
    {
        if (TaskCreated is not null)
            TaskCreated(this, new TaskeventArgs() { Task=task});
    }
}
