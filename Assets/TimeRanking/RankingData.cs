using System;

/// <summary>
/// ゲームのデータ
/// </summary>
[Serializable]  // これをつけることでシリアル化ができるようになる
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
