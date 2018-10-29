using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vlc.DotNet.Core;

namespace Task2
{
    class Player : IPlayable, IRecordable
    {
        VlcMedia vlcMedia;



        void IPlayable.Pause()
        {

        }

        void IRecordable.Pause()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Play()
        {
            vlcMedia.URL = @"C:\Дживс и Вустер - Jeeves and Wooster[DVDRip - AVC, 1990 - 1993]\s01e01.Jeeves Takes Charge.DVDRip - AVC.Rus.Eng.mkv";
            vlcMedia.
        }

        void IRecordable.Record()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Stop()
        {
            throw new NotImplementedException();
        }

        void IRecordable.Stop()
        {
            throw new NotImplementedException();
        }
    }
}
