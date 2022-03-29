using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Scale : MonoBehaviour
{
    [SerializeField] private InputActionReference scaleReferenceUp;
    [SerializeField] private InputActionReference scaleReferenceDown;
    public GameObject cubePrincipal;
    private Vector3 vector3 = new Vector3(0.5f, 0.5f, 0.5f);

    // Update is called once per frame
    void Update()
    {
        if (scaleReferenceUp.action.triggered && cubePrincipal.gameObject.transform.localScale.x < 5)
        {
            cubePrincipal.gameObject.transform.localScale += vector3;
            Debug.Log("A");
        }
        if (scaleReferenceDown.action.triggered && cubePrincipal.gameObject.transform.localScale.x > 1)
        {
            Debug.Log("B");
            cubePrincipal.gameObject.transform.localScale -= vector3;
        }
    }
}
