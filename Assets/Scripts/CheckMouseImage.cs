using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// 旋转饼状图的检测图片.
/// </summary>
public class CheckMouseImage : EventTrigger{

    private CreatePieChart createPieChart;

    void Start()
    {
        createPieChart = transform.parent.Find("PieChart").GetComponent<CreatePieChart>();
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);

        //createPieChart.IsDrag = true;
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);

        //createPieChart.IsDrag = false;
    }

}
