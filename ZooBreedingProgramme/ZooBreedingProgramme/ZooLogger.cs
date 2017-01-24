using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBreedingProgramme
{
    public sealed class ZooLogger : IDisposable
    {
        private static System.IO.TextWriter _loWriter;

        private static readonly Lazy<ZooLogger> Logger =
        new Lazy<ZooLogger>(() => new ZooLogger());

        public static ZooLogger Instance
        {
            get { return Logger.Value; }
        }

        private ZooLogger()
        {
            _loWriter = new StreamWriter(@"C:\temp\pomfrit.txt",false,Encoding.Default);
        }
        public void Log(object obj)
        {
            string output = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fffffff") + $": {obj}";
            Console.WriteLine(output);
            _loWriter.WriteLine(output);
            _loWriter.Flush();
        }
        public void Dispose()
        {
            _loWriter.Close();
        }
    }
}
