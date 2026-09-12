using ClassBook;

// Проверка на норм работу
Book WarAndPeace = new Book("Война и мир", "Толстой", 1869, true); 
WarAndPeace.BookInfo();

Console.WriteLine();

// Проверка пустого конструктора
Book emptyBook = new Book(); 
emptyBook.BookInfo();

Console.ReadKey();