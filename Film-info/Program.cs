using Film_info;

  class Program
  {
    public static void Main(string[] args)
    {
      var film = new Film();
      
      Console.WriteLine("Tittel");
      film.Tittel = Console.ReadLine();
      Console.WriteLine("År");
      film.År= Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Beskrivelse");
      film.Beskrivelse = Console.ReadLine();
      Console.WriteLine("Forfatter");
      film.Forfatter = Console.ReadLine();
      Console.WriteLine("Skuespillere<UNK>");
      film.Skuespillere = Console.ReadLine();

      film.SkrivInfo();

    }
  }