namespace prjBible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BibleBooks books = new BibleBooks("John", 3, "16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
            BibleBooks books2 = new BibleBooks("Psalm", 28, "7", "The Lord is my strength and my shield; my heart trusted in him and, I am helped.");

            Console.WriteLine(books[0]);
            Console.WriteLine(books[1]);
            Console.WriteLine(books[2]);
            Console.WriteLine(books[3]);


            Console.WriteLine($"{books["book"]} {books["chapter"]} : {books["versenumber"]} \n{books["verse"]}");

            Console.WriteLine(books2[0]);
            Console.WriteLine(books2[1]);
            Console.WriteLine(books2[2]);
            Console.WriteLine(books2[3]);


            Console.WriteLine($"{books2["book"]} {books2["chapter"]} : {books2["versenumber"]} \n{books2["verse"]}");
        }
        }
}
