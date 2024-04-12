using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Material_Controller : MonoBehaviour
{
    public GameObject targetObject;
    public Material[] exampleMat = new Material[2];
    private int i;

    // �� ��ư Ŭ�� �� ȣ��� �Լ�
    public void ChangeMaterial(Button clickedButton)
    {
        Debug.Log("?2");
        string buttonTag = clickedButton.tag;
        Renderer renderer = targetObject.GetComponent<Renderer>();
        switch (clickedButton.tag)
        {
            case "Mat1":
                i = 0;
                break;

            case "Mat2":
                i = 1;
                Debug.Log("?");
                break;

        }

        renderer.material = exampleMat[i];
    }
}