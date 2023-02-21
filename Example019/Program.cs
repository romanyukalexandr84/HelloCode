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
string url = "https://m.vk.com";
string localPath = "vkcom.html";
string html = GetHtml(url, localPath);
System.Console.WriteLine(html);
System.Console.WriteLine(s.IndexOf("cjsdf"));
