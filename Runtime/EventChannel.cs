using UnityEngine;
using UnityEngine.Events;

namespace IronCarpStudios.Unity.Events
{
    public class EventChannel<T> : ScriptableObject
    {
        public UnityAction<T> RaiseEvent;

        public void OnRaiseEvent(T parameter)
        {
            RaiseEvent?.Invoke(parameter);
        }
    }

    public abstract class EventBroadcastChannels
    {

    }

    public abstract class EventListenChannels
    {

    }
}
