namespace Table_de_multiplication;

class Program
{
    static void Main(string[] args)
    {
        int N;
        int i;
        
        int resultat;

        Console.WriteLine("saisir un nombre de votre choix");
        N=Convert.ToInt32(Console.ReadLine());
        for(i =1;i<=10;i++)
        {
            resultat=N*i;
            Console.WriteLine(N+"x"+i+"="+resultat);
        }
    }
}
