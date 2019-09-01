using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Analys
{
    class Program
    {
        static void ConvertData(
            ushort[] data, 
            out ConvertedData receivedData
        )
        {
            const ushort mask1 = 0x0013;
            const ushort mask2 = 0x07FF;
            receivedData.code = new ushort[4];
            receivedData.values = new ushort[4];
            for (int i = 0; i < data.Length; i++)
            {
                ushort tmp = (ushort)(data[i]>>11);
                receivedData.code[i] = (ushort)(tmp & mask1);
                receivedData.values[i] = (ushort)(data[i] & mask2);
            }
        }
        static void Print()
        {

        }
        static void Middle()
        {

        }
        struct ConvertedData
        {
            public ushort[] code;
            public ushort[] values;
        }
        static void Main(string[] args)
        {
            ushort[] data = {0x180C, 0x100A, 0x1809, 0x0809};
            ConvertedData receivedData;
            ConvertData(data, out receivedData);
            Console.WriteLine("Данные:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i + "  " + receivedData.code[i] + "  " + receivedData.values[i]);
            }
        }
    }
}
