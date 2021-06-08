using System;

namespace NetBenchmark.Erklärbär._1_Switches.Methoden
{
    public class OldSwitch : IHasColor
    {
        public bool HasColor(Dinge ding, Farben farbe)
        {
            switch (ding)
            {
                case Dinge.Apfel:
                    switch (farbe)
                    {
                        case Farben.Rot:
                        case Farben.Grün:
                        case Farben.Gelb:
                            return true;
                           
                        case Farben.Blau:  
                        case Farben.Lila:      
                        case Farben.Schwarz:     
                        case Farben.Pink:
                            return false;

                        default:
                            throw new ArgumentOutOfRangeException($"Farbe [{farbe}] für Ding [{ding}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
                    }
                   
                case Dinge.Banane:
                    switch (farbe)
                    {
                        case Farben.Grün:
                        case Farben.Gelb:
                            return true;

                        case Farben.Rot:
                        case Farben.Blau:
                        case Farben.Lila:
                        case Farben.Schwarz:
                        case Farben.Pink:
                            return false;

                        default:
                            throw new ArgumentOutOfRangeException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)");
                    }

                case Dinge.Auto:
                    switch (farbe)
                    {
                        case Farben.Rot:
                        case Farben.Grün:
                        case Farben.Gelb:
                        case Farben.Blau:
                        case Farben.Lila:
                        case Farben.Schwarz:
                        case Farben.Pink:
                            return true;

                        default:
                            throw new ArgumentOutOfRangeException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)");
                    }

                case Dinge.Sonne:
                    switch (farbe)
                    {     
                        case Farben.Gelb:
                            return true;

                        case Farben.Rot:
                        case Farben.Grün:
                        case Farben.Blau:
                        case Farben.Lila:
                        case Farben.Schwarz:
                        case Farben.Pink:
                            return false;

                        default:
                            throw new ArgumentOutOfRangeException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)");
                    }

                case Dinge.Himmel:
                    switch (farbe)
                    {
                        case Farben.Blau:
                            return true;

                        case Farben.Lila:
                        case Farben.Schwarz:
                        case Farben.Pink:
                        case Farben.Rot:
                        case Farben.Grün:
                        case Farben.Gelb:
                            return false;

                        default:
                            throw new ArgumentOutOfRangeException($"Farbe [{farbe}] für Ding [{ding}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
                    }

                default:
                    throw new ArgumentOutOfRangeException($"Ding [{ding}] wird derzeit nicht unterstützt (┬┬﹏┬┬)");
            }
        }
    }
}
