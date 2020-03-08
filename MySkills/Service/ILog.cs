using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MySkills.Service
{
    public interface ILog
    {
        public void Write(string message);
    }

    public class TextWriteLog : ILog
    {
        public void Write(string message)
        {
            File.AppendAllText(@"E:\logFile.txt", message);
        }
    }
}
