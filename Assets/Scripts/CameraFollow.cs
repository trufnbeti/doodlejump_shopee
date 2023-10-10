using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public static CameraFollow Ins;
	public Transform target;
    public Vector3 offset;
    [Range(1, 10)]
    public float smoothFactor;
	private void Awake() {
		Ins = this;
	}
	private void FixedUpdate() {
        Follow();
    }
    private void Follow() {
        if (target == null || target.transform.position.y < transform.position.y) return;
        Vector3 targetPos = new Vector3(0f, target.transform.position.y, 0f) + offset;
        Vector3 smoothPos = Vector3.Lerp(transform.position, targetPos, smoothFactor * Time.deltaTime);
        transform.position = new Vector3(
            Mathf.Clamp(smoothPos.x, 0, smoothPos.x),
            Mathf.Clamp(smoothPos.y, 0, smoothPos.y),
            -10f);
    }
}
