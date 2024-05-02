using UnityEngine;
using System.Diagnostics;
using System.IO;
using System.Text;
public class test : MonoBehaviour
{   
    void Start()
    {
        RunPythonScript();
    }

    void RunPythonScript()
    {
        
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = "python"; // Python ���� ����
        start.Arguments = Path.Combine(Application.dataPath, "test.py"); // ���̽� ��ũ��Ʈ
        start.UseShellExecute = false;
        start.RedirectStandardOutput = true;
        start.StandardOutputEncoding = Encoding.UTF8;
        
        using (Process process = Process.Start(start))
        {
            using (StreamReader reader = process.StandardOutput)
            {
                string result = reader.ReadToEnd();
            }
        }
    }
}