using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class FirstDecision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var timelineAsset = this.gameObject.GetComponent<PlayableDirector>().playableAsset as TimelineAsset;
        var animationtrack = timelineAsset.GetOutputTrack(1) as AnimationTrack;
        IEnumerable clips = animationtrack.GetClips();
        var clip = clips.GetEnumerator();
        print(clip);
        
    }
}
