using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;

namespace deflate
{
    class Program
    {
        /// <summary>
        /// applies the DEFLATE algorithm as specified by System.IO.Compression.DeflateStream
        /// to STDIN and writes the result to STDOUT.
        /// </summary>
        static void Main(string[] args)
        {
            using (var stdin = System.Console.OpenStandardInput())
            {
                using (var stdout = System.Console.OpenStandardOutput())
                {
                    using (var deflator = new DeflateStream(stdout, CompressionMode.Compress))
                    {
                        stdin.CopyTo(deflator);
                    }
                }
            }
        }
    }
}
