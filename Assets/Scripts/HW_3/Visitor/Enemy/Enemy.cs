using System;
using UnityEngine;

namespace Assets.Visitor
{
    public abstract class Enemy: MonoBehaviour
    {
        public event Action<Enemy> Died;

        public abstract void Accept(IEnemyVisitor visitor);

        //Какая то общая логика врага: передвижение, жизни и тп.

        public void MoveTo(Vector3 position) => transform.position = position;

        public void Kill()
        {
            Died?.Invoke(this);
            Destroy(gameObject);
        }
    }
}
