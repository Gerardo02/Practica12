using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EventListener : MonoBehaviour
{
    private Renderer renderers;
    [SerializeField] GameObject panel;
    
    // Start is called before the first frame update
    void Start()
    {
        renderers = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnter()
    {
        renderers.material.color = Color.red;
        panel.gameObject.SetActive(true);
    }
    public void OnEnxit()
    {
        renderers.material.color = Color.white;
        panel.gameObject.SetActive(false);
    }
}
