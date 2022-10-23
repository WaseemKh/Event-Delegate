// See https://aka.ms/new-console-template for more information

using Event_Delegate;
using Task = Event_Delegate.Task;

var task = new Task() { Title = "First Task ", Body = "1-message ,2-message " };
HeadEmployees headEmployees = new(); //publisher
var serviceDoctor = new Doctor(); //subscriber 1
Accountent serviceAccount = new(); // subscriber 2
var newservice = new NewEmployee();
headEmployees.TaskCreated += serviceDoctor.onTaskCreated;
headEmployees.TaskCreated += serviceAccount.onTaskCreated;
headEmployees.TaskCreated += newservice.onTaskCreated;
headEmployees.SendTask(task);
