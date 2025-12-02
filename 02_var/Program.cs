namespace _02_var;


class Program

{
    static void Main(string[] args)
    
        
    ;internal string vraag;
    internal string antwoord;

    internal Quizvraag(string vraag, string antwoord)
    {
        this.vraag = vraag;
        this.antwoord = antwoord;
    }
    
    private void Run()
    {
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1986?", "World Trade Center");
    }

}
class Quiz
{
    internal Quizvraag[] vragen;
    internal Quizvragenantwoord[] ingevuldenantwoorden;
}
class Quizvragenantwoord
{
    internal Quizvraag vraag;
    internal bool goed;
}