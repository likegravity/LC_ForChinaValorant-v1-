using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChToEngBackdoorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LngChanger     Made By LikeGravity";
            //chinaGameFolder == 원래게임폴더경로  (C:\Tencent Games\VALORANT\live\ShooterGame\Content\Paks)
            string chinaGameFolder = File.ReadAllText("china.txt");
            // koreanGameFolder == 걍 한국발로 폴더 (C:\Riot Games\VALORANT\live\ShooterGame\Content\Paks)
            string koreanGameFolder = File.ReadAllText("korea.txt");
            //언어 설정파일 ex) en_US ko_KR
            string Lang = File.ReadAllText("Lang.txt");
            Console.WriteLine("");
            Console.WriteLine("[1] 실행");
            string read = Console.ReadLine();
            if (read == "1")
            {

                //원래 짱깨파일을 짱깨파일 2로 이름변환하려했다가 굳이?라는생각이듬 어차피 클라이언트 런쳐에서 손상파일자동보정해줌 ㅇ
                //그래서 걍 없앴음 ㅋ
                File.Delete(chinaGameFolder + "\\zh_CN_Audio-WindowsClient.pak");
                File.Delete(chinaGameFolder + "\\zh_CN_Audio-WindowsClient.sig");
                File.Delete(chinaGameFolder + "\\zh_CN_Text-WindowsClient.pak");
                File.Delete(chinaGameFolder + "\\zh_CN_Text-WindowsClient.sig");
                //한국 언어파일을 불러서 중국파일로 이름 바꿔치기
                File.Copy(koreanGameFolder + "\\" + Lang + "_Audio-WindowsClient.pak", chinaGameFolder + "\\zh_CN_Audio-WindowsClient.pak");
                File.Copy(koreanGameFolder + "\\" + Lang + "_Audio-WindowsClient.sig", chinaGameFolder + "\\zh_CN_Audio-WindowsClient.sig");
                File.Copy(koreanGameFolder + "\\" + Lang + "_Text-WindowsClient.pak", chinaGameFolder + "\\zh_CN_Text-WindowsClient.pak");
                File.Copy(koreanGameFolder + "\\" + Lang + "_Text-WindowsClient.sig", chinaGameFolder + "\\zh_CN_Text-WindowsClient.sig");
            }

        }
    }
}
