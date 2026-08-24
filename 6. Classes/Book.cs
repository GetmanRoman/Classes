namespace _6._Classes;

public class Book
{
    private string Title; // Название
    private string Author; // Автор
    private int Year; // Год создания книги
    private bool IsAvailable; // Доступна ли к продаже
    
    public Book()
    {
        Console.WriteLine("Параметры не заполнены");
        Title = "Не записано";
        Author = "Не записан";
        Year = 0; 
        IsAvailable = false;
    }
    
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
        IsAvailable = true;
    }

    public void BookInfo()
    {
        Console.WriteLine($"Название книги: {Title}");
        Console.WriteLine($"Автор: {Author}");
        Console.WriteLine($"Год написания книги: {Year}");
        Console.WriteLine($"Наличие в продаже: {(IsAvailable ? "есть" : "нет")}");
    }
}