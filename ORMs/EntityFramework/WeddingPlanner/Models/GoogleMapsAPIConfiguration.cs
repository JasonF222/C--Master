namespace WeddingPlanner.Models;

public class GoogleMapsAPIConfiguration
{
    public GoogleMapsAPIConfiguration(string apiKey)
    {
        APIKey = apiKey;
    }

    public string APIKey { get; set; }
}

