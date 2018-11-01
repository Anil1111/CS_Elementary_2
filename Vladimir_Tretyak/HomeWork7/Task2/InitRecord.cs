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
    class InitRecord
    {
        public static WaveInEvent WaveSource;
        public static void waveSource_DataAvailable(object sender, WaveInEventArgs e) { }       
        public static void initRecord()
        {
            WaveInEvent waveSource = new WaveInEvent();
            WaveSource = waveSource;
            WaveSource.DeviceNumber = 0;
            WaveSource.WaveFormat = new WaveFormat(44100, 1);
            WaveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            //string tempFile = (@"C:\test1.mp3");
            string tempFile = Environment.CurrentDirectory + "\\testRec.mp3";
            Player.waveFile = new WaveFileWriter(tempFile, WaveSource.WaveFormat);
        }
    }
}
