using UnityEngine;
using UnityEngine.Events;

namespace IronCarpStudios.Unity.Events
{
    [CreateAssetMenu(menuName = "Iron Carp Studios/Event Channels/Void")]
    public class VoidEventChannel : ScriptableObject
    {
        public UnityAction EventRaised;

        public void OnEventRaised()
        {
            EventRaised?.Invoke();
        }
    }
}
