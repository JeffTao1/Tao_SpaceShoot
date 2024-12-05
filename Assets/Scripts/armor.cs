using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class armor : MonoBehaviour
{
    public int maxHP =3;
    public int HP;
    public TextMesh hpShow;
    // Start is called before the first frame update
    private void Start()
    {
        HP = maxHP;
    }
    public void TakeDamge(int Damge)
    {
        HP -= Damge;
        if (HP < 0) HP = 0;
        UpdateHPText();

    }
    public void healcheck(float Heal)
    {
         
    }
    void UpdateHPText()
    {
       
    }
}
