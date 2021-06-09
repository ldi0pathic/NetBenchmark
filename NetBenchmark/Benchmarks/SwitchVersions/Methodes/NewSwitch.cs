using System;

namespace NetBenchmark.Benchmarks.SwitchVersions.Methodes
{
    public class NewSwitch : IHasColor
    {
        public bool HasColor(Dinge ding, Farben farbe) => (ding, farbe) switch
        {
            { ding: Dinge.Apfel, farbe: Farben.Rot } => true,
            { ding: Dinge.Apfel, farbe: Farben.Grün } => true,
            { ding: Dinge.Apfel, farbe: Farben.Gelb } => true,

            { ding: Dinge.Apfel, farbe: Farben.Blau } => false,
            { ding: Dinge.Apfel, farbe: Farben.Lila } => false,
            { ding: Dinge.Apfel, farbe: Farben.Schwarz } => false,
            { ding: Dinge.Apfel, farbe: Farben.Pink } => false,
            { ding: Dinge.Apfel } => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            { ding: Dinge.Banane, farbe: Farben.Grün } => true,
            { ding: Dinge.Banane, farbe: Farben.Gelb } => true,

            { ding: Dinge.Banane, farbe: Farben.Rot } => false,
            { ding: Dinge.Banane, farbe: Farben.Blau } => false,
            { ding: Dinge.Banane, farbe: Farben.Lila } => false,
            { ding: Dinge.Banane, farbe: Farben.Schwarz } => false,
            { ding: Dinge.Banane, farbe: Farben.Pink } => false,
            { ding: Dinge.Banane } => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            { ding: Dinge.Auto, farbe: Farben.Grün } => true,
            { ding: Dinge.Auto, farbe: Farben.Gelb } => true,
            { ding: Dinge.Auto, farbe: Farben.Rot } => true,
            { ding: Dinge.Auto, farbe: Farben.Blau } => true,
            { ding: Dinge.Auto, farbe: Farben.Lila } => true,
            { ding: Dinge.Auto, farbe: Farben.Schwarz } => true,
            { ding: Dinge.Auto, farbe: Farben.Pink } => true,
            { ding: Dinge.Auto } => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            { ding: Dinge.Sonne, farbe: Farben.Gelb } => true,

            { ding: Dinge.Sonne, farbe: Farben.Grün } => false,
            { ding: Dinge.Sonne, farbe: Farben.Rot } => false,
            { ding: Dinge.Sonne, farbe: Farben.Blau } => false,
            { ding: Dinge.Sonne, farbe: Farben.Lila } => false,
            { ding: Dinge.Sonne, farbe: Farben.Schwarz } => false,
            { ding: Dinge.Sonne, farbe: Farben.Pink } => false,
            { ding: Dinge.Sonne } => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            { ding: Dinge.Himmel, farbe: Farben.Blau } => true,

            { ding: Dinge.Himmel, farbe: Farben.Gelb } => false,
            { ding: Dinge.Himmel, farbe: Farben.Grün } => false,
            { ding: Dinge.Himmel, farbe: Farben.Rot } => false,
            { ding: Dinge.Himmel, farbe: Farben.Lila } => false,
            { ding: Dinge.Himmel, farbe: Farben.Schwarz } => false,
            { ding: Dinge.Himmel, farbe: Farben.Pink } => false,
            { ding: Dinge.Himmel } => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            _ => throw new NotSupportedException($"Ding [{ding}] wird derzeit nicht unterstützt (┬┬﹏┬┬)")
        };
    }

    public class NewSwitch2 : IHasColor
    {
        public bool HasColor(Dinge ding, Farben farbe) => ding switch
        {
            Dinge.Apfel => farbe switch
            {
                Farben.Rot => true,
                Farben.Grün => true,
                Farben.Gelb => true,
                Farben.Blau => false,
                Farben.Lila => false,
                Farben.Schwarz => false,
                Farben.Pink => false,
                _ => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)")
            },
            Dinge.Banane => farbe switch
            {
                Farben.Gelb => true,
                Farben.Grün => true,

                Farben.Rot => false,
                Farben.Blau => false,
                Farben.Lila => false,
                Farben.Schwarz => false,
                Farben.Pink => false,
                _ => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)")
            },
            Dinge.Auto => farbe switch
            {
                Farben.Rot => true,
                Farben.Grün => true,
                Farben.Blau => true,
                Farben.Lila => true,
                Farben.Gelb => true,
                Farben.Schwarz => true,
                Farben.Pink => true,
                _ => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)")
            },
            Dinge.Sonne => farbe switch
            {
                Farben.Gelb => true,

                Farben.Rot => false,
                Farben.Grün => false,
                Farben.Blau => false,
                Farben.Lila => false,
                Farben.Schwarz => false,
                Farben.Pink => false,
                _ => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)")
            },
            Dinge.Himmel => farbe switch
            {
                Farben.Blau => true,

                Farben.Rot => false,
                Farben.Grün => false,
                Farben.Lila => false,
                Farben.Gelb => false,
                Farben.Schwarz => false,
                Farben.Pink => false,
                _ => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)")
            },
            _ => throw new NotSupportedException($"Ding [{ding}] wird derzeit nicht unterstützt (┬┬﹏┬┬)")
        };
    }

    public class NewSwitch3 : IHasColor
    {
        public bool HasColor(Dinge ding, Farben farbe) => ding switch
        {
            Dinge.Apfel when
                farbe == Farben.Rot ||
                farbe == Farben.Grün ||
                farbe == Farben.Gelb => true,

            Dinge.Apfel when
                farbe == Farben.Blau ||
                farbe == Farben.Lila ||
                farbe == Farben.Schwarz ||
                farbe == Farben.Pink => false,

            Dinge.Apfel => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            Dinge.Banane when
                farbe == Farben.Gelb ||
                farbe == Farben.Grün => true,

            Dinge.Banane when
                farbe == Farben.Rot ||
                farbe == Farben.Blau ||
                farbe == Farben.Lila ||
                farbe == Farben.Schwarz ||
                farbe == Farben.Pink => false,

            Dinge.Banane => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            Dinge.Auto when
                farbe == Farben.Rot ||
                farbe == Farben.Blau ||
                farbe == Farben.Lila ||
                farbe == Farben.Schwarz ||
                farbe == Farben.Pink ||
                farbe == Farben.Gelb ||
                farbe == Farben.Grün => true,

            Dinge.Auto => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            Dinge.Sonne when
                farbe == Farben.Gelb => true,

            Dinge.Sonne when
                farbe == Farben.Rot ||
                farbe == Farben.Blau ||
                farbe == Farben.Lila ||
                farbe == Farben.Schwarz ||
                farbe == Farben.Pink ||
                farbe == Farben.Grün => false,

            Dinge.Sonne => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            Dinge.Himmel when
                farbe == Farben.Blau => true,

            Dinge.Himmel when
                farbe == Farben.Rot ||
                farbe == Farben.Gelb ||
                farbe == Farben.Lila ||
                farbe == Farben.Schwarz ||
                farbe == Farben.Pink ||
                farbe == Farben.Grün => false,

            Dinge.Himmel => throw new NotSupportedException($"Farbe [{farbe}] für Ding [{ding}]  wird derzeit nicht unterstützt (┬┬﹏┬┬)"),

            _ => throw new NotSupportedException($"Ding [{ding}] wird derzeit nicht unterstützt (┬┬﹏┬┬)")
        };
    }

}
