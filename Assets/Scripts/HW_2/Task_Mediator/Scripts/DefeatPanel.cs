using UnityEngine;
using UnityEngine.UI;


namespace Mediator
{
    public class DefeatPanel : MonoBehaviour
    {
        [SerializeField] private Button _restartButton;

        private GameplayMediator _mediator;

        private void OnEnable() => _restartButton.onClick.AddListener(OnRestartClick);
        private void OnDisable() => _restartButton.onClick.RemoveListener(OnRestartClick);

        public void Init(GameplayMediator mediator) => _mediator = mediator;

        public void Show() => gameObject.SetActive(true);
        public void Hide() => gameObject.SetActive(false);

        private void OnRestartClick() => _mediator.RestartLevel();
    }
}

