using System;

namespace Heist2ElectricBogaloo {
  public class Hacker : IRobber {
    public string SpecialtyName { get; set; } = "Hacker";
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public void PerformSkill (Bank bank) {
      bank.AlarmScore -= SkillLevel;
      Console.WriteLine ($"{Name} is hacking the alarm system. Reducing security by {SkillLevel} points");

      if (bank.AlarmScore <= 0) {
        Console.WriteLine ($"{Name} has disabled the alarms!");
      }

    }
  }
}