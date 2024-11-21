Task task1 = new Task(
    ()=>{
        Thread.Sleep(100);
        Console.WriteLine("Executing Task 1");
    }
);
task1.Start();
Console.WriteLine("Doing Task2 while runing Task 1 ");
await task1;
Task task4 = ConsoleDelayAsync("Task 4",10);
Console.WriteLine("After Task 1 is Run");
Task task3 = ConsoleDelayAsync("Task 3",50);
await task3;
ConsoleDelay("Delay",100);
await task4;




static void ConsoleDelay(string task, int delay){
    Thread.Sleep(delay);
    Console.WriteLine(task);
}

static async Task ConsoleDelayAsync(string task, int delay){
    Task.Delay(delay);
    Console.WriteLine(task);
} 