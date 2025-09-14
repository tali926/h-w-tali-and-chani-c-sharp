using lesson2;
namespace lesson2
{
    public class program
    {
        static void Main(string[] args)
        {

            Book b1 = new Book(1, 2, 1, "people dying", "tali weiss", "adults");
            Book b2 = new Book(100, 200, 2, "people living", "tali weiss", "adults");
            Book b3 = new Book(1000, 2000, 3, "people wondring", "tali weiss", "adult");
            Book b4 = new Book(10000, 20000, 4, "happy life", "elinor levi", "kids");
            Book b5 = new Book(3, 4, 5, "me and i", "chani t", "kids");
            Book b6 = new Book(5, 6, 6, "she is", "mike jack", "kids");

            Shelf<Book> shelf1 = new Shelf<Book>();
            Shelf<Book> shelf2 = new Shelf<Book>();
            Shelf<Book> shelf3 = new Shelf<Book>();

            shelf1.Add(b1);
            shelf1.Add(b2);
            shelf2.Add(b3);
            shelf2.Add(b4);
            shelf3.Add(b5);
            shelf3.Add(b6);


            List<shelf<Book>> library = new List<Shelf<Book>>();

            library.Add(shelf1);
            library.Add(shelf2);
            library.Add(shelf3);

            //שאילתה 1
            var kidsBooks = from b in library
                            where b.description == "kids"
                            select shelf.b;
            //שאילתה 2
            var expensiveBooks = from eb in library
                                 where eb.price > 1500
                                 select shelf.eb;

            //שאילתה 3
            var talisBooks = from tb in library
                             where tb.author == "tali weiss"
                             select tb.title;

            //שאילתה 4

            var alotOfBooks = from aob in library
                              where aob.quantity > 95
                              select aob.shelf;

            //לא עשינו את שאילתה מספר 1 בגלל שלא היה כתוב שצריך משקל ספרים ולא ראינו דרך אחרת לעשות את זה, וכשגילינו על זה היינו בסוף הפרויקט תודה רבה


        }
    }

}