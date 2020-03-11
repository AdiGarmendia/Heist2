using System;

namespace Heist2ElectricBogaloo {
  public class Muscle : IRobber {
    public string SpecialtyName { get; set; } = "Muscle";
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public int PercentageCut { get; set; }

    public void PerformSkill (Bank bank) {
      bank.SecurityGuardScore -= SkillLevel;
      Console.WriteLine ($"{Name} is thunder punching the security guards. Reducing security by {SkillLevel} points");

      if (bank.SecurityGuardScore <= 0) {
        Console.WriteLine ($"{Name} has knocked out all the guards!");
      }

    }
  }
}