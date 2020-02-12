using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace AOR8200Manager
{
    public class Utils
    {
        public DataTable LoadTableFromCSV(string filename)
        {
            DataTable dt = new DataTable();
            using (StreamReader s = new StreamReader(filename))
            {
                string[] headers = s.ReadLine().Split(',');
                foreach (string h in headers)
                {
                    dt.Columns.Add(h);
                }

                while (!s.EndOfStream)
                {
                    string[] vals = s.ReadLine().Split(',');
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < vals.Length; i++)
                    {
                        dr[i] = vals[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }

        public string FormatMode(string mode)
        {
            switch (mode)
            {
                case "WFM":
                    return "0";

                case "NFM":
                    return "1";

                case "AM":
                    return "2";

                case "USB":
                    return "3";

                case "LSB":
                    return "4";

                case "CW":
                    return "5";

                case "SFM":
                    return "6";

                case "WAM":
                    return "7";

                case "NAM":
                    return "8";

                default:
                    return "3";
            }
        }


        public string FormatFreq(string freq)
        {
            // if no decimal, then assume whole number and add the decimal
            if (freq.IndexOf('.') == -1)
            {
                freq = freq + ".0";
            }

            char[] delim = new char[] { '.' };
            string[] parts = freq.Split(delim, 2);

            string leftPart = parts[0].PadLeft(4, '0');
            string rightPart = parts[1].PadRight(5, '0');
            return (leftPart + "." + rightPart);
        }

        public string FormatChannel(string channel)
        {
            return (channel.PadLeft(2, '0'));
        }

        public List<string> GenerateTestFreqs()
        {
            List<string> testFreqs = new List<string>();

            testFreqs.Add("MXA04 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1");
            testFreqs.Add("MXA05 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2");
            testFreqs.Add("MXa08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXa09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXB08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXB09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXb08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXb09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXC08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXC09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXc08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXc09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXD08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXD09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXd08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXd09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXE08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXE09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXe08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXe09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXF08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXF09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXf08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXf09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXG08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXG09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXg08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXg09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXH08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXH09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXh08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXh09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXI08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXI09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXi08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXi09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXJ08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXJ09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");
            testFreqs.Add("MXj08 RF0008.99200 AU1 ST001.00 MD3 AT0 TMTest Freq 1\r");
            testFreqs.Add("MXj09 RF0011.17500 AU1 ST001.00 MD3 AT0 TMTest Freq 2\r");

            return testFreqs;
        }

        public List<string> GenerateBankDeletes()
        {
            List<string> bankDeletes = new List<string>();

            bankDeletes.Add("MQA%%");
            bankDeletes.Add("MQa%%");
            bankDeletes.Add("MQB%%");
            bankDeletes.Add("MQb%%");
            bankDeletes.Add("MQC%%");
            bankDeletes.Add("MQc%%");
            bankDeletes.Add("MQD%%");
            bankDeletes.Add("MQd%%");
            bankDeletes.Add("MQE%%");
            bankDeletes.Add("MQe%%");
            bankDeletes.Add("MQF%%");
            bankDeletes.Add("MQf%%");
            bankDeletes.Add("MQG%%");
            bankDeletes.Add("MQg%%");
            bankDeletes.Add("MQH%%");
            bankDeletes.Add("MQh%%");
            bankDeletes.Add("MQI%%");
            bankDeletes.Add("MQi%%");
            bankDeletes.Add("MQJ%%");
            bankDeletes.Add("MQj%%");

            return bankDeletes;
        }


        public string ConvertToASCII(string RxBuffer)
        {
            string finalValue = String.Empty;
            foreach (char c in RxBuffer)
            {
                if (c == '\r')
                {
                    finalValue += "<CR>";
                }
                else if (c == '\n')
                {
                    finalValue += "<LF>";
                }
                else
                {
                    finalValue += c.ToString();
                }
            }
            return finalValue;
        }

    }
}
