using Core;

Report report = new Report("Base", "This is a base report");
Console.WriteLine(report.Generate());

Report hltmReport = new HtmlReport("Html", "This is a html report");
Console.WriteLine(hltmReport.Generate());