using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public Text diffText;
    public int diffInt;

    public void diffIncrease() {
        if (diffInt < 20) {
            diffInt = diffInt + 1;
            diffText.text = diffInt.ToString();
        }
    }

    public void diffDecrease() {
        if (diffInt > 0) {
            diffInt = diffInt - 1;
            diffText.text = diffInt.ToString();
        }
    }
}