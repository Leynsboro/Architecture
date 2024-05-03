using System;

public class MageFactory : NpcFactory<Mage>
{
    public override Mage Spawn(RaceType raceType)
    {
        switch (raceType)
        {
            case RaceType.ork:
                return new OrkMage();
            case RaceType.elf:
                return new ElfMage();
            default:
                throw new ArgumentException(nameof(raceType));
        }
    }
}
