using System.Collections.Generic;
using UnityEngine;

// ����� ��������� ��� ���������� ����������
public class Inventory : MonoBehaviour
{
    public static Inventory instance; // �������� ��� �������� �������

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Inventory ��� ����������!");
            return;
        }
        instance = this;
    }

    public List<Item> items = new List<Item>(); // ������ ��������� � ���������
    public int space = 20; // ������������ ���������� ���������

    // ������� ��� ����������� �� ���������� � ���������
    public delegate void OnItemChanged();
    public OnItemChanged onItemChangedCallback;

    // ����� ��� ���������� ��������
    public bool Add(Item item)
    {
        if (items.Count >= space)
        {
            Debug.Log("��� ����� � ���������!");
            return false;
        }

        items.Add(item);
        onItemChangedCallback?.Invoke(); // ���������� �� ����������
        return true;
    }

    // ����� ��� �������� ��������
    public void Remove(Item item)
    {
        items.Remove(item);
        onItemChangedCallback?.Invoke(); // ���������� �� ����������
    }
}
