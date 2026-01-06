class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Entre un premier nombre:");
            int n1, n2;
            //var n1 = int.Parse(Console.ReadLine() ?? "lmao");
            if(!int.TryParse(Console.ReadLine(), out n1))
                throw new Exception("Wrong format, retard !");
            Console.WriteLine($"{n1} entré; entrez un 2eme nombre:");
            //var n2 = int.Parse(Console.ReadLine() ?? "lmao");
            if(!int.TryParse(Console.ReadLine(), out n2))
                throw new Exception("Wrong format, retard !");
            Console.WriteLine($"Nombres entrés: {n1} + {n2} = {n1 + n2}");            
        }
        catch(Exception ex)
        {
            Console.WriteLine($"FUCKED SHIT UP => {ex.Message}");
        }


        
    }
}