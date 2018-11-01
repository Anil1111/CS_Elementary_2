using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;
using WMPLib;
using System.IO;
using System.Media;
namespace Player
{
    class Player : IPlayable, IRecodable
    {
        public static WaveFileWriter waveFile;
        public void Pause()
        {
            InitPlay.Wplayer.controls.pause();
        }

        public void Play()
        {
            InitPlay.Wplayer.controls.play();           
        }

        public void Stop()
        {
            InitPlay.Wplayer.controls.stop();
        }
        public void PauseRec()
        {

        }

        public void Record()
        {
            InitRecord.WaveSource.StartRecording();
        }
        public void StopRec()
        {
            InitRecord.WaveSource.StopRecording();
            waveFile.Dispose();
        }
    }

}
