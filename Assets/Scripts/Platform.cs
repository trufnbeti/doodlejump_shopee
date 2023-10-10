using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform itemSpawnPoint;
    [SerializeField] protected Rigidbody2D m_rb;
    // Start is called before the first frame update
    protected virtual void Start() {
        if (!GameManager.Ins) return;

        if (itemSpawnPoint) {
            Debug.Log("Spawn item");
        }
		Debug.Log((GameTag.LeftCorner.ToString()));

	}
	public virtual void PlatformAction() {

	}
}
