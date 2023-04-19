// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


static void Main(string[] args)
{
    FileInfo dato = new FileInfo(args[0]);

    int dato1 = 16;
    String dato2 = "25g";
    int resultado = dato1 + Convert.ToInt32(dato2);

    try
    {
        
        string fileInfo = Console.ReadLine();
        dato = new FileInfo(dato);
        


    }
    
    catch (Exception ex)
    {
        Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada", ex.Message);
    }

}