using StjerneDuggen.Components;

namespace StjerneDuggen.Pages
{
    public partial class Routine
    {
        private List<YearSeasonCard.MonthRecord> springMonths = new()
        {
            new("Marts", "Vi følger naturens stille opvågning", new()
                {
                    new("Foråret begynder at vise sig", SpringSign),
                    new("Fastelavn", Fastelavn),
                    new("Påskeforberedelser", EsterPrep),  
                    new("Påskefrokost", EsterLunch)
                    
                }),
            new("April", "Vi åbner vores univers for andre", new()
                {
                    new("Vi planter karse", PlantingIndoor),
                    new("Kyllingeløb", Chickenrun)
                    
                }),
            new("Maj", "Vi passer det, der vokser", new()
                {
                    new("Miljøuge", EcoWeek),
                    new("Mors dag", MothersDay),
                    new("Vi planter sår og passer", PlantingOutside),
                    new("Naturen bliver varm og farverig" , WarmNature )
                })
        };
        private List<YearSeasonCard.MonthRecord> summerMonths = new()
        {
            new("Juni", "Vi lader nysgerrigheden vise vej", new()
                {
                    new("Sommer og udeliv", Summertime),
                    new("Fars dag", FathersDay),
                    new("Sankt Hans", MidSummer),
                    new("vandleg - vandets tre stadier", WaterPlay)
                }),
            new("Juli", "Vi giver plads til forventninger", new()
                {
                    new("Sommerferie", SummerHoliday)
                    
                }),
            new("August", "Vi forstår verden gennem hverdagen", new()
                {
                    new("Høst", Harvest),
                    new("Penge – legende forståelse af økonomi", Money)
                })
        };
        private List<YearSeasonCard.MonthRecord> autumnMonths = new()
        {
            new("September", "Vi passer på os selv og hinanden", new()
                {
                    new("Vi taler om efterårets komme", FallSigns),
                    new("Førstehjælp i børnehøjde", FirstAid)
                }),
            new("Oktober", "Vi mærker forandring gennem leg", new()
                {
                    new("Naturen forandrer sig", NatureChange),
                    new("Bål og udeliv", CampFire),
                    new("Halloween i børnehøjde", Halloween)
                }),
            new("November", "Vi leger os til selvstændighed", new()
                {
                    new("Selvhjulpenhed i garderoben", PutOnTakeOff),
                    new("Eventyr og fortællinger", FairyTale)
                })
        };
        private List<YearSeasonCard.MonthRecord> winterMonths = new()
        {
            new("December", "Vi deler traditioner og nærvær", new()
                {
                    new("Bedsteforældredag med nissestemning", GrandParents),
                    new("Jul og julegaver", Christmas),
                    new("Juleafslutning", SeeYouNextYear)
                }),
            new("Januar", "Vi mærker vinterens stille eventyr", new()
                {
                    new("Nytårsvelkomst", newYearWelcome),
                    new("Udforskning af vinterverden", winterWorld),
                    new("Følesansen får en tur", feeling)
                }),
            new("Februar", "Vi undrer os og undersøger vinterverdenen", new()
                {
                    new("Vinter-science", WinterScience),
                    new("Fastelavnsforberedelser", FastelavnForberedelser)
                })
        };

        #region YearCardText
        private const string SpringSign = @"Marts er årets første forårsmåned, og vi går på opdagelse efter forårstegn i naturen. Det kan være vintergækker, der bryder gennem jorden, eller blade og blomster, der så småt begynder at spire. Vi øver os i at se, mærke og sætte ord på de små forandringer omkring os. ";
        private const string Fastelavn = @"Op til fastelavn taler vi om, hvad fastelavn er, hvorfor vi fejrer den, og hvordan man traditionelt gør. Samtidig giver vi plads til børnenes egne tanker og ønsker, da alle børn har forskellige forestillinger om, hvad der gør en fest tryg og hyggelig. ";
        private const string EsterPrep = @"Fredagen inden påskeferien holder vi vores egen lille påskefrokost, hvor fællesskab, ro og hyggelige rammer er i centrum. ";
        private const string EsterLunch = @"Selvom påsken falder i april, begynder vi forberedelserne allerede i marts. Vi laver påskepynt, taler om påskens traditioner og fortællinger og snakker om påskeharen. Samtidig begynder vi at glæde os til vores kyllingeløb.";

        private const string PlantingIndoor = @"I april planter vi karse og stiller dem, så børnene kan følge med i, hvordan de vokser. Vi smager på karsen og taler om, hvad planter har brug for, for at gro.";
        private const string Chickenrun = @"April bruges også på at forberede vores kyllingeløb. Her inviterer vi familier og andre interesserede fra byen til nogle hyggelige timer i Stjerneduggen. 

Dagen byder på blandt andet æggejagt, påskeharens forhindringsbane og andre sjove og sanselige aktiviteter. Det er en dag, hvor vi viser Stjerneduggens univers frem – fyldt med leg, nærvær, fantasi og varme. Børnene kan deltage sammen med søskende, forældre eller bedsteforældre. 

Læs mere ved at kopiere linket til begivenheden på min facebookside: https://fb.me/e/7cHdRd5ZZ ";

        private const string EcoWeek = @"I maj holder vi miljøuge, hvor vi taler om affald, affaldssortering og genbrug. Når vi går på tur, har vi en skraldepose med og samler det affald, vi møder på vores vej. Vi taler om, hvordan vi – også som små mennesker – kan passe på jorden og bidrage til en verden, der er god at være i.";
        private const string MothersDay = @"Op til mors dag laver vi en lille ting til mor som en kærlig hilsen. Samtidig taler vi om, at mors dag er én særlig dag på året, hvor vi har aftalt at være ekstra opmærksomme – men at omsorg og kærlige handlinger er vigtige alle dage, både over for mor, far og andre, vi holder af. ";
        private const string PlantingOutside = @"I maj planter vi i bedet ved drivhuset. Det kan være ærter, gulerødder, blomster eller andre frø, vi får lyst til at så. Børnene er med til at vande, passe og følge planternes udvikling, og vi deler glæden ved det, der spirer frem.";
        private const string WarmNature = @"Maj markerer overgangen mod sommer. Dagene bliver længere, vejret varmere, og naturen mere farverig. Vi bruger uderummet flittigt, går på ture og udforsker naturen med krop, sanser og nysgerrighed.";


        private const string Summertime = @"Vi taler om sommeren, mærker varmen og opholder os ofte ude det meste af dagen. Vi går ture i nærområdet, leger i haven og passer de ting, vi har sået i bedene. Sommeren giver os mulighed for fordybelse i leg, natur og fællesskab i et roligt tempo. ";
        private const string FathersDay = @"Da fars dag ligger i juni, forbereder vi en lille ting til far for at vise ham, hvor vigtig han er. Vi taler sammen om, at fars dag er én bestemt dag, hvor vi har valgt at være ekstra søde ved far – men også om, at man gerne må gøre søde ting for både mor og far alle årets andre dage.";
        private const string MidSummer = @"Vi taler om Sankt Hans og traditionerne omkring dagen. Sammen laver vi vores egen lille heks, som vi brænder på et bål i haven og markerer midsommeren på en tryg og børnevenlig måde.";
        private const string WaterPlay = @"Når solen forhåbentlig har fået godt fat, begynder vi for alvor at lege med vand. Vi leger vandlege, laver vandbaner, vander planter og tager måske et badebassin frem nogle dage. Gennem legen undersøger vi vandets tre stadier og giver børnene kropslige og sanselige erfaringer med naturfænomener.";


        private const string SummerHoliday = @"Da en stor del af sommerferien afvikles i juli, har vi fokus på børnenes forventninger til ferien og deres oplevelser. Når børnene kommer tilbage, deler vi fortællinger om, hvad de har oplevet, og øver os i at lytte til hinanden og sætte ord på egne erfaringer. 

I 2026 holder Stjerneduggen sommerferielukket i ugerne: 29, 30 og 31. ";

        private const string Harvest = @"I august taler vi om høst og høster selv det, vi har dyrket i vores højbede. Vi går ture i nærområdet og ser, om vi kan opleve markerne blive høstet. På den måde får børnene en konkret forståelse for, hvor maden kommer fra.";
        private const string Money = @"I august arbejder vi med et forløb om penge. Målet er at give børnene en overordnet forståelse af, hvad penge er, og hvordan de bruges. Vi leger købmandslege med legepenge og taler om, hvordan man får penge i familien, og hvad de bruges til. 

Børnene inddrages i denne periode i indkøb af frugt og frokost, så vi kan tale om, hvad et beløb rækker til, og at der nogle gange kan være penge tilbage – og andre gange ikke. Forløbet foregår legende, med tydelig voksen guidning, og giver børnene en tidlig og tryg forståelse af økonomi i hverdagen.";


        private const string FallSigns = @"Selvom september ofte stadig rummer sommerens varme, begynder vi så småt at tale om efteråret. Temperaturen falder, vinden tager til, og bladene begynder at skifte farve. 
I denne periode har vi særligt fokus på påklædning og på at mærke efter, hvad kroppen har brug for. Børn er forskellige: Nogle er i konstant bevægelse og har det varmt, mens andre fordyber sig stille i naturens små detaljer og lettere bliver kolde. 
Vi øver os i at mærke efter, hvad vi laver, hvordan vi har det i kroppen, og hvilken påklædning det kalder på – og i at forstå, at vores behov ikke nødvendigvis er de samme.";
        private const string FirstAid = @" I september arbejder vi med førstehjælp for børn. Vi taler om, hvordan man passer på sig selv, og hvordan man kan hjælpe andre, hvis der skulle ske en ulykke. Vi tager udgangspunkt i Førstehjælp i børnehøjde fra Børneulykkesfonden, hvor al læring foregår gennem leg. I legen skabes rum for dialog, gentagelser og tryghed, så børnene kan gøre erfaringer, som sætter sig i kroppen – for det er gennem leg, børn lærer og husker bedst.";


        private const string NatureChange = @"Vi følger naturens forvandling fra sommerens varme til efterårets kølige eventyr. Vi samler blade, hopper i bladbunker, leger med mudder og udforsker vandpytter. 
Verden bliver til farverige blad regnbuer, skinnende vandpytter og skøre kastanjekreationer – og vi mærker efter, hvordan årstiden ændrer sig både omkring os og i kroppen.";
        private const string CampFire = @"Når temperaturen begynder at falde, tænder vi op i bålfadet og leger med at lave mad over bål. Vi tager også på ture til shelterpladsen i Møllegårdsskoven, hvor vi indimellem holder hyggelige båldage i naturen.";
        private const string Halloween = @"I oktober arbejder vi med halloween på en tryg og børnevenlig måde. Vi leder efter edderkoppespind i naturen, som vi kan fange på pap og bruge til at skabe en (u)hyggelig stemning.  Vi skærer græskar, bager græskarkerner og leger os ind i efterårets magi. ";


        private const string PutOnTakeOff = @"I november har efterårets kulde for alvor fået fat, og overtøjet fylder mere i hverdagen. Derfor sætter vi ekstra fokus på selvhjulpenhed i garderoben. 
Vi øver os i at tage termotøj og flyverdragt på og af og i at håndtere lynlåse, knapper og støvler. 
Selvhjulpenhed er noget, vi arbejder med hele året, men i denne periode kræver det ofte mere tid og tålmodighed, fordi tøjet fylder mere og giver mindre bevægelsesfrihed.";
        private const string FairyTale = @"I november fordyber vi os i eventyrenes verden. Vi læser og fortæller eventyr, bruger dem i stille stunder og arbejder med dukketeater, skyggeteater og rolleleg – både inde og ude. 
Vi taler om, hvad der kendetegner et eventyr: magiske tal som 3 og 7, helte, prøvelser og forvandlinger. Forløbet afsluttes med, at vi sammen skaber vores eget eventyr, som vi fortæller til forældrene sidst på måneden.";


        private const string GrandParents = @"(Fredag d. 11. december 2026) 
I december inviterer vi bedsteforældrene indenfor til bedsteforældredag. Det er en dag, hvor de får mulighed for at opleve en del af børnenes hverdag i Stjerneduggen og være sammen i rolige, hyggelige aktiviteter. Dagen er præget af nærvær, tid til relationer og fælles oplevelser på børnenes præmisser. 

Som en del af dagen vil der være små nisseinspirerede aktiviteter, som børn og bedsteforældre kan deltage i sammen. Nisseløbet fungerer her som en legende ramme, der understøtter hyggen og fællesskabet – uden tempo, krav eller faste programmer.";
        private const string Christmas = @"I løbet af december får vi besøg af vores drillenisse Hermansen og hans kæreste Gerda, som laver små, sjove nissestreger i hverdagen. 
Vi snakker om jul, hvorfor vi fejrer den, og synger julesange sammen. Vi tager i kirke og ser konfirmandernes julekrybbespil sammen med byens børnehaver. 

Vi laver julegaver på børnenes præmisser. Da børnegruppen er lille, bliver det ikke et samlebånd, hvor alle skal lave den samme gave. Allerede i november begynder vi at tale om, hvad man kunne have lyst til at give i julegave til mor, far og eventuelt søskende. 
Med guidning forsøger vi efter bedste evne at gøre børnenes egne idéer til virkelighed, så de kan give en personlig julegave fra hjertet – fremfor en voksenbestemt gave lavet i tvang.";
        private const string SeeYouNextYear = @"Vi slutter december af med en hyggelig og rolig juleafslutning sammen med forældre og søskende. Her får julegaverne lov at komme med hjem, vi ønsker hinanden god jul og godt nytår, glæder os over det, vi har oplevet sammen, og ser frem mod alt det nye, der venter, når vi ses igen i det nye år.";
        
        
        private const string newYearWelcome = @"Første dag efter juleferien bliver børnene budt velkommen med et regn af balloner. Det er vores måde at sige: Velkommen tilbage – I har været savnet. Det er en rolig, men hyggelig og festlig start, som hjælper børnene blidt tilbage i fællesskabet efter en længere ferie.";
        private const string winterWorld = @"Om vinteren er verden kold og hård. Mørket fylder mere, og dagene føles korte. Vi udforsker vinterverdenen på mange sanselige og nysgerrige måder. 
Vi går på lommelygtejagt og udnytter, at lyset både kommer sent og forsvinder tidligt. Vi undersøger, hvordan verden ser ud og føles, når den kun kan ses gennem lyskeglen fra en lommelygte. 
Vi går ture og mærker kulden, der bider i kinderne, og forskellen på varmen inde i stuen og kulden udenfor. De morgener, hvor det er muligt, kigger vi på stjerner og lytter efter de få fugle, som stadig synger og ikke er trukket sydpå. 

Hvis vi er heldige at få sne, leger vi i den: vi kælker, bygger snemænd, laver sneengle og – hvis lysten og sneen rækker – forsøger vi os måske med at bygge en iglo. Vi tegner i sneen med farvet vand, går ture og ser, hvor højt sneen når op, lytter til lyden af fodtrin i nyfalden sne og nyder vinterens stille eventyrlandskab. ";
        private const string feeling = @"Vintermånederne er en tid, hvor følesansen let kan blive lidt udfordret, fordi kroppen ofte er pakket ind i mange lag tøj. Derfor giver vi følesansen ekstra opmærksomhed i denne periode. 
Gennem massage, fodbad og små spa-dage arbejder vi med kropsfornemmelse og velvære. Vi tager elementer fra vinterverdenen med indenfor, når det giver mening, og arbejder med sansekasser, kartoffelmel, bagning og andre taktile aktiviteter. 
I denne tid har vi særligt fokus på det sanselige – både inde og ude – og giver børnene mulighed for at mærke, opleve og fordybe sig. ";


        private const string WinterScience = @"Vinteren er en oplagt tid til at lege med science. Vi udforsker den magiske verden omkring os gennem eksperimenter og nysgerrige undersøgelser. 
Vi arbejder med frosne sæbebobler, undersøger hvordan vand fryser til is, laver frosne solfangere og – hvis vi er heldige med sne – snevulkaner og maler i sneen med farvet vand. 
Måske finder vi en vintergæk og eksperimenterer med at farve den gennem vand. Alt sammen sker i børnehøjde, hvor undren, leg og fælles opdagelser er i centrum.";
        private const string FastelavnForberedelser = @"Da fastelavn i år falder i marts, bruger vi februar på at gøre os klar. Vi laver hyggelig fastelavnspynt, maler fastelavnstønden og leger med idéer til kostumer. 
Hvis lysten og evnerne rækker, forsøger vi også at lave kostumer selv – på børnenes præmisser og med de færdigheder, vi hver især har.";
#endregion



        private string routineStart = @"Her i stjerneduggen stræber vi efter både at have en rolig og genkendelig hverdags rytme og samtidig give plads til spontanitet hvor børnene kan komme med inputs og gode ideer til hvilke aktiviteter der skal finde sted i løbet af dagen. Børnene vil desuden blive inkluderet i forberedelser til maden da det er god læring og er med til at styrke børns mad-mod. Efter frokost vil alle børn holde siesta, hvilket vil give de børn der har behov for at sove, muligheden for dette, mens de børn der ikke skal sove, får ro i både hoved og krop. Her vil der være mulighed for at ligge og læse, lægge et puslespil eller bare ligge på en madras og slappe af.  ";

        private string typicalDay =
        @"6.30-7.30 Morgenmad og rolige aktiviteter 
8.30 Frugten klargøres i fællesskab i køkkenet 
9.00 Frugt og snak om dagens indhold 
9.30-10.30 Dagens planlagte aktivitet 
10.45-11.00 Tisse og vaske hænder samt dække bord 
11.00 Frokost 
12.00-12.30 Siesta 
12.30-14.00 Dem der ikke sover, går ud og leger. 
14.00 Eftermiddagsmad 
14.30-16.00 Leg og afhentning ";

        private string routineEnd =
            @"Hverdagen er struktureret så der er plads til spontanitet både hen over dagen men også spredt ud over ugen. Vi har dog torsdag som en fast tur-dag hvor vi vil besøge forskellige steder i nærområdet bl.a. skoven, kirken, plejehjemmet, togstationen, skolen, de andre børnehaver i byen. Der er også mulighed for at børnene kan komme med forslag for at imødekomme deres ønsker og give dem ejerskab over turen og deres dag. Der er dog begrænsninger da der skal tages hensyn til hele børnegruppen.";
    }
}
