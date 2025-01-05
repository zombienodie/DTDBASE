// 05/01/2025 00:00:00 CH Version NSN(NEW STEP NOTHING)
// Protector Wisdom and Time 
// Good Luck
//                                       .""--..__
//                      _                     []       ``-.._
//                   .'` `'.                  ||__           `-._
//                  /    ,-.\                 ||_ ```---..__     `-.
//                 /    /:::\\               /|//}          ``--._  `.
//                 |    |:::||              |////}                `-. \
//                 |    |:::||             //'///                    `.\
//                 |    |:::||            //  ||'                      `|
//                 /    |:::|/        _,-//\  ||
//                /`    |:::|`-,__,-'`  |/  \ ||
//              /`  |   |'' ||           \   |||
//            /`    \   |   ||            |  /||
//          |`       |  |   |)            \ | ||
//         |          \ |   /      ,.__    \| ||
//         /           `         /`    `\   | ||
//        |                     /        \  / ||
//        |                     |        | /  ||
//        /         /           |        `(   ||
//       /          .           /          )  ||
//      |            \          |     ________||
//     /             |          /     `-------.|
//    |\            /          |              ||
//    \/`-._       |           /              ||
//     //   `.    /`           |              ||
//    //`.    `. |             \              ||
//   ///\ `-._  )/             |              ||
//  //// )   .(/               |              ||
//  ||||   ,'` )               /              //
//  ||||  /                    /             || 
//  `\\` /`                    |             // 
//      |`                     \            ||  
//     /                        |           //  
//   /`                          \         //   
// /`                            |        ||    
// `-.___,-.      .-.        ___,'        (/    
//          `---'`   `'----'`
using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
     class Program
     {    
          static void Main(string[] args)
          {
               // 
               string str = "";
               // 
               do{
                    // 
                    string strSysNothing = @"Nothing/Sys/",strActivityNothing = strSysNothing + "Activity/",strTime = strSysNothing + "Time/",strDate = strSysNothing + "Date/",strBXH = strSysNothing + "BXH/",strPercentMinutes = strSysNothing + "PercentMinutes/",strActivityErr = strSysNothing + "ActivityErr/",strPointNothing = strSysNothing + "PointNothing/";
                    string strUrNothing = @"Nothing/Ur/",strUserSeconds = strUrNothing + "Seconds",strFont = strUrNothing + "Font/";
                    string strNewFont = "";
                    int numRefresh = 0,numLock = 3000;

                    // 
                    string strUser = @"NewStep/User/", strFuture = strUser + "Future/",strRisk = "Risk/",strSafe = strUser + "Safe/",strUserRisk = strUser + "UR/",strUserSafe = strUser + "US/",strTable = strUser + "Table/",strMain = strUser + "Main/",strTimes = strUser + "Today/Times/",strNewTime = strTimes,strMission = strUser + "Today/Mission/",strNewMission = strMission,strRunAT = strUser + "Today/RunAT/",strNewRunAT = strRunAT,strTodayElse = strUser + "Today/Else/",strNewTodayElse = strTodayElse,strContinuous = strUser + "Continuous/",strAdd = strUser + "Add/";
                    string strSystem = @"NewStep/System/",strDetails = strSystem + "Details/",strCount = strSystem + "Count/",strMessage = strSystem + "Message/",strData = strSystem + "Data/",strTableWidth = strSystem + "TW",strDelay = strSystem + "Delay/",strNavigation = strSystem + "Navigation/",strRandom = strSystem + "Random/",strDirFuture = strSystem + "dirFuture",strMSG = strSystem + "MSG",strRiskManagement = strSystem + "RiskManagement/",strRunAutomatically = strData + "RunAutomatically/",strHoliday = strSystem + "Holiday/",strGraph = strSystem + "Graph/",strActivity = strSystem + "Activity/";
                    string strProcess = "",strProcessBack = "",strLink = strFuture,strLinkBack = strFuture,strShow = "",strNewStep = "",strNVGT = "",strPrimaryName = "",strRD = "",strDestiny = "",strNameMain = "";
                    // 
                    bool bl = false,blNPT = false, blComputer = false,blZTimes = true,blRD = false,blRDList = false,blTree = true;
                    // 
                    int numMax = 0,num = 0,num1 = 0,numMission = 0,numP = 0,numLink = 0,numMSG = 0,numResult = 0,numSafe = 0;
                    // 
                    int[] arrNum = new int[] { };
                    long[] arrLNum = new long[] { };
                    string[] arrValue = new string[] { };
                    // 
                    List<string> listLink = new List<string> {};
                    List<string> listDelayTimes = new List<string> {};
                    List<string> listCayThuMuc = new List<string> {};
                    // 
                    List<int> xList = new List<int>();
                    List<int> yList = new List<int>();
                    List<string> nameList = new List<string>();
                    // 
                    DateTime dToday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                    //    
                    HelpYou hy = new HelpYou();
                    Random rd = new Random();

                    // 
                    hy.TaoThuMuc(strSysNothing);
                    hy.TaoThuMuc(strActivityNothing);
                    hy.TaoThuMuc(strTime);
                    hy.TaoThuMuc(strDate);
                    hy.TaoThuMuc(strBXH);
                    hy.TaoThuMuc(strPercentMinutes);
                    hy.TaoThuMuc(strActivityErr);
                    hy.TaoThuMuc(strPointNothing);
                    // 
                    hy.TaoThuMuc(strUrNothing);
                    hy.TaoThuMuc(strFont);
                    // 
                    hy.TaoFile(strUrNothing + "AddFont");
                    hy.TaoFile(strUrNothing + "UseFont");
                    // 
                    hy.TaoFileVsSuaLoi(strUserSeconds,"0");
                    // 
                    FileInfo fileInfo = new FileInfo(strUrNothing + "AddFont");
                    // 
                    strFont = strFont + hy.DocFile(strUrNothing + "UseFont") + "/";

                    // 
                    hy.TaoThuMuc(strFuture);
                    hy.TaoThuMuc(strTimes);
                    hy.TaoThuMuc(strSafe);
                    hy.TaoThuMuc(strUserRisk);
                    hy.TaoThuMuc(strUserSafe);
                    hy.TaoThuMuc(strTable);
                    hy.TaoThuMuc(strMain);
                    hy.TaoThuMuc(strContinuous);
                    hy.TaoThuMuc(strAdd);
                    // 
                    hy.TaoFile(strUser + "Image");
                    hy.TaoFile(strUser + "Situation");
                    // 
                    hy.TaoFile(strUserRisk + "nghean");
                    hy.TaoFile(strUserRisk + "cantho");
                    hy.TaoFile(strUserRisk + "1macvankhoa");
                    hy.TaoFile(strUserRisk + "bixamlon");
                    hy.TaoFile(strUserRisk + "biquabao");
                    hy.TaoFile(strUserRisk + "gapchongu");
                    hy.TaoFile(strUserRisk + "coiphimsex");
                    hy.TaoFile(strUserRisk + "thudam");
                    // 
                    hy.TaoFileVsSuaLoi(strUser + "Point","1");
                    hy.TaoFileVsSuaLoi(strUser + "Destiny","unknow!");
                    hy.TaoFileVsSuaLoi(strUser + "SafeMinutes","0");

                    // 
                    hy.TaoThuMuc(strCount);
                    hy.TaoThuMuc(strMessage);
                    hy.TaoThuMuc(strData);
                    hy.TaoThuMuc(strData + "Risk");
                    hy.TaoThuMuc(strData + "Times");
                    hy.TaoThuMuc(strData + "ListTime");
                    hy.TaoThuMuc(strDelay);
                    hy.TaoThuMuc(strNavigation);
                    hy.TaoThuMuc(strDetails);
                    hy.TaoThuMuc(strRandom);
                    hy.TaoThuMuc(strRunAutomatically);
                    hy.TaoThuMuc(strHoliday);
                    hy.TaoThuMuc(strGraph);
                    hy.TaoThuMuc(strGraph + "Setting");
                    hy.TaoThuMuc(strGraph + "Data");
                    hy.TaoThuMuc(strRiskManagement);
                    hy.TaoThuMuc(strRiskManagement + "Data");
                    hy.TaoThuMuc(strRiskManagement + "Setting");
                    hy.TaoThuMuc(strRiskManagement + "Setting/RMList");
                    hy.TaoThuMuc(strRiskManagement + "Setting/RMData");
                    hy.TaoThuMuc(strRiskManagement + "Setting/OperationsManagement");
                    hy.TaoThuMuc(strActivity);
                    // 
                    hy.TaoFile(strRiskManagement + "Setting/History");
                    hy.TaoFile(strMSG);
                    // 
                    hy.TaoFileVsSuaLoi(strTableWidth, "0");
                    hy.TaoFileVsSuaLoi(strRiskManagement + "Setting/Day","10");
                    hy.TaoFileVsSuaLoi(strGraph + "Setting/Y","0");
                    hy.TaoFileVsSuaLoi(strGraph + "Setting/Column","[]");

                    // 
                    strTimes = strTimes + dToday.Day + dToday.Month + dToday.Year + "/";
                    strMission = strMission + dToday.Day + dToday.Month + dToday.Year + "/";
                    strRunAT = strRunAT + dToday.Day + dToday.Month + dToday.Year + "/";
                    strTodayElse = strTodayElse + dToday.Day + dToday.Month + dToday.Year + "/";
                    // 
                    strRisk = strMission + strRisk;
                    // 
                    if(numMission == 0)
                         // 
                         numMission = 1;
                    // 
                    SetTimes(strData,strTimes,strNewTime,hy);
                    // 
                    SetRunAT(strRunAT,strNewRunAT,strRunAutomatically,hy);
                    // 
                    SetTodayElse(strTodayElse,strNewTodayElse,hy);
                    // 
                    LoadingRisk(strData + "Risk", strRisk,strMission,strNewMission, num, hy);
                    // 
                    SetRiskManagement(strRiskManagement,0,dToday,hy);
                    // 
                    ActiveAttack(strRiskManagement,strTimes,strData,hy);
                    // 
                    AutoDeleteContinuousDays(strContinuous,strCount,0,dToday,hy);
                    // 
                    numMission = hy.DemFileTrongThuMuc(strRisk);
                    // 
                    LoadingImages(strUser + "Image",0,hy);
                    // 
                    blComputer = hy.ValueYesNo("Computer?");
                    // 
                    Holiday(strHoliday,0,dToday,hy);
                    // 
                    do
                    {
                         // 
                         try
                         { 
                              bl = false;
                              // 
                              Console.Clear();
                              // 
                              Console.ResetColor();
                              // 
                              numP = hy.DocFileReturnNum(strMission + "MissionPercent");
                              // 
                              strDestiny = hy.DocFileReturnOneLine(strUser + "Destiny");
                              // 
                              numSafe = Safe(strUserSafe,strLink,strFuture,strTimes,numSafe,false, hy);
                              // 
                              strNameMain = string.Format("{00:00,0}", hy.DocFileReturnNum(strUrNothing + "Seconds"));
                              // 
                              Console.BackgroundColor = ConsoleColor.Yellow; 
                              // 
                              MainAc(strMain,hy);
                              // 
                              MSG(numMSG,strMSG,hy);
                              // 
                              blZTimes = ThayDoiTrangThaiHoatDong(str,"ZTS",blZTimes);
                              blNPT = ThayDoiTrangThaiHoatDong(str,"NPT",blNPT);
                              blRD = ThayDoiTrangThaiHoatDong(str,"RD",blRD);
                              // 
                              Console.ResetColor();
                              // 
                              Console.WriteLine("\n");
                              // 
                              blTree = Tree(strLink,strUserRisk,HoatDongMax(strShow, strCount, strLink, numMax, arrValue, hy),"",true,hy);
                              // 
                              NewTree(strLink,strUserRisk,blTree,hy);
                              
                              // 
                              listCayThuMuc.Clear();
                              // 
                              if(blTree == false)
                                   // 
                                   Console.ForegroundColor = ConsoleColor.Red;
                              // 
                              else
                                   // 
                                   Console.ForegroundColor = ConsoleColor.Green;
                              // 
                              Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(strNameMain), ' ') + strNameMain + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(strNameMain), ' '), CayThuMuc(strShow, strCount, strLink, strLink, strContinuous, strDelay,strTimes,strUserSafe,"","",0,0,blZTimes,true, num,listCayThuMuc, hy), hy);
                              
                              //  
                              if (File.Exists(strTable + strNewStep) == true)
                              {
                                   // 
                                   Console.ForegroundColor = ConsoleColor.White;
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(strNewStep), ' ') + strNewStep + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(strNewStep), ' '), hy.DocFileReturnOneLine(strTable + strNewStep), hy);
                              }
                              // 
                              if (File.Exists(strMessage + strNewStep) == true)
                              {
                                   // 
                                   Console.ForegroundColor = ConsoleColor.Yellow;
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(strNewStep), ' ') + strNewStep + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(strNewStep), ' '), hy.DocFileReturnOneLine(strMessage + strNewStep), hy);
                                   // 
                                   numMSG++;
                                   // 
                                   hy.GhiFile(strMSG,strNewStep.ToUpper() + " : " + hy.DocFileReturnOneLine(strMessage + strNewStep)+".",true);
                                   // 
                                   strNewStep = null;
                              }
                              // 
                              Console.ResetColor();
                              // 
                              if(strPrimaryName.Replace(" ","") != ""){
                                   // 
                                   Console.ForegroundColor = ConsoleColor.Green;
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(hy.TenFile(hy.LietKeFile(strMain,""))), ' ') + strPrimaryName + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(hy.TenFile(hy.LietKeFile(strMain,""))), ' '), hy.DocFile(strMain + strPrimaryName), hy);
                              }
                              // 
                              Console.ResetColor();
                              // 
                              if(strRD == "")
                                   //
                                   str = hy.Value($"\n[{hy.DocFile(strUser + "Destiny")}]\n<").Replace(" ", "").ToLower();
                              // 
                              str = NewStr(str,0,listCayThuMuc);
                              // 
                              while(str == "" || str[str.Length - 1] != '>'){
                                   // 
                                   str = hy.Value().Replace(" ", "").ToLower();
                                   // 
                                   str = NewStr(str,0,listCayThuMuc);
                              }
                              // 
                              str = str.Replace(">","");
                              // 
                              if(strRD != "" && hy.ValueYesNo($"Next? {strRD}") == true){
                                   // 
                                   str = strRD;
                                   //
                                   if(hy.DemThuMuc(strLink + strRD) > 0)
                                        // 
                                        blRDList = true;
                                   // 
                                   else
                                        // 
                                        blRDList = false;
                              }
                              // 
                              str = RunAutomatically(strRunAT,strTimes,strLink,str,"",strTableWidth,hy);
                              // 
                              Console.ResetColor();
                              // 
                              if(str == "main" && hy.TenThuMuc(strLink) + "/" != strFuture){
                                   // 
                                   if(File.Exists(strMain + hy.TenThuMuc(strLink)) == true || hy.DemFileTrongThuMuc(strMain) == 0){
                                        // 
                                        hy.TaoThuMuc(strMain);
                                        // 
                                        hy.TaoFile(strMain + hy.TenThuMuc(strLink));
                                        // 
                                        strPrimaryName = hy.TenThuMuc(strLink);
                                   }
                              }
                              // 
                              if (str == "cl" || str == "clear")
                              {
                                   strProcess = null;
                                   strLink = null;
                                   strLink = strFuture;
                                   str = null;
                                   strNewStep = null;
                                   listLink.Clear();
                                   numLink = 0;
                                   strPrimaryName = "";
                                   numMSG = 0;
                                   // 
                                   if(hy.DemSoDongTrongFile(strMSG) > 0 && hy.ValueYesNo("Delete all messages?") == true)
                                        // 
                                        hy.GhiFile(strMSG,"",false);
                              }
                              // 
                              if (str == "tw" || str == "tablewidth")
                              {
                                   Console.Write("{0}>", hy.DocFile(strTableWidth));
                                   // 
                                   hy.GhiFile(strTableWidth, hy.Value(), false);
                                   // 
                                   str = "";
                              }
                              // 
                              if (str == "<" && numLink > 0){
                                   // 
                                   if(strPrimaryName != "" && hy.TenThuMuc(strLink) == strPrimaryName){
                                        //
                                        if(hy.ValueYesNo("DELETE PRIMARY?") == false)
                                             // 
                                             str = null;
                                        // 
                                        else
                                             // 
                                             strPrimaryName = DeleteMain(strMain,hy);
                                   }
                              }
                              //
                              if (str == "<" && numLink > 0)
                              {
                                   // 
                                   strNewStep = null;
                                   // 
                                   numLink--;
                                   // 
                                   listLink.RemoveAt(numLink);
                                   // 
                                   strLinkBack = strFuture + GetLinkBack(listLink,"");
                                   // 
                                   strLink = strLinkBack;
                                   // 
                                   strProcessBack = GetLink(listLink,"");
                                   // 
                                   strProcess = GetLink(listLink,"").Replace("/", " > ").Replace("\\", " > ");
                              }
                              // 
                              if(str == "setdisplay" || str == "sdp")
                                   // 
                                   blComputer = hy.ValueYesNo("Computer?");
                              // 
                              if (str != "<" && str != "")
                              {
                                   // 
                                   if (Directory.Exists(strLink + str) == false && blNPT == true)
                                   {
                                        // 
                                        if (hy.ValueYesNo("NEW EVENT?") == true)
                                        {
                                             // 
                                             bl = true;
                                             // 
                                             hy.TaoThuMuc(strLink + str);
                                        }
                                   }
                                   // 
                                   if (bl == true || Directory.Exists(strLink + str) == true){
                                        // 
                                        bl = true;
                                        //
                                        if(bl == true)
                                             //  
                                             bl = CheckTimes(str,false,strTimes,hy);
                                        // 
                                        if(bl == true && blRD == true)
                                             // 
                                             bl = Random(str,strRandom,0,0,0,0.0,rd.Next(0,1000000000),false,blComputer,arrValue,arrNum,hy,rd);
                                        // 
                                        if(bl == true)
                                             // 
                                             bl = Damn(hy.DocFile(strUser + "Destiny").ToLower().Replace(" ",""),strActivityNothing,strUserRisk + str,strBXH,strTime,strDate,strPointNothing,true,dToday,hy);
                                        // 
                                        if(bl == true){
                                             // 
                                             Delay(str,strDelay,strTableWidth,strMain,"",0.0,0.0,0.0,strTimes,strNavigation,strSystem,true,listDelayTimes,hy);
                                             // 
                                             ListTime(str,strTimes,strData + "ListTime/",hy);
                                             // 
                                             MainCheck(str,strPrimaryName,strUserRisk,strMain,strLink,strFuture,strData,strTimes,0,hy);
                                             // 
                                             CheckForRisks(str,strRiskManagement,strUserRisk,dToday,hy);
                                             // 
                                             SafetyChecking(str,strSafe,strUserRisk,strUserSafe,strLink,hy);
                                             // 
                                             AddContinuousDays(str,strContinuous,strCount,0,dToday,hy);
                                             // 
                                             strNewStep = str;
                                             // 
                                             strLinkBack = strLink;
                                             strProcessBack = strProcess;
                                             // 
                                             if(str != "")
                                                  // 
                                                  hy.TaoFileVsSuaLoi(strCount + str, "0");
                                             // 
                                             if (File.Exists(strCount + strLink.ToLower().Replace("/", "").Replace("\\", "") + str) == true)
                                                  // 
                                                  hy.GhiFile(strCount + strLink.ToLower().Replace("/", "").Replace("\\", "") + str, hy.DocFileReturnNum(strCount + strLink.ToLower().Replace("/", "").Replace("\\", "") + str) + 1 + "", false);
                                             // 
                                             else
                                                  // 
                                                  hy.GhiFile(strCount + str, hy.DocFileReturnNum(strCount + str) + 1 + "", false);
                                             // 
                                             strLink = strLink + str + "/";
                                             strProcess = strProcess + str + " > ";
                                             // 
                                             hy.GhiFile(strTimes + str,hy.DocFileReturnNum(strTimes + str) - 1 + "",false);
                                             // 
                                             listLink.Add(str);
                                             numLink++;
                                             // 
                                             if(strPrimaryName.Replace(" ","") != "")
                                                  // 
                                                  hy.GhiFile(strMain + strPrimaryName,str + " ",true);
                                             // 
                                        }
                                   }
                              }
                              // 
                              strRD = Function(str,strUser,"",num,num1,0,bl,blRDList,blComputer,strNavigation,strTable,strUserSafe,strUserRisk,strShow,strRisk,strData,strTimes,strMessage,arrValue,arrNum,strFuture,strCount,strDelay,strLink,strLinkBack,strProcessBack,strTableWidth,numP,strRandom,strDirFuture,strMSG,strRiskManagement,strRunAutomatically,strRunAT,strHoliday,strTodayElse,strGraph,strContinuous,strAdd,strActivity,strNameMain,xList,yList,nameList,"chat : another screen.zts : an hoat dong da het so lan truy cap.tw, tablewidth : chieu rong bang.< : tro ve hoat dong truoc.nha phat trien, npt : che do nha phat trien.rd : che do random.set display, sdp : cai dat cau hinh.main : cai dat hoat dong.clear, cl : xoa duong dan.reset : restart.exit : tat may.",dToday,hy,rd);
                              // 
                              if(str == "chat"){
                                   // 
                                   Console.Clear();
                                   // 
                                   do{
                                        bl = false;
                                        // 
                                        Console.ResetColor();
                                        //
                                        try{
                                             // 
                                             str = hy.Value("YOU(" + strLink + ") ").Replace(" ","").ToLower();
                                             // 
                                             if (str != "")
                                                  // 
                                                  ShowReality(strFuture,strLink,strMessage,strTable, str,strTableWidth,"",false, hy);
                                             // 
                                             if(str == "cls")
                                                  // 
                                                  Console.Clear();
                                             // 
                                             if(str == "!")
                                                  // 
                                                  UnexpectedActivity(strFuture, strCount, hy.Value("SYS >Hay ghi hoat dong gay hai chung toi se liet ke hoat dong can thiet!\nYOU >").ToLower().Replace(" ", ""), hy);
                                             // 
                                             if(str == "always")
                                                  // 
                                                  Console.WriteLine("SYS >Day la cac hoat dong luon luon xay ra!\n " + HoatDongMax(strShow, strCount, strLink, numMax, arrValue, hy));
                                             // 
                                             if(str == ">"){
                                                  // 
                                                  str = null;
                                                  // 
                                                  str = hy.Value(strLink + "/").Replace(" ","").ToLower();
                                                  // 
                                                  str = RunAutomatically(strRunAT,strTimes,strLink,str,"",strTableWidth,hy);
                                                  // 
                                                  if(Directory.Exists(strLink + str) == true && str != ""){
                                                       // 
                                                       bl = true;
                                                       //
                                                       if(bl == true)
                                                            //  
                                                            bl = CheckTimes(str,false,strTimes,hy);
                                                       // 
                                                       if(bl == true && blRD)
                                                            // 
                                                            bl = Random(str,strRandom,0,0,0,0.0,rd.Next(0,1000000000),false,blComputer,arrValue,arrNum,hy,rd);
                                                       // 
                                                       if(bl == true)
                                                            // 
                                                            bl = Damn(hy.DocFile(strUser + "Destiny").ToLower().Replace(" ",""),strActivityNothing,strUserRisk + str,strBXH,strTime,strDate,strPointNothing,true,dToday,hy);
                                                       // 
                                                       if(bl == true){
                                                            // 
                                                            Delay(str,strDelay,strTableWidth,strMain,"",0.0,0.0,0.0,strTimes,strNavigation,strSystem,true,listDelayTimes,hy);
                                                            // 
                                                            KillRisk(strRisk, str,strRisk,strMission,strNewMission,strTimes,numMission, hy);
                                                            // 
                                                            ListTime(str,strTimes,strData + "ListTime/",hy);
                                                            // 
                                                            MainCheck(str,strPrimaryName,strUserRisk,strMain,strLink,strFuture,strData,strTimes,0,hy);
                                                            // 
                                                            CheckForRisks(str,strRiskManagement,strUserRisk,dToday,hy);
                                                            // 
                                                            SafetyChecking(str,strSafe,strUserRisk,strUserSafe,strLink,hy);
                                                            // 
                                                            AddContinuousDays(str,strContinuous,strCount,0,dToday,hy);
                                                            // 
                                                            if (File.Exists(strTable + str) == true)
                                                                 // 
                                                                 Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' ') + str + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' '), hy.DocFileReturnOneLine(strTable + str), hy);
                                                            // 
                                                            if(File.Exists(strMessage + str) == true)
                                                                 // 
                                                                 Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' ') + str + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' '), hy.DocFileReturnOneLine(strMessage + str), hy);
                                                            // 
                                                            strLink = strLink + str + "/";
                                                            // 
                                                            hy.GhiFile(strTimes + str,hy.DocFileReturnNum(strTimes + str) - 1 + "",false);
                                                            // 
                                                            listLink.Add(str);
                                                            numLink++;
                                                            // 
                                                            if(strPrimaryName.Replace(" ","") != "")
                                                                 // 
                                                                 hy.GhiFile(strMain + strPrimaryName,str + " ",true);
                                                       }
                                                  }    
                                             }
                                             // 
                                             if (str == "cl" || str == "clear")
                                             {
                                                  strProcess = null;
                                                  strLink = null;
                                                  strLink = strFuture;
                                                  str = null;
                                                  strNewStep = null;
                                                  listLink.Clear();
                                                  numLink = 0;
                                                  strPrimaryName = "";
                                                  numMSG = 0;
                                                  // 
                                                  if(hy.DemSoDongTrongFile(strMSG) > 0 && hy.ValueYesNo("Delete all messages?") == true)
                                                       // 
                                                       hy.GhiFile(strMSG,"",false);
                                             }
                                             // 
                                             if (str == "<" && numLink > 0){
                                                  // 
                                                  if(strPrimaryName != "" && hy.TenThuMuc(strLink) == strPrimaryName){
                                                       //
                                                       if(hy.ValueYesNo("DELETE PRIMARY?") == false)
                                                            // 
                                                            str = null;
                                                       // 
                                                       else
                                                            // 
                                                            strPrimaryName = DeleteMain(strMain,hy);
                                                  }
                                             }
                                             // 
                                             if (str == "<" && numLink > 0)
                                             {
                                                  // 
                                                  strNewStep = null;
                                                  // 
                                                  numLink--;
                                                  // 
                                                  listLink.RemoveAt(numLink);
                                                  // 
                                                  strLinkBack = strFuture + GetLinkBack(listLink,"");
                                                  // 
                                                  strLink = strLinkBack;
                                                  // 
                                                  strProcessBack = GetLink(listLink,"");
                                                  // 
                                                  strProcess = GetLink(listLink,"").Replace("/", " > ").Replace("\\", " > ");
                                                  // 
                                             }
                                             // 
                                             Function(str,strUser,"",num,num1,0,bl,blRDList,blComputer,strNavigation,strTable,strUserSafe,strUserRisk,strShow,strRisk,strData,strTimes,strMessage,arrValue,arrNum,strFuture,strCount,strDelay,strLink,strLinkBack,strProcessBack,strTableWidth,numP,strRandom,strDirFuture,strMSG,strRiskManagement,strRunAutomatically,strRunAT,strHoliday,strTodayElse,strGraph,strContinuous,strAdd,strActivity,strNameMain,xList,yList,nameList,"> : truy cap thu muc.< : tro ve hoat dong truoc.always : liet ke hoat dong luon luon xay ra.? : liet ke cac hoat dong sap dien ra.! : liet ke hoat dong dan toi hoat dong khong mong muon.cls : xoa man hinh.clear, cl : xoa duong dan.off : loi thoat.",dToday,hy,rd);
                                        }
                                        // 
                                        catch
                                        {     
                                        // 
                                        }
                                   // 
                                   }while(str != "off");
                              }
                              // 
                              KillRisk(strRisk, strNewStep,strRisk,strMission,strNewMission,strTimes,numMission, hy);
                              // 
                              if(dToday.Year + "" + dToday.Month + "" + dToday.Day !=  DateTime.Now.Year + "" + DateTime.Now.Month + "" + DateTime.Now.Day){
                                   // 
                                   dToday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
                                   // 
                                   strTimes = strNewTime + dToday.Day + dToday.Month + dToday.Year + "/";
                                   // 
                                   strMission = strNewMission + dToday.Day + dToday.Month + dToday.Year + "/";
                                   // 
                                   strRunAT = strNewRunAT + dToday.Day + dToday.Month + dToday.Year + "/";
                                   // 
                                   strTodayElse = strNewTodayElse + dToday.Day + dToday.Month + dToday.Year + "/";
                              }
                              // 
                              if(str == ""){
                                   // 
                                   do
                                   {
                                        try{
                                             // 
                                             Console.Clear();
                                             // 
                                             if(str == "load"){
                                                  // 
                                                  Nothing(strActivityNothing,strTime,strDate,strBXH,strUserSeconds,strPercentMinutes,strPointNothing,0,arrValue,arrLNum,false,hy);
                                                  // 
                                                  PrintLargeText(strFont,string.Format("{0:00,0}",hy.DocFileReturnNum(strUserSeconds)),true,rd,hy);
                                             }
                                             // 
                                             if(str == "loaderr")
                                                  // 
                                                  Nothing(strActivityErr,strTime,strDate,strBXH,strUserSeconds,strPercentMinutes,strPointNothing,0,arrValue,arrLNum,true,hy);
                                             // 
                                             str = null;
                                             // 
                                             while(str != "load" && str != "loaderr" && str != "off"){
                                                  // 
                                                  Console.ResetColor();
                                                  // 
                                                  str = STR(str,$"\n{hy.DocFile(strUrNothing + "UseFont")} > ",hy);
                                                  // 
                                                  if(str == "+activity" || str == "+ac"){
                                                       //    
                                                       str = STR(str,$"New Activity >",hy);
                                                       // 
                                                       CreateActivity(strActivityNothing,strBXH,strTime,strDate,str, dToday,hy);
                                                  }
                                                  // 
                                                  if(str == "+activityerr" || str == "+acerr"){
                                                       //    
                                                       str = STR(str,$"New Activity >",hy);
                                                       // 
                                                       CreateActivity(strActivityErr,strBXH,strTime,strDate,str, dToday,hy);
                                                  }
                                                  // 
                                                  if(str == "#"){
                                                       // 
                                                       str = STR(str,$"#Activity >",hy);
                                                       // 
                                                       if(File.Exists(strActivityNothing + str) == true)
                                                            // 
                                                            hy.GhiFile(strActivityNothing + str,"#" + STR(str,$"{str} >#",hy) + " ",true);
                                                       // 
                                                       if(File.Exists(strActivityErr + str) == true)
                                                            // 
                                                            hy.GhiFile(strActivityErr + str,"#" + STR(str,$"{str} >#",hy) + " ",true);
                                                  }
                                                  // 
                                                  if(str == "reset"){
                                                       // 
                                                       str = STR(str,$"Reset Activity >",hy);
                                                       // 
                                                       if(File.Exists(strActivityNothing + str) == true){
                                                            // 
                                                            hy.TaoFileVsSuaLoi(strBXH + str + "/" + dToday.ToString("dd MM yyyy"),hy.DocFileReturnNum(strPointNothing + str) + "");
                                                            // 
                                                            hy.GhiFile(strTime + str,GetTheRemainingMinutes() + "",false);
                                                            hy.GhiFile(strDate + str,dToday.AddDays(1).ToString("dd/MM/yyyy"),false);
                                                       }
                                                  }
                                                  // 
                                                  if(str == "addactivityandcode" || str == "aaac"){
                                                       //    
                                                       str = STR(str,$"Name Activity >",hy);
                                                       // 
                                                       if(File.Exists(strActivityNothing + str) == false){
                                                            // 
                                                            hy.TaoThuMuc(strBXH + str);
                                                            // 
                                                            hy.TaoFile(strActivityNothing + str);
                                                            hy.TaoFileVsSuaLoi(strTime + str,hy.ValueInt("Code >") + "");
                                                            hy.TaoFileVsSuaLoi(strDate + str,hy.ValueDate("Day/Month/Year >",dToday) + "");
                                                       }
                                                  }
                                                  // 
                                                  if(str == "percent" || str == "%"){
                                                       // 
                                                       PrintLargeText(strFont,$"{string.Format("{0:00,0}%",hy.DocFileReturnNum(strPercentMinutes + STR(str,$"Object >",hy)))}",true,rd,hy);
                                                       // 
                                                       Console.ReadKey();
                                                  }
                                                  // 
                                                  if(str == "font"){
                                                       // 
                                                       strFont = strUrNothing + "Font/";
                                                       // 
                                                       PrintD(strFont);
                                                       // 
                                                       str = STR(str,$"\n{strFont}",hy);
                                                       // 
                                                       PrintLargeText(strFont + str + "/",string.Format("{0:00,0}",hy.DocFileReturnNum(strUserSeconds)),false,rd,hy);
                                                       // 
                                                       if(Directory.Exists(strFont + str) == true && hy.ValueYesNo($"{str}") == true){
                                                            //
                                                            strFont = strFont + str + "/"; 
                                                            // 
                                                            hy.GhiFile(strUrNothing + "UseFont",str,false);
                                                       }
                                                       // 
                                                       else
                                                            // 
                                                            strFont = strUrNothing + "Font/" + hy.DocFile(strUrNothing + "UseFont") + "/"; 
                                                  }
                                                  // 
                                                  if(str == "addfont"){
                                                       // 
                                                       strNewFont = "";
                                                       // 
                                                       do{
                                                            // 
                                                            Console.Clear();
                                                            // 
                                                            PrintD(strFont.Replace(hy.TenThuMuc(strFont),"") + strNewFont);
                                                            // 
                                                            str = STR(str,$"[{strNewFont.ToUpper()}]\n>",hy);
                                                            // 
                                                            if(str == "+f"){
                                                                 // 
                                                                 strNewFont = STR(str,$"{strNewFont} >",hy);
                                                                 // 
                                                                 hy.TaoThuMuc(strFont.Replace(hy.TenThuMuc(strFont),"") + strNewFont);
                                                            }
                                                            // 
                                                            if(str == "+")
                                                                 // 
                                                                 AddFont(strFont.Replace(hy.TenThuMuc(strFont),"") + strNewFont,STR(str,$"Char >",hy),fileInfo.FullName,hy);
                                                       // 
                                                       }while(str != "off");
                                                  }
                                                  // 
                                                  if(str == "menu"){
                                                       // 
                                                       Table("               MENU               ","+activity, +ac : Add Activity.+activityerr, +acerr : Add Activity Err.# : #Tag.reset : again.aaac : add activity and code.percent, % : show percent.font : show font.add font : make new font.load : show.load err : show error.",hy);
                                                       // 
                                                       Console.ReadKey();
                                                  }
                                                  // 
                                                  if(str == "")
                                                       //
                                                       numRefresh++; 
                                                  // 
                                                  if(numRefresh >= 2){
                                                       // 
                                                       ClockDigital(strFont,numLock,rd,hy);
                                                       // 
                                                       numRefresh = 0;
                                                  }
                                             }
                                        // 
                                        }catch(Exception e){
                                             // 
                                             Console.WriteLine(e);
                                             // 
                                             Console.ReadKey();
                                        }
                                   //   
                                   }while(str != "off");
                              }
                         // 
                         }
                         catch (Exception e)
                         {
                              // 
                              Console.WriteLine(e);
                              //
                              if (hy.ValueYesNo("Display errors?") == true)
                                   // 
                                   hy.GhiFile(strTableWidth, "50", false);
                         }
                    // 
                    } while (str != "exit" && str != "reset");
               // 
               }while(str != "exit");
          }
          //     
          public static bool Damn(string strDestiny,string strActivityNothing,string strUserRisk,string strBXH,string strTime,string strDate,string strPointNothing,bool bl,DateTime dToday,HelpYou hy){
               // 
               if(File.Exists(strUserRisk) == true && File.Exists(strActivityNothing + strDestiny) == true){
                    // 
                    bl = false;
                    // 
                    if(hy.ValueYesNo($"{strDestiny} will restart!") == true){
                         // 
                         hy.TaoFileVsSuaLoi(strBXH + strDestiny + "/" + dToday.ToString("dd MM yyyy"),hy.DocFileReturnNum(strPointNothing + strDestiny) + "");
                         // 
                         hy.GhiFile(strTime + strDestiny,GetTheRemainingMinutes() + "",false);
                         hy.GhiFile(strDate + strDestiny,dToday.AddDays(1).ToString("dd/MM/yyyy"),false);
                         // 
                         bl = true;
                    }
               }
               // 
               return bl;
          }
          // 
          public static void CreateActivity(string Object,string strBXH,string strTime,string strDate,string str,DateTime dToday,HelpYou hy){
               // 
               if(File.Exists(Object + str) == false){
                    // 
                    hy.TaoThuMuc(strBXH + str);
                    // 
                    hy.TaoFile(Object + str);
                    hy.TaoFileVsSuaLoi(strTime + str,GetTheRemainingMinutes() + "");
                    hy.TaoFileVsSuaLoi(strDate + str,dToday.AddDays(1).ToString("dd/MM/yyyy"));
               }
          }
          // 
          public static void PrintD(string strD){
               // 
               string[] gD = Directory.GetDirectories(strD);
               foreach(string d in gD){
                    // 
                    Console.WriteLine(" " + d);
               }
          }
          // 
          public static void AddFont(string strFont,string strChar,string strF,HelpYou hy){
               // 
               if(Directory.Exists(strFont + "/" + strChar) == false){
                    // 
                    hy.GhiFile(strF,"",false);
                    // 
                    hy.MoDuongDan(strF);
                    // 
                    if(hy.ValueYesNo("") == true && hy.DemSoDongTrongFile(strF) <= 6){
                         // 
                         hy.TaoThuMuc(strFont + "/" + strChar);
                         // 
                         for(int i = 0;i < 6;i++){
                         // 
                         hy.TaoFileVsSuaLoi(strFont + "/" + strChar + "/" + i,DocFileVsSoDong(strF,"",i + 1,0));
                         }
                         // 
                         Console.ReadKey();
                    }
               } 
          }
          // 
          public static void ClockDigital(string strFont,int num,Random rd,HelpYou hy){
               // 
               for(int i = 0;i < num;i++){
                    // 
                    Console.Clear();
                    // 
                    ForegroundColor(rd.Next(0,15));
                    // 
                    PrintLargeText(strFont,$"{string.Format("{0:00}",DateTime.Now.Hour)}:{string.Format("{0:00}",DateTime.Now.Minute)}:{string.Format("{0:00}",DateTime.Now.Second)}",false,rd,hy);
                    // 
                    Thread.Sleep(1000);
               }
          }
          // 
          public static void BackgroundColor(int num){
               // 
               if(num == 0)
                    // 
                    Console.BackgroundColor = ConsoleColor.Black;
               // 
               if(num == 1)
                    // 
                    Console.BackgroundColor = ConsoleColor.White;
               // 
               if(num == 2)
                    // 
                    Console.BackgroundColor = ConsoleColor.Blue;
               // 
               if(num == 3)
                    // 
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
               // 
               if(num == 4)
                    // 
                    Console.BackgroundColor = ConsoleColor.Red;
               // 
               if(num == 5)
                    // 
                    Console.BackgroundColor = ConsoleColor.DarkRed;
               // 
               if(num == 6)
                    // 
                    Console.BackgroundColor = ConsoleColor.Yellow;
               // 
               if(num == 7)
                    // 
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
               // 
               if(num == 8)
                    // 
                    Console.BackgroundColor = ConsoleColor.Gray;
               // 
               if(num == 9)
                    // 
                    Console.BackgroundColor = ConsoleColor.DarkGray;
               // 
               if(num == 10)
                    // 
                    Console.BackgroundColor = ConsoleColor.Green;
               // 
               if(num == 11)
                    // 
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
               // 
               if(num == 12)
                    // 
                    Console.BackgroundColor = ConsoleColor.Cyan;
               // 
               if(num == 13)
                    // 
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
               // 
               if(num == 14)
                    // 
                    Console.BackgroundColor = ConsoleColor.Magenta;
               // 
               if(num == 15)
                    // 
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
          }
          // 
          public static void ForegroundColor(int num){
               // 
               if(num == 0)
                    // 
                    Console.ForegroundColor = ConsoleColor.Black;
               // 
               if(num == 1)
                    // 
                    Console.ForegroundColor = ConsoleColor.White;
               // 
               if(num == 2)
                    // 
                    Console.ForegroundColor = ConsoleColor.Blue;
               // 
               if(num == 3)
                    // 
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
               // 
               if(num == 4)
                    // 
                    Console.ForegroundColor = ConsoleColor.Red;
               // 
               if(num == 5)
                    // 
                    Console.ForegroundColor = ConsoleColor.DarkRed;
               // 
               if(num == 6)
                    // 
                    Console.ForegroundColor = ConsoleColor.Yellow;
               // 
               if(num == 7)
                    // 
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
               // 
               if(num == 8)
                    // 
                    Console.ForegroundColor = ConsoleColor.Gray;
               // 
               if(num == 9)
                    // 
                    Console.ForegroundColor = ConsoleColor.DarkGray;
               // 
               if(num == 10)
                    // 
                    Console.ForegroundColor = ConsoleColor.Green;
               // 
               if(num == 11)
                    // 
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
               // 
               if(num == 12)
                    // 
                    Console.ForegroundColor = ConsoleColor.Cyan;
               // 
               if(num == 13)
                    // 
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
               // 
               if(num == 14)
                    // 
                    Console.ForegroundColor = ConsoleColor.Magenta;
          }
          // 
          public static void Nothing(string strActivity,string strTime,string strDate,string strBXH,string strUserSeconds,string strPercentMinutes,string strPointNothing,long lSumDays,string[] arrValue, long[] arrNum,bool bl,HelpYou hy){
               // 
               hy.GhiFile(strUserSeconds,"0",false);
               //
               string[] gF = Directory.GetFiles(strActivity);
               foreach(string f in gF){
                    // 
                    hy.TaoFile(strPercentMinutes + hy.TenFile(f));
                    hy.TaoFile(strPointNothing + hy.TenFile(f));
                    // 
                    try{
                         // 
                         Console.Write(Frame($"{hy.TenFile(f).ToUpper()} {hy.DocFile(strTime + hy.TenFile(f))} {string.Format("{00:00}",23 - hy.DocFileReturnNum(strTime + hy.TenFile(f)) / 60)}:{string.Format("{00:00}",60 - hy.DocFileReturnNum(strTime + hy.TenFile(f)) % 60)} {hy.DocFile(strDate + hy.TenFile(f))} {ConvertDaysToDateAndTime(strUserSeconds,strPercentMinutes + hy.TenFile(f),0,0,0,0,hy.DocFileReturnNum(strTime + hy.TenFile(f)) + (hy.DemNgay(hy.DocFile(strDate + hy.TenFile(f)),DateTime.Now.ToString("dd/MM/yyyy")) * 1440) + GetMinutes(),0,0,out lSumDays,hy)}",strPercentMinutes + hy.TenFile(f),0,bl,hy));
                    // 
                    }catch(Exception e){
                         // 
                         Console.WriteLine($"BAN CHUA THAY DOI THOI GIAN THEO NGAY/THANG/NAM TRONG MAY TINH!\n{e}");
                    }
                    // 
                    Console.WriteLine($"{hy.DocFile(strActivity + hy.TenFile(f))}");
                    //
                    if(hy.DemFileTrongThuMuc(strBXH + hy.TenFile(f)) > 0){
                         // 
                         try{
                              // 
                              CountListNothing(strBXH + hy.TenFile(f),hy.TenFile(f),lSumDays, arrValue, arrNum, hy);
                         }
                         catch{

                         }
                    }
                    // 
                    hy.GhiFile(strPointNothing + hy.TenFile(f),lSumDays + "",false);
               } 
          }
          // 
          public static string ConvertDaysToDateAndTime(string strUserSeconds,string strPercentMinutes,int years,int months,int days,int remainingDays,long totalMinutes,int hours,int minutes,out long oiSumDays,HelpYou hy)
          { 
               // 
               hy.GhiFile(strUserSeconds,hy.DocFileReturnNum(strUserSeconds) + (totalMinutes * 60) + "",false);
               // Chuyển đổi phút sang TimeSpan
               TimeSpan timeSpan = TimeSpan.FromMinutes(totalMinutes);

               // Tính toán số năm, tháng, ngày, giờ, phút
               years = (int)(timeSpan.TotalDays / 365);
               days = (int)(timeSpan.TotalDays % 365);
               months = days / 30; // Giả định 30 ngày cho mỗi tháng
               days = days % 30; // Số ngày còn lại

               hours = timeSpan.Hours;
               minutes = timeSpan.Minutes;
               oiSumDays = totalMinutes * 60;
               // 
               hy.GhiFile(strPercentMinutes,string.Format("{0:00}",(((hours * 60) + minutes) / 1440.00) * 100),false);
               // 
               return $"{years} Years {months} Months {days} Days {string.Format("{00:00}",hours)}:{string.Format("{00:00}",minutes)}";
          }
          // 
          public static string Frame(string strRT,string strPercentMinutes, int numSTR,bool blErr, HelpYou hy){
               // 
               numSTR = hy.DemStr(strRT);
               // 
               GetColor(blErr);
               // 
               Console.Write($"┌");
               // 
               STRColor(hy.Draw(numSTR - 1,'─'),strPercentMinutes,0,0,blErr,hy);
               // 
               GetColor(blErr);
               // 
               Console.Write($"┐\n│");
               // 
               STRColor(strRT,strPercentMinutes,0,0,blErr,hy);
               // 
               GetColor(blErr);
               // 
               Console.Write($"│\n└");
               // 
               STRColor(hy.Draw(numSTR - 1,'─'),strPercentMinutes,0,0,blErr,hy);
               // 
               GetColor(blErr);
               // 
               Console.WriteLine($"┘");
               // 
               Console.ResetColor();
               // 
               return "";
          }
          // 
          public static void GetColor(bool bl){
               // 
               if(bl == true)
                    // 
                    Console.ForegroundColor = ConsoleColor.Red;
               // 
               else
                    // 
                    Console.ForegroundColor = ConsoleColor.Cyan;  
          }
          // 
          public static string STRColor(string str,string strPercentMinutes,int num,int numSTR,bool bl,HelpYou hy){
               // 
               numSTR = hy.DemStr(str);
               // 
               foreach(char ch in str){
                    // 
                    num++;
                    // 
                    if(num <= hy.DocFileReturnNum(strPercentMinutes) * numSTR / 100){
                         // 
                         if(bl == true)
                         // 
                         Console.ForegroundColor = ConsoleColor.Red;
                         // 
                         else
                         // 
                         Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    //
                    else 
                         // 
                         Console.ResetColor();

                    Console.Write(ch);
               }
               // 
               return "";
          }
          // 
          public static int GetTheRemainingMinutes(){
               // 
               return 1440 - ((DateTime.Now.Hour * 60) + DateTime.Now.Minute);
          }
          public static int GetMinutes(){
               // 
               return (DateTime.Now.Hour * 60) + DateTime.Now.Minute;
          }
          // 
          public static void AddData(string str,string strData,HelpYou hy){
               // 
               if(File.Exists(strData) == true){
                    //  
                    str = STR(str,$"{hy.TenFile(strData)} >",hy);
                    // 
                    if(str.Replace(" ","") != "" && hy.DocFileRTF(strData,str) == false)
                         // 
                         hy.GhiFile(strData,str + "\n",true);
               }
          }
          // 
          public static void CountListNothing(string strC,string strName,long lSumDays, string[] arrValue, long[] arrNum, HelpYou hy)
          {
               // 
               if (Directory.Exists(strC) == true)
               {
                    // 
                    hy.SetCount();
                    // 
                    arrNum = new long[hy.DemFileTrongThuMuc(strC) + 1];
                    arrValue = new string[hy.DemFileTrongThuMuc(strC) + 1];
                    // 
                    string[] gF = Directory.GetFiles(strC);
                    foreach (string f in gF)
                    {
                         // 
                         arrNum[hy.GetCount()] = hy.DocFileReturnNum(f);
                         arrValue[hy.GetCount()] = hy.TenFile(f);
                         // 
                         hy.Count();
                    }
                    // 
                    // Console.WriteLine(lSumDays);
                    arrNum[arrNum.Length - 1] = lSumDays;
                    arrValue[arrValue.Length - 1] = strName;
                    // 
                    // Console.WriteLine(arrNum[arrNum.Length - 1]);
                    // Console.WriteLine(arrNum[arrNum.Length - 1]);
                    // 
                    IComparer myComparer = new myReverserClass();
                    // Sorts the entire Array using the default comparer.
                    // Array.Sort( arrNum, arrValue );
                    // Console.WriteLine( "After sorting the entire Array using the default comparer:" );
                    // PrintKeysAndValues( arrNum, arrValue );

                    // Sorts the entire Array using the reverse case-insensitive comparer.
                    Array.Sort(arrNum, arrValue, myComparer);
                    // Console.WriteLine( "After sorting the entire Array using the reverse case-insensitive comparer:" );
                    Console.WriteLine(" {0,-15}  {1}", "Object", "Your life is worth every second");
                    Console.WriteLine($" {hy.Draw(hy.DemStr("Object") - 1,'-')}           {hy.Draw(hy.DemStr("Your life is worth every second") - 1,'-')}");
                    PrintKeysAndValuesWithNumNothing(strName,arrNum, arrValue,20);
               }
          }
          // 
          // public static void PrintKeysAndValues(int[] myKeys, String[] myValues)
          // {
          //     for (int i = 0; i < myKeys.Length; i++)
          //     {
          //         Console.WriteLine(" {0,-15} +{1}",myValues[i],myKeys[i]);
          //     }
          //     Console.WriteLine();
          // }
          // // 
          public static void PrintKeysAndValuesWithNumNothing(string strName,long[] myKeys, String[] myValues,int num)
          {
               for (int i = 0; i < num; i++)
               {
                    // 
                    if(myValues[i] == strName)
                         // 
                         Console.ForegroundColor = ConsoleColor.Cyan;
                    // 
                    else
                         // 
                         Console.ResetColor();
                    // 
                    Console.Write(" {0,-15}: ",myValues[i]);
                    Console.WriteLine(string.Format("{0:0,0}",myKeys[i]));
               }
               Console.WriteLine();
          }
          // 
          public static void NewFile(string strF,string str,HelpYou hy){
               // 
               if(File.Exists(strF) == true){
                    // 
                    if(File.Exists(strF + hy.TenFile(strF)) == true)
                         // 
                         File.Delete(strF + hy.TenFile(strF));
                    // 
                    hy.TaoFile(strF + hy.TenFile(strF));
                    // 
                    string[] rF = File.ReadAllLines(strF);
                    foreach(string lines in rF){
                         // 
                         if(str != lines)
                         // 
                         hy.GhiFile(strF + hy.TenFile(strF),lines + "\n",true);
                    }
                    // 
                    File.Delete(strF);
                    // 
                    File.Move(strF + hy.TenFile(strF),strF);
               }
          }
          // 
          public static string DocFileVsSoDong(string strF,string strRT,int numShow,int num){
               // 
               string[] rF = File.ReadAllLines(strF);
               foreach(string lines in rF){
                    // 
                    num++;
                    // 
                    if(numShow == num)
                         // 
                         strRT = lines;
               }
               // 
               return strRT;
          }
          // 
          public static string STR(string str,string strName,HelpYou hy){
               // 
               str = hy.Value($"{strName}").ToLower().Replace(" ","");
               // 
               return str;
          }
          // 
          public static void PrintLargeText(string strFont,string text,bool bl,Random rd,HelpYou hy)
          {
               // Khai báo mảng để chứa các dòng chữ lớn
               string[] largeTextLines = new string[6];

               foreach (char c in text.ToLower().Replace(" ",""))
               {
                    switch (c)
                    {
                         case '0':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "0/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "0/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "0/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "0/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "0/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "0/5")} ";
                         break;
                         case '1':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "1/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "1/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "1/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "1/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "1/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "1/5")} ";
                         break;
                         case '2':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "2/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "2/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "2/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "2/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "2/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "2/5")} ";
                         break;
                         case '3':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "3/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "3/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "3/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "3/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "3/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "3/5")} ";
                         break;
                         case '4':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "4/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "4/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "4/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "4/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "4/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "4/5")} ";
                         break;
                         case '5':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "5/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "5/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "5/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "5/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "5/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "5/5")} ";
                         break;
                         case '6':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "6/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "6/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "6/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "6/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "6/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "6/5")} ";
                         break;
                         case '7':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "7/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "7/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "7/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "7/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "7/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "7/5")} ";
                         break;
                         case '8':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "8/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "8/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "8/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "8/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "8/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "8/5")} ";
                         break;
                         case '9':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "9/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "9/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "9/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "9/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "9/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "9/5")} ";
                         break;
                         case '.':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "dot/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "dot/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "dot/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "dot/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "dot/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "dot/5")} ";
                         break;
                         case '%':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "percent/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "percent/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "percent/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "percent/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "percent/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "percent/5")} ";
                         break;
                         case ':':
                         largeTextLines[0] += $"{hy.DocFile(strFont + "colon/0")} ";
                         largeTextLines[1] += $"{hy.DocFile(strFont + "colon/1")} ";
                         largeTextLines[2] += $"{hy.DocFile(strFont + "colon/2")} ";
                         largeTextLines[3] += $"{hy.DocFile(strFont + "colon/3")} ";
                         largeTextLines[4] += $"{hy.DocFile(strFont + "colon/4")} ";
                         largeTextLines[5] += $"{hy.DocFile(strFont + "colon/5")} ";
                         break;
                         // Bạn có thể thêm các chữ cái khác ở đây
                         default:
                         Console.WriteLine("Chữ cái không được hỗ trợ: " + c);
                         break;
                    }
               }
               // 
               if(bl == true){
                    // In ra các dòng chữ lớn
                    foreach (string line in largeTextLines)
                    {
                         StrColor(line,line.Length,0,rd);
                    }
               }
               // 
               else{
                    // In ra các dòng chữ lớn
                    foreach (string line in largeTextLines)
                    {
                         Console.WriteLine(line);
                    }
               }
          }
          // 
          public static void StrColor(string str,int num,int numEnd,Random rd){
               // 
               foreach(char ch in str){
                    // 
                    numEnd++;
                    // 
                    if(numEnd == num){
                         // 
                         Console.WriteLine();
                         numEnd = 0;
                    }
                    // 
                    else{
                         // 
                         ForegroundColor(rd.Next(0,15));
                         // 
                         Console.Write(ch);
                    }
               }
          }
          // 
          public static string NewStringFormat(int num){
               // 
               return string.Format("{0:00}",num); 
          }
          // 
          public static string LietKeFileVsTen(string strNameD,string strRT,HelpYou hy){
               // 
               if(Directory.Exists(strNameD) == true){
                    // 
                    string[] gF = Directory.GetFiles(strNameD);
                    foreach (string f in gF){
                         // 
                         strRT = strRT + hy.TenFile(f) + ", ";
                    }
               }
               // 
               return strRT;
          }
          // 
          public static string NewSpaceWithString(string str,string strRT, int num,int numTableWidth,int numShow){
               // 
               foreach(char ch in str){
                    // 
                    numShow++;
                    // 
                    if(numShow <= (numTableWidth - num))
                         // 
                         Console.Write(ch);
               }
               // 
               return "";
          }
          // 
          public static string GetMinutes(int numHour,int numMinutes,string strRT,int numInterval){
               // 
               DateTime startTime = DateTime.Now; // Start time: 8:00 AM
               DateTime endTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, numHour, numMinutes, 0); // End time: 5:00 PM

               // 
               TimeSpan interval = TimeSpan.FromMinutes(numInterval); // Interval: 30 minutes

               for (DateTime time = startTime; time <= endTime; time = time.Add(interval))
               {
                    // 
                    if(DateTime.Now.Hour == time.Hour && DateTime.Now.Minute == time.Minute)
                         // 
                         strRT = strRT + startTime.ToString("\nHH:mm "); // Display time in 12-hour format
                    // 
                    else
                         // 
                         strRT = strRT + " ";
               }
               // 
               return strRT;
          }
          // 
          public static string NewStr(string str,int numResult,List<string> listCayThuMuc){
               // 
               if(str != "" && str[str.Length - 1] != '>'){
                    // 
                    numResult = 0;
                    // 
                    try{
                         // 
                         numResult = int.Parse(str);
                    }
                    catch{

                    }
                    // 
                    str = ListGetObjectWithNum(listCayThuMuc,"",0,numResult);
               }
               // 
               return str;
          }
          // 
          public static bool Tree(string strLink,string strUserRisk,string strNormally,string str,bool bl,HelpYou hy){
               // 
               if(Directory.Exists(strLink) == true){
                    // 
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach(string d in gD){
                         // 
                         if(File.Exists(strUserRisk + hy.TenThuMuc(d)) == true){
                              // 
                              bl = false;
                              // 
                              str = hy.TenThuMuc(d);
                         }
                    }
                    // 
                    if(bl == false){
                         // 
                         Console.ForegroundColor = ConsoleColor.Red;
                         // 
                         Console.Write(hy.TenThuMuc(strLink));
                    }
                    // 
                    else{
                         // 
                         Console.ForegroundColor = ConsoleColor.Green;
                         // 
                         Console.Write(strLink.Replace("/","──").Replace("\\","──"));
                         // 
                         Console.ForegroundColor = ConsoleColor.DarkGray;
                         // 
                         Console.Write(strNormally);
                    }
                    // 
                    if(bl == false){
                         // 
                         Console.ForegroundColor = ConsoleColor.Yellow;
                         // 
                         Console.WriteLine($"─┬─{DangerousTree(strLink,strUserRisk,"",hy)}");
                    }
                    // 
                    else
                         Console.WriteLine();

               }
               // 
               return bl;
          }
          // 
          public static void NewTree(string strLink,string strUserRisk,bool bl,HelpYou hy){
               // 
               if(Directory.Exists(strLink) == true && bl == false){
                    // 
                    Console.ForegroundColor = ConsoleColor.Green;
                    // 
                    Console.WriteLine($"{hy.Draw(hy.DemStr(hy.TenThuMuc(strLink)),' ')}└─{SafeTree(strLink,strUserRisk,"",hy)}");
               }
          }
          // 
          public static string SafeTree(string strLink,string strUserRisk,string str,HelpYou hy){
               // 
               if(Directory.Exists(strLink) == true && Directory.Exists(strUserRisk) == true){
                    // 
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach(string d in gD){
                         // 
                         if(File.Exists(strUserRisk + hy.TenThuMuc(d)) == false)
                              // 
                              str = str + hy.TenThuMuc(d) + " ";
                    }
               }
               // 
               return str;
          }
          // 
          public static string DangerousTree(string strLink,string strUserRisk,string str,HelpYou hy){
               // 
               if(Directory.Exists(strLink) == true && Directory.Exists(strUserRisk) == true){
                    // 
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach(string d in gD){
                         // 
                         if(File.Exists(strUserRisk + hy.TenThuMuc(d)) == true)
                              // 
                              str = str + hy.TenThuMuc(d) + " ";
                    }
               }
               // 
               return str;
          }
          // 
          public static void LoadingImages(string strImage,int numP,int numSum,HelpYou hy){
               // 
               if(File.Exists(strImage) == true){
                    // 
                    numSum = hy.DemSoDongTrongFile(strImage);
                    // 
                    string[] lines = File.ReadAllLines(strImage);
                    // 
                    for(int i = 0;i < numSum;i++){
                         // 
                         Console.ResetColor();
                         // 
                         if(i >=  (numSum - ((numSum * numP) / 100)))
                              // 
                              Console.ForegroundColor = ConsoleColor.Green;
                         // 
                         if(numP >= 100)
                              // 
                              Console.ForegroundColor = ConsoleColor.Cyan;
                         // 
                         Console.WriteLine(lines[i]);
                    }
               }
          }
          // 
          public static void LoadingImages(string strImage,int numSum,HelpYou hy){
               // 
               if(File.Exists(strImage) == true){
                    // 
                    numSum = hy.DemSoDongTrongFile(strImage);
                    // 
                    string[] lines = File.ReadAllLines(strImage);
                    // 
                    for(int i = 0;i < numSum;i++){
                         // 
                         Console.WriteLine(lines[i]);
                    }
               }
          }
          // 
          public static void Holiday(string strHoliday,int num,DateTime dToday,HelpYou hy){
               // 
               if(Directory.Exists(strHoliday) == true && Directory.Exists(strHoliday + dToday.Day + dToday.Month) == true){
                    // 
                    for(int i = 0;i <= hy.DemFileTrongThuMuc(strHoliday + dToday.Day + dToday.Month);i++){
                         // 
                         Console.Clear();
                         // 
                         if(File.Exists(strHoliday + dToday.Day + dToday.Month + "/" + i) == true)
                              // 
                              Console.WriteLine(hy.DocFile(strHoliday + dToday.Day + dToday.Month + "/" + i));
                         // 
                         Thread.Sleep(1000);
                    }
               }
          }
          // 
          public static string RunAutomatically(string strRunAT,string strTimes,string strLink,string str,string strRT,string strTableWidth,HelpYou hy){
               // 
               if(hy.DemFileTrongThuMuc(strRunAT) > 0 && Directory.Exists(strTimes) == true){
                    // 
                    if(File.Exists(strRunAT + str) == true){
                         // 
                         hy.GhiFile(strTimes + str,hy.DocFileReturnNum(strTimes + str) - 1 + "",false);
                         // 
                         strRT = hy.DocFile(strRunAT + str);
                         // 
                         if(hy.DocFileReturnNum(strTimes + str) <= 0)
                              // 
                              File.Delete(strRunAT + str);
                         // 
                         if(Directory.Exists(strLink + strRT) == true){
                              // 
                              Console.Clear();
                              // 
                              Console.ForegroundColor = ConsoleColor.Yellow;
                              // 
                              Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' ') + "WARNING!" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' '),$"DAY LA MA~ TU DONG BAN CAN PHAI NHAN [Y] DE HAN CHE RUI RO!.TAI SAO LAI CO THONG BAO NAY?.+THONG BAO NAY SE HIEN THI KHI NGUOI DUNG CHAC CHAN GAP RUI RO!.+THONG BAO YEU CAU NGUOI DUNG {hy.DocFile(strRunAT + str)} NHAN [Y] DE THUC HIEN!", hy);
                              // 
                              str = strRT;
                         }
                    }
               }
               // 
               return str;
          }
          // 
          public static void MSG(int numMSG,string strMSG,HelpYou hy){
               // 
               if(numMSG > 0 || hy.DemSoDongTrongFile(strMSG) > 0)
                    // 
                    Console.ForegroundColor = ConsoleColor.Black;
               // 
               else
                    // 
                    Console.ForegroundColor = ConsoleColor.DarkGray;
               // 
               Console.Write($"MSG+{numMSG} ");
          }
          // 
          public static void ShowList(List<string> list){
               // 
               if(list.Count > 0){
                    // 
                    foreach(string item in list){
                         // 
                         Console.WriteLine(" " + item);
                    }
                    // 
                    Console.ReadKey();
               }
          }
          // 
          public static void ShowListWithNum(List<string> list,int num){
               // 
               if(list.Count > 0){
                    // 
                    foreach(string item in list){
                         // 
                         num++;
                         // 
                         Console.WriteLine($"{num} {item}");
                    }
                    // 
                    Console.ReadKey();
               }
          }
          // 
          public static string ListGetObjectWithNum(List<string> list,string strRT,int num,int numObject){
               // 
               if(list.Count > 0){
                    // 
                    foreach(string item in list){
                         // 
                         num++;
                         // 
                         if(num == numObject)
                              // 
                              strRT = item + ">";
                    }
               }
               // 
               return strRT;
          }
          // 
          public static void MainCheck(string str,string strPrimaryName,string strUserRisk,string strMain,string strLink,string strFuture,string strData,string strTimes,int num,HelpYou hy){
               // 
               if(File.Exists(strMain + str) == false && strLink == strFuture)
                    // 
                    num++;
               // 
               if(File.Exists(strUserRisk + str) == true && strPrimaryName != ""){
                    // 
                    num++;
                    // 
                    hy.GhiFile(strData + "Times/" + hy.TenThuMuc(strLink),0 + "",false);
                    hy.GhiFile(strTimes + hy.TenThuMuc(strLink),0 + "",false);
               }
               // 
               if(num > 0)
                    // 
                    strPrimaryName = DeleteMain(strMain,hy);
          }
          // 
          public static string DeleteMain(string strMain,HelpYou hy){
               // 
               if(Directory.Exists(strMain) == true)
                    // 
                    Directory.Delete(strMain,true);
               // 
               hy.TaoThuMuc(strMain);
               // 
               return "";
          }
          // 
          public static void MainAc(string strLink,HelpYou hy){
               // 
               if(Directory.Exists(strLink) == true){
                    // 
                    if(hy.DemFileTrongThuMuc(strLink) == 0)
                         // 
                         Console.ForegroundColor = ConsoleColor.DarkGray;
                    // 
                    else
                         // 
                         Console.ForegroundColor = ConsoleColor.Black;
                    // 
                    Console.Write(" MAIN+{0} ",hy.TenFile(hy.LietKeFile(strLink,"")));
               }
          }
          // 
          public static bool ThayDoiTrangThaiHoatDong(string str,string strName,bool bl){
               // 
               if(str == strName.ToLower().Replace(" ","")){
                    // 
                    if(bl == true)
                         // 
                         bl = false;
                    // 
                    else if(bl == false)
                         // 
                         bl = true;
               }
               // 
               if(bl == true)
                    // 
                    Console.ForegroundColor = ConsoleColor.Black;
               // 
               else
                    // 
                    Console.ForegroundColor = ConsoleColor.Gray;
               // 
               Console.Write("{0} ",strName);
               // 
               return bl;
          }
          // 
          public static string GetLinkBack(List<string> listLink,string str){
               //
               foreach (string item in listLink)
               {
                    str = str + item + "/";
               }
               return str;
          }
          // 
          public static string GetLink(List<string> listLink,string str){
               //
               foreach (string item in listLink)
               {
                    str = str + item + "/";
               }
               return str;
          }
          // 
          public static bool Random(string str,string strRandom,int num,int num1,int num0,double numP,double numRD,bool bl,bool blComputer,string[] arrValue, int[] arrNum,HelpYou hy,Random rd){
               // 
               if(Directory.Exists(strRandom) == true){
                    // 
                    Directory.Delete(strRandom,true);
                    // 
                    hy.TaoThuMuc(strRandom);
                    // 
                    if(numRD > 0){
                         // 
                         hy.TaoFile(strRandom + str);
                         // 
                         num1 = 0;
                         num0 = 0;
                         // 
                         for(double i = 0;i <= numRD;i++){
                              // 
                              numP = (i / numRD) * 100;
                              // 
                              num = rd.Next(0,2);
                              // 
                              if(num == 1)
                                   // 
                                   num1++;
                              // 
                              else
                                   // 
                                   num0++;
                              // 
                              if(blComputer == true)
                                   // 
                                   Console.Write($"\r {string.Format("{0:00.00}",numP)}% {Running("",num)} {str}");
                              // 
                              else{
                                   // 
                                   Console.Clear();
                                   // 
                                   Console.Write($" {string.Format("{0:00.00}",numP)}% {Running("",num)} {str}");
                              }
                         }
                         // 
                         if(num1 >= num0){
                              // 
                              hy.GhiFile(strRandom + str,"1",false);
                              // 
                              Console.BackgroundColor = ConsoleColor.Green;
                              // 
                              bl = true;
                         }
                         // 
                         else{
                              // 
                              hy.GhiFile(strRandom + str,"0",false);
                              // 
                              Console.BackgroundColor = ConsoleColor.Red;
                              // 
                              bl = false;
                         }
                         // 
                         Console.WriteLine(" ");
                         // 
                         Console.ResetColor();
                    }
               }
               return bl;
          }
          // 
          public static string Running(string str,int num){
               // 
               if(num == 0)
                    // 
                    str = "> > >";
               // 
               else
                    // 
                    str = " > > ";
               // 
               return str;
          }
          // 
          public static void ListTime(string str,string strTimes,string strData,HelpYou hy){
               // 
               if(Directory.Exists(strData + str) == true){
                    // 
                    string[] gF = Directory.GetFiles(strData + str);
                    foreach(string f in gF){
                         // 
                         if(File.Exists(strTimes + hy.TenFile(f)) == true)
                              // 
                              hy.GhiFile(strTimes + hy.TenFile(f),hy.DocFileReturnNum(strTimes + hy.TenFile(f)) + hy.DocFileReturnNum(f) + "",false);
                    }
               }
          }
          // 
          public static bool CheckTimes(string str,bool bl,string strTimes,HelpYou hy){
               // 
               if(Directory.Exists(strTimes) == true){
                    // 
                    if(File.Exists(strTimes + "/" + str) == true && hy.DocFileReturnNum(strTimes + "/" + str) <= 0)
                         // 
                         bl = false;
                    // 
                    else
                         // 
                         bl = true;
               }
               return bl;
          }
          // 
          public static void SetRiskManagement(string strRiskManagement,int numDays,DateTime dRiskDay,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true){
                    // 
                    numDays = hy.DocFileReturnNum(strRiskManagement + "Setting/Day");
                    // 
                    for (int i = 0; i <= numDays; i++){
                         // 
                         hy.TaoThuMuc(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day);
                         // 
                         if(i == numDays)
                              // 
                              Directory.Delete(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day,true);
                    }
               }
          }
          // 
          public static void CreateDateRiskManagement(string strRiskManagement,int numDays,DateTime dRiskDay,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true){
                    // 
                    numDays = hy.DocFileReturnNum(strRiskManagement + "Setting/Day");
                    // 
                    for (int i = 0; i < numDays; i++){
                         // 
                         hy.TaoThuMuc(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day);
                    }
               }
          }
          // 
          public static void ClearRiskManagement(string strRiskManagement,int num,int numDelete,int numDays,DateTime dRiskDay,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true){
                    //
                    numDays = hy.DocFileReturnNum(strRiskManagement + "Setting/Day"); 
                    // 
                    for (int i = 0; i <= num; i++){
                         // 
                         if(i >= numDays && Directory.Exists(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day) == true){
                              // 
                              Directory.Delete(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day,true);
                              // 
                              numDelete++;
                         }
                    }
                    // 
                    Console.WriteLine($"{numDelete} folders were deleted!");
                    // 
                    Console.ReadKey();
               }
          }
          // 
          public static void CheckForRisks(string str,string strRiskManagement,string strUserRisk,DateTime dToday,HelpYou hy){
               // 
               if(Directory.Exists(strUserRisk) == true && Directory.Exists(strRiskManagement) == true){
                    // 
                    if(File.Exists(strUserRisk + str) == true && File.Exists(strRiskManagement + "Data/" + dToday.Year + dToday.Month + dToday.Day + "/" + str) == false)
                         // 
                         File.Copy(strUserRisk + str,strRiskManagement + "Data/" + dToday.Year + dToday.Month + dToday.Day + "/" + str);
               }
          }
          // 
          public static void ShowRiskManagement(string str,string strRiskManagement,DateTime dRiskDay,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true){
                    // 
                    for (int i = 0; i <= hy.DocFileReturnNum(strRiskManagement + "Setting/Day"); i++){
                         // 
                         if(File.Exists(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day + "/" + str) == true){
                              //
                              Console.ForegroundColor = ConsoleColor.Red;
                              // 
                              Console.Write(" " + dRiskDay.AddDays(-i).Day + "/" + dRiskDay.AddDays(-i).Month + "/" + dRiskDay.AddDays(-i).Year + " ");
                         }
                         // 
                         else{
                              // 
                              Console.ForegroundColor = ConsoleColor.Green;
                              // 
                              Console.Write("-");
                         }
                    }
                    // 
                    Console.ReadKey();
                    // 
                    Console.ResetColor();
               }
          }
          //  
          public static void RefreshRiskManagement(string strRiskManagement,string strUserRisk,double num,int numDays,DateTime dRiskDay,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true && Directory.Exists(strUserRisk) == true){
                    // 
                    numDays = hy.DocFileReturnNum(strRiskManagement + "Setting/Day");
                    // 
                    string[] gF = Directory.GetFiles(strUserRisk);
                    foreach(string f in gF){
                         // 
                         for (int i = 0; i <= numDays; i++){
                              // 
                              if(File.Exists(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day + "/" + hy.TenFile(f)) == true)
                                   //
                                   num++;
                         }
                         // 
                         hy.TaoFile(strRiskManagement + "Setting/RMData/" + hy.TenFile(f));
                         // 
                         hy.GhiFile(strRiskManagement + "Setting/RMData/" + hy.TenFile(f),(int)((num / numDays) * 100) + "",false);
                         // 
                         num = 0;
                    }
               }
          }
          //  
          public static void UpdateRiskManagement(string strRiskManagement,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true){
                    // 
                    string[] gD = Directory.GetDirectories(strRiskManagement + "Setting/OperationsManagement");
                    foreach(string d in gD){
                         //     
                         string[] gF = Directory.GetFiles(d);
                         foreach(string f in gF){
                              // 
                              hy.GhiFile(f,hy.DocFileReturnNum(strRiskManagement + "Setting/RMData/" + hy.TenThuMuc(d)) + "",false);
                         }
                    }
               }
          }
          //  
          public static string ShowOperationsManagement(string strRiskManagement,string strUserRisk,string str,string strRT,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true && File.Exists(strUserRisk + str) == true){
                    // 
                    string[] gF = Directory.GetFiles(strRiskManagement + "Setting/OperationsManagement/" + str);
                    foreach(string f in gF){
                         //     
                         strRT = strRT + hy.TenFile(f) + " : " + hy.DocFile(f) + "%.";
                    }
               }
               return strRT;
          }
          //  
          public static string ShowListTime(string strData,string str,string strRT,HelpYou hy){
               // 
               if(Directory.Exists(strData) == true){
                    // 
                    string[] gF = Directory.GetFiles(strData + str);
                    foreach(string f in gF){
                         //     
                         strRT = strRT + hy.TenFile(f) + " " + hy.DocFile(f) + ".";
                    }
               }
               return strRT;
          }
          // 
          public static string ShowRiskManagementData(string strRiskManagement,string strRT,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true){
                    // 
                    string[] gF = Directory.GetFiles(strRiskManagement + "Setting/RMData");
                    foreach(string f in gF){
                         //     
                         strRT = strRT + string.Format("{0:00}% ",hy.DocFileReturnNum(f)) + hy.TenFile(f).ToUpper() + ".";
                    }
               }
               return strRT;
          }
          // 
          public static void ActiveAttack(string strRiskManagement,string strTimes,string strData,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true && Directory.Exists(strTimes) == true){
                    // 
                    string[] gD = Directory.GetDirectories(strRiskManagement + "Setting/OperationsManagement");
                    foreach(string d in gD){
                        // 
                        string[] gF = Directory.GetFiles(d);
                        foreach(string f in gF){
                              // 
                              if(hy.DocFileReturnNum(strTimes + hy.TenFile(f)) > 0){     
                                   // 
                                   if(hy.DocFileReturnNum(strRiskManagement + "Setting/RMData/" + hy.TenThuMuc(d)) >= hy.DocFileReturnNum(f)){
                                        // 
                                        hy.GhiFile(strTimes + hy.TenFile(f),"0",false);
                                        // 
                                        hy.GhiFile(strRiskManagement + "Setting/History",$"{DateTime.Now} {hy.TenThuMuc(d).ToUpper()} delete {hy.TenFile(f)} by User ({hy.TenThuMuc(d).ToUpper()} >= {hy.DocFileReturnNum(f)}%).\n",true);
                                   }
                              }
                              // 
                              if(hy.DocFileReturnNum(strData + "Times/" + hy.TenFile(f)) > 0){     
                                   // 
                                   if(hy.DocFileReturnNum(strRiskManagement + "Setting/RMData/" + hy.TenThuMuc(d)) >= 90){
                                   // 
                                        hy.GhiFile(strData + "Times/" + hy.TenFile(f),0 + "",false);
                                        // 
                                        hy.GhiFile(strRiskManagement + "Setting/History",$"{DateTime.Now} {hy.TenThuMuc(d).ToUpper()} delete {hy.TenFile(f)} by System ({hy.TenThuMuc(d).ToUpper()} >= 90%).\n",true);
                                   }
                              }
                        }
                    }
               }
          }
          //  
          public static void GetListRiskManagement(string strRiskManagement,string strUserRisk,double numP,double num,int numDays,DateTime dRiskDay,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true && Directory.Exists(strUserRisk) == true){
                    //
                    if(Directory.Exists(strRiskManagement + "Setting/RMList") == true)
                         // 
                         Directory.Delete(strRiskManagement + "Setting/RMList",true);
                    // 
                    hy.TaoThuMuc(strRiskManagement + "Setting/RMList");
                    // 
                    numDays = hy.DocFileReturnNum(strRiskManagement + "Setting/Day");
                    // 
                    string[] gF = Directory.GetFiles(strUserRisk);
                    foreach(string f in gF){
                         // 
                         for (int i = 0; i <= numDays; i++){
                              // 
                              if(File.Exists(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day + "/" + hy.TenFile(f)) == true)
                                   //
                                   num++;
                         }
                         // 
                         numP = (num / numDays) * 100;
                         // 
                         hy.TaoFileVsSuaLoi(strRiskManagement + "Setting/RMList/" + hy.TenFile(f),(int)numP + "");
                         // 
                         num = 0;
                    }
               }
          }
          // 
          public static void SetTimes(string strData,string strTimes,string strTimesRPL,HelpYou hy){
               // 
               if(Directory.Exists(strTimes) == false && Directory.Exists(strData + "Times") == true){ 
                    // 
                    if(Directory.Exists(strTimesRPL) == true)
                         // 
                         Directory.Delete(strTimesRPL,true);
                    // 
                    hy.TaoThuMuc(strTimesRPL);
                    hy.TaoThuMuc(strTimes);
                    // 
                    string[] gF = Directory.GetFiles(strData + "Times");
                    foreach(string f in gF){
                         // 
                         File.Copy(f,strTimes + hy.TenFile(f));
                    }
               }
          }
          // 
          public static void SetRunAT(string strRunAT,string strNewRunAT,string strRunAutomatically,HelpYou hy){
               // 
               if(Directory.Exists(strRunAT) == false && Directory.Exists(strRunAutomatically) == true){ 
                    // 
                    if(Directory.Exists(strNewRunAT) == true)
                         // 
                         Directory.Delete(strNewRunAT,true);
                    // 
                    hy.TaoThuMuc(strNewRunAT);
                    hy.TaoThuMuc(strRunAT);
                    // 
                    string[] gF = Directory.GetFiles(strRunAutomatically);
                    foreach(string f in gF){
                         // 
                         File.Copy(f,strRunAT + hy.TenFile(f));
                    }
               }
          }
          // 
          public static void SetTodayElse(string strTodayElse,string strNewTodayElse,HelpYou hy){
               // 
               if(Directory.Exists(strTodayElse) == false || Directory.Exists(strNewTodayElse) == false){ 
                    // 
                    if(Directory.Exists(strNewTodayElse) == true)
                         // 
                         Directory.Delete(strNewTodayElse,true);
                    // 
                    hy.TaoThuMuc(strNewTodayElse);
                    hy.TaoThuMuc(strTodayElse);
                    // 
                    hy.TaoFile(strTodayElse + "random");
                    hy.TaoFileVsSuaLoi(strTodayElse + "minutes","0");
               }
          }
          // 
          public static void AddList(List<int> xList,List<int> yList,List<string> nameList,string strData,int num,HelpYou hy){
               // 
               if(Directory.Exists(strData) == true){
                    // 
                    xList.Clear();
                    yList.Clear();
                    nameList.Clear();
                    // 
                    string[] gD = Directory.GetDirectories(strData);
                    foreach(string d in gD){
                         // 
                         num++;
                         // 
                         if(hy.DocFileReturnNum(d + "/x") != num)
                              // 
                              hy.GhiFile(d + "/x",num + "",false);
                         // 
                         xList.Add(hy.DocFileReturnNum(d + "/x"));
                         yList.Add(hy.DocFileReturnNum(d + "/y"));
                         nameList.Add(hy.TenThuMuc(d));
                    }
                    // 
               }
          }
          // 
          public static void Graph(List<int> xList,List<int> yList,List<string> nameList,string strGraph,int numY,int numSpace,int num,HelpYou hy){
               // 
               // Console.WriteLine("y");
               // 
               for(int y = -1;y <= numY;y++){
                    // 
                    // Console.Write(string.Format(" {0:0000} |",y));
                    // 
                    if(y < 0)
                         // 
                         Console.Write("   % ");
                    // 
                    else{
                         // 
                         if(y > 0)
                              // 
                              Console.Write(string.Format(" {0:00}│",100 - (y / (double)numY) * 100));
                         //
                         else
                              // 
                              Console.Write(string.Format("{0:00}│",100 - (y / (double)numY) * 100));
                    }
                    // 
                    for(int x = 0;x <= xList.Count;x++){
                         // 
                         if(GetPoint(x,y,strGraph,"",0,numY,xList,yList,hy) == "")
                              // 
                              Console.Write($"     ");
                         // 
                         else
                              // 
                              Console.Write(GetPoint(x,y,strGraph,"",0,numY,xList,yList,hy));
                    }
                    // 
                    Console.WriteLine();
                    

               }
               // 
               Console.Write("   └");
               // 
               for(double x = 0;x <= xList.Count;x++){
                    // 
                    // Console.Write(string.Format("{0:00}   ",x));
                    if(x > 0)
                         // 
                         Console.Write("───┬─");
                    // 
                    else
                    // 
                         Console.Write("─────");
               }
               // 
               // Console.WriteLine(" x");
               Console.WriteLine();
               // 
               foreach(string item in nameList){
                    // 
                    num++;
                    // 
                    Console.WriteLine(item + hy.Draw(numSpace - hy.DemStr(item),'─') + "┘" + NewSpace(num,xList.Count,"",hy));
                    // 
                    numSpace++;
                    numSpace++;
                    numSpace++;
                    numSpace++;
                    numSpace++;
               }
               // 
               Console.WriteLine();
          }
           // 
          public static string NewSpace(int num,int numCount,string str,HelpYou hy){
               // 
               for(int i = 0;i < numCount - num;i++){
                    // 
                    str = str + "    │";
               }
               // 
               return str;
          }
          // 
          public static string GetPoint(int x,int y,string strGraph,string strRT,double numP,double numY,List<int> xList,List<int> yList,HelpYou hy){
               // 
               if(Directory.Exists(strGraph) == true){
                    // 
                    strRT = hy.DocFile(strGraph + "Setting/Column");
                    // 
                    for(int num = 0;num < xList.Count ;num++){
                         // 
                         // Console.WriteLine($"{xList[num]} {yList[num]}");
                         // 
                         // 
                         if( x == xList[num] && y >= yList[num] + 1)
                              // 
                              return $"  {strRT} ";
                         // 
                         if( x == xList[num] && y >= yList[num])
                              // 
                              return "  ── ";
                         // 
                         if( x == xList[num] && y >= yList[num] - 1){
                              // 
                              numP = ((numY - yList[num]) / numY) * 100;
                              // 
                              // Console.WriteLine($"{numY} - {yList[num]} / {numY} * 100");
                              // 
                              // return $"{string.Format("{0:00.0}%", (yList[num] / 50.00) * 100)}";
                              if(numP < 100)
                                   // 
                                   return $"{string.Format("{0:00.0}%", numP)}";
                              // 
                              else
                                   // 
                                   return $"{numP}% ";
                         }
                    }
               }
               // 
               return "";
          }
          //  
          public static void LoadAllRiskManagementIntoTheGraph(string strRiskManagement,string strUserRisk,string strGraph,string str,double num,int numDays,DateTime dRiskDay,HelpYou hy){
               // 
               if(Directory.Exists(strRiskManagement) == true && Directory.Exists(strUserRisk) == true){
                    // 
                    if(Directory.Exists(strGraph + "Data") == true)
                         // 
                         Directory.Delete(strGraph + "Data",true);
                    // 
                    hy.TaoThuMuc(strGraph + "Data");
                    // 
                    numDays = hy.DocFileReturnNum(strRiskManagement + "Setting/Day");
                    // 
                    string[] gF = Directory.GetFiles(strUserRisk);
                    foreach(string f in gF){
                         // 
                         for (int i = 0; i <= numDays; i++){
                              // 
                              if(File.Exists(strRiskManagement + "Data/" + dRiskDay.AddDays(-i).Year + dRiskDay.AddDays(-i).Month + dRiskDay.AddDays(-i).Day + "/" + hy.TenFile(f)) == true)
                                   //
                                   num++;
                         }
                         // 
                         // str = str + string.Format("{0:00.00}% {1}.",(num / numDays) * 100 ,hy.TenFile(f).ToUpper());
                         // 
                         AddGraph(strGraph,hy.TenFile(f),(int)((num / numDays) * 100) ,hy);
                         // 
                         num = 0;
                    }
               }
          }
          // 
          public static void AddGraph(string strGraph,string strNameObj,int numPercent,HelpYou hy){
               //
               if(Directory.Exists(strGraph) == true){ 
                    // 
                    hy.TaoThuMuc(strGraph + "Data/" + strNameObj);
                    // 
                    hy.TaoFileVsSuaLoi(strGraph + "Data/" + strNameObj + "/Percent",numPercent + "");
                    // 
                    hy.TaoFileVsSuaLoi(strGraph + "Data/" + strNameObj + "/x",hy.DemThuMuc(strGraph + "Data/") + "");
                    hy.TaoFileVsSuaLoi(strGraph + "Data/" + strNameObj + "/y",GetNewY(strGraph + "Setting/Y",strGraph + "Data/" + strNameObj + "/Percent",0,hy) + "");
               }
          }
          // 
          public static int GetNewY(string strSetting,string strPercent,int numP,HelpYou hy){
               // 
               if(File.Exists(strSetting) == true && File.Exists(strPercent) == true)
                    // 
                    numP = (int)(hy.DocFileReturnNum(strSetting) - (hy.DocFileReturnNum(strSetting) * ((hy.DocFileReturnNum(strPercent) / 100.00))));
               // 
               return numP;
          }
          // 
          public static void NewGraph(string strGraph,string strLink,string strCount,int numSum,HelpYou hy){
               // 
               if(Directory.Exists(strGraph) == true && Directory.Exists(strLink) == true){
                    // 
                    if(Directory.Exists(strGraph + "Data") == true)
                         // 
                         Directory.Delete(strGraph + "Data",true);
                    // 
                    hy.TaoThuMuc(strGraph + "Data"); 
                    // 
                    numSum = hy.DocFileReturnNum(strCount + hy.TenThuMuc(strLink));
                    // 
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach(string d in gD){
                         // 
                         AddGraph(strGraph,hy.TenThuMuc(d),(int)(((double)(hy.DocFileReturnNum(strCount + hy.TenThuMuc(d))) / numSum) * 100) ,hy);
                    }
               }
          }
          // 
          public static int SecondsRemainingIn1Hour(){
               // 
               DateTime startTime = new DateTime(1,1,1,DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second);
               DateTime endTime =  new DateTime(1,1,1,DateTime.Now.Hour + 1,0,0);
               TimeSpan elapsedTime = endTime - startTime;
               // 
               return (int)elapsedTime.TotalSeconds;
          }
          // 
          public static void SetContinuous(string strContinuous,string str,HelpYou hy){
               // 
               if(Directory.Exists(strContinuous) == true){
                    // 
                    hy.TaoThuMuc(strContinuous + str);
                    hy.TaoThuMuc(strContinuous + str + "/date");
                    // 
                    hy.TaoFileVsSuaLoi(strContinuous + str + "/date/year",DateTime.Now.Year + "");
                    hy.TaoFileVsSuaLoi(strContinuous + str + "/date/month",DateTime.Now.Month + "");
                    hy.TaoFileVsSuaLoi(strContinuous + str + "/date/day",DateTime.Now.Day + "");
                    hy.TaoFileVsSuaLoi(strContinuous + str + "/continuousdays","0");
               }
          }
          // 
          public static void AddContinuousDays(string str,string strContinuous,string strCount,int numDays,DateTime dToday,HelpYou hy){
               // 
               if(hy.DocFileReturnNum(strCount + str) >= 2){
                    // 
                    SetContinuous(strContinuous,str,hy);
                    // 
                    numDays = hy.DemNgay(hy.DocFileReturnNum(strContinuous + str + "/date/year") + "/" + hy.DocFileReturnNum(strContinuous + str + "/date/month") + "/" + hy.DocFileReturnNum(strContinuous + str + "/date/day"),dToday.Year + "/" + dToday.Month + "/" + dToday.Day);
                    // 
                    if(numDays != 0){
                         // 
                         if(numDays <= 2){
                              // 
                              hy.GhiFile(strContinuous + str + "/continuousdays",hy.DocFileReturnNum(strContinuous + str + "/continuousdays") + 1 + "",false);
                              // 
                              hy.GhiFile(strContinuous + str + "/date/year",DateTime.Now.Year + "",false);
                              hy.GhiFile(strContinuous + str + "/date/month",DateTime.Now.Month + "",false);
                              hy.GhiFile(strContinuous + str + "/date/day",DateTime.Now.Day + "",false);
                         }
                         // 
                         else
                              // 
                              Directory.Delete(strContinuous + str,true);
                    }
               }
          }
          // 
          public static void AutoDeleteContinuousDays(string strContinuous,string strCount,int numDays,DateTime dToday,HelpYou hy){
               // 
               if(Directory.Exists(strContinuous) == true){
                    // 
                    string[] gD = Directory.GetDirectories(strContinuous);
                    foreach(string d in gD){
                         // 
                         numDays = hy.DemNgay(hy.DocFileReturnNum(d + "/date/year") + "/" + hy.DocFileReturnNum(d + "/date/month") + "/" + hy.DocFileReturnNum(d + "/date/day"),dToday.Year + "/" + dToday.Month + "/" + dToday.Day);
                         // 
                         if(numDays < 0 || numDays > 2){
                              // 
                              Directory.Delete(d,true);
                              // 
                              hy.GhiFile(strCount + "/" + hy.TenFile(d),"0",false);
                         }
                    }
               }
          }
          // 
          public static void AddFile(string strAdd,string strLink,string str,HelpYou hy){
               // 
               if(Directory.Exists(strAdd) == true){
                    // 
                    if(str != "" && File.Exists(strAdd + str) == true){
                         // 
                         string[] rF = File.ReadAllLines(strAdd + str);
                         foreach(string lines in rF){
                              // 
                              hy.TaoThuMuc(strLink + "/" + lines);
                         }
                    }
               }
          }
          // 
          public static string Function(string str,string strUser,string str1,int num,int num1,int num0,bool bl,bool blRDList,bool blComputer,string strNavigation,string strTable,string strUserSafe,string strUserRisk,string strShow,string strRisk,string strData,string strTimes,string strMessage,string[] arrValue,int[] arrNum,string strFuture,string strCount,string strDelay,string strLink,string strLinkBack,string strProcessBack,string strTableWidth,int numMission,string strRandom,string strDirFuture,string strMSG,string strRiskManagement,string strRunAutomatically,string strRunAT,string strHoliday,string strTodayElse,string strGraph,string strContinuous,string strAdd,string strActivity,string strNameMain,List<int> xList,List<int> yList,List<string> nameList,string strMenu,DateTime dToday,HelpYou hy,Random rd){
               // 
               if(str == "add")
                    // 
                    AddFile(strAdd,strLink,str = hy.Value("Name File >").ToLower().Replace(" ",""),hy);
               // 
               if(str == "destiny")
                    // 
                    hy.GhiFile(strUser + "Destiny",hy.Value(hy.DocFile(strUser + "Destiny") + " > "),false);
               // 
               if(str == "run"){
                    // 
                    num = 0;
                    // 
                    if(hy.ValueYesNo("ALL TIMES?") == true)
                         // 
                         num = -1;
                    // 
                    while(num <= 0){
                         // 
                         Console.Clear();
                         // 
                         for(int i = DateTime.Now.Hour;i <= 23;i++){
                              // 
                              Console.ForegroundColor = ConsoleColor.Green;
                              // 
                              Console.WriteLine(dToday.ToString("[dd MM yyyy ") + string.Format("{0:00}",i) + $"h] {strNameMain}+");
                              // 
                              ShowReality(strLink,strLink,strMessage,strTable,string.Format("{0:00}",i) + "h","",strTableWidth,true, hy);
                         }
                         // 
                         if(num == 0){
                              // 
                              Console.ReadKey();
                              // 
                              break;
                         }
                         // 
                         Thread.Sleep(SecondsRemainingIn1Hour() * 1000);
                    }
               }
               // 
               if(str == "graph"){
                    // 
                    Console.Clear();
                    // 
                    Console.ResetColor();
                    // 
                    NewGraph(strGraph,strLink,strCount,0,hy);
                    // 
                    AddList(xList,yList,nameList,strGraph + "Data/",0,hy);
                    // 
                    Graph(xList,yList,nameList,strGraph,hy.DocFileReturnNum(strGraph + "Setting/Y"),11,0,hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if(str == "holiday")
                    // 
                    Holiday(strHoliday,0,dToday,hy);
               // 
               if(str == "runautomatically" || str == "runat"){
                    // 
                    str = hy.Value("Run Automatically >").ToLower().Replace(" ","");
                    // 
                    if(str != "" && Directory.Exists(strLink + str) == true){
                         // 
                         hy.TaoFile(strRunAutomatically + str);
                         // 
                         hy.GhiFile(strRunAutomatically + str,hy.Value("Object >").ToLower().Replace(" ",""),false);
                         // 
                         File.Delete(strRunAT + str);
                         // 
                         File.Copy(strRunAutomatically + str,strRunAT + str);
                    }
               }
               // 
               if(str == "riskmanagement" || str == "rmngm"){
                    // 
                    RefreshRiskManagement(strRiskManagement,strUserRisk,0.0,0,dToday,hy);
                    // 
                    ActiveAttack(strRiskManagement,strTimes,strData,hy);
                    // 
                    LoadAllRiskManagementIntoTheGraph(strRiskManagement,strUserRisk,strGraph,"",0.0,0,dToday,hy);
                    // 
                    do{
                         try{
                              // 
                              Console.ResetColor();
                              // 
                              Console.Clear();
                              // 
                              AddList(xList,yList,nameList,strGraph + "Data/",0,hy);
                              // 
                              Graph(xList,yList,nameList,strGraph,hy.DocFileReturnNum(strGraph + "Setting/Y"),11,0,hy);
                              // 
                              if(hy.DemSoDongTrongFile(strRiskManagement + "Setting/History") > 0)
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' ') + "History" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' '), hy.DocFileReturnOneLine(strRiskManagement + "Setting/History"), hy);
                              // 
                              str = hy.Value($"\nRisk Management {hy.DocFile(strRiskManagement + "Setting/Day")}-day >").ToLower().Replace(" ","");
                              // 
                              if(str == "show")
                                   // 
                                   ShowRiskManagement(hy.Value("Risk >").ToLower().Replace(" ",""),strRiskManagement,dToday,hy);
                              // 
                              if(str == "clear" || str == "cls")
                                   // 
                                   ClearRiskManagement(strRiskManagement,hy.ValueInt("Num Day Clear >"),0,0,dToday,hy);
                              // 
                              if(str == "setupdate"){
                                   // 
                                   hy.GhiFile(strRiskManagement + "Setting/Day",hy.ValueInt(hy.DocFileReturnNum(strRiskManagement + "Setting/Day") + " >") + "",false);
                                   // 
                                   CreateDateRiskManagement(strRiskManagement,0,dToday,hy);
                              }
                              // 
                              if(str == "list"){
                                   // 
                                   GetListRiskManagement(strRiskManagement,strUserRisk,0.0,0.0,0,dToday,hy);
                                   // 
                                   ShowRiskManagementList(strRiskManagement + "Setting/RMList",arrValue,arrNum,false,hy);
                                   // 
                                   Console.ReadKey();
                              }
                              // 
                              if(str == "addactivitie" || str == "adac"){
                                   // 
                                   str = hy.Value("Risk >").ToLower().Replace(" ","");
                                   // 
                                   if(File.Exists(strUserRisk + str) == true){
                                        // 
                                        str1 = hy.Value("Activity >").ToLower().Replace(" ","");
                                        // 
                                        hy.TaoThuMuc(strRiskManagement + "Setting/OperationsManagement/" + str);
                                        // 
                                        hy.TaoFile(strRiskManagement + "Setting/OperationsManagement/" + str + "/" + str1);
                                        // 
                                        hy.GhiFile(strRiskManagement + "Setting/OperationsManagement/" + str + "/" + str1,hy.DocFileReturnNum(strRiskManagement + "Setting/RMData/" + str) + "",false);
                                   }
                              }
                              // 
                              if(str == "refresh")
                                   // 
                                   RefreshRiskManagement(strRiskManagement,strUserRisk,0.0,0,dToday,hy);
                              // 
                              if(str == "update")
                                   // 
                                   UpdateRiskManagement(strRiskManagement,hy);
                              // 
                              if(str == "showoperationsmanagement" || str == "som"){
                                   // 
                                   str = hy.Value("Risk >").ToLower().Replace(" ","");
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' ') + str + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' '), ShowOperationsManagement(strRiskManagement,strUserRisk,str,"",hy), hy);
                                   // 
                                   Console.ReadKey();
                              }
                              // 
                              if(str == "showriskmanagementdata" || str == "srmd"){
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 6, ' ') + "RMDATA" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 6, ' '), ShowRiskManagementData(strRiskManagement,"",hy), hy);
                                   // 
                                   Console.ReadKey();
                              }
                              // 
                              if(str == "deletehistory" || str == "delhis")
                                   // 
                                   hy.GhiFile(strRiskManagement + "Setting/History","",false);
                              // 
                              if(str == "menu"){
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' ') + "Menu" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' '), "show : xem chi tiet rui ro.clear, cls: xoa du lieu cu~.setup date : so ngay thong ke.list : danh sach.addactivitie, adac : them hoat dong vao rui ro.refresh : lam moi du lieu.update : tao moi toan bo du lieu.show operations management, som : danh sach hoat dong.show risk management data : srmd : du lieu rm.delete history, del his : xoa lich su.off : thoat.", hy);
                                   // 
                                   Console.ReadKey();
                              }
                         // 
                         }catch(Exception e){
                              // 
                              Console.WriteLine(e);
                              Console.ReadKey();
                         }
                    }while(str != "off");
               }
               // 
               if(str == "sety"){
                    // 
                    hy.GhiFile(strGraph + "Setting/Y",hy.ValueInt($"{hy.DocFile(strGraph + "Setting/Y")} > ") + "",false);
                    // 
                    string[] gD = Directory.GetDirectories(strGraph + "Data/");
                    foreach(string d in gD){
                         // 
                         hy.GhiFile(d + "/y",GetNewY(strGraph + "Setting/Y",d + "/Percent",0,hy) + "",false);
                    }
               }
               // 
               if(str == "deletegraph" || str == "delgraph"){
                    // 
                    str = hy.Value("Delete Graph >").ToLower().Replace(" ","");
                    // 
                    if(Directory.Exists(strGraph + "Data/" + str) == true &&  str != "")
                         // 
                         Directory.Delete(strGraph + "Data/" + str,true);
               }
               // 
               if(str == "columngraph" || str == "clgraph"){
                    // 
                    str = hy.Value($"{hy.DocFile(strGraph + "Setting/Column")} >").ToLower().Replace(" ","");
                    // 
                    if(str != "" && hy.DemStr(str) == 2)
                         // 
                         hy.GhiFile(strGraph + "Setting/Column",str,false);
               }
               // 
               if(str == "allmsg" || str == "allmessage"){
                    // 
                    Console.Clear();
                    // 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' ') + "Message" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' '), hy.DocFileReturnOneLine(strMSG), hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if(str == "times?"){
                    // 
                    str = hy.Value("Object >").ToLower().Replace(" ","");
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' ') + str + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' '),strData + " : " + hy.DocFile(strData + "Times/" + str) + "." + strTimes + " : " + hy.DocFile(strTimes + str) + "." + strDelay + " : " + hy.DocFileReturnNum(strDelay + str) + "m .Total : " + ((hy.DocFileReturnNum(strDelay + str) * hy.DocFileReturnNum(strTimes + str)) / 60) / 24 + "d " + ((hy.DocFileReturnNum(strDelay + str) * hy.DocFileReturnNum(strTimes + str)) / 60) % 24 + "h " + (hy.DocFileReturnNum(strDelay + str) * hy.DocFileReturnNum(strTimes + str)) % 60 + "m", hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if(str == "times"){
                    // 
                    str = hy.Value("Object >").ToLower().Replace(" ","");
                    // 
                    if(File.Exists(strData + "Times/" + str) == false && Directory.Exists(strLink + str) == true){
                         // 
                         hy.TaoFile(strData + "Times/" + str);
                         // 
                         File.Delete(strTimes + str);
                         // 
                         hy.GhiFile(strData + "Times/" + str,hy.ValueInt("Times >") + "",false);
                         // 
                         File.Copy(strData + "Times/" + str,strTimes + str);
                    }
               }
               //
               if(str == "listtime" || str == "lst"){
                    // 
                    str = hy.Value("Object >").ToLower().Replace(" ","");
                    str1 = hy.Value("Object -1 >").ToLower().Replace(" ","");
                    // 
                    hy.TaoThuMuc(strData + "ListTime/" + str);
                    hy.TaoFileVsSuaLoi(strData + "ListTime/" + str + "/" +  str1,"-1"); 
               }
               // 
               if(str == "showlisttime" || str == "slt"){
                    // 
                    str = hy.Value("Object >").ToLower().Replace(" ","");
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' ') + str + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(str), ' '), ShowListTime(strData + "ListTime/",str,"",hy), hy);
                    // 
                    Console.ReadKey();
               } 
               // 
               if(str == "navigation" || str == "nvgt"){
                    // 
                    Console.Clear();
                    // 
                    Navigation(strTimes,strNavigation,strTableWidth,hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if(str == "newnavigation" || str == "nnvgt"){
                    // 
                    str = hy.Value("New Navigation\nObject >").ToLower().Replace(" ","");
                    // 
                    hy.TaoFile(strNavigation + str);
                    // 
                    hy.GhiFile(strNavigation + str,hy.Value(str + " >"),false);
               }
               // 
               if (str == "newreality" || str == "nr"){
                    //
                    str = hy.Value("REALITY>");
                    Console.Write("{0}\\", str.Replace(" ", ""));
                    // 
                    NewReality(strFuture, strCount, str.Replace(" ", "").ToLower(), hy.Value().Replace(" ", "").ToLower(), hy);
               }
               // 
               if (str == "killreality" || str == "kr"){
                    // 
                    str = hy.Value("REALITY>");
                    Console.Write("{0}\\", str.Replace(" ", ""));
                    // 
                    KillReality(strFuture, strCount,strData,strActivity, str.Replace(" ", "").ToLower(), hy.Value().Replace(" ", "").ToLower(), hy);
               }
               //
               if(str == "delay"){
                    // 
                    hy.TaoFileVsSuaLoi(strDelay + hy.TenThuMuc(strLink),"0");
                    // 
                    hy.GhiFile(strDelay + hy.TenThuMuc(strLink),hy.DocFileReturnNum(strDelay + hy.TenThuMuc(strLink)) + 1 + "",false);
               }
               //
               if(str == "report"){
                    // 
                    hy.TaoFileVsSuaLoi(strDelay + hy.TenThuMuc(strLink),"0");
                    // 
                    hy.GhiFile(strDelay + hy.TenThuMuc(strLink),hy.DocFileReturnNum(strDelay + hy.TenThuMuc(strLink)) + 30 + "",false);
               }
               // 
               if(str == "menu"){
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' ') + "MENU" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' '),strMenu + ". [" + DateTime.Now + "]..add : them du lieu file.destiny : dinh menh.run : chay chuong trinh.graph : bieu do.set y : y graph.delete graph, del graph : xoa phan tu graph.column graph , cl graph: thay doi hinh ve cot.show random, show rd : xem danh sach nguoi dung random.holiday : show gif today.runautomatically, runat : them ma~ tu dong.risk management, rmngm : quan ly rui ro.all message,  all msg : xem tin nhan.times? : so lan ghi he thong.times : ghi so lan duoc tham gia cua doi tuong trong he thong.list time , lst : them doi tuong -1 lan tham gia.show list time, slt : hien thi danh sach list time.navigation, nvgt : dieu huong.new navigation, nnvgt : them dieu huong an toan danh cho nguoi dung.mission : nhiem vu cua nguoi dung.random list, rdlist : chon ngau nhien trong danh sach.random yn, rdyn : chon hoat dong trong danh sach.table : bang?.new reality, nr : tao hoat dong moi cho toan bo.kill reality, kr : xoa hoat dong cua toan bo chuong trinh.delay : can tro hoat dong co the gay nguy hai + 1 phut.report : them 30 phut delay.msg, message : gui tin nhan cua hoat dong.risk : tao rui ro.show risk : hien thi cac rui ro cua nguoi dung.count list : thong ke so lan truy cap.count continuous : thong ke so lan truy cap lien tiep.userrisk | ur : canh bao rui ro.usersafe | us : canh bao an toan.dir : liet ke thu muc.url : duong dan hien tai.url back : duong dan duoc xu ly lai.process back : hoat dong duoc xu ly lai", hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if (str == "msg" || str == "message")
                    // 
                    hy.TaoFileVsSuaLoi(strMessage + hy.Value("NEW MESSAGE>").Replace(" ", ""), hy.Value());
               // 
               if (str == "risk")
               {
                    // 
                    hy.TaoThuMuc(strData + "/Risk/" + DateTime.Now.Hour);
                    // 
                    hy.TaoFileVsSuaLoi(strData + "/Risk/" + DateTime.Now.Hour + "/" + hy.Value("NEW RISK>").Replace(" ", "").ToLower(), hy.Value("WARNING >"));
               }
               // 
               if(str == "showrisk"){
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' ') + "RISK" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' '), ShowRisk(strShow, strRisk, hy), hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if(str == "mission"){
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' ') + $"{numMission}%" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' '), ShowMission(strShow, strRisk, hy), hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if (str == "countlist"){
                    // 
                    try{
                         // 
                         CountList(strCount, arrValue, arrNum, hy);
                    }
                    // 
                    catch{

                    }
                    // 
                    Console.ReadKey();
               }
               // 
               if (str == "countcontinuous"){
                    // 
                    try{
                         // 
                         CountContinuous(strContinuous, arrValue, arrNum, hy);
                    }
                    // 
                    catch{

                    }
                    // 
                    Console.ReadKey();
               }
               // 
               if(str == "userrisk" || str == "ur")
                    // 
                    hy.TaoFile(strUserRisk + hy.Value("USER RISK> ").Replace(" ","").ToLower());
               // 
               if(str == "usersafe" || str == "us")
                    // 
                    hy.TaoFile(strUserSafe + hy.Value("USER SAFE> ").Replace(" ","").ToLower());
               // 
               if(str == "dir")
                    // 
                    LietKeThuMucVsDelay(strLink,strDelay,hy);
               // 
               if (str == "url"){
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 3, ' ') + "URL" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 3, ' '), strLink, hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if (str == "urlback"){
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' ') + "URL BACK" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' '), strLinkBack, hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if (str == "processback"){
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 12, ' ') + "PROCESS BACK" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 12, ' '), strProcessBack, hy);
                    // 
                    Console.ReadKey();
               }
               // 
               if(str == "table")
                    // 
                    TableScreen(str,strTable,strTableWidth,hy);
               // 
               if(str == "randomlist" || str == "rdlist" || blRDList == true)
                    // 
                    hy.GhiFile(strTodayElse + "random",$"{hy.TenThuMuc(strLink).ToUpper()} > {str1 = RandomList(str,strLink,strRandom,0,0,rd.Next(0,100),0.0,"",strTimes,blComputer,false,arrValue,arrNum,hy,rd)}.\n",true);
               // 
               if(str == "randomyn" || str == "rdyn")
                    // 
                    RandomYN(str,strLink,strRandom,0,0,0,rd.Next(0,10000),0.0,strTimes,blComputer,false,arrValue,arrNum,hy,rd);
               // 
               if(str == "showrandom" || str == "showrd"){
                    // 
                    Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 12, ' ') + "RANDOM LIST" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 12, ' '), hy.DocFileReturnOneLine(strTodayElse + "random"), hy);
                    // 
                    Console.ReadKey();
               }
               // 
               Situation(strUser,strLink,strUserRisk,hy);
               // 
               return str1;
          }
          // 
          public static void Situation(string strUser,string strLink,string strUserRisk,HelpYou hy){
               // 
               if(File.Exists(strUser + "Situation") == true){
                    // 
                    if(File.Exists(strUserRisk + hy.TenThuMuc(strLink)) == true && hy.DemThuMuc(strLink) == 1){
                         // 
                         string[] gD = Directory.GetDirectories(strLink);
                         foreach(string d in gD){
                              // 
                              if(File.Exists(strUserRisk + hy.TenThuMuc(d)) == true)
                                   // 
                                   hy.GhiFile(strUser + "Situation",DateTime.Now + "",false);
                         }
                    }
               }
          }
          // 
          public static void PrintAllDirectory(string dirPath,string strDirFuture,HelpYou hy)
          {
               // 
               try
               {
                    // Nếu bạn không có quyền truy cập thư mục 'dirPath' 
                    // một ngoại lệ UnauthorizedAccessException sẽ được ném ra.
                    IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);
                    List<string> dirs = new List<string>(enums);
                    foreach (var dir in dirs)
                    {
                         hy.TaoFile(strDirFuture);
                         hy.GhiFile(strDirFuture,dir + "\n",true);
                         PrintAllDirectory(dir,strDirFuture,hy);
                    }
               }
               // Lỗi bảo mật khi truy cập vào thư mục mà bạn không có quyền.
               catch (UnauthorizedAccessException e)
               {
                    Console.WriteLine("Can not access directory: " + dirPath);
                    Console.WriteLine(e.Message);
               }
          }
          // 
          public static void Navigation(string strTimes,string strNavigation,string strTableWidth,HelpYou hy){
               // 
               if(Directory.Exists(strNavigation) == true){
                    // 
                    string[] gF = Directory.GetFiles(strNavigation);
                    foreach(string f in gF){
                         // 
                         if(hy.DocFileReturnNum(strTimes + hy.TenFile(f)) > 0)
                              // 
                              Console.ForegroundColor = ConsoleColor.White;
                         //
                         if(hy.DocFileReturnNum(strTimes + hy.TenFile(f)) <= 0)
                              // 
                              Console.ForegroundColor = ConsoleColor.DarkGray;
                         // 
                         Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(hy.TenFile(f)), ' ') + hy.TenFile(f) + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(hy.TenFile(f)), ' '), hy.DocFile(f), hy);
                    }
                    // 
                    Console.ResetColor();
               }
          }
          // 
          public static void RandomYN(string str,string strLink,string strRandom,int num,int num1,int num0,double numRD,double numP,string strTimes,bool blComputer,bool bl,string[] arrValue, int[] arrNum,HelpYou hy,Random rd){
               // 
               if(Directory.Exists(strLink) == true && Directory.Exists(strRandom) == true){
                    // 
                    Directory.Delete(strRandom,true);
                    // 
                    hy.TaoThuMuc(strRandom);
                    // 
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach(string d in gD){
                         // 
                         bl = CheckTimes(hy.TenThuMuc(d),false,strTimes,hy);
                         // 
                         if(bl == true){
                              // 
                              hy.TaoFile(strRandom + hy.TenThuMuc(d));
                              // 
                              hy.GhiFile(strRandom + hy.TenThuMuc(d),0 + "",false);
                         }
                    }
                    // 
                    string[] gF = Directory.GetFiles(strRandom);
                    foreach(string f in gF){
                         // 
                         num1 = 0;
                         num0 = 0;
                         // 
                         for(double i = 0;i <= numRD;i++){
                              // 
                              numP = (i / numRD) * 100;
                              // 
                              num = rd.Next(0,2);
                              // 
                              if(num == 1)
                                   // 
                                   num1++;
                              // 
                              else
                                   // 
                                   num0++;
                              // 
                              if(blComputer == true)
                                   // 
                                   Console.Write($"\r {string.Format("{0:00.00}",numP)}% {Running("",num)} {hy.TenFile(f)}");

                              // 
                              else{
                                   // 
                                   Console.Clear();
                                   // 
                                   Console.Write($" {string.Format("{0:00.00}",numP)}% {Running("",num)} {hy.TenFile(f)}");
                              }
                              // 
                              if(num1 >= num0){
                                   // 
                                   hy.GhiFile(f,"1",false);
                                   // 
                                   // Console.BackgroundColor = ConsoleColor.Green;
                                   Console.ForegroundColor = ConsoleColor.Green;
                              }
                              // 
                              else{
                                   // 
                                   hy.GhiFile(f,"0",false);
                                   // 
                                   // Console.BackgroundColor = ConsoleColor.Red;
                                   Console.ForegroundColor = ConsoleColor.Red;
                              }
                         }
                         // 
                         if(blComputer == true)
                              // 
                              Console.WriteLine(" ");
                         // 
                         Console.ResetColor();
                         // 
                    }
                    Console.WriteLine();
                    // 
                    ShowRandom(strRandom,"",arrValue,arrNum,false,hy);
                    // 
                    Console.ReadKey();
               }
          }
          // 
          public static string RandomList(string str,string strLink,string strRandom,int num,int num1,double numRD,double numP,string strNameObj,string strTimes,bool blComputer,bool bl,string[] arrValue, int[] arrNum,HelpYou hy,Random rd){
               // 
               if(Directory.Exists(strLink) == true && Directory.Exists(strRandom) == true){
                    // 
                    Directory.Delete(strRandom,true);
                    // 
                    hy.TaoThuMuc(strRandom);
                    // 
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach(string d in gD){
                         // 
                         bl = CheckTimes(hy.TenThuMuc(d),false,strTimes,hy);
                         // 
                         if(bl == true){
                              // 
                              hy.TaoFile(strRandom + hy.TenThuMuc(d));
                              // 
                              hy.GhiFile(strRandom + hy.TenThuMuc(d),0 + "",false);
                         }
                    }
                    // 
                    for(double i = 0;i <= numRD;i++){
                         // 
                         numP = (i / numRD) * 100;
                         // 
                         num = 0;
                         // 
                         num1 = rd.Next(1,hy.DemThuMuc(strLink) + 1);
                         // 
                         string[] gF = Directory.GetFiles(strRandom);
                         foreach(string f in gF){
                              // 
                              num++;
                              // 
                              if(num1 == num){
                                   // 
                                   hy.GhiFile(f,hy.DocFileReturnNum(f) + 1 + "",false);
                                   // 
                                   strNameObj = hy.TenFile(f);
                              }
                         }
                         // 
                         if(blComputer == true)
                              // 
                              Console.Write($"\r {string.Format("{0:00.00}",numP)}% {Running("",rd.Next(0,2))} {strNameObj}");
                         // 
                         else{
                              // 
                              Console.Clear();
                              // 
                              Console.Write($" {string.Format("{0:00.00}",numP)}% {Running("",rd.Next(0,2))} {strNameObj}");
                         }
                    }
                    // 
                    Console.WriteLine(" ");
                    // 
                    strNameObj = ShowRandom(strRandom,"",arrValue,arrNum,true,hy);
                    // 
                    Console.ReadKey();
               }
               // 
               return strNameObj;
          }
          // 
          public static string ShowRandom(string strRandom,string strRT, string[] arrValue, int[] arrNum,bool bl, HelpYou hy)
          {
               // 
               if (Directory.Exists(strRandom) == true)
               {
                    // 
                    hy.SetCount();
                    // 
                    arrNum = new int[hy.DemFileTrongThuMuc(strRandom)];
                    arrValue = new string[hy.DemFileTrongThuMuc(strRandom)];
                    // 
                    string[] gF = Directory.GetFiles(strRandom);
                    foreach (string f in gF)
                    {
                         // 
                         arrNum[hy.GetCount()] = hy.DocFileReturnNum(f);
                         arrValue[hy.GetCount()] = hy.TenFile(f);
                         // 
                         hy.Count();
                    }
                    // 
                    IComparer myComparer = new myReverserClass();
                    // Sorts the entire Array using the default comparer.
                    // Array.Sort( arrNum, arrValue );
                    // Console.WriteLine( "After sorting the entire Array using the default comparer:" );
                    // PrintKeysAndValues( arrNum, arrValue );

                    // Sorts the entire Array using the reverse case-insensitive comparer.
                    Array.Sort(arrNum, arrValue, myComparer);
                    // Console.WriteLine( "After sorting the entire Array using the reverse case-insensitive comparer:" );
                    Console.WriteLine(" {0,-10}  {1}", "Times", "Object");
                    // 
                    if(bl == true)
                         // 
                         strRT = PrintKeysAndValuesRDList("",arrNum, arrValue);
                    // 
                    if(bl == false)
                         // 
                         PrintKeysAndValuesRDYN(arrNum, arrValue);
               }
               // 
               return strRT;
          }

          // 
          public static void ShowRiskManagementList(string strRiskManagement, string[] arrValue, int[] arrNum,bool bl, HelpYou hy)
          {
               // 
               if (Directory.Exists(strRiskManagement) == true)
               {
                    // 
                    hy.SetCount();
                    // 
                    arrNum = new int[hy.DemFileTrongThuMuc(strRiskManagement)];
                    arrValue = new string[hy.DemFileTrongThuMuc(strRiskManagement)];
                    // 
                    string[] gF = Directory.GetFiles(strRiskManagement);
                    foreach (string f in gF)
                    {
                         // 
                         arrNum[hy.GetCount()] = hy.DocFileReturnNum(f);
                         arrValue[hy.GetCount()] = hy.TenFile(f);
                         // 
                         hy.Count();
                    }
                    // 
                    IComparer myComparer = new myReverserClass();
                    // Sorts the entire Array using the default comparer.
                    // Array.Sort( arrNum, arrValue );
                    // Console.WriteLine( "After sorting the entire Array using the default comparer:" );
                    // PrintKeysAndValues( arrNum, arrValue );

                    // Sorts the entire Array using the reverse case-insensitive comparer.
                    Array.Sort(arrNum, arrValue, myComparer);
                    // Console.WriteLine( "After sorting the entire Array using the reverse case-insensitive comparer:" );
                    Console.WriteLine(" {0,-10}  {1}", "Percent", "Object");
                    // 
                    if(bl == true)
                         // 
                         PrintKeysAndValuesRDList("",arrNum, arrValue);
                    // 
                    if(bl == false)
                         // 
                         PrintKeysAndValuesRDYN(arrNum, arrValue);
               }
          }
          // 
          public static void TableScreen(string str,string strTable,string strTableWidth,HelpYou hy){
               // 
               Console.ResetColor();
               do{
                   try{
                         // xoa man hinh
                         Console.Clear();
                         // 
                         Table(hy.Draw(hy.DocFileReturnNum(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/Space") / 2,' ') + hy.TenFile(strTable + hy.DocFile(strTable + "InUse")) + hy.Draw(hy.DocFileReturnNum(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/Space") / 2,' '),hy.DocFileReturnOneLineWithNumShow(strTable + hy.DocFile(strTable + "InUse"),hy.DocFileReturnNum(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/FCh"),hy.DocFileReturnNum(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/ECh")),hy);
                         //
                         Console.Write("\n{0} > {1} ",hy.DocFileReturnNum(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/FCh"),hy.DocFileReturnNum(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/ECh"));
                         //  
                         str = hy.Value().ToLower().Replace(" ","");

                         // 
                         if(str == "fch"){
                              Console.Write("FISRT CHAR>");
                              // 
                              hy.GhiFile(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/FCh",hy.Value(),false);
                         }
                         // 
                         if(str == "ech"){
                              Console.Write("END CHAR>");
                              // 
                              hy.GhiFile(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/ECh",hy.Value(),false);
                         }
                         // 
                         if(str == "createtable"){
                              //
                              str = hy.Value("NEW TABLE>").Replace(" ","").ToLower();
                              //
                              if(File.Exists(strTable + str) == false){
                                  // 
                                  hy.TaoFile(strTable + str);
                                  // 
                                  hy.TaoThuMuc(strTable + "FECH/" + str);
                                  // 
                                  hy.TaoFileVsSuaLoi(strTable + "FECH/" + str + "/FCh","0");
                                  hy.TaoFileVsSuaLoi(strTable + "FECH/" + str + "/ECh","0");
                                  hy.TaoFileVsSuaLoi(strTable + "FECH/" + str + "/Space","0");
                              }
                         }
                         // 
                         if(str == "opentable"){
                              // 
                              str = hy.Value("NAME TABLE>").Replace(" ","").ToLower();
                              // 
                              if(File.Exists(strTable + str) == true && str != "user")
                                  // 
                                  hy.GhiFile(strTable + "InUse",str,false);
                         }
                         // 
                         if(str == "deletetable"){
                              // 
                              str = hy.Value("NAME TABLE>").Replace(" ","").ToLower();
                              // 
                              if(File.Exists(strTable + str) == true)
                                  // 
                                  File.Delete(strTable + str);
                              // 
                              if(Directory.Exists(strTable + "FECH/" + str) == true)
                                  // 
                                  Directory.Delete(strTable + "FECH/" + str,true);
                         }
                         // 
                         if(str == "+"){
                              Console.Write("NEW CONTENT [{0}]>",hy.DocFile(strTable + "/InUse"));
                              str = hy.Value();
                              // 
                              if(File.Exists(strTable + hy.DocFile(strTable + "InUse")) == true)
                                  // 
                                  hy.GhiFileVaDongMoi(strTable + hy.DocFile(strTable + "InUse"),str,true);
                         }
                         // 
                         if(str == "-"){
                              Console.Write("DELETE STRING [{0}]>",hy.DocFile(strTable + "/InUse"));
                              str = hy.Value();
                              // 
                              if(File.Exists(strTable + hy.DocFile(strTable + "InUse")) == true)
                                 // 
                                 hy.GhiFileVaDongMoi(strTable + hy.DocFile(strTable + "InUse"),hy.DocFile(strTable + hy.DocFile(strTable + "InUse")).Replace(str,""),false);
                              // 
                              DeleteNullInFile(strTable + hy.DocFile(strTable + "InUse"),hy);
                         }
                         // 
                         if(str == "replace"){
                              Console.Write("REPLACE STRING [{0}]>",hy.DocFile(strTable + "/InUse"));
                              str = hy.Value();
                              // 
                              if(File.Exists(strTable + hy.DocFile(strTable + "InUse")) == true){
                                   Console.Write("{0} > ",str);
                                   // 
                                   hy.GhiFile(strTable + hy.DocFile(strTable + "InUse"),hy.DocFile(strTable + hy.DocFile(strTable + "InUse")).Replace(str,hy.Value()),false);
                                   //     
                                   DeleteNullInFile(strTable + hy.DocFile(strTable + "InUse"),hy);
                              }
                         }
                         // 
                         if(str == "clear"){
                              Console.Write("DU LIEU CUA TABLE [{0}] SE BI XOA! Y/N>",hy.DocFile(strTable + "/InUse"));
                              str = hy.Value();
                              // 
                              if(File.Exists(strTable + hy.DocFile(strTable + "InUse")) == true && str.ToLower() == "y")
                                  // 
                                  hy.GhiFile(strTable + hy.DocFile(strTable + "InUse"),"",false);
                         }
                         // 
                         if(str == "space"){
                              Console.Write("SPACE {0} > ",hy.DocFile(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/Space"));
                              str = hy.Value();
                              // 
                              if(File.Exists(strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/Space") == true)
                                  // 
                                  hy.GhiFile((strTable + "FECH/" + hy.DocFile(strTable + "InUse") + "/Space"),str,false);
                         }
                         // 
                         if(str == "menu"){
                              // 
                              Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' ') + "MENU" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 4, ' '),"fch : so ky tu dau tien duoc hien thi.ech : so ky tu cuoi cung duoc hien thi.create table : tao bang.open table : chon bang.delete table : xoa bang.+ : them du lieu.- : xoa du lieu.replace : thay doi du lieu.clear : xoa noi dung.space : khoang trong.off : loi thoat", hy);
                              // 
                              Console.ReadKey();
                         }

     
                    }catch(Exception e){
                         // 
                         Console.WriteLine(e);
                         // 
                         Console.ReadKey();
                         // 
                         hy.TaoThuMuc(strTable + "FECH");
                         hy.TaoThuMuc(strTable + "FECH/Notes");
                         //     
                         hy.TaoFile(strTable + "Notes");
                         hy.TaoFile(strTable + "FECH/Notes/FCh");
                         hy.TaoFile(strTable + "FECH/Notes/ECh");
                         hy.TaoFile(strTable + "FECH/Notes/Space");
                         hy.TaoFile(strTable + "/InUse");
                         // 
                         hy.GhiFile(strTable + "/InUse","Notes",false);
                         hy.GhiFile(strTable + "FECH/Notes/Space","0",false);
                         hy.GhiFile(strTable + "Notes","menu",false);
                         hy.GhiFile(strTable + "FECH/Notes/FCh","1",false);
                         hy.GhiFile(strTable + "FECH/Notes/ECh","100",false);
                    }
     
               }while(str != "off");
          }
          // 
          public static void DeleteNullInFile(string strLink,HelpYou hy){
               // 
               if(File.Exists(strLink) == true){
                    // 
                    hy.TaoFile(strLink + hy.TenFile(strLink));
                    // 
                    string[] rF = File.ReadAllLines(strLink);
                    foreach(string line in rF){
                         // 
                         if(line != "")
                              // 
                              hy.GhiFile(strLink + hy.TenFile(strLink),line + "\n",true);
                    }
                    // 
                    File.Delete(strLink);
                    // 
                    File.Move(strLink + hy.TenFile(strLink),strLink);
               }
          }
          // 
          public static void LietKeThuMucVsDelay(string strLink,string strDelay,HelpYou hy){
               // 
               string[] gD = Directory.GetDirectories(strLink);
               foreach(string d in gD){
                    // 
                    Console.WriteLine("{0} {1}",d,hy.DocFile(strDelay + hy.TenThuMuc(d)));
               }
               // 
               Thread.Sleep(1000);
          }
          // 
          public static void Delay(string str,string strDelay,string strTableWidth,string strMain,string strDelayList,double numShow,double numDelay,double numSeconds,string strTimes,string strNavigation,string strSystem,bool bl,List<string> listDelayTimes,HelpYou hy){
               // 
               if(File.Exists(strDelay + str) == true){
                    // 
                    listDelayTimes.Clear();
                    // 
                    Console.Clear();
                    // 
                    Console.ForegroundColor = ConsoleColor.Red;
                    // 
                    DateTime dt = DateTime.ParseExact("00:00:00", "HH:mm:ss", null);
                    DateTime d1 = dt.AddSeconds(hy.DocFileReturnNum(strDelay + str) * 60);
                    DateTime d2 = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second);
                    // Create a new Stopwatch object
                    Stopwatch stopwatch = new Stopwatch();
                    // Start the stopwatch
                    stopwatch.Start();
                    // 
                    numSeconds = hy.DocFileReturnNum(strDelay + str) * 60;
                    // 
                    for(int i = 0;i < numSeconds;i++){
                         // 
                         if(((i / numSeconds) * 100) % 10 == 0){
                              // 
                              if((i / numSeconds) * 100 != numShow){
                                   // 
                                   strDelayList = strDelayList + d2.AddSeconds(i).ToString("[HH:mm:ss tt dd/MM/yyyy] ") + (numShow + 10) + "%.";
                                   // 
                                   listDelayTimes.Add(d2.AddSeconds(i).ToString("[HH:mm:ss tt dd/MM/yyyy] ") + (numShow + 10) + "%");
                              }
                              // 
                              numShow = (i / numSeconds) * 100;
                         }
                         // 
                    }
                    // Stop the stopwatch
                    stopwatch.Stop();
                    // 
                    listDelayTimes.Add("");
                    listDelayTimes.Add("");
                    // 
                    // Output the elapsed time
                    // Console.WriteLine("Time elapsed: {0} h {1} m {2} s total s {3}",ts.Hours, ts.Minutes,  ts.Seconds,(ts.Hours * 60 * 60) + (ts.Minutes * 60) + ts.Seconds);
                    // 
                    numDelay = ((numSeconds * 0.1) * 1000) - NumSecondsCalculation(stopwatch);
                    // 
                    FinalMainCheck(strMain,strTimes,"","",hy);
                    // 
                    for(int i = 0;i <= 10;i++){
                         // 
                         Console.Clear();
                         // 
                         if(i < 10){
                              // 
                              stopwatch = new Stopwatch();
                              // Start the stopwatch
                              stopwatch.Start();
                              // 
                              Navigation(strTimes,strNavigation,strTableWidth,hy);
                              // 
                              if(hy.DemSoDongTrongFile(strSystem + "MSG") > 0 && File.Exists(strSystem + "MSG") == true)
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' ') + "Message" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' '), hy.DocFile(strSystem + "MSG"), hy);
                              // 
                              if(hy.TenFile(hy.LietKeFile(strMain,"")).Replace(".","").Replace(" ","") != "" && hy.DocFile(strMain + hy.TenFile(hy.LietKeFile(strMain,""))).Replace(".","").Replace(" ","") != "")
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(hy.TenFile(hy.LietKeFile(strMain,""))), ' ') + hy.TenFile(hy.LietKeFile(strMain,"")).Replace(".","") + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - hy.DemStr(hy.TenFile(hy.LietKeFile(strMain,""))), ' '), hy.DocFile(strMain + hy.TenFile(hy.LietKeFile(strMain,""))).Replace(".",""), hy);
                              // 
                              Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' ') + "WARNING!" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' '), "HOAT DONG " + str + " SE MANG LAI RUI RO!.BAN CO THE TIEP TUC HOAT DONG SAU:" + d2.AddSeconds(hy.DocFileReturnNum(strDelay + str) * 60).ToString(" HH:mm tt d/MM/yyyy") + "." + strDelayList, hy);
                              // Stop the stopwatch
                              stopwatch.Stop();
                              // 
                         }
                         // 
                         Console.WriteLine("\nProcessing...");
                         // 
                         Processing((i * 10));
                         // 
                         if(((int)numDelay) + NumSecondsCalculation(stopwatch) * 9 <= ((int)numDelay * 10))
                              // 
                              if(i < 10 && ((int)numDelay - NumSecondsCalculation(stopwatch)) > 0)
                                   // 
                                   Thread.Sleep((int)numDelay - NumSecondsCalculation(stopwatch));
                         // 
                         if(((int)numDelay) + NumSecondsCalculation(stopwatch) * 9 > ((int)numDelay * 10)){
                              // 
                              Thread.Sleep(((int)numDelay * 10) - NumSecondsCalculation(stopwatch));
                              // 
                              break;
                         }
                         // 
                         strDelayList = strDelayList.Replace(listDelayTimes[i] + ".","");
                    }
                    // 
                    Console.ResetColor();
               }
          }
          // 
          public static int NumSecondsCalculation(Stopwatch stopwatch){
               // Get the elapsed time as a TimeSpan value.
               TimeSpan ts = stopwatch.Elapsed;
               // 
               return ((ts.Hours * 60 * 60) + (ts.Minutes * 60) + ts.Seconds) * 1000;
          }
          // 
          public static void FinalMainCheck(string strMain,string strTimes,string str,string strNameFile,HelpYou hy){
               // 
               if(hy.TenFile(hy.LietKeFile(strMain,"")).Replace(".","").Replace(" ","") != "" && hy.DocFile(strMain + hy.TenFile(hy.LietKeFile(strMain,""))).Replace(".","").Replace(" ","") != ""){
                    // 
                    strNameFile = hy.TenFile(hy.LietKeFile(strMain,""));
                    // 
                    str = hy.DocFile(strMain + hy.TenFile(hy.LietKeFile(strMain,""))).Replace(" ","\n");
                    // 
                    File.Delete(strMain + hy.TenFile(hy.LietKeFile(strMain,"")));
                    // 
                    hy.TaoFileVsSuaLoi(strMain + strNameFile + strNameFile,str);
                    // 
                    hy.TaoFile(strMain + strNameFile);
                    // 
                    string[] rF = File.ReadAllLines(strMain + strNameFile + strNameFile);
                    foreach(string lines in rF){
                         // 
                         if(hy.DocFileReturnNum(strTimes + lines) > 0)
                              // 
                              hy.GhiFile(strMain + strNameFile,lines + " ",true);
                    }
                    // 
                    File.Delete(strMain + strNameFile + strNameFile);
               }
          }
          // 
          public static string Processing(int num){
               //
               Console.BackgroundColor = ConsoleColor.Green;
               // 
               for(int i = 1;i <= num / 10;i++){
                    // 
                    Console.Write("  ");
               }
               //
               Console.BackgroundColor = ConsoleColor.Red;
               // 
               for(int i = 1;i <= 10 - (num / 10);i++){
                    // 
                    Console.Write("  ");
               } 
               // 
               Console.ResetColor();
               // 
               Console.WriteLine(" {0}%",num);
               // 
               return null;
          }
          // 
          public static int Safe(string strUserSafe,string strLink,string strFuture,string strTimes,int num,bool bl, HelpYou hy)
          {
               if(hy.TenThuMuc(strLink) == hy.TenThuMuc(strFuture)){
                    // 
                    bl = true;
                    // 
                    num = 0;
               }
               // 
               if(Directory.Exists(strLink) == true && Directory.Exists(strUserSafe) == true){
                    // 
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach(string d in gD){
                         //  
                         num = GetActivityForUser(d,strUserSafe,hy.TenThuMuc(d),strTimes,num,bl,hy);
                    }
               }
               // 
               if(num > 0){
                    // 
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    // 
                    Console.Write("\nActivity");
                    // 
                    if(bl == false){
                         // 
                         Console.Write($"+{num}");
                    }
                   
               }
               // 
               return num;
          }
          // 
          public static int GetActivityForUser(string dirPath,string strUserSafe,string strObj,string strTimes,int num,bool bl,HelpYou hy){
               // 
               try
               {
                    // Nếu bạn không có quyền truy cập thư mục 'dirPath' 
                    // một ngoại lệ UnauthorizedAccessException sẽ được ném ra.
                    IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);
                    List<string> dirs = new List<string>(enums);
                    foreach (var dir in dirs)
                    {
                         // Console.WriteLine(dir);
                         num = GetActivityForUser(dir,strUserSafe,strObj,strTimes,num,bl,hy);
                         // 
                         if(File.Exists(strUserSafe + hy.TenThuMuc(dir)) == true && hy.DocFileReturnNum(strTimes + hy.TenThuMuc(dir)) > 0){
                              // 
                              Console.Write($"{strObj.ToUpper()} ");
                              // 
                              if(bl == true)
                                   // 
                                   num++;
                         }
                    }
               }
               // Lỗi bảo mật khi truy cập vào thư mục mà bạn không có quyền.
               catch (UnauthorizedAccessException e)
               {
                    Console.WriteLine("Can not access directory: " + dirPath);
                    Console.WriteLine(e.Message);
               }
               // 
               return num;
          }
          // 
          public static void SafetyChecking(string str,string strSafe,string strUserRisk,string strUserSafe,string strLink,HelpYou hy){
               // 
               if(Directory.Exists(strSafe) == true){
                    // 
                    if(File.Exists(strUserRisk + str) == true){
                         // 
                         hy.TaoFile(strSafe + DateTime.Now.Hour);
                         // 
                         hy.GhiFile(strSafe + DateTime.Now.Hour,strLink.Replace("/"," >").Replace("\\"," >") + str + ".\n",true);
                    }
                    // 
                    if(File.Exists(strUserSafe + str) == true && File.Exists(strSafe + DateTime.Now.Hour) == true)
                         // 
                         File.Delete(strSafe + DateTime.Now.Hour);
               }
          }
          // 
          public static void LoadingRisk(string strD, string strR,string strMission,string strNewMission, int num, HelpYou hy)
          {
               // 
               if (Directory.Exists(strD) == true && Directory.Exists(strMission) == false)
               {
                    if(Directory.Exists(strNewMission) == true)
                         // 
                         Directory.Delete(strNewMission,true);
                    // 
                    hy.TaoThuMuc(strNewMission);
                    hy.TaoThuMuc(strMission);
                    hy.TaoThuMuc(strR);
                    // 
                    hy.TaoFileVsSuaLoi(strMission + "MissionPercent","0");
                    // 
                    string[] gD = Directory.GetDirectories(strD);
                    foreach (string d in gD)
                    {
                         // 
                         num = int.Parse(hy.TenThuMuc(d));
                         // 
                         if (num >= DateTime.Now.Hour)
                         {
                              // 
                              string[] gF = Directory.GetFiles(d);
                              foreach (string f in gF)
                              {
                                   // 
                                   if (File.Exists(strR + hy.TenFile(f)) == false){
                                        // 
                                        try
                                        {
                                             // 
                                             File.Copy(f, strR + hy.TenFile(f), true);
                                        }
                                        catch
                                        {
                                             // 
                                             File.Copy(f, strR + hy.TenFile(f), true);
                                        }
                                   }
                              }
                         }
                         num = 0;
                    }
               }
          }
          // 
          public static void ShowReality(string strF,string strLink,string strMessage,string strTable, string strNR,string str,string strTableWidth,bool bl, HelpYou hy)
          {
               // 
               if (Directory.Exists(strF) == true)
               {
                    // 
                    IEnumerable<string> enums = Directory.EnumerateDirectories(strF);
                    List<string> dirs = new List<string>(enums);
                    foreach (var dir in dirs)
                    {
                         // 
                         // Console.WriteLine(dir.Substring(dir.LastIndexOf("\\")+1));
                         // Console.WriteLine(dir.Substring(dir.LastIndexOf("/")+1));
                         // 
                         // 
                         if (dir.Substring(dir.LastIndexOf("\\") + 1) == strNR || dir.Substring(dir.LastIndexOf("/") + 1) == strNR || dir.Contains($"{strNR}") == true){
                              // 
                              Console.ForegroundColor = ConsoleColor.Red;
                              // 
                              Console.WriteLine("├─" + dir.Replace("/", " >").Replace("\\", " >").Replace(strNR, "[" + strNR + "]"));
                              // 
                              if(bl == true && File.Exists(strMessage + hy.TenThuMuc(dir)) == true){
                                   // 
                                   Console.ForegroundColor = ConsoleColor.Yellow;
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' ') + "Message" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 8, ' '), hy.DocFile(strMessage + hy.TenThuMuc(dir)), hy);
                              }
                              // 
                              if(bl == true && File.Exists(strTable + hy.TenThuMuc(dir)) == true)
                              {
                                   // 
                                   Console.ForegroundColor = ConsoleColor.White;
                                   // 
                                   Table(hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 6, ' ') + "Table" + hy.Draw((hy.DocFileReturnNum(strTableWidth) / 2) - 6, ' '), hy.DocFileReturnOneLine(strTable + hy.TenThuMuc(dir)), hy);
                              }
                         }
                         // 
                         ShowReality(dir,strLink,strMessage,strTable, strNR,str,strTableWidth,bl, hy);
                    }
               }
          }
          // 
          public static void UnexpectedActivity(string strF, string strC, string strNR, HelpYou hy)
          {
               // 
               if (Directory.Exists(strF) == true)
               {
                    // 
                    IEnumerable<string> enums = Directory.EnumerateDirectories(strF);
                    List<string> dirs = new List<string>(enums);
                    foreach (var dir in dirs)
                    {
                         // 
                         // Console.WriteLine(dir.Substring(dir.LastIndexOf("\\")+1));
                         // Console.WriteLine(dir.Substring(dir.LastIndexOf("/")+1));
                         // Console.WriteLine(dir);
                         // 
                         if (dir.Substring(dir.LastIndexOf("\\") + 1) == strNR || dir.Substring(dir.LastIndexOf("/") + 1) == strNR)
                              // 
                              Console.WriteLine("+ " + hy.TenThuMuc(dir.Replace("/" + strNR,"").Replace("\\" + strNR,"")));
                         // 
                         UnexpectedActivity(dir, strC, strNR, hy);
                    }
               }
          }
          // 
          public static void NewReality(string strF, string strC, string str, string strNR, HelpYou hy)
          {
               // 
               if (Directory.Exists(strF) == true)
               {
                    // 
                    IEnumerable<string> enums = Directory.EnumerateDirectories(strF);
                    List<string> dirs = new List<string>(enums);
                    foreach (var dir in dirs)
                    {
                         // 
                         // Console.WriteLine(dir.Substring(dir.LastIndexOf("\\")+1));
                         // Console.WriteLine(dir.Substring(dir.LastIndexOf("/")+1));
                         // 
                         if (dir.Substring(dir.LastIndexOf("\\") + 1) == str || dir.Substring(dir.LastIndexOf("/") + 1) == str)
                         {
                              // 
                              hy.TaoThuMuc(dir + "/" + strNR);
                              // 
                              hy.TaoFileVsSuaLoi(strC + strNR, "0");
                         }
                         // 
                         NewReality(dir, strC, str, strNR, hy);
                    }
               }
          }
          // 
          public static void ChangeFileName(string strD,string str,string str1, HelpYou hy)
          {
               // 
               if (Directory.Exists(strD) == true)
               {
                    string strFileName = "";
                    string[] fileList = Directory.GetFiles(strD);//lay danh sách file cho vao mảng
                    //duyet mang file trong thư mục
                    foreach (string fileName in fileList)
                    {
                         strFileName = "";
                         strFileName = Path.GetFileName(fileName).Trim();
                         ProcessChangeFileName(fileName,str,str1, strFileName);
                    }
                    // 
                    string[] directorylist = Directory.GetDirectories(strD);//lấy danh sách target file cho vào mảng
                    //duyệt mảng target
                    foreach (string directory in directorylist)
                    {
                         ChangeFileName(directory,str,str1,hy);
                    }
               }
          }
          // 
          public static void ProcessChangeFileName(string path,string str,string str1, string strfileName)
          {
               if (path.Substring(path.LastIndexOf("\\") + 1) == str || path.Substring(path.LastIndexOf("/") + 1) == str)
                    // 
                    // Console.WriteLine("{0}", path.Replace(str,"") + str1);
                    // 
                    if(File.Exists(path.Replace(str,"") + str1) == false && str1 != "")
                         // 
                         File.Move(path,path.Replace(str,str1));
          }
          // 
          public static void KillReality(string strF, string strC,string strData,string strActivity, string str, string strNR, HelpYou hy)
          {
               // 
               if (Directory.Exists(strF) == true)
               {
                    // 
                    IEnumerable<string> enums = Directory.EnumerateDirectories(strF);
                    List<string> dirs = new List<string>(enums);
                    foreach (var dir in dirs)
                    {
                         // 
                         // Console.WriteLine(dir.Substring(dir.LastIndexOf("\\")+1));
                         // Console.WriteLine(dir.Substring(dir.LastIndexOf("/")+1));
                         // 
                         if (dir.Substring(dir.LastIndexOf("\\") + 1) == str || dir.Substring(dir.LastIndexOf("/") + 1) == str)
                         {
                              // 
                              Directory.Delete(dir + "/" + strNR, true);
                              // 
                              if(strNR == ""){
                                   // 
                                   File.Delete(strC + str);
                                   File.Delete(strData + "Times/" + str);
                                   File.Delete(strActivity + str);
                              }
                              // 
                              File.Delete(strC + strNR);
                              File.Delete(strData + "Times/" + strNR);
                              File.Delete(strActivity + strNR);
                         }
                         // 
                         KillReality(dir, strC, strData,strActivity, str, strNR, hy);
                    }
               }
          }
          // 
          public static void CountContinuous(string strC, string[] arrValue, int[] arrNum, HelpYou hy)
          {
               // 
               if (Directory.Exists(strC) == true)
               {
                    // 
                    hy.SetCount();
                    // 
                    arrNum = new int[hy.DemThuMuc(strC)];
                    arrValue = new string[hy.DemThuMuc(strC)];
                    // 
                    string[] gD = Directory.GetDirectories(strC);
                    foreach (string d in gD)
                    {
                         // 
                         arrNum[hy.GetCount()] = hy.DocFileReturnNum(d + "/continuousdays");
                         arrValue[hy.GetCount()] = hy.TenThuMuc(d);
                         // 
                         hy.Count();
                    }
                    // 
                    IComparer myComparer = new myReverserClass();
                    // Sorts the entire Array using the default comparer.
                    // Array.Sort( arrNum, arrValue );
                    // Console.WriteLine( "After sorting the entire Array using the default comparer:" );
                    // PrintKeysAndValues( arrNum, arrValue );

                    // Sorts the entire Array using the reverse case-insensitive comparer.
                    Array.Sort(arrNum, arrValue, myComparer);
                    // Console.WriteLine( "After sorting the entire Array using the reverse case-insensitive comparer:" );
                    Console.WriteLine(" {0,-10}  {1}", "Times", "Object");
                    PrintKeysAndValuesWithNum(arrNum, arrValue,20);
               }
          }
          // 
          public static void CountList(string strC, string[] arrValue, int[] arrNum, HelpYou hy)
          {
               // 
               if (Directory.Exists(strC) == true)
               {
                    // 
                    hy.SetCount();
                    // 
                    arrNum = new int[hy.DemFileTrongThuMuc(strC)];
                    arrValue = new string[hy.DemFileTrongThuMuc(strC)];
                    // 
                    string[] gF = Directory.GetFiles(strC);
                    foreach (string f in gF)
                    {
                         // 
                         arrNum[hy.GetCount()] = hy.DocFileReturnNum(f);
                         arrValue[hy.GetCount()] = hy.TenFile(f);
                         // 
                         hy.Count();
                    }
                    // 
                    IComparer myComparer = new myReverserClass();
                    // Sorts the entire Array using the default comparer.
                    // Array.Sort( arrNum, arrValue );
                    // Console.WriteLine( "After sorting the entire Array using the default comparer:" );
                    // PrintKeysAndValues( arrNum, arrValue );

                    // Sorts the entire Array using the reverse case-insensitive comparer.
                    Array.Sort(arrNum, arrValue, myComparer);
                    // Console.WriteLine( "After sorting the entire Array using the reverse case-insensitive comparer:" );
                    Console.WriteLine(" {0,-10}  {1}", "Times", "Object");
                    PrintKeysAndValuesWithNum(arrNum, arrValue,20);
               }
          }
          // 
          public static void PrintKeysAndValues(int[] myKeys, String[] myValues)
          {
               for (int i = 0; i < myKeys.Length; i++)
               {
                    Console.WriteLine(" {0,-10}: {1}", myKeys[i], myValues[i]);
               }
               Console.WriteLine();
          }
          // 
          public static void PrintKeysAndValuesWithNum(int[] myKeys, String[] myValues,int num)
          {
               for (int i = 0; i < num; i++)
               {
                    Console.WriteLine(" {0,-10}: {1}", myKeys[i], myValues[i]);
               }
               Console.WriteLine();
          }
          // 
          public static string PrintKeysAndValuesRDList(string strRT,int[] myKeys, String[] myValues)
          {
               for (int i = 0; i < myKeys.Length; i++)
               {
                    // 
                    if(i == 0){
                         // 
                         strRT = myValues[i];
                         // 
                         Console.ForegroundColor = ConsoleColor.Green;
                    }
                    // 
                    else
                         // 
                         Console.ForegroundColor = ConsoleColor.Red;
                    // 
                    Console.WriteLine(" {0,-10}: {1}", myKeys[i], myValues[i]);
               }
               // 
               Console.WriteLine();
               //
               return strRT; 
          }
          // 
          public static void PrintKeysAndValuesRDYN(int[] myKeys, String[] myValues)
          {
               for (int i = 0; i < myKeys.Length; i++)
               {
                    // 
                    if(myKeys[i] >= 1)
                         // 
                         Console.ForegroundColor = ConsoleColor.Green;
                    // 
                    else
                         // 
                         Console.ForegroundColor = ConsoleColor.Red;
                    // 
                    Console.WriteLine(" {0,-10}: {1}", myKeys[i], myValues[i]);
               }
               Console.WriteLine();
          }
          // 
          public static void Money(int num){
               // 
               if(num > 0)
                    // 
                    Console.ForegroundColor = ConsoleColor.Green;
               // 
               else
                    // 
                    Console.ForegroundColor = ConsoleColor.Red;

          }
          // 
          public static string ShowRisk(string strReturn, string strR, HelpYou hy)
          {
               if (Directory.Exists(strR) == true)
               {
                    string[] gF = Directory.GetFiles(strR);
                    foreach (string f in gF)
                    {
                         strReturn = strReturn + hy.DocFile(f) + ".";
                    }
               }
               return strReturn;
          }
          // 
          public static string ShowMission(string strReturn, string strR, HelpYou hy)
          {
               if (Directory.Exists(strR) == true)
               {
                    string[] gF = Directory.GetFiles(strR);
                    foreach (string f in gF)
                    {
                         strReturn = strReturn + hy.TenFile(f) + ".";
                    }
               }
               return strReturn;
          }
          // 
          public static void KillRisk(string strR, string str,string strRisk,string strMission,string strNewMission,string strTimes,int numMission, HelpYou hy)
          {
               // 
               if (File.Exists(strR + str) == true && hy.DocFileReturnNum(strTimes + str) <= 0){
                    // 
                    File.Delete(strR + str);
                    // 
                    hy.GhiFile(strMission + "MissionPercent",(100 - (hy.DemFileTrongThuMuc(strRisk) * 100) / numMission) + "",false);
               }
          }
          // 
          public static string UserSafe(string strUserSafe,string strNameObj,HelpYou hy){
               // 
               if(File.Exists(strUserSafe + strNameObj) == true)
                    // 
                    return "*.";
               // 
               return ".";
          }
          // 
          public static string SetPoint(string strD,string strPoint,int numDays,HelpYou hy){
               // 
               if(Directory.Exists(strD) == true){
                    // 
                    numDays = hy.DocFileReturnNum(strD + "/continuousdays");
                    // 
                    strPoint = string.Format("(+{0:00,0})",numDays).Replace(".",",");
               }
               // 
               return strPoint;
          }
          // 
          public static string CayThuMuc(string strReturn, string strCount, string strLink, string strMain, string strContinuous,string strDelay,string strTimes,string strUserSafe,string strNameObj,string strPoint,int numDays,int numSTT,bool blZTimes,bool blSetSpace, int num,List<string> listCayThuMuc, HelpYou hy)
          {
               // 
               if (Directory.Exists(strLink) == true)
               {
                    // strReturn = hy.Draw(hy.CountStr(hy.TenThuMuc(strMain)),' ') + "┌─────────────.";
                    strReturn = hy.Draw(hy.CountStr(hy.TenThuMuc(strMain)), '─') + "┐.";
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach (string d in gD)
                    {
                         // 
                         numSTT++;
                         // 
                         strNameObj = hy.TenThuMuc(d);
                         // 
                         listCayThuMuc.Add(strNameObj);
                         // 
                         strPoint = SetPoint(strContinuous + strNameObj,"",0,hy);
                         // 
                         num++;
                         // 
                         if (num == (hy.DemThuMuc(strLink) / 2) || num == 1 && hy.DemThuMuc(strLink) == 1)
                         {
                              // 
                              if(blZTimes == true){
                                   // 
                                   if(hy.DocFileReturnNum(strTimes + strNameObj) > 0)
                                        // 
                                        strReturn = strReturn + hy.TenThuMuc(strMain) + "─┼─" + numSTT + "[" + hy.DocFile(strTimes + strNameObj) + "][" + hy.DemThuMuc(strMain + strNameObj) + "][" + (hy.DocFile(strDelay + strNameObj)) + "m] " + strNameObj + strPoint + UserSafe(strUserSafe,strNameObj,hy);
                                   // 
                                   else{
                                        // 
                                        strReturn = strReturn + hy.TenThuMuc(strMain) + "─┼";
                                        // 
                                        blSetSpace = false;
                                   }
                              }
                              // 
                              else
                                   // 
                                   strReturn = strReturn + hy.TenThuMuc(strMain) + "─┼─" + numSTT + "[" + hy.DocFile(strTimes + strNameObj) + "][" + hy.DemThuMuc(strMain + strNameObj) + "][" + (hy.DocFile(strDelay + strNameObj)) + "m] " + strNameObj + strPoint + UserSafe(strUserSafe,strNameObj,hy);

                         }
                         // 
                         else
                         {
                              // 
                              if(blZTimes == true){
                                   // 
                                   if(hy.DocFileReturnNum(strTimes + strNameObj) > 0){
                                        // 
                                        if(blSetSpace == true)
                                             // 
                                             strReturn = strReturn + hy.Draw(hy.CountStr(hy.TenThuMuc(strMain)), ' ') + "├─" + numSTT + "[" + hy.DocFile(strTimes + strNameObj) + "][" + hy.DemThuMuc(strMain + strNameObj) + "][" + hy.DocFile(strDelay + strNameObj) + "m] " + strNameObj + strPoint + UserSafe(strUserSafe,strNameObj,hy);
                                        // 
                                        else{
                                             // 
                                             strReturn = strReturn + "─" + numSTT + "[" + hy.DocFile(strTimes + strNameObj) + "][" + hy.DemThuMuc(strMain + strNameObj) + "][" + hy.DocFile(strDelay + strNameObj) + "m] " + strNameObj + strPoint + UserSafe(strUserSafe,strNameObj,hy);
                                             // 
                                             blSetSpace = true;
                                        }
                                   }
                              }
                              // 
                              else
                                   // 
                                   strReturn = strReturn + hy.Draw(hy.CountStr(hy.TenThuMuc(strMain)), ' ') + "├─" + numSTT + "[" + hy.DocFile(strTimes + strNameObj) + "][" + hy.DemThuMuc(strMain + strNameObj) + "][" + hy.DocFile(strDelay + strNameObj) + "m] " + strNameObj + strPoint + UserSafe(strUserSafe,strNameObj,hy);
                         }
                         // 
                         strNameObj = null;
                    }
                    // strReturn = strReturn  + hy.Draw(hy.CountStr(hy.TenThuMuc(strMain)),' ') + "└─────────────.";
                    strReturn = strReturn.Replace("...", " ? ") + hy.Draw(hy.CountStr(hy.TenThuMuc(strMain)), '─') + "┘.";
               }
               return strReturn;
          }
          // 
          public static string HoatDongMax(string strR, string strCount, string strLink, int num, string[] arrValue, HelpYou hy)
          {
               // 
               hy.SetCount();
               // 
               arrValue = new string[hy.DemThuMuc(strLink)];
               // 
               if (Directory.Exists(strLink) == true)
               {
                    // 
                    string[] gD = Directory.GetDirectories(strLink);
                    foreach (string d in gD)
                    {
                         if (hy.DocFileReturnNum(strCount + hy.TenThuMuc(d)) > num)
                              // 
                              num = hy.DocFileReturnNum(strCount + hy.TenThuMuc(d));
                    }
                    // 
                    string[] gD1 = Directory.GetDirectories(strLink);
                    foreach (string d in gD1)
                    {
                         if (hy.DocFileReturnNum(strCount + hy.TenThuMuc(d)) == num)
                         {
                              // 
                              arrValue[hy.GetCount()] = hy.TenThuMuc(d);
                              // 
                              hy.Count();
                         }
                    }
               }
               // 
               return hy.DocMang(arrValue);
          }
          // 
          public static void Table(string strT, string strC, HelpYou hy)
          {
               //TITLE
               Console.WriteLine("\n┌{0}┐", hy.Draw(hy.CountStr(strT) - 1, '─'));
               // title
               Console.WriteLine("│{0}│", strT);
               // 
               Console.WriteLine("├{0}┤", hy.Draw(hy.CountStr(strT) - 1, '─'));

               // CONTENT
               // Console.WriteLine("│{0}│",strC);
               //     
               hy.XepChuoiTratTuCuaTable(strC, '│', hy.CountStr(strT));
               // 
               Console.Write("└{0}┘", hy.Draw(hy.CountStr(strT) - 1, '─'));
          }
     }
     // 
     public class myReverserClass : IComparer
     {
          // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
          int IComparer.Compare(Object x, Object y)
          {
               return ((new CaseInsensitiveComparer()).Compare(y, x));
          }
     }
     // 
     class HelpYou
     {
          private static int _numCount;
          private int _num;
          private int _num1;
          private string _str;
          private string _strUserName;
          private string _strPassword;
          private string _strChar;

          // properties
          public static int NumLineFile
          {
               get
               {
                    return _numCount;
               }
               set
               {
                    _numCount = value;
               }
          }
          public int Num
          {
               get
               {
                    return _num;
               }
               set
               {
                    _num = value;
               }
          }
          public int Num1
          {
               get
               {
                    return _num1;
               }
               set
               {
                    _num1 = value;
               }
          }
          public string Str
          {
               get
               {
                    return _str;
               }
               set
               {
                    _str = value;
               }
          }
          public string StrUserName
          {
               get
               {
                    return _strUserName;
               }
               set
               {
                    _strUserName = value;
               }
          }
          public string StrPassword
          {
               get
               {
                    return _strPassword;
               }
               set
               {
                    _strPassword = value;
               }
          }
          public string StrChar
          {
               get
               {
                    return _strChar;
               }
               set
               {
                    _strChar = value;
               }
          }


          // 
          public void SetCount()
          {
               _numCount = 0;
          }
          public void Count()
          {
               _numCount++;
          }
          public int GetCount()
          {
               return _numCount;
          }
          // tao thu muc
          public void TaoThuMuc(string nameFolder)
          {
               // 1.Khai báo một thể hiện của lớp DirectoryInfo
               DirectoryInfo directory = new DirectoryInfo(nameFolder);
               // Kiểm tra thư mục chưa tồn tại mới sử dụng phương thức tạo
               if (!directory.Exists)
                    // 2.Sử dụng phương thức Create để tạo thư mục.
                    directory.Create();
          }
          public void XoaVaTaoThuMuc(string nameFolder)
          {
               // 
               if(Directory.Exists(nameFolder) == true)
                    // 
                    Directory.Delete(nameFolder,true);
               // 1.Khai báo một thể hiện của lớp DirectoryInfo
               DirectoryInfo directory = new DirectoryInfo(nameFolder);
               // Kiểm tra thư mục chưa tồn tại mới sử dụng phương thức tạo
               if (!directory.Exists)
                    // 2.Sử dụng phương thức Create để tạo thư mục.
                    directory.Create();
          }
          // tao file
          public void TaoFile(string nameFile)
          {
               // neu file chua co
               if (File.Exists(nameFile) == false)
               {
                    // sử dụng hàm tạo của lớp FileStream
                    FileStream fs = new FileStream(nameFile, FileMode.Create);
                    fs.Close();
               }
          }
          // tao file
          public void TaoFileVsSuaLoi(string nameFile, string str)
          {
               // neu file chua co
               if (File.Exists(nameFile) == false)
               {
                    // sử dụng hàm tạo của lớp FileStream
                    FileStream fs = new FileStream(nameFile, FileMode.Create);
                    fs.Close();
                    StreamWriter sWriter = new StreamWriter(nameFile, true);//fs là 1 FileStream 
                    sWriter.Write(str);
                    sWriter.Close();
               }
          }
          // ghi du lieu vao file
          public void GhiFile(string nameFile, string data, bool bl)
          {
               // neu file da co
               if (File.Exists(nameFile) == true)
               {
                    // sử dụng hàm tạo của lớp FileStream
                    StreamWriter sWriter = new StreamWriter(nameFile, bl);//fs là 1 FileStream 
                    sWriter.Write(data);
                    sWriter.Close();
               }
          }
          // ghi du lieu vao file
          public void GhiFileVaDongMoi(string nameFile, string data, bool bl)
          {
               // neu file da co
               if (File.Exists(nameFile) == true)
               {
                    // sử dụng hàm tạo của lớp FileStream
                    StreamWriter sWriter = new StreamWriter(nameFile, bl);//fs là 1 FileStream 
                    sWriter.WriteLine(data);
                    sWriter.Close();
               }
          }

          // ghi du lieu vao file voi 1 noi dung duy nhat (loc cac ky tu giong nhau)
          public void GhiFileDuyNhat(string nameFile, string data, bool bl)
          {
               bool b = true;
               // neu file da co
               if (File.Exists(nameFile) == true)
               {
                    // // sử dụng hàm tạo của lớp FileStream

                    // doc file
                    string[] rF = File.ReadAllLines(nameFile);
                    foreach (string r in rF)
                    {
                         // kiem tra du lieu
                         if (data.Replace(" ", "").ToLower() == r.Replace(" ", "").ToLower())
                              b = false;

                         // Console.WriteLine(r+ " = " + data + " = " +  b);
                    }
                    // Console.ReadKey();
                    if (b == true)
                    {
                         StreamWriter sWriter = new StreamWriter(nameFile, bl);//fs là 1 FileStream 
                         sWriter.Write(data + "\n");
                         sWriter.Close();
                    }
               }
          }
          // ghi du lieu vao file voi 1 noi dung duy nhat (loc cac ky tu giong nhau)
          public string ThongKeDuLieuConLai(string nameFile, string nameFile1)
          {
               _str = "";
               bool b = false;
               // neu file da co
               if (File.Exists(nameFile) == true)
               {
                    // // sử dụng hàm tạo của lớp FileStream

                    // doc file
                    string[] rF = File.ReadAllLines(nameFile);
                    foreach (string r in rF)
                    {
                         b = false;
                         // doc file
                         string[] rF1 = File.ReadAllLines(nameFile1);
                         foreach (string r1 in rF1)
                         {
                              // kiem tra du lieu
                              if (r1.Replace(" ", "").ToLower() == r.Replace(" ", "").ToLower())
                                   b = true;


                         }
                         // lay ra cong ban chua lam
                         if (b == false)
                         {
                              _str = _str + r;
                         }

                    }


                    // Console.ReadKey();
               }
               return _str;
          }
          // ghi du lieu vao file voi 1 noi dung duy nhat (tra ve cac ky tu giong nhau)
          public string ThongKeDuLieuGiongNhau(string nameFile, string nameFile1)
          {
               _str = "";
               bool b = false;
               // neu file da co
               if (File.Exists(nameFile) == true)
               {
                    // // sử dụng hàm tạo của lớp FileStream

                    // doc file
                    string[] rF = File.ReadAllLines(nameFile);
                    foreach (string r in rF)
                    {
                         b = false;
                         // doc file
                         string[] rF1 = File.ReadAllLines(nameFile1);
                         foreach (string r1 in rF1)
                         {
                              // kiem tra du lieu
                              if (r1.Replace(" ", "").ToLower() == r.Replace(" ", "").ToLower())
                                   b = true;


                         }
                         // lay ra cong ban chua lam
                         if (b == true)
                         {
                              _str = _str + r;
                         }

                    }


                    // Console.ReadKey();
               }
               return _str;
          }
          // doc du lieu trong file
          public string DocFile(string nameFile)
          {
               _str = "...";
               // neu file co ton tai
               if (File.Exists(nameFile) == true)
                    _str = File.ReadAllText(nameFile);
               return _str;
          }
          // doc du lieu trong file
          public string DocFileReturnOneLine(string nameFile)
          {
               _str = "";
               // neu file co ton tai
               string[] rF = File.ReadAllLines(nameFile);
               foreach (string str in rF)
               {
                    _str = _str + str;
               }
               return _str;
          }
          // doc du lieu trong file
          public string DocFileReturnOneLineWithNumShow(string nameFile, int num1, int num2)
          {
               _str = "";
               _strChar = "";
               _numCount = 0;
               // neu file co ton tai
               string[] rF = File.ReadAllLines(nameFile);
               foreach (string str in rF)
               {
                    _str = _str + str;
               }
               // 
               foreach (char ch in _str)
               {
                    _numCount++;
                    // 
                    if (_numCount >= num1 && _numCount <= num2)
                         _strChar = _strChar + ch;
               }
               return _strChar;
          }
          // doc du lieu trong file
          public int DocFileReturnNum(string nameFile)
          {
               // 
               _num = 0;
               // neu file co ton tai
               if (File.Exists(nameFile) == true)
                    // 
                    _num = int.Parse(File.ReadAllText(nameFile));
               // 
               return _num;
          }
          // doc du lieu trong file va tra ve vi tri can tim
          public string DocFileVsFind(string nameFile, string strFind)
          {
               _str = "...";
               // neu file co ton tai
               string[] lines = File.ReadAllLines(nameFile);
               foreach (string s in lines)
               {
                    if (s.Contains(strFind))
                         _str = _str + "> " + s + " <\n";
                    else
                         _str = _str + s + "\n";
               }
               return _str;
          }
          // doc du lieu trong file va tra ve gia tri can tim
          public string DocFileVsReturnValueFind(string nameFile, string strFind)
          {
               _str = "...";
               // neu file co ton tai
               string[] lines = File.ReadAllLines(nameFile);
               foreach (string s in lines)
               {
                    if (strFind.Contains(s))
                         _str = s;
               }
               return _str;
          }
          // doc du lieu trong file va tra ve gia tri can tim
          public bool DocFileRTF(string nameFile, string strFind)
          {
               bool bTF = false;
               // neu file co ton tai
               string[] lines = File.ReadAllLines(nameFile);
               foreach (string s in lines)
               {
                    if (strFind.Contains(s))
                         bTF = true;
               }
               return bTF;
          }
          // doc du lieu trong file
          public string DocFileVsNeuDuLieuKhacRong(string data, string nameFile)
          {
               _str = "...";
               // neu file co ton tai
               if (File.Exists(nameFile) == true && data.Replace(" ", "") != "")
                    _str = File.ReadAllText(nameFile);
               return _str;
          }
          // liet ke file trong thu muc
          public void LietKeFile(string nameFolder)
          {
               if (Directory.Exists(nameFolder) == true)
               {
                    string[] rFD = Directory.GetFiles(nameFolder);
                    foreach (string f in rFD)
                    {
                         Console.WriteLine(f);
                    }
                    Console.ReadKey();
               }
          }
          // liet ke file trong thu muc
          public string LietKeFile(string nameFolder,string str)
          {
               if (Directory.Exists(nameFolder) == true)
               {
                    _str = "...";
                    // 
                    string[] rFD = Directory.GetFiles(nameFolder);
                    foreach (string f in rFD)
                    {
                         _str = _str + f + str;
                    }
               }
               return _str;
          }
           // liet ke file trong thu muc
          public void LietKeThuMuc(string nameFolder)
          {
               if (Directory.Exists(nameFolder) == true)
               {
                    string[] rFD = Directory.GetDirectories(nameFolder);
                    foreach (string d in rFD)
                    {
                         Console.WriteLine(d);
                    }
                    Console.ReadKey();
               }
          }
          // liet ke thu muc va file
          public string KiemTraThuMucVsTen(string nameFolder)
          {
               _str = "...";
               if (Directory.Exists(nameFolder) == true)
                    _str = nameFolder.Substring(nameFolder.LastIndexOf("/") + 1);
               return _str;
          }
          // // dem ngay
          // public string DemNgay(string date1, string date2)
          // {
          //      DateTime ngaymuon = Convert.ToDateTime(date1);
          //      DateTime ngaytra = Convert.ToDateTime(date2);
          //      TimeSpan Time = ngaytra - ngaymuon;
          //      int TongSoNgay = Time.Days;
          //      return TongSoNgay + "";
          // }
          // dem ngay
          public int DemNgay(string date1, string date2)
          {
               DateTime ngaymuon = Convert.ToDateTime(date1);
               DateTime ngaytra = Convert.ToDateTime(date2);
               TimeSpan Time = ngaytra - ngaymuon;
               int TongSoNgay = Time.Days;
               return TongSoNgay;
          }
          // dem thang
          public string DemThang(DateTime date1, DateTime date2)
          {
               DateTime ngaymuon = Convert.ToDateTime(date1);
               DateTime ngaytra = Convert.ToDateTime(date2);
               TimeSpan Time = ngaytra - ngaymuon;
               int TongSoNgay = Time.Days;
               return (TongSoNgay / 30) + "";
          }
          // dem so dong trong file
          public int DemSoDongTrongFile(string nameFile)
          {
               _num = 0;
               // 
               if (File.Exists(nameFile) == true)
               {
                    string[] rF = File.ReadAllLines(nameFile);
                    foreach (string line in rF)
                    {
                         _num++;
                    }
               }
               return _num;
          }
          // dem ky tu trong file
          public int DemKyTuTrongFile(string nameFile)
          {
               _num = 0;
               _str = "";
               // 
               if (File.Exists(nameFile) == true)
               {
                    string[] rF = File.ReadAllLines(nameFile);
                    foreach (string line in rF)
                    {
                         _str = _str + line;
                    }
                    // 
                    foreach (char ch in _str)
                    {
                         _num++;
                    }
               }
               return _num;
          }
          // dem ky tu trong file
          public int DemStr(string strSTR)
          {
               _num = 0;
               _str = "";
               // 
               if (strSTR.Replace(" ", "") != "")
               {
                    // 
                    foreach (char ch in strSTR)
                    {
                         _num++;
                    }
               }
               return _num;
          }
          // tra ve du lieu ngau nhien trong file
          public string ReturnRandomLineInFile(string nameFile)
          {
               _str = "";
               // 
               if (File.Exists(nameFile) == true)
               {
                    _num = 0;
                    _num1 = 0;
                    Random rd = new Random();
                    // dem so dong trong file
                    string[] rF = File.ReadAllLines(nameFile);
                    foreach (string s in rF)
                    {
                         _num++;
                    }
                    _num1 = rd.Next(0, _num);
                    _num = 0;
                    // lay du lieu  string[] rF = File.ReadAllLines(nameFile);
                    foreach (string s in rF)
                    {
                         if (_num1 == _num)
                              _str = s;
                         _num++;
                    }
               }
               return _str;
          }
          // hien thi ten thu muc
          public string TenThuMuc(string nameFolder)
          {
               if (Directory.Exists(nameFolder) == true)
               {
                    // 2.Khai báo một thể hiện của lớp DirectoryInfo
                    DirectoryInfo dr = new DirectoryInfo(nameFolder);
                    nameFolder = dr.Name;
               }
               return nameFolder;
          }
          // hien thi ten thu muc
          public string TenThuMuc1(string nameFolder)
          {
               if (Directory.Exists(nameFolder) == true)
               {
                    // 2.Khai báo một thể hiện của lớp DirectoryInfo
                    DirectoryInfo dr = new DirectoryInfo(nameFolder);
                    nameFolder = dr.FullName + "";
               }
               return nameFolder;
          }
          // ve khoang cach
          public void VeKhoangTrong(int num)
          {
               for (int i = 0; i < num / 3; i++)
               {
                    Console.Write(" ");
               }
          }
          // dem so luong thu muc
          public int DemThuMuc(string nameFolder)
          {
               _num = 0;
               if (Directory.Exists(nameFolder) == true)
               {
                    string[] getD = Directory.GetDirectories(nameFolder);
                    foreach (string d in getD)
                    {
                         _num++;
                    }
               }
               return _num;
          }
          // dem so luong thu muc
          public int DemFileTrongThuMuc(string nameFolder)
          {
               _num = 0;
               if (Directory.Exists(nameFolder) == true)
               {
                    string[] getD = Directory.GetFiles(nameFolder);
                    foreach (string d in getD)
                    {
                         _num++;
                    }
               }
               return _num;
          }
          // mo duong dan
          public void MoDuongDan(string duongDan)
          {
               Process myProcess = new Process();
               try
               {
                    // true is the default, but it is important not to set it to false
                    myProcess.StartInfo.UseShellExecute = true;
                    myProcess.StartInfo.FileName = duongDan;
                    myProcess.Start();
               }
               catch (Exception e)
               {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
               }
          }
          // ten file
          public string TenFile(string strNameFile)
          {
               // 
               FileInfo file = new FileInfo(strNameFile);
               // Console.WriteLine(file.Name);
               return file.Name;
          }
          // tra va bien
          public string Value()
          {
               _str = Console.ReadLine();
               return _str;
          }
          // tra va bien
          public string Value(string strName)
          {
               // 
               Console.Write(strName);
               _str = Console.ReadLine();
               return _str;
          }
          // tra va bien
          public int ValueInt(string strName)
          {
               // 
               Console.Write(strName);
               _num = int.Parse(Console.ReadLine());
               return _num;
          }
          // tra va bien
          public string ValueDate(string strName,DateTime date)
          {
               // Sử dụng TryParseExact để đảm bảo định dạng chính xác
               while (!DateTime.TryParseExact(strName, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out date))
               {
                    Console.Write("dd/MM/yyyy >");
                    strName = Console.ReadLine();
               }
               // 
               return date.ToString("dd/MM/yyyy");
          }
          // dem so ky tu trong chuoi
          public int CountStr(string strC)
          {
               _numCount = 0;
               foreach (char ch in strC)
               {
                    _numCount++;
               }
               return _numCount;
          }
          //ve cai qq gi v
          public string Draw(int num, char ch)
          {
               _str = "";
               _str = _str + ch;
               // 
               if (num != 0)
               {
                    for (int i = 0; i < num; i++)
                    {
                         _str = _str + ch;
                    }
               }
               return _str;
          }
          //ve o vi tri chi dinh
          public string DrawN(int num, int num1, char ch, char ch1)
          {
               _str = "";
               _str = _str + ch;
               // 
               if (num != 0)
               {
                    for (int i = 0; i < num; i++)
                    {
                         // 
                         if (i == num1)
                              _str = _str + ch1;
                         else
                              _str = _str + ch;
                    }
               }
               return _str;
          }
          // xep chuoi thanh nhung ky tu thang hang dung de tu dong xuong dong trong table
          public void XepChuoiTratTuCuaTable(string str, char chDraw, int num)
          {
               _numCount = 0;
               Console.Write(chDraw);
               // 
               foreach (char ch in str)
               {
                    // 
                    _numCount++;
                    // 
                    Console.Write(ch);
                    // 
                    if (_numCount == num)
                    {
                         Console.Write(chDraw + "\n" + chDraw);
                         // 
                         _numCount = 0;
                    }
                    if (ch == '.')
                    {
                         // Console.Write(ch);
                         for (int i = 0; i < num - _numCount; i++)
                         {
                              Console.Write(" ");
                         }
                         // 
                         Console.Write(chDraw + "\n" + chDraw);

                         // 
                         _numCount = 0;
                    }
               }
               // 
               if (num != 0)
               {
                    // 
                    for (int i = 0; i < num - _numCount; i++)
                    {
                         Console.Write(" ");
                    }
                    // 
                    Console.WriteLine(chDraw);
               }
          }
          // 
          public bool User(string strF)
          {
               Console.Write("Enter username: ");
               _strUserName = Console.ReadLine();
               _strPassword = "";
               Console.Write("Enter password: ");
               ConsoleKeyInfo keyInfo;

               do
               {
                    keyInfo = Console.ReadKey(true);
                    // Skip if Backspace or Enter is Pressed
                    if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                    {
                         _strPassword += keyInfo.KeyChar;
                         Console.Write("*");
                    }
                    else
                    {
                         if (keyInfo.Key == ConsoleKey.Backspace && _strPassword.Length > 0)
                         {
                              // Remove last charcter if Backspace is Pressed
                              _strPassword = _strPassword.Substring(0, (_strPassword.Length - 1));
                              Console.Write("\b \b");
                         }
                    }
               }
               // Stops Getting Password Once Enter is Pressed
               while (keyInfo.Key != ConsoleKey.Enter);
               Console.WriteLine();
               Console.WriteLine("---------------------------");
               Console.WriteLine("Welcome " + _strUserName + ",");
               // Console.WriteLine("Your Password is : " + _strPassword);
               if (File.Exists(strF + _strUserName) == true)
                    _str = File.ReadAllText(strF + _strUserName);
               // 
               if (_str == _strPassword)
                    return true;
               return false;
          }
          // 
          public bool ValueYesNo(string str){
              // 
              ConsoleKeyInfo keyInfo;
              // 
              do
              {
                  // 
                  Console.Write("\n{0}[Y/N] ",str);
                  // 
                  keyInfo = Console.ReadKey(true);
              }
              // Stops Getting Password Once Enter is Pressed
              while (keyInfo.Key != ConsoleKey.Y && keyInfo.Key != ConsoleKey.N);
              // 
              if(keyInfo.Key == ConsoleKey.Y)
                  // 
                  return true;
              // 
              else
                  // 
                  return false;
          }
          // 
          public void PrintAllDirectory(string dirPath)
          {
               try
               {
                    // Nếu bạn không có quyền truy cập thư mục 'dirPath' 
                    // một ngoại lệ UnauthorizedAccessException sẽ được ném ra.
                    IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);
                    List<string> dirs = new List<string>(enums);
                    foreach (var dir in dirs)
                    {
                         Console.WriteLine(dir);

                         PrintAllDirectory(dir);
                    }
               }
               // Lỗi bảo mật khi truy cập vào thư mục mà bạn không có quyền.
               catch (UnauthorizedAccessException e)
               {
                    Console.WriteLine("Can not access directory: " + dirPath);
                    Console.WriteLine(e.Message);
               }
          }
          // 
          public void PrintAllFile(string pathfile)
          {
               string[] fileList = Directory.GetFiles(pathfile);//lay danh sách file cho vao mảng
               string strFileName = "";
               //duyet mang file trong thư mục
               foreach (string fileName in fileList)
               {
                    strFileName = "";
                    strFileName = Path.GetFileName(fileName).Trim();
                    ProcessFile(fileName, strFileName);

               }

               string[] directorylist = Directory.GetDirectories(pathfile);//lấy danh sách target file cho vào mảng

               //duyệt mảng target
               foreach (string directory in directorylist)
               {
                    PrintAllFile(directory);
               }
          }
          // 
          public void ProcessFile(string path, string strfileName)
          {
               Console.WriteLine("{0}", path);
          }
          //
          public string DocMang(string[] arr)
          {
               // 
               _str = null;
               try
               {
                    // 
                    foreach (string str in arr)
                    {
                         // 
                         _str = _str + str + " ";
                    }
                    // 
                    return _str;
               }
               // 
               catch
               {
                    // 
                    return "Undefined!";
               }
          }
     }
}
