using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SaludoUIManager : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;
    string nombreIngresado;

    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = "";
    }

    public void Saludar()
    {
        txtSaludo.text = "Hola " + inputNombre.text;
    }
}
