namespace Film_info;
public class Film
{
    public string Tittel { get; set; }
    public int År { get; set; }
    public string Beskrivelse { get; set; }
    public string Forfatter { get; set; }
    public string Skuespillere { get; set; }


    public void SkrivInfo()
    {
        Console.WriteLine("Film-informasjon");
        Console.WriteLine($"Tittel：{Tittel}");
        Console.WriteLine($"År:{År}");
        Console.WriteLine($"Beskrivelse：{Beskrivelse}");
        Console.WriteLine($"Forfatter：{Forfatter}");
        Console.WriteLine($"Skuespillere：{Skuespillere}");
    }
}