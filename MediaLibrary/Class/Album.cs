using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeChalleng
{
    class Album : Media
    {
        public string Band { get; }
        public string Disk { get; }


        public Album (string band, string disk)
        {
            Disk = disk;
            Band = band;
        }

        public override string ToString()
        {
            return $"The band: {Band} has recorder {Disk}";
        }
    }
}
