using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class SpawnerPlayer : MonoBehaviour
{
    [SerializeField] private GameObject male;
    [SerializeField] private GameObject vc;
    private GameObject player;
    void Start()
    {
        if (StaticData.PlayerGender != null)
            player = Instantiate(StaticData.PlayerGender, gameObject.transform);
        else 
           player =  Instantiate(male, gameObject.transform);

        player.transform.localPosition = new Vector3(0, 0, -0.1f);
        vc.gameObject.GetComponent<CinemachineVirtualCamera>().Follow = player.transform;
    }

   
}
