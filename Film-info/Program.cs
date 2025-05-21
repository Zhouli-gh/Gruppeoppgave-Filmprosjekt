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
  

/*
 * Lag en applikasjon der man kan skrive inn forskjellige detaljer,
   制作一个应用程序，让用户可以输入各种详细信息，

   og etter man har skrevet inn alt få printet tilbake det som ble skrevet inn som et “produkt”,
   当用户输入完所有内容后，程序会将这些作为一个“作品”打印出来，

   enten en film eller en bok, dere velger.
   可以是电影，也可以是书，由你们决定。

   Man skal bli spurt av konsollen om Tittel,
   控制台会询问用户标题，

   så år det kom ut,
   然后是出版或上映的年份，

   litt beskrivelse av hva filmen eller boken handler om,
   接着是关于电影或书籍内容的简要描述，

   forfatter/regissør,
   作者或导演，

   hvilke skuespillere som var med.
   有哪些演员参与演出。

   Når alle spørsmål er besvart skal man kunne få se boken eller filmen man skrev inn som et produkt, med alle egenskaper listet opp.
   当所有问题都回答完毕后，用户将看到完整的作品信息，所有属性都会被列出来。

   BONUS:
   加分项：

   Legg til mulighet for å skrive inn flere bøker eller filmer, her trenger man å ta i bruk lister 😉
   添加功能让用户可以输入多本书或多部电影，这里需要使用列表（List）结构。
 */