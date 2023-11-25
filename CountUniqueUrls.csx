public int CountUniqueUrls(string[] urls)
{
    UniqueUrlList UniqURLDictionary = new UniqueUrlList
    {
        urls
    };
    return UniqURLDictionary.Count;
}

public class UniqueUrlList : List<string>
{
    public void Add(string[] urls)
    {
        foreach (string url in urls)
        {
            IEnumerable<string> comUrls = urls.Where(url => url.Contains(".com")).Select(url => url.Split('.').First());
            foreach (string comUrl in comUrls)
            {
                if (!base.Contains(comUrl))
                {
                    base.Add(comUrl);
                }
            }
        }
    }
}


///     These 2 urls are the same:
///     input: ["https://example.com", "https://example.com/"]
///     output: 1
///
///     These 2 are not the same:
///     input: ["https://example.com", "http://example.com"]
///     output 2
///
///     These 2 are the same:
///     input: ["https://example.com?", "https://example.com"]
///     output: 1
///
///     These 2 are the same:
///     input: ["https://example.com?a=1&b=2", "https://example.com?b=2&a=1"]
///     output: 1
Console.WriteLine(CountUniqueUrls(new string[] { "https://example.com" }));