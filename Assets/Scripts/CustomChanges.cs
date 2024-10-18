using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Samples.ARStarterAssets;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;



public class CustomChanges : MonoBehaviour
{
    public Button red;
    public Button yellow;
    public Button blue;
    public ObjectSpawner ObjectSpawner;
    public ARInteractorSpawnTrigger ARInteractorSpawnTrigger;
    public GameObject currentObject;
    private MeshRenderer mr;

    private void Start()
    {
        ARInteractorSpawnTrigger.ObjectCreatedEvent.AddListener(Assignments);
        red.onClick.AddListener(Red);
        blue.onClick.AddListener(Blue);
        yellow.onClick.AddListener(Yellow);
    }

    private bool runOnce = false;

    private void Assignments()
    {
        if(runOnce == false)
        {
            currentObject = ObjectSpawner.instanceObj;
            mr = currentObject.GetComponentInChildren<MeshRenderer>();
            runOnce = true;
        }
   
    }

    public void Red()
    {
        Debug.Log("Changing Color Called Red");
        mr.material.color = Color.red;
    }

    public void Blue()
    {
        mr.material.color = Color.blue;
    }
    
    public void Yellow()
    {
        mr.material.color = Color.yellow;
    }
}


