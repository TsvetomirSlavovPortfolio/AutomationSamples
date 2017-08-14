using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Framework
{
    public class ExcelDataParser
    {
        static string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
        static string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
        static string projectPath = new Uri(actualPath).LocalPath;
        static string excelPath = projectPath + @"\TestData\";


        public static IEnumerable<TestCaseData> Test(string file)
        {
            {
                
                List<TestCaseData> testCaseDataList = new ExcelReader().ReadExcelData(excelPath + file);

                if (testCaseDataList != null)
                    foreach (TestCaseData testCaseData in testCaseDataList)
                        yield return testCaseData;
            }
    
    }
 
    }
}
