using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders28_32
{
    internal class Ogrenci : Kisi, IComparable<Ogrenci>
    {
        public int OgrNo { get; set; }
        private int _not;

        public Ogrenci(string ad, string soyad, int ogrNo, int Not) : base(ad, soyad)
        {
            this.OgrNo = ogrNo;
            this._not = Not;
        }

        // 2.Kapı
        public int Not
        {
            get
            {
                return _not;
            }

            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hata: Not 0'dan küçük olamaz! 0'a eşitlendi.");
                    _not = 0;
                }
                else if (value > 100)
                {
                    Console.WriteLine("Hata: Not 100'den büyük olamaz! 100'e eşitlendi.");
                    _not = 100;
                }
                else
                {
                    _not = value;
                }
            }
        }

        public string Durum
        {
            get
            {
                if (_not >= 50) return "Geçti";
                else return "Kaldı";
            }
        }

        public override void BilgiYazdır()
        {
            Console.WriteLine($"Öğrenci: {Ad} {Soyad} - Numara: {OgrNo} - Geçme Durumu: {Durum}");
        }

        public int CompareTo(Ogrenci other)
        {
            return this.Not.CompareTo(other.Not);
        }
    }
}
