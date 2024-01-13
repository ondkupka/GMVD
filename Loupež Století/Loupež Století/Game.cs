using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Loupež_Století
{
    internal class Game
    {
        public int numberOfEvidence;
        public List<Locations> Location { get; set; } //list na lokace
        public List<Evidence> Evidence { get; set; }   //list na důkazy 
        public List<Npcs> Npcs { get; set; } //list na postavy krom hráčova charakteru
        public Game()
        {
            Location = new List<Locations>
    {
        new Locations("Kancelář", "Kancelář, kde začíná dobrodružství."),
        new Locations("Opuštěný dům", "Starý opuštěný dům, kde se máte setkat s klientem."),
        new Locations("Místo činu", "Místo, kde došlo ke krádeži/vraždě."),
        new Locations("Policejní stanice", "Místo, kde můžete získat další informace o případu.")
    };
            Evidence = new List<Evidence>();
            Npcs= new List<Npcs>();
        }
        public void startGame()
        {
            Character player = new Character("Petr Klíč", "Chytrý soukromý detektiv s pověstí řešitele tajemných případů");
            Console.WriteLine($"Vítejte ve světě detektivky. Jste {player.name}, {player.description}.");
            Console.WriteLine("Dnes ráno jste přišel do své kanceláře a na svém stole jste našel tajemný dopis.");
            Console.WriteLine("Dopis obsahuje výzvu k řešení záhadného případu, který se týká krádeže uměleckého díla v muzeu.");
            Console.WriteLine("Jste připraven vyrazit na tajné místo, kde se setkáte s klientem? (ano/ne)");
            string odpoved = Console.ReadLine();

            if (odpoved.ToLower() == "ano") 
            {
                Console.Clear();
                Console.WriteLine("Vydáváte se směrem ke starému, odlehlému a opuštěnému domu.");
                Console.WriteLine("Když přicházíte na místo, vstupujete do temného domu a ve stínu spatřujete postavu čekající na vás.");

                Npcs klient = new Npcs("Klient", "Tajemná postava se zakrytou tváří", true);
                Npcs.Add(klient);
                talkToNPC(klient);
                Console.WriteLine($"{klient.name}: Děkuji, že jste dorazil, detektive Klíči. Mám pro vás důležitou zakázku.");
                Console.WriteLine($"{klient.name}: V muzeu došlo k odcizení vzácného uměleckého díla. Potřebuji, abyste tento případ vyřešil.");
                Console.WriteLine($"{klient.name}: Zde máte několik důkazů, které vám mohou pomoci. Buďte obezřetný, není jasné, kdo všechno je zapleten.");

                Console.WriteLine("Pro zobrazení fotografie stiskni jakékoliv tlačítko.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("  O");
                Console.WriteLine(" /|\\");
                Console.WriteLine(" / \\");
                Console.WriteLine("^^^^^");
                Evidence photo = new Evidence("Fotka", "Fotka muže snědé pleti, na fotce nejsou vidět jeho rysy");
                Console.WriteLine(Environment.NewLine + $"Popis důkazu: {photo.description}");
                this.Evidence.Add(photo);
                numberOfEvidence++;
                Console.WriteLine($"{klient.name}: Buďte opatrný, Detektive Klíči, a mějte na paměti, že čas je důležitý.");
                Console.WriteLine($"{klient.name} rychle mizí ve stínu, zanechávaje vás s úkolem vyřešit záhadu krádeže.");
                evidenceCheck();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Takhle se ale nikam neposuneš, pojďme tedy začít odznovu");
                startGame();
            }
        }
        public void talkToNPC(Npcs npc)
        {
            Console.WriteLine($"Mluvíte s postavou: {npc.name}. {npc.description}");
        } //Vždy nám řekne s kým si povídáme a jaký má popis
        public void evidenceCheck() //Kontroluje kolik máme sebraných důkazů (maximum jsou 4) následně shrne důkazy a postavy a hráč uhodne/neuhodne pachatele
        {
            if (numberOfEvidence >= 4)
            {
                Console.Clear();
                Console.WriteLine("Již jsi získal všechny možné důkazy");
                Console.WriteLine("Zde máš jejich shrnutí:");

                foreach (Evidence ev in Evidence)
                {
                    Console.WriteLine($"Název: {ev.name}, Popis: {ev.description}");
                }

                Console.WriteLine("Seznam podzřelých:");
                foreach (Npcs npc in Npcs )
                {
                    Console.WriteLine($"Jméno: {npc.name}, Popis: {npc.description}");
                }
                Console.WriteLine("Kdo z podezřelých je tedy pachatelem?");
                string result = Console.ReadLine();
                if (result.ToLower() == "ondřej bartolomeo")
                {
                    Console.Clear();
                    string asciiArt = @" 

                                                                                                                                                                       
                                                               _|                _|              _|      _|                                
   _|_|_|    _|_|    _|_|_|      _|_|_|  _|  _|_|    _|_|_|  _|_|_|_|  _|    _|  _|    _|_|_|  _|_|_|_|        _|_|    _|_|_|      _|_|_|  
 _|        _|    _|  _|    _|  _|    _|  _|_|      _|    _|    _|      _|    _|  _|  _|    _|    _|      _|  _|    _|  _|    _|  _|_|      
 _|        _|    _|  _|    _|  _|    _|  _|        _|    _|    _|      _|    _|  _|  _|    _|    _|      _|  _|    _|  _|    _|      _|_|  
   _|_|_|    _|_|    _|    _|    _|_|_|  _|          _|_|_|      _|_|    _|_|_|  _|    _|_|_|      _|_|  _|    _|_|    _|    _|  _|_|_|    
                                     _|                                                                                                    
                                 _|_|                                                                                                      ";
                    Console.WriteLine(asciiArt+ "\n");
                    Console.WriteLine("Gratuluji!\nPodařilo se ti vyřešit záhadu ukradeného obrazu a zařadil ses tím mezi nejlepší detektivy!");
                }
                else
                {
                    Console.WriteLine("Tentokrát to nevyšlo :(\nZkus si hru zahrát ještě jednou, a určitě na to přijdeš!");
                }
            }
            else
            {
                whatToDo();
            }
        }
        public void whatToDo() // posílá hráče do jednotlivých lokací pomocí switch
        {
            Console.WriteLine("Co chceš dělat teď?");
            Console.WriteLine("Můžeš:" + Environment.NewLine + "Zvol 1 pro návrat do Kanceláře" + Environment.NewLine + "Zvol 2 pro prozkoumání místa činu" + Environment.NewLine + "Zvol 3 pro navšívení policejní stanice");

            char a;
            while (!char.TryParse(Console.ReadLine(), out a) || (a != '1' && a != '2' && a != '3')) //kontrola vstupu
            {
                Console.WriteLine("Zadej prosím platné číslo:");
            }
            Console.Clear();
            switch (a) 
            {
                case '1':
                    Console.Clear();
                    exploreLocation(Location[0]);
                    break;
                case '2':
                    exploreLocation(Location[2]);
                    break;
                case '3':
                    exploreLocation(Location[3]);
                    break;
            }
        }
        public void exploreLocation(Locations location) 
        {
            Console.WriteLine($"Jste na místě: {location.name}. {location.description}");
            Evidence umbrella = new Evidence("Deštník", "Klasický velký černý deštník.");
            Evidence testimony = new Evidence("Výpověď", "Výpoveď o pohlaví pachatele (muž).");
            if (location.name == "Kancelář")
            {
                Console.WriteLine("Zde jsi získal první vodítko k případu, teď už tu ale nic nenajdeš.");
                whatToDo();
            }

            else if (location.name == "Místo činu")
            {
                
                Console.WriteLine("Přicházíte na místo, kde došlo ke krádeži uměleckého díla. Okolo je mnoho policejních pásů.");
                Console.WriteLine("Zde jsou některé možné akce, které můžete provést:");
                Console.WriteLine("Můžeš:" + Environment.NewLine + "Zvolit 1 pro promluvení s hlídačem" + Environment.NewLine + "Zvolit 2 pro promluvení s policistou");

                char n;
                while (!char.TryParse(Console.ReadLine(), out n) || (n != '1' && n != '2')) 
                {
                    Console.WriteLine("Zadej prosím platné číslo:");
                }
                Console.Clear();
                switch (n) 
                {
                    case '1':
                        if (!Evidence.Exists(e => e.name == umbrella.name))  //pomohl jsem si přes chat gtp, nejdříve jsem to chtěl udělat přes Evidence.Contains, ale to mi nefunovalo, teď už chápu. Ověřuje zda už má hráč sebraný daný důkaz či nikoliv
                        {
                            this.Evidence.Add(umbrella);
                            numberOfEvidence++;
                        } 
                        else
                        {
                            Console.WriteLine("Tady už jsi byl, je čas pokračovat v případu!");
                            whatToDo();
                        }
                        Npcs guard = new Npcs("Hlídač", "Starý pán hlídající muzeum.", true);
                        Npcs.Add(guard);
                        talkToNPC(guard);
                        Console.WriteLine("Bohužel ti nemám jak pomoci mladíku...");
                        Console.WriteLine("Já jsem malinko...hehe..usnul během služby víš?");
                        Console.WriteLine("Ale našel jsem tady nějaký deštník tak třeba ti k něčemu bude.");

                        Console.WriteLine("Pro sebrání deštníku stiskni libovolné tlačítko.");
                        Console.ReadKey();
                        string asciiArt = @"  
                                
                                         .-'-.
                                       ,"".,-.,"".
                                           |
                                           J                                       
                                                            ";
                        Console.WriteLine(asciiArt);
                        Console.WriteLine("Tady už jsi získal všechno co jde, je čas pokračovat v případu!");
                        evidenceCheck();
                        break;
                    case '2':
                        Npcs policeOfficer = new Npcs("Mirek měšťák", "Obtloustlý policista.", false);
                        Npcs.Add(policeOfficer);
                        talkToNPC(policeOfficer);
                        Console.WriteLine("Zdravím pane policisto, nezjistil jste tady na místě něco zajímavého?");
                        Console.WriteLine($"{policeOfficer.name}: No to žejo záleží kdo se ptá.");
                        Console.WriteLine("Já jsem soukromý detektiv Klíč.");
                        Console.WriteLine($"{policeOfficer.name}: detektiv jo? To si ale musim ověřit\nVyřeš tuhle hádanku a hned bude jasný jestli jsi tak chytrej!");
                        Console.WriteLine($"{policeOfficer.name}: Co je to, co běží až za tebou, když utečeš z banky, ale nikdy tě nechytnou?");
                        for (int i = 0; i < 2; i++)
                        {
                            string answer = Console.ReadLine();
                            if (answer.ToLower() == "tvoje stíny")
                            {
                                Console.WriteLine($"{policeOfficer.name}: Správně hehe! Tvoje stíny tě nikdy nechytnou.");
                                Console.WriteLine($"{policeOfficer.name}: Zjistili jsme, že pachatelem byl určitě muž.");

                                if (!Evidence.Exists(e => e.name == testimony.name))
                                {
                                    this.Evidence.Add(testimony);
                                    numberOfEvidence++;
                                    Console.WriteLine("Tady už jsi získal všechno co jde, je čas pokračovat v případu!");
                                    evidenceCheck();
                                }
                                else
                                {
                                    Console.WriteLine("Tady už jsi byl, je čas pokračovat v případu!");
                                    whatToDo();
                                }

                            }
                            else
                            {
                                Console.WriteLine("Špatně. Zkus to znovu!");
                            }
                            
                        }
                        gameOver();
                        break;
                }
            }
            else if (location.name == "Policejní stanice")
            {
                Console.WriteLine("Nacházíte se na policejní stanici, kde můžete získat další informace o případu.");
                Console.WriteLine("Zde jsou některé možné akce:");
                Console.WriteLine("1. Oslovte vyšetřovatele a zeptejte se na aktuální pokrok v případu.");
                Console.WriteLine("2. Opusťte policejní stanici.");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        Console.Clear();
                        Npcs policeOfficer2 = new Npcs("Petr Patrola", "Vyšetřovatel, pomohl nám dostat seznam podezřelýchh", false);
                        Console.WriteLine("Oslovujete vyšetřovatele a zeptáte se na aktuální pokrok v případu.");
                        Console.WriteLine($"{policeOfficer2.name}: Máme několik podezřelých, kteří se motali v blízkosti místa činu, ale zatím žádné konkrétní stopy. Každá informace je vítána.\"");
                        Console.WriteLine($"{policeOfficer2.name}: Zde máte seznam podezřelých");
                        Console.WriteLine("Pro zobrazení seznamu podezřelých stiskni jakékoliv tlačítko.");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Pavel Příživník, Lukáš Loupežník, Karel Kapsář, Ondřej Bartolomeo");
                        Evidence list = new Evidence("seznam podezřelých", "na seznamu jsou čtyři jména: Karel Kapsář, Lukáš Loupežník, Pavla Příživníková, Ondřej Bartolomeo, po zavolání na stanici zjistíš jejich popis");
                        
                        Npcs sus1 = new Npcs("Karel Kapsář", "Muž menšího vzrůstu, bílé pleti, brýle", true);
                        Npcs sus2 = new Npcs("Lukáš Loupežník", "Muž středního vzrůstu, snědší pleti, modré oči", true);    
                        Npcs sus3 = new Npcs("Pavla Pavla Příživníková", "Žena nižšího vzrůstu, bílé pleti, černé vlasy, hnědé oči", true);
                        Npcs sus4 = new Npcs("Ondřej Bartolomeo", "Muž vyššího vzrůstu, snědší pleti, černé vlasy, tmavé a mokré vlasy", true);
                       
                        Npcs.Add(sus1);
                        Npcs.Add(sus2);
                        Npcs.Add(sus3); //přidávání postav do listů
                        Npcs.Add(sus4);
                       
                        Npcs.Add(policeOfficer2);
                        if (!Evidence.Exists(e => e.name == list.name))
                        {
                            this.Evidence.Add(list);
                            numberOfEvidence++;
                            Console.WriteLine("Tady už jsi získal všechno co jde, je čas pokračovat v případu!");
                            evidenceCheck();
                        }
                        else
                        {
                            Console.WriteLine("Tady už jsi byl, je čas pokračovat v případu!");
                            whatToDo();
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Opouštíte policejní stanici.");
                        whatToDo();
                        break;
                    default:
                        Console.WriteLine("Neplatná volba. Ztrácíte cenný čas.");
                        break;
                }
            }
        }
        public void gameOver()
        {
            Console.WriteLine("Případ se ti nepovedlo vyřešit...tak snad někdy přístě.");
        }
    }
}
