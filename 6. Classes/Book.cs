namespace _6._Classes;

public class Book
{
    private string Title; // Название
    private string Author; // Автор
    private int Year; // Год создания книги
    private bool IsAvaliable; // Доступна ли к продаже

    public Book()
    {
        Title = "";
        Author = "";
        Year = 0;
        IsAvaliable = false;
    }
    
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
        IsAvaliable = true;
    }
}