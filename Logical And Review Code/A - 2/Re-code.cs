public class ApplicationInfo
{
    public string Path { get; set; }
    public string Name { get; set; }
}

public ApplicationInfo GetInfo(string path, string name)
{
    // Check if either path or name is null or empty
    if (string.IsNullOrEmpty(path) || string.IsNullOrEmpty(name))
    {
        throw new ArgumentException("Path and name cannot be null or empty.");
    }

    var application = new ApplicationInfo
    {
        Path = path,
        Name = name
    };

    return application;
}
