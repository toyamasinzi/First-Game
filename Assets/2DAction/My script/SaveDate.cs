using System;

/// <summary>
/// ゲームのデータ
/// </summary>
[Serializable]  // これをつけることでシリアル化ができるようになる
public class SaveData
{
    public string Name;

    public SaveData(string name)
    {
        this.Name = name;
    }
}
