using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootControl : MonoBehaviour
{
    public Transform[] RayTargets;
    public Transform[] FootTargets;
    private float distance = 0.13f;
    private float startingDistance;
    private Vector3 previousLeftPosition;
    private Vector3 previousRightPosition;
    private Vector3 freezePosition;
    private Vector3 newRightPosition;
    private int counter = 0;
    private bool canMoveRight = false;
    private bool canMoveLeft = false;
    private void Start()
    {
        previousRightPosition = FootTargets[0].transform.position;
        previousLeftPosition = FootTargets[1].transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        /*for (int i = 0; i < RayTargets.Length; i++)
        {
            Transform rayTarget = RayTargets[i];
            Ray ray = new Ray(rayTarget.transform.position + Vector3.up * distance * 10, Vector3.down);
            RaycastHit hitInfo = new RaycastHit();
            if (Physics.SphereCast(ray, distance, out hitInfo, distance * 10))
            {
                rayTarget.position = hitInfo.point + Vector3.up * distance;
                if (Physics.Raycast(rayTarget.position, -Vector3.up, out hitInfo, distance * 10))
                {
                    rayTarget.localRotation = Quaternion.FromToRotation(transform.up, hitInfo.normal);
                }
            }
        }
        FootTargets[1].SetPositionAndRotation(RayTargets[1].transform.position, RayTargets[1].transform.rotation);

        if (Mathf.Abs(Vector3.Distance(RayTargets[0].transform.position, FootTargets[0].transform.position)) > 0.8f)
        {
            if (!canMoveRight)
            {
                canMoveRight = true;
                RayTargets[2].transform.position = FootTargets[0].transform.position;
                newRightPosition = RayTargets[0].transform.position;
                previousRightPosition = newRightPosition;
                startingDistance = Vector3.Distance(FootTargets[0].transform.position, newRightPosition);
            }
            FootTargets[0].position = RayTargets[2].transform.position;
        }

        if (canMoveRight)
        {
            Vector3 targetPos = Vector3.zero;
            if (startingDistance / Vector3.Distance(FootTargets[0].transform.position, newRightPosition) <= 1)
            {
                targetPos = newRightPosition + Vector3.up / 2;
            }
            else
            {
                targetPos = newRightPosition;
            }
            Debug.Log("hooo");
            FootTargets[0].transform.position = Vector3.MoveTowards(FootTargets[0].transform.position, newRightPosition, 1f * Time.deltaTime);
            if (FootTargets[0].transform.position == newRightPosition)
            {
                canMoveRight = false;
            }
        }
        else
        {
            //FootTargets[0].transform.position = Vector3.MoveTowards(previousRightPosition, RayTargets[2].transform.position, 1f * Time.deltaTime);
            FootTargets[0].SetPositionAndRotation(previousRightPosition, RayTargets[2].transform.rotation);
        }*/

    }
}
