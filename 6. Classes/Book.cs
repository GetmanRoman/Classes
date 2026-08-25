namespace _6._Classes;

public class Book
{
    // Стоит писать с маленькой буквы
    private string title; // Название
    private string author; // Автор
    private int year; // Год создания книги
    private bool isAvailable; // Доступна ли к продаже
    
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
    
    // Оказывается устаревшее
    // public Book(string Title, string Author, int Year)
    // {
    //     this.Title = Title;
    //     this.Author = Author;
    //     this.Year = Year;
    //     IsAvailable = true;
    // }

    public void BookInfo()
    {
        Console.WriteLine($"Название книги: {title}");
        Console.WriteLine($"Автор: {author}");
        Console.WriteLine($"Год написания книги: {year}");
        Console.WriteLine($"Наличие в продаже: {(isAvailable ? "есть" : "нет")}");
    }
}