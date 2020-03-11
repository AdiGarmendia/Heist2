using System;

namespace Heist2ElectricBogaloo {
  public class LockSpecialist : IRobber {
    public string SpecialtyName { get; set; } = "LockSpecialist";
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public void PerformSkill (Bank bank) {
      bank.AlarmScore -= SkillLevel;
      Console.WriteLine ($"{Name} is picking dat vault lock. Reducing security by {SkillLevel} points");

      if (bank.AlarmScore <= 0) {
        Console.WriteLine ($"{Name} has picked dat lock!");
      }

    }
  }
}