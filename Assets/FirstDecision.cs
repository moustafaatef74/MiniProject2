using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class FirstDecision : MonoBehaviour
{
    public GameObject FirstCanvas;
    public GameObject DecisionOne;
    public GameObject DecisionTwo;
    public GameObject DecisionTwoAnim;
    bool Select = true;
    // Start is called before the first frame update
    void Start()
    {
        DecisionOne.GetComponent<Button>().onClick.AddListener(() => {
            this.gameObject.GetComponent<PlayableDirector>().Play();
        });
        DecisionTwo.GetComponent<Button>().onClick.AddListener(() => {
            this.gameObject.GetComponent<PlayableDirector>().Play();
        });
    }

    // Update is called once per frame
    void Update()
    {
    }

}
