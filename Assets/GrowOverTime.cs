using UnityEngine;

public class GrowOverTime : MonoBehaviour {
    [Tooltip("The maximum random scale factor per frame.")]
    [Range(0.1f, 3)]
    public float maxScalePerFrame = 0.5f;
	
	void Update () {
        float randomScale = Random.Range(0.1f, maxScalePerFrame);
        transform.localScale += new Vector3(Time.deltaTime * randomScale,
                                            Time.deltaTime * randomScale,
                                            Time.deltaTime * randomScale);
    }
}
