namespace Core;

public class HtmlReport : Report
{
    public HtmlReport(string title, string content) : base(title, content)
    {
    }

    public override string Generate()
    {
        return $@"<!DOCTYPE html>
                <html lang=""en"">
                <head>
                    <meta charset=""UTF-8"">
                    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
                    <title>Document</title>
                </head>
                <body>
                    <header>
                        <h1>{GetTitle()}</h1>
                    </header>
                    <main>
                        <p>{GetContent()}</p>
                    </main>
                </body>
                </html>";
    }
}
