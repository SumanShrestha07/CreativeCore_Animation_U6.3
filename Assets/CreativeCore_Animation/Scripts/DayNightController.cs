using UnityEngine;

namespace CreativeCore_Animation.Scripts
{
    public class DayNightController : MonoBehaviour
    {
        private static readonly int Time1 = Animator.StringToHash("Time");
        [SerializeField] private Animator animator;
        

        private void OnTriggerEnter(Collider other)
        {
            animator.SetTrigger(Time1);
        }
        
        private void OnTriggerExit(Collider other){
            animator.SetTrigger(Time1);
        }
    }
}
