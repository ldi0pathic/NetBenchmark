using System;
using System.Collections.Generic;
using System.Text;

namespace NetBenchmark.Benchmarks.Switch.Methodes
{
    public class Switch
    {
        public long doSwitch(SwitchEnum value)
        {
            switch (value)
            {
                case SwitchEnum.E1:
                case SwitchEnum.E2:
                case SwitchEnum.E3:
                case SwitchEnum.E4:
                case SwitchEnum.E5:
                case SwitchEnum.E6:
                case SwitchEnum.E7:
                case SwitchEnum.E8:
                case SwitchEnum.E9:
                case SwitchEnum.E10:
                case SwitchEnum.E11:
                case SwitchEnum.E12:
                case SwitchEnum.E13:
                case SwitchEnum.E14:
                case SwitchEnum.E15:
                    return 2;
                default:
                    return 3;
            }
        }

        public static long doStaticSwitch(SwitchEnum value)
        {
            switch (value)
            {
                case SwitchEnum.E1:
                case SwitchEnum.E2:
                case SwitchEnum.E3:
                case SwitchEnum.E4:
                case SwitchEnum.E5:
                case SwitchEnum.E6:
                case SwitchEnum.E7:
                case SwitchEnum.E8:
                case SwitchEnum.E9:
                case SwitchEnum.E10:
                case SwitchEnum.E11:
                case SwitchEnum.E12:
                case SwitchEnum.E13:
                case SwitchEnum.E14:
                case SwitchEnum.E15:
                    return 2;
                default:
                    return 3;
            }
        }
    }
}
