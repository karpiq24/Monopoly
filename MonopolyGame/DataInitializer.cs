using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public static class DataInitializer
    {
        public static void initializeFields()
        {
            MonopolyGame.allFields.Add(new StartField(
                "START",// Nazwa
                "start")); // Slug

            MonopolyGame.allFields.Add(new PropertyField(
                "TĘŻNIE CIECHOCINEK", // Nazwa
                "teznie-ciechocinek", // Slug
                PropertyGroup.Brown, // Grupa
                600, // Podstawowy koszt
                300, // Hipoteka
                new int[] { 20, 100, 300, 900, 1600, 2500 }, // Tablica zarobków
                500, // Cena domu
                500)); // Cena hotelu

            MonopolyGame.allFields.Add(new CardField(
                "KASA SPOŁECZNA", // Nazwa
                "kasa1", // Slug
                CardType.CommunityCehst)); //Typ karty

            MonopolyGame.allFields.Add(new PropertyField(
                "KOPALNIA SOLI WIELICZKA", // Nazwa
                "kopalnia-wieliczka", // Slug
                PropertyGroup.Brown, // Grupa
                600, // Podstawowy koszt
                300, // Hipoteka
                new int[] { 40, 200, 600, 1800, 3200, 4500 }, // Tablica zarobków
                500, // Cena domu
                500)); // Cena hotelu

            MonopolyGame.allFields.Add(new TaxField(
                "PODATEK DOCHODOWY", // Nazwa
                "podatek1", // Slug
                2000)); //Wartosć podatku

            MonopolyGame.allFields.Add(new BasePropertyField(
                "LOTNISKO IM LECHA WAŁĘSY GDAŃSK", // Nazwa
                "lotnisko-gdansk", // Slug
                PropertyGroup.Airport, // Grupa
                2000, // Podstawowy koszt
                1000, // Hipoteka
                new int[] { 250, 500, 1000, 2000 })); // Tablica zarobków

            MonopolyGame.allFields.Add(new PropertyField(
                "MUZEUM ZABAWKARSTWA KIELCE", // Nazwa
                "muzeum-kielce", // Slug
                PropertyGroup.LightBlue, // Grupa
                1000, // Podstawowy koszt
                500, // Hipoteka
                new int[] { 60, 300, 900, 2700, 4000, 5500 }, // Tablica zarobków
                500, // Cena domu
                500)); // Cena hotelu

            MonopolyGame.allFields.Add(new CardField(
                "SZANSA", // Nazwa
                "szansa1", // Slug
                CardType.Chance)); //Typ karty

            MonopolyGame.allFields.Add(new PropertyField(
                "PLANETARIUM TORUŃ", // Nazwa
                "planetarium-torun", // Slug
                PropertyGroup.LightBlue, // Grupa
                1000, // Podstawowy koszt
                500, // Hipoteka
                new int[] { 60, 300, 900, 2700, 4000, 5500 }, // Tablica zarobków
                500, // Cena domu
                500)); // Cena hotelu

            MonopolyGame.allFields.Add(new PropertyField(
                "PARK MYŚLĘCINEK BYDGOSZCZ", // Nazwa
                "park-bydgoszcz", // Slug
                PropertyGroup.LightBlue, // Grupa
                1200, // Podstawowy koszt
                600, // Hipoteka
                new int[] { 80, 400, 1000, 3000, 4500, 6000 }, // Tablica zarobków
                500, // Cena domu
                500)); // Cena hotelu

            MonopolyGame.allFields.Add(new Field
                ("WIĘZIENIE", // Nazwa
                "wiezienie")); // Slug

            MonopolyGame.allFields.Add(new PropertyField(
                "TOR REGATOWY MALTA POZNAŃ", // Nazwa
                "tor-poznan", // Slug
                PropertyGroup.Pink, // Grupa
                1400, // Podstawowy koszt
                700, // Hipoteka
                new int[] { 100, 500, 1500, 4500, 6250, 7500 }, // Tablica zarobków
                1000, // Cena domu
                1000)); // Cena hotelu

            MonopolyGame.allFields.Add(new BasePropertyField(
                "TVN", // Nazwa
                "tvn", // Slug
                PropertyGroup.Media, // Grupa
                1500, // Podstawowy koszt
                750, // Hipoteka
                new int[] { 4, 10 })); // Tablica zarobków

            MonopolyGame.allFields.Add(new PropertyField(
                "WIELKA KROKIEW ZAKOPANE", // Nazwa
                "wielka-zakopane", // Slug
                PropertyGroup.Pink, // Grupa
                1400, // Podstawowy koszt
                700, // Hipoteka
                new int[] { 100, 500, 1500, 4500, 6250, 7500 }, // Tablica zarobków
                1000, // Cena domu
                1000)); // Cena hotelu

            MonopolyGame.allFields.Add(new PropertyField(
                "STADION ŚLĄSKI CHORZÓW", // Nazwa
                "stadion-chorzow", // Slug
                PropertyGroup.Pink, // Grupa
                1600, // Podstawowy koszt
                800, // Hipoteka
                new int[] { 120, 600, 1800, 5000, 7000, 9000 }, // Tablica zarobków
                1000, // Cena domu
                1000)); // Cena hotelu

            MonopolyGame.allFields.Add(new BasePropertyField(
                "LOTNISKO SADKÓW RADOM", // Nazwa
                "lotnisko-radom", // Slug
                PropertyGroup.Airport, // Grupa
                2000, // Podstawowy koszt
                1000, // Hipoteka
                new int[] { 250, 500, 1000, 2000 })); // Tablica zarobków

            MonopolyGame.allFields.Add(new PropertyField(
                "PANORAMA RACŁAWICKA WROCŁAW", // Nazwa
                "panorama-wroclaw", // Slug
                PropertyGroup.Orange, // Grupa
                1800, // Podstawowy koszt
                900, // Hipoteka
                new int[] { 140, 700, 2000, 5500, 7500, 9500 }, // Tablica zarobków
                1000, // Cena domu
                1000)); // Cena hotelu

            MonopolyGame.allFields.Add(new CardField(
                "KASA SPOŁECZNA", // Nazwa
                "kasa2", // Slug
                CardType.CommunityCehst)); //Typ karty

            MonopolyGame.allFields.Add(new PropertyField(
                "NARODOWA ORKIESTRA SYMFONICZNA PR KATOWICE", // Nazwa
                "narodowa-katowice", // Slug
                PropertyGroup.Orange, // Grupa
                1800, // Podstawowy koszt
                900, // Hipoteka
                new int[] { 140, 700, 2000, 5500, 7500, 9500 }, // Tablica zarobków
                1000, // Cena domu
                1000)); // Cena hotelu

            MonopolyGame.allFields.Add(new PropertyField(
                "TEATR WIELKI OPERA NARODOWA WARSZAWA", // Nazwa
                "teatr-warszawa", // Slug
                PropertyGroup.Orange, // Grupa
                2000, // Podstawowy koszt
                1000, // Hipoteka
                new int[] { 160, 800, 2200, 6000, 8000, 1000 }, // Tablica zarobków
                1000, // Cena domu
                1000)); // Cena hotelu

            MonopolyGame.allFields.Add(new Field
                ("PARKING", // Nazwa
                "parking")); // Slug


            MonopolyGame.allFields.Add(new PropertyField(
                "NOWA HUTA", // Nazwa
                "nowa-huta", // Slug
                PropertyGroup.Red, // Grupa
                2200, // Podstawowy koszt
                1100, // Hipoteka
                new int[] { 180, 900, 2500, 7000, 8750, 10500 }, // Tablica zarobków
                1500, // Cena domu
                1500)); // Cena hotelu

            MonopolyGame.allFields.Add(new CardField(
                "SZANSA", // Nazwa
                "szansa2", // Slug
                CardType.Chance)); //Typ karty

            MonopolyGame.allFields.Add(new PropertyField(
                "STOCZNIA GDAŃSKA", // Nazwa
                "stocznia-gdansk", // Slug
                PropertyGroup.Red, // Grupa
                2200, // Podstawowy koszt
                1100, // Hipoteka
                new int[] { 180, 900, 2500, 7000, 8750, 10500 }, // Tablica zarobków
                1500, // Cena domu
                1500)); // Cena hotelu

            MonopolyGame.allFields.Add(new PropertyField(
                "PAŁAC KULTURY I NAUKI WARSZAWA", // Nazwa
                "palac-warszawa", // Slug
                PropertyGroup.Red, // Grupa
                2400, // Podstawowy koszt
                1200, // Hipoteka
                new int[] { 200, 1000, 3000, 7500, 9250, 11000 }, // Tablica zarobków
                1500, // Cena domu
                1500)); // Cena hotelu

            MonopolyGame.allFields.Add(new BasePropertyField(
                "LOTNISKO BALICE IM. JANA PAWŁA II KRAKÓW", // Nazwa
                "lotnisko-krakow", // Slug
                PropertyGroup.Airport, // Grupa
                2000, // Podstawowy koszt
                1000, // Hipoteka
                new int[] { 250, 500, 1000, 2000 })); // Tablica zarobków

            MonopolyGame.allFields.Add(new PropertyField(
                "MONCIAK - MOLO SOPOT", // Nazwa
                "monciak-sopot", // Slug
                PropertyGroup.Yellow, // Grupa
                2600, // Podstawowy koszt
                1300, // Hipoteka
                new int[] { 220, 1100, 3300, 8000, 9750, 11500 }, // Tablica zarobków
                1500, // Cena domu
                1500)); // Cena hotelu

            MonopolyGame.allFields.Add(new PropertyField(
                "KRUPÓWKI ZAKOPANE", // Nazwa
                "krupowki-zakopane", // Slug
                PropertyGroup.Yellow, // Grupa
                2600, // Podstawowy koszt
                1300, // Hipoteka
                new int[] { 220, 1100, 3300, 8000, 9750, 11500 }, // Tablica zarobków
                1500, // Cena domu
                1500)); // Cena hotelu

            MonopolyGame.allFields.Add(new BasePropertyField(
                "GAZETA WYBORCZA", // Nazwa
                "gazeta-wyborcza", // Slug
                PropertyGroup.Media, // Grupa
                1500, // Podstawowy koszt
                750, // Hipoteka
                new int[] { 4, 10 })); // Tablica zarobków

            MonopolyGame.allFields.Add(new PropertyField(
                "UL. PIOTRKOWSKA ŁÓDŹ", // Nazwa
                "ul-lodz", // Slug
                PropertyGroup.Yellow, // Grupa
                2800, // Podstawowy koszt
                1400, // Hipoteka
                new int[] { 240, 1200, 3600, 8500, 10250, 12000 }, // Tablica zarobków
                1500, // Cena domu
                1500)); // Cena hotelu

            MonopolyGame.allFields.Add(new JailedField(
                "IDŹ DO WIĘZIENIA", // Nazwa
                "idz-wiezienie")); // Slug

            MonopolyGame.allFields.Add(new PropertyField(
                "SŁOWIŃSKI PARK NARODOWY", // Nazwa
                "slowinski-park", // Slug
                PropertyGroup.Green, // Grupa
                3000, // Podstawowy koszt
                1500, // Hipoteka
                new int[] { 260, 1300, 3900, 9000, 11000, 12750 }, // Tablica zarobków
                2000, // Cena domu
                2000)); // Cena hotelu

            MonopolyGame.allFields.Add(new PropertyField(
                "BIAŁOWIESKI PARK NARODOWY", // Nazwa
                "bialowieski-park", // Slug
                PropertyGroup.Green, // Grupa
                3000, // Podstawowy koszt
                1500, // Hipoteka
                new int[] { 260, 1300, 3900, 9000, 11000, 12750 }, // Tablica zarobków
                2000, // Cena domu
                2000)); // Cena hotelu

            MonopolyGame.allFields.Add(new CardField(
                "KASA SPOŁECZNA", // Nazwa
                "kasa3", // Slug
                CardType.CommunityCehst)); //Typ karty

            MonopolyGame.allFields.Add(new PropertyField(
                "TATRZAŃSKI PARK NARODOWY", // Nazwa
                "tatrzanski-park", // Slug
                PropertyGroup.Green, // Grupa
                3200, // Podstawowy koszt
                1600, // Hipoteka
                new int[] { 280, 1500, 4500, 10000, 12000, 14000 }, // Tablica zarobków
                2000, // Cena domu
                2000)); // Cena hotelu

            MonopolyGame.allFields.Add(new BasePropertyField(
                "LOTNISKO IM. FRYDERYKA CHOPINA WARSZAWA", // Nazwa
                "lotnisko-warszawa", // Slug
                PropertyGroup.Airport, // Grupa
                2000, // Podstawowy koszt
                1000, // Hipoteka
                new int[] { 250, 500, 1000, 2000 })); // Tablica zarobków

            MonopolyGame.allFields.Add(new CardField(
                "SZANSA", // Nazwa
                "szansa3", // Slug
                CardType.Chance)); //Typ karty

            MonopolyGame.allFields.Add(new PropertyField(
                "RYNEK GŁÓWNY KRAKÓW", // Nazwa
                "rynek-krakow", // Slug
                PropertyGroup.Blue, // Grupa
                3500, // Podstawowy koszt
                1750, // Hipoteka
                new int[] { 350, 1750, 5000, 11000, 13000, 15000 }, // Tablica zarobków
                2000, // Cena domu
                2000)); // Cena hotelu

            MonopolyGame.allFields.Add(new TaxField(
                "DOMIAR PODATKOWY", // Nazwa
                "podatek2", // Slug
                1000)); //Wartosć podatku

            MonopolyGame.allFields.Add(new PropertyField(
                "TRAKT KRÓLEWSKI WARSZAWA", // Nazwa
                "trakt-warszawa", // Slug
                PropertyGroup.Blue, // Grupa
                4000, // Podstawowy koszt
                2000, // Hipoteka
                new int[] { 500, 2000, 6000, 14000, 17000, 20000 }, // Tablica zarobków
                2000, // Cena domu
                2000)); // Cena hotelu
        }

        public static void initializePlayers(List<string> _players)
        {
            foreach (var item in _players)
            {
                MonopolyGame.players.Add(new Player(item));
            }                
        }

        public static void initializeChanceCards()
        {
            Card c = new Card(CardType.Chance, "ZATRUDNIASZ SŁAWNEGO DEKORATORA WNĘTRZ. ZA KAŻDY APARTAMENT PŁACISZ 250. ZA KAŻDY HOTEL PŁACISZ 1000");
            c.onDrawn += () =>
            {
                int toPay = 0;
                foreach (var item in MonopolyGame.currentPlayer.getProperties())
                {
                    if (item.getHousesCount() == 5)
                        toPay += 1000;
                    else
                        toPay += item.getHousesCount() * 250;
                }
                MonopolyGame.currentPlayer.pay(toPay);
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "WZRASTA PODATEK OD NIERUCHOMOŚCI. PŁACISZ 400 ZA KAŻDY APARTAMENT I 1150 ZA KAŻDY HOTEL.");
            c.onDrawn += () =>
            {
                int toPay = 0;
                foreach (var item in MonopolyGame.currentPlayer.getProperties())
                {
                    if (item.getHousesCount() == 5)
                        toPay += 1150;
                    else
                        toPay += item.getHousesCount() * 400;
                }
                MonopolyGame.currentPlayer.pay(toPay);
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "NIEZAPŁACONE PODATKI - ŚCIGA CIĘ URZĄD SKARBOWY. IDZIESZ DO WIĘZIENIA. IDZIESZ PROSTO DO WIĘZIENIA, NIE PRZECHODZISDZ PRZEZ START, NIE POBERASZ 2000 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.jail(settings.jailTime);
                MonopolyGame.currentPlayer.skipTo(MonopolyGame.allFields.Find(x => x.getSlug() == "wiezienie"));
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "NA AUKCJI INTERNETOWEJ SPRZEDAJESZ SWÓJ BILET NA ZAWODY WIELKIEKJ KROKWI. POBIERZ 500 ZŁOTYCH.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(500);
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "WYGRAŁEŚ W KUMULACJI LOTTO!. POBIERZ 1000 ZŁOTYCH.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(1000);
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "ŁAPIESZ LOT Z RADOMIA. JEŚLI PRZEJDZIESZ PRZEZ START, POBIERZ 2000 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.walkTo(MonopolyGame.allFields.Find(x => x.getSlug() == "lotnisko-radom"));
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "IDZIESZ NA TOR REGATOWY MALTA. JEŚLI PRZEJDZIESZ PRZEZ START, POBIERZ 2000 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.walkTo(MonopolyGame.allFields.Find(x => x.getSlug() == "tor-poznan"));
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "SPRZEDDAJESZ AKCJE. POBIERZ 1500 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(1500);
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "WRACASZ NA START.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.skipTo(MonopolyGame.allFields.Find(x => x.getSlug() == "start"));
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "ZAPŁAĆ CZESNE W PRYWATNEJ SZKOLE - 1500 ZŁOTYCYH");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.pay(1500);
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "ZWIEDZANIE MIASTA! IDZIESZ DO PAŁACU KULTURY I NAUKI. JEŚLI PRZEJDZIESZ PRZEZ START, POBIERZ 2000 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.walkTo(MonopolyGame.allFields.Find(x => x.getSlug() == "palac-warszawa"));
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "MANDAT ZA KORZYSTANIE Z TELEFONU KOMÓRKOWEGO PODCZAS JAZDY SAMOCHODEM. PŁACISZ 150 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.pay(150);
            };
            MonopolyGame.chanceCards.Add(c);

            c = new Card(CardType.Chance, "INWESTUJESZ W ZABYTKI. PRZEJDŹ NA TRAKT KRÓLEWSKI.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.walkTo(MonopolyGame.allFields.Find(x => x.getSlug() == "trakt-warszawa"));
            };
            MonopolyGame.chanceCards.Add(c);
        }

        public static void initializeCommunityChestCards()
        {
            Card c = new Card(CardType.CommunityCehst, "TWOI PRZYJACIELE ZATRUDNIAJĄ SIĘ NA TYDZIEŃ DO POMOCY PRZY OGÓLNOPOLSKIM FESTIWALU FILMOWYM. POBIERZ PO 100 ZŁ OD KAŻDEGO GRACZA.");
            c.onDrawn += () =>
            {
                foreach (var p in MonopolyGame.players)
                {
                    p.pay(100);
                    MonopolyGame.currentPlayer.earn(100);
                }
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "BUDUJESZ BASEN NA DACHU SWOJEGOO APARTAMENTU. ZAPŁAĆ 200.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.pay(200);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "WYJDŹ BEZPŁATNIE Z WIĘZIENIA. Tę kartę możesz zatrzymać do późniejszego wykorzystania.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.drawnNoJailCard();
            };
            MonopolyGame.communityChestCards.Add(c);
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "OTRZYMUJESZ W SPADKU 1000 ZŁ");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(1000);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "WRACASZ NA START.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.skipTo(MonopolyGame.allFields.Find(x => x.getSlug() == "start"));
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "POBIERAZ 1000 ZŁ ZA WYNAJEM PRYWATNEGO SAMOLOTU.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(1000);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "WYGRYWASZ W REALITY SHOW. POBIERZ 100 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(100);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "DOSTAJESZ ODSZKODOWANIE ZA STŁUCZKĘ ZAMOCHODOWĄ. POBIERZ 250 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(250);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "SPONSORUJESZ PRZEDSTAWIENIE \"DON GIOVANNI\" W OPERZE NARODOWEJ. PŁACISZ 500 ZŁ");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.pay(500);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "SPRZEDAJSZ SWOJĄ FIRMĘ KOMPUTEROWĄ. POBIERZ 2000 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(2000);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "JEDZIESZ DO SANATORIUM W CIECHOCINKU.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.skipTo(MonopolyGame.allFields.Find(x => x.getSlug() == "teznie-ciechocinek"));
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "WYNAJMUJESZ STOCZNIĘ GDAŃSKĄ NA PRYWATNE PRZYJĘCIE. PŁACISZ 1000 ZŁ");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.pay(1000);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "ZWROT PODATKU. POBIERZ 500 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(500);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "ORGANIZUJESZ WSPANIAŁY KONCERT NARODOWEJ ORKIESTRY SYMFONICZNEJ. POBIERZ 200 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.earn(200);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "PŁACISZ 500 ZŁ ZA DWUDNIOWY POBYT W LUKSUSOWYM SPA.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.pay(500);
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "ZOSTAJESZ ARESZTOWANY ZA \"KREATYWNA KSIĘGOWOŚĆ\". IDZIESZ DO WIĘZIENIA. IDZIESZ PROSTO DO WIĘZIENIA, NIE PRZECHODZISDZ PRZEZ START, NIE POBERASZ 2000 ZŁ.");
            c.onDrawn += () =>
            {
                MonopolyGame.currentPlayer.jail(settings.jailTime);
                MonopolyGame.currentPlayer.skipTo(MonopolyGame.allFields.Find(x => x.getSlug() == "wiezienie"));
            };
            MonopolyGame.communityChestCards.Add(c);

            c = new Card(CardType.CommunityCehst, "PŁACISZ 100 ZŁ KARY ALBO BIERZESZ KARTĘ \"SZANSA\"");
            c.onDrawn += () =>
            {
                Console.WriteLine("Kara - k\nSzansa - s");
                while (true)
                {
                    string choice = Console.ReadLine();
                    if (choice == "k")
                    {
                        MonopolyGame.currentPlayer.pay(100);
                        break;
                    }
                    else if (choice == "s")
                    {
                        var random = new Random();
                        Card x = MonopolyGame.chanceCards[random.Next(0, MonopolyGame.chanceCards.Count)];
                        x.onDrawn();
                        break;
                    }
                }
            };
            MonopolyGame.communityChestCards.Add(c);
        }
    }
}
