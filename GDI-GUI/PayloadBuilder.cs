using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDI_GUI.Properties;

namespace GDI_GUI
{
    public class PayloadBuilder
    {
        private StringBuilder payloadCode;
        private bool synchronis;
        private const string SleepStatement = "\n    Sleep(timeInBetween);";

        public PayloadBuilder(int timePerEffect, bool synchronis)
        {
            this.synchronis = synchronis;
            payloadCode = new StringBuilder($"int timePerEffect = {timePerEffect};\n");
        }

        public void AddEffect(string functionName, string parameters = "")
        {
            if (!synchronis)
            { 
                payloadCode.AppendLine($"    {functionName}({parameters}timePerEffect);{SleepStatement}");
            }
            else
            {
                //std::thread StaticThread = std::thread(Static, 150000000);
                payloadCode.AppendLine($"    auto thr_{functionName} = std::thread({functionName},{parameters} timePerEffect);");
            }

        }

        public void AddThreadedEffect(string threadName, string shaderFunction)
        {
            if (!synchronis)
            {
                payloadCode.AppendLine($"""
        
        HANDLE {threadName} = CreateThread(0, 0, {shaderFunction}, 0, 0, 0);
        Sleep(timePerEffect * 1000);
        TerminateThread({threadName}, 0);
        CloseHandle({threadName});
        {SleepStatement}
        """);
            }
            else
            {
                payloadCode.AppendLine($"""
        
        HANDLE {threadName} = CreateThread(0, 0, {shaderFunction}, 0, 0, 0);
        {SleepStatement}
        """);
            }
        }

        public void BuildFile()
        {
            if(synchronis) payloadCode.AppendLine($"    Sleep(timePerEffect * 1000);");

            string filePath = $"{Path.GetTempPath()}\\GDI-GUI-CustomStub.cpp";
            string fileContent = Resources.stub.Replace("//METHODSHERE", payloadCode.ToString());
            File.WriteAllText(filePath, fileContent);
        }
    }
}
