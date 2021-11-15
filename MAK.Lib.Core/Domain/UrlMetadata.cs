namespace Domain;

public static class UrlMetadata
{
    public static int Id { get; set; } = 0;
    public static string Url { get; set; } = string.Empty;

    public static void SetUrlMetadata(int id = 0, string url = default)
    {
        Id = id;

        if(Id != 0)
        {
            Url = url + "/" + id;
        }
        else
        {
            Url = url;
        }
    }

    public static string GetUrl(int id = 0, string url = default)
    {
        Id = id;

        if(Id != 0)
        {
            Url = url + "/" + id;
        }
        else
        {
            Url = url;
        }

        return Url;
    }
}
