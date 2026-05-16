using c = System.Console;

namespace Lab7
{
    // 1. Define the Delegate (The signature of the method that will handle the event)
    public delegate void TaskFinishedHandler(string msg);

    public class TaskManager
    {
        // 2. Define the Event using the Delegate
        public event TaskFinishedHandler OnTaskFinished;

        public void StartTask()
        {
            c.WriteLine("Task in progress...");

            // 3. Raise the Event (Notify all subscribers)
            if (OnTaskFinished != null)
            {
                OnTaskFinished("The backup process is complete!");
            }
        }
    }

    class q4
    {
        static void Main()
        {
            TaskManager manager = new TaskManager();

            // 4. Subscribe to the Event (Attaching a method to the event)
            manager.OnTaskFinished += ShowNotification;

            // Start the process
            manager.StartTask();

            c.ReadLine();
        }

        // 5. The Event Handler (The method that executes when the event fires)
        static void ShowNotification(string msg)
        {
            c.WriteLine($"Notification: {msg}");
        }
    }
}