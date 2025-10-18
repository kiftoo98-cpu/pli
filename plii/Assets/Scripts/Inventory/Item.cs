using UnityEngine;

// ScriptableObject ��� �������� ������� ������ ��������
[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string itemName; // �������� ��������
    public Sprite icon;     // ������ ��������
    public bool isStackable; // ����� �� ���������� � ������

    // �����, ������� ����� ���� ������������� ��� ���������� �������� � ���������
    public virtual void Use()
    {
        Debug.Log($"����������� �������: {itemName}");
    }
}
