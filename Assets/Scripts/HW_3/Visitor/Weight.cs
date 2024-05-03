using System;
using UnityEngine;

namespace Assets.Visitor
{
    public class Weight : IDisposable
    {
        private const int MaxValue = 30;

        private int Value => _enemyVisitor.Weight;

        private EnemyVisitor _enemyVisitor;
        private IEnemySpawnNotifier _spawnNotifier;
        private Spawner _spawner;

        public Weight(Spawner spawnNotifier)
        {
            _spawner = spawnNotifier;
            _spawnNotifier = spawnNotifier;
            _spawnNotifier.SpawnNotified += OnEnemySpawn;

            _enemyVisitor = new EnemyVisitor();
        }

        public void Dispose()
        {
            _spawnNotifier.SpawnNotified -= OnEnemySpawn;
        }

        private void OnEnemySpawn(Enemy enemy)
        {
            enemy.Accept(_enemyVisitor);

            if (IsWeightFree() == false)
            {
                _spawner.StopWork();
            }
                

        }

        private bool IsWeightFree()
        {
            if (Value < MaxValue)
                return true;
            else
                return false;
        }

        private class EnemyVisitor : IEnemyVisitor
        {
            public int Weight { get; private set; }

            public void Visit(Elf elf) => Weight += 10;

            public void Visit(Human human) => Weight += 5;

            public void Visit(Ork ork) => Weight += 20;

            public void Visit(Robot robot) => Weight += 15;
        }
    }
}

