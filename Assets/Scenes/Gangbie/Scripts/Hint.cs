using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Hint : Item, IUseable
{
    [SerializeField] GameObject hintCanvas;
    [SerializeField] List<GameObject> hintColliders;
    public UnityEvent hintSound;

    public LayerMask hintLayer;

    private int hintCount = 5;
    public int leftHintCount { get { return hintCount - 1; } }

    public int triggerNum;

    public void Use()
    {
        if (hintCount > 0)
        {
            StartCoroutine(hintRoutine());
            hintCount--;
        }
    }

    IEnumerator hintRoutine()
    {
        hintCanvas.SetActive(true);
        yield return new WaitForSeconds(5);
        hintCanvas.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        hintSound?.Invoke();
        if (other.gameObject.layer == hintColliders[0].layer)
        {
            if (other.gameObject == hintColliders[0])
            {
                triggerNum = 1;
                Use();
            }
            else if (other.gameObject == hintColliders[1])
            {
                triggerNum = 2;
                Use();
            }
            else if (other.gameObject == hintColliders[2])
            {
                triggerNum = 3;
                Use();
            }
            else if (other.gameObject == hintColliders[3])
            {
                triggerNum = 4;
                Use();
            }
            else if (other.gameObject == hintColliders[4])
            {
                triggerNum = 5;
                Use();
            }
            else if (other.gameObject == hintColliders[5])
            {
                triggerNum = 6;
                Use();
            }
        }
    }
}
