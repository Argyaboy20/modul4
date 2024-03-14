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
        a.GetKodeBuah("Kurma");
        a.GetKodeBuah("Durian");
        a.GetKodeBuah("Anggur");
        a.GetKodeBuah("Melon");
        a.GetKodeBuah("Semangka");
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
            { "Kurma" ,"K00"},
            { "Durian" ,"L00"},
            { "Anggur" ,"M00"},
            { "Melon" ,"N00"},
            {"Semangka" ,"O00" },
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