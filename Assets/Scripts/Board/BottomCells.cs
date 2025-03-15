using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCells : MonoBehaviour
{
    public static BottomCells Instance;
    public List<Cell> botcells = new List<Cell>();
    public Item[] items;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this);
        items = new Item[5];
    }
    public void MoveToBotCells(Cell cell)
    {
        for (int i = 0; i < botcells.Count; i++)
        {
            if (items[i] == null)
            {
                Item item = cell.Item;
                items[i] = item;
                cell.Free();
                botcells[i].Free();

                item.View.DOMove(botcells[i].transform.position, 0.6f);
                item.View.DOScale(Vector3.one * 1.5f, 0.3f)
                    .OnComplete(() => item.View.DOScale(Vector3.one, 0.3f));
            }
        }
        for (int i = 0; i < botcells.Count; i++)
        {
            //items[i].
        }
    }
}
