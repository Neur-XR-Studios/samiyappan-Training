using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{


    public Transform[] followTargets; // An array of follow targets
    public float lookatSpeed;
    public float followSpeed;
    public Vector3 offset;

    private int currentTargetIndex = 0; // Index of the current follow target

    private void FixedUpdate()
    {
        if (followTargets.Length > 0 && currentTargetIndex >= 0 && currentTargetIndex < followTargets.Length)
        {
            LookAtTarget(followTargets[currentTargetIndex]);
            FollowTarget(followTargets[currentTargetIndex]);
        }
    }

    public void LookAtTarget(Transform target)
    {
        Vector3 lookDir = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(lookDir);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookatSpeed * Time.deltaTime);
    }

    public void FollowTarget(Transform target)
    {
        Vector3 targetPosition = target.position + (target.forward * offset.z + target.right * offset.x + target.up * offset.y);
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
    }

    public void SwitchTarget(int targetIndex)
    {
        if (targetIndex >= 0 && targetIndex < followTargets.Length)
        {
            currentTargetIndex = targetIndex;
        }
    }

   /* public Transform follow;
    public float lookatSpeed;
    public float followSpeed;
    public Vector3 offset;
    public void FixedUpdate()
    {
        Lookat();
        Follow();
    }
    public void Lookat()
    {
        Vector3 _lookDir = follow.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(_lookDir);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lookatSpeed * Time.deltaTime);
    }

    public void Follow()
    {
        Vector3 _tragetpos = follow.position + (follow.forward * offset.z + follow.right * offset.x + follow.up * offset.y);
        transform.position = Vector3.Lerp(transform.position, _tragetpos, lookatSpeed * Time.deltaTime);
    }*/
}