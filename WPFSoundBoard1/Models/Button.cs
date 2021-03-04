using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSoundBoard1.Models
{
    public class Button
    {
        public Guid Id { get; set; }
        public string SoundUrl { get; set; }
        public string ButtonText { get; set; }
    }
}
