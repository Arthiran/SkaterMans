using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyControlScript : MonoBehaviour
{
    public Transform[] FootTarget;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        for (int i = 0; i < FootTarget.Length; i++)
        {
            var foot = FootTarget[i];
            var ray = new Ray(foot.transform.position + Vector3.up * 0.5f, Vector3.down);
            var hitInfo = new RaycastHit();
            if (Physics.SphereCast(ray, 0.05f, out hitInfo, 0.5f))
            {
                foot.position = hitInfo.point + Vector3.up * 0.05f;
                foot.rotation = Quaternion.FromToRotation(transform.up, hitInfo.normal);
            }
        }
    }
}
