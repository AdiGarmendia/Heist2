namespace Heist2ElectricBogaloo {
  public interface IRobber {
    string Name { get; set; }
    int SkillLevel { get; set; }
    int PercentageCut { get; set; }
    void PerformSkill (Bank bank);

  }
}