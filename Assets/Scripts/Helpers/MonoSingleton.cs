using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log($"{typeof(T).ToString()} MonoSingletons is null");

            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if (_instance == null)
            _instance = this as T;
    }
}