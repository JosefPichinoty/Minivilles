using UnityEngine;

public class UiAnim : MonoBehaviour
{
    [SerializeField] private Animator sAnimator;
    [SerializeField] private Animator p1Animator;
    [SerializeField] private Animator p2Animator;
    [SerializeField] private Animator p3Animator;
    [SerializeField] private Animator p4Animator;
    
    private bool sIsOpen;
    private bool p1IsOpen;
    private bool p2IsOpen;
    private bool p3IsOpen;
    private bool p4IsOpen;
    private int lockUi = 0;

    public void shopOpen()
    {
        if (sIsOpen == false)
        {
            sAnimator.SetTrigger("sOpenTrigger"); 
            sIsOpen = true;
            lockUi = 5;
            closeOther();
        }

        else if (sIsOpen) 
        {
            sAnimator.SetTrigger("sCloseTrigger");
            sIsOpen = false;
        }  
        
    }
    public void p1Open()
    {
        if (p2IsOpen == false)
        {
            p1Animator.SetTrigger("p1OpenTrigger");
            p1IsOpen = true;
            lockUi = 1;
            closeOther();
        }

        else if (p1IsOpen)
        {
            p1Animator.SetTrigger("p1CloseTrigger");
            p1IsOpen = false;
        }
        
    }

    public void p2Open()
    {
        if (p2IsOpen == false)
        {
            p2Animator.SetTrigger("p2OpenTrigger");
            p2IsOpen = true;
            lockUi = 2;
            closeOther();
        }

        else if (p2IsOpen)
        {
            p2Animator.SetTrigger("p2CloseTrigger");
            p2IsOpen = false;
        }
        
    }

    public void p3Open()
    {
        if (p3IsOpen == false)
        {
            p3Animator.SetTrigger("p3OpenTrigger");
            p3IsOpen = true;
            lockUi = 3;
            closeOther();
        }

        else if (p3IsOpen)
        {
            p3Animator.SetTrigger("p3CloseTrigger");
            p3IsOpen = false;
        }
        
    }

    public void p4Open()
    {
        if (p4IsOpen == false)
        {
            p4Animator.SetTrigger("p4OpenTrigger");
            p4IsOpen = true;
            lockUi = 4;
            closeOther();
        }

        else if (p4IsOpen)
        {
            p4Animator.SetTrigger("p4CloseTrigger");
            p4IsOpen = false;
        }
    }

  private void closeOther()
    {
        if (p1IsOpen == true && lockUi != 1)
        {
            p1Animator.SetTrigger("p1CloseTrigger");
            p1IsOpen = false;
        }
        else if (p2IsOpen == true && lockUi != 2)
        {
            p2Animator.SetTrigger("p2CloseTrigger");
            p2IsOpen = false;
        }
    
        else if (p3IsOpen == true && lockUi != 3)
        {
            p3Animator.SetTrigger("p3CloseTrigger");
            p3IsOpen = false;
        }
    
        else if (p4IsOpen == true && lockUi != 4)
        {
            p4Animator.SetTrigger("p4CloseTrigger");
            p4IsOpen = false;
            
        }
        else if (sIsOpen == true && lockUi != 5)
        {
            sAnimator.SetTrigger("sCloseTrigger");
        }
        
        
    }
   
}