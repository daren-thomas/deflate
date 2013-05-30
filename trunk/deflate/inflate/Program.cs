using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Compression;
using System.IO;

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
            if (args.Length == 0)
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
            else if (args.Length == 2)
            {
                // copy from first arg to second arg
                using (var infile = new FileStream(args[0], FileMode.Open, FileAccess.Read))
                {
                    using (var outfile = new FileStream(args[1], FileMode.Create, FileAccess.Write))
                    {
                        using (var deflator = new DeflateStream(infile, CompressionMode.Decompress))
                        {
                            deflator.CopyTo(outfile);
                        }
                    }
                }
            }
            else if (args.Length == 1)
            {
                // copy from first arg to stdout
                // copy from first arg to second arg
                using (var infile = new FileStream(args[0], FileMode.Open, FileAccess.Read))
                {
                    using (var stdout = System.Console.OpenStandardOutput())
                    {
                        using (var deflator = new DeflateStream(infile, CompressionMode.Decompress))
                        {
                            deflator.CopyTo(stdout);
                        }
                    }
                }
            }
            
        }
    }
}
