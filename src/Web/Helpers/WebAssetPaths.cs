namespace SpaceShooter;

public static class WebAssetPaths
{
    private static Uri _baseUri = new("http://localhost/");

    public static void Configure(Uri baseUri)
    {
        _baseUri = baseUri;
    }

    public static string Build(string relativePath)
    {
        return new Uri(_baseUri, relativePath).ToString();
    }
}