public abstract class NpcFactory<T> where T : Class
{
    public abstract T Spawn(RaceType raceType);
}
