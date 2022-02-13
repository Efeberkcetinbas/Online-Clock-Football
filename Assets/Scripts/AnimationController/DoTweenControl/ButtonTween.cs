using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonTween : MonoBehaviour,IDoTween
{
    [SerializeField] private float x, y, duration, old_x, old_y;

    [SerializeField] private Ease ease;

    void Start()
    {
        DoDoTween();
    }

    public void DoDoTween()
    {
        gameObject
            .transform.DOScale(new Vector2(x, y), duration)
            .SetEase(ease)
            .OnComplete(() => gameObject.transform.DOScale(new Vector2(old_x, old_y), duration)
            .SetLoops(-1, LoopType.Yoyo));
    }
}
