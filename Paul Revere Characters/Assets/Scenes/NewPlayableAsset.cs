using System.Collections;
using System.Collections.Generic;
using System.Net.Mail;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class NewPlayableAsset : PlayableAsset
{ NewPlayableAsset exttra derive(MonoBehaviour);

    public NewPlayableAsset Playable1 { get => Playable; set => Playable = value; }
    public NewPlayableAsset Extra { get => Extra1; set => Extra1 = value; }
    public NewPlayableAsset Extra1 { get => extra; set => extra = value; }

    public override Playable NewPlayableAsset(PlayableGraph graph, GameObject go)
    {
        prop CreatePlayable(NewPlayableAsset);
    }
}
