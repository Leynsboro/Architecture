using System;

public class PaladinFactory : NpcFactory<Paladin>
{
    public override Paladin Spawn(RaceType raceType)
    {

        switch (raceType)
        {
            case RaceType.ork:
                return new OrkPaladin();
            case RaceType.elf:
                return new ElfPaladin();
            default:
                throw new ArgumentException(nameof(raceType));
        }
    }
}
