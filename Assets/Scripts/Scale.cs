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
        //Permet de vérifier si le bouton A de la manette est activé et vérifie si la grosseur du cube est plus petit de 5
        if (scaleReferenceUp.action.triggered && cubePrincipal.gameObject.transform.localScale.x < 5)
        {
            //Permet d'ajouter un scale au cube
            cubePrincipal.gameObject.transform.localScale += vector3;
        }
        //Permet de vérifier si le bouton B de la manette est activé et vérifie si la grosseur du cube est plus grand que 1
        if (scaleReferenceDown.action.triggered && cubePrincipal.gameObject.transform.localScale.x > 1)
        {
            //Permet d'enlever un sacle au cube
            cubePrincipal.gameObject.transform.localScale -= vector3;
        }
    }
}
