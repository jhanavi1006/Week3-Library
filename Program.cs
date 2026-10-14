using Library;

Book book = new Book();
// This information is for one book in our library
book.Title = "C# for beginners";
book.Author = "BillGates";
book.ISBN = "12345678";

book.DisplayInfo();

Book book1 = new Book();
book1.Title = "C# Methods and classes";
book1.Author = "Microspoft";
book1.ISBN = "55667778";

book1.DisplayInfo();