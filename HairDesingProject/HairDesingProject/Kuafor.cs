using System;
using System.Collections.Generic;
using System.Text;

namespace HairDesingProject
{
    enum Hizmetler
    {
        Saç_Traşı,
        Sakal_Traşı,
        Saç_Yıkama,
        Cilt_Bakımı
    };
    public class Kuafor
    {
        /* enum hizmetler: saç tıraşı, sakal traşı, saç yıkama, cilt bakımı
           saç tıraşı: 20,Sakal traşı: 15, Saç yıkama:10, cilt bakımı:30
           Metotlar: SaçTraşiYap, SakalTraşıYap,SaçYika, CiltBakimiYap();
        */

        public float SacTrasiUcreti { get; set; }
        public float SakalTrasiUCreti { get; set; }
        public float SacYikamaUcreti { get; set; }
        public float CiltBakimUcreti { get; set; }

        public Kuafor()
        {
            SacTrasiUcreti = 20;
            SakalTrasiUCreti = 15;
            SacYikamaUcreti = 10;
            CiltBakimUcreti = 30;
        }
        private List<Hizmetler> alinanHizmetler = new List<Hizmetler>();
        private float toplamUCret;
        public void SacTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Saç_Traşı);
            toplamUCret += SacTrasiUcreti;
        }
        public void SacYikamaYap()
        {
            alinanHizmetler.Add(Hizmetler.Saç_Yıkama);
            toplamUCret += SacYikamaUcreti;
        }
        public void CiltBakımıYap()
        {
            alinanHizmetler.Add(Hizmetler.Cilt_Bakımı);
            toplamUCret += CiltBakimUcreti;
        }
        public void SakalTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Sakal_Traşı);
            toplamUCret += SakalTrasiUCreti;
        }



    }
}
