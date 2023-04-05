using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Gwendolin
{
    public class Game
    {
        private Room MyRoom;
        private Player MyPlayer;
        
        
        
        //Was going to have a command that the player could input to display invenotry, but there were only a few items so not very necessary
        /*public void CheckInventory(string item_name)
        {
            if (MyPlayer.HasItem(item_name))
            {
                WriteLine("You have the " + item);
            }
            else
            {
                WriteLine("You do not have the " + item);
            }
        }*/

        

        public Game()
        {
            MyPlayer = new Player();
            MyRoom = new Room(MyPlayer);
            
            //start game
            StartGame();
            //introduction
            Introduction();
            //Start the rooms
            StartRooms();
            //end game


        }
        public void StartRooms()
        {
            
            //How to call a method from a different class?
            //Prof helped me figure it out, thank you!
            MyRoom.RoomOne();
        }

        public void StartGame()
        {
            string asciiArt = @"

 .---. .-. . .-..----..-. .-..----.  .----. .-.   .-..-. .-.
/   __}| |/ \| || {_  |  `| || {}  \/  {}  \| |   | ||  `| |
\  {_ }|  .'.  || {__ | |\  ||     /\      /| `--.| || |\  |
 `---' `-'   `-'`----'`-' `-'`----'  `----' `----'`-'`-' `-'

";
            WriteLine(asciiArt);
            WriteLine("Press 'Enter' to begin");
            ReadLine();
            Clear();

        }

        public void Introduction()
        {
            WriteLine("A young violinist named Gwen is practicing for her recital when she overhears her dad talking about something peculiar on the phone.");
            WriteLine("When he was done talking, Gwen asked him about it. Her father told her he was talking about an abandonded home possibly belonging to their family.");
            WriteLine("Gwen exclaimed she wanted to see it, but her father said it wouldn't be possible that day.");
            WriteLine("Press 'Enter' to continue");
            ReadLine();
            Clear();
            WriteLine("Gwen told her father she was going to practise outside, she grabbed her violin, went out to their backyard, carefully climbed over the fence and headed torwards the location of the house.");
            WriteLine("Press 'Enter' to continue");
            ReadLine();
            Clear();
            WriteLine("The location wasn't very far from her house, and only took around 30 minutes for her to stumble upon it");
            //I had Chatgpt help me for the code to display the art.
            string asciiArt = @"
 ..                                                                 ..                                                                                                                                  
..                                                                  ..     ..                                                                                                                           
..                                                                 ..      .'.                                                                                                                          
'.                                                                 '.      .;'                                                                                                                          
'                                                                 ''        ;:.                                                                           .,.                                           
,.                                                               .'         'l,                                                                           .;;.                                          
,.                                                              ..           .,'                                       ''                                 ..'.                                          
.,                                                            .'.              .,.                                     ...                                ...'                                          
 ,.                 .                                        ...                .,,....                                ....                               .. '.                                        .
 .,.              .''.                                     ...                     .:c;.        ''                    ..  ..                             .'. .,.                                       .
  .,.            .'...                                  ..'.                       .;oc'       .,,.                   ..   ..                            ..   .,                                     .,.
   .,.           ,.  '.                               .';:;...                   ...:c,.      .'...                  .'.    ..                          ..     ',                                    '' 
     .'.       .;'   .,                             .;c:;;'.                        .'.      .'.  '.                 '.      ...                      .'.       ',.                                ',.  
      ..'.    .:'     ,,                          .';,.                              .'.    ...    ';.              '.         ...                   .,.         .;.                              ,l.   
       .;'   ':.       ,;.                    ..'''.                                   ',. ..      .',.           .'.            ....              .''            .,,.                           .,.    
 .....;;.  .;;.         ,;.               ..'''..                                       .';,.        .;,         .'.               .,,.'.         .'.               .,'.                    .....:,.... 
 ','...  .,:.            .:'              ':,'.                 ..                         .'''...    .;;.      .'.             .....  ''       .'.                   ..,'      ........................
  ..   .,:'               .,;'              ,c.     .''.    ...''.                            .......'';lo:.   ..            .....  ....      .'.       .'.           .,,.     .,....                 .'
   ..':c,.                  .,;'           .,'.....,lddc,......                          ..'::'......,c,...''...         ...... ...',..      .,',,.  ...',.      .....,'.       .,:,,'....''..........''
     ;xc.             .'..   ..c;    ;;            .,,'.                                .',','..........,:,;l:..,'.........  ..... .........  ...::'...               .           .,:,....'........'.'. 
      .,,.             .;;,;ol,'.   .;:'       ....                                       ........     ..;'  ......''..  ..''..    .'.. .,;.     ...                 ..            .'    ..  .....,,.   
        .','....           .''     .,..;,  ......                                             ......',:,..,.  ';,'..  .......      .;;;,..      ..                   .'.           ''.......... .',.    
           .,;'              ..   .'.  .,;';c;.  .      .    ..                              .....';,'.   'c:;,.  ......   ..      .'..'.    .''.                     .'           '.        ..  .,.    
             .::;'.           ''  ..     .,;:;'.,:'....'''....                               .......   ..''..  .....       .'      .'   .'''''.                        ';.         ''.......... ..,.    
             .;dko;.           ';.         .''''..                                                ..''''.  ..''..       ...',.     .,  .,::,.                          .:c.        '.   .'.    ...,.    
   .,.    .,,';ol.              .;,.          ',.                                              .'''...  ..''.       ....   .'.     .,. .,,,;:'.........                  ...'.    .,'..........''';.    
  ..',,;;',lc....                 .,,'..   ....                                            ..'''.  ...'''.         ..      .,.     .;.    ';'..      .                      .::.  .,'',. ..''....';.    
       .,,..                        ..';,....                                           .'''.   .''''..                    .,.     'c'..,cc,........;ccc:,..................,;'...';',,....,'....';.    
        ..                         ......                                      .    ..''..  ..'''.       ....              .;.     'c,..''..........'''''.........................'''''...'''...........
      ...',.                   .......     ......                               .,;,'.   .','..       .....                .,.     .:'......''....''''...''''.........................................  
       .';:'                .,;,..  .';ldxxxxxxkkkxoc'.                      ..''..  ..,,'.      ......             ...    .,.     .;.  ....;,.....;;.....;;................';'....','..............,,..
         ...                 ..':::oxxdl:,.......';lxOOd;.                ..'..   .',,'.       ...                ..       .;.     .;       ',.....'.     ..                ...    ..               '.  
          .'.         ..       .lOxc.                .;dOOo.          ......  ..','.                                       .;.     .;.       .;cc;..      '.                 ...''..                '.  
            ',.        ......'lkk:.                     .cOKo. .,....'..   .',,'.     .....     ..........               . ';.     .;......   ,o:'...''''',,'''',,''. .',,,,,,,;::,,,,',,.      .'',:,..
             .,.          .cok0l.                         .l00lcl;..    .'''.      ....     ..''...........''.       ....  .,.     .,         ,c;.                        .'...;:'........      ........
              .,,.      .:xl:c,                           .';oKKk:.....'..     .....      .,,.......   ...  .',.......     .,.     .,         .cl;                         .   ,c:.                     
                .,'.   .ox,  .                             .;,,xKx,.;,      ....         ';. .'.. .'. .. ...  .,;.         .,.     .,         .,,,.                            .,,.                ...  
   .              .',..ox.                                  .cdd:.  ,.  .....           ,;..'.    .,. ..    ..  ''         .;.     .;........':;,;;'.......';:;,,,'..','..,;''',..','.'''''''...........
..';:;,..      .::'';,lk,                                    .xl   .:;...              .;. .'     ',. ..    .,.  ,.      . .;.     .,         ,,.''.     .,,,,'.......,,,......,,,,.........'...        
  .;c::,......;oOx:...xo                                      ,d;  .c'           ....  ',  .........   ........  ';..      .,.     ',         ,;.,,.   .''.   .         ..'.   ',,,.        ...         
   ,,        .';:;.  ;O:                                       :x, ':.        ....     ',    ......     ......   ';.       .,.     ',        .,,',;'  .'.    .........    .,. .',,,'.       ';.      .'.
  .;.  .';;,,,.      lO,                                        lx,,:     .....        .,.  .'....''.  ........  '.        .,.     ':..   .......';,.''    .'.       .....  ';''............;c:,.    ;o,
  ',.   .....'      .dO'                                        .okx:......          ...,,   ..   ... ..    ..  ''         .,.     'c'.   ...........,.   .'.          ..    ;;.   ..,'.....;:'. .;. .;.
  ,,        .'.     .xO'                                         .lKx'.              .   .,.  ....... ....... .'.        ...;.     ';                '.   ..           .'.   ',      '.   .,cl;'.';'.':;
  ,,         '.     .ok,                                           ;kx,      ..           .''.   ..    ...  ..'.     ....  .;.     ';               .,.  .'.            '.   ',     .'.  .;;,;:c:;;,,::,
  ';         ,'     .:xl                                            .:xx:......             .''....    .......  ......     .;.     ':.........  .....,.   '.            '.   ,;.    .,.  .,.            
  .;.        ,'     .'lk'                       ..             '.     ,k0:.            ..      ............ ......          ,.     'c'........  .....,.   '.           .'.   ,:..  ..'....''.           
   ',        ,.     '..xd..'                    ',             .:,   .lOc          .....                 .....              ,.     ';               .,.  .'.         ..',.   ,,              ...........
   .;.      .,.     .' ;Ol,:. .;.                .          ..  .;c:lkd,       .....                .   ..                 .;.     ',               .,.  .'.     ...'''l:    ,,                   '.    
    ,,      .'      .,. :O0k, .:'                            ''   .;oxd;    .....               ......                 .....;.     ',               .,.  .'.     ......;,    ,;.                 .,'    
    .,.     '.       .'  ,OXo. c:                            .,.    .lOo'.                   .....                ..;.      ;'     ':'.......,'..   .,.  .,.           .'    ,:............','....'.  ..
     .,.   .'         '.  .ckx::o'   ..    .                  ..  ,okkc..               ...                    .....;.      ;'     ',        ..  .. .,   .'            .'   .;,            .'.          
      .,. .'.         .'.   .;odOx.  .:'                    . .'lk0d,.               .....                          ;'      ;'     .,            ';..'   .'            ..    ',   ....     ...          
       .':lc,..........,:'..   .,dd,..;l.       .,   ..   .,oxkkddo.                ..                ..        .. .;,.     ,'     .'            ':';,   ..            ..    ';..;,;l:......;,..........
 ........,;;,''.........''.......:dkOxlxkl;,''''lkc,,cdoldxxdc,. ,:.                             ......         ,c,.,:;  .,.,.     .;........,,..'::oc.  ..       .....;;....;:;,......',,,,;::;;,''',,,
                                 ..'xk..,clooooo0X0xdlcloc,......:c'......,;;,.................,:;,.........   ...,,..,...;cl'     .,.......   .;,. ',....'.....................       ..  ..    .......
                                   :0c          ,OO:'.....'.....................                 ...............       ..'..,;..  .,;...''.......       ...                                             
                                 .lOl.           ,xkc.                                                                        ...........                                                               
                               .:kx,               ,ldl;.                                                                                                                                               
                             .;ckk;                .,oxocol,                                                                                                                                            
                            ;o;..;lol:'.    ...,;:cc:,.  .ckd,                                                                                                                                          
                          .oo'     .,cloollccc::;'.        .cxd;.                                                                                                                                       
                        .lx:.                                .,ldl;.                                                                                                                                    
                      'ldc.                                     .,loo:.                                                                                                                                 
                     .dl.                                           'll.                                                                                                                                
                     ,d'                                             .o,                                                                                                                                
                     ;x'                                              oo.                                                                                                                               
                     ck'                                              :k,                                                                                                                               
                    .dx.    ''                                        .xo.                                                                                                                              
                    'Ol     .l:                                        cO;                                                                                                                              
                    lO,      ,d;                        ..             .kd.                                                                                                                             
                   'Od.       ld.                       ,;              :O:                                                                                                                             
                   o0,        ,k:                       'c.             .xk'                                                                                                                            
                  ;0o.        .dd.                      'l.              'kx.                                                                                                                           
                 .d0,          lk.                      'o'               cKc                                                                                                                           
            ";
            WriteLine(asciiArt);
            ReadLine();
            Clear();
        }
    }

    



    
}
