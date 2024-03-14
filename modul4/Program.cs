using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        KodeBuah a = new KodeBuah();
        a.GetKodeBuah("Apel");
        a.GetKodeBuah("Aprikot");
        a.GetKodeBuah("Alpukat");
        a.GetKodeBuah("Pisang");
        a.GetKodeBuah("Paprika");
        a.GetKodeBuah("Blackberry");
        a.GetKodeBuah("Ceri");
        a.GetKodeBuah("Kelapa");
        a.GetKodeBuah("Jagung");
    }
    class KodeBuah
    {
        Dictionary<String, String> kodeBuah = new Dictionary<string, string>()
        {
            { "Apel","A00" },
            { "Aprikot", "B00" },
            {"Alpukat" ,"C00"},
            {"Pisang" ,"D00"},
            { "Paprika" ,"E00"},
            { "Blackberry" ,"F00"},
            { "Ceri" ,"H00"},
            { "Kelapa" ,"I00"},
            { "Jagung" ,"J00"},
        };
        public void GetKodeBuah(string KodeBuah)
        {
            if (kodeBuah.ContainsKey(KodeBuah))
            {
                Console.WriteLine(KodeBuah + ":" + kodeBuah[KodeBuah]);
            }
            else
            {
                Console.WriteLine("Buah tidak ditemukan");



            }
        }
           
        
        
        
    
    
    
    
    
    
    }

}