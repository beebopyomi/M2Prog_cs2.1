namespace _03;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.run();
        }

        class QuizVraag
    {
        internal string vraag;
        internal string antwoord;
        
    
        internal QuizVraag(string vraag, string antwoord)
        {
            this.vraag = vraag;
            this.antwoord = antwoord;
        }
    }



    internal void run()
    {
        QuizVraag quizVraag = new QuizVraag("welke jaar vielen de twin towers?", "2001");
        Quiz quiz = new Quiz(10);
    }
    class Quiz
    {
    internal QuizVraag[] vragen;
    internal QuizVraagAntwoord[] Ingevuldeantwoorden;
    }

    internal Quiz()
    {
        vragen = new QuizVraag[3];
    }
    internal QuizVraagenAntwoord(WuizVraag vraag)
    {
        vraag = vraag;
        goed = false;
    }
    
    
}
