using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3
{
    class KodeBuah
    {
        public enum NamaBuah
        {
            Apel,
            Alprikot,
            Alpukat,
            Pisang,
            Paprika,
            Blackberry,
            Ceri,
            Kelapa,
            Jagung,
            Kurma,
            Durian,
            Anggur,
            Melon,
            Semangka
        };

        public string GetKodeBuah(NamaBuah inputBuah)
        {
            string[] arrayKodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "O00" };
            int indexJawaban = (int)inputBuah;
            return arrayKodeBuah[indexJawaban];
        }

    }
}
