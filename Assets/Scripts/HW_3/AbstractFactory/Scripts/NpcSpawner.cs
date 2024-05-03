using UnityEngine;

public class NpcSpawner : MonoBehaviour
{
    [SerializeField] private Transform _firstSpawn;
    [SerializeField] private Transform _secondSpawn;

    [SerializeField] private RaceType _firstSpawnType;
    [SerializeField] private RaceType _secondSpawnType;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            SwapSpawnerRaceType();
    }

    private void SwapSpawnerRaceType()
    {
        RaceType previousType = _firstSpawnType;
        _firstSpawnType = _secondSpawnType;
        _secondSpawnType = previousType;
    }

    private void Spawn()
    {

    }

    private void BuildNpc(RaceType raceType, Transform spawnLocation)
    {

    }

}
