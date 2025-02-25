using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    // UI 요소들
    public Text nameText;   // 이름을 표시하는 텍스트
    public Text levelText;  // 레벨을 표시하는 텍스트
    public Slider hpSlider; // 체력을 표시하는 슬라이더

    // HUD를 설정하는 메서드
    public void SetHUD(Unit unit)
    {
        // 유닛의 이름을 텍스트로 설정
        nameText.text = unit.unitName;
        // 유닛의 레벨을 텍스트로 설정
        levelText.text = "Lvl " + unit.unitLevel;
        // 슬라이더의 최대값을 유닛의 최대 체력으로 설정
        hpSlider.maxValue = unit.maxHP;
        // 슬라이더의 값(체력)을 유닛의 현재 체력으로 설정
        hpSlider.value = unit.currentHP;
    }

    // 체력을 업데이트하는 메서드
    public void SetHP(int hp)
    {
        // 슬라이더의 값(체력)을 주어진 값으로 설정
        hpSlider.value = hp;
    }
}
