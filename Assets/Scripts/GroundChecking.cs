using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecking : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col) {
        if (!GameManager.Ins || !GameManager.Ins.player) return;
        if (!col.CompareTag(GameTag.Platform.ToString())) return;
        GameManager.Ins.player.Jump();
    }
}
