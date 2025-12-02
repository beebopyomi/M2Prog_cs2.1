namespace _02_var;

class Quizvraag

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
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1987?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1988?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1989?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1990?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1991?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1992?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1983?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1994?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1995?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1996?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1997?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1998?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 1999?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 2000?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 2001?", "World Trade Center");
        Quizvraag quizvraag = new Quizvraag("wat is de grootste gebouw in  new york city 2002?", "World Trade Center");

    }

}
class Quiz
{
    internal Quizvraag[] vragen;
    internal Quizvragenantwoord[] ingevuldenantwoorden;
    quizvraag vraag = vragen[index];|`

    internal quiz()
    {
        vragen = new quizvraag[1]
        quiz quiz = new quiz(1);
        vragen{index} = vraag;
        quiz VroegVraagToeOpIndex(0, quizvraag);
    }

    internal QuizvragenantwoorD(Quizvraag hoi)
    {
        vraag = vraag;
        goed = false;
        
    }

    internal void VoegVraagToeOpIndex(int index, string vraag, string antwoord)
        {
            Quizvraag q = new Quizvraag(vraag, antwoord);
            vragen[index] = q;
            ingevuldenantwoorden[index] = new Quizvragenantwoord(q);
        }
}
class Quizvragenantwoord
{
    internal Quizvraag vraag;
    internal bool goed;
}

    
