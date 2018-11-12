using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Task3
{
    class Archiving
    {
        WatchText watchText;
        private FileStream destination;
        private GZipStream compressor;

        public Archiving(WatchText _watchText)
        {
            Console.WriteLine("You`re start archiving");
            watchText = _watchText;
        }

        private void CreateZip()
        {
            string file = watchText.MainFileStream.Name;
            DirectoryInfo directory = new DirectoryInfo(file);
            var directories = file.Split(new string[] { "\\" },StringSplitOptions.RemoveEmptyEntries);
            Array.Resize(ref directories, (directories.Length - 1));
            string parentDirectory = String.Join("\\", directories);

            destination = File.Create(parentDirectory + "\\" + directory.Name.Split(new char[] {'.'})[0] + ".zip");
        }

        private void CreateCompressor()
        {
            compressor = new GZipStream(destination, CompressionMode.Compress);
        }

        private void AddInfoToArchive()
        {
           
            bool us = watchText.MainFileStream.CanRead;
            watchText.MainFileStream.Position = 0;
            int theByte = watchText.MainFileStream.ReadByte();
            while (theByte!=-1)
            {
                compressor.WriteByte((byte)theByte);
                theByte = watchText.MainFileStream.ReadByte();
            }
        }

        private void DeleteComp()
        {
            watchText.MainFileStream.Close();
            compressor.Close();
        }

        internal void ArchivingFile()
        {
            CreateZip();
            CreateCompressor();
            AddInfoToArchive();
            DeleteComp();
        }
    }
}
