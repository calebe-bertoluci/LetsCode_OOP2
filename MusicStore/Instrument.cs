using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    internal abstract class Instrument
    {
        public decimal Price { get; set; }
        public string Maker { get; set; }
        public int NumStrings { get; set; }
    }
}