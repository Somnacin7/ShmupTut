using UnityEngine;
using System.Collections;

public class OnDestroyGameOver : MonoBehaviour
{
    void OnDestroy()
    {
        GameManager.instance.gameOver = true;
    }
}