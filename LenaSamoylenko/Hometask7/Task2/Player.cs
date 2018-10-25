using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Task2
{
    class Player : IPlayable, IRecordable
    {
        void IPlayable.Pause()
        {
            throw new NotImplementedException();
        }

        void IRecordable.Pause()
        {
            throw new NotImplementedException();
        }

        void IPlayable.Play()
        {
            throw new NotImplementedException();
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
