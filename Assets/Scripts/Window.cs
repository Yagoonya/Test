using UnityEngine;

namespace Scripts
{
    public class Window : MonoBehaviour
    {
        public void Close()
        {
            Destroy(gameObject);
        }
    }
}