namespace WebApp.Buisness.Models;

public class CourseCardModel
{
    public string? Id { get; set; }
    public bool isBestSeller { get; set; }
    public string? image { get; set;}
    public string? bigImage { get; set; }
    public string? title { get; set;}
    public string? author { get; set;}
    public string? price { get; set;}
    public string? discountPrice { get; set;}
    public string? hours { get; set; }
    public string? likesInProcent { get; set; }
    public string? likesInNumbers { get; set;}
}
