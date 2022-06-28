using System.IO;
using UnityEditor;
using UnityEngine;

public static class JsonModel
{
    /// <summary>
    /// �w�肳�ꂽ�p�X����Json�t�@�C����ǂݍ��ފ֐�
    /// </summary>
    /// <typeparam name="T">�ǂݍ��݂����N���X</typeparam>
    /// <param name="path">�ǂݍ��݂����f�[�^�̃p�X</param>
    /// <returns>�ǂݍ��񂾃f�[�^</returns>
    public static T LoadJson<T>(string path)
    {
        using var reader = new StreamReader(path, System.Text.Encoding.GetEncoding("UTF-8"));

        var jsonStr = reader.ReadToEnd();
        reader.Close();

        Debug.Log($"�ʏ�t�@�C���ǂݍ���Json�t�@�C���̓��e{jsonStr}");

        return JsonUtility.FromJson<T>(jsonStr);
    }

    /// <summary>
    /// Json�t�@�C�������֐�
    /// </summary>
    /// <param name="data">��肽���f�[�^</param>
    /// <param name="path">�ǂݍ��݂����f�[�^�̃p�X</param>
    public static void CreateJson<T>(T data, string path)
    {
        using var writer = new StreamWriter(path);

        var jsonStr = JsonUtility.ToJson(data);

        Debug.Log($"�쐬����Json�t�@�C���̓��e{jsonStr}\n�p�X{path}");

        writer.Write(jsonStr);
        writer.Flush();
        writer.Close();
    }
}
