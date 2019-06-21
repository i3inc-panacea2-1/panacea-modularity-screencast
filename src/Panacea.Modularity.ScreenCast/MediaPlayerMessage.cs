using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.ScreenCast
{
    public class MediaPlayerMessage
    {
        public string Action { get; set; }
        public string Mrl { get; set; }
        public string Extras { get; set; }
        public float Position { get; set; }
        public float Volume { get; set; }
        public double Duration { get; set; }
        public int HashCode { get; set; }
    }
}
