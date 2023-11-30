using UnityEngine;

public class Shop2OpenClose : MonoBehaviour
{
    [SerializeField] private Animator sAnimator;
    private bool isOpen;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOpen == false)
        {
            sAnimator.SetTrigger("TrOpen");
            isOpen = true;
        }

        else if (Input.GetKeyDown(KeyCode.Space) && isOpen)
        {
            sAnimator.SetTrigger("TrClose");
            isOpen = false;
        }
    }
}