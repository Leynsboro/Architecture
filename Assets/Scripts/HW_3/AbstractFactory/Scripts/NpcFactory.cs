public abstract class NpcFactory<T> where T : IRace
{
    public abstract T Spawn(ClassType classType);
}
