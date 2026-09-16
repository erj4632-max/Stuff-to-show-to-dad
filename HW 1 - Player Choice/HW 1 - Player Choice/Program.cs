namespace HW_1___Player_Choice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vars
            bool isDemon = false;
            int NumInvalid = 0;
            bool killedGuard = false;
            bool talkedToGuard = false;
            bool foughtKing = false;
            int devScore = 0;
            int endingNum = 0;
            bool bestEnding = false;
            //Wake up, can choose to lie there or to get up and get moving

            //Tutorial
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hey Dad!");
            Console.WriteLine("Just a heads up: If you see this symbol \">\" it means you have to press any key to continue.");
            Console.Write("Try it now! >");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            //Intro
            Console.WriteLine("As your senses begin to return to you, the first thing you regain is touch.");
            Console.WriteLine("You can feel the heat and it is oppressive. It is bearing on you causing you to sweat more then you ever have before.");
            Console.WriteLine("The next thing you regain is the smell.");
            Console.WriteLine("It smells of sulfer and ash.");
            Console.WriteLine("Next is your hearing");
            Console.WriteLine("You hear the crackle of fire, and the distant sound of screams");
            Console.WriteLine("Finally, you open your eyes and see just where you are. The baren waste, the constant fires, the feeling of dread.");
            Console.Write("You know exactly where you are. >");
            Console.ReadKey();

            //First choice
            bool madeChoice1 = true;
            while (madeChoice1)
            {
                Console.Clear();
                Console.Write("You are in ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hell.\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("You sit up and decide what to do from here.");
                Console.Write("You can ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("LIE DOWN");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" and go back to sleep or you can ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("GET UP");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" and start exploring.\n");

                Console.Write("Your choice: ");
                String choice1 = Console.ReadLine()!.ToLower().Trim();
                if (choice1 == "lie down")
                {
                    Console.Clear();
                    madeChoice1 = false;
                    Console.WriteLine("\"This is probably just all a bad dream\" You think to yourself.");
                    Console.Write("You lie back down, close your eyes and hope that when you wake up again you are somewhere else >");
                    Console.ReadKey();
                    Console.Clear();
                    isDemon = true;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("You are not that lucky. >");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("As you wake back up, your senses don't seem to be anguishing anymore.");
                    Console.WriteLine("The heat is bearable, the smell lessened, \nand the screams feel like nothing more to you then the sound of an air conditioner");
                    Console.WriteLine("When you open your eyes, however you see your skin is completely red.");
                    Console.WriteLine("As you franticly examine the rest of your body, you notice two horns pertruding from the top of your head!");
                    Console.Write("You have turned into a demon! >");
                    Console.ReadKey();
                }
                else if (choice1 == "get up")
                {
                    madeChoice1 = false;
                }
                else
                {
                    NumInvalid++;
                    Console.Write("Invalid choice. >");
                    Console.ReadKey();
                }
            }

            //second intro
            Console.Clear();
            Console.WriteLine("You get up and begin to explore.");
            Console.WriteLine("In the distance you see a castle and decide to head there.");
            Console.Write("Guarding the door is a large and imposing demon holding a pitchfork. >");
            Console.ReadKey();
            Console.Clear();
            
            //second choice
            bool madeChoice2 = true;
            while (madeChoice2)
            {
                Console.WriteLine("He speaks in a booming voice:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\"Halt! None may enter here!\"");
                if (!isDemon)
                {
                    SetColorToDefault(isDemon);
                    Console.WriteLine("He smirks at you.");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\"Especially not a weak little human like you.\"\n");
                }
                SetColorToDefault(isDemon);
                Console.WriteLine("You contimplate on how to get past him.");
                Console.Write("You could try to ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("FIGHT");
                SetColorToDefault(isDemon);
                Console.Write(" him or you could try to ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("SNEAK");
                SetColorToDefault(isDemon);
                Console.WriteLine(" past him.");
                if (isDemon)
                {
                    Console.Write("He doesn't seem hostile to you, you could try to ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("TALK");
                    SetColorToDefault(isDemon);
                    Console.WriteLine(" to him.");
                }

                Console.Write("\nYour Choice: ");
                String choice2 = Console.ReadLine()!.ToLower().Trim();
                if (choice2 == "fight")
                {
                    Console.Clear();
                    madeChoice2 = false;
                    if (!isDemon)
                    {
                        Console.Write("Insulted by the demon, y");
                    }
                    else
                    {
                        Console.Write("Y");
                    }
                    Console.Write("ou run right up to him, ");
                    if (!isDemon)
                    {
                        Console.WriteLine("dodging as he stabs at you with his pitchfork.");
                    }
                    else
                    {
                        Console.WriteLine("seeming to catch him off guard.");
                    }
                    Console.WriteLine("You jump on his back and begin climbing him.");
                    Console.WriteLine("When you reach the top, you grab onto his head and twist. >");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("CRACK!");
                    Console.Write("The demon falls to the ground, dead. >");
                    killedGuard = true;
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (choice2 == "sneak")
                {
                    Console.Clear();
                    madeChoice2 = false;
                    Console.WriteLine("You point out into the distance.");
                    Console.WriteLine("Hey! What's that over there!");
                    Console.Write("As the demon turns to look, you slip past him. >");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choice2 == "talk" && isDemon)
                {
                    Console.Clear();
                    madeChoice2 = false;
                    Console.WriteLine("You ask politely for the demon to let you in");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\"Hmmm... Okay! Only because you asked so nicely.\"");
                    SetColorToDefault(isDemon);
                    Console.Write("The guard steps asside and lets you in. >");
                    talkedToGuard = true;
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    NumInvalid++;
                    Console.Write("Invalid choice. >");
                    Console.ReadKey();
                }
            }

            //third choice intro
            Console.WriteLine("You enter the throne room of the castle, and see a demon sitting on the throne, wearing a crown.");
            Console.WriteLine("As you enter, he speaks to you:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (isDemon)
            {
                if (killedGuard)
                {
                    Console.WriteLine("\"How dare you kill my guard! Prepare to die!");
                }
                else
                {
                    Console.WriteLine("\"Who are you? How did you get in here?\"");
                }
            }
            else
            {
                if (killedGuard)
                {
                    Console.WriteLine("\"How dare you, a human, kill my guard! Prepare to die!");
                }
                else
                {
                    Console.WriteLine("\"Who are you? How did you, a human, get in here?\"");
                }
            }

            //third choice
            bool madeChoice3 = true;
            while (madeChoice3)
            {
                Console.Clear();
                SetColorToDefault(isDemon);
                Console.WriteLine("He looks pretty mad, you need to decide what to do, and fast.");
                Console.Write("You can ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("ATTACK");
                SetColorToDefault(isDemon);
                Console.Write(", or ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("RUN AWAY");
                SetColorToDefault(isDemon);
                Console.WriteLine(".");
                if (killedGuard)
                {
                    Console.Write("You feel pretty cocky after killing that guard, you could also try to ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("INTIMIDATE");
                    SetColorToDefault(isDemon);
                    Console.WriteLine(" The king.");
                }
                if (isDemon)
                {
                    Console.Write("You're both demons right? You could probably just ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("TALK");
                    SetColorToDefault(isDemon);
                    Console.WriteLine(" things out right?");
                    if (talkedToGuard)
                    {
                        Console.WriteLine("It worked well enough with the guard.");
                    }
                }
                Console.Write("Your Choice: ");
                String choice3 = Console.ReadLine()!.Trim().ToLower();
                Console.Clear();
                if (choice3 == "attack")
                {
                    madeChoice3 = false;
                    if (isDemon)
                    {
                        Console.WriteLine("The demon king throws his pitchfork at you, but you dodge it.");
                        Console.WriteLine("You then pick it up and drive it through him.");
                        Console.WriteLine("You pick up the crown and sit on the throne.");
                        Console.Write("You are now the demon king. >");
                        Console.ReadKey();
                        if (killedGuard)
                        {
                            Console.Clear();
                            Console.WriteLine("The demon king throws his pitchfork at you, but you dodge it.");
                            Console.WriteLine("You then pick it up and drive it through him.");
                            Console.WriteLine("You pick up the crown and sit on the throne.");
                            Console.WriteLine("You are now the demon king. ");
                            Console.Write("Unfortunatly because you dont have a guard, you are soon assassinated. >");
                            Console.ReadKey();
                            endingNum = 1;
                        }
                        else
                        {
                            endingNum = 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The demon king throws his pitchfork at you, but you dodge it.");
                        Console.WriteLine("But as you go to pick it up, you are engulfed in flames.");
                        Console.Write("Better luck next time! >");
                        Console.ReadKey();
                        endingNum = 3;
                    }
                }
                else if (choice3 == "run away")
                {
                    madeChoice3 = false;
                    if (killedGuard)
                    {
                        if (isDemon)
                        {
                            Console.WriteLine("You dash out of the throne room as fast as you can.");
                            Console.WriteLine("The guard is dead, so you have no trouble escaping.");
                            Console.Write("You end up in a demon village, where you live out the rest of your life. >");
                            Console.ReadKey();
                            endingNum = 4;
                        }
                        else
                        {
                            Console.WriteLine("You dash out of the throne room as fast as you can.");
                            Console.WriteLine("The guard is dead, so you have no trouble escaping.");
                            Console.Write("You spend the rest of your life on the run from all the demons. >");
                            Console.ReadKey();
                            endingNum = 5;

                        }
                    }
                    else if (talkedToGuard)
                    {
                        Console.WriteLine("You dash out of the throne room as fast as you can.");
                        Console.WriteLine("The guard waves to you on the way out.");
                        Console.Write("You end up in a demon village, where you live out the rest of your life. >");
                        Console.ReadKey();
                        endingNum = 4;
                    }
                    else
                    {
                        Console.WriteLine("You dash out of the throne room as fast as you can.");
                        Console.WriteLine("Unfortunatly, you run straight into the guard, who swiftly captures you.");
                        Console.Write("You spend the rest of your life in prison.");
                        Console.ReadKey();
                        endingNum = 6;
                    }
                    
                }
                else if (choice3 == "intimidate" && killedGuard)
                {
                    madeChoice3 = false;
                    Console.WriteLine("You puff out your chest and say:");
                    Console.WriteLine("\"Get out of here before I kill you like I killed your guard.\"");
                    if (isDemon)
                    {
                        Console.WriteLine("The king runs away, letting you claim the throne.");
                        Console.Write("You rule with an iron fist, and all demons suffer for it. >");
                        Console.ReadKey();
                        endingNum = 7;
                    }
                    else
                    {
                        Console.WriteLine("The king laughs at you.");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\"A human? threatening me? How cute.\"");
                        SetColorToDefault(isDemon);
                        Console.WriteLine("The demon torches you with a fireball. >");
                        Console.ReadKey();
                        endingNum = 8;
                    }
                }
                else if (choice3 == "talk" && isDemon)
                {
                    madeChoice3 = false;
                    Console.WriteLine("You ask to talk with the demon king.");
                    if (talkedToGuard)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\"Hmm.. you were very polite to my guard so I suppose I shall hear you out.\"");
                        SetColorToDefault(isDemon);
                        Console.WriteLine("You explain that you are a human who turned into a demon, and you want to go home.");
                        Console.WriteLine("The king replies:");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\"I get it.\"");
                        SetColorToDefault(isDemon);
                        Console.WriteLine("You're shocked. \"Y-You do?\"");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("\"Yes! you are my new royal jester! That was a very funny story!\"");
                        SetColorToDefault(isDemon);
                        Console.Write("You live out the rest of your days as the king's jester.");
                        Console.ReadKey();
                        endingNum = 9;
                    }
                    else
                    {
                        Console.Write("The king throws his pitchfork through you before you can get a word out.");
                        Console.ReadKey();
                        endingNum = 10;
                    }
                }
                else if (choice3 == "seduce" && talkedToGuard)
                {
                    Console.WriteLine("\"Hey. Is it hot in here, or is it just you?\"");
                    Console.WriteLine("You successfully seduce the king! He proposes right on the spot and you get married.");
                    Console.Write("You live out the rest of your days in bliss with your new husband. >");
                    madeChoice3 = false;
                    Console.ReadKey();
                    bestEnding = true;

                }
                else
                {
                    NumInvalid++;
                    Console.Write("Invalid choice. >");
                    Console.ReadKey();
                }
            }
            Console.Clear();

            //Epilogue
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Congrats on winning! Let's see how you did!");
            if (!bestEnding)
            {
                if (isDemon)
                {
                    Console.WriteLine("You turned into a demon! That's pretty cool! +5");
                    devScore += 5;
                }
                else
                {
                    Console.WriteLine("You stayed a human. Boring. +0");
                }

                if (talkedToGuard)
                {
                    Console.WriteLine("You were polite to the guard! Nice! +5");
                    devScore += 5;
                }
                else if (killedGuard)
                {
                    Console.WriteLine("You killed the guard! Badass! +4");
                    devScore += 4;
                }
                else
                {
                    Console.WriteLine("You sneaked past the guard! Sneaky! +3");
                    devScore += 3;
                }

                switch (endingNum)
                {
                    case 1: Console.WriteLine("You got ending 1: Assasinated +4");
                        devScore += 4;
                        break;
                    case 2: Console.WriteLine("You got ending 2: Demon King +9");
                        devScore += 9;
                        break;
                    case 3: Console.WriteLine("You got ending 3: Incinerated +1");
                        devScore += 1; 
                        break;
                    case 4: Console.WriteLine("You got ending 4: Villager +7");
                        devScore += 7; 
                        break;
                    case 5: Console.WriteLine("You got ending 5: On the Run +6");
                        devScore += 6; 
                        break;
                    case 6: Console.WriteLine("You got ending 6: Prisoner +5");
                        devScore += 5; 
                        break;
                    case 7: Console.WriteLine("You got ending 7: Demon Dictator +8");
                        devScore += 8; 
                        break;
                    case 8: Console.WriteLine("You got ending 8: Cutly Incinerated +3");
                        devScore += 3; 
                        break;
                    case 9: Console.WriteLine("You got ending 9: Jester +10");
                        devScore += 10; 
                        break;
                    case 10: Console.WriteLine("You got ending 10: Failed Negotiator +2");
                        devScore += 2; 
                        break;
                }
                Console.WriteLine($"Finally you entered {NumInvalid} Invalid choices! -{NumInvalid}");
                Console.Write("Your final score is... >");
                Console.ReadKey();
                Console.WriteLine($"{devScore}!");
                if (devScore >= 20)
                {
                    Console.Write("Wow! A perfect score! Lemme tell you a little secret. After talking it out with the guard, type ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("SEDUCE");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" when fighting the king for a secret ending. ;)");
                    
                }
                else
                {
                    Console.WriteLine("Thank you for playing! Play again to get a new ending! There are 11 total!");
                }
            }
            else
            {
                Console.WriteLine("YOU GOT THE BEST ENDING POSSIBLE!!!!!");
            }
            Console.ReadKey();
        }

        //sets the console foreground color to it's defaut value based on if you're a demon or not
        public static void SetColorToDefault(bool demon)
        {
            if (demon)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
