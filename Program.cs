using System;
using System.Collections.Generic;

namespace Heist2ElectricBogaloo {
    class Program {
        static void Main (string[] args) {

            // List of robbers
            var rolodex = new List<IRobber> ();

            // Premade robbers
            var Adrian = new Muscle () {
                Name = "Adrian",
                SkillLevel = 70,
                PercentageCut = 15
            };
            var Slim = new Muscle () {
                Name = "Slim",
                SkillLevel = 50,
                PercentageCut = 5
            };

            var YoMomma = new LockSpecialist () {
                Name = "YoMomma",
                SkillLevel = 50,
                PercentageCut = 5
            };
            var YeahBoy = new LockSpecialist () {
                Name = "YeahBoy",
                SkillLevel = 70,
                PercentageCut = 15
            };

            var WhoDat = new Hacker () {
                Name = "WhoDat",
                SkillLevel = 50,
                PercentageCut = 5
            };
            var Prince = new Hacker () {
                Name = "Prince",
                SkillLevel = 60,
                PercentageCut = 10
            };

            // Adding them to the list
            rolodex.Add (Adrian);
            rolodex.Add (Slim);
            rolodex.Add (YoMomma);
            rolodex.Add (YeahBoy);
            rolodex.Add (WhoDat);
            rolodex.Add (Prince);

            while (true) {
                //Print out how many operatives are in your rolodex
                Console.WriteLine ($"There are currently {rolodex.Count} available operatives");
                Console.WriteLine ("Enter the name of a new possible crew member or nothing to contine.");
                var newMemberName = Console.ReadLine ();
                //break out of while loop if blank name is entered
                if (string.IsNullOrEmpty (newMemberName)) {
                    break;
                } else {
                    //Pick new members specialty
                    Console.WriteLine ($"What specialty do you want {newMemberName} to have?");
                    Console.WriteLine ("Hacker (Does magic computery thingies)");
                    Console.WriteLine ("Muscle (Thunder Punches)");
                    Console.WriteLine ("LockSpecialist (Picks dat lock)");
                    string newMemberSpecialty;
                    while (true) {
                        newMemberSpecialty = Console.ReadLine ().ToLower ();

                        if (newMemberSpecialty == "hacker" || newMemberSpecialty == "muscle" || newMemberSpecialty == "lock specialist") {
                            break;
                        } else {
                            Console.WriteLine ("Not a valid entry. Please choose Hacker, Muscle, or Lock Specialist");
                        }
                    }
                    //pick new members skill level
                    Console.WriteLine ($"What is {newMemberName}'s skill level? (1-100)");
                    int newMemberSkillLevel;
                    while (true) {
                        try {
                            newMemberSkillLevel = int.Parse (Console.ReadLine ());

                            if (newMemberSkillLevel > 0 && newMemberSkillLevel <= 100) {
                                break;
                            } else {
                                Console.WriteLine ("Not a valid entry. Please enter a skill level between 1-100");
                            }
                        } catch {
                            Console.WriteLine ("Not a valid entry. Please enter a valid skill level between 1-100");
                        }
                    }

                    //new members percentage cut
                    Console.WriteLine ($"What percentage cut does {newMemberName} want? (1-25)");
                    int newMemberCut;
                    while (true) {
                        try {
                            newMemberCut = int.Parse (Console.ReadLine ());

                            if (newMemberCut > 0 && newMemberCut <= 25) {
                                break;
                            } else {
                                Console.WriteLine ("Not a valid input, please choose an integer between 1-50");
                            }
                        } catch {
                            Console.WriteLine ("Not a valid input, please choose an integer between 1-50");
                        }
                    }

                    //create new instance off of information you entered
                    if (newMemberSpecialty == "hacker") {
                        Hacker hacker = new Hacker () {
                        Name = $"{newMemberName}",
                        SkillLevel = newMemberSkillLevel,
                        PercentageCut = newMemberCut
                        };

                        rolodex.Add (hacker);
                    } else if (newMemberSpecialty == "muscle") {
                        Muscle muscle = new Muscle () {
                        Name = $"{newMemberName}",
                        SkillLevel = newMemberSkillLevel,
                        PercentageCut = newMemberCut
                        };

                        rolodex.Add (muscle);
                    } else if (newMemberSpecialty == "lock specialist") {
                        LockSpecialist lockSpecialist = new LockSpecialist () {
                        Name = $"{newMemberName}",
                        SkillLevel = newMemberSkillLevel,
                        PercentageCut = newMemberCut
                        };

                        rolodex.Add (lockSpecialist);
                    }
                }
            }
        }

    }
}