using System.Text;
using System.Numerics;

public class ExoBonk
{
    public static void WholeDiv(int dividend, int divisor)
    {
        try
        {
            Console.WriteLine($"-- Dividing {dividend} by {divisor}:");

            if (divisor == 0)
                throw new DivideByZeroException("Divisor cannot be zero.");

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Remainder: {remainder}");
        }           
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
      

    public static void BBANChecker(string bban)
    {
        try
        {
            Console.WriteLine($"-- Checking BBAN: {bban}"); 

            if (string.IsNullOrWhiteSpace(bban))
                throw new ArgumentException("BBAN cannot be null or empty.");

            if (bban.Length != 12)
                throw new ArgumentException("BBAN must be exactly 12 characters long.");

            string first10 = bban.Substring(0, 10);
            string last2 = bban.Substring(10, 2);

            if (!long.TryParse(first10, out long first10Number))
                throw new ArgumentException("The first 10 characters must be numeric.");

            if (!int.TryParse(last2, out int last2Number))
                throw new ArgumentException("The last 2 characters must be numeric.");

            var remainderCheck = first10Number % 97 == 0? 97 : (int)(first10Number % 97);
                
            if (remainderCheck != last2Number)
                throw new ArgumentException("BBAN check digits are invalid.");

            Console.WriteLine("BBAN is valid.");

        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public static void BBANtoIBAN(string bban)
    {
        try
        {
            Console.WriteLine($"-- Converting BBAN to IBAN: {bban}"); 

            if (string.IsNullOrWhiteSpace(bban))
                throw new ArgumentException("BBAN cannot be null or empty.");

            if (bban.Length != 12)
                throw new ArgumentException("BBAN must be exactly 12 characters long.");

            string first10 = bban.Substring(0, 10);
            string last2 = bban.Substring(10, 2);

            if (!long.TryParse(first10, out long first10Number))
                throw new ArgumentException("The first 10 characters must be numeric.");

            if (!int.TryParse(last2, out int last2Number))
                throw new ArgumentException("The last 2 characters must be numeric.");

            var remainderCheck = first10Number % 97 == 0? 97 : (int)(first10Number % 97);
                
            if (remainderCheck != last2Number)
                throw new ArgumentException("BBAN check digits are invalid.");

            // Assuming country code "XX" and calculating IBAN check digits
            string countryCode = "XX";
            string bbanForIban = first10 + last2 + countryCode + "00";

            // Convert letters to numbers: A=10, B=11, ..., Z=35
            StringBuilder numericBban = new StringBuilder();
            foreach (char c in bbanForIban)
            {
                if (char.IsLetter(c))
                    numericBban.Append((c - 'A' + 10).ToString());
                else
                    numericBban.Append(c);
            }

            // Calculate the remainder
            BigInteger bigIntBban = BigInteger.Parse(numericBban.ToString());
            int mod97 = (int)(bigIntBban % 97);
            int checkDigits = 98 - mod97;

            string iban = countryCode + checkDigits.ToString("D2") + bban;
            Console.WriteLine($"Converted IBAN: {iban}");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    } 
}
