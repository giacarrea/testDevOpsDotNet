class ExoMisc
{
    public static void ExoSwitch()
    {
        try
        {
            Console.WriteLine("Make a selection:");
            var selection = int.Parse(Console.ReadLine() ?? "0");
            string selectedStuff;

            switch(selection)
            {
                case 1: 
                    selectedStuff = "Café noir - 1,20€";
                    break;
                case 2: 
                    selectedStuff = "Chocolat chaud - 1,50€";
                    break;
                case 3:
                    selectedStuff = "Thé vers - 1,00€";
                    break;
                default:
                    throw new Exception("Wrong choice !");
            }

            Console.WriteLine("Selected stuff: " + selectedStuff);
        }
        catch(Exception ex)
        {
            Console.WriteLine("NOPE => " + ex.Message);
        }
    }

    public static void ExoPage106()
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