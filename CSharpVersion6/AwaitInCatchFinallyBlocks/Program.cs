static async Task addAsync()  
{  
    try  
    {  
        int[] arr = new int[5];  
        arr[10] = 12;  
    }  
    catch(Exception e) {  
        // Using await in catch block  
        await ExceptionOccured();  
    }  
}

static Task ExceptionOccured()
{
    Console.WriteLine("Array Exception Occurred");
    return Task.CompletedTask;
}