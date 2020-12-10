using System;
using System.Collections.Generic;


namespace GrandTheftText
{
    public static class Game
    {
        static string CharacterName = "*";
        static string playerv = "*";
        static string playerw = "*";
        static string playero = "*";
        public static void StartGame()
        {
            GameTitle();
            NameCharacter();
            Choice();
            EndGame();
            //choose name and if you want to start//
            static void NameCharacter()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@"Note that some choises have shortcuts wich make it easier to play
exaple: Option=running away (run)the text in: -->()<-- 
is the text your suppossed to type.
thx for reading now lets start with the game!!");
                Console.ResetColor();
                Console.WriteLine("Welcome to my game ready to have some fun? First we start with your name...");
                CharacterName = Console.ReadLine();
                Console.WriteLine("Well hello there " + CharacterName + ", are you ready to start yes or no?");
                {
                    if (CharacterName == "BigFloppa")
                    {
                        Console.Clear();
                        string floppa = @"...,cloooolllllllllllllllooooooooloolllllllllllllllllllllloollc'...   .........':cccccccc::::::::;;;
...'clloolllllllllllllllooooolooolllllllllllllllllllllllllllc:,...   ..........;cccccccc:::;:::::;;;
....'cloollllllllllllllllllllllllllllllllllllllcc::;;,,,,,,,....    ..........':cccccccc::;;;::::;;;
.  ...;:clllllllllllllllllllllollllllllc:;,,,,,'...............   .......'..''';ccccccc:::;;;;;;;;;;
;.. .....',;:ccccccllllllllllooollc;,,,'... ....................   .....'''....,:cccccc:::;;;;;:;;;;
l:,... .....''',''',,,,,;:ccccc:,'......... ..............................'....':ccccc::::;;;;:::;;;
llc:,'.......................'........'....  ......''''... ....................;clcccc::::;;;;::;;;;
llllc:,''..........................'''.....   .......''...   ...............  .;cccccc:::;;:::::;;;;
llllllc:;'.........................'........  ............    ...............  ..;:ccc::;,,;:::::;;:
lllllllllc;'...................  ............ ............   ....  ...............;:cc::,,;:::::::::
llllllooollc:;,,'..............  ............................             .........,:::;;;:::::::;;:
llllllooooooolcc:,'............   ......................','.              ..........';;;;;;:::::::::
llllllooooooooolc;'.............  ......................,:;.             .'......  ...,;;;;;::::::;;
lllllooooooooooolc;'.....         .';;,'................,:;.           .';;.....    ...;;;;;;;:::;;;
oooooooooooooooool:,...            .;lc;'...............,::'          .';;'....      ...,;;;:::::;;;
oooooooooooooooolc,..... ..         'll:'...............',;'.      ...','......       ...,;;::::;;;;
ooooooooooooooolc'....','..         .cc:,.................'.     ..,,,'........       ...';:;::;;;;:
ooooooooooooooll;......,;:,..       .,:;,'...................   ..,,''........        ....,;;;;;,;;:
oooooooooooooooc,.......'',,'..'..   ..''.....................   ............        .....';;::;,;;;
oooooooooooooool;............',;;'.  .......................  .  ..........     ...........,;;;,,;:;
ooooooooooooooll:.............'','.. .......................      ........    .............,;;,',;;;
oooooooooooooollc;'................... ....................    .. .....    ................,;;..,;;;
oooooooooooooolllc;'..................  ...................    .....     ...................,...,;;,
oooooooooollllllllc;.... .............. ................       ......  ........................',,,,
ooooooooollllllllll:,......   ......... .............         ........ ................     ...,;,,,
oolloooolllllllllllc;'..............''...       ....         .'......    .............      ..';;,,,
lloolllllllllllllllc:,''''''''.....'''''..       ...        .',....      ......................',,',
lllllllllllllllllllcc:;'''''''.. ....'';;'..              .'''........   .................... ..,,,,
llllllllllllllllcllccc:;,,''''.. .....';:::;..           .,,'.....       .................     ..',,
llllllllllllcccccccccccc:;,'''........'',;::;'.        ..'''.....       ..............         ...',
lllllllclllcccllccccccccc:;,'''..  .....',,,,''...    .'........       ...........              ...,
llllllcccccclllllccccccccc:;'.......................  .........      ........                     ..
lllllccccccclllllccccccccc:,'........   ...........     .   ..............                        ..
lllcccccllllllccccccccccc::,'..........  .............................                             .
cccccccccccccccccccccccc:::,''''...................................                                 
ccccccccccccccccccccccc:::;'''''...................''''........                                     
cccccccccccccccccccc::::;,..................................                                        
cccccccccccccccccccccc:;'.......................................                                    
cccccccccccccccccccccc:,........................''''.''''........                                   
";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(floppa);
                        Console.ResetColor();
                        Console.WriteLine("BIG_FLOPPA_MODE_ACTIVATED");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You found an easter egg!!");
                        Console.ResetColor();
                    }
                }
                {   //Start yes or no
                    string input = Console.ReadLine();
                    if (input == "yes")
                    {
                        Console.Clear();
                        Console.WriteLine("Nice, lets Start committing some crimes Press enter to continue ");
                    }
                    switch (input == "no")
                    {
                        case true:
                            Console.WriteLine("Ok I'll wait but not for long, I don't wanne miss out on the fun!");
                            Console.WriteLine("If your ready give me a yes and we'll start");
                            if (input == "yes")
                            {
                                Console.WriteLine("alright lets go then!");

                            }
                            if (input == "no")
                            {
                                return;
                            }
                            break;
                    }
                }
            }
            //All chapters and choices//
            static void Choice()
            {
                for (int scenario = 1; scenario <= 3; scenario++)
                {
                    //Story parts
                    string input = Console.ReadLine();
                    switch (scenario)
                    {
                        //H1
                        case 1:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(@"
████████╗██╗  ██╗███████╗    ██████╗ ███████╗ ██████╗ ██╗███╗   ██╗███╗   ██╗██╗███╗   ██╗ ██████╗ ███████╗
╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██╔════╝██╔════╝ ██║████╗  ██║████╗  ██║██║████╗  ██║██╔════╝ ██╔════╝
   ██║   ███████║█████╗      ██████╔╝█████╗  ██║  ███╗██║██╔██╗ ██║██╔██╗ ██║██║██╔██╗ ██║██║  ███╗███████╗
   ██║   ██╔══██║██╔══╝      ██╔══██╗██╔══╝  ██║   ██║██║██║╚██╗██║██║╚██╗██║██║██║╚██╗██║██║   ██║╚════██║
   ██║   ██║  ██║███████╗    ██████╔╝███████╗╚██████╔╝██║██║ ╚████║██║ ╚████║██║██║ ╚████║╚██████╔╝███████║
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═════╝ ╚══════╝ ╚═════╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚══════╝
                                                                                                           
");
                            Console.WriteLine("Chapter_1");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            //C1
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("You take of on the street ready to steal a car, " + CharacterName + " can choose for 3 atributes:");
                                Console.WriteLine("A pistol, picklock or crowbar.");
                                //c1 choice 1
                                input = Console.ReadLine();
                                if (input == "pistol")
                                {
                                    Console.Clear();
                                    Console.WriteLine("pistol:");
                                    Console.WriteLine(CharacterName + " quickly grabs his pistol of his belt and runs towards the nearby highway." + "He sees a car.");
                                    Console.WriteLine("As " + CharacterName + " trows open the door and Screams: GET OUT OF THE CAR! The victim runs out desperately to get to safety quick.");
                                    Console.WriteLine("Thats how he ends up with a car and drives of with roaring wheels. " + CharacterName + " noticed the car is perfect for the next gang meetup");
                                    Console.WriteLine("he was about to go to.");
                                    Console.ReadLine();
                                }
                                else if (input == "picklock")
                                {
                                    Console.Clear();
                                    Console.WriteLine("picklock:");
                                    Console.WriteLine(CharacterName + " reaches in his right pocket only to find a picklock.");
                                    Console.WriteLine("Oh well we'll find a use for that. " + CharacterName + " heads of to a nearby car garage, and finds a suiting and stealthy car.");
                                    Console.WriteLine("Perfect for the next Gang meetup he was about to head to. " + CharacterName + " breaks in to the car an drives of with a cool look");
                                    Console.WriteLine("on his face.");
                                    Console.ReadLine();
                                }
                                else if (input == "crowbar")
                                {
                                    Console.Clear();
                                    Console.WriteLine("crowbar:");
                                    Console.WriteLine(CharacterName + "  reaches in his back pocket and suddenly finds a crowbar, he tries to guess where it came from but thinks: nervermind...");
                                    Console.WriteLine("As he walks down the street " + CharacterName + " finds a car garage next to a nice looking house, with the crowbar he breaks te lock and open the");
                                    Console.WriteLine("big garage door. A realy nice car is sitting inside ready to be stolen, " + CharacterName + " suddenly realizes the keys are knowhere to be seen. ");
                                    Console.WriteLine("But there is always another option, " + CharacterName + " tries to slam the backwidow a couple of times and the windows breaks!!");
                                    Console.WriteLine("As " + CharacterName + " makes his way in from the backwindow he hears a loud noice more like an alarm, when " + CharacterName + " comes to the part when he combines te wires and is ready to drive off,");
                                    Console.WriteLine("The owner of the car comes out of his house and runs with a big gun towards the garage. " + CharacterName + " drifts off savely.");
                                    Console.ReadLine();
                                }
                            }
                            //C2
                            {
                                Console.Clear();
                                Console.WriteLine(CharacterName + " succesfully stole a car and he's ready to go to the big gang meeting thats a couple of blocks away.");
                                Console.WriteLine("While " + CharacterName + " is driving in cruise control a flashing light in his right mirror catches his interest,");
                                Console.WriteLine("quit curious he looks in his back mirror and sees a white and black car speeding towards his car.");
                                Console.WriteLine("As " + CharacterName + " redecides all his live choices he suddenly knows that those are the colors of a cop car. ");
                                Console.WriteLine("Now the flashing light also makes sens but " + CharacterName + " has another problem to deal with... you have 3 options:");
                                Console.WriteLine("play it cool (cool), guns blazing (guns) or explotion (boom)?");
                                input = Console.ReadLine();
                                if (input == "cool")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Play it cool:");
                                    Console.WriteLine("While the police car drives by with loud sirens and takes a tight corner " + CharacterName + " sits straight face in his car being aware the police car wasn't ment for him, ");
                                    Console.WriteLine("you continue savely with a rather boring route.");
                                    Console.ReadLine();
                                }
                                else if (input == "guns")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Guns blazing:");
                                    Console.WriteLine("As the police car starts to pass " + CharacterName + " and drives besides him he grabs his gun aiming for the driver and tries to shoot, but the only thing he hears is a loud clicking noise.");
                                    Console.WriteLine("It had happend earlier that the gun was empty in some thight situations but this really is the wrong moment, ");
                                    Console.WriteLine("while " + CharacterName + " looks surprised the police man a couple of feet away looks to his side and sees a man poiting a gun at him.  ");
                                    Console.WriteLine(CharacterName + " notices it realy scared him because in a fast moment he steers hard left and crashes off a bridge into a large lake.");
                                    Console.ReadLine();
                                }
                                else if (input == "boom")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Explotion:");
                                    Console.WriteLine("As " + CharacterName + " drives faster and faster out of nervousness, the cop noticesses him and starts driving faster also. when " + CharacterName + " is almost at the end of the bridge he's driving already at 74 mph,");
                                    Console.WriteLine("now to police car is realy triggert and starts chasing " + CharacterName + " . At the of the bridge is a tight corner " + CharacterName + " needs to take to get to his destination.");
                                    Console.WriteLine("But his driving speed is way to high to take the corner without crashing. So " + CharacterName + " desides to break, the cop gets quite the big jump scare and steers hard left crashing in a big fuel truck. ");
                                    Console.WriteLine("While " + CharacterName + " drives of he sees in his back window that the big truck explodes!!. You drive off fast because more cops will arive soon.");
                                    Console.ReadLine();
                                }
                            }
                            //C3
                            {
                                Console.Clear();
                                Console.WriteLine(CharacterName + " escaped the police car. Now he's ready to go over to the gang meeting. As he drives around the corner a couple of big guys stop his car and asks the question what he's doing there.");
                                Console.WriteLine("Minutes later they let " + CharacterName + " in and drive thru the street entrance. In the distance he sees the gang leader and more people he doesn't know. ");
                                Console.WriteLine("As " + CharacterName + " comes closer the man facepalms and directs that " + CharacterName + " gets out of the car. He doesn't look happy... When " + CharacterName + " gets out he says: " + CharacterName + " you have a big problem,");
                                Console.WriteLine("you stole a car and we heard sirens in the distance, if you want to stay in the gang you need to keep a low profile. ");
                                Console.WriteLine("But he also has a new job for " + CharacterName + ", he wants to do a big heist stealing a lot of money. he calls it: The Big Score.");
                                Console.WriteLine("He asks if " + CharacterName + " is in or not?");
                                Console.WriteLine("You have 2 options: yes or no...");
                                input = Console.ReadLine();
                                if (input == "yes")
                                {
                                    Console.Clear();
                                    Console.WriteLine(CharacterName + " deside's to move on.");
                                    Console.ReadLine();
                                }
                                else if (input == "no")
                                {
                                    Console.Clear();
                                    Console.WriteLine("come on... that's not an option!");
                                    Console.ReadLine();
                                }
                            }
                            break;
                        //H2
                        case 2:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(@"
████████╗██╗  ██╗███████╗    ██████╗ ██████╗ ███████╗██████╗ ███████╗
╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██╔══██╗██╔════╝██╔══██╗██╔════╝
   ██║   ███████║█████╗      ██████╔╝██████╔╝█████╗  ██████╔╝███████╗
   ██║   ██╔══██║██╔══╝      ██╔═══╝ ██╔══██╗██╔══╝  ██╔═══╝ ╚════██║
   ██║   ██║  ██║███████╗    ██║     ██║  ██║███████╗██║     ███████║
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═╝     ╚═╝  ╚═╝╚══════╝╚═╝     ╚══════╝
                                                                     
");
                            Console.WriteLine("Chapter_2");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            //C1
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Clear();
                                Console.WriteLine("Now " + CharacterName + " has a new job as a bank robber, but first he needs to do a couple of preps. We need a couple of weapons and vehicles to have succes at raiding the bank.");
                                Console.WriteLine("First " + CharacterName + " chooses a vehicle. You can choose between 3 objects:");
                                Console.WriteLine("fast car, heavy car or a helicopter?");
                                playerv = Console.ReadLine();
                                if (playerv == "fast car")
                                {
                                    Console.Clear();
                                    Console.WriteLine("fast car:");
                                    Console.WriteLine(CharacterName + " has chosen go for a fast car sinds can out run police easly with it and has a new cool car.");
                                    Console.ReadLine();
                                }
                                else if (playerv == "heavy car")
                                {
                                    Console.Clear();
                                    Console.WriteLine("heavy car:");
                                    Console.WriteLine(CharacterName + " has chosen go for a heavy car sinds he can use it as a nice defence against the police and can ram right into the bank backdoor.");
                                    Console.ReadLine();
                                }
                                else if (playerv == "helicopter")
                                {
                                    Console.Clear();
                                    Console.WriteLine("helicopter:");
                                    Console.WriteLine(CharacterName + " has chosen go for a helicopter sinds he can land on the roof and take out any defenders on top of the roof.");
                                    Console.ReadLine();
                                }
                            }
                            //C2
                            {
                                Console.Clear();
                                Console.WriteLine("Now " + CharacterName + " has a vehicle that wil come handy for the heist. Next he will choose a weapon.");
                                Console.WriteLine("You can choose between 3 weapons:");
                                Console.WriteLine("shotgun, ar rifle or mk2 revolver");
                                playerw = Console.ReadLine();
                                if (playerw == "shotgun")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Shotgun:");
                                    Console.WriteLine(CharacterName + " has chosen to go with the shotgun sinds he then can shoot doors open and use it as a big advantage.");
                                    Console.ReadLine();
                                }
                                else if (playerw == "ar rifle")
                                {
                                    Console.Clear();
                                    Console.WriteLine("AR Rifle:");
                                    Console.WriteLine(CharacterName + " has chosen for the AR Rifle sinds he now can shoot automaticly and has a big advantage against the guards.");
                                    Console.ReadLine();
                                }
                                else if (playerw == "mk2 revolver")
                                {
                                    Console.Clear();
                                    Console.WriteLine("MK2 Revolver:");
                                    Console.WriteLine(CharacterName + " has chosen for the MK2 Revolver sinds he now can shoot right thru locks and gives him a big advantage.");
                                    Console.ReadLine();
                                }
                            }
                            //C3
                            {
                                Console.Clear();
                                Console.WriteLine("Now " + CharacterName + " has a weapon that wil come handy for the heist. Next he will choose some equipment.");
                                Console.WriteLine("You can choose between 2 options:");
                                Console.WriteLine("drill or explosives.");
                                playero = Console.ReadLine();
                                if (playero == "drill")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Drill:");
                                    Console.WriteLine(CharacterName + " has chosen for the Lock Drill so now he can open the lock stealty without the whole bank knowing");
                                    Console.ReadLine();
                                }
                                else if (playero == "explosives")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Explosives:");
                                    Console.WriteLine(CharacterName + " has chosen for the Explosives so he can open the fault with a bang and can get out without wasting any time.");
                                    Console.ReadLine();
                                }
                            }
                            break;
                        //H3
                        case 3:
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkCyan;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(@"
████████╗██╗  ██╗███████╗    ██████╗ ██╗ ██████╗     ███████╗ ██████╗ ██████╗ ██████╗ ███████╗
╚══██╔══╝██║  ██║██╔════╝    ██╔══██╗██║██╔════╝     ██╔════╝██╔════╝██╔═══██╗██╔══██╗██╔════╝
   ██║   ███████║█████╗      ██████╔╝██║██║  ███╗    ███████╗██║     ██║   ██║██████╔╝█████╗  
   ██║   ██╔══██║██╔══╝      ██╔══██╗██║██║   ██║    ╚════██║██║     ██║   ██║██╔══██╗██╔══╝  
   ██║   ██║  ██║███████╗    ██████╔╝██║╚██████╔╝    ███████║╚██████╗╚██████╔╝██║  ██║███████╗
   ╚═╝   ╚═╝  ╚═╝╚══════╝    ╚═════╝ ╚═╝ ╚═════╝     ╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚══════╝
                                                                                              
");
                            Console.WriteLine("Chapter_3");
                            Console.ResetColor();
                            Console.ReadKey();
                            Console.Clear();
                            //C1
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("As the whole gang starts prepairing, the gang leader and " + CharacterName + " are going over to the bank to start prepairing for the heist.");
                                Console.WriteLine("After some time the whole squad and " + CharacterName + " are at the location ready to start. first we must enter the bank. You chose: " + playerv);                           
                                if (playerv == "fast car")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Fast car");
                                    Console.WriteLine(CharacterName + " enters the fast car and drives towards the garage, because the car is so fast and cool they think " + CharacterName + " must be a high assosiation member of the bank so they let you in!");
                                    Console.WriteLine(CharacterName + " continues");
                                    Console.ReadLine();
                                }
                                else if (playerv == "heavy car")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Heavy car");
                                    Console.WriteLine(CharacterName + " enters the Heavy car and drives to the bank door, as " + CharacterName + " lines up the car and rams the car thru the back door,");
                                    Console.WriteLine("it would have made some noice but it was the quiet par of the bank. " + CharacterName + " continues"); 
                                    Console.ReadLine();
                                }
                                else if (playerv == "helicopter")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Helicopter");
                                    Console.WriteLine(CharacterName + " enters the helicopter and flies to the top of the bank, nobody will expect this says the gang leader. " + CharacterName + " lands on the roof and enters the building.");
                                    Console.WriteLine(CharacterName + " continues.");
                                    Console.ReadLine();
                                }
                            }
                            //C2
                            {
                                Console.WriteLine("Now everybody is in, " + CharacterName + " steps in the elevator and goes down to the basement. the first " + CharacterName);
                                Console.WriteLine("sees is a lot of guards, the gang members charge right at them and take out most.");
                                Console.WriteLine("You chose: " + playerw);
                                if (playerw == "shotgun")
                                {
                                    Console.Clear();
                                    Console.WriteLine(CharacterName + " grabs his shotgun and grabs one of the guards. he asks the guard where the fault is positioned, he says its straight ahead.");
                                    Console.WriteLine("With the Shotgun " + CharacterName + " can pick all the quards in close quaters, this is quite handy for all the small coridors.");
                                    Console.WriteLine(CharacterName + " continues");
                                    Console.ReadLine();
                                }
                                else if (playerw == "ar rifle")
                                {
                                    Console.Clear();
                                    Console.WriteLine(CharacterName + " grabs his AR Rifle the M416 he puts it on burst mode and starts spraying, he ands up with a clutch. ");
                                    Console.WriteLine(CharacterName + " continues");
                                    Console.ReadLine();
                                }
                                else if (playerw == "mk2 revolver")
                                {
                                    Console.Clear();
                                    Console.WriteLine(CharacterName + " grabs the giant deagle like pistol he has the MK2 Revolver, and aims it at one of the quards. out of pure fear he runs away.");
                                    Console.WriteLine(CharacterName + " continues");
                                    Console.ReadLine();
                                }
                            }
                            //C3
                            {
                                Console.WriteLine("Now " + CharacterName + " ensured there are no guards left. He find the fault and starts the breaking job.");
                                Console.WriteLine("You chose: " + playero);
                                if (playero == "drill")
                                {
                                    Console.Clear();
                                    Console.WriteLine(CharacterName + " gets the Big drill out of his pocket and starts drilling. After some time the lock breaks and with a couple of twists the fault opens,");
                                    Console.WriteLine(CharacterName + " grabs as much money as he can and leaves.");
                                    Console.ReadLine();
                                }
                                else if (playero == "explosives")
                                {
                                    Console.Clear();
                                    Console.WriteLine(CharacterName + " grabs as much c4 as he can out of his bag. As the door blows open he gets a giant wave of money raining upon him, ");
                                    Console.WriteLine(CharacterName + " grabs as much money as he can and leaves.");
                                    Console.ReadLine();
                                }
                            }
                            break;
                    }
                }
            }
            //Gametitle
            static void GameTitle()
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WindowHeight = Console.LargestWindowHeight - 20;
                Console.WindowWidth = Console.LargestWindowWidth - 20;
                Console.Title = "title";
                string title = @"
 ██████╗ ██████╗  █████╗ ███╗   ██╗██████╗     ████████╗██╗  ██╗███████╗███████╗████████╗    ████████╗███████╗██╗  ██╗████████╗
██╔════╝ ██╔══██╗██╔══██╗████╗  ██║██╔══██╗    ╚══██╔══╝██║  ██║██╔════╝██╔════╝╚══██╔══╝    ╚══██╔══╝██╔════╝╚██╗██╔╝╚══██╔══╝
██║  ███╗██████╔╝███████║██╔██╗ ██║██║  ██║       ██║   ███████║█████╗  █████╗     ██║          ██║   █████╗   ╚███╔╝    ██║   
██║   ██║██╔══██╗██╔══██║██║╚██╗██║██║  ██║       ██║   ██╔══██║██╔══╝  ██╔══╝     ██║          ██║   ██╔══╝   ██╔██╗    ██║   
╚██████╔╝██║  ██║██║  ██║██║ ╚████║██████╔╝       ██║   ██║  ██║███████╗██║        ██║          ██║   ███████╗██╔╝ ██╗   ██║   
 ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝        ╚═╝   ╚═╝  ╚═╝╚══════╝╚═╝        ╚═╝          ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝   
";
                string photo = @"MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMWNNNNNNNNNNNNNWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMk,''''''''''''lXMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMd   ........  ;XMMMMMMMMMMMMMMMM
MMMMMMMMWNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXNWMMMMMWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWMMMMMWNNNo  .dXXXXXXc  ;XMMMMMMMMMMMMMMMM
MMMMMNkc,'.............................',ck0xc;'''''''''',,;;,''''''''''''''',;:okkc,'.'.  .kMMMMMWl  ;XMMMMMMMMMMMMMMMM
MMMM0;   ..''''''''''''.  .''''''''''''.   .   .'''''''''..     .''''''.  ..'..      ..'''':OMMMMMWl  ;XMMMMMMMMMMMMMMMM
MMMK,  'xKNWWWNWWWWWWWNc .kWWWWWWWWWWNNKO:  .cOXNNWWWWWWWNKxl'  lNWNWWW0xOXNNX0d.  .d0XWWWWWWMMMMMWl  ;XMMMMMMMMMMMMMMMM
MMMx. .xMMMMMMMMMMMMMMWc .OMMMMMMMMMMMMMMK, ;XMMMMMMMMMMMMMMWx. oMMMMMMMMMMMMMMWd..xWMMMMMMMMMMMMMWl  :NMMMMMMMMMMMMMMMM
MMMx. .OMMMMMWX0NMMMMMWc .OMMMMMWKKWMMMMMK, :XMMMMMW0KWMMMMMMk. oWMMMMMN0XMMMMMMk..kMMMMMMX0NMMMMMWl  :NMMMMMMMMMMMMMMMM
MMMx. .OMMMMMNc.kMMMMMWc .OMMMMMK,;XMMMMMK, .clllll:.:XMMMMMMk. oMMMMMMx.lWMMMMMk..kMMMMMWl.kMMMMMWl  :NMMMMMMMMMMMMMMMM
MMMx. .OMMMMMN:.kMMMMMWc .OMMMMMNO0WMMMMMK,  .coxxxxx0WMMMMMMk. oWMMMMMd.lWMMMMMk..kMMMMMWc.xMMMMMWl  :NMMMMMMMMMMMMMMMM
MMMx. .OMMMMMN:.kMMMMMWc .OMMMMMMMMMMMMMWx. .kWMMMMMMMMMMMMMMk. oMMMMMMx.lWMMMMMk..kMMMMMWc.xMMMMMWl  :NMMMMMMMMMMMMMMMM
MMMx. .OMMMMMN:.kMMMMMWc .OMMMMMMWWMMMMMWO' ;XMMMMMMWWMMMMMMMk. oMMMMMMx.lWMMMMMk..kMMMMMWc.xMMMMMWl  :NMMMMMMMMMMMMMMMM
MMMx. .OMMMMMN:.kMMMMMWc .OMMMMMXllXMMMMMK, :XMMMMMKcoNMMMMMMk. oMMMMMMx.lWMMMMMk..kMMMMMWc.xMMMMMWl  :NMMMMMMMMMMMMMMMM
MMMx. .OMMMMMWxlKMMMMMWc .OMMMMM0',KMMMMMK, :XMMMMMXodNMMMMMMk. oMMMMMMx.lWMMMMMk..kMMMMMWxl0MMMMMWl  cNMMMMMMMMMMMMMMMM
MMMx. .OMMMMMMMMMMMMMMWc .OMMMMM0',KMMMMMK, :XMMMMMMMMMMMMMMMk. oMMMMMMd.lWMMMMMk..kMMMMMMMMMMMMMMWl  cNMMMMMMMMMMMMMMMM
MMMx.  lNMMMMMMMMMMMMMWl .OMMMMM0',KMMMMMK, '0WMMMMMMMMMMMMMMk. oMMMMMMd.lWMMMMMk. cXMMMMMMMMMMMMMWl  cWMMMMMMMMMMMMMMMM
MMMx.   'coooooxXMMMMMWc .:oooooc.,KMMMMMK,  .:looooooooooood:  ,oooooo; 'oooooo;   'cloooooooooooo'  cWMMMMMMMMMMMMMMMM
MMMx. .cdddddddkXMMMMMWc  .'''''. ,KMMMMMNOddddo.                                  ...                lWMMMMMMMMMMMMMMMM
MMMx. .OMMMMMMMMMMMMMMNc .dNNNNXl ,0MMMMMMMMMMMX;  .lddxkO0OkxddddddddddddxO000OkxxkOkxxxxkkxxkkkkxkxx0NNNNNWMMMMMMMMMMM
MMMx. .kMMMMMMMMMMMWNKo.  .;,,,,.  :0NWMMMMMMMMX;   ....':c,...............;oxl,'..........................,ldddddddd0WM
MMMx.  ';;;;;;;;;;;;'.,::::::.      ..,;oXMMMMMNx:::::;.     .';:::::::::,.     ';::::::::::::'  .;:::::,.           lWM
MMMO,............   'dKMMMMMM0oooooooo, ,KMMMMMMMMMMMMMXo. ,dONMMMMMMMMMMWXd. 'kNWMMMMMMMMMMMMd.:ONMMMMMNkooooooo:.  lWM
MMMWNNNNNNNNNNXNO'  oWMMMMMMMMMMMMMMMMd ,KMMMMMMMMMMMMMMX:.kMMMMMMMMMMMMMMMWc oWMMMMMMMMMMMMMMd,OMMMMMMMMMMMMMMMMO.  lWM
MMMMMMMMMMMMMMMMK,  lWMMMMMMMMMMMMMMMMd ,KMMMMMWkxXMMMMMN:.kMMMMMMWOdKMMMMMMl.dMMMMMMKdooooooo,'OMMMMMMMMMMMMMMMMO.  lWM
MMMMMMMMMMMMMMMMK,  .c0MMMMMMk::lccccc' ,KMMMMMX;.OMMMMMN:.kMMMMMMWl.kMMMMMMl.dMMMMMMKxdxddddx:.'dNMMMMMXo:clcccl;   lWM
MMMMMMMMMMMMMMMMXc.  .xMMMMMWl c000000c ,0MMMMMX;.OMMMMMN:.kMMMMMMMXKNMMMMMMl.dMMMMMMMMMMMMMMMx. ;XMMMMMK,'x00000o.  lWM
MMMMMMMMMMMMMMMMWNl  .xMMMMMWl.dMMMMMMd ,KMMMMMX;.OMMMMMN:.kMMMMMMMMMMMMMMMWl.dMMMMMMWWWWWWWWWd. ;XMMMMMK,,KMMMMMO.  lWM
MMMMMMMMMMMMMMMMMMd  .xMMMMMWl.dMMMMMMd ,KMMMMMX;.OMMMMMN:.kMMMMMMMNKKKKKKKK:.dMMMMMMO;,,,,,,,.  ;XMMMMMK,,KMMMMMO.  lWM
MMMMMMMMMMMMMMMMMMd  .xMMMMMWl.dMMMMMMd ,KMMMMMX;.OMMMMMN:.kMMMMMMWo.;lccccc. dMMMMMMd  ..''''.  ;XMMMMMK,,KMMMMMO.  lWM
MMMMMMMMMMMMMMMMMMd  .xMMMMMMOo0MMMMMMd ,0MMMMMX;.OMMMMMN:.kMMMMMMWOoKMMMMMWl.dMMMMMMd  :XNNNXc  ;XMMMMMNxxNMMMMMO.  lWM
MMMMMMMMMMMMMMMMMMd  .xMMMMMMMMMMMMMMMo ,0MMMMMX;.OMMMMMN:.kMMMMMMMMMMMMMMMWl dMMMMMMd  :NMMMWl  ;XMMMMMMMMMMMMMMO.  lWM
MMMMMMMMMMMMMMMMMMx.  ;XMMMMMMMMMMMMM0, ,0MMMMMX;.OMMMMMN: :OXMMMMMMMMMMMMMO' dMMMMMMd  :NMMMWl  .dWMMMMMMMMMMMMWo.  oWM
MMMMMMMMMMMMMMMMMMXl.  'codddddddddoc.  .ldddddo..cdddddo'  .'lodddddddddo:.  ;dddddd;  :NMMMMk.  .;lddddddddddl;.  ,0MM
MMMMMMMMMMMMMMWKo:,.                                                                    .,:oONWk;.                .lKMMM
MMMMMMMMMMMMMXo.   .;;;;;;;;;;.    .;;;;;;' .;;;;;;,   .;;;;:;;'             .,;;;;;;;:;,.   :KMWKkxooooooooooooxOXWMMMM
MMMMMMMMMMMMWo  .cOXWMMMMMMMMWXO:  ;XMMMMMO.:NMMMMM0'.cOWMMMMMMXxooooooo,  .dKWMMMMMMMMMWKd.  cNMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMN:  '0MMMMMMMMMMMMMM0' ,KMMMMMO.:NMMMMM0';XMMMMMMMMMMMMMMMMWo  dWMMMMMMMMMMMMMWo  ;XMMMMMMMMMMMMMMMMMMMMMMMM
MMMWX0OOOOOOk,  .kXNWWMW0ONMMMMM0' ,KMMMMMO.:NMMMMM0';XMMMMMMMMMMMMMMMMWo .xMMMMMMXkXMMMMMWo  ,0XXXXKKKKXWMMMMMMMMMMMMMM
MMKl'.           ..',,;;..,ccccl:. .lddddd:..odxkkko..;oOOOOOOOxc:::::::.  cOOOkkx; ,l:::;,.   ..........:OWMMMMMMMMMMMM
MX:                                                                                                       .xWMMMMMMMMMMM
Mk.                                                                                                        :XMMMMMMMMMMM
M0'                                                                                                        cNMMMMMMMMMMM
MWk.                                                                                                      ,0MMMMMMMMMMMM
MMWKxlccccccc'   .'.......                                                              ....  .',,,,,,;:cxXMMMMMMMMMMMMM
MMMMMMMMMMMMMo  'ONXKK00000OOkxko. .ldddddddddooolc;.  .cccccccccccccccc'  ,cccclooodxkO00Kl  ;KWWWWWWWMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMd  .oNMMMMMMMMMMMMM0' .dNMMMMMMMMMMMWKc   .xNMMMMMMMMMMMMWK;  ,OWMMMMMMMMMMMWO,  cNMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMM0,   ':clclllcccccl;.   ':clllllllcc;.      ':clllllcclcc;.    .,:ccccccccc:,.  'OMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMWKo,..                ...           ..,oOx:..            ..;do,..           ..,oKWMMMMMMMMMMMMMMMMMMMMMMMMM
MMMMMMMMMMMMMMMMWX000000000000000000XK00000000000KXWMMMWX00000000000000XWMMNK0000000000000XWMMMMMMMMMMMMMMMMMMMMMMMMMMMM
";
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(photo);
                Console.WriteLine(title);
                Console.WriteLine("Press a random button to start XD");
                Console.ResetColor();
                Console.ReadKey();
                Console.Clear();
            }
            //End of the game
            static void EndGame()
            {
                Console.Clear();
                Console.WriteLine("You win!!! and leave with:");
                Console.WriteLine(playerv);
                Console.WriteLine(playerw);
                Console.WriteLine(playero);
                Console.ReadKey();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                string end = @"
████████╗██╗  ██╗██╗  ██╗    ███████╗ ██████╗ ██████╗     ██████╗ ██╗      █████╗ ██╗   ██╗██╗███╗   ██╗ ██████╗ 
╚══██╔══╝██║  ██║╚██╗██╔╝    ██╔════╝██╔═══██╗██╔══██╗    ██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝██║████╗  ██║██╔════╝ 
   ██║   ███████║ ╚███╔╝     █████╗  ██║   ██║██████╔╝    ██████╔╝██║     ███████║ ╚████╔╝ ██║██╔██╗ ██║██║  ███╗
   ██║   ██╔══██║ ██╔██╗     ██╔══╝  ██║   ██║██╔══██╗    ██╔═══╝ ██║     ██╔══██║  ╚██╔╝  ██║██║╚██╗██║██║   ██║
   ██║   ██║  ██║██╔╝ ██╗    ██║     ╚██████╔╝██║  ██║    ██║     ███████╗██║  ██║   ██║   ██║██║ ╚████║╚██████╔╝
   ╚═╝   ╚═╝  ╚═╝╚═╝  ╚═╝    ╚═╝      ╚═════╝ ╚═╝  ╚═╝    ╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                                                 
";
                Console.WriteLine(end);
                Console.WriteLine("Press enter to leave :)");
                Console.ResetColor();
            }
        }
    }
    class Item { }
    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
    }
}