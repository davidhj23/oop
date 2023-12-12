namespace Core;

public class Report
{
    private string Title { get; set; }

    private string Content { get; set; }

    public Report(string title, string content)
    {
        Title = title;
        Content = content;
    }

    protected string GetTitle()
    {
        return Title;
    }

    protected string GetContent()
    {
        return Content;
    }

    public virtual string Generate()
    {
        return $"{Title}\n{Content}";
    }
}
