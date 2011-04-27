using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;

namespace inflate
{
    class Program
    {
        /// <summary>
        /// applies the reverse of the DEFLATE algorithm as specified by System.IO.Compression.DeflateStream
        /// to STDIN and writes the result to STDOUT.
        /// </summary>
        static void Main(string[] args)
        {
            using (var stdin = System.Console.OpenStandardInput())
            {
                using (var stdout = System.Console.OpenStandardOutput())
                {
                    using (var deflator = new DeflateStream(stdin, CompressionMode.Decompress))
                    {
                        deflator.CopyTo(stdout);
                    }
                }
            }
        }
    }
}
