using UnityEngine;
using Zenject;

namespace HW4.Mediator
{
    public class MediatorInstaller : MonoInstaller
    {
        [SerializeField] private DefeatPanel _defeatPanel;

        public override void InstallBindings()
        {
            BindLevel();
            BindMediator();
            BindDefeatPanel();
            BindExample();
        }

        private void BindExample()
        {
            Container.BindInterfacesAndSelfTo<Example>().AsSingle();
        }

        private void BindDefeatPanel()
        {
            Container.Bind<DefeatPanel>().FromInstance(_defeatPanel).AsSingle();
        }

        private void BindMediator()
        {
            Container.BindInterfacesAndSelfTo<GameplayMediator>().AsSingle();
        }

        private void BindLevel()
        {
            Container.Bind<Level>().AsSingle();
        }
    }
}

