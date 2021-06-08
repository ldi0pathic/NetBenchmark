using System;

namespace NetBenchmark.Erklärbär._1_Switches.Methoden
{
    public class IfElse : IHasColor
    {
        public bool HasColor(Dinge ding, Farben farbe)
        {
            if(ding == Dinge.Apfel)
            {
                if (farbe == Farben.Rot ||
                    farbe == Farben.Grün ||
                    farbe == Farben.Gelb)
                {
                    return true;
                }
                else if(farbe == Farben.Blau ||
                        farbe == Farben.Lila ||
                        farbe == Farben.Schwarz ||
                        farbe == Farben.Pink)
                {
                    return false;
                }
                throw new ArgumentOutOfRangeException($"Farbe [{farbe}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
            }
            else if(ding == Dinge.Banane)
            {
                if (farbe == Farben.Grün ||
                    farbe == Farben.Gelb)
                {
                    return true;
                }
                else if (farbe == Farben.Rot || 
                         farbe == Farben.Blau ||
                         farbe == Farben.Lila ||
                         farbe == Farben.Schwarz ||
                         farbe == Farben.Pink)
                {
                    return false;
                }
                throw new ArgumentOutOfRangeException($"Farbe [{farbe}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
            }
            else if(ding == Dinge.Auto)
            {
                if (farbe == Farben.Rot ||
                    farbe == Farben.Grün ||
                    farbe == Farben.Gelb ||
                    farbe == Farben.Blau ||
                    farbe == Farben.Lila ||
                    farbe == Farben.Schwarz ||
                    farbe == Farben.Pink)
                {
                    return true;
                }
                throw new ArgumentOutOfRangeException($"Farbe [{farbe}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
            }
            else if(ding == Dinge.Sonne)
            {
                if (farbe == Farben.Gelb)
                {
                    return true;
                }
                else if (farbe == Farben.Blau ||
                         farbe == Farben.Lila ||
                         farbe == Farben.Schwarz ||
                         farbe == Farben.Grün ||
                         farbe == Farben.Rot ||
                         farbe == Farben.Pink)
                {
                    return false;
                }
                throw new ArgumentOutOfRangeException($"Farbe [{farbe}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
            }
            else if(ding == Dinge.Himmel)
            {
                if (farbe == Farben.Blau)
                {
                    return true;
                }
                else if (farbe == Farben.Rot ||
                         farbe == Farben.Grün ||
                         farbe == Farben.Gelb||
                         farbe == Farben.Lila ||
                         farbe == Farben.Schwarz ||
                         farbe == Farben.Pink)
                {
                    return false;
                }
                throw new ArgumentOutOfRangeException($"Farbe [{farbe}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
            }

            throw new ArgumentOutOfRangeException($"Ding [{ding}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
        }
    }
}
