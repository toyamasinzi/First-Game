using System;

/// <summary>
/// �Q�[���̃f�[�^
/// </summary>
[Serializable]  // ��������邱�ƂŃV���A�������ł���悤�ɂȂ�
public class RankingData
{
    public float[] Times;

    public string[] Names;

    public RankingData(float[] times, string[] names)
    {
        this.Names = names;
        this.Times = times;
    }
}
