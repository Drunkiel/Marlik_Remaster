using UnityEngine;

public class InteractionController : MonoBehaviour
{
    public bool canInteract;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canInteract) Show();
        if (!canInteract) Hide();
    }

    public void Show()
    {
        canInteract = true;
        anim.Play("InteractWithObjects_Show");
    }

    public void Hide()
    {
        canInteract = false;
        anim.Play("InteractWithObjects_Hide");
    }
}
