using UnityEngine;

namespace Scripts
{
    public class ScrollItem : MonoBehaviour
    {
        public void DestroyOnClick()
        {
            Destroy(gameObject);
        }
    }
}