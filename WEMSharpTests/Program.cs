using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEMSharp;

namespace WEMSharpTests
{
    class Program
    {
        static void Main(string[] args)
        {
            WEMFile wem = new WEMFile("LoL_MUSIC_TreelineINTRO.wem", WEMForcePacketFormat.NoForcePacketFormat);
            wem.GenerateOGG("LoL_MUSIC_TreelineINTRO.ogg", "packed_codebooks_aoTuV_603.bin", false, false);
        }
    }
}
