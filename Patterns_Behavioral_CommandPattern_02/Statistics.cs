using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Behavioral_Command_02
{
    public enum StatisticType
    {
        Agility,
        Charisma,
        Strength
    }

    public interface IStatistic
    {
        decimal Value { get; set; }
    }

    public class Strength : IStatistic
    {
        public decimal Value { get; set; } = 0;
    }

    public class Agility : IStatistic
    {
        public decimal Value { get; set; } = 0;
    }

    public class Charisma : IStatistic
    {
        public decimal Value { get; set; } = 0;
    }
}
