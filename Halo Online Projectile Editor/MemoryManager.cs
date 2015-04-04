using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace Halo_Online_Projectile_Editor
{
    class MemoryManager
    {
        public enum ProcessAccessFlags : uint
        {
            All = 0x001F0FFF,
            Terminate = 0x00000001,
            CreateThread = 0x00000002,
            VMOperation = 0x00000008,
            VMRead = 0x00000010,
            VMWrite = 0x00000020,
            DupHandle = 0x00000040,
            SetInformation = 0x00000200,
            QueryInformation = 0x00000400,
            Synchronize = 0x00100000
        }

        [DllImport("kernel32.dll")]
        static extern IntPtr OpenProcess(ProcessAccessFlags dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern Int32 CloseHandle(IntPtr hProcess);

        public static void WriteToAddress(uint address, byte[] hex)
        {
            var p = Process.GetProcessesByName("eldorado").FirstOrDefault();
            IntPtr startOffset = p.MainModule.BaseAddress;
            var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);

            int unused = 0;
            IntPtr addr = new IntPtr(address);
            Debug.WriteLine("writing {0} to {1}", BitConverter.ToString(hex), addr.ToString("X"));
            WriteProcessMemory(hProc, addr, hex, (UInt32)hex.LongLength, out unused);

            CloseHandle(hProc);
        }

        public static uint ReadUntilFindBytes(byte[] hex)
        {

            var p = Process.GetProcessesByName("eldorado").FirstOrDefault();
            IntPtr startOffset = p.MainModule.BaseAddress;
            var hProc = OpenProcess(ProcessAccessFlags.All, false, (int)p.Id);
            int unused = 0;
            int SCAN_CHUNK_SIZE = 0x10000;

            byte[] rhex = new byte[SCAN_CHUNK_SIZE];

            for (IntPtr i = new IntPtr(0x0D000000); i.ToInt32() < 0x18000000; i = IntPtr.Add(i, SCAN_CHUNK_SIZE))
            {
                ReadProcessMemory(hProc, i, rhex, (uint)SCAN_CHUNK_SIZE, out unused);
                for (int chunk_idx = 0; chunk_idx <= (SCAN_CHUNK_SIZE - hex.Length); chunk_idx++)
                {
                    int byte_idx;
                    for (byte_idx = 0; byte_idx < hex.Length; byte_idx++)
                    {
                        if (hex[byte_idx] != rhex[chunk_idx + byte_idx]) break;
                    }
                    if (byte_idx == hex.Length)
                    {
                        CloseHandle(hProc);
                        return (uint)(i.ToInt32() + chunk_idx);
                    }

                }

            }
            CloseHandle(hProc);
            return 0;
        }
    }
}
