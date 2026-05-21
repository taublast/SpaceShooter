namespace SpaceShooter;

public static class AssetPaths
{
    private static Func<string, string> _resolver = static relativePath => relativePath;

    public static string Resolve(string relativePath)
    {
        return _resolver(relativePath);
    }

    public static void ConfigureWebBase(Uri baseUri)
    {
        _resolver = relativePath => new Uri(baseUri, relativePath).ToString();
    }
}