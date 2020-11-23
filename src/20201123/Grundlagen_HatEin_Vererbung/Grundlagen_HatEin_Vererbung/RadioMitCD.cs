using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grundlagen_HatEin_Vererbung
{
    public class RadioMitCD : Radio
    {
        private bool _modeCD;
        private int _track;

        public RadioMitCD(double frequenz, int volume, Power PowerState, bool modeCD, int track)
            : base()
        {
            _track = track;
            _modeCD = modeCD;
        }

        public int Track
        {
            get { return _track; }
        }



        public bool ModeCD
        {
            get { return _modeCD; }
        }


        public void SetTrack(int newtrack)
        {
            if (_modeCD)
            {
                newtrack = _track;
            }
            else
            {
                Console.WriteLine("Der Radio hat keine CD geladen");
                return;

            }            
        }
    }
}
