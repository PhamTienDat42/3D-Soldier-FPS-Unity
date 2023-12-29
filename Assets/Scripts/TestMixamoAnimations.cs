using UnityEngine;

public class TestMixamoAnimations : MonoBehaviour
{
    [SerializeField] private Animator swatAnimator;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            swatAnimator.SetBool(Constants.IsRun, true);
        }
        else
        {
            swatAnimator.SetBool(Constants.IsRun, false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            swatAnimator.SetTrigger(Constants.RunLeft);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            swatAnimator.SetTrigger(Constants.RunBackward);

        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            swatAnimator.SetTrigger(Constants.RunRight);
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            swatAnimator.SetTrigger(Constants.RunForward);
        }
    }
}
