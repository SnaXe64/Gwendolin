using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gwendolin
{
    public class Room
    {
        private Player player;
        private ItemManager im;
        
        public string RoomName { get; set; }

        public string RoomDesc { get; set; }


        
        
        public Room(Player p)
        {
            im = new ItemManager();
            player = p;
        }

        public void RoomOne()
        {
            RoomName = "Main floor";
            RoomDesc = "Seems pretty normal here.";
            WriteLine("Right now, Gwen is in the living room of the house, there seems to be a kitchen next to her as well, where should she investigate?");
            WriteLine("1. Stay in Living Room.");
            WriteLine("2. Go to the Kitchen.");
            WriteLine("(Input 1 or 2)");
            string input = ReadLine();
            if (input == "1")
            {
                LivingRoom();
            }
            else if (input == "2")
            {
                Kitchen();
            }
            else
            {
                WriteLine("Invalid input, try again.");
                ReadLine();
                Clear();
                RoomOne();

            }
        }

        public void LivingRoom()
        {
            RoomName = "Living Room";
            RoomDesc = "An ordinary, old fashioned living room.";
            WriteLine("The living room seems very normal, there was a lot dust collected on the furniture and floor which wasn't out of the ordinary.");
            WriteLine($"What should Gwen investigate in the {RoomName}?");
            WriteLine("1. Rocking chair");
            WriteLine("2. TV");
            WriteLine("3. Bookshelf");
            string input = ReadLine();
           
            if (input == "1")
            {
                WriteLine("An old rocking chair, Gwen sits on it and rocks in it for a little bit.");
                ReadLine();
                Clear();
                LivingRoom();
            }
            else if (input == "2")
            {
                WriteLine("A big crt tv, Gwens grandparents still have one that they would watch westerns on. It was strangely way larger than the ones shes seen.");
                WriteLine("Gwen layed her hand on the tv, and something shifted, the front face of the tv was loose, she grabbed it and took it off");
                WriteLine("She revealed a hidden ladder going down below with the tv encasing it, it was a small pit but how did this even fit in here anyway? And for what purpose?");
                WriteLine("Gwen decided to head down the ladder, there must be a reason as to why it was hidden in such a weird way");
                ReadLine();
                Clear();
                Storage();
                //send to next room
            }
            else if (input == "3")
            {
                WriteLine("A tall dusty bookshelf, Gwen took a look at some of the books, most were about carpentry and music.");
                WriteLine("She would take one, but they were way too long for her taste.");
                ReadLine();
                Clear();
                LivingRoom();
            }
            else
            {
                WriteLine("Invalid input, try again.");
                ReadLine();
                Clear();
                LivingRoom();

            }
        }

        public void Storage()
        {
            RoomName = "Storage room";
            RoomDesc = "A narrow storage room.";
            WriteLine("Gwen stepped off the ladder, it led to a small storage room filled handcrafted orchestral stringed instruments.");
            WriteLine("There were many kinds, such as violas, cellos, and some double bass.");
            WriteLine("A door is at the end of the room, it has a heart shaped hole in the middle of it. Gwen tried opening it but it was locked.");
            WriteLine($"What should Gwen investigate in the {RoomName}?");
            WriteLine("1. Door");
            WriteLine("2. Violins");
            WriteLine("3. Heart shaped object");
            string input = ReadLine();

            if (input == "1") 
            {
                if (player.HasItem("Heart Shaped Object"))
                {
                    WriteLine("Gwen inserted the Heart shaped object into the slot, at first nothing happened, but then there was a loud click noise.");
                    WriteLine("She tried opening the door, and it was unlocked! 'What a weird way to open a door.' Gwen thought");
                    ReadLine();
                    Clear();
                    //nextroom
                    DisplayRoom();
                }
                else
                {
                    WriteLine("Gwen walked up to the door, the door was painted neatly. The hole in the door is shaped like a heart.");
                    WriteLine("Maybe there's a heart shaped object around the room somewhere...");
                    ReadLine();
                    Clear();
                    Storage();
                }
                
            }
            else if (input == "2") 
            {
                if (player.HasItem("Heart Shaped Object"))
                {
                    WriteLine("It seems like the violins weren't damaged from the fall, except of course for the heart piece Gwen picked up.");
                    ReadLine();
                    Clear();
                    Storage();
                }
                else
                {
                    WriteLine("Gwen inspected the 4 violins below her, each one was had different colors and shapes on them.");
                    WriteLine("While looking closely, Gwen lost her footing and bumped into the first violin, causing them to domino and all fall over.");
                    WriteLine("Gwen panicked at first, trying to save them from falling, but she was not successful.");
                    ReadLine();
                    Clear();
                    WriteLine("The final violin hit the ground and a piece of it flew out on the ground, it was a small, heart shaped object.");
                    WriteLine("Gwen was stunned, she did just knock over a bunch of nice instruments, but it looks like she found a way out!");
                    ReadLine();
                    Clear();
                    Item i = im.CreateHeartObject();
                    player.AddItem(i);
                    string asciiArt = @"
                                                                                                  
                                                       ....'',;cok0kc.                              
                                                     ,xO00KK0K00kolkX0l'                            
                                  ..,;,.           .lKKxc,......   .,dKKx;.                         
                             .,coxO0KKXKOo;.     .;dX0occ'       .'.  .ckXO:.                       
                         .:okOOkoc;'..':dOX0d:. 'kNNOl:cdk:      .l'     :KK;                       
                        c00o:'.          .,lk0KO0WMKo:::cx0l.    'o'     .xNl                       
                       .kNd;.                .,dXMMWkc:::ckK;     .      .dNl                       
                       .kNxodc'          .....',c0WWKo:::l0k.            .xWd.                      
                       ;KKl:coxdc.   .cdddddddo:..;;::c::co;              ,0K:                      
                      ;0Nxc:::cokOxod0Oc..           ;xOk;                 ,00,                     
                     ,0Nkc:::::::lxOk:.               .oK0,              .. cXd                     
                    .xW0l::::::::col.   .:c;.          ;0k.            .;;. :Xx.                    
                    .xMXoccc::::lxo.     'co:         .dO'   .',.    .cl,   lNo                     
                     lWNxcdxoccxOl.         .':ool:,.  ..      ;l;  .cl.   .xX:                     
                     ;XMOccodx00:       ..;coxxddkOOOxo:.       ;Oo.       .O0,                     
                     '0MKo:::dKx.     .,clolc::::::codOXx.      '0O.       ,Kk.                     
                     .xMNd:::ck0:    .,:::::::::::::::ckXl      '0O.       :Xd.                     
                      lWWOc:::l0k.  .:c::::::::::::::::l00,     '00'       oNl                      
                      ;KMKl::::dKl  ;xo:::::::::::::::::dKd.    .O0,  'od,'OK;                      
                      .kMNOoc::ck0; :Oo:::::::::::::::::cx0d'  .cK0:..ld;.oNk.                      
                       'xNWNOdc:lO0oodc::::::::::::::::::co0O,.l0Oo:'    ,KXc                       
                         ,o0WWKxllx0XOl:::::::::::::::::::ck0; .,:::'   .xWk.                       
                           .;d0NXOxdOXOc:::::::::::::::::lO0:   ,xxo:. .dNX:                        
                              .;d0NNXNNxc:::::::::::::::d0k,     ;kxoodOWNo.                        
                                 .,lONWXOoc::::::::::::dKd.       .lKWWXk:.                         
                                    .,o0WN0xlc::::::::cOX:        ;KMXl.                            
                                       .:kXWX0xoc::::ccxXd.      ,0MNc                              
                                          'lONWN0kkkO0KXN0c'.   .OWNl.                              
                                             'ckXNWNKkdodOXXKxlckWXl                                
                                                .',..     .:d0NWWXl.                                
                                                             .';;'                                  
                                                                                                    
";
                    WriteLine(asciiArt);
                    WriteLine($"Gwen got the {i.Name}");
                    ReadLine();
                    Clear();
                    Storage();
                }
            }
            else if (input == "3") 
            {
                if (player.HasItem("Heart Shaped Object"))
                {
                    WriteLine("In the back corner of the storage room were muliple shaped wooden carved objects. Spades, clubs, diamond, and hearts, all of there were card shapes.");
                    WriteLine("Gwen took on of the heart objects and took it to the door, 'this probably fits right into the door!' Gwen thought.");
                    WriteLine("However, it did not fit into the door, it was too big for it. The heart object she found looks like it will fit though.");
                    ReadLine();
                    Clear();
                    Storage();
                }
                
                else
                {
                    WriteLine("In the back corner of the storage room were muliple shaped wooden carved objects. Spades, clubs, diamond, and hearts, all of there were card shapes.");
                    WriteLine("Gwen took on of the heart objects and took it to the door, 'this probably fits right into the door!' Gwen thought.");
                    WriteLine("However, it did not fit into the door, it was too big for it. There must be something else here that can fit in there...");
                    ReadLine();
                    Clear();
                    Storage();
                }
                
            }
            else
            {
                WriteLine("Invalid input, try again.");
                ReadLine();
                Clear();
                Storage();
            }
        }

        public void Kitchen()
        {
            RoomName = "Kitchen";
            RoomDesc = "A neat, and slightly overgrown Kitchen.";
            WriteLine("The Kitchen is neatly organized, many appliances are stored well. Some vines from the window have grown into the house.");
            WriteLine($"What should Gwen investigate in the {RoomName}?");
            WriteLine("1. Knife block ");
            WriteLine("2. Sink");
            WriteLine("3. Pantry");
            
            string input = ReadLine();

            if (input == "1")
            {
                WriteLine("A block full of varios different Kitchen knives, might not be a bad idea to take one with you, who knows what's in this house.");
                ReadLine();
                if (player.HasItem("Knife"))
                {
                    WriteLine("Gwen didn't need another knife, she felt content with just one.");
                    ReadLine();
                    Clear();
                    Kitchen();
                }
                else
                {
                    //I mentioned in the Player class that i had my friend help me out with this. He has a lot of programming knowledge and walked me through and let me try to figure things out on my own.
                    Item i = im.CreateKnife();
                    player.AddItem(i);
                    string asciiArt = @"
                                                                                                    
                                                                                .;c'                
                                                                              .:l';:.               
                                                                            .:dc. 'c.               
                                                                           ,dd'   ,l.               
                                                                         .dkc.    ;l.               
                                                                       .l00l.     :c                
                                                                      ;OKkol;.   .l:                
                                                                    'xX0dllll;.  .o,                
                                                                  .lKKxollllll,  ;o.                
                                                                .:O0l:lllllllll'.lc                 
                                                               ,xKd. .;llllllllcox,                 
                                                             .oKKl.   .cllllllloOo.                 
                                                           .:00l;:.   .;lllllllxO;                  
                                                          ,kKx' .::.   'cllllloOo.                  
                                                        .oKO;    'c,   .:lllllxO,                   
                                                      .:0Kl.     .:c.   'lllldOo                    
                                                     ,kXx'        ,l;   .:llokk'                    
                                                   .oKO:          .:c.   'llx0c                     
                                                .:x0Ko.            'l;.  .:o0x.                     
                                               ,kXXk'              .:c.   ,kO,                      
                                             .oK0:..                'l;.  ;Ol                       
                                           .c0Xo.                   .:c. .dd.                       
                                          ;ON0;                      .c;.lx'                        
                                       .,ok0N0c.                      ;lxk,                         
                                     'lxdllodkXKd;..                  .d0:                          
                                  .;x0x;  .;dxdkXNX0l.                ;kc                           
                                .:OXk,      .:dxxxk0NXd,             ,kl                            
                              .c0Xk;   ..      ,oxddoONNk:.         ;kl.                            
                            .c0NO:.  .lKO'     .,xKXOddx0NOc.      cOl                              
                          .:ONKc.    .oo,   .ck0Oxol,.  .:xKOc.  .oOc                               
                         ,kNXo.            ;0Xx;.          .cxxccOO;                                
                       .oXNk,            .dXKc.               .cxd'                                 
                      ,OWKc.           .cKNx'                                                       
                    .lXWk'  ,c,       ;ON0:                                                         
                   .dNNd.  ;KMK:    .oXKl.                                                          
                  .xWXl.   ;xo;.   ;OXx'                                                            
                  oWWo          .:kKk;.                                                             
                  lNW0:.     .:d00d;.                                                               
                  .:kXNKkdodkOko;.                                                                  
                     .:loolc,.                                                                      
                                                                                                    
                                                                                                    
";
                    WriteLine(asciiArt);
                    WriteLine($"Gwen got the {i.Name}");
                    
                    ReadLine();
                    Clear();
                    Kitchen();
                }

                
            }
            else if (input == "2")
            {
                WriteLine("The sink is filled with dirty water, and Gwen doesn't look to eager to touch it.");
                WriteLine("Gwen opens the cabinet below the sink, revealing thick vines covering up a passage of some kind, might need something to cut these away...");
                if (player.HasItem("Knife"))
                {
                    //next room
                    WriteLine("Gwen takes the Knife and starts cutting away at the vines.");
                    WriteLine("She finished cutting through the uncomfortable corridor, and found herself in a new room.");
                    ReadLine();
                    Clear();
                    Workshop();
                }
                else
                {
                    Kitchen();
                }
                
            }
            else if (input == "3")
            {
                WriteLine("Gwen looks through at the open pantry, there's some canned pinapple, an absurd amount of canned pinapple.");
                WriteLine("Gwen likes pinapple, but knows that they are probably way over their expiration date.");
                ReadLine();
                Clear();
                Kitchen();
            }
            else
            {
                WriteLine("Invalid input, try again.");
                ReadLine();
                Clear();
                Kitchen();
            }
        }

        public void Workshop()
        {
            RoomName = "Workshop";
            RoomDesc = "A small workshop, it seems it was used quite often.";
            WriteLine("Gwen was now in what appeared to be a workshop, a lot of dust and wood scraps were strewn about.");
            WriteLine($"What should Gwen investigate in the {RoomName}?");
            WriteLine("1. Workstation");
            WriteLine("2. Boarded wall");
            WriteLine("3. Toolbox");
            string input = ReadLine();

            if (input == "1")
            {
                WriteLine("Gwen decides to look at the workstation, there are some wood carvings of instrument parts.");
                WriteLine("Additionally, there is a framed photo of a kid named Arthur.");
                WriteLine("Gwen realized, 'Hey, my dads name is Arthur... Is this what he looked like when he was younger?");
                ReadLine();
                Clear();
                Workshop();
            }
            else if (input == "2")
            {
                WriteLine("There is a wall with thin wood planks nailed to it. There are small openings where the wood doesn't line up");
                WriteLine("Something is definetly behind that wall Gwen thought, but how would she reach it, if her dad was here, he could totally punch through that wood");
                if (player.HasItem("Big Mallet"))
                {
                    WriteLine("Gwen gripped the mallet firmly in her hands, she was going to try to smash the wood planks in her way.");
                    WriteLine("Three...Two...One!");
                    WriteLine("She swung with all her might, and with a CRASH and a THUNK, the wooden planks were no more!");
                    ReadLine();
                    Clear();
                    //next room
                    DisplayRoom();
                }
                
                else
                {
                    ReadLine();
                    Clear();
                    Workshop();
                }
                   
            }
            else if (input == "3")
            {
                

                WriteLine("A big red toolbox caught Gwens attention, she opens it up and sure enough there are a various tools inside.");
                WriteLine("Hammers, mallets, saws, screwdrivers, chisels, anything a craftsman would want is in this toolbox.");
                if (player.HasItem("Big Mallet"))
                {
                    WriteLine("Gwen had a big mallet, what more could she possibly need?.");
                    ReadLine();
                    Clear();
                    Workshop();
                }
                else
                {
                    WriteLine("Gwen remembers what her father told her 'I always have my mallet with me, gets me through all my problems'");
                    WriteLine("Gwen decides to take the big mallet.");
                    ReadLine();
                    Item i = im.CreateMallet();
                    player.AddItem(i);
                    string asciiArt = @"
                                                                                                    
                                                                                                    
                                                          .:lddxdoc;.                               
                                                       ,lxkxdlcccodxxdl,.                           
                                                     ;xkdc,''''''.....cxko'  ,:,.                   
                                                   .dOo,'''''''..       'oOkxkkOOd,                 
                                                 'lxk;''''''''.           .cO0dclkKd.               
                                                .dNk;'''''''..              .:O0dcOXc               
                                                'ONd'''''''..                 .:OKXx.               
                                                .xNk;''''''.                    .l0k,               
                                                 ,dko'''''..                      .d0o.             
                                                   ;xl,'''.                         ;OO;            
                                                    ,xd;'.                           .xK:           
                                                     .dkl'                        .;ld0W0'          
                                                       :kx,                    'lOXXOxOWO'          
                                                       ,dkko'                ,xXXkc'.:KK:           
                                                     ,oo' .lko,            .dXKo'  .dXO,            
                                                  .;dx:.    .o0Oc.        'kXd'  .:OOc.             
                                               .;x0kc.      ;xxloxdc.    .kKc  .cxx:.               
                                             .:kOl,.      'xk:.  .;oxxo:,dXx:cdxo,.                 
                                           .lOOl.       .lOl.        .:ldk0kdc,.                    
                                        .;d0kc.        'xk,               .                         
                                      .lOKx,.        .lOo.                                          
                                   .;xK0d,          ,xk;                                            
                                 'lOKOl,.        .;oOl.                                             
                               ,xKKx:''.       .ckOd'                                               
                            .:kX0o;''...      ;kk;.                                                 
                          .:OXOl,'.'''.     ,xkc.                                                   
                         :OXOc,'''''''.   'dOl.                                                     
                       ,kXOc,'''''''''...oOo.                                                       
                     .dK0l,''''''''''':xOd'                                                         
                   .c0Kd;'.'''''''',ck0d'                                                           
                  'kXk:'''''''''',lO0o'                                                             
                 :00l,'''''''',:dOOl.                                                               
                .xO;'''''''';oO0x:.                                                                 
                 :Od;'''';lk0Ol'                                                                    
                  :0Ol:ok0Oo,.                                                                      
                   'd0Oxl,.                                                                         
                     ..                                                                             
                                                                                                    
";
                    WriteLine(asciiArt);
                    WriteLine($"Gwen got the {i.Name}");
                    ReadLine();
                    Clear();
                    Workshop();
                }
                
            }
            else
            {
                WriteLine("Invalid input, try again.");
                ReadLine();
                Clear();
                Workshop();
            }      

        }

        public void DisplayRoom()
        {
            if (player.HasItem("Arthurs Violin"))
            {
                WriteLine("The sheet music was simple for Gwen to understand. (UP, UP, RIGHT, DOWN, LEFT, UP, RIGHT)");
                WriteLine("(8 = UP, 6 = RIGHT, 2 = DOWN, 4 = LEFT)");
                ReadLine();
                string input = ReadLine();

                if (input == "8862486")
                {
                    //End Game
                    EndGame();
                }
                else
                {
                    WriteLine("That didn't sound quite right, Gwen tried again.");
                    ReadLine();
                    Clear();
                    DisplayRoom();
                }
            }
            else
            {
                RoomName = "Display Room";
                RoomDesc = "A dark, ambient room with display cases of unique looking instruments.";
                WriteLine("Gwen now found herself in a display room, it was dark, but there were a few lights over stands that held unique looking Instruments.");
                WriteLine($"What should Gwen investigate in the {RoomName}?");
                WriteLine("1. Cello");
                WriteLine("2. Violin");
                WriteLine("3. Viola");
                string input = ReadLine();

                if (input == "1")
                {
                    WriteLine("Gwen walks up to the Cello, it's highly detailed, made of wood, and painted in blue with yellow highlights");
                    WriteLine("There is a small card next to it, it reads:");
                    WriteLine("'For our good friend Chris, he is a fantastic Chello player, and like a brother to me! Thank you for being there for me Chris.'");
                    WriteLine("Next to the writing is a picture of two men with their arms hung around each other.");
                    ReadLine();
                    Clear();
                    DisplayRoom();
                }
                else if (input == "2")
                {
                    WriteLine("The Violin seemed to have the most complex design of the three, it had odd curves on each side that jutted outwards. It was also painted in yellow and white.");
                    WriteLine("Beside it was a birthday card, adressed to Arthur, it read:");
                    WriteLine("'Happy Birthday Arthur! For your 10th birthday, we wanted to do something extra special, so we made you this Violin! We hope you like it! Love, Mom and Dad (Bob and Susan)'");
                    WriteLine("Arthur was the name of Gwens dad, was this violin for him? Gwen remembered her dad saying he never played an instrument before.");
                    ReadLine();
                    WriteLine("Gwen noticed a small strip of paper where the card was standing before, it was a small snippet of sheet music.");
                    WriteLine("Seeing as there was not much else to do, Gwen decided to pick up the Violin and try playing the song");
                    ReadLine();
                    Clear();
                    Item i = im.CreateViolin();
                    player.AddItem(i);
                    string asciiArt = @"
                                                                                                                                                     
                                                                                                                                                      
                                      ';.                               .                                                                             
                                      lXd.                             ,:                                                                             
                    ....              :XNx,                           ,OO'                                                                            
                  .clc:;;.  ..'''..   .kKkdl;..                       .xO,                                                                            
               .';lxl.  .;cc:,'.';:.   'k0o:::cccc::,'.                .'                                                                             
              ,c,...;o:. ';.   .'..     .ckko;...',;:clol,.                                          ..                                               
             'c.     .oc     .c;           'ck0xol:'.  .:dx:.                                        .lc                                              
             :l;;:c,  ;d:'';lo:....          .coccoddc.   ;xd'                                       .kXl.                                            
            .ll,...   :kxkkko,.,ooc,           .;'  .,;'   .lx:                                     ,xNMWk:.                                          
           .:,    ...:xd:;;:cc:'.;l:.            ';.   .''.  'll,.                                .o0NMMMW0;                                          
           ';..:c:::coxdc:;:clodc,,c:',;.         .','   .,,.  'ldc.                               ..,dXNd.                                           
           .:codl...'',lkkxdodxxxxl:oo,:d,           ';,.  .,;'. .cdo;.                                l0;                                            
            lkc:oc,:l;  .cOX0kxxkkOkxx:'o;             .;;.  .,:;. .,ldl,.                             'd,                                            
            .o;  .:;,,'.  .c0N0kkO0KKN0o,                .','.  .;:,. .;llc:,.                          .                                             
             .;;,;'   .,,...;kXK0kkO0KX0c.                  .''.  .';;,. .,:clc;.                                                                     
                .   ',',colc,,xXKKOkkO0KXOc.                  ..,'.  .,;;,.   ':llc,.                                                                 
                   ;l.  .:ll; ,O00K0OxkO0KXOc.                   .'''.  .,;:;,.  .;lll:'.                                                             
                   'c,..;d:.c;..:dOKK0kxkO0KXO:.                    .',,.   .';;;.   .:lol:'.                                                         
                    .',;:'  .;c:c'.cOK0OkxxO0KXO:.                     .',,'.   ';;;'.  .':looc,.                                                     
                              ..    'd00OkxdxO0KXO:.                      ..',,..  .,;;;.   .':lool:'.                                                
                                      ;kK0OkddxO0KXO;.                        .',,'.  .';;;,.    .;lodol;'.                                           
                                       .lO0OkxddxO0KXk;            .c:.           .'''..  .';;;,.    .':odddo:,.                                      
                                         'd00kkxddxk0KXk;          'xd.              .',,'.   .';;;,..    .':oxkkxoc;'.                               
                                           :k0OkxxdoxkOKXk,         ..                   .',,'.   ..,,,,'..    .':oxO00Oxoc;'.                        
                                            .o00OkxdooxkOKXx,                               ..,,,'.    .....,clc;'. ..,:ldkkOOOkxol:.                 
                                              ,x0OkxddodxkOXXx,                                 ..,,,,..     ,lOKklcc:,.    .xKkxxkKO'                
                                               .:O0OkxddooxkOXXx,                                    .,,;;,..  .,:c:,,cxxc;;c00ollo0k'                
                               .l'               .o00kxddoodxk0XXx'                                      .',,,,,'';oc  ,xc.':lllddoc.                 
                               ,0x.                ,kKOkxddoodkk0XXd::lodxxxxxdol;.                           ..',:ll::cc.                            
                              .dWXc                 .c0KOkxddoodkO0NWXd;......,;cdxxo,.                 ...         ...                               
                             .dNMM0,                  .dK0kkdodooxkO0NXd'          'lkk:.             .okkkkdl;.                                      
                           .l0WMMMW0:.                  ;OKOkxdodooxOOKNXo.          .ckd'            .ld;',:ldxxo;.                                  
                         .cKWMMMMMMMNO,                 .oO00kkxdodooxOO0NKOo.         .lk:            .dl      .:dxo,                                
                          'dKWMMMMMNOo'                ,xl..dKOxkxoodookOO0XNKl.         ;ko.           :k,        .cxd;                              
                            .dNMMNx'                  :Oo.   ,k0kxxdoddookOOOKN0:.        .ldoc,.       ,Oc           ;dd,                            
                             .dWNo.                  :0x.     .cO0xxxdoddldxkOOKXk,         .,lkx,      ,Oc            .ckl.                          
                              ;XK,                  ,00'        .o0kdxxooddoldkkONXc         ;l:.       ck'              ,Ok'                         
                              ,0k.                 .kNl           'dOxdxxooxxdkKK0koc.      ;0l        'x:                ,00;                        
                              .c:                  lN0'             ;xkddkxxOK0x,;lccl:.  . .kk,     .:d;                  cXO'                       
                                                  .OMx.              .cOO0XK0o';c'.;cccloOkc''cdolccloc.                  .cKNl                       
                                                  ;XWd                 .lo'..::..:c'.;c:lOk;,;...,:;'                  .;dkkkOx'                      
                                                  lWWd                        'c:.'cc..;::cc;';,.    ';.              ,k0xl:;cko.                     
                                                  oWMk.                         ,c,.'lc..;:;cl:::cc,.oXKl.          .lKkl:;:;;dk'                     
                                      .cx:        oNWK,                       ,ddocc'.,l:..,;;cllOWk'.;kO'         .oKkc:;;;;;oO;                     
                                      :0Xd.       cKXNd.             ...      lKx,..::..;l,..:''cc;;,;cc,          lXkodc;;:;;oO:                     
                                       ':.        ,O0KK;          .:xxxdoc.   .:l'   .c:..;;..;,':;               ,00oxd:;;;;;o0c                     
                                                  .x0kXO'        .x0dc:::odd:   'lc.   ,l, .;..';,lolll;.         oXxloc;;;;;;d0:                     
                                                   :0xxXk.      .x0dodol::cod:    ,l:.  .:;..;,'oOO0Odldd'       .OKo:::;;;;;:k0,                     
                                                   .d0oxXk.     lX0xc::codc;od.    .:o'   ,:.,xKOxxdddlcxO:      .OXo:c:;;:;;lKO.                     
                                                    .kkldKO,   '0Xl.    .lxdkd.      cd.   ,k0xodocooll::x0l.    .dNxcl:;;;;cOXl                      
                                                     'kkco00:  cKl      .cOKk,  .lOc.,k:   ;kxoccoo:::;;;:d0o.    :K0l::;;:lOXd.                      
                                                      'xxcck0d'ok.    'xOl'.     ,xkodo.    ,oxo::::;;;;;;:d0o.    lXOl::lxKKo.                       
                                                       .dkc:oO00l     l0Okc'.      ...       .:ddc:;;;:;;;;:d0l.    ;k00KK0d'                         
                                                        .lxl::xK:    .dOldKXk.                 .lkxc:;;;;;:;:d0l    .lXMKc.                           
                                                          ,ddcd0:    .xOc:oOKO'                  'okdc;;:;;;;:d0c  'xNW0;                             
                                                           .cx0K:     ,dxdc:oKO,                   ,xOd:;:;;;;:xOodXMNx'                              
                                                             .ox,       ;k0kooK0:                   .:kkl:;;;::dXWMWKc.                               
                                                                         .dX0dlOKx'                   .lOxc:lx0NWWXd.                                 
                                                                          .,o0xcoO0d;.                 .:0KKXNNWXd'                                   
                                                                            .c00oclxOOxdl:;'......',:ldk0KKKKX0o'                                     
                                                                              'd0Oo::coxkOO00OOOO0000OkkkO00kc.                                       
                                                                                'd0Oxl::;;::cccccccclokO0xl'                                          
                                                                                  .:dkkkxdolllllodxkkxl;.                                             
                                                                                     .';cllllllcc:,'.                                                 
                                                                                                                                                      
                                                                                                                                                      
                                                                                                                                                      
";
                    WriteLine(asciiArt);
                    WriteLine($"Gwen got {i.Name}");
                    ReadLine();
                    WriteLine("The sheet music was simple for Gwen to understand. (UP, UP, RIGHT, DOWN, LEFT, UP, RIGHT)");
                    WriteLine("(8 = UP, 6 = RIGHT, 2 = DOWN, 4 = LEFT)");
                    
                    
                    input = ReadLine();
                    if (input == "8862486")
                    {
                        WriteLine("You played the Melody successfully!");
                        ReadLine();
                        EndGame();
                    }
                    else
                    {
                        WriteLine("That didn't sound quite right, Gwen tried again.");
                        ReadLine();
                        Clear();
                        DisplayRoom();
                    }




                }
                else if (input == "3")
                {
                    WriteLine("The Viola had an interesting tip to it, it was shaped like a sunflower, and had wood carved leaves running down it.");
                    WriteLine("It had a note beside it, it read:");
                    WriteLine("'To my Mother, you were everything to me. Like a sunflower, you bloomed brightly, and shined into everyones hearts, including yours truly: Susan.");
                    WriteLine("There was a portrait next to the note of a Woman with a sun hat. She seems very happy in the picture.");
                    ReadLine();
                    Clear();
                    DisplayRoom();
                }
                else
                {
                    WriteLine("Invalid input, try again.");
                    ReadLine();
                    Clear();
                    DisplayRoom();
                }
            }

            
        }

        public void EndGame()
        {
            WriteLine("There was a click, then suddenly, a hidden door slowly revealed itself and slid open.");
            WriteLine("On the other side was an outlook of the backyard through a window, in front of it was a pretty looking jar.");
            ReadLine();
            WriteLine("There is a plaque on the vase, it read:");
            WriteLine("'Here lies Bob Lyn and and Susan Lyn, parents to Arthur Lyn and friends to all.'");
            ReadLine();
            WriteLine("Gwen stood at the vase for a bit.");
            WriteLine("However, she was interupted when she heard a loud CRASH sound behind her, followed by a 'AAAHH, God Damnit! Stupid secret passages, why did they have to-");
            WriteLine("That voice was very familiar, she turned around, and it turned out to be her dad, rubbing his back after what looked like him falling over.");
            ReadLine();
            WriteLine("'Gwen! There you are! You can't just run away like that, I am not used to that kind of stress.' Gwens dad said");
            WriteLine("Gwen ran up to hug her dad 'I'm sorry, my curoisity got the better of me, but I should have just waited until tommorrow.'");
            ReadLine();
            WriteLine("'Well, I wasn't planning on showing you all this, but you saw it anyways.'");
            WriteLine("'Why not? I thought it was really cool. So this is really your parents house right?'");
            ReadLine();
            WriteLine("'Yup, everything here was made by my mom and dad, the instruments, the secret tunnels, basically the whole house itself.'");
            WriteLine("'That includes this right?' Gwen shows her dad the Violin she picked up.");
            ReadLine();
            WriteLine("'Ah yes, I got this when I turned 10, I could never play it like they could.'");
            WriteLine("'What do you mean?'");
            ReadLine();
            WriteLine("You see, my parents not only crafted beautiful intruments, but also played them beautifully. And I wanted to be just like them.'");
            WriteLine("'What happened? Did you not practice enough?'");
            ReadLine();
            WriteLine("'Hehehe, I guess so, My parents tried all they could to teach me, but it just never clicked fast enough for me, and I gave up way too early.'");
            ReadLine();
            WriteLine("They sat there for a little bit, til Gwen exclaimed 'It's never to late to pick it back up again!'");
            WriteLine("'Huh? You want me to try playing again?' Gwens dad said with a puzzled look on his face.");
            WriteLine("'Why not? It's never too late to learn!'");
            WriteLine("'I guess not no, sure why not lets give it a shot'");
            ReadLine();
            Clear();

            WriteLine("Gwen ran back to their house with her dad, barely keeping her excitement.");
            WriteLine("'If I can teach you more about playing the violin, you gotta tell me more about your parents!' Gwen said");
            WriteLine("'Haha, sure thing kiddo, let's eat dinner first though, i'm starving!");
            ReadLine();
            string asciiArt = @"
 .---. .-. .-..----.   .----..-. .-..----. 
{_   _}| {_} || {_     | {_  |  `| || {}  \
  | |  | { } || {__    | {__ | |\  ||     /
  `-'  `-' `-'`----'   `----'`-' `-'`----' 
";
            WriteLine(asciiArt);
            ReadLine();
            
            

            
        }
        

    }

}
