string GetHtml(string url, string path)
{
    string html = String.Empty;
    if (!File.Exists(path))
    {
        html = new HttpClient().GetStringAsync(url).Result;
        File.WriteAllText(path, html);
    }
    else
    {
        html = File.ReadAllText(path);
    }
    return html;
}
string url = "https://google.com";
string localPath = "googlecom.html";
string html = GetHtml(url, localPath);
// System.Console.WriteLine(html);
int firstnumber = html.IndexOf("<title>");
int secondnumber = html.IndexOf("</title>");
string final = html.Substring (firstnumber+7, secondnumber-firstnumber-7);
Console.WriteLine(final);
