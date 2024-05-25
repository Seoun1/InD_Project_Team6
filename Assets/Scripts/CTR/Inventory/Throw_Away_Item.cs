using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Throw_Away_Item : MonoBehaviour
{
    public TMP_InputField discard_value; // ���� ���� �Է� �޾ƿ���
    public int discard_count;
    public void Throw_Item() // �κ��丮���� Ŭ���� ������ ����
    {
        discard_count = int.Parse(discard_value.GetComponent<TMP_InputField>().text);
        if(Inventory_Controller.g_ICinstance.g_Sclick_Slot.g_iitem_Number < discard_count)
        {
           // Inventory_Controller.g_ICinstance.lock_UI = true;
            print("�������� �����ۺ��� ���� �������� ������ �� �����ϴ�.");
        }
        else
        {
            Inventory_Controller.g_ICinstance.g_Sclick_Slot.g_iitem_Number -= discard_count;
            
        }
        
        if(Inventory_Controller.g_ICinstance.g_Sclick_Slot.g_iitem_Number != 0)
        {
            Inventory_Controller.g_ICinstance.g_Sclick_Slot.Refresh();
        }
        discard_value.GetComponent<TMP_InputField>().text = " ";
        discard_count = 0;
        gameObject.transform.parent.gameObject.SetActive(false);
        Inventory_Controller.g_ICinstance.lock_UI = true;
    }
}
