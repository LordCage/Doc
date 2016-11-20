using Discord;
using Discord.Commands;   
using Discord.Modules;
//-----------------------------\\ Rewrite this.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
//-----------------------------\\

namespace Doc 
{
    class Doc         
    {
        DiscordClient discord;
        CommandService commands;

        Random rand;

        string[] MiraiBot;

        string[] randomTexts;

        string[] NGNLWeaponery;

        public Doc() 
        {
            rand = new Random();

            MiraiBot = new string[]
            {
                "Quote", //0
                               
                

            };

            NGNLWeaponery = new string[] //Weapon Stances.
            {
               
            };

            randomTexts = new string[]
            {
                "It is certain",
                "It is decidedly so",
                "Without a doubt",
                "Yes, definitely",
                "You may rely on it",
                "As I see it, yes",
                "Most likely",
                "Outlook good",
                "Yes",
                "Signs point to yes",
                "Reply hazy try again",
                "Ask again later",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and ask again",
                "Don't count on it",
                "My reply is no",
                "My sources say no",
                "Outlook not so good",
                "Very doubtful",

            };


            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '$';
                x.AllowMentionPrefix = true;
            });

            commands = discord.GetService<CommandService>();

            RegisterPurgeCommand();
            Register8ballCommand();
            RegisterngnlCommand();
            RegisterRezeroCommand();
            RegisterHubCommand();
            RegisternoCommand();
            RegisterYesForNGNLCommand();
            RegisterYForNGNLCommand();
            RegisterNCommand();
            RegisterCityHikarizakaCommand();
            RegisterNGNLWeaponeryCommand();
            RegisterCityHubGoodbyeCommand();
            RegisterNewChannelInvite();
            RegisterShutdownCommand();
            RegisterCreateChannelCommand();
            RegisterCoryDotCommand();
            RegisterCityHubKikarizakaGoodbyeCommand();
            RegisterFeedBackCommand();
            RegisterCityElcheaCommand();




            //Logging in.
            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("Token", TokenType.Bot);
            });

        }


        private void RegisterNGNLWeaponeryCommand()
        {
            commands.CreateCommand("~Base_Weapons") 
                 .Do(async (e) =>
                 {

                     int randombasicIndex = rand.Next(NGNLWeaponery.Length);
                     string BasicWeaponeryPost = NGNLWeaponery[randombasicIndex];
                     await e.Channel.SendMessage(BasicWeaponeryPost);
                 });                 
        }

        private void Register8ballCommand()
        {
            commands.CreateCommand("8ball") 
                 .Do(async (e) =>
                 {

                     int randomTextIndex = rand.Next(randomTexts.Length);
                     string textToPost = randomTexts[randomTextIndex];           
                     await e.Channel.SendMessage(textToPost);
                 });                 
        }

        private void RegisterhelpCommand()
        {
            commands.CreateCommand("----")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();

                });
        }

        private void RegisterFillCommand()
        {
            commands.CreateCommand("----")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();

                });
        }

        private void RegisterFillerCommand()
        {
            commands.CreateCommand("----")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                });
        }

        private void RegisterFiller3Command()
        {
            commands.CreateCommand("------")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping(); 

                });


        }

        private void RegisterngnlCommand()
        {
            commands.CreateCommand("---")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();


                });



        }

        private void RegisterRezeroCommand()
        {
            commands.CreateCommand("rezero")
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("`Currently IN PROGRESS.`");


                });



        }

        private void RegisterHubCommand()
        {
            commands.CreateCommand("hub")
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !` !hub General Command + has been used" + "{" + e.User.Name + "}");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("**NGNL + RE : Zero Chapter Bot.**");
                    await e.Channel.SendMessage("NGNL -> No Game No Life <-  ->Starting Life In Another World -> Re:Zero <-");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("__Before Continuing,__ **---> Choose your Timeline. !NGNL Or !REZERO**");


                });


        }

        private void RegisternoCommand()
        {
            commands.CreateCommand("!!no") //For Both, NGNL And RE:ZERO
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("**Recieved** __No__ *as a response. return to hub and choose your TimeLine");

                }); //hit enter 4 times. start with other commands. don't forget re:zero. add buffs,healthbar. and all that.

        }


        private void RegisterNCommand()
        {
            commands.CreateCommand("!N") //NGNL !!N
                .Do(async (e) =>
                {
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("**Recieved** __N__ *as a response. Why would you say No? D:");
                    await e.Channel.SendMessage("Start over at the Hub! Hurry! Your adventure awaits!");

                }); //hit enter 4 times. start with other commands. don't forget re:zero. add buffs,healthbar. and all that.

        }


        private void RegisterYesForNGNLCommand()
        {
            commands.CreateCommand("!yes") //puting prefix inside the "!Example" works. --> so it would be !!Example.
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !` !!yes Response Commands has been used" + "{" + e.User.Name + "}");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("**Recieved** __Yes.__ **NGNL (No Game No Life) for your timeline.**");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Are you sure you want to Continue?");
                    await e.Channel.SendMessage("!!Y Or !!N");

                }); //hit enter 4 times. start with other commands. don't forget re:zero. add buffs,healthbar. and all that.





        }



        private void RegisterCityHubGoodbyeCommand()
        {
            commands.CreateCommand("!![") //puting prefix inside the "!Example" works. --> so it would be !!Example.
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !` !![ Response Commands has been used" + "{" + e.User.Name + "}");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("====================!");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Name :" + e.User.Mention);
                    await e.Channel.SendMessage("====================!! __Narrator__ : *Do Respond to any of this inside the Direct messaging. As that will work!. A Private channel should of or will be created you apon request (untill implemented)");
                    await e.Channel.SendMessage("Thank you for listening *Bows*. Now, Go look for Hiruzen. You will see him around ```Good Luck!```");//Start from here

                }); //hit enter 4 times. start with other commands. don't forget re:zero. add buffs,healthbar. and all that.
        }



        private void RegisterCityHikarizakaCommand()
        {
            commands.CreateCommand("!!Hikarizaka City") //puting prefix inside the "!Example" works. --> so it would be !!Example.
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !`!!Hikarizaka City (Hikarizaka City General) has been used." + "---{" + e.User.Name + "}------" + "----{" + e.User.Id + "}-----");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("*Hikarizaka City (光坂市, Hikarizaka-shi?) is a City in Japan where most of the events of [[[?]]] occur. Although its name is never specifically mentioned.  We can see this because of the numerous establishments and companies which have this name, such as Hikarizaka Private High School or Hikarizaka Electricity. The name Hikarizaka means 'hills of light'. it was constructed on the top of an uneven area, and as a result, walking across the city means constantly climbing small hills such as the one students have to climb every morning. The city used to be small, but time passed and it started increasing in size, making use of all the greenery around it to construct new buildings. [?] believes that this is the cause of [[?]] illness, because of the tight bond she shares with the town.*");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Name :" + e.User.Mention);
                    await e.Channel.SendMessage("The syntax [?] + are currently hidden from your eyes! Cool huh? Later on, you will come back and the characters name will appear! `--> !![ <--`"); //Start from here

                }); //hit enter 4 times. start with other commands. don't forget re:zero. add buffs,healthbar. and all that.
        }


        private void RegisterCityElcheaCommand()
        {
            commands.CreateCommand("!!Elchea City") //puting prefix inside the "!Example" works. --> so it would be !!Example.
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !`!!Elchea City (Elchea City General) has been used." + "---{" + e.User.Name + "}------" + "----{" + e.User.Id + "}-----");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("*Elchea City Elchea (エルキア), or Elkia is the capital of the Kingdom of Elchea, last kingdom of Imanity, and part of the Andalusia continent. [!?] and [!!?] note that the city's architecture and technology appear to similar to those in the early 15th century on Earth, which is towards the end of the Middle Ages and the beginning of the Renaissance. Things and concepts such as the printing press, four-field crop rotation, and treasury bonds have not been invented/discovered, which [!?] then introduces & uses to solve several of Elchea's problems.*");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Name :" + e.User.Mention);
                    await e.Channel.SendMessage("The syntax [?] + are currently hidden from your eyes! Cool huh? Later on, you will come back and the characters name will appear! `--> !!]] <--`"); //Start from here

                }); //hit enter 4 times. start with other commands. don't forget re:zero. add buffs,healthbar. and all that.
        }




        private void RegisterCityHubElcheaGoodbyeCommand()
        {
            commands.CreateCommand("!]]") //puting prefix inside the "!Example" works. --> so it would be !!Example.
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !`!![ (Elchea City Response) has been used." + "---{" + e.User.Name + "}------" + "{" + e.User.Id + "}");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("====================!");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Name :" + e.User.Mention);
                    await e.Channel.SendMessage("====================!! __Narrator__ : *Do Respond to any of this inside the Direct messaging. As that will work!. A Private channel should of or will be created you apon request (untill automatic implementation)");
                    await e.Channel.SendMessage("Thank you for listening *Bows*. Now, Go look for Hiruzen. You will see him around ```Good Luck!```");//Start from here
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Optional : **!feedback ♥(^ω^＼)﻿**");

                }); //hit enter 4 times. start with other commands. don't forget re:zero. add buffs,healthbar. and all that.
        }

        private void RegisterCityHubKikarizakaGoodbyeCommand()
        {
            commands.CreateCommand("![") //puting prefix inside the "!Example" works. --> so it would be !!Example. //!![
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !`!![ (Hikarizaka City Response) has been used." + "---{" + e.User.Name + "}------" + "{" + e.User.Id + "}");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("====================!");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage("Name :" + e.User.Mention);
                    await e.Channel.SendMessage("====================!! __Narrator__ : *Do Respond to any of this inside the Direct messaging. As that will work!. A Private channel should of or will be created you apon request (untill automatic implementation)");
                    await e.Channel.SendMessage("Thank you for listening *Bows*. Now, Go look for Riku. You will see him around ```Good Luck!```");//Start from here

                }); //hit enter 4 times. start with other commands. don't forget re:zero. add buffs,healthbar. and all that.
        }



        private void RegisterYForNGNLCommand()
        {
            commands.CreateCommand("!Y") //puting prefix inside the "!Example" works. --> so it would be !!Example.
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !`!Y () has been used." + "---{" + e.User.Name + "}------" + "{" + e.User.Id + "}");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage(e.User.Mention); //await e.Channel.SendMessage(e.User.Mention); @'s Player who used command
                    await e.Channel.SendMessage("**Recieved** __!!Y.__ **No Game No Life. Is now your selected timeline. Good Luck Out There!**");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendIsTyping();
                    await e.User.SendMessage("Hello!" + e.User.Mention); //await e.User.SendMessage("Hello"); sends user a direct message.
                    await e.Channel.SendIsTyping();
                    await e.User.SendMessage("Am Mirai, and i am your guide! Although i won't be much of a help when you start your timeline ┏༼ ◉ ╭╮ ◉༽┓ You will always meet people on your way that will aid you! **Beware of who you trust, not everyone has a kind heart like myself ୧| ͡ᵔ ﹏ ͡ᵔ |୨** As you progress i will show up and give some helpful advice. Let me also explain that i can interact with you at any time, Try not to message me! Am not giving the a how to list on how do ; do <I said do do> the quest!");
                    await e.User.SendMessage("I am trailing off again aren't i?...  Right, you should first pick where you are starting from! !!!Hikarizaka City Or !!!Elchea City");
                    await e.Channel.SendIsTyping();
                    await e.Channel.SendMessage(e.User.Mention + "Has selected the NGNL (No Game No Life Timeline!");


                });
        }

        public void RegisterNewChannelInvite()
        {
            commands.CreateCommand("----")
                .Do(async (e) =>
                {
                    await e.Channel.CreateInvite(maxAge: null);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("---- : " + "{" + e.User.Name + "}");


                });

        }

        public void RegisterNewChannelInvit()
        {
            commands.CreateCommand("-ci")
                .Do(async (e) =>
                {
                    await e.Channel.CreateInvite(maxAge: null);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("---------" + "{" + e.User.Name + "}");


                });


        }

        public void RegisterShutdownCommand()
        {
            commands.CreateCommand("Shutdown")
                .Do(async (e) =>
                {
                    Console.WriteLine("-----" + "-----{" + e.User.Name + "}" + "{" + e.User.Id + "}");
                    await e.Channel.Client.Disconnect();





                });

        }

        private void RegisterCreateChannelCommand()
        {
            commands.CreateCommand("~CC")
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("--------" + "-{" + e.User.Name + "}" + "{" + e.User.Id + "}");
                    await e.Channel.Server.CreateChannel("RenameTXT", ChannelType.Text);


                });


        }

        private void RegisterCoryDotCommand()
        {
            commands.CreateCommand("---------") //!+Dots Cory dot command.
                .Do(async (e) =>
                {
 
                    await e.Channel.SendMessage(". . . . . . . . . . . .");


                });






            //I Don't know how to do this, am to lazy. Come back in 10+ years.
            //var DiscordClient = new DiscordClient();

            // DiscordClient.UsingAudio(x =>
            //{

            //x.Mode = AudioMode.Outgoing;
            //});

            //var voiceChannel = await(x =>  DiscordClient.FindServers("Music Bot Server").FirstOrDefault().VoiceChannels.FirstOrDefault();

            //var _VClient = DiscordClient.GetService<AudioService>()
            //.Join(voiceChannel);
            //IAudioClient.Join(Channel);




        }
        private void RegisterFeedBackCommand() //rewrite.
        {
            commands.CreateCommand("Feedback")
                .Do(async (e) =>
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("----");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mirai : => !`Feedback (Send's Dm related feedback infomation.) has been used." + "---{" + e.User.Name + "}------" + e.User.Id + "---");
                    await e.User.SendMessage("*We would love to hear from you! Feedback is key, so please give us ideas and* **feedback!~**");



                });
        }

        private void RegisterPurgeCommand() //rewrite.
        {
            commands.CreateCommand("purge")
                .Do(async (e) =>
                {
                    Message[] messageToDelete;
                    messageToDelete = await e.Channel.DownloadMessages(100);

                    await e.Channel.DeleteMessages(messageToDelete);

                    

                });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }

}