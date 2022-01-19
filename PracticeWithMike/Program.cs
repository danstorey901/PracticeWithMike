using System;

namespace PracticeWithMike
{
    class Program
    {
        static void Main(string[] args)
        {
            Books book1 = new Books("cat in the hat", "jon", 50, 5, true);
            Books book2 = new Books("his name", "jacob", 2, 1, true);
            Books book3 = new Books("is my name", "jingle", 2, 1, false);
            Books book4 = new Books("crime and punishment", "heimer", 500, 100, true);
            Books book5 = new Books("ordinary men", "schmidt", 350, 56, true);

            Books[] List = { book1, book2, book3, book4, book5};
            foreach (var Fred in List)
            {
                Fred.PrintUserInputData();
            }


        }
    }
}
