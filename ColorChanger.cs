using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material pinkMatirial;
    public Material greyMatirial;
    public Material whiteMatirial;
    public Material blueMatirial;

    public void SetPink()
    {
        SetMatirial(pinkMatirial);
    }

    public void SetGrey()
    {
        SetMatirial(greyMatirial);
    }

    public void SetWhite()
    {
        SetMatirial(whiteMatirial);
    }

    public void SetBlue()
    {
        SetMatirial(blueMatirial);
    }

    private void SetMatirial(Material newMatirial)
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        renderer.material = newMatirial;
    }
}
