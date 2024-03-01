public Dictionary<string, int> CountUniqueUrlsPerTopLevelDomain(string[] urls)
{
    // get all urls that contains .com not contains 
    Dictionary<string, int> comUrlsDict = new Dictionary<string, int>();

    foreach (string url in urls)
    {
        string domainName = GetDomain(url);

        if (string.IsNullOrEmpty(domainName))
        {
            continue;
        }

        if (comUrlsDict.ContainsKey(domainName))
        {
            comUrlsDict[domainName] += 1;
        }
        else
        {
            comUrlsDict.Add(domainName, 1);
        }
    }

    return comUrlsDict;
}

private string GetDomain(string url)
{
    Uri uri = new Uri(url);
    string host = uri.Host;
    string[] parts = host.Split('.');

    if (parts.Length > 2)
    {
        return string.Join(".", parts[parts.Length - 2], parts[parts.Length - 1]);
    }

    return host;
}

/// input 1: ["https://example.com"] 
/// output 1: { { "example.com", 1 } }
/// 
/// input 2: ["https://example.com", "https://subdomain.example.com"] 
/// output 2: { { "example.com", 2 } }
/// 
/// input 3: ["https://test.example.com", "https://test.test.com"] 
/// output 3: { { "example.com", 1 }, { "test.com" , 1 } }
Dictionary<string, int> comUrlsDict = CountUniqueUrlsPerTopLevelDomain(new string[] { "https://test.example.com", "https://test.test.com" });
foreach (KeyValuePair<string, int> kvp in comUrlsDict)
{
    Console.WriteLine("URL = {0}, Count = {1}", kvp.Key, kvp.Value);
}
