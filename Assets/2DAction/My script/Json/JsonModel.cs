using System.IO;
using UnityEditor;
using UnityEngine;

public static class JsonModel
{
    /// <summary>
    /// 指定されたパスからJsonファイルを読み込む関数
    /// </summary>
    /// <typeparam name="T">読み込みたいクラス</typeparam>
    /// <param name="path">読み込みたいデータのパス</param>
    /// <returns>読み込んだデータ</returns>
    public static T LoadJson<T>(string path)
    {
        using var reader = new StreamReader(path, System.Text.Encoding.GetEncoding("UTF-8"));

        var jsonStr = reader.ReadToEnd();
        reader.Close();

        Debug.Log($"通常ファイル読み込んだJsonファイルの内容{jsonStr}");

        return JsonUtility.FromJson<T>(jsonStr);
    }

    /// <summary>
    /// Jsonファイルを作る関数
    /// </summary>
    /// <param name="data">作りたいデータ</param>
    /// <param name="path">読み込みたいデータのパス</param>
    public static void CreateJson<T>(T data, string path)
    {
        using var writer = new StreamWriter(path);

        var jsonStr = JsonUtility.ToJson(data);

        Debug.Log($"作成したJsonファイルの内容{jsonStr}\nパス{path}");

        writer.Write(jsonStr);
        writer.Flush();
        writer.Close();
    }
}
