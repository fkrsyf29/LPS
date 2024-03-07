public class ApplicationInfo
{
    public string Path { get; set; }
    public string Name { get; set; }
}

public ApplicationInfo GetInfo(string path, string name)
{
    var application = new ApplicationInfo
    {
        Path = path,
        Name = name
    };
    return application;
}
