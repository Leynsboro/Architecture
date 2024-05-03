using System;

public class OrkFactory : NpcFactory<IOrk>
{
    public override IOrk Spawn(ClassType classType)
    {

        switch (classType)
        {
            case ClassType.paladin:
                return new OrkPaladin();
            case ClassType.mage:
                return new OrkMage();
            default:
                throw new ArgumentException(nameof(classType));
        }
    }
}
