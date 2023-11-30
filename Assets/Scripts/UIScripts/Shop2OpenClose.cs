using UnityEngine;

public class Shop2OpenClose : MonoBehaviour
{
    [SerializeField] private Animator sAnimator;
    private bool isOpen = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab) && isOpen == false)
        {
            sAnimator.SetTrigger("OpenTrigger");
            isOpen = true;
        }

        else if (Input.GetKeyDown(KeyCode.Tab) && isOpen == true)
        {
            sAnimator.SetTrigger("CloseTrigger");
            isOpen = false;
        }
    }
}