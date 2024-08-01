using PatikaPratikConsturactor;

class Program
{
    static void Main(string[] args)
    {
        //Default Constructor ile bilgi girişi ve konsola yazdırma
        Baby baby1 = new Baby();
        baby1.Name = "Fahri";
        baby1.Surname = "Korutürk";
        baby1.Display();
        //Parametre alan constructor ile bilgi girişi ve konsola yazdırma
        Baby baby2 = new Baby("Sait Faik", "Abasıyanık");
        baby2.Display();


    }
}