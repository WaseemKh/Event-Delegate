using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Delegate
{
    public class NewEmployee
    {

        public void onTaskCreated(object source, TaskeventArgs args)
        {

            Console.WriteLine($"newEmployee object receive : {args.Task.Title}");

        }

    }
}
