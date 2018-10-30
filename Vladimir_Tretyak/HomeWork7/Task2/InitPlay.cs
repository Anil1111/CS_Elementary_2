using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Player
{
    static class InitPlay
    {
        public static  WindowsMediaPlayer Wplayer;  
           
        public static void  initPlay()
        {
            WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            Wplayer = wplayer;
        }
    }
}
