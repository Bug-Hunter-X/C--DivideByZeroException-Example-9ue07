public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        int x = 5;
        int y = 0;
        try
        {
            int z = x / y; 
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero encountered.");
            Console.WriteLine(ex.Message);
            // Handle the exception appropriately, e.g., log the error, display a user-friendly message, or use a default value.
        }
    }
} 