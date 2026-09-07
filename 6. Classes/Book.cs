namespace ClassBook;

public class Book
{
    // Стоит писать с маленькой буквы
    public string title; // Название
    public string author; // Автор
    public int year; // Год создания книги
    public bool isAvailable; // Доступна ли к продаже
    
    // Создали 1 идеальный конструктор, который и записывает, и работает, если не записали
    public Book(
        string title = "Не записано",
        string author = "Не записан",
        int year = 0,
        bool isAvailable = false)
    {
        this.title = title;
        this.author = author;
        this.year = year;
        this.isAvailable = isAvailable;
    }
    
public void BookInfo()
    {
        Console.WriteLine($"Название книги: {title}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Год написания книги: {year}");
        Console.WriteLine($"Наличие в продаже: {(isAvailable ? "есть" : "нет")}");
    }
}

// Класс расширитель
public static class BookHelper 
{ 
    public static void Print(this Book book) // Объект основного класса
    { 
        Console.WriteLine($"Книга: {book.title}, Автор: {book.author}"); 
    } 
    
    public static void CreateDefault(this Book book) // Объект основного класса
    {
        string title = "Не записано";
        string author = "Не записан";
        int year = 0;
        bool isAvailable = false;
    } 
}