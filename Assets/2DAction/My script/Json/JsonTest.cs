using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Json��ۑ�������ǂݍ��񂾂肷��̂��m�F����X�N���v�g
/// </summary>
public class JsonTest : MonoBehaviour
{
    RankingData _rankingData;
    void Start()
    {
        JsonModel.CreateJson(new RankingData(new float[] {10f, 5f},//�ۑ�
            new string[] {"�v���C���[A", "�v���C���[B" }),
            Application.persistentDataPath + "/RankingData.json");

        RankingData _data = JsonModel.LoadJson<RankingData>(Application.persistentDataPath + "/RankingData.json");//���[�h
        
        for(int i = 0; i < _data.Names.Length; i++)//�����L���O
        {
            print($"{_data.Names[i]}��{_data.Times[i]}�b�ɃS�[������");
        }
    }
}
