using Microsoft.AspNetCore.Components;
using StjerneDuggen.Services;
using static System.Net.Mime.MediaTypeNames;

namespace StjerneDuggen.Pages
{
    public partial class Home
    {
        [Inject] private NavigationManager Navigation { get; set; } = default!;

        public void NavigateTo(string url)
        {
            if (!string.IsNullOrEmpty(url))
            {
                Navigation.NavigateTo(url);
            }
        }

        private string whatIsSD =
            @"Stjerneduggen er en privat pasningsordning i Aarup med plads til fem børn i alderen 3–6 år. Her er hverdagen fyldt med leg, motorik, musik og dejlige oplevelser i naturen. Jeg lægger vægt på at skabe en rolig og hjemlig atmosfære, hvor der er tid til nærvær og til at følge hvert enkelt barns nysgerrighed og unikke udvikling. ";

        private string aboutMeP1 =
            @"Mit navn er Rikke, og jeg står bag pasningsordningen Stjerneduggen. Jeg bor sammen med min mand og vores to børn i Aarup. Jeg er uddannet pædagog siden januar 2020 med erfaring fra daginstitution og familieliv – og jeg brænder for at skabe et roligt, stabilt og kærligt miljø, hvor både børn og forældre kan føle sig hjemme.  

Jeg er selv glad for at bruge min krop og er ikke bange for at løbe stærkt, klatre i træer eller se lidt fjollet ud når vi leger en god leg. Det er vigtigt for mig at børnene oplever at der er plads til at te sig tosset og udfordre sin krop i trygge rammer. Jeg blev i 2023 uddannet motorikvejleder hos Vends Motorik og naturskole og har derfor en god viden om børns motoriske udvikling.";

        private string aboutMeP2 =
            @"Jeg er glad for musik og bruger det meget i mit arbejde. Jeg synger meget og spiller guitar (til husbehov) Jeg er desuden glad for at være kreativ ved enten at male, tegne, klippe/klistre eller hækle. 

Med Stjerneduggen ønsker jeg at tilbyde en lille, hjertevarm pasningsordning, hvor børn får lov til at vokse i deres eget tempo.";

        private string aboutNamingSd =
            @" Navnet Stjerneduggen er valgt med hjertet. Det vækker billeder af stjernelys, der daler stille ned og lægger sig som dug i græsset – et magisk øjeblik, som kun det nysgerrige barneøje rigtigt ser. For mig symboliserer det den ro, det nærvær og den fordybelse, jeg ønsker at give børnene. Her skal der være plads til at gå i sit eget tempo, opdage verden i det små og blive guidet – ikke skubbet – i sin udvikling. Barndommen er ikke et kapløb, men en tid til at være lige præcis dét, man er: barn. ";

        private string poem =
            @"Et blad bliver til en tallerken, 
en pind bliver til et sværd, 
og midt i planlagte aktiviteter 
opstår der små mirakler uden manuskript. 

En trøstet tåre. Et nyopfundet spil. 
En hånd, der rækker ud, fordi det føles rigtigt. 
Livet i børnehøjde følger rytmen som et hjerte, 
men springer alligevel i alle retninger. 

Det er her idyllen bor – 
ikke i det perfekte program, 
men i mødet mellem ramme og frihed, 
mellem klokken og nu’et, 
mellem verden og legen. ";


    }
}
