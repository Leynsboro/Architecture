using System;

public class ElfFactory : NpcFactory<IElf>
{
    public override IElf Spawn(ClassType classType)
    {
        switch (classType)
        {
            case ClassType.paladin:
                return new ElfPaladin();
            case ClassType.mage:
                return new ElfMage();
            default:
                throw new ArgumentException(nameof(classType));
        }
    }
}
