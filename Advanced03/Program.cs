namespace Advanced03
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region part1
            //List<Book> books = new List<Book> { new Book("1", "Math", new string[] { "Aya", "Sara" }, DateTime.Now, 100), new Book("2", "Science", new string[] { "Madonna", "Louji" }, DateTime.Now, 200) };
            //BookFunctionsPointer bookFunctionsPointer = BookFunctions.Getauthors;
            //LibraryEngine.ProcessBooks(books, bookFunctionsPointer);

            //BookFunctionsPointer functionsPointer1 = delegate (Book b) { return b.ISBN; };
            //BookFunctionsPointer functionsPointer2 = (Book b) => $"{b.PublicationDate}";
            //LibraryEngine.ProcessBooks(books, functionsPointer1);
            //LibraryEngine.ProcessBooks(books, functionsPointer2); 
            #endregion
            #region part02
            //ListMethods<int> listMethods = new ListMethods<int>(4);
            //listMethods[0] = 1;
            //listMethods[1] = 2;
            //listMethods[2] = 3;
            //listMethods[3] = 4;

            //List<int> EvenNumbers =listMethods.FindAll(N=>N%2==0);
            //foreach (int i in EvenNumbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("..............");

            //int FirstEven = listMethods.Find(N => N % 2 == 0);
            //Console.WriteLine(FirstEven);
            //Console.WriteLine("..............");

            //int LastEven =listMethods.FindLast(N => N % 2 == 0);
            //Console.WriteLine(LastEven);
            //Console.WriteLine("..............");

            //int FirstEvenIndex = listMethods.FindIndex(N => N %2 == 0);
            //Console.WriteLine(FirstEvenIndex);
            //Console.WriteLine("..............");

            //int LastEvenIndex =listMethods.FindLastIndex(N => N %2==0);
            //Console.WriteLine(LastEvenIndex);
            //Console.WriteLine("..............");

            //listMethods.Remove(N => N % 2 == 0);
            //Console.WriteLine(listMethods[1]);
            //Console.WriteLine("..............");

            //listMethods.RemoveAll(N => N % 2 == 0);
            //foreach(int i in listMethods.values)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("..............");

            //Console.WriteLine(listMethods.Exists(N => N % 2 == 1));
            //Console.WriteLine("..............");

            //Console.WriteLine(listMethods.TrueForAll(N => N % 2 == 1));
            //Console.WriteLine("..............");

            //listMethods.Foreach(x => Console.WriteLine(x));
            #endregion
        }
    }
}
