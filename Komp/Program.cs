
Console.WriteLine("Hej vad heter du? ,skriv ditt namn här:");

// 

string n = name();
int s = 10;

Console.WriteLine($"ok vad bra Hej, {n}");

// få ut nament ur metoden!!!
// en output värde

Console.ReadLine();



static string name()
{

    string name = Console.ReadLine();
    int shhh;
    bool hsgdhs =  int.TryParse(name,out shhh);
    if (shhh == 10) {
        Console.WriteLine("fel");
    }
   return name;

}