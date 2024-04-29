using TMPro;
using UnityEngine;

namespace Mediator
{
    public class PlayerPanel : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _healthValueText;
        [SerializeField] private TextMeshProUGUI _levelValueText;

        public void SetupNewValues(int health, int level)
        {
            _healthValueText.text = health.ToString();
            _levelValueText.text = level.ToString();
        }
    }
}

