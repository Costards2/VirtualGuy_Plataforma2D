using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetarChave : MonoBehaviour
{
    private bool coletouChave = false;

    private void OnTriggerEnter2D(Collider2D colisor){
        if(colisor.gameObject.tag == "Player" && coletouChave == false){
            coletouChave = true;
            PlayerMng.Instance.IncrementarChave();
            Destroy(gameObject);
        }
    }
}
