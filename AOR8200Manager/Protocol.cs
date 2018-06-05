using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace AOR8200Manager
{
    public static class Protocol
    {
        const byte STX = 0x02;
        const byte ETX = 0x03;

        public static void SendCommand(SerialPort sp, byte[] cmd)
        {
            byte[] psrCmd = new byte[cmd.Length + 1];   // total command length + sum byte

            // copy command into byte array to be sent
            for (int i = 0; i < cmd.Length; i++)
            {
                psrCmd[i] = cmd[i];
            }

            // now append the checksum
            psrCmd[psrCmd.Length - 1] = CalcChecksum(cmd);

            // send it
            sp.Write(psrCmd, 0, psrCmd.Length);

            string test = "hello" + ETX;

            
            
        }

        public static byte[] GetLCD()
        {
            byte[] cmd = new byte[3] { STX, 0x4C, ETX };
            return cmd;
        }

        public static byte[] GetStatus()
        {
            byte[] cmd = new byte[3] { STX, 0x41, ETX };
            return cmd;
        }

        public static byte[] SendKey(byte keycode)
        {
            byte[] cmd = new byte[4];
            cmd[0] = STX;
            cmd[1] = 0x4B;
            cmd[2] = keycode;
            cmd[3] = ETX;
            return cmd;
        }

        private static byte CalcChecksum(byte[] Value)
        {
            byte cksum;

            cksum = 0;
            for (int idx = 1; idx < Value.Length; idx++)
            {
                cksum += Value[idx];
            }
            return cksum;
        }

        private static string ByteArrayToString(byte[] ba)
        {
            string hex = BitConverter.ToString(ba);
            return hex.Replace("-", "");
        }

    }
}
