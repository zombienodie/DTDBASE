using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;

//music
//using WMPLib;

namespace TurnTheLight
{
    class Program
    {
        static void Main(string[] args)
        {
            //Music
            string linkMusic = "";
            //TTL
            string sDisk = "";
            int show = 0;
            string link = "";
            int soKetNoi = 0;
            string map = "";
            int soLanDuocThietLap = 0;
            int chonSo = 255;
            int dem = 0;
            int dem1 = 0;
            string wAYWF = null;
            string linkDatabase = "";
            string colorT = "";
            string a = "";
            string b = "";
            string b1 = "";
            int num = 0;
            string linkActive = "";
            int soPT = 0;
            string linkUpload = "";
            double demUpload = 0;
            int times = 0;
            string linkConnect = "";
            string[] arr = { "chaybangmaascii", "thongtin", "restart", "#", "hide", "show", "capnhatfile", "bieudo(chart)", "bigmap", "aday", "error", "startup", "valoi", "calendar", "off", "sukien", "year", "thongbao", "dangkycongviecngaunhien", "luachoncongviecngaunhien", "kenhchat", "danhsach", "...", "...", "xoasukien", "timelines", "percentttl", "music", "capnhatdulieu" };
            //wall data
            string page = "";
            string[] arrTable = { "addtable", };
            //wall data
            //stage
            string[] Stage = { "new_stage", "open_stage", "historical_period", "rule", "namegate" };
            string chosseST = "";
            string linkST = "";
            //stage
            string[] DanhSachViecLamTrongNgay = { "bangmaascii", "menu", "createmanyfile", "createmanyfolder", "...", "database", "thietlap", };
            string[] ThuMucHoTro = { "HSD(Connect)", "TTL(Connect)", "(Music)Connect", "(XeMay)Connect", "...", "XeMay", "...", "picture", "random", "table", "hashtag", "history", "remind", "information", "walldata", "color" };
            //NHAC NHO
            string chosseNN = "";
            string[] NhacNho = { "themnhacnho", "xoanhacnho", "doinoidungnhacnho" };
            //TTL
            //BIEU DO
            string chosseBD = "";
            string linkBD = "";
            //BIEU DO
            //HSD
            int check = 0;
            int demSPCanXoa = 0;
            int numPinMax = 0;
            string newLink = "";
            string chosse = "";
            string linkHSD = "";
            string linkHSD1 = "";
            string tenKhoDangSuDUng = "";
            string[] HSD = { "themsanpham", "hsd", "kiemtrakho", "xoa", "khomoi", "...", "thietlap", "...", "...", "timkiemsanpham", "xoasanpham" };
            //kiem tra co duong dan duoc thiet lap san hay khong
            string SPCanXoa = "";
            //HSD
            //XEMAY
            string linkXM = "";
            string chosseXM = "";
            string[] arrHonda = { "moithaynhot", "kiemtranhot", "themxe", "xoadulieu", "tinhtrang", "thietlap", "exit" };
            //XEMAY
            // 7day
            string sday = "";
            int khoangCachHienThi = 18;
            string linkDate = "";
            // 7day
            //table
            bool bShowTable = false;
            string linkTKB = "";
            string linkTKB1 = "";
            string nameTable = "";
            string nameTable1 = "";
            string linkXuatFile = "";
            string c = "";
            string cc = "";
            int numLineShow1 = 0;
            int numLineShow2 = 0;
            //table
            // UPLOAD FILE
            string linkTTLUploadFile = "";
            int numRead = 0;
            string dataUpload = "";
            string linkFile = "";
            string chosseFileUpload = "";
            string nameFileUpload = "";
            int numSumUL = 0;
            int numLoading = 0;
            string duLieuDaXoa = "";
            // UPLOAD FILE
            //kiem tra ket noi mang cua may tinh
            bool internet = true;
            //lay du lieu o dia can ket noi
            sDisk = ConnectDisk(sDisk);
            // BAO TRI HE THONG
            bool bBTHT = true;
            // TAO FILE CANH BAO
            // Warning();
            //hoi quyen truy cap
            Console.Title = "TTL FREE [VERSION 1.0] " + DateTime.Now.Date;
            HelpTTL ttl = new HelpTTL();
            do
            {
                do
                {
                    // kiem tra ket noi internet
                    internet = IsConnectedToInternet();
                    //lay link ket noi thu muc hsd
                    linkHSD = LinkConnectHSD(linkHSD, sDisk);
                    //duòng d?n k?t n?i thu m?c nh?c
                    linkMusic = LinkConnectMusic(linkMusic, sDisk);
                    //xoa man hinh neu nguoi dung co nhap thong tin vao chuong trinh
                    if (wAYWF != "")
                        Console.Clear();
                    demUpload = 0;
                    Console.BackgroundColor = ConsoleColor.Black;
                   Console.ResetColor();
                    b1 = b;
                    //neu linkupload khac rong
                    //tu cap nhat so lan thiet lap
                    soLanDuocThietLap++;
                    show = 0;
                    //thong tin chuong trinh
                    linkConnect = Information(show, b, dem1, soKetNoi, soLanDuocThietLap);
                    // tai cac ung dung neu nguoi dung co yeu cau trong file va co nhap thong tin vao chuong trinh
                    if (linkUpload != "" && File.Exists(linkUpload) == true && wAYWF != "")
                    {
                        //hien thi tho tin nguoi dung dang upload
                        string[] fileUpload = File.ReadAllLines(linkUpload);
                        foreach (string lines in fileUpload)
                        {
                            demUpload++;
                            if (lines == "information" || lines == "all")
                            {
                               Console.ResetColor();
                                show = 1;
                                ////thong tun chuong trinh
                                // //year
                                // Year(DateTime.Now.Year, b);
                                Console.WriteLine();
                                //hien thi so bieu do dang su dung
                                BieuDoDangSuDung(b);
                                //hien thi tong so trang dang co
                                HienThiTongSoTrangDangSuDung(b);
                                //hien thi tong so bang dang co
                                HienThiTongSoBang(b);
                                //hien thi so bang da pin
                                DemSoBangDaPin(b);
                                //thong tin chuong trinh
                                linkConnect = Information(show, b, dem1, soKetNoi, soLanDuocThietLap);
                                //so lan da hoan thanh cong viec
                                SoLanHoanThanhCongViec(b);
                            }
                            if (lines == "picture" || lines == "all")
                            {
                               Console.ResetColor();
                                //thong bao thong tin chuong trinh
                                TTLHead(b, times);
                            }
                            if (lines == "random" || lines == "all")
                            {
                               Console.ResetColor();
                                //hien thi cong viec ngau nhien
                                CVNgauNhien(b);
                            }
                            // if (lines == "hashtag" || lines == "all")
                            //     //hien thi hashtag
                            //     Hashtag(b, wAYWF);
                            if (lines == "remind" || lines == "all")
                            {
                               Console.ResetColor();
                                //hien thi nhac nho
                                ShowNhacNho(b);
                            }
                            if (lines == "chart" || lines == "all" || lines == "bieudo")
                            {
                               Console.ResetColor();
                                //hien so do
                                ShowBD(b);
                            }
                            if (lines == "color" || lines == "all")
                            {
                               Console.ResetColor();
                                TTLIcon(b);
                            }
                            if (lines == "walldata" || lines == "all" || lines == "wd")
                            {
                                //colorTable
                                colorT = TableColor(b, wAYWF);
                                //hien thi so trang dang co
                                Pages(b, page);
                                //show du lieu kieu buc tuong
                                page = WallData(b, wAYWF, colorT, page);
                            }
                            // stage
                            if (lines == "stage" || lines == "all")
                            {
                               Console.ResetColor();
                                CanhBaoGiaiDoan(b);
                            }
                        }
                    }
                    try
                    {
                        //nguoi dung nhap vao
                       Console.ResetColor();
                        Console.Write("\n«TTL FREE» ");
                        // show file upload
                        ShowFileUpload(b);
                        // hien thi dong trong file mot cach ngau nhien
                        ShowLineFileRandom(b);
                        // hien thi ket noi internet
                        ShowInternet(internet);
                        wAYWF = Console.ReadLine();
                        //l?ch s?
                        HistorySave(wAYWF, b);
                        if (wAYWF != "")
                        {
                            dem1++;
                        }
                        //check for table
                        CheckTable(b, wAYWF, page);
                        // call
                        CallSomething(wAYWF, b);
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ResetColor();
                        wAYWF = wAYWF.ToLower().Replace(" ", "");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ResetColor();
                        //upload program
                        linkUpload = Upload(b, wAYWF);
                        //database
                        if (wAYWF == DanhSachViecLamTrongNgay[5])
                        {
                            linkDatabase = database();
                        }
                        if (wAYWF == DanhSachViecLamTrongNgay[4])
                        {

                        }
                        //tao nhieu file
                        if (wAYWF == DanhSachViecLamTrongNgay[2])
                        {
                            CreateManyFile();
                        }
                        //tao nhieu folder
                        if (wAYWF == DanhSachViecLamTrongNgay[3])
                        {
                            CreateManyFolder();
                        }
                        //MENU
                        if (wAYWF == DanhSachViecLamTrongNgay[1])
                        {
                            DSDieuMoi(linkDatabase, b);
                        }
                        //setting
                        if (wAYWF == "connect")
                        {
                            //lay du lieu o dia can ket noi
                            sDisk = ConnectDisk(sDisk);
                            //kiem tra thiet lap
                            b = Connect(b);
                            a = b;
                            if (b == "")
                            {
                                Console.Write("New link: ");
                                b = Console.ReadLine();
                                //neu thiet lap moi != rong
                                if (b != "")
                                {
                                    //ghi du lieu thiet lap vao file ttl
                                    TextWriter fileConnect = new StreamWriter(sDisk + "/TTL/TTL/TTL.txt", false);
                                    fileConnect.WriteLine(b);
                                    fileConnect.Close();
                                }
                            }
                            b = b + "/TTL/";
                            DirectoryInfo newFolder = new DirectoryInfo(b);
                            newFolder.Create();
                            b = Connect(b, num, b1);
                            soLanDuocThietLap = 0;
                        }
                        // dung de bao tri he thong
                        if (bBTHT == true)
                        {
                            b = wAYWF + "/TTL/";
                            bBTHT = false;
                        }
                        //bang ma ascii
                        if (wAYWF == arr[0])
                        {
                            BangMaAscii(chonSo);
                            Console.ReadKey();
                        }
                        //hien thi thong tin chuong trinh
                        if (wAYWF == arr[1])
                        {
                            soKetNoi = ThongTin(b, sDisk, arr, arrTable, DanhSachViecLamTrongNgay, b, linkConnect, ThuMucHoTro);
                        }
                        //Connect
                        if (wAYWF == arr[3])
                        {
                            try
                            {
                                b = Connect(b, num, b1);
                            }
                            catch
                            {

                            }
                        }
                        ////hide system
                        if (wAYWF == arr[4])
                        {
                            HideSystem(a);
                        }
                        //show system
                        if (wAYWF == arr[5])
                        {
                            ShowSystem(a);
                        }
                        //cap nhat file
                        if (wAYWF == arr[6])
                        {
                            linkTTLUploadFile = "";
                            linkTTLUploadFile = b + "UploadFiles";
                            // cap nhat du lieu
                            dataUpload = "";
                            numSumUL = 0;
                            numLoading = 0;
                            numRead = 0;
                            // hien thi du lieu da xoa
                            Console.WriteLine("\n-DU LIEU DA XOA-");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(duLieuDaXoa);
                           Console.ResetColor();
                            Console.WriteLine("1[UPLOAD ALL FILE]\n2[UPLOAD 1 FILE]");
                            chosseFileUpload = Console.ReadLine();
                            //upload 1 file
                            if (chosseFileUpload == "2")
                            {
                                Console.Write("NAME FILE UPLOAD> ");
                                nameFileUpload = Console.ReadLine();
                                if (File.Exists(linkTTLUploadFile + "/" + nameFileUpload) == true)
                                {
                                    // hiển thị thông tin file upload
                                    Console.WriteLine(linkTTLUploadFile + "/" + nameFileUpload);
                                    // đọc dữ liệu trong file
                                    string[] fileRead = File.ReadAllLines(linkTTLUploadFile + "/" + nameFileUpload);
                                    foreach (string rF in fileRead)
                                    {
                                        dataUpload = rF;
                                        numRead++;
                                        if (numRead == 1)
                                        {
                                            // ket noi vs file
                                            if (File.Exists(dataUpload) == true)
                                            {
                                                // xóa dữ liệu trong file
                                                StreamWriter fileU = new StreamWriter(dataUpload);
                                                fileU.Close();
                                                linkFile = dataUpload;
                                            }
                                            //xoa file neu duong dan khong ton tai
                                            if (File.Exists(dataUpload) == false)
                                            {
                                                File.Delete(linkTTLUploadFile + "/" + nameFileUpload);
                                            }
                                        }
                                        if (numRead == 2)
                                        {
                                            // neu du lieu upload la 1 thu muc
                                            if (Directory.Exists(dataUpload) == true)
                                            {
                                                numSumUL = GetSumLoading(dataUpload, numSumUL);
                                                // cập nhật dữ liệu mới vào file
                                                TextWriter ttlu = new StreamWriter(linkFile, true);
                                                string[] dU = Directory.GetFiles(dataUpload);
                                                foreach (string lineD in dU)
                                                {
                                                    numLoading++;
                                                    ttlu.WriteLine(lineD);
                                                    // loading
                                                    Loading(numLoading, numSumUL);
                                                }
                                                string[] fU = Directory.GetDirectories(dataUpload);
                                                foreach (string lineD in fU)
                                                {
                                                    numLoading++;
                                                    ttlu.WriteLine(lineD + " - " + Directory.GetCreationTime(lineD));
                                                    // loading
                                                    Loading(numLoading, numSumUL);
                                                }
                                                ttlu.Close();
                                            }
                                            // neu du lieu upload la 1 file
                                            if (File.Exists(dataUpload) == true)
                                            {
                                                //get num sum loading
                                                numSumUL = GetSumLoading(dataUpload, numSumUL);
                                                // cập nhật dữ liệu mới vào file
                                                TextWriter ttlu = new StreamWriter(linkFile, true);
                                                string[] fU = File.ReadAllLines(dataUpload);
                                                foreach (string lineD in fU)
                                                {
                                                    numLoading++;
                                                    ttlu.WriteLine(lineD);
                                                    // loading
                                                    Loading(numLoading, numSumUL);
                                                }
                                                ttlu.Close();
                                            }
                                            //xoa file neu duong dan khong ton tai
                                            if (Directory.Exists(dataUpload) == false && File.Exists(dataUpload) == false)
                                            {
                                                File.Delete(linkTTLUploadFile + "/" + nameFileUpload);
                                                duLieuDaXoa = duLieuDaXoa + linkTTLUploadFile + "/" + nameFileUpload + " !\n";
                                            }

                                        }
                                    }
                                }
                            }
                            // upload tat ca cac file
                            if (chosseFileUpload == "1")
                            {
                                // hiển thị các file trong đường dẫn
                                string[] files = Directory.GetFiles(linkTTLUploadFile);
                                foreach (string file in files)
                                {
                                    numRead = 0;
                                    Console.WriteLine(file);
                                    // đọc dữ liệu trong file
                                    string[] fileRead = File.ReadAllLines(file);
                                    foreach (string rF in fileRead)
                                    {
                                        dataUpload = rF;
                                        numRead++;
                                        if (numRead == 1)
                                        {
                                            // ket noi vs file
                                            if (File.Exists(dataUpload) == true)
                                            {
                                                // xóa dữ liệu trong file
                                                StreamWriter fileU = new StreamWriter(dataUpload);
                                                fileU.Close();
                                                linkFile = dataUpload;
                                            }
                                            //xoa file neu duong dan khong ton tai
                                            if (File.Exists(dataUpload) == false)
                                            {
                                                File.Delete(file);
                                            }
                                        }
                                        if (numRead == 2)
                                        {
                                            // neu du lieu upload la mot thu muc
                                            if (Directory.Exists(dataUpload) == true)
                                            {
                                                //get num sum loading
                                                numSumUL = GetSumLoading(dataUpload, numSumUL);
                                                // cập nhật dữ liệu mới vào file
                                                TextWriter ttlu = new StreamWriter(linkFile, true);
                                                string[] dU = Directory.GetFiles(dataUpload);
                                                foreach (string lineD in dU)
                                                {
                                                    numLoading++;
                                                    ttlu.WriteLine(lineD);
                                                    // loading
                                                    Loading(numLoading, numSumUL);
                                                }
                                                string[] fU = Directory.GetDirectories(dataUpload);
                                                foreach (string lineD in fU)
                                                {
                                                    numLoading++;
                                                    ttlu.WriteLine(lineD + " - " + Directory.GetCreationTime(lineD));
                                                    // loading
                                                    Loading(numLoading, numSumUL);
                                                }
                                                ttlu.Close();
                                            }
                                            // neu du lieu upload la 1 file
                                            if (File.Exists(dataUpload) == true)
                                            {
                                                //get num sum loading
                                                numSumUL = GetSumLoading(dataUpload, numSumUL);
                                                // cập nhật dữ liệu mới vào file
                                                TextWriter ttlu = new StreamWriter(linkFile, true);
                                                string[] fU = File.ReadAllLines(dataUpload);
                                                foreach (string lineD in fU)
                                                {
                                                    numLoading++;
                                                    ttlu.WriteLine(lineD);
                                                    // loading
                                                    Loading(numLoading, numSumUL);
                                                }
                                                ttlu.Close();
                                            }
                                            //xoa file neu duong dan khong ton tai
                                            if (Directory.Exists(dataUpload) == false && File.Exists(dataUpload) == false)
                                            {
                                                File.Delete(file);
                                                duLieuDaXoa = duLieuDaXoa + file + " !\n";
                                            }
                                        }
                                    }
                                    Console.WriteLine();
                                }
                            }
                            // :__
                            if (chosseFileUpload == "1" || chosseFileUpload == "2")
                                Console.ReadKey();
                        }
                        //
                        if (wAYWF == arr[7])
                        {

                        }
                        //big map
                        if (wAYWF == arr[8])
                        {
                            do
                            {
                                //xoa man hinh
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("CHAO MUNG BAN DEN VOI BIG MAP :D");
                                Console.Write("HAY GHI MUC TIEU CUA BAN: ");
                                map = Console.ReadLine();
                                if (map != "")
                                {
                                    Console.Write("NHAP SO LAN THIET LAP DE TIEN TOI MUC TIEU: ");
                                    int.TryParse(Console.ReadLine(), out soPT);
                                    string[] danhSach = new string[soPT];
                                    nhapMang(danhSach, map);
                                    xuatMang(danhSach, map, b, page);
                                }
                            } while (map != "");
                        }
                        //Aday aday
                        if (wAYWF == arr[9])
                        {
                            linkActive = Aday(linkActive, b);
                        }
                        // Error
                        if (wAYWF == arr[10])
                            SoanNoiDungCanhBao(b);
                        // mo duong dan bang file
                        if(wAYWF == arr[11])
                            Starup(b + "starup.txt");
                        //va loi~
                        if (wAYWF == arr[12])
                        {
                            VaLoi(b);
                        }
                        //lên l?ch
                        if (wAYWF == arr[13])
                        {
                            CalendarUp(b, page);
                        }
                        //s? ki?n
                        if (wAYWF == arr[15])
                        {
                            Event(b, page);
                        }
                        //year
                        if (wAYWF == arr[16])
                        {
                            Year(DateTime.Now.Hour, b);
                        }
                        //thong bao
                        if (wAYWF == arr[17])
                        {
                            ThongBaoTTL(b, ttl);
                        }
                        //dang ky cong viec ngau nhien
                        if (wAYWF == arr[18])
                        {
                            NgauNhien(b);
                        }
                        //lua chon cong viec ngau nhien
                        if (wAYWF == arr[19])
                        {
                            RandomSelection(b);
                        }
                        //kênh chat
                        if (wAYWF == arr[20])
                        {
                            ChatChannel(b);
                        }
                        //danh sách vi?c c?n làm trong m?t ngày
                        if (wAYWF == arr[21])
                        {
                            DanhSachViecTrongMotNgay(b);
                        }
                        //
                        if (wAYWF == arr[22])
                        {

                        }
                        //
                        if (wAYWF == arr[23])
                        {

                        }
                        //xóa s? ki?n
                        if (wAYWF == arr[24])
                        {
                            DeleteEvent(b);
                        }
                        //dong thoi gian
                        if (wAYWF == arr[25])
                        {
                            TimeLines(b);
                        }
                        //percent
                        if (wAYWF == arr[26])
                        {
                            PercentTTL(b);
                        }
                        // //music
                        // if(wAYWF == arr[27])
                        // {
                        //     PlayMusic(linkMusic);
                        // }
                        // cập nhật file
                        if (wAYWF == arr[28])
                        {
                            UploadFiles(b);
                        }
                        ///////////////wall data\\\\\\\\\\\\\\\\\\\\\///////////////
                        // /t?o b?ng 5184
                        CreateTable(b, page, wAYWF);
                        //xóa b?ng
                        DeleteTable(b, page, wAYWF);
                        //?ánh d?u b?ng
                        PinTable(b, page, wAYWF);
                        //xóa dánh d?u b?ng
                        DeletePinTable(b, page, wAYWF);
                        //??i tên
                        ChangeName(b, page, wAYWF);
                        // Hide table ẩn bảng
                        HideTable(b, page, wAYWF);
                        // hien thi thong tin bang
                        ShowTable(b, page, wAYWF);
                        //////////page\\\\\\\\\\\\
                        //chon trang
                        Page(b, wAYWF);
                        //them trang moi
                        NewPage(b, wAYWF);
                        //xoa trang                      
                        DeletePage(b, wAYWF);
                        //canh le cho bang
                        LineTable(b, wAYWF);
                        //////////////password////////////5230
                        AddPassword(b, wAYWF, page);
                        //thêm b?ng
                        if (wAYWF == arrTable[0])
                        {
                            AddTable(b, page);
                        }
                        //////////////////////////////////////////BANG NHIEU C?T///////////////////////////////
                        if (wAYWF == "table")
                        {
                            linkTKB = b + "/BC/";
                            linkTKB1 = linkTKB;
                            // tao thu muc
                            ttl.TaoThuMuc(linkTKB);
                            //xoa man hinh
                            Console.Clear();
                            do{
                                // hien thi ten thu muc
                                string[] getD = Directory.GetDirectories(linkTKB);
                                foreach(string d in getD){
                                    if(Directory.Exists(d + "/Date") == true){
                                        try{
                                              // lay thoi gian truy cap thu muc
                                            var datTB = new DateTime(ttl.LayDuLieuTrongFile(d + "/Date/year.txt"),ttl.LayDuLieuTrongFile(d + "/Date/month.txt"),ttl.LayDuLieuTrongFile(d + "/Date/day.txt"));
                                            if(ttl.TinhNgay(datTB.Day,datTB.Month,datTB.Year,DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year) < 30)
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            else if(ttl.TinhNgay(datTB.Day,datTB.Month,datTB.Year,DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year) < 365)
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                            else
                                                Console.ForegroundColor = ConsoleColor.Red;
                                        }
                                        catch{
                                            // xoa thu muc loi~
                                            Directory.Delete(d + "/Date",true);
                                        }
                                       
                                    }
                                    else
                                        // Console.ResetColor();;
                                       Console.ResetColor();
                                    Console.Write(d.Substring(d.LastIndexOf("/")+1) + "  ");
                                }
                                do
                                {
                                    numLineShow1 = 0;
                                    numLineShow2 = 0;
                                    try
                                    {
                                        // kiem tra tinh xac thuc cua thu muc
                                        if (Directory.Exists(linkTKB + nameTable1 + "/SetLineShow") == true)
                                        {
                                            string[] rF1 = File.ReadAllLines(linkTKB + nameTable1 + "/SetLineShow/setline1");
                                            foreach (string line1 in rF1)
                                            {
                                                numLineShow1 = int.Parse(line1);
                                            }
                                            string[] rF2 = File.ReadAllLines(linkTKB + nameTable1 + "/SetLineShow/setline2");
                                            foreach (string line2 in rF2)
                                            {
                                                numLineShow2 = int.Parse(line2);
                                            }
                                            if (c != "")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("*CHE DO HIEN THI HAN CHE (slst) line {0} > {1}", numLineShow1, numLineShow2);
                                               Console.ResetColor(); // lay cac file trong bang
                                            }
                                        }
                                        try{
                                            Console.Write("[{0}]-Line:{1},Column:{2}_ ",linkTKB + nameTable1, ttl.DemFileTrongThuMuc(linkTKB + nameTable1), ttl.DemSoDongTrongFile(linkTKB + nameTable1 + "/Name/name.txt"));
                                        }catch{
                                            Console.Write(DateTime.Now + " ");
                                        }
                                        
                                        c = Console.ReadLine();
                                        // call
                                        CallSomething(c, b);
                                        cc = c;
                                        c = c.ToLower().Replace(" ", "");
                                        //kênh chat
                                        if (c == "kenhchat")
                                        {
                                            ChatChannel(b);
                                        }
                                        //them dong moi
                                        if (c == "newline" || c == "nl")
                                            NewLine(linkTKB1);
                                        //mo bang
                                        nameTable = OpenTable(c, linkTKB, b);
                                        //ghi ten bang
                                        if (nameTable != "")
                                            nameTable1 = nameTable;
                                        // xuat du lieu table ra file
                                        if (c == "getfile")
                                        {
                                            Console.Write("link>");
                                            linkXuatFile = Console.ReadLine();
                                            // neu file chua ton tai
                                            if (File.Exists(linkXuatFile) == false)
                                                // tao file
                                                ttl.TaoFile(linkXuatFile);
                                        }
                                        // HTML for table
                                        if (c == "html")
                                            HTMLForTable(c, linkTKB, nameTable1, ttl.DemFileTrongThuMuc(linkTKB + nameTable1) - 1);
                                        // RAINBOW thay doi mau sac cho tung chu~
                                        Rainbow(c, linkTKB, b, nameTable1);
                                        //them bang moi
                                        NewTable(c, linkTKB, b);
                                        // them dong moi vs so luong dong
                                        NewLines(c, linkTKB1);
                                        //them cot
                                        NewColumn(c, linkTKB1);
                                        //xoa dong nhung van giu lai khoang cach dong
                                        DeleteLineTables(c, linkTKB, nameTable1);
                                        //xoa dong va khoang trong cua dong
                                        KillLine(c, linkTKB, nameTable1, ttl.DemFileTrongThuMuc(linkTKB + nameTable1) - 1, b);
                                        //change space table
                                        ChangeSpaceTable(c, linkTKB, nameTable1);
                                        //ghi de dong
                                        OverrideLine(c, linkTKB, nameTable1);
                                        //xoa bang
                                        DeleteTables(c, linkTKB);
                                        //them mau cho bang
                                        ColorTables(c, linkTKB, nameTable1);
                                        //them mau cho chu
                                        ColorTablesWord(c, linkTKB, nameTable1);
                                        //chong ghi de cua dong
                                        ProtectOverRideLine(c, linkTKB, nameTable1);
                                        //xoa chong ghi de cho dong
                                        DeleteProtectOverRideLine(c, linkTKB, nameTable1);
                                        //xoa cot
                                        DeleteColumnTable(c, linkTKB, nameTable1, b);
                                        //chen dong
                                        InsertLine(c, linkTKB, nameTable1);
                                        //hien thi thong tin bang
                                        ShowColumn(c, linkTKB, nameTable1);
                                        //hien thi thong tin bang theo dong
                                        ShowColumnLine(c, linkTKB, nameTable1);
                                        //chen bang
                                        InsertTable(c, linkTKB, nameTable1);
                                        //tinh tong column
                                        GetSumColumn(c, linkTKB, nameTable1);
                                        //tinh tong column theo dong
                                        GetSumColumnWithLine(c, linkTKB, nameTable1);
                                        //tinh tong line
                                        GetSumLine(c, linkTKB, nameTable1);
                                        //thay doi du lieu trong cot co chi dinh dong nhat dinh
                                        ChangeInformationInColumn(c, linkTKB, nameTable1, numLineShow1, numLineShow2, b);
                                        //bao ve du lieu cho cot
                                        ProtectOverRideColumn(c, linkTKB, nameTable1);
                                        //xoa bao ve cho cot
                                        DeleteProtectOverRideColumn(c, linkTKB, nameTable1);
                                        //pin nhung dong dac biet
                                        PinTables(c, linkTKB, nameTable1);
                                        //xoa du lieu trong file pin
                                        DeletePinTables(c, linkTKB, nameTable1);
                                        //canh l?i kích thu?c toàn b? b?ng
                                        ChangeAllTable(c, linkTKB, nameTable1);
                                        // thêm 1 nội dung cho nhiều cột
                                        AllColumn(c, linkTKB, nameTable1);
                                        //ghi noi dung cho 1 cot vs tat ca cac dong trong cot
                                        AllLineInColumn(c, linkTKB, nameTable1);
                                        //sua noi dung cho cot vs contains
                                        AllLineInColumnReplace(c, linkTKB, nameTable1);
                                        //ghi noi dung  cho 1 cot vs so dong chi dinh
                                        WriteInColumnWithLine(c, linkTKB, nameTable1);
                                        //thay doi dong
                                        ChangeLines(c, linkTKB, nameTable1);
                                        //hien thi thong tin dong'
                                        ShowLine(c, linkTKB, nameTable1);
                                        //upload du lieu tu file len cot
                                        UploadFileToColumn(c, linkTKB, nameTable1, b);
                                        // ghi du lieu ngay/thang/nam vao cot
                                        WriteInColumnWithDate(c, linkTKB, nameTable1);
                                        // ghi du lieu so tang dan va giam dan vao cot
                                        WriteInColumnWithNum(c, linkTKB, nameTable1);
                                        // viet noi dung cho cot
                                        WriteContent(c, linkTKB, nameTable1);
                                        // thay doi ten cot
                                        ChangeNameTable(c, linkTKB, nameTable1);
                                        // thay doi vi tri dong dua vao cot theo thu giam dan
                                        SXColumnGD(c, linkTKB, nameTable1);
                                        // thay doi vi tri dong dua vao cot theo thu tang dan
                                        SXColumnTD(c, linkTKB, nameTable1);
                                        // delete line with data (xoa du lieu vs dong tuong ung)
                                        DeleteLineWithData(c, linkTKB, nameTable1);
                                        // tao bang moi dua tren du lieu dong trong bang
                                        NewTableWithDataInLine(c, linkTKB, nameTable1, b);
                                        // goi duong dan va them gia tri vao cot
                                        CallAndChangeValueInColumn(c, linkTKB, nameTable1, b);
                                        // thong ke du lieu bang table js
                                        FindValueWithJS(c, linkTKB, nameTable1);
                                        // cai dat so dong se hien thi
                                        if (c == "setlineshowtable" || c == "slst")
                                        {
                                            Console.Write("NUM LINE1> ");
                                            int.TryParse(Console.ReadLine(), out numLineShow1);
                                            Console.Write("NUM LINE2> ");
                                            int.TryParse(Console.ReadLine(), out numLineShow2);
                                            // GHI DU LIEU VAO FILE
                                            SetLineShow(numLineShow1, numLineShow2, linkTKB, nameTable1);
                                        }
                                        //xoa du lieu nhieu dong
                                        // DeleteManyLines(c,linkTKB,nameTable1);
                                        // //xoa hoan toan nhieu dong
                                        // KillManyLines(c,linkTKB,nameTable1);
                                        //chang name table
                                        // if(c == "changenametable")
                                        //     ChangeNameTable(c,linkTKB,nameTable1);
                                        // thay doi noi dung trong bang thanh noi dung khac
                                        if (c == "changecontent")
                                            ChangeContent(c, linkTKB, nameTable1);
                                        // tim file co du lieu can tim va dien du lieu moi vao file o vi tri bat ky(tim du lieu o cot nay de thay doi du lieu o cot khac)
                                        if(c == "changecontentv1")
                                            FindDataAndWriteInColumn(c,linkTKB, nameTable1);
                                        // hoan doi vi tri cot
                                        if (c == "movecolumn")
                                            MoveColumn(c, linkTKB, nameTable1, b);
                                        // copy cot
                                        if (c == "copycolumn")
                                            CopyColumn(c, linkTKB, nameTable1, b);
                                        // copy cot vs the a
                                        if (c == "copycolumnwithtag<a>")
                                            CopyColumnWithTagA(c, linkTKB, nameTable1, b);
                                        // error
                                        if (c == "error")
                                            FixErrorTable(c, linkTKB, nameTable1, b);
                                        // question
                                        if (c == "question")
                                            Question(c, linkTKB, nameTable1, b);
                                        // percent
                                        if (c == "percent")
                                            PercentInTable(c, linkTKB, nameTable1, b);
                                        // percent
                                        if (c == "truefalse")
                                            TrueFalse(c, linkTKB, nameTable1, b);
                                        // dung de ghi thong tin vao 1 file de upload du lieu cho table
                                        if(c == "file.txt")
                                            FileTXT(c, linkTKB);
                                        // ve bieu do thong ke Canvas
                                        if(c == "canvas")
                                            Canvas(c,linkTKB,nameTable1,ttl);
                                        // hien thi bang neu du lieu trung khop vs cac chu sau
                                        // if(c == "showtable" || c.Contains("find") || c.Contains("search") || c.Contains("pin") || c.Contains("menu") || c.Contains("getfile"))
                                        // hien thi du lieu bang neu khac rong~
                                        if(c != "" && c != "exit")
                                            bShowTable = true;
                                        //kiem tra duong dan
                                        if (nameTable != "")
                                            linkTKB1 = linkTKB + nameTable + "/";
                                        // Console.WriteLine(linkTKB1);
                                        // bang dang duoc hien thi
                                        if (bShowTable == true)
                                        {
                                            ////hien thi bang
                                            ShowTableTKB(linkTKB1, c, cc, nameTable1, linkXuatFile);
                                            linkXuatFile = "";
                                            // an bang
                                            bShowTable = false;
                                        }
                                        //neu co ket noi mang
                                        //////////////////////////////////////////BANG NHIEU C?T///////////////////////////////
                                    }
                                    catch (Exception tkb)
                                    {
                                        ttl.HienThiThongBao("TABLE!", tkb.Message, 16, b);
                                    }
                                } while (c != "exit");
                                nameTable1 = "";
                                Console.Write("[BIG DATA TABLE] ");
                                c = Console.ReadLine();
                            }while(c.ToLower().Replace(" ", "") != "exit");
                        }
                        /////////////////////////////stage\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                        if (wAYWF == "stage" && b != "")
                        {
                            linkST = b + "\\Stage";
                            do
                            {
                                //xoa man hinh
                                Console.Clear();
                                for (int i = 0; i < Stage.Length; i++)
                                {
                                    Console.WriteLine("[" + (i + 1) + "]" + Stage[i]);
                                }
                                chosseST = Console.ReadLine();
                                //neu nguoi dung chon mo giai doan moi
                                if (chosseST == Stage[0] || chosseST == "1")
                                    NewStage(linkST);
                                //mo giai doan
                                if (chosseST == Stage[1] || chosseST == "2")
                                    OpenStage(linkST);
                                //them lich su cho giai doan
                                if (chosseST == Stage[2] || chosseST == "3")
                                    HistoryStage(linkST);
                                //them luat le cho giai doan
                                if (chosseST == Stage[3] || chosseST == "4")
                                    RuleStage(linkST);
                                //GHI TEN CONG?
                                if (chosseST == Stage[4] || chosseST == "5")
                                    NameGateStage(linkST);
                            } while (chosseST != "exit");
                        }
                        //////////////////////////////////////HSD//////////////////////////////////////
                        if (wAYWF == "hsd")
                        {
                            linkHSD1 = linkHSD;
                            do
                            {
                                //xoa man hinh
                                Console.Clear();
                                SPCanXoa = linkHSD + "\\Thong Bao\\San Pham Can Xoa.txt";
                                demSPCanXoa = 0;
                                //kiem tra san pham can xoa
                                //tim so file can xoa              
                                if (File.Exists(SPCanXoa) == true)
                                {
                                    string[] nhungSPHetHan = File.ReadAllLines(SPCanXoa);
                                    foreach (string linkDelete in nhungSPHetHan)
                                    {
                                        demSPCanXoa++;
                                    }
                                }
                               Console.ResetColor();
                                try
                                {
                                    //thong ke so so san pham hien dang co
                                    tenKhoDangSuDUng = SoSanPhamHienDangCo(linkHSD);
                                    ////hien thong tin san pham
                                    ThongTinSanPham(linkHSD, b);
                                   Console.ResetColor();
                                    //xuat mang
                                    XuatMang(HSD, demSPCanXoa, numPinMax, linkHSD);
                                    Console.Write("HSD>");
                                    //chon chuc nang
                                    chosse = Console.ReadLine();
                                    chosse = chosse.ToLower();
                                    chosse = chosse.Replace(" ", "");
                                    //cai dat percent sp
                                    PercentSP(linkHSD, chosse);
                                    //them san pham moi
                                    if (chosse == HSD[0] || chosse == "1")
                                    {
                                        ThemSanPham(linkHSD);
                                        check = 1;
                                    }
                                    //kiem tra han su dung
                                    if (chosse == HSD[1] || chosse == "2")
                                    {
                                        KiemTraHanSuDung(linkHSD, chosse);
                                        check = 1;
                                    }
                                    //kiem tra kho
                                    if (chosse == HSD[2] || chosse == "3")
                                    {
                                        KiemTraKho(linkHSD);
                                        check = 1;
                                    }
                                    //xoa san pham
                                    if (chosse == HSD[3] || chosse == "4")
                                    {
                                        XoaSanPham(linkHSD);
                                        check = 1;
                                    }
                                    //kho moi
                                    if (chosse == HSD[4] || chosse == "5")
                                    {
                                        KhoMoi(linkHSD1);
                                        check = 1;
                                    }
                                    //
                                    if (chosse == HSD[5] || chosse == "6")
                                    {
                                        check = 1;
                                    }
                                    //thiet lap duong dan moi, hoac sau khi bi mat ket noi
                                    if (chosse == HSD[6] || chosse == "7")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        string[] d = Directory.GetDirectories(linkHSD1);
                                        foreach (string ds in d)
                                        {
                                            Console.WriteLine(ds);
                                        }
                                       Console.ResetColor();
                                        Console.Write("NEW LINK: ");
                                        newLink = Console.ReadLine();
                                        newLink = newLink.Replace(" ", "");
                                        if (Directory.Exists(newLink) == true)
                                        {
                                            linkHSD = newLink;
                                        }
                                        check = 1;
                                    }
                                    //
                                    if (chosse == HSD[7] || chosse == "8")
                                    {
                                        check = 1;
                                    }
                                    //
                                    if (chosse == HSD[8] || chosse == "9")
                                    {
                                        check = 1;
                                    }
                                    //tim san pham
                                    if (chosse == HSD[9] || chosse == "10")
                                    {
                                        SearchSP(linkHSD);
                                        check = 1;
                                    }
                                    //xoa san pham thu cong
                                    if (chosse == HSD[10] || chosse == "11")
                                    {
                                        XoaSanPhamThuCong(linkHSD);
                                        check = 1;
                                    }
                                    //kiem tra han su dung cua 1 san pham
                                    if (chosse != "" && check == 0)
                                    {
                                        KiemTraHanSuDung(linkHSD, chosse);
                                    }
                                }
                                catch (Exception aHSD)
                                {
                                    ttl.HienThiThongBao("HSD!", aHSD.Message, 16, b);
                                }
                                check = 0;
                            } while (chosse != "exit");
                        }
                        //XE MAY
                        if (wAYWF == "xemay" || wAYWF == "moto")
                        {
                            //kiem tra ket noi
                            linkXM = ConnectXM(linkXM);
                            do
                            {
                                try
                                {
                                    XuatMang(arrHonda, linkXM);
                                   Console.ResetColor();
                                    chosseXM = Console.ReadLine();
                                    chosseXM = chosseXM.ToLower();
                                    chosseXM = chosseXM.Replace(" ", "");
                                    //xoa man hinh
                                    Console.Clear();
                                    //c?p nh?t t?nh tr?ng m?i thay nh?t c?a xe
                                    if (chosseXM == arrHonda[0] || chosseXM == "1")
                                    {
                                        MoiThayNhot(linkXM);
                                    }
                                    //ki?m tra s? km c?n l?i c?a xe
                                    if (chosseXM == arrHonda[1] || chosseXM == "2")
                                    {
                                        KiemTraNhot(linkXM);
                                    }
                                    //thêm bi?n s? xe
                                    if (chosseXM == arrHonda[2] || chosseXM == "3")
                                    {
                                        ThemBienSoXe(linkXM);
                                    }
                                    //xóa d? li?u
                                    if (chosseXM == arrHonda[3] || chosseXM == "4")
                                    {
                                        XoaDuLieu(linkXM);
                                    }
                                    //xóa d? li?u
                                    if (chosseXM == arrHonda[4] || chosseXM == "5")
                                    {
                                        TinhTrangXe(linkXM, b);
                                    }
                                    //thi?t l?p
                                    if (chosseXM == arrHonda[5] || chosseXM == "6")
                                    {
                                        Console.Write("[{0}]\nLink: ", linkXM);
                                        linkXM = Console.ReadLine();
                                    }
                                }
                                catch (Exception aXM)
                                {
                                    ttl.HienThiThongBao("XE MAY!", aXM.Message, 16, b);
                                    linkXM = Console.ReadLine();
                                }
                               Console.ResetColor();
                            }
                            while (chosseXM != "exit");
                        }
                        //nhac nho
                        if (wAYWF == "nhacnho" && b.Replace(" ", "") != "")
                        {
                            link = b + "/NhacNho";
                            //neu thu muc chua ton tai tao thu muc moi
                            ttl.TaoThuMuc(link);
                            // xoa nhac nho cu~
                            XoaNhacNhoCu(link);
                            do
                            {
                                //xoa man hinh
                                Console.Clear();
                                //xuat mang
                                XuatMang(NhacNho);
                                chosseNN = Console.ReadLine();
                                //them nhac nho moi
                                if (chosseNN == NhacNho[0] || chosseNN == "1")
                                {
                                    ThemNhacNho(link, b);
                                }
                                //xoa nhac nho
                                if (chosseNN == NhacNho[1] || chosseNN == "2")
                                {
                                    XoaNhacNho(link);
                                }
                                //thay doi noi dung cua nhac nho
                                if (chosseNN == NhacNho[2] || chosseNN == "3")
                                {
                                    ThayDoiNoiDungNhacNho(link);
                                }
                            } while (chosseNN != "exit");
                        }
                        //bieu do
                        if (wAYWF == "bieudo" || wAYWF == "chart")
                        {
                            linkBD = b + "\\BieuDo\\";
                            do
                            {
                                //xoa man hinh
                                Console.Clear();
                                Console.WriteLine("[+]THEM BIEU DO");
                                chosseBD = Console.ReadLine();
                                chosseBD = chosseBD.ToLower().Replace(" ", "");
                                //them bieu do moi
                                if (chosseBD == "+")
                                {
                                    AddBD(linkBD);
                                }
                            } while (chosseBD != "exit");
                        }
                    }
                    catch (Exception bD)
                    {
                        ttl.HienThiThongBao("Bieu Do!", bD.Message, 16, b);
                    }
                    //Check Green Zone
                    if (File.Exists(b + "/Code/GreenZone.TTL") == false)
                    {
                        dem++;
                    }
                    CheckGreenZone(dem, num, b1, b);
                    //thong bao chuong trinh
                    ThongBao(num, b, sDisk);
                    ColorTTL(times, b);
                    times++;
                    if (times > 10)
                    {
                        times = 0;
                    }
                } while (wAYWF != arr[14] && wAYWF != arr[2]);
                if (wAYWF == arr[2])
                {
                    b = "";
                    Console.WriteLine("Restarting...Done!");
                }
            } while (wAYWF != arr[14]);
            // xoa man hinh
            Console.Clear();
            // sao luu du lieu
            if (File.Exists("TTL.rar") == true)
            {
                File.Delete("TTL.rar");
            }
            // nen file
            ZipFile.CreateFromDirectory(b, "TTL.rar");
            // hien thi thong bao
            ttl.HienThiThongBao("TTL PROGRAM...", "BAN DA DANG XUAT KHOI CHUONG TRINH CHUC BAN MOT NGAY LAM VIEC VUI VE :))", 4096, b);
            //Delete 
            try
            {
                ShutDown(b);
            }
            catch (Exception e)
            {
                ttl.HienThiThongBao("ERROR! :<<", e.Message, 16, b);
            }
           Console.ResetColor();
        }
        // ve bieu do canvas
        public static void Canvas(string c,string nameTKB,string nameTable,HelpTTL ttl){
            string strColumn1 = "";
            string strColumn2 = "";
            int iNum1 = 0;
            int iNum2 = 0;
            int iNum = 0;
            bool bGo = false;
            // tao thu muc va file
            ttl.TaoThuMuc(nameTKB + "Canvas");
            ttl.TaoFile(nameTKB + "Canvas/Canvas.html");
            ttl.TaoFile(nameTKB + "Canvas/Head.txt");
            ttl.TaoFile(nameTKB + "Canvas/Bottom.txt");

            // kiem tra du lieu
            if(Directory.Exists(nameTKB + "/" + nameTable) == true){
                Console.Write("NAME COLUMN NAME: ");
                strColumn1 = Console.ReadLine();
                Console.Write("NAME COLUMN DATA(number): ");
                strColumn2 = Console.ReadLine();
                Console.Write("Line1 ");
                int.TryParse(Console.ReadLine(), out iNum1);
                Console.Write("Line2 ");
                int.TryParse(Console.ReadLine(), out iNum2);

                // ghi phan dau
                ttl.GhiDuLieuVaoFile(nameTKB + "Canvas/Canvas.html",ttl.LayDuLieuTrongFileStr(nameTKB + "Canvas/Head.txt"). Replace("name",nameTable),false);
                
                // ghi phan noi dung
                string[] getFile = Directory.GetFiles(nameTKB + nameTable);
                foreach(string fi in getFile){
                    if(iNum >= iNum1 - 1 && iNum <= iNum2 - 1)
                    // loc du lieu rong
                        if(ttl.TraDuLieuSoNDongTrongFile(fi,ttl.TraVeSoDongTrongFile(nameTKB + nameTable + "/Name/name.txt",strColumn1) + 1).Replace(" ","") != "" && ttl.TraDuLieuSoNDongTrongFile(fi,ttl.TraVeSoDongTrongFile(nameTKB + nameTable + "/Name/name.txt",strColumn2) + 1).Replace(" ","") != ""){
                            // xoa dau cham
                            ttl.TraDuLieuSoNDongTrongFile(fi,ttl.TraVeSoDongTrongFile(nameTKB + nameTable + "/Name/name.txt",strColumn2) + 1).Replace(" ","").Replace(".","");
                            ttl.GhiDuLieuVaoFile(nameTKB + "Canvas/Canvas.html",  "{ label:\""  +  ttl.TraDuLieuSoNDongTrongFile(fi,ttl.TraVeSoDongTrongFile(nameTKB + nameTable + "/Name/name.txt",strColumn1) + 1) + "\", y:" + ttl.TraDuLieuSoNDongTrongFile(fi,ttl.TraVeSoDongTrongFile(nameTKB + nameTable + "/Name/name.txt",strColumn2) + 1) + "},",true);
                        }
                    // Console.WriteLine(ttl.TraDuLieuSoNDongTrongFile(fi,ttl.TraVeSoDongTrongFile(nameTKB + nameTable + "/Name/name.txt",strColumn1) + 1) + " " + ttl.TraDuLieuSoNDongTrongFile(fi,ttl.TraVeSoDongTrongFile(nameTKB + nameTable + "/Name/name.txt",strColumn2) + 1));
                    iNum++;
                }

                // ghi phan cuoi
                ttl.GhiDuLieuVaoFile(nameTKB + "Canvas/Canvas.html",ttl.LayDuLieuTrongFileStr(nameTKB + "Canvas/Bottom.txt") + "",true);
                
                //mo bieu do
                ttl.MoDuongDan(nameTKB + "Canvas/Canvas.html"); 
                
            }
            // Console.Write(c + " " + nameTKB);
            // Console.ReadKey();
        }
        // hien thi ket noi internet
        public static void ShowInternet(bool internet)
        {
            // hien mau do neu ket noi internet bang false
            if (internet == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("INTERNET>");
            }
            // hien mau xanh neu ket noi internet bang true
            if (internet == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("INTERNET>");
            }
        }
        //kiem tra ket noi mang cua may tinh
        private static bool IsConnectedToInternet()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// ttl icon
        /// </summary>
        /// <param name="link"></param>
        public static void TTLIcon(string link)
        {
            Random rd = new Random();
            int dem = 0;
            int numLineTable = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                link = link + "/NumLineTable.ttl";
                //neu duong dan ton tai
                if (File.Exists(link) == true)
                {
                    //lay so canh bang
                    string[] fileNumLineTable = File.ReadAllLines(link);
                    foreach (string numLTB in fileNumLineTable)
                    {
                        numLineTable = int.Parse(numLTB);
                    }
                }
                if (numLineTable != 0)
                {
                    numLineTable = numLineTable / 3;
                }
                do
                {
                    foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
                    {
                        for (int i = 0; i <= rd.Next(1, numLineTable); i++)
                        {
                            Console.ForegroundColor = color;
                            Console.Write(".");
                        }
                    }
                    dem++;
                    Console.WriteLine();
                } while (dem < 4);
            }
        }
        /// <summary>
        /// tai mot ung dung moi cho chuong trinh
        /// </summary>
        /// <param name="link"></param>
        public static string Upload(string link, string data)
        {
            string strUpload = "";
            //neu duong dan khac rong
            if (link != "")
            {
                HelpTTL ttl = new HelpTTL();
                //thay doi duong dan
                link = link + "/Upload.ttl";
                //neu duong dan chua ton tai
                if (File.Exists(link) == false)
                {
                    FileStream fileNew = new FileStream(link, FileMode.Create);
                    fileNew.Close();
                }
                //neu duong dan khac rong
                if (link != "")
                {
                    // them du lieu truy cap
                    strUpload = ttl.Loc2KyTu(data, "upload", "add");
                    if (strUpload != "")
                        //ghi du lieu vao file
                        ttl.GhiDuLieuVaoFile(link, strUpload, false);
                    // xoa du lieu truy cap
                    strUpload = ttl.Loc2KyTu(data, "-upload", "-add");
                    if (strUpload != "")
                        // tao file moi
                        ttl.TaoFileVsDongMoi(link, strUpload);
                    //xoa du lieu dang tai len he thong
                    if (strUpload == "null")
                        //xoa file
                        File.Delete(link);
                }
            }
            return link;
        }
        /// <summary>
        /// doc so lan da hoan thanh cong viec
        /// </summary>
        /// <param name="link"></param>
        public static void SoLanHoanThanhCongViec(string link)
        {
            //neu duong dan khac rong
            if (link != "")
            {
                HelpTTL ttl = new HelpTTL();
                try
                {
                    //thay doi duong dan
                    link = link + "/CongViecDaHoanThanh.ttl";
                    //doc so lan da hoan thanh cong viec
                    Console.Write("SO LAN HOAN THANH CONG VIEC ");
                    string[] file = File.ReadAllLines(link);
                    foreach (string lines in file)
                    {
                        Console.WriteLine(lines);
                    }
                }
                catch (Exception l)
                {
                    ttl.HienThiThongBao("SLHTCV!", l.Message, 16, link);
                }
            }
        }
        //tinh phan tram du lieu so
        public static void PercentTTL(string link)
        {
            //neu duong dan khac rong
            if (link != "")
            {
                int percent = 0;
                int numSum = 0;
                int num = 0;
                int Sum = 0;
                string linkTable = link + "/Table/taichinh";
                string linkTableCurrentTime = linkTable + "/" + DateTime.Now.Month + "-" + DateTime.Now.Year;
                string linkTableSum = linkTable + "/sum";
                //ghi tong
                Console.Write("SUM: ");
                int.TryParse(Console.ReadLine(), out numSum);
                //ghi phan tram mong muon
                Console.Write("PERCENT UPLOAD: ");
                int.TryParse(Console.ReadLine(), out percent);
                //neu tong > 0
                if (numSum > 0)
                {
                    //xoa thu muc
                    if (Directory.Exists(linkTableCurrentTime) == true)
                    {
                        Directory.Delete(linkTableCurrentTime, true);
                    }
                    if (Directory.Exists(linkTableSum) == true)
                    {
                        Directory.Delete(linkTableSum, true);
                    }
                    //tien hanh tinh toan
                    for (double i = 1; i <= 100; i++)
                    {
                        if (percent == i)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            //tao thu muc table
                            if (Directory.Exists(linkTable) == false)
                            {
                                DirectoryInfo taichinh = new DirectoryInfo(linkTable);
                                taichinh.Create();
                            }
                            if (Directory.Exists(linkTableCurrentTime) == false)
                            {
                                DirectoryInfo taichinhTime = new DirectoryInfo(linkTableCurrentTime);
                                taichinhTime.Create();
                                //tao di lieu bang
                                FileStream fileTaiChinhTime = new FileStream(linkTableCurrentTime + "/" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".ttl", FileMode.Create);
                                fileTaiChinhTime.Close();
                                //ghi du lieu tai len
                                TextWriter fileTaiChinhTimeUpload = new StreamWriter(linkTableCurrentTime + "/" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".ttl", true);
                                fileTaiChinhTimeUpload.WriteLine(i * numSum / 100);
                                fileTaiChinhTimeUpload.Close();
                                //file ten
                                FileStream fileTaiChinhTimeName = new FileStream(linkTableCurrentTime + "/name.ttl", FileMode.Create);
                                fileTaiChinhTimeName.Close();
                                //ghi ten bang
                                TextWriter textName = new StreamWriter(linkTableCurrentTime + "/name.ttl", false);
                                textName.WriteLine(i + "% " + DateTime.Now);
                                textName.Close();
                            }
                            if (Directory.Exists(linkTableSum) == false)
                            {
                                DirectoryInfo taichinhSum = new DirectoryInfo(linkTableSum);
                                taichinhSum.Create();
                                //file ten
                                FileStream fileSumName = new FileStream(linkTableSum + "/name.ttl", FileMode.Create);
                                fileSumName.Close();
                                //ghi ten bang
                                TextWriter textNameSum = new StreamWriter(linkTableSum + "/name.ttl", false);
                                textNameSum.WriteLine("SUM =))");
                                textNameSum.Close();
                                //tao file du lieu bang
                                FileStream fileSum = new FileStream(linkTableSum + "/sum.ttl", FileMode.Create);
                                fileSum.Close();
                                //nhap du lieu bang sum
                                string[] dataSum = Directory.GetDirectories(linkTable);
                                foreach (string folders in dataSum)
                                {
                                    //tru thu muc goc
                                    //Console.WriteLine(folders);
                                    if (folders != @"D:\Users\MyPC\\TTL\/Table/taichinh\Sum")
                                    {
                                        //lay file trong thu muc
                                        string[] dataFile = Directory.GetFiles(folders);
                                        foreach (string files in dataFile)
                                        {
                                            //Console.WriteLine(files);
                                            //lay du lieu trong file
                                            string[] readFile = File.ReadAllLines(files);
                                            foreach (string data in readFile)
                                            {
                                                try
                                                {
                                                    num = int.Parse(data);
                                                }
                                                catch
                                                {

                                                }
                                                Sum = Sum + num;
                                                //Console.WriteLine(Sum);
                                                //Console.WriteLine(num);
                                                num = 0;
                                            }
                                        }
                                    }
                                }
                                //ghi du lieu vao file
                                TextWriter textSum = new StreamWriter(linkTableSum + "/sum.ttl", false);
                                textSum.WriteLine(string.Format("{0:0,0}", Sum));
                                textSum.Close();
                            }
                        }
                        Console.WriteLine(string.Format("{0}% = {1:0,0} ({2:0,0})", i, (i * numSum / 100), (numSum - (i * numSum / 100))));
                       Console.ResetColor();
                        Thread.Sleep(500);
                    }
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// thong tin chuong trinh
        /// </summary>
        /// <param name="link"></param>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="arr3"></param>
        /// <param name="link1"></param>
        /// <param name="link2"></param>
        /// <param name="thuMucHT"></param>
        /// <returns></returns>
        public static int ThongTin(string link, string sDisk, string[] arr1, string[] arr2, string[] arr3, string link1, string link2, string[] thuMucHT)
        {
            int dem = 0;
            int old = 0;
            int soNgay = 0;
            //tinh so ngay chuong trinh da ton tai
            var dat = new DateTime(2020, 8, 19);
            for (int ctr = 0; ctr <= ctr + 1; ctr++)
            {
                //??m s? ngày
                soNgay++;
                //hi?n ngày
                //Console.Write(dat.AddDays(ctr).ToString("dd|"));
                //?i?u ki?n d?ng v?ng l?pyp
                if (dat.AddDays(ctr).Day == DateTime.Now.Day && dat.AddDays(ctr).Month == DateTime.Now.Month && dat.AddDays(ctr).Year == DateTime.Now.Year)
                {
                    break;
                }
            }
            old = DateTime.Now.Year - 2020;
           Console.ResetColor();
            Console.WriteLine("[TTL]\n-NAM THANH LAP: 2020\n-TUOI HIEN TAI: {0}\n-SO NGAY CUA CHUONG TRINH: {1} NGAY\n-MUC TIEU: GIU CHO MAY CHU KHONG BI SAP\n-NGUOI SANG LAP: DTDBB NGAY 19/8/2020", old, soNgay);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("[ " + arr1[i] + " ]");
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("[ " + arr2[i] + " ]");
            }
            Console.WriteLine();
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("[ " + arr3[i] + " ]");
            }
            for (int i = 0; i < thuMucHT.Length; i++)
            {
                Console.Write("[ " + thuMucHT[i] + " ]");
            }
            Console.WriteLine();
            //cac thu muc dang ho tro
            string[] folders = Directory.GetDirectories(sDisk + "/TTL/");
            foreach (string folderTTL in folders)
            {
                Console.WriteLine(folderTTL);
                //lay file trong thu muc
                string[] fileLinkTTL = Directory.GetFiles(folderTTL);
                foreach (string files in fileLinkTTL)
                {
                    //doc du lieu trong file
                    string[] file = File.ReadAllLines(files);
                    foreach (string lines in file)
                    {
                        dem++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(lines + " ..ÐANG SU DUNG..USING..");
                       Console.ResetColor();
                    }
                }
            }
            Console.ReadKey();
            return dem;
        }
        /// <summary>
        /// chuong trinh dau tien, bang ma ascii
        /// </summary>
        /// <param name="chonSo"></param>
        public static void BangMaAscii(int chonSo)
        {
            for (int i = 1; i <= chonSo; i++)
            {
                Console.Write((char)i + "\t");
            }
        }
        /// <summary>
        /// menu chuong trinh
        /// </summary>
        /// <param name="linkDatabase"></param>
        public static void DSDieuMoi(string linkDatabase, string linkTTL)
        {
            string chosse = ""; string a = " "; string b = " "; string c = " "; string d = " "; string e = " "; string f = " "; string g = " "; string h = " "; string j = " "; string k = " "; string l = " "; string v = " "; string u = " ";
            int num = 0;
            HelpTTL ttl = new HelpTTL();
            do
            {
                do
                {
                    for (int i = 0; i <= 12; i++)
                    {
                        //xoa man hinh
                        Console.Clear();
                        if (i == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            a = "< mo file"; b = " "; c = " "; d = " "; e = " "; f = " "; g = " "; h = " "; j = " "; k = " "; l = " "; v = " "; u = " ";
                            num = 1;
                        }
                        if (i == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            a = " "; b = "< tao file moi"; c = " "; d = " "; e = " "; f = " "; g = " "; h = " "; j = " "; k = " "; l = " "; v = " "; u = " ";
                            num = 2;
                        }
                        if (i == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            a = " "; b = " "; c = "< xoa mot dong trong file"; d = " "; e = " "; f = " "; g = " "; h = " "; j = " "; k = " "; l = " "; v = " "; u = " ";
                            num = 3;
                        }
                        if (i == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            a = " "; b = " "; c = " "; d = "< xoa file"; e = " "; f = " "; g = " "; j = " "; k = " "; l = " "; v = " "; u = " ";
                            num = 4;
                        }
                        if (i == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            a = " "; c = " "; b = " "; d = " "; e = "< tao thu muc moi"; f = " "; g = " "; h = " "; j = " "; k = " "; l = " "; v = " "; u = " ";
                            num = 5;
                        }
                        if (i == 5)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            a = " "; c = " "; b = " "; d = " "; e = " "; f = "< mo thu muc dang tree"; g = " "; h = " "; j = " "; k = " "; l = " "; v = " "; u = " ";
                            num = 6;
                        }
                        if (i == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            a = " "; c = " "; b = " "; d = " "; e = " "; f = " "; g = "< xoa thu muc"; h = " "; j = " "; k = " "; l = " "; v = " "; u = " ";
                            num = 7;
                        }
                        if (i == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            a = " "; c = " "; b = " "; d = " "; e = " "; f = " "; g = " "; h = "< hien thong tin may tinh"; j = " "; k = " "; l = " "; v = " "; u = " ";
                            num = 8;
                        }
                        if (i == 8)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            a = " "; c = " "; b = " "; d = " "; e = " "; f = " "; g = " "; h = " "; j = "< sao chep thu muc"; k = " "; l = " "; v = " "; u = " ";
                            num = 9;
                        }
                        if (i == 9)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            a = " "; c = " "; b = " "; d = " "; e = " "; f = " "; g = " "; h = " "; j = " "; k = "< mo thuc muc hoac file"; l = " "; v = " "; u = " ";
                            num = 10;
                        }
                        if (i == 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            a = " "; c = " "; b = " "; d = " "; e = " "; f = " "; g = " "; h = " "; j = " "; k = " "; l = "< sao chep thu muc"; v = " "; u = " ";
                            num = 11;
                        }
                        if (i == 11)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            a = " "; c = " "; b = " "; d = " "; e = " "; f = " "; g = " "; h = " "; j = " "; k = " "; l = " "; v = "< nen thu muc"; u = " ";
                            num = 12;
                        }
                        if (i == 12)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            a = " "; c = " "; b = " "; d = " "; e = " "; f = " "; g = " "; h = " "; j = " "; k = " "; l = " "; v = " "; u = "< giai nen file"; ;
                            num = 13;
                        }
                        ProcessDirectory(linkDatabase);
                        Console.WriteLine("Open File {0}", a);
                        Console.WriteLine("Create File {0}", b);
                        Console.WriteLine("Delete The Line {0}", c);
                        Console.WriteLine("Delete File {0}", d);
                        Console.WriteLine("Create Directory {0}", e);
                        Console.WriteLine("Open The Folder [tree] {0}", f);
                        Console.WriteLine("Delete Directory {0}", g);
                        Console.WriteLine("Infor Memory {0}", h);
                        Console.WriteLine("Copy Folder {0}", j);
                        Console.WriteLine("Open The Folder / File  {0}", k);
                        Console.WriteLine("Copy File {0}", l);
                        Console.WriteLine("Compressed Folder {0}", v);
                        Console.WriteLine("Extract File {0}", u);
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("\nrun/");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("exit: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        chosse = Console.ReadLine();
                        chosse = chosse.Replace(" ", "");
                        chosse = chosse.ToLower();
                       Console.ResetColor();
                        if (chosse == "run")
                        {
                            break;
                        }
                        if (chosse == "exit")
                        {
                            num = 0;
                            break;
                        }
                    }
                } while (chosse != "run" && chosse != "exit");
                //giai nen thu muc
                if (num == 13)
                {
                    string sFileRAR = "";
                    string sFolderCompressed = "";
                    //ghi ten file can giai nen
                    Console.Write("FILE.rar || File.zip> ");
                    sFileRAR = Console.ReadLine();
                    //neu ten file co ton tai
                    if (File.Exists(sFileRAR) == true)
                    {
                        //ghi ten thu muc
                        Console.Write("NAME FOLDER> ");
                        sFolderCompressed = Console.ReadLine();
                        //neu ten thu muc chua ton tai
                        if (Directory.Exists(sFolderCompressed) == false)
                        {
                            //tien hanh giai nen cho file
                            ZipFile.ExtractToDirectory(sFileRAR, sFolderCompressed);
                            Console.WriteLine("DONE...");
                            Console.ReadKey();
                        }
                    }
                }
                //nen thu muc
                if (num == 12)
                {
                    string sLinkFolder = "";
                    string sNameFileRAR = "";
                    //ghi duong dan thu muc can nen
                    Console.Write("FOLDER> ");
                    sLinkFolder = Console.ReadLine();
                    //neu thu muc co ton tai
                    if (Directory.Exists(sLinkFolder) == true)
                    {
                        //ghi ten file can nen
                        Console.Write("NAME FILE> ");
                        sNameFileRAR = Console.ReadLine();
                        //neu file chua ton tai
                        if (File.Exists(sNameFileRAR + ".rar") == false)
                        {
                            //tien hanh nen file
                            ZipFile.CreateFromDirectory(sLinkFolder, sNameFileRAR + ".rar");
                            Console.WriteLine("DONE...");
                            Console.ReadKey();
                        }
                    }
                }
                //open folder
                if (num == 10)
                {
                    string nameFolder = " ";
                    Console.Write("Link: ");
                    nameFolder = Console.ReadLine();
                    Process myProcess = new Process();
                    try
                    {
                        // true is the default, but it is important not to set it to false
                        myProcess.StartInfo.UseShellExecute = true;
                        myProcess.StartInfo.FileName = nameFolder;
                        myProcess.Start();
                    }
                    catch (Exception s)
                    {
                        ttl.HienThiThongBao("MENU!", s.Message, 16, linkTTL);
                    }
                }
                //copy thu muc
                if (num == 9)
                {
                    string sourceDirectory = "";
                    string targetDirectory = "";
                    try
                    {
                        //ghi ten thu muc 1
                        Console.Write("FOLDER 1>");
                        sourceDirectory = Console.ReadLine();
                        //neu thu muc 1 co ton tai tien hanh ghi thu muc 2
                        if (Directory.Exists(sourceDirectory) == true)
                        {
                            Console.Write("FOLDER 2>");
                            targetDirectory = Console.ReadLine();
                            targetDirectory =  targetDirectory.Replace(" ","");
                            //neu thu muc 2 chua ton tai tao thu muc moi
                            if (Directory.Exists(targetDirectory) == false)
                            {
                                DirectoryInfo newF = new DirectoryInfo(targetDirectory);
                                newF.Create();
                            }
                            //tien hanh sao chep thu muc
                            DirectoryInfo sourceDircetory = new DirectoryInfo(sourceDirectory);
                            DirectoryInfo targetDircetory = new DirectoryInfo(targetDirectory);
                            CopyAll(sourceDircetory, targetDircetory);
                            if (num == 9)
                            {
                                Console.WriteLine("\nDONE...");
                                Console.ReadLine();
                            }
                        }
                        if (num == 14)
                        {
                            //nen du lieu
                            ZipFile.CreateFromDirectory(targetDirectory, targetDirectory + ".rar");
                            //xoa du lieu cu
                            Directory.Delete(targetDirectory, true);
                            Console.WriteLine("DONE...");
                            Console.ReadLine();
                        }
                    }
                    catch (Exception fF)
                    {
                        ttl.HienThiThongBao("MENU!", fF.Message, 16, linkTTL);
                    }
                }
                //copy file
                if (num == 11)
                {
                    try
                    {
                        string link = "";
                        string newLink = "";
                        Console.Write("COPY TO>>");
                        newLink = Console.ReadLine();
                        if (File.Exists(newLink) == false)
                        {
                            FileStream file = new FileStream(newLink, FileMode.Create);
                            file.Close();
                            TextWriter copy = new StreamWriter(newLink, true);
                            Console.Write("COPY FILE>>");
                            link = Console.ReadLine();
                            //kiem tra file duoc copy
                            if (File.Exists(link) == true)
                            {
                                Console.Write("loading...");
                                string[] fileData = File.ReadAllLines(link);
                                foreach (string lines in fileData)
                                {
                                    copy.WriteLine(lines);
                                }
                                copy.Close();
                                Console.WriteLine("Done! Link:" + newLink);
                            }
                        }
                    }
                    catch (Exception copy)
                    {
                        ttl.HienThiThongBao("MENU!", copy.Message, 16, linkTTL);
                    }
                    Console.ReadKey();
                }
                //tim file va nhap du lieu : DTD
                if (num == 1)
                {
                    string nameFile = "";
                    int dem = 0;
                    bool bl = true;
                    string function = "";
                    string chosseFunction = "";
                    int xacNhan = 0;
                    Console.Write("[Open]Link>");
                    Console.ForegroundColor = ConsoleColor.Green;
                    nameFile = Console.ReadLine();
                    //bat loi : intertnet

                    try
                    {
                        do
                        {

                            //THONG BAO
                            if (xacNhan == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("FILE DANG DUOC CHINH SUA NOI DUNG...");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("FILE DANG DUOC TRINH CHIEU...");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            //mo file
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            string[] lines = File.ReadAllLines(nameFile);
                            foreach (string timfile in lines)
                            {
                                Console.WriteLine(timfile);
                            }
                            //ghi noi dung moi
                            if (xacNhan == 1)
                            {
                                TextWriter text = new StreamWriter(nameFile, bl);
                                function = Console.ReadLine();
                                //cac dieu kien xoa file trong luc chinh sua
                                if (function == "bl = true")
                                {
                                    bl = true;
                                    function = "";
                                }
                                if (function == "bl = false")
                                {
                                    bl = false;
                                    function = "";
                                }
                                text.WriteLine(function);
                                xacNhan = 0;
                                //dong file      
                                text.Close();
                            }
                            //ghi du lieu
                            if (bl == true)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.Write("delete/save/exit/write/{0}[write line {1} file: {2} ]>", bl, dem, nameFile);
                            Console.ForegroundColor = ConsoleColor.Green;
                            chosseFunction = Console.ReadLine();
                            //viet dung moi vao file
                            if (chosseFunction == "write" || chosseFunction == "w")
                            {
                                xacNhan = 1;
                            }

                        } while (chosseFunction != "exit" && chosseFunction != "e");
                        //lenh                        
                    }
                    catch (Exception q)
                    {
                        ttl.HienThiThongBao("MENU!", q.Message, 16, linkTTL);
                    }
                }
                //xoa file : intertnet
                if (num == 4)
                {
                    char yn = ' ';
                    try
                    {
                        ProcessDirectory(linkDatabase);
                        Console.Write("[DELETE FILE]Link>");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string xoaFile = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        //xac nhan lai nguoi dung muon xoa file
                        if (File.Exists(xoaFile) == true)
                        {
                            Console.Write("BAN CO MUON XOA FILE NAY KHONG?[Y][N]");
                            char.TryParse(Console.ReadLine(), out yn);
                            if (yn == 'Y' || yn == 'y')
                            {
                                File.Delete(xoaFile);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("DA XOA!");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("TU CHOI!");
                            }
                        }
                        //thong bao cho nguoi dung neu khong tim thay file
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("KHONG TIM THAY FILE!");
                        }
                    }
                    catch (Exception s)
                    {
                        Console.WriteLine(s.Message);
                    }
                    Console.ReadKey();
                }
                //tao file : intertnet
                if (num == 2)
                {
                    try
                    {
                        Console.Write("New Link File:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string newFile = Console.ReadLine();
                        if (System.IO.File.Exists(newFile))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Da ton tai file " + newFile);
                        }
                        else
                        {
                            System.IO.FileStream fs = new System.IO.FileStream(newFile, System.IO.FileMode.Create);
                            fs.Close();
                            Console.WriteLine("Link:" + newFile);
                        }
                    }
                    catch (Exception s)
                    {
                        ttl.HienThiThongBao("MENU!", s.Message, 16, linkTTL);
                    }
                    Console.ReadKey();
                }
                //xoa 1 dong tong file 
                if (num == 3)
                {
                    int line = 0;
                    char yn = ' ';
                    int dem = -1;
                    string timFile = "";
                    //link
                    Console.Write("[Open]Link>");
                    timFile = Console.ReadLine();
                    //neu file co ton tai
                    if (File.Exists(timFile) == true)
                    {
                        do
                        {
                            dem = -1;
                            Console.ForegroundColor = ConsoleColor.White;
                            try
                            {
                                string[] lines = File.ReadAllLines(timFile);
                                foreach (string timfile in lines)
                                {
                                    dem++;
                                    Console.WriteLine("[ " + dem + " ]" + timfile);
                                }
                                //xoa mot dong trong file
                                var file = new List<string>(System.IO.File.ReadAllLines(timFile));
                                Console.Write("Chon so dong can xoa: ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                int.TryParse(Console.ReadLine(), out line);
                                file.RemoveAt(line);
                                File.WriteAllLines(timFile, file.ToArray());
                                Console.WriteLine("Line number {0} has been deleted!", line);
                            }
                            catch (Exception p)
                            {
                                ttl.HienThiThongBao("MENU!", p.Message, 16, linkTTL);
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("Continue? [y][n]");
                            char.TryParse(Console.ReadLine(), out yn);
                        } while (yn != 'n' && yn != 'N');
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("KHONG TIM THAY FILE!");
                        Console.ReadKey();
                    }
                }
                //tao folder : intertnet
                if (num == 5)
                {
                    try
                    {
                        Console.Write("New Link Directory:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string newDirectory = Console.ReadLine();
                        if (System.IO.Directory.Exists(newDirectory))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("THU MUC DA TON TAI");
                        }
                        else
                        {
                            DirectoryInfo directory = new DirectoryInfo(newDirectory);
                            directory.Create();
                            Console.WriteLine("Link Directory: " + newDirectory);
                        }
                    }
                    catch (Exception s)
                    {
                        ttl.HienThiThongBao("MENU!", s.Message, 16, linkTTL);
                    }
                    Console.ReadKey();
                }
                //xoa thu muc 
                if (num == 7)
                {
                    char yn = ' ';
                    try
                    {
                        Console.Write("Link the folder to delete: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string LinkFolderToDelete = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        //xac nhan lai nguoi dung muon xoa thu muc
                        if (Directory.Exists(LinkFolderToDelete) == true)
                        {
                            Console.Write("BAN CO MUON XOA THU MUC NAY KHONG?[Y][N]");
                            char.TryParse(Console.ReadLine(), out yn);
                            if (yn == 'Y' || yn == 'y')
                            {
                                Directory.Delete(LinkFolderToDelete, true);
                                ttl.HienThiThongBao("MENU!", "DA XOA THU MUC.", 4096, linkTTL);
                            }
                            else
                            {

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                ttl.HienThiThongBao("MENU!", "TU CHOI!", 48, linkTTL);
                            }
                        }
                        //thong bao cho nguoi dung neu khong tim thay thu muc
                        else
                        {
                            ttl.HienThiThongBao("MENU!", "KHONG TIM THAY THU MUC!", 64, linkTTL);
                        }
                    }
                    catch (Exception w)
                    {
                        ttl.HienThiThongBao("MENU!", w.Message, 16, linkTTL);
                    }
                    Console.ReadKey();
                }
                //mo thu muc : intertnet
                if (num == 6)
                {
                    try
                    {
                        Console.Write("Link Open folder: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        string directory = Console.ReadLine();
                        PrintDirectory(directory);
                        Console.ReadKey();
                    }
                    catch (Exception x)
                    {
                        ttl.HienThiThongBao("MENU!", x.Message, 16, linkTTL);
                    }
                }
                //infor memory : intertnet
                if (num == 8)
                {
                    DriveInfo[] drives = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in drives)
                    {
                        Console.WriteLine(" ============================== ");
                        // Tên c?a ? ??a (C, D, ..)
                        Console.WriteLine("Drive {0}", drive.Name);
                        // Lo?i ? ??a (Removable,..)
                        Console.WriteLine("  Drive type: {0}", drive.DriveType);
                        // N?u ? ??a s?n sàng.
                        if (drive.IsReady)
                        {
                            Console.WriteLine("  Volume label: {0}", drive.VolumeLabel);
                            Console.WriteLine("  File system: {0}", drive.DriveFormat);
                            Console.WriteLine(
                                "  Available space to current user:{0, 15} bytes < {1} gigabyte",
                                drive.AvailableFreeSpace, drive.AvailableFreeSpace / 1000000000);
                            Console.WriteLine(
                                "  Total available space:          {0, 15} bytes < {1} gigabyte",
                                drive.TotalFreeSpace, drive.TotalFreeSpace / 1000000000);

                            Console.WriteLine(
                                "  Total size of drive:            {0, 15} bytes < {1} gigabyte",
                                drive.TotalSize, drive.TotalSize / 1000000000);
                        }
                    }
                    Console.ReadKey();
                }
            } while (chosse != "exit");

        }
        //SAO CHEP THU MUC
        private static void CopyAll(DirectoryInfo sourceDirectory, DirectoryInfo targetDirectory)
        {
            Directory.CreateDirectory(targetDirectory.FullName);
            foreach (FileInfo fi in sourceDirectory.GetFiles())
            {
                Console.Write("Copying {0}\\{1}", targetDirectory.FullName, fi.Name + "\r");
                fi.CopyTo(Path.Combine(targetDirectory.FullName, fi.Name), true);
            }
            foreach (DirectoryInfo diSourceSubDir in sourceDirectory.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = targetDirectory.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }
        }
        /// <summary>
        /// luu lai lich su nguoi dung
        /// </summary>
        /// <param name="data"></param>
        /// <param name="link"></param>
        public static void HistorySave(string data, string link)
        {
            int dem = 0;
            link = link + "History.ttl";
            if (File.Exists(link) == true)
            {
                string[] lineSum = File.ReadAllLines(link);
                foreach (string lines in lineSum)
                {
                    dem++;
                }
                if (dem >= 100)
                {
                    FileInfo file = new FileInfo(link);
                    file.Delete();
                }
                if (data != "")
                {
                    TextWriter text = new StreamWriter(link, true);
                    text.WriteLine(DateTime.Now + " " + data);
                    text.Close();
                }
            }
            if (File.Exists(link) == false)
            {
                FileStream file = new FileStream(link, FileMode.Create);
                file.Close();
            }
        }
        //mo thu muc : intertnet
        public static void PrintDirectory(string dirPath)
        {
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                // N?u b?n không có quy?n truy c?p th? m?c 'dirPath' 
                // m?t ngo?i l? UnauthorizedAccessException s? ???c ném ra.
                IEnumerable<string> enums = Directory.EnumerateDirectories(dirPath);
                List<string> dirs = new List<string>(enums);
                foreach (string dir in dirs)
                {
                    Console.WriteLine(dir);
                    PrintDirectory(dir);
                }
            }
            // L?i b?o m?t khi truy c?p vào th? m?c mà b?n không có quy?n.
            catch (Exception e)
            {
                Console.WriteLine("Can not access directory: " + dirPath);
                Console.WriteLine(e.Message);
            }
        }
        // va loi~
        public static void VaLoi(string link)
        {
            string c = "";
            string nameLink = "";
            string vaLoi = "";
            string vaLoi1 = "";
            int dem = 0;
            do
            {
                // xoa man hinh
                Console.Clear();
                c = "";
                dem = 0;
                Console.ForegroundColor = ConsoleColor.White;
                HelpTTL ttl = new HelpTTL();
                Console.WriteLine("[1]TAO THU MUC TRONG NHIEU THU MUC\n[2]TAO MOT FILE TRONG NHIEU THU MUC\n[3]XOA MOT THU MUC TRONG NHIEU THU MUC\n[4]XOA MOT FILE TRONG NHIEU THU MUC\n[5]DI CHUYEN FILE DEN THU MUC MOI\n[6]DI CHUYEN THUC MUC DEN THU MUC");
                c = Console.ReadLine();
                // neu nguoi dung chon 1
                if (c == "1")
                {
                    Console.Write("-GHI TEN THU MUC CAN VA LOI~(tao.): ");
                    nameLink = Console.ReadLine();
                    // neu thu muc co ton tai
                    if (Directory.Exists(nameLink) == true)
                    {
                        Console.Write("-GHI TEN THU MUC SE DUOC TAO DE VA LOI~: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(nameLink + "/.../");
                        vaLoi = Console.ReadLine();
                        // neu cac du lieu co ton tai
                        if (Directory.Exists(nameLink) == true && vaLoi.Replace(" ", "") != "")
                        {
                            // lay cac thu muc trong file
                            string[] gD = Directory.GetDirectories(nameLink);
                            foreach (string d in gD)
                            {
                                // tao thu muc de va loi
                                if (Directory.Exists(d + "/" + vaLoi) == false)
                                {
                                    dem++;
                                    ttl.TaoThuMuc(d + "/" + vaLoi);
                                }
                            }
                            // thong bao
                            ttl.HienThiThongBao("VA' LOI~!", "[DA KHOI TAO " + dem + " THU MUC " + vaLoi + " DEN THU MUC " + nameLink + "]", 0, link);
                        }
                    }
                }
                // neu nguoi dung chon 1
                if (c == "3")
                {
                    Console.Write("-GHI TEN THU MUC CAN VA LOI~(xoa'): ");
                    nameLink = Console.ReadLine();
                    // neu thu muc co ton tai
                    if (Directory.Exists(nameLink) == true)
                    {
                        Console.Write("-GHI TEN THU MUC BI XOA DE VA LOI~: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(nameLink + "/.../");
                        vaLoi = Console.ReadLine();
                        // neu cac du lieu co ton tai
                        if (Directory.Exists(nameLink) == true && vaLoi.Replace(" ", "") != "")
                        {
                            // lay cac thu muc trong file
                            string[] gD = Directory.GetDirectories(nameLink);
                            foreach (string d in gD)
                            {
                                // tao thu muc de va loi
                                if (Directory.Exists(d + "/" + vaLoi) == true)
                                {
                                    dem++;
                                    Directory.Delete(d + "/" + vaLoi, true);
                                }
                            }
                            // thong bao
                            ttl.HienThiThongBao("VA' LOI~!", "[DA XOA " + dem + " THU MUC " + vaLoi + " DEN THU MUC " + nameLink + "]", 0, link);
                        }
                    }
                }
                // neu nguoi dung chon 1
                if (c == "2")
                {
                    Console.Write("-GHI TEN THU MUC CAN VA LOI~(tao.): ");
                    nameLink = Console.ReadLine();
                    // neu thu muc co ton tai
                    if (Directory.Exists(nameLink) == true)
                    {
                        Console.Write("-GHI TEN FILE SE DUOC TAO DE VA LOI~: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(nameLink + "/.../");
                        vaLoi = Console.ReadLine();
                        // neu cac du lieu co ton tai
                        if (Directory.Exists(nameLink) == true && vaLoi.Replace(" ", "") != "")
                        {
                            // lay cac thu muc trong file
                            string[] gD = Directory.GetDirectories(nameLink);
                            foreach (string d in gD)
                            {
                                // tao thu muc de va loi
                                if (File.Exists(d + "/" + vaLoi) == false)
                                {
                                    dem++;
                                    ttl.TaoFile(d + "/" + vaLoi);
                                }
                            }
                            // thong bao
                            ttl.HienThiThongBao("VA' LOI~!", "[DA KHOI TAO " + dem + " FILE " + vaLoi + " DEN THU MUC " + nameLink + "]", 0, link);
                        }
                    }
                }
                // neu nguoi dung chon 1
                if (c == "4")
                {
                    Console.Write("-GHI TEN THU MUC CAN VA LOI~(xoa'): ");
                    nameLink = Console.ReadLine();
                    // neu thu muc co ton tai
                    if (Directory.Exists(nameLink) == true)
                    {
                        Console.Write("-GHI TEN FILE SE DUOC XOA DE VA LOI~: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(nameLink + "/.../");
                        vaLoi = Console.ReadLine();
                        // neu cac du lieu co ton tai
                        if (Directory.Exists(nameLink) == true && vaLoi.Replace(" ", "") != "")
                        {
                            // lay cac thu muc trong file
                            string[] gD = Directory.GetDirectories(nameLink);
                            foreach (string d in gD)
                            {
                                // tao thu muc de va loi
                                if (File.Exists(d + "/" + vaLoi) == true)
                                {
                                    dem++;
                                    File.Delete(d + "/" + vaLoi);
                                }
                            }
                            // thong bao
                            ttl.HienThiThongBao("VA' LOI~!", "[DA XOA " + dem + " FILE " + vaLoi + " DEN THU MUC " + nameLink + "]", 0, link);
                        }
                    }
                }
                // neu nguoi dung chon 1
                if (c == "5")
                {
                    Console.Write("-GHI TEN THU MUC CAN VA LOI~(move): ");
                    nameLink = Console.ReadLine();
                    // neu thu muc co ton tai
                    if (Directory.Exists(nameLink) == true)
                    {
                        Console.Write("-GHI TEN FILE SE DUOC DI CHUYEN?: {0}/..../",nameLink);
                        vaLoi = Console.ReadLine();
                        Console.Write("-GHI TEN THU MUC FILE({0}) SE DUOC CHUYEN DEN?: ", (nameLink + "/..../" + vaLoi));
                        vaLoi1 = Console.ReadLine();
                        // neu cac du lieu co ton tai
                        if (Directory.Exists(nameLink) == true && vaLoi.Replace(" ", "") != "" == true && vaLoi1.Replace(" ", "") != "")
                        {
                            // lay cac thu muc trong file
                            string[] gD = Directory.GetDirectories(nameLink);
                            foreach (string d in gD)
                            {
                                // tao thu muc
                                if (File.Exists(d + "/" + vaLoi) == true && Directory.Exists(d + "/" + vaLoi1) == false)
                                    ttl.TaoThuMuc(d + "/" + vaLoi1);
                                try{
                                     // di chuyen file den thu muc
                                    if (File.Exists(d + "/" + vaLoi) == true && Directory.Exists(d + "/" + vaLoi1) == true)
                                    {
                                        dem++;
                                        // di chuyen file
                                        File.Move(d + "/" + vaLoi,d + "/" + vaLoi1 + "/" + vaLoi);
                                    }
                                }
                                catch{

                                }
                            }
                            // thong bao
                            ttl.HienThiThongBao("VA' LOI~!", "[DA DI CHUYEN " + dem + " FILE " + nameLink + "/.../" + vaLoi + " DEN THU MUC " + nameLink + "/.../" + vaLoi1 + "]", 0, link);
                        }
                    }
                }
                // neu nguoi dung chon 1
                if (c == "6")
                {
                    Console.Write("-GHI TEN THU MUC CAN VA LOI~(move): ");
                    nameLink = Console.ReadLine();
                    // neu thu muc co ton tai
                    if (Directory.Exists(nameLink) == true)
                    {
                        Console.Write("-GHI TEN THU MUC SE DUOC DI CHUYEN?: {0}/..../",nameLink);
                        vaLoi = Console.ReadLine();
                        Console.Write("-GHI TEN THU MUC MA THU MUC({0}) SE DUOC CHUYEN DEN?: ", (nameLink + "/..../" + vaLoi));
                        vaLoi1 = Console.ReadLine();
                        // neu cac du lieu co ton tai
                        if (Directory.Exists(nameLink) == true && vaLoi.Replace(" ", "") != "" == true && vaLoi1.Replace(" ", "") != "")
                        {
                            // lay cac thu muc trong file
                            string[] gD = Directory.GetDirectories(nameLink);
                            foreach (string d in gD)
                            {
                                // tao thu muc
                                if (Directory.Exists(d + "/" + vaLoi) == true && Directory.Exists(d + "/" + vaLoi1) == false)
                                    ttl.TaoThuMuc(d + "/" + vaLoi1);
                                try{
                                     // di chuyen file den thu muc
                                    if (Directory.Exists(d + "/" + vaLoi) == true && Directory.Exists(d + "/" + vaLoi1) == true)
                                    {
                                        dem++;
                                        // di chuyen file
                                        Directory.Move(d + "/" + vaLoi,d + "/" + vaLoi1 + "/" + vaLoi);
                                    }
                                }
                                catch{

                                }
                            }
                            // thong bao
                            ttl.HienThiThongBao("VA' LOI~!", "[DA DI CHUYEN " + dem + " THU MUC " + nameLink + "/.../" + vaLoi + " DEN THU MUC " + nameLink + "/.../" + vaLoi1 + "]", 0, link);
                        }
                    }
                }
                // neu thu muc khong ton tai
                if (Directory.Exists(nameLink) == false && nameLink.Replace(" ", "") != "")
                    ttl.HienThiThongBao("VA' LOI~!", "KHONG TIM THAY TEN THU MUC!> " + nameLink, 16, link);
            } while (c.Replace(" ", "").ToLower() != "exit");
        }
        //tao nhieu file
        public static void CreateManyFile()
        {
            try
            {
                int SoLanTaoFile = 0;
                int ii = 0;
                string a = @"D:/" + DateTime.Now.Millisecond;
                string b = ".txt";
                Console.Write("So Lan Tao file: ");
                int.TryParse(Console.ReadLine(), out SoLanTaoFile);
                Console.Write("Ghi Noi Dung Vao file: ");
                string noidung = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ghi ten duong dan file:vd:" + a + "\n>");
                a = Console.ReadLine();
                Console.Write("Ghi ky tu duoi file:vd:" + b + "\n>");
                b = Console.ReadLine();
                for (int i = 0; i < SoLanTaoFile; i++)
                {
                    ii++;
                    TextWriter tsw = new StreamWriter(a + "/" + ii + b, true);
                    tsw.WriteLine(noidung);
                    tsw.Close();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DA TAO {0} FILE!", SoLanTaoFile);
                Console.ReadKey();
            }
            catch (Exception file)
            {
                Console.WriteLine(file.Message);
                Console.ReadKey();
            }

        }
        //tao nhieu thu muc
        public static void CreateManyFolder()
        {
            try
            {
                long SoLanTaoFolder = 0;
                Console.Write("So Lan Tao folder: ");
                long.TryParse(Console.ReadLine(), out SoLanTaoFolder);
                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("Ghi duong dan folder: ");
                Console.ForegroundColor = ConsoleColor.Green;
                string linkFolder = Console.ReadLine();
                for (int i = 0; i < SoLanTaoFolder; i++)
                {
                    DirectoryInfo directory = new DirectoryInfo(linkFolder + "/" + name + "(" + i + ")");
                    directory.Create();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DA TAO {0} THU MUC!", SoLanTaoFolder);
                Console.ReadKey();
            }
            catch (Exception ii)
            {
                Console.WriteLine(ii.Message);
                Console.ReadKey();
            }
        }
        //database
        public static string database()
        {
            //thi?t l?p d? li?u c? b?n
            Console.Write("LINK: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string link = Console.ReadLine();
           Console.ResetColor();
            ShowFile(link);
            return link;
        }
        public static void ShowFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("File khong ton tai");
                }
                else if (Directory.Exists(path))
                {
                    ProcessDirectory(path); // n?u file t?n t?i
                }
                else
                {
                    Console.WriteLine("Khong tim thay file :(");
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// hien thi thong tin cac item trong thu muc
        /// </summary>
        /// <param name="pathfile"></param>
        public static void ProcessDirectory(string pathfile)
        {
            if (pathfile != "")
            {
                //hietn thi file
                string[] fileList = Directory.GetFiles(pathfile);//lay danh sách file cho vao m?ng
                Console.WriteLine("------------------------------------------------------");
                for (int i = 0; i < fileList.Length; i++)
                {
                    Console.WriteLine(fileList[i]);
                }
                //hien thi thu muc
                string[] folderList = Directory.GetDirectories(pathfile);//lay danh sách file cho vao m?ng
                for (int i = 0; i < folderList.Length; i++)
                {
                    Console.WriteLine(folderList[i]);
                }
                Console.WriteLine("------------------------------------------------------");
            }
        }
        /// <summary>
        /// ket noi du lieu
        /// </summary>
        /// <param name="b"></param>
        /// <param name="num"></param>
        /// <param name="b1"></param>
        /// <returns></returns>
        public static string Connect(string b, int num, string b1)
        {
            int dem = 0;
            string linkTable = "";
            linkTable = b + "\\Table\\";
            Console.ForegroundColor = ConsoleColor.White;
            //n?u th? m?c t?n t?i
            // goi ham thong bao
            HelpTTL ttl = new HelpTTL();
            if (Directory.Exists(b + "\\Code\\") == true)
            {
                //m? th? m?c
                string[] fileSum = Directory.GetFiles(b + "\\Code\\");
                foreach (string linkFile in fileSum)
                {
                    //n?u s? file v??t quá s? cho phép
                    dem++;
                    if (dem >= 100)
                    {
                        //xóa th? m?c
                        Directory.Delete(b + "\\Code\\", true);
                    }
                }
            }
            //n?u th? m?c không t?n t?i
            if (Directory.Exists(linkTable) == false)
            {
                DirectoryInfo folder = new DirectoryInfo(linkTable);
                folder.Create();
            }
            try
            {
                //t?o th? m?c
                DirectoryInfo f = new DirectoryInfo(b + "\\Code\\");
                f.Create();
                string line = "";
                Random rd = new Random();
                num = rd.Next(1, 1000000000);
                TextWriter file = new StreamWriter(b + "\\Code\\" + num, true);
                file.WriteLine(rd.Next(100000, 999999));
                file.WriteLine("LUU Y! MA CHI CO HIEU LUC 1 LAN.");
                file.Close();
                //lay du lieu trong file
                StreamReader File = new StreamReader(b + "\\Code\\" + num);
                do
                {
                    try
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("{0}", num);
                        //ng??i s? d?ng nh?p m? s?
                        Console.Write("MA TRUY CAP> ");
                        line = Console.ReadLine();
                        Console.BackgroundColor = ConsoleColor.Black;
                        //do
                        //{
                        //neu dung mat khau
                        if (line == File.ReadLine())
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            //thi?t l?p ??ng nh?p ?áng tin c?y
                            GreenZone(b);
                            ttl.HienThiThongBao("CONNECT..", "DANG NHAP THANH CONG!", 4096, b);
                            File.Close();
                            return b;
                        }
                        //neu nhap sai mat khau
                        else
                        {
                            ttl.HienThiThongBao("CONNECT..", "SAI MAT KHAU DANG NHAP!", 64, b);
                            b = "";
                            break;
                        }
                        //} while (File.EndOfStream != true);
                    }
                    catch (Exception q)
                    {
                        ttl.HienThiThongBao("CONNECT..", q.Message, 16, b);
                        break;
                    }
                } while (line != File.ReadLine());
                File.Close();
            }
            catch (Exception j)
            {
                ttl.HienThiThongBao("CONNECT!", j.Message, 16, b);
            }
            Console.ReadKey();
            return b;
        }
        //Green zone
        public static void GreenZone(string link)
        {
            //t?o vùng an toàn
            FileStream file = new FileStream(link + "\\Code\\" + "\\GreenZone.TTL", FileMode.Create);
            file.Close();
            TextWriter text = new StreamWriter(link + "\\Code\\" + "\\GreenZone.TTL");
            text.WriteLine("This is green zone :)");
            text.Close();
        }
        //Check Green Zone
        public static void CheckGreenZone(int dem, int num, string b1, string b)
        {
            //ki?m tra vùng an toàn
            if (dem == 5)
            {
                //Connect                      
                b = Connect(b, num, b1);
            }
            if (dem > 5)
            {
                dem = 0;
            }
        }

        //nh?p m?ng
        static void nhapMang(string[] arrM, string content)
        {
            if (content == "")
            {
                content = "Unfounded!";
            }
            for (int i = 0; i < arrM.Length; i++)
            {
                Console.Write("Nhap noi dung thiet lap {0} voi muc buoc cuoi cung la {1}: ", i + 1, content);
                arrM[i] = Console.ReadLine();
                if (arrM[i] == "")
                {
                    arrM[i] = "Unfounded!";
                }
            }
        }
        //xu?t m?ng
        static void xuatMang(string[] arrM, string content, string b, string page)
        {
            int dem = 0;
            string save = "";
            HelpTTL ttl = new HelpTTL();
            if (content == "")
            {
                content = "Unfounded!";
            }
            foreach (string s in arrM)
            {
                save = save + "[B" + dem + "]" + s + "------>";
                dem++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("B" + dem + " ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(s);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("------->");
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("[ " + content + " ]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(b + "\nPrint");
            for (int i = 0; i <= 3; i++)
            {
                for (int slow = 0; slow <= 100000000; slow++)
                {
                    //hello
                }
                Console.Write(" .");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            try
            {
                //tao thu muc
                DirectoryInfo folder = new DirectoryInfo(b + "\\Table\\" + page + "\\BIG MAP " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\");
                folder.Create();
                //tao file thong tin
                //tao file big map
                TextWriter f = new StreamWriter(b + "\\Table\\" + page + "\\BIG MAP " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\Map.ttl", true);
                f.WriteLine(DateTime.Now.DayOfWeek + " " + DateTime.Now);
                f.WriteLine(save + ">-- " + content);
                f.Close();
                //tao file ten map
                FileStream file = new FileStream(b + "\\Table\\" + page + "\\BIG MAP " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\name.ttl", FileMode.Create);
                file.Close();
                //ghi ten vao file
                TextWriter name = new StreamWriter(b + "\\Table\\" + page + "\\BIG MAP " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\name.ttl", true);
                name.WriteLine("BIG MAP " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                name.Close();
            }
            catch (Exception a)
            {
                ttl.HienThiThongBao("BIG MAP!", a.Message, 16, b);
            }
        }
        //Aday aday
        public static string Aday(string LinkActive, string Link)
        {
            string c = Link;
            string link7Day = Link + "/7Day/";
            HelpTTL ttl = new HelpTTL();
            var today = DateTime.Now;
            var duration = new TimeSpan(0, 0, 0, 0);
            DateTime newday = today.Add(duration);
            string amopm = "";
            amopm = newday.ToString("tt");
            string b = Link + "\\Table\\main\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\";
            string newActive = "";
            Link = Link + "\\Table\\main\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".ttl";
            //t?o th? m?c c?a ngày hôm nay
            if (Directory.Exists(b) == false)
            {
                DirectoryInfo folder = new DirectoryInfo(b);
                folder.Create();
            }
            //t?o file c?a ngày hôm nay
            if (File.Exists(Link) == false)
            {
                FileStream f = new FileStream(Link, FileMode.Create);
                f.Close();
            }
            //t?o file tên c?a ngày hôm nay
            if (File.Exists(b + "\\name.ttl") == false)
            {
                FileStream f = new FileStream(Link, FileMode.Create);
                f.Close();
                TextWriter textName = new StreamWriter(b + "\\name.ttl", false);
                textName.WriteLine(DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                textName.Close();
            }
            //n?u file ?? t?n t?i
            if (File.Exists(Link) == true && DateTime.Now.Hour < 22 && DateTime.Now.Hour >= 5)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("How is your day : ");
                    newActive = Console.ReadLine();
                    TextWriter hoatDongMoi = new StreamWriter(Link, true);
                    if (newActive != "")
                    {
                        hoatDongMoi.WriteLine(amopm + newday.ToString(" hh:MM ") + newActive);
                        // tao du lieu vao file 7 day
                        ttl.TaoFile(link7Day, DateTime.Now.Day + "-" + DateTime.Now.Month);
                        ttl.GhiDuLieuVaoFile(link7Day + DateTime.Now.Day + "-" + DateTime.Now.Month, "<[aday] " + newActive + ">", false);
                    }
                    hoatDongMoi.Close();
                    if (Link != "" && newActive != "")
                    {
                        ttl.HienThiThongBao("ADAY..", "HOAT DONG CUA BAN DA DUOC GUI TOI " + Link, 4096, c);
                    }

                }
                catch (Exception e)
                {
                    ttl.HienThiThongBao("ADAY!", e.Message, 16, c);
                }
            }
            else
            {
                if (DateTime.Now.Hour >= 22)
                {
                    Console.WriteLine("Hien tai chuc nang chua the su dung do chua den thoi gian quy dinh :D\nThoi gian con lai ({0}h {1}m)", 24 - DateTime.Now.Hour + 4, 60 - DateTime.Now.Minute);
                }
                else
                {
                    Console.WriteLine("Hien tai chuc nang chua the su dung do chua den thoi gian quy dinh :D\nThoi gian con lai ({0}h {1}m)", 4 - DateTime.Now.Hour, 60 - DateTime.Now.Minute);
                }
            }
            Console.ReadKey();
            return LinkActive;
        }
        //lay o dia can ket noi
        public static string ConnectDisk(string sDisk)
        {
            string nameDisk = "";
            int numGetDisk = 0;
            //lay thong tin cac o o trong may tinh
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                numGetDisk++;
                //lay ten o dia dau tien
                if (numGetDisk == 1)
                {
                    nameDisk = drive.Name;
                }
            }
            return nameDisk;
        }
        //ki?m tra k?t n?i t? thi?t l?p k?t n?i
        public static string Connect(string b)
        {
            string nameDisk = "";
            int numGetDisk = 0;
            HelpTTL ttl = new HelpTTL();
            try
            {
                //lay thong tin cac o o trong may tinh
                DriveInfo[] drives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in drives)
                {
                    numGetDisk++;
                    //lay ten o dia dau tien
                    if (numGetDisk == 1)
                    {
                        nameDisk = drive.Name;
                    }
                }
                string[] link = Directory.GetFiles(nameDisk + "TTL/TTL/");
                foreach (string newConnect in link)
                {
                    string[] iConnect = File.ReadAllLines(newConnect);
                    foreach (string start in iConnect)
                    {
                        b = start;
                    }
                }
            }
            catch
            {
                ttl.HienThiThongBao("SET UP!", "THIET LAP THAT BAI!", 16, b);
                //tao thuc muc chua thong tin cac duong dan
                DirectoryInfo newFolder = new DirectoryInfo(nameDisk + "TTL/TTL/");
                newFolder.Create();
                //tao file ghi tu muc
                FileStream fileTTL = new FileStream(nameDisk + "TTL/TTL/TTL.txt", FileMode.Create);
                fileTTL.Close();
                b = "";
            }
            return b;
        }
        /// <summary>
        /// hien thi hoat dong cua chuong trinh
        /// </summary>
        /// <returns></returns>
        public static string Information(int show, string link, int dem, int soKetNoi, int soLanDuocThietLap)
        {
            string soLanThietLap = "";
            string linkConnect = "";
            string connect = "";
            int soLanThietLapMoi = 0;
            string nameDisk = "";
            int numGetDisk = 0;
            try
            {
                if (link != "")
                {
                    //lay thong tin cac o o trong may tinh
                    DriveInfo[] drives = DriveInfo.GetDrives();
                    foreach (DriveInfo drive in drives)
                    {
                        numGetDisk++;
                        //lay ten o dia dau tien
                        if (numGetDisk == 1)
                        {
                            nameDisk = drive.Name;
                        }
                    }
                    soLanThietLap = link + "/SLTLTTL.ttl";
                    //dem so duong dan dang duoc su dung
                    connect = "DANG KET NOI...";
                    string[] file = Directory.GetFiles(nameDisk + "TTL/TTL/");
                    foreach (string s in file)
                    {
                        string[] file1 = File.ReadAllLines(s);
                        foreach (string a in file1)
                        {
                            linkConnect = a;
                        }
                    }
                    if (soLanDuocThietLap == 1)
                    {
                        //dem so lan chuong trinh da duoc mo
                        //neu file dem so lan thiet lap chua duoc mo
                        if (File.Exists(soLanThietLap) == false)
                        {
                            //tao file so lan thiet lap
                            FileStream fileNew = new FileStream(soLanThietLap, FileMode.Create);
                            fileNew.Close();
                        }
                        //neu file so lan thiet lap da ton tai
                        //dem so lan thiet lap va them 1 lan thiet lap moi
                        if (File.Exists(soLanThietLap) == true)
                        {
                            //mo file
                            string[] fileOpen = File.ReadAllLines(soLanThietLap);
                            foreach (string line in fileOpen)
                            {
                                soLanThietLapMoi = int.Parse(line);
                            }
                        }
                        //ghi so lan thiet lap moi vao du lieu
                        TextWriter SoLanThietLapMoi = new StreamWriter(soLanThietLap, false);
                        SoLanThietLapMoi.WriteLine(soLanThietLapMoi + 1);
                        SoLanThietLapMoi.Close();
                    }
                    //doc du lieu tu file
                    //mo file
                    string[] fileSLDTL = File.ReadAllLines(soLanThietLap);
                    foreach (string line in fileSLDTL)
                    {
                        soLanThietLapMoi = int.Parse(line);
                    }

                }
                else
                {
                    connect = "KHONG CO KET NOI :(";
                }
                //dieu kien de hien thong tin
                if (show == 1)
                {
                    //hien thi thong tin chuong trinh
                    Console.WriteLine("SLTL {0:00,0}", soLanThietLapMoi);
                    Console.WriteLine("SEARCH: {0}", soLanDuocThietLap);
                    Console.WriteLine("TINH TRANG: {0}", connect);
                    Console.WriteLine("SO DUONG DAN THIET LAP: {0}", soKetNoi);
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
            return linkConnect;
        }
        /// <summary>
        /// hien thi phan bang chuong trinh, o phan dau
        /// </summary>
        public static void TTLHead(string link, int times)
        {
            string linkPicture = link + "\\Picture\\";
            string soLanThietLap = link + "\\SLTLTTL.ttl";
            string linkNumLineTable = "";
            int numLineTable = 0;
            if (link != "")
            {
                linkNumLineTable = link + "\\NumLineTable.ttl";
                //neu duong dan ton tai
                if (File.Exists(linkNumLineTable) == true)
                {
                    //lay so canh bang
                    string[] fileNumLineTable = File.ReadAllLines(linkNumLineTable);
                    foreach (string numLTB in fileNumLineTable)
                    {
                        numLineTable = int.Parse(numLTB);
                    }
                }
            }
            Space(numLineTable);
            Console.WriteLine("");
            Space(numLineTable);
            Console.WriteLine(" _______________________");
            Space(numLineTable);
            Console.Write("|-----------------------");
            Console.Write("|");
            ColorTTL(times, link);
            Console.Write("    |||||||||  |||||||||  ||    ");
            Console.ForegroundColor = ConsoleColor.Green;
            //hien thi hinh dai dien
            if (File.Exists(linkPicture + "1") == true)
            {
                string[] fileH1 = File.ReadAllLines(linkPicture + "1");
                foreach (string line in fileH1)
                {
                    Console.WriteLine(line);
                }
            }
            //neu khong co anh dai dien, xuong dong
            if (File.Exists(linkPicture + "1") == false)
            {
                Console.WriteLine();
            }
           Console.ResetColor();
            Space(numLineTable);
            Console.Write("|-ADAY       ");
            //hien thi hom nay la thu may
            if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour <= 21)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("   ONLINE");
               Console.ResetColor();
                Console.Write("  |");
                ColorTTL(times, link);
                Console.Write("       ||         ||      ||    ");
                Console.ForegroundColor = ConsoleColor.Green;
                //hien thi hinh dai dien
                if (File.Exists(linkPicture + "2") == true)
                {
                    string[] fileH1 = File.ReadAllLines(linkPicture + "2");
                    foreach (string line in fileH1)
                    {
                        Console.WriteLine(line);
                    }
                }
                //neu khong co anh dai dien, xuong dong
                if (File.Exists(linkPicture + "2") == false)
                {
                    Console.WriteLine();
                }
               Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("   OFFLINE");
               Console.ResetColor();
                Console.Write(" |");
                ColorTTL(times, link);
                Console.Write("       ||         ||      ||    ");
                Console.ForegroundColor = ConsoleColor.Green;
                //hien thi hinh dai dien
                if (File.Exists(linkPicture + "2") == true)
                {
                    string[] fileH1 = File.ReadAllLines(linkPicture + "2");
                    foreach (string line in fileH1)
                    {
                        Console.WriteLine(line);
                    }
                }
                //neu khong co anh dai dien, xuong dong
                if (File.Exists(linkPicture + "2") == false)
                {
                    Console.WriteLine();
                }
               Console.ResetColor();

            }
            Space(numLineTable);
            //hien chuong trinh dang duoc ket noi hay chua
            Console.Write("|-CALENDAR ");
            if (DateTime.Now.Hour >= 22)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("     ONLINE");
               Console.ResetColor();
                Console.Write("  |");
                ColorTTL(times, link);
                Console.Write("       ||         ||      ||    ");
                Console.ForegroundColor = ConsoleColor.Green;
                //hien thi hinh dai dien
                if (File.Exists(linkPicture + "3") == true)
                {
                    string[] fileH1 = File.ReadAllLines(linkPicture + "3");
                    foreach (string line in fileH1)
                    {
                        Console.WriteLine(line);
                    }
                }
                //neu khong co anh dai dien, xuong dong
                if (File.Exists(linkPicture + "3") == false)
                {
                    Console.WriteLine();
                }
               Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("     OFFLINE");
               Console.ResetColor();
                Console.Write(" |");
                ColorTTL(times, link);
                Console.Write("       ||         ||      ||    ");
                Console.ForegroundColor = ConsoleColor.Green;
                //hien thi hinh dai dien
                if (File.Exists(linkPicture + "3") == true)
                {
                    string[] fileH1 = File.ReadAllLines(linkPicture + "3");
                    foreach (string line in fileH1)
                    {
                        Console.WriteLine(line);
                    }
                }
                //neu khong co anh dai dien, xuong dong
                if (File.Exists(linkPicture + "3") == false)
                {
                    Console.WriteLine();
                }
               Console.ResetColor();
            }
            Space(numLineTable);
            //hien thi so ket noi dang duoc su dung
            Console.Write("|-BEDTIME ");
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 5 || DateTime.Now.Hour == 23)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("      ONLINE");
               Console.ResetColor();
                Console.Write("  |");
                ColorTTL(times, link);
                Console.Write("       ||         ||      ||    ");
                Console.ForegroundColor = ConsoleColor.Green;
                //hien thi hinh dai dien
                if (File.Exists(linkPicture + "4") == true)
                {
                    string[] fileH1 = File.ReadAllLines(linkPicture + "4");
                    foreach (string line in fileH1)
                    {
                        Console.WriteLine(line);
                    }
                }
                //neu khong co anh dai dien, xuong dong
                if (File.Exists(linkPicture + "4") == false)
                {
                    Console.WriteLine();
                }
               Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("      OFFLINE");
               Console.ResetColor();
                Console.Write(" |");
                ColorTTL(times, link);
                Console.Write("       ||         ||      ||    ");
                Console.ForegroundColor = ConsoleColor.Green;
                //hien thi hinh dai dien
                if (File.Exists(linkPicture + "4") == true)
                {
                    string[] fileH1 = File.ReadAllLines(linkPicture + "4");
                    foreach (string line in fileH1)
                    {
                        Console.WriteLine(line);
                    }
                }
                //neu khong co anh dai dien, xuong dong
                if (File.Exists(linkPicture + "4") == false)
                {
                    Console.WriteLine();
                }
               Console.ResetColor();
            }
            Space(numLineTable);
            //hien thi so lan tim kiem cua chuong trinh
            Console.Write("|_______________________|");
            ColorTTL(times, link);
            Console.Write("       ||         ||      |||||  ");
            Console.ForegroundColor = ConsoleColor.Green;
            //hien thi hinh dai dien
            if (File.Exists(linkPicture + "5") == true)
            {
                string[] fileH1 = File.ReadAllLines(linkPicture + "5");
                foreach (string line in fileH1)
                {
                    Console.WriteLine(line);
                }
            }
            //neu khong co anh dai dien, xuong dong
            if (File.Exists(linkPicture + "5") == false)
            {
                Console.WriteLine();
            }
           Console.ResetColor();
        }
        /// <summary>
        /// tao khoang cach cho trang
        /// </summary>
        /// <param name="num"></param>
        public static void Space(int num)
        {
            for (int i = 0; i <= num / 3; i++)
            {
                Console.Write(" ");
            }
        }
        /// <summary>
        /// tao lich
        /// </summary>
        /// <param name="link"></param>
        /// <param name="page"></param>
        public static void CalendarUp(string link, string page)
        {
            int h = 0;
            string up = "";
            string activeCalender = "";
            string diaDiem = "";
            string b = link + "\\Table\\" + page + "\\Calendar\\";
            if (link != "" && DateTime.Now.Hour >= 22)
            {
                try
                {
                    link = link + "\\Table\\" + page + "\\Calendar\\Calendar.ttl";
                    //n?u th? m?c không t?n t?i
                    if (Directory.Exists(b) == false)
                    {
                        DirectoryInfo folder = new DirectoryInfo(b);
                        folder.Create();
                    }
                    //n?u file không t?n t?i
                    if (File.Exists(link) == false)
                    {
                        //t?o file
                        FileStream file = new FileStream(link, FileMode.Create);
                        file.Close();
                        //t?o tên file
                        FileStream fileName = new FileStream(b + "\\name.ttl", FileMode.Create);
                        fileName.Close();
                        //ghi tên file
                        TextWriter textName = new StreamWriter(b + "\\name.ttl", false);
                        textName.WriteLine("Calendar");
                        textName.Close();
                        var dat = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                        for (int ctr = 0; ctr <= 1; ctr++)
                        {
                            if (ctr == 0)
                            {
                                Console.WriteLine("Today: {0} (ngay len lich)", dat.AddDays(ctr).ToString("d"));
                            }
                            if (ctr == 1)
                            {
                                Console.WriteLine("Tomorrow: {0} (ngay su dung)", dat.AddDays(ctr).ToString("d"));
                            }
                            if (ctr == 1)
                            {
                                TextWriter text = new StreamWriter(link, true);
                                text.WriteLine("Lich ngay +  " + dat.AddDays(ctr).ToString("d") + "| Da cap nhat luc + " + DateTime.Now);
                                text.Close();
                            }
                        }
                        //thông báo n?u file ?? ???c t?o xong
                        Console.WriteLine("Tao file thanh cong!");
                        do
                        {
                            Console.Write("Chon thoi gian dien ra su kien(1h -> 24h): ");
                            int.TryParse(Console.ReadLine(), out h);
                            Console.Write("Dia diem dien ra su kien: ");
                            diaDiem = Console.ReadLine();
                            if (h >= 1 && h <= 24 && diaDiem != "")
                            {
                                h = h - 1;
                                Console.WriteLine("Thoi gian ly tuong: " + h + " h");
                                Console.Write("Active " + dat.AddDays(1).ToString("d") + " at " + h + "h :");
                                activeCalender = Console.ReadLine();
                                if (activeCalender != "")
                                {
                                    TextWriter text = new StreamWriter(link, true);
                                    text.WriteLine("[{0}h] {1} > {2} | Dia diem: {3}", h, dat.AddDays(1).ToString("d"), activeCalender, diaDiem);
                                    text.Close();
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Da huy lich luc " + h);
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Day khong phai la thoi gian ly tuong : " + h + " h");
                            }
                           Console.ResetColor();
                            Console.WriteLine("exit to off/enter to continue ");
                            up = Console.ReadLine();
                        } while (up != "exit");
                        Console.WriteLine("Da cap nhat lich moi nhat..");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Lich da duoc cap nhat!");
                    }
                }
                catch (Exception a)
                {
                    Console.WriteLine(a.Message);
                }
            }
            else
            {
                if (link == "")
                {
                    Console.WriteLine("Khong tim thay lien ket! :(");
                }
                else
                {
                   Console.ResetColor();
                    if (DateTime.Now.Hour < 21)
                    {
                        Console.WriteLine("Hien tai chuc nang chua the su dung do chua den thoi gian quy dinh :D\nThoi gian con lai ({0}h {1}m)", 22 - DateTime.Now.Hour - 1, 60 - DateTime.Now.Minute);
                    }
                    if (DateTime.Now.Hour == 21)
                    {
                        Console.WriteLine("Hien tai chuc nang chua the su dung do chua den thoi gian quy dinh :D\nThoi gian con lai ({0}m)", 60 - DateTime.Now.Minute);
                    }
                }

            }
            Console.ReadKey();
        }
        /// <summary>
        /// chay he thong
        /// </summary>
        /// <param name="a"></param>
        /// <param name="link"></param>
        /// <param name="diemChuyenCan"></param>
        /// <param name="kyLuat"></param>
        public static void ThongBao(int a, string link, string disk)
        {
            link = link + "Table\\main\\THONG BAO\\THONG BAO.ttl";
            try
            {
                FileStream file = new FileStream(link, FileMode.Create);
                file.Close();
                TextWriter line = new StreamWriter(link, false);
                line.WriteLine("*THONG BAO TTL* :D " + DateTime.Now);
                // TTL
                if (Directory.Exists(disk + "/TTL/TTL") == true)
                    line.WriteLine("[TTL] > da duoc thiet lap.");
                if (Directory.Exists(disk + "/TTL/TTL") == false)
                    line.WriteLine("[TTL] > chua duoc thiet lap!");
                // HSD
                if (Directory.Exists(disk + "/TTL/HSD") == true)
                    line.WriteLine("[HSD] > da duoc thiet lap.");
                if (Directory.Exists(disk + "/TTL/HSD") == false)
                    line.WriteLine("[HSD] > chua duoc thiet lap!");
                // XE MAY
                if (Directory.Exists(disk + "/TTL/XeMay") == true)
                    line.WriteLine("[XeMay] > da duoc thiet lap.");
                if (Directory.Exists(disk + "/TTL/XeMay") == false)
                    line.WriteLine("[XeMay] > chua duoc thiet lap!");
                // Music
                if (Directory.Exists(disk + "/TTL/Music") == true)
                    line.WriteLine("[Music] > da duoc thiet lap.");
                if (Directory.Exists(disk + "/TTL/Music") == false)
                    line.WriteLine("[Music] > chua duoc thiet lap!");
                line.Close();
            }
            catch (Exception aa)
            {
                Console.WriteLine(aa.Message);
            }
        }

        /// <summary>
        /// su kien
        /// </summary>
        /// <param name="link"></param>
        /// <param name="page"></param>
        public static void Event(string link, string page)
        {
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            string nameEvent = "";
            string content = "";
            int numDelete = 0;
            string b = link + "\\Event\\";
            //n?u file có t?n t?i
            if (Directory.Exists(b) == true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("BAN DA THIET LAP SU KIEN HAY QUAY TRO LAI KHI SU KIEN KET THUC.");
               Console.ResetColor();
            }
            //n?u th? m?c không t?n t?i        
            if (Directory.Exists(b) == false)
            {
                DirectoryInfo folder = new DirectoryInfo(b);
                folder.Create();
                Console.Write("Muc dich (purpose)?\n>");
                content = Console.ReadLine();
                Console.Write("Name Event: ");
                nameEvent = Console.ReadLine();
                Console.Write("Ngay ket thuc: ");
                int.TryParse(Console.ReadLine(), out ngay);
                Console.Write("Thang ket thuc: ");
                int.TryParse(Console.ReadLine(), out thang);
                Console.Write("Nam ket thuc: ");
                int.TryParse(Console.ReadLine(), out nam);
                //kiem tra ngay
                //neu thang nhap vao la cac thang co 31 ngay
                if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
                {
                    if (ngay > 31 || ngay <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("SAI NGAY!");
                        numDelete = 1;
                    }
                }
                //neu thang nhap vao la thang co 30 ngay
                if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
                {
                    if (ngay > 30 || ngay <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("SAI NGAY!");
                        numDelete = 1;
                    }
                }
                //neu thang nhap vao la thang 2
                if (thang == 2)
                {
                    //neu la nam nhuan
                    if (ngay % 4 == 0 && ngay % 100 != 0)
                    {
                        if (ngay > 29 || ngay <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("SAI NGAY!");
                            numDelete = 1;
                        }
                    }
                    //neu khong phai la nam nhuan
                    else
                    {
                        if (ngay > 28 || ngay <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("SAI NGAY!");
                            numDelete = 1;
                        }
                    }
                }
                if (ngay == 0 || thang == 0 || nam == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("SAI DINH DANG THOI GIAN!");
                    numDelete = 1;
                }
                //neu thang lon hon 12
                if (thang > 12)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("SAI THANG!");
                    numDelete = 1;
                }
                if (numDelete == 1 && nam < DateTime.Now.Year)
                {
                    //xoa thu muc trong bang
                    Directory.Delete(link, true);
                    //xoa thu muc chinh
                    Directory.Delete(b, true);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("XOA DU LIEU!");
                    Console.ReadKey();
                }
                //neu day du cac tham so
                if (nameEvent != "" && numDelete == 0 && nam >= DateTime.Now.Year)
                {
                    try
                    {
                        //t?o file n?i dung s? ki?n
                        FileStream fileNameEventPP = new FileStream(link + "\\Event\\purposeKTSK.ttl", FileMode.Create);
                        fileNameEventPP.Close();
                        TextWriter EVPP = new StreamWriter(link + "\\Event\\purposeKTSK.ttl", false);
                        EVPP.WriteLine(content);
                        EVPP.Close();
                        //t?o th? m?c s? ki?n
                        DirectoryInfo folder1 = new DirectoryInfo(link + "\\Table\\" + page + "\\Event\\");
                        folder1.Create();
                        //t?o file s? ki?n
                        FileStream fileEvent = new FileStream(link + "\\Table\\" + page + "\\Event\\Event.ttl", FileMode.Create);
                        fileEvent.Close();
                        //t?o file tên s? ki?n
                        FileStream fileNameEvent = new FileStream(link + "\\Table\\" + page + "\\Event\\name.ttl", FileMode.Create);
                        fileNameEvent.Close();
                        //ghi tên b?ng s? ki?n
                        TextWriter textName = new StreamWriter(link + "\\Table\\" + page + "\\Event\\name.ttl", false);
                        textName.WriteLine("Event");
                        textName.Close();
                        //c?p nh?t s? ki?n vào b?ng
                        TextWriter EV = new StreamWriter(link + "\\Table\\" + page + "\\Event\\Event.ttl", false);
                        EV.WriteLine("TEN SU KIEN: [" + nameEvent.ToUpper() + "]");
                        EV.WriteLine("MUC TIEU CUA SU KIEN: +" + content);
                        EV.WriteLine("NGAY BAT DAU: " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year);
                        EV.WriteLine("NGAY KET THUC: " + ngay + "-" + thang + "-" + nam);
                        EV.Close();
                        //t?o file ngày t? ch?c s? ki?n
                        FileStream fileNgay = new FileStream(link + "\\Event\\ngayKTSK.ttl", FileMode.Create);
                        fileNgay.Close();
                        //ghi file ngày k?t thúc s? ki?n
                        TextWriter ngayEEV = new StreamWriter(link + "\\Event\\ngayKTSK.ttl", false);
                        ngayEEV.WriteLine(ngay);
                        ngayEEV.Close();
                        //t?o file tháng k?t thúc s? ki?n
                        FileStream fileThang = new FileStream(link + "\\Event\\thangKTSK.ttl", FileMode.Create);
                        fileThang.Close();
                        //ghi file tháng k?t thúc s? ki?n
                        TextWriter thangEEV = new StreamWriter(link + "\\Event\\thangKTSK.ttl", false);
                        thangEEV.WriteLine(thang);
                        thangEEV.Close();
                        //t?o file n?m k?t thúc s? ki?n
                        FileStream fileNam = new FileStream(link + "\\Event\\namKTSK.ttl", FileMode.Create);
                        fileNam.Close();
                        //ghi file n?m k?t thúc s? ki?n
                        TextWriter namEEV = new StreamWriter(link + "\\Event\\namKTSK.ttl", false);
                        namEEV.WriteLine(nam);
                        namEEV.Close();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("DA THIET LAP XONG SU KIEN :D");
                    }
                    catch (Exception ev)
                    {
                        //thông báo ngo?i l?
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(ev.Message);
                    }
                }
                else
                {
                    //thông báo n?u ng??i dùng nh?p sai s
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sai dinh dang!");
                }
            }
            Console.ReadKey();
           Console.ResetColor();
        }
        /// <summary>
        /// xoa su kien dang dien ra
        /// </summary>
        /// <param name="link"></param>
        public static void DeleteEvent(string link)
        {
            char yn = ' ';
            string b = link + "\\Event\\";
            //n?u ?ang có s? ki?n
            if (Directory.Exists(b) == true)
            {
                Console.Write("BAN CO MUON XOA SU KIEN DANG DIEN RA? [Y][N]");
                char.TryParse(Console.ReadLine(), out yn);
                if (yn == 'y' || yn == 'Y')
                {
                    Directory.Delete(b, true);
                    Directory.Delete(link, true);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("-DA XOA SU KIEN...");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-SU KIEN VAN DANG DUOC TIEP TUC...");
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// xoa chuong trinh dua tren su kien
        /// </summary>
        /// <param name="link"></param>
        public static void ShutDown(string link)
        {
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            int numSumFile = 0;
            try
            {
                //neu thu muc su kien co ton tai
                if (Directory.Exists(link + "\\Event") == true)
                {
                    //lay tong so file trong thu muc
                    string[] getFile = Directory.GetFiles(link + "\\Event");
                    foreach (string files in getFile)
                    {
                        numSumFile++;
                    }
                    if (numSumFile == 4)
                    {
                        //ki?m tra ngày k?t thúc s? ki?n
                        string[] ngayEV = File.ReadAllLines(link + "\\Event\\ngayKTSK.ttl");
                        foreach (string ngayEEV in ngayEV)
                        {
                            ngay = int.Parse(ngayEEV);
                        }
                        //ki?m tra tháng k?t thúc s? ki?n
                        string[] thangEV = File.ReadAllLines(link + "\\Event\\thangKTSK.ttl");
                        foreach (string thangEEV in thangEV)
                        {
                            thang = int.Parse(thangEEV);
                        }
                        //ki?m tra n?m k?t thúc s? ki?n
                        string[] namEV = File.ReadAllLines(link + "\\Event\\namKTSK.ttl");
                        foreach (string namEEV in namEV)
                        {
                            nam = int.Parse(namEEV);
                        }
                        //?i?u ki?n ?? k?t thúc s? ki?n
                        if (ngay != 0 && thang != 0 && nam != 0)
                        {
                            if (DateTime.Now.Day >= ngay && DateTime.Now.Month >= thang && DateTime.Now.Year >= nam || DateTime.Now.Year > nam)
                            {
                                Directory.Delete(link, true);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("SU KIEN DA KET THUC!");
                            }
                        }
                    }
                    else
                    {
                        Directory.Delete(link, true);
                    }

                }
                //neu thu muc su kien khong ton tai
                if (Directory.Exists(link + "\\Event") == false)
                {
                    Directory.Delete(link, true);
                }

            }
            catch (Exception p)
            {
                //thông báo ngo?i l?
                Console.WriteLine(p.Message);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// mau sac ttl
        /// </summary>
        /// <param name="times"></param>
        /// <param name="link"></param>
        public static void ColorTTL(int times, string link)
        {
            if (times == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            if (times == 2)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            if (times == 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            if (times == 4)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            if (times == 5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            if (times == 6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (times == 7)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (times == 8)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            if (times == 9)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            if (times == 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }
        /// <summary>
        /// su kien nam
        /// </summary>
        /// <param name="num"></param>
        /// <param name="link"></param>
        public static void Year(int num, string link)
        {
            int num1 = 0;
            int namThemSuKien = 0;
            string tenSuKien = "";
            char yn = ' ';
            string linkSK = "";
            int year1 = 0;
            int year2 = 0;
            int iNum = 3;
            string sY = " ";
            int iB = 0;
            int demNam = 0;
            string can = "";
            string chi = "";
            int namDienRaSuKien = 0;
            // tim nam
            string findYear = "";
            int iFY = 0;
            string fYear = "";
           Console.ResetColor();
            do
            {
                demNam = 0;
                if (num != DateTime.Now.Year)
                {
                    //nh?p n?m ??u tiên
                    Console.Write("Year1? :");
                    int.TryParse(Console.ReadLine(), out year1);
                    //nh?p n?m th? hai
                    Console.Write("Year2? :");
                    int.TryParse(Console.ReadLine(), out year2);
                    Console.Write("Find CAN CHI: ");
                    findYear = Console.ReadLine();
                }
                if (link != "" && year1 != year2)
                {
                    linkSK = link + "\\Su Kien Moi Nam\\";
                }
                else
                {
                    year1 = DateTime.Now.Year;
                    year2 = year1;
                }
                for (int i = iNum; i <= year2; i++)
                {
                    for (int y = 1; y <= year2 - iNum; y++)
                    {
                        //hien thi thong tin nam do
                        do
                        {

                            if (y == 1)
                            {
                                sY = " ty'  | Mouse";
                                iB = 0;
                            }
                            else if (y == 2)
                            {
                                sY = " siu? | Buffalo";
                                iB = 0;
                            }
                            else if (y == 3)
                            {
                                sY = " dan' | Tiger";
                                iB = 0;
                            }
                            else if (y == 4)
                            {
                                sY = " meo. | Cat";
                                iB = 0;
                            }
                            else if (y == 5)
                            {
                                sY = " thin'| Dragon";
                                iB = 0;
                            }
                            else if (y == 6)
                            {
                                sY = " ti.  | Snake";
                                iB = 0;
                            }
                            else if (y == 7)
                            {
                                sY = " ngo. | Horse";
                                iB = 0;
                            }
                            else if (y == 8)
                            {
                                sY = " mui' | Goat";
                                iB = 0;
                            }
                            else if (y == 9)
                            {
                                sY = " than | Monkey";
                                iB = 0;
                            }
                            else if (y == 10)
                            {
                                sY = " dau. | Chicken";
                                iB = 0;
                            }
                            else if (y == 11)
                            {
                                sY = " tuat'| Dog";
                                iB = 0;
                            }
                            else if (y == 12)
                            {
                                sY = " hoi. | Pig";
                                iB = 0;
                            }
                            else
                            {
                                y = 1;
                                sY = " ty'  | Mouse";
                            }

                        } while (iB == 1);
                        i = i + 1;
                        if (i >= year1 && i <= year2)
                        {
                            //dem tong so nam
                            demNam++;
                            //n?u trùng n?m hi?n t?i
                            if (i == DateTime.Now.Year && year1 != year2)
                            {
                                //neu hai nam khac nhau
                                if (year1 != year2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write(">");
                                }
                                //neu hai nam bang nhau
                                else
                                {
                                    for (int month = 0; month <= DateTime.Now.Month; month++)
                                    {
                                        if (DateTime.Now.Month == month)
                                        {
                                            Console.Write("-");
                                            //Console.ForegroundColor = ConsoleColor.Green;
                                        }
                                        else
                                        {
                                            //Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        if (month != 0)
                                        {
                                            //ghi mau sac cho thang
                                            if (month <= 4)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            else if (month <= 8)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            //neu khong phai la thang hien tai
                                            if (month != DateTime.Now.Month)
                                            {
                                                Console.Write("[{0}]", month);
                                            }
                                            //neu la thang hien tai
                                            if (month == DateTime.Now.Month)
                                            {
                                                Console.Write("{0}/{1}/", DateTime.Now.Day, month);
                                            }
                                        }
                                    }
                                }
                                Console.Write(i);
                               Console.ResetColor();
                            }
                            else
                            {
                                //neu hai nam khac nhau
                                if (year1 != year2)
                                {
                                    Console.Write(">");
                                }
                                //neu hai nam bang nhau
                                else
                                {
                                    for (int month = 0; month <= DateTime.Now.Month; month++)
                                    {


                                        if (DateTime.Now.Month == month)
                                        {
                                            Console.Write("-");
                                            //Console.ForegroundColor = ConsoleColor.Green;
                                        }
                                        else
                                        {
                                            //Console.ForegroundColor = ConsoleColor.Gray;
                                        }
                                        if (month != 0)
                                        {
                                            //ghi mau sac cho thang
                                            if (month <= 4)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                            }
                                            else if (month <= 8)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                            }
                                            //neu khong phai la thang hien tai
                                            if (month != DateTime.Now.Month)
                                            {
                                                Console.Write("[{0}]", month);
                                            }
                                            //neu la thang hien tai
                                            if (month == DateTime.Now.Month)
                                            {
                                                Console.Write("{0}/{1}/", DateTime.Now.Day, month);
                                            }

                                        }
                                    }
                                }
                                Console.Write(i);
                            }
                            // tìm can chi
                            switch (i % 10)
                            {
                                case 0:
                                    can = "Canh";
                                    break;
                                case 1:
                                    can = "Ta^n";
                                    break;
                                case 2:
                                    can = "Nha^m";
                                    break;
                                case 3:
                                    can = "Quy'";
                                    break;
                                case 4:
                                    can = "Gia'p";
                                    break;
                                case 5:
                                    can = "A^t'";
                                    break;
                                case 6:
                                    can = "Bi'nh";
                                    break;
                                case 7:
                                    can = "-Dinh";
                                    break;
                                case 8:
                                    can = "Ma^u.";
                                    break;
                                case 9:
                                    can = "Ky?";
                                    break;
                            }

                            // tìm chi bằng cách lấy năm đó chia lấy dư cho 12
                            switch (i % 12)
                            {
                                case 0:
                                    chi = "Tha^n";
                                    break;
                                case 1:
                                    chi = "Da^u.";
                                    break;
                                case 2:
                                    chi = "Tua^t'";
                                    break;
                                case 3:
                                    chi = "Ho?i.";
                                    break;
                                case 4:
                                    chi = "Ty'";
                                    break;
                                case 5:
                                    chi = "Suu?";
                                    break;
                                case 6:
                                    chi = "Da^n'";
                                    break;
                                case 7:
                                    chi = "Meo.";
                                    break;
                                case 8:
                                    chi = "Thi'n";
                                    break;
                                case 9:
                                    chi = "Ty.";
                                    break;
                                case 10:
                                    chi = "Ngo.";
                                    break;
                                case 11:
                                    chi = "Mui'";
                                    break;
                            }
                            Console.Write(sY);
                            Console.Write(" (" + can + " " + chi + ") ");
                            // tim nam can chi
                            if (findYear.ToLower().Replace(" ", "") == can.ToLower().Replace(" ", "") + chi.ToLower().Replace(" ", ""))
                            {
                                fYear = fYear + i + ",";
                                iFY++;
                            }
                            //n?u là n?m nhu?n
                            if (i % 4 == 0 && i % 100 != 0)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(" [nam nhuan(366 day)]");
                               Console.ResetColor();
                            }
                            //n?u không ph?i là n?m nhu?n
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(" [khong phai nam nhuan(365 day)]");
                               Console.ResetColor();
                            }
                            //lay cac su kien trong file su kien
                            if (Directory.Exists(linkSK) == true)
                            {
                                string[] folders = Directory.GetDirectories(linkSK);
                                foreach (string events in folders)
                                {
                                    //Console.WriteLine(events);
                                    //neu cac su kien co ton tai
                                    if (Directory.Exists(events) == true)
                                    {
                                        //lay du lieu nam cua su kien do
                                        string[] files = Directory.GetFiles(events);
                                        foreach (string file in files)
                                        {
                                            //lay du kien nan xay ra
                                            string[] year = File.ReadAllLines(file);
                                            foreach (string lines in year)
                                            {
                                                try
                                                {
                                                    namDienRaSuKien = int.Parse(lines);
                                                }
                                                catch
                                                {
                                                    namDienRaSuKien = 0;
                                                }
                                            }
                                            //neu nam trong thu muc co su kien bang nam hien tai
                                            if (namDienRaSuKien == i)
                                            {
                                                //lay du lieu nam cua su kien do
                                                string[] fileSuKien = Directory.GetFiles(events);
                                                foreach (string filesSuKien in fileSuKien)
                                                {
                                                    //hien su kien cua nam co su kien
                                                    Console.Write(" ");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    //doc du lieu tu file su kien
                                                    string[] SuKien = File.ReadAllLines(filesSuKien);
                                                    foreach (string sk in SuKien)
                                                    {
                                                        Console.Write(sk + " |");
                                                    }
                                                   Console.ResetColor();
                                                }
                                            }
                                        }
                                    }
                                }
                                //xuong dong cho thong tin
                                Console.WriteLine();
                            }
                        }
                        if (i == year2)
                        {
                            break;
                        }
                    }
                    if (year1 != year2)
                    {
                        Console.WriteLine("-DANG HIEN THI THONG TIN {0} NAM. TIM THAY {1} NAM {2} ({3})", demNam - 1, iFY, findYear, fYear);
                        //tao su kien moi
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("BAN CO MUON THEM SU KIEN MOI? [Y][N][E]");
                       Console.ResetColor();
                        char.TryParse(Console.ReadLine(), out yn);
                        if (yn == 'Y' || yn == 'y')
                        {
                            Console.Write("GHI NAM DE THEM SU KIEN: ");
                            int.TryParse(Console.ReadLine(), out namThemSuKien);
                            //neu nam dien ra su kien lon hon 0
                            if (namThemSuKien > 0)
                            {
                                //neu nam dien ra su kien da co su kien
                                if (Directory.Exists(linkSK + "\\" + namThemSuKien) == true)
                                {
                                    //thong bao cho nguoi dung
                                    Console.WriteLine("NAM {0} DA DUOC THEM TU TRUOC, BAN CO MUON GHI THEM SU KIEN CHO NAM {1} [Y][N]", namThemSuKien, namThemSuKien);
                                    char.TryParse(Console.ReadLine(), out yn);
                                    if (yn == 'Y' || yn == 'y')
                                    {
                                        //neu file su kien khong ton tai
                                        if (File.Exists(linkSK + "\\" + namThemSuKien + "\\" + namThemSuKien) == false)
                                        {
                                            //tao file su kien moi
                                            FileStream fileNew = new FileStream(linkSK + "\\" + namThemSuKien + "\\" + namThemSuKien, FileMode.Create);
                                            fileNew.Close();
                                        }
                                        //neu file su kien da ton tai
                                        if (File.Exists(linkSK + "\\" + namThemSuKien + "\\" + namThemSuKien) == true)
                                        {
                                            //ghi su kien moi                                    
                                            Console.Write("GHI SU KIEN MOI: ");
                                            tenSuKien = Console.ReadLine();
                                            if (tenSuKien != "")
                                            {
                                                TextWriter textSKMoi = new StreamWriter(linkSK + "\\" + namThemSuKien + "\\" + namThemSuKien, true);
                                                textSKMoi.WriteLine(" " + tenSuKien);
                                                textSKMoi.Close();
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("SU KIEN MOI DA DUOC THEM :D");
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("SU KIEN MOI KHONG DUOC BO TRONG! TIEN HANH XOA DU LIEU SU KIEN NAM...");
                                                Directory.Delete(linkSK + "\\" + namThemSuKien, true);
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("HUY THEM SU KIEN NAM {0}!", namThemSuKien);
                                    }
                                    //dieu kien de if o duoi khong hoat dong
                                    num1 = 1;
                                }
                                //neu nam dien ra su kien chua ton tai, tao thu muc chua su kien
                                if (Directory.Exists(linkSK + "\\" + namThemSuKien) == false && num1 == 0)
                                {
                                    DirectoryInfo newFolder = new DirectoryInfo(linkSK + "\\" + namThemSuKien);
                                    newFolder.Create();
                                    //tao file nam su kien
                                    FileStream yearSK = new FileStream(linkSK + "\\" + namThemSuKien + "\\year", FileMode.Create);
                                    yearSK.Close();
                                    //ghi nam dien ra su kien vao file nam su kien
                                    TextWriter textNamSK = new StreamWriter(linkSK + "\\" + namThemSuKien + "\\year", false);
                                    textNamSK.WriteLine(namThemSuKien);
                                    textNamSK.Close();
                                    //them su kien moi
                                    //ghi su kien moi                                    
                                    Console.Write("GHI SU KIEN MOI: ");
                                    tenSuKien = Console.ReadLine();
                                    if (tenSuKien != "")
                                    {
                                        TextWriter textSKMoi = new StreamWriter(linkSK + "\\" + namThemSuKien + "\\" + namThemSuKien, true);
                                        textSKMoi.WriteLine(tenSuKien);
                                        textSKMoi.Close();
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("SU KIEN MOI DA DUOC THEM :D");
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("SU KIEN MOI KHONG DUOC BO TRONG! TIEN HANH XOA DU LIEU SU KIEN NAM...");
                                        Directory.Delete(linkSK + "\\" + namThemSuKien, true);
                                    }
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("KHONG TIM THAY NAM DIEN RA SU KIEN!");
                                Console.ReadKey();
                            }
                        }

                    }
                }
            } while (yn != 'e' && yn != 'E');
        }
        /// <summary>
        /// tao bang moi
        /// </summary>
        /// <param name="link"></param>
        /// <param name="page"></param>
        /// <param name="nameTable"></param>

        public static void CreateTable(string link, string page, string nameTable)
        {
            string str = "";
            //neu duong dan khac rong
            if (link != "")
            {
                HelpTTL ttl = new HelpTTL();
                //neu ten bang khac rong
                if (nameTable != "")
                {
                    str = ttl.Loc1KyTu(nameTable, "createtable");
                    if (str.Replace(" ", "") != "" && Directory.Exists(link + "\\Table\\" + page + "\\" + str + "\\") == false)
                    {
                        // tao thu muc
                        ttl.TaoThuMuc(link + "\\Table\\" + page + "\\" + str + "\\");
                        // tao fle
                        ttl.TaoFile(link + "\\Table\\" + page + "\\" + str + "\\name.ttl");
                        ttl.TaoFile(link + "\\Table\\" + page + "\\" + str + "\\" + str + ".ttl");
                        // ghi du lieu vao file
                        ttl.GhiDuLieuVaoFile(link + "\\Table\\" + page + "\\" + str + "\\name.ttl",str,true);

                        //thông báo n?u t?o b?ng thành công
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("BANG [{0}] DA DUOC TAO :D", str);
                        Console.ReadKey();
                    }
                }
            }
            else
            {
                //neu duong dan khong ton tai
                Console.WriteLine("KHONG TIM THAY DUONG DAN!");
                Console.ReadKey();
            }
        }
        //color table
        public static string TableColor(string link, string str)
        {
            string color = "";
            HelpTTL ttl = new HelpTTL();
            str = ttl.Loc1KyTu(str, "color");
            //n?u file ch?a kh?i t?o th? b?t ??u kh?i t?o
            ttl.TaoFile(link + "/color.ttl");
            if (str.Replace(" ", "") != "" && link != "")
            {
                //ghi du lieu vao file mau sac
                ttl.GhiDuLieuVaoFile(link + "/color.ttl", str.ToLower().Replace(" ", ""), true);
            }
            color = ttl.LayDuLieuTrongFile1(link + "/color.ttl");
            return color;
        }
        /// <summary>
        /// them mat khau cho trang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="data"></param>
        /// <param name="page"></param>
        public static void AddPassword(string link, string data, string page)
        {
            string str = "";
            string maXacNhan = "";
            int num = 0;
            string linkHide = "";
            string linkHide1 = "";
            string b = "";
            string c = link;
            b = link + "/Table/" + page;
            //neu duong dan khac rong
            if (link != "" && data != "")
            {
                HelpTTL ttl = new HelpTTL();
                //loc ky tu
                str = ttl.Loc1KyTu(data, "addpassword");
                //tao dia chi ghi file an link
                linkHide = link + "/SettingLink.bat";
                linkHide1 = link + "/SettingLink1.bat";
                //kiem tra phai moi da ton tai chua
                link = link + "/Table/" + page + "/p.ttl";
                //neu duong dan da ton tai, doi mat khau cu
                if (File.Exists(link) == true && str.Replace(" ", "") != "" && num == 0)
                {
                    //tao file
                    FileStream fileHide = new FileStream(linkHide1, FileMode.Create);
                    fileHide.Close();
                    //ghi du lieu vao file
                    TextWriter textFileHide = new StreamWriter(linkHide1, true);
                    textFileHide.WriteLine("@echo off");
                    textFileHide.WriteLine("cd " + b);
                    textFileHide.WriteLine("attrib -s -h -r p.ttl");
                    textFileHide.Close();
                    //chay file an link
                    // System.Diagnostics.Process p = new System.Diagnostics.Process();
                    // p.StartInfo.FileName = linkHide;
                    // p.Start();
                    Process.Start(linkHide1);
                    //ghi ma xac nhan
                    Console.Write("PASSWORD: ");
                    maXacNhan = Console.ReadLine();
                    //lay du lieu mat khau cu
                    string[] password = File.ReadAllLines(link);
                    foreach (string lines in password)
                    {
                        //neu dung mat khau thi tien hanh tao mat khau moi
                        if (maXacNhan == lines)
                        {
                            //hien file
                            TextWriter newMXN = new StreamWriter(link, false);
                            newMXN.WriteLine(str);
                            newMXN.Close();
                            //thong bao cho nguoi dung
                            ttl.HienThiThongBao("PASSWORD..", "DA THIET LAP MAT KHAU MOI.", 1064, c);
                        }
                        //neu nguoi dung nhap sai ma xac nhan
                        if (maXacNhan != lines)
                        {
                            //thong bao cho nguoi dung
                            ttl.HienThiThongBao("PASSWORD..", "SAI MAT KHAU!", 48, c);
                        }
                        //xoa file
                        if (File.Exists(linkHide1) == true)
                        {
                            File.Delete(linkHide1);
                        }
                        //an file
                        //tao file
                        FileStream fileHide1 = new FileStream(linkHide, FileMode.Create);
                        fileHide1.Close();
                        //ghi du lieu vao file
                        TextWriter textFileHide1 = new StreamWriter(linkHide, true);
                        textFileHide1.WriteLine("@echo off");
                        textFileHide1.WriteLine("cd " + b);
                        textFileHide1.WriteLine("attrib +s +h +r p.ttl");
                        textFileHide1.Close();
                        //chay file an link
                        System.Diagnostics.Process p1 = new System.Diagnostics.Process();
                        p1.StartInfo.FileName = linkHide;
                        p1.Start();
                    }
                    num = 1;
                    //neu duong dan link an da ton tai, xoa file               
                }
                //neu duong dan chua ton tai, tao mat khau moi
                if (File.Exists(link) == false && str != "" && num == 0)
                {
                    //neu file duong dan link an chua ton tai
                    if (File.Exists(linkHide) == false)
                    {
                        //an file
                        //tao file
                        FileStream fileHide = new FileStream(linkHide, FileMode.Create);
                        fileHide.Close();
                        //ghi du lieu vao file
                        TextWriter textFileHide = new StreamWriter(linkHide, true);
                        textFileHide.WriteLine("@echo off");
                        textFileHide.WriteLine("cd " + b);
                        textFileHide.WriteLine("attrib +s +h +r p.ttl");
                        textFileHide.Close();
                        //chay file an link
                        System.Diagnostics.Process p = new System.Diagnostics.Process();
                        p.StartInfo.FileName = linkHide;
                        p.Start();
                    }
                    //tao mat khau moi cho trang, tao file
                    FileStream fileNew = new FileStream(link, FileMode.Create);
                    fileNew.Close();
                    //ghi mat khau cho trang
                    TextWriter textNewPassword = new StreamWriter(link, false);
                    textNewPassword.WriteLine(str);
                    textNewPassword.Close();
                    //thong bao cho nguoi dung
                    ttl.HienThiThongBao("PASSWORD..", "<<DA THIET LAP MAT KHAU>>", 1064, c);
                    num = 1;
                }
               Console.ResetColor();

            }
        }
        /// <summary>
        /// pages for table
        /// </summary>
        /// <param name="link"></param>
        public static void Page(string link, string namePage)
        {
            string str = "";
            string b = "";
            string password = "";
            //neu duong dan khac rong
            if (link != "")
            {
                HelpTTL ttl = new HelpTTL();
                b = link + "\\page.ttl";
                //neu ten trang khac rong
                if (namePage != "")
                {
                    //loc ky tu
                    str = ttl.Loc1KyTu(namePage, "openpage");
                    //neu ten trang khac rong
                    if (str.Replace(" ", "") != "")
                    {
                        //neu trang co ton tai va khong can mat khau
                        if (Directory.Exists(link + "\\Table\\" + str + "\\") == true && File.Exists(link + "\\Table\\" + str + "\\p.ttl") == false)
                        {
                            //hien thi thong bao
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DANG MO TRANG [{0}]... :D", str);
                            //ghi ten trang vao file page
                            //neu file trang da ton tai, ghi ten trang dang hien thi vao file
                            if (File.Exists(b) == true)
                            {
                                TextWriter newPage = new StreamWriter(b, false);
                                newPage.WriteLine(str);
                                newPage.Close();
                            }
                            //neu file trang chua ton tai
                            if (File.Exists(b) == false)
                            {
                                //tao file trang 
                                FileStream filePage = new FileStream(b, FileMode.Create);
                                filePage.Close();
                                //ghi du lieu vao file la trang chinh
                                TextWriter newPage = new StreamWriter(b, false);
                                newPage.WriteLine("main");
                                newPage.Close();
                            }
                            Console.ReadKey();
                        }
                        //neu trang co ton tai va can mat khau
                        if (Directory.Exists(link + "\\Table\\" + str + "\\") == true && File.Exists(link + "\\Table\\" + str + "\\p.ttl") == true)
                        {
                            //can nhap mat khau de vao trang
                            Console.Write("PASSWORD: ");
                            password = Console.ReadLine();
                            //kiem tra mat khau, doc du lieu mat khau trong file
                            string[] filePassword = File.ReadAllLines(link + "\\Table\\" + str + "\\p.ttl");
                            foreach (string pass in filePassword)
                            {
                                //neu mat khau chinh xac
                                if (password == pass)
                                {
                                    //tien hanh mo trang
                                    //hien thi thong bao
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("DANG MO TRANG [{0}]... :D", str);
                                    //ghi ten trang vao file page
                                    //neu file trang da ton tai, ghi ten trang dang hien thi vao file
                                    if (File.Exists(b) == true)
                                    {
                                        TextWriter newPage = new StreamWriter(b, false);
                                        newPage.WriteLine(str);
                                        newPage.Close();
                                    }
                                    //neu file trang chua ton tai
                                    if (File.Exists(b) == false)
                                    {
                                        //tao file trang 
                                        FileStream filePage = new FileStream(b, FileMode.Create);
                                        filePage.Close();
                                        //ghi du lieu vao file la trang chinh
                                        TextWriter newPage = new StreamWriter(b, false);
                                        newPage.WriteLine("main");
                                        newPage.Close();
                                    }
                                    Console.ReadKey();
                                }
                                //neu mat khau khong chinh xac
                                if (password != pass)
                                {
                                    ttl.HienThiThongBao("PASSWORD!", "MAT KHAU KHONG DUNG!", 16, link);
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// them trang moi
        /// </summary>
        /// <param name="link"></param>
        public static void NewPage(string link, string namePage)
        {
            string str = "";
            //neu duong dan khac rong
            if (link != "" && namePage != "")
            {
                HelpTTL ttl = new HelpTTL();
                //loc ky tu
                str = ttl.Loc1KyTu(namePage, "addpage");
                //kiem tra phai moi da ton tai chua
                link = link + "\\Table\\" + str + "\\";
                //neu trang da ton tai
                if (Directory.Exists(link) == true && str.Replace(" ", "") != "")
                {
                    //thong bao cho nguoi dung biet trang da duoc tao
                    ttl.HienThiThongBao("PAGE!", "TRANG '" + str + "' DA TON TAI!", 64, link);
                }
                //neu trang chua ton tai
                if (Directory.Exists(link) == false && str != "")
                {
                    //tao trang moi
                    DirectoryInfo newFolder = new DirectoryInfo(link);
                    newFolder.Create();
                    //thong bao cho nguoi dung biet trang da duoc tao
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("TRANG {0} DA DUOC TAO :D", str);
                    Console.ReadKey();
                }
            }
        }
        /// <summary>
        /// xoa trang
        /// </summary>
        /// <param name="link"></param>
        public static void DeletePage(string link, string namePage)
        {
            string str = "";
            string maXacNhan = "";
            string linkHide = "";
            string b = link;
            //neu duong dan khac rong
            if (link != "" && namePage != "")
            {
                HelpTTL ttl = new HelpTTL();
                //loc ky tu
                str = ttl.Loc1KyTu(namePage, "deletepage");
                linkHide = link;
                //kiem tra phai moi da ton tai chua
                link = link + "\\Table\\" + str + "\\";
                //neu trang da ton tai, xoa trang
                if (Directory.Exists(link) == true && str.Replace(" ", "") != "")
                {
                    //neu trang khong co mat khau
                    if (File.Exists(link + "p.ttl") == false)
                    {
                        Directory.Delete(link, true);
                        //thong bao cho nguoi dung biet trang da duoc tao
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("DA XOA TRANG {0} :D", str);
                        Console.ReadKey();
                    }
                    //neu trang co mat khau
                    if (File.Exists(link + "p.ttl") == true)
                    {
                        //tao file mo cac file an
                        FileStream fileNew = new FileStream(link + "attributes.bat", FileMode.Create);
                        fileNew.Close();
                        TextWriter text = new StreamWriter(link + "attributes.bat", true);
                        text.WriteLine("@echo off");
                        text.WriteLine("cd " + link);
                        text.WriteLine("attrib -s -h -r p.ttl");
                        text.Close();
                        //chay file
                        Process.Start(link + "attributes.bat");
                        //nhap lai mat khau
                        Console.Write("PASSWORD: ");
                        maXacNhan = Console.ReadLine();
                        //kiem tra ma xac nhan
                        string[] fileP = File.ReadAllLines(link + "p.ttl");
                        foreach (string code in fileP)
                        {
                            //neu nhap dung ma xac nhan
                            if (maXacNhan == code)
                            {
                                //xoa du lieu trang
                                Directory.Delete(link, true);
                                //thong bao cho nguoi dung biet trang da duoc tao
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("DA XOA TRANG {0} :D", str);
                                Console.ReadKey();
                            }
                            //neu nhap sai ma xac nhan
                            if (maXacNhan != code)
                            {
                                //thong bao cho nguoi dung
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("MA XAC NHAN KHONG DUNG!");
                                Console.ReadKey();
                                //xoa file
                                File.Delete(link + "attributes.bat");
                                //an file
                                FileStream fileNew1 = new FileStream(linkHide + "attributes.bat", FileMode.Create);
                                fileNew1.Close();
                                TextWriter text1 = new StreamWriter(linkHide + "attributes.bat", true);
                                text1.WriteLine("@echo off");
                                text1.WriteLine("cd " + link);
                                text1.WriteLine("attrib +s +h +r p.ttl");
                                text1.Close();
                                Process.Start(linkHide + "attributes.bat");
                            }
                        }
                    }
                    // xoa file
                    File.Delete(b + "/attributes.bat");
                }
                //neu trang chua ton tai
                if (Directory.Exists(link) == false && str.Replace(" ", "") != "")
                {
                    //thong bao cho nguoi dung biet trang da duoc tao
                    ttl.HienThiThongBao("PAGE!", "KHONG TIM THAY TRANG '" + str + "'.", 64, link);
                }
            }
        }
        /// <summary>
        /// hien thi so trang dang co
        /// </summary>
        /// <param name="link"></param>
        public static void Pages(string link, string page)
        {
            int num = 0;
            string b = "";
           Console.ResetColor();
            int dem = 0;
            if (link != "" && Directory.Exists(link + "\\Table\\") == true)
            {
                HelpTTL ttl = new HelpTTL();
                //do so trang hien dang co trong thu muc
                string[] folder = Directory.GetDirectories(link + "\\Table\\");
                foreach (string folders in folder)
                {
                    b = "";
                    dem++;
                    b = link + "\\Table\\" + page;
                    //so sanh duong dan b voi duong dan hien tai
                    if (b == folders)
                    {
                        num = dem;
                    }
                    //Console.WriteLine(b);
                    //Console.WriteLine(folders);
                }
                //neu trong thu muc co thu muc
                if (dem > 0)
                {
                    Console.Write("|");
                    ttl.ShowFileWithSpace(dem, 10, 10, num, page);
                    Console.Write("|");
                }
            }
            Console.WriteLine();
        }
        /// <summary>
        /// canh le cho bang
        /// </summary>
        /// <param name="link"></param>
        public static void LineTable(string link, string numTable)
        {
            string str = "";
            int numCanhBang = 0;
            //neu duong dan khac rong
            if (link != "" && numTable != "")
            {
                link = link + "\\NumLineTable.ttl";
                HelpTTL ttl = new HelpTTL();
                //loc ky tu
                str = ttl.Loc1KyTu(numTable, "sot");
                //neu chu 1 khac rong 
                if (str != "")
                {
                    //chuyen doi so lieu
                    numCanhBang = int.Parse(str);
                }
                //neu co so canh bang
                if (numCanhBang != 0)
                {
                    //tao file canh bang
                    //neu file canh bang chua ton tai
                    if (File.Exists(link) == false)
                    {
                        //tao file canh bang
                        FileStream fileNew = new FileStream(link, FileMode.Create);
                        fileNew.Close();
                    }
                    //neu file canh bang co ton tai
                    if (File.Exists(link) == true)
                    {
                        //ghi so canh bang
                        TextWriter textNumCanhBang = new StreamWriter(link, false);
                        textNumCanhBang.WriteLine(str);
                        textNumCanhBang.Close();
                        //thong bao cho nguoi dung
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("KHOANG CACH TRANG {0}", numCanhBang);
                    }
                }

            }
        }
        // ẩn thong tin bảng trong trang
        public static void HideTable(string link, string page, string data)
        {
            string str = "";
            //neu duong dan khac rong
            if (link != "" && data != "")
            {
                HelpTTL ttl = new HelpTTL();
                //loc ky tu
                str = ttl.Loc2KyTu(data, "ht", "hidetable");
                // nếu bảng có tồn tại
                if (Directory.Exists(link + "Table/" + page + "/" + str) == true && str.Replace(" ", "") != "")
                {
                    // tạo file trong bảng
                    if (File.Exists(link + "Table/" + page + "/" + str + "/HideTable") == false)
                    {
                        FileStream fN = new FileStream(link + "Table/" + page + "/" + str + "/HideTable", FileMode.Create);
                        fN.Close();
                    }
                    // nếu file ẩn bảng đã tồn tại
                    if (File.Exists(link + "Table/" + page + "/" + str + "/HideTable") == true)
                    {
                        //  ghi dữ liệu vào file
                        TextWriter tx = new StreamWriter(link + "Table/" + page + "/" + str + "/HideTable", false);
                        tx.WriteLine(DateTime.Now);
                        tx.Close();
                    }
                }
            }
        }
        // hien thong tin bảng trong trang
        public static void ShowTable(string link, string page, string data)
        {
            string str = "";
            //neu duong dan khac rong
            if (link != "" && data != "")
            {
                //loc ky tu
                HelpTTL ttl = new HelpTTL();
                //loc ky tu
                str = ttl.Loc2KyTu(data, "st", "showtable");
                // nếu bảng có tồn tại
                if (Directory.Exists(link + "Table/" + page + "/" + str) == true && str.Replace(" ", "") != "")
                {
                    // nếu file ẩn bảng đã tồn tại
                    if (File.Exists(link + "Table/" + page + "/" + str + "/HideTable") == true)
                    {
                        //  xoa file an bang
                        File.Delete(link + "Table/" + page + "/" + str + "/HideTable");
                    }
                }
            }
        }
        /// <summary>
        /// hien thi bang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="dataUser"></param>
        /// <param name="colorTable"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public static string WallData(string link, string dataUser, string colorTable, string page)
        {
            int num = 0;
            int max = 0;
            int num1 = 0;
            int numNull = 0;
            int times = 0;
            int canhGiua = 0;
            int numLineTable = 0;
            string b = "";
            string nameTable = "";
            string linkInformationTable = "";
            string linkNumTable = "";
            int demPin = 0;
            string linkFind = "";
            HelpTTL ttl = new HelpTTL();
            //neu duong dan khac rong
            if (link != "")
            {
                linkNumTable = link + "\\NumLineTable.ttl";
                //neu duong dan ton tai
                if (File.Exists(linkNumTable) == true)
                {
                    //lay so canh bang
                    string[] fileNumLineTable = File.ReadAllLines(linkNumTable);
                    foreach (string numLTB in fileNumLineTable)
                    {
                        numLineTable = int.Parse(numLTB);
                    }
                }
            }
            //kiem tra trang dang hien thi
            if (File.Exists(link + "\\page.ttl") == true)
            {
                //lay du lieu ten trang dang hien thi
                string[] filePage = File.ReadAllLines(link + "\\page.ttl");
                foreach (string linePage in filePage)
                {
                    page = linePage;
                }
            }
            linkFind = link + "/Table/";
            b = link + "\\PinTable.ttl";
            link = link + "\\Table\\" + page + "\\";
            try
            {
                //n?u file không t?n t?i
                if (File.Exists(b) == false)
                {
                    FileStream file = new FileStream(b, FileMode.Create);
                    file.Close();
                }
                string[] findLinkTable = Directory.GetDirectories(link);
                foreach (string linkTable in findLinkTable)
                {
                    //??m pin
                    demPin++;
                    // hien thi ten bang neu do la bang an
                    if (File.Exists(linkTable + "/HideTable") == true && File.Exists(linkTable + "/name.ttl") == true)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        string[] nT = File.ReadAllLines(linkTable + "/name.ttl");
                        foreach (string nameTableHide in nT)
                        {
                            // ve khoang cach cho ten bang
                            // for(int i = 0;i <= numLineTable / 2;i++){
                            //     Console.Write("-");
                            // }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[" + demPin + "]");
                           Console.ResetColor();
                            Console.Write(nameTableHide + " ");
                        }
                       Console.ResetColor();
                    }
                    //n?u th? m?c có t?n t?i
                    if (Directory.Exists(linkTable) == true && File.Exists(linkTable + "/HideTable") == false)
                    {
                        string[] findTable = Directory.GetFiles(linkTable);
                        foreach (string tables in findTable)
                        {
                            if (tables != linkTable + "\\name.ttl")
                            {
                                linkInformationTable = tables;
                            }

                        }
                        //n?u file không t?n t?i
                        if (File.Exists(linkTable + "\\name.ttl") == false)
                        {
                            nameTable = linkInformationTable;
                        }
                        //n?u file có t?n t?i
                        if (File.Exists(linkTable + "\\name.ttl") == true)
                        {
                            string[] name = File.ReadAllLines(linkTable + "\\name.ttl");
                            foreach (string nameT in name)
                            {
                                //màu
                                ttl.ColorTTL(colorTable);
                                nameTable = nameT;
                                //t?o ?ánh d?u cho b?ng
                                Console.WriteLine();
                                string[] danhDau = File.ReadAllLines(b);
                                foreach (string line in danhDau)
                                {
                                    if (nameTable == line)
                                    {
                                        if (max <= numLineTable)
                                        {
                                            //canh giua cho bang
                                            canhGiua = numLineTable - max;
                                            canhGiua = canhGiua / 2;
                                            for (int cg = 0; cg <= canhGiua; cg++)
                                            {
                                                Console.Write("=");
                                            }
                                        }
                                        Console.WriteLine("\\ ");
                                        for (int cg = 0; cg <= canhGiua; cg++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write("|");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("[{0}]", demPin);
                                       Console.ResetColor();
                                    }
                                }
                            }
                        }
                        string[] lineTable = File.ReadAllLines(linkInformationTable);
                        //ki?m tra giá tr? max trong tên c?a b?ng
                        foreach (char ch in nameTable)
                        {
                            num1++;
                            if (num1 > max)
                            {
                                max = num1;
                            }
                        }
                        do
                        {
                            //th?c hi?n tên c?a b?ng sau 1 l?n
                            if (times == 1)
                            {
                                //canh gi?a cho b?ng
                                if (max <= numLineTable)
                                {
                                    canhGiua = numLineTable - max;
                                    canhGiua = canhGiua / 2;
                                    for (int cg = 0; cg <= canhGiua; cg++)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("|");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                                Console.Write(nameTable);
                                //t?o kho?ng tr?ng
                                for (int i = 0; i < max - num1; i++)
                                {
                                    Console.Write(" ");
                                }
                                //ch?n màu cho b?ng
                                if (numNull == 0)
                                {
                                    //n?u d? li?u r?ng
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
                                if (numNull != 0)
                                {
                                    //màu
                                    ttl.ColorTTL(colorTable);
                                }
                                Console.Write("|");
                                //?i?u ki?n canh ??
                                if (max != 78)
                                {
                                    Console.WriteLine();
                                }
                            }
                            foreach (string dataTable in lineTable)
                            {
                                numNull++;
                                num = 0;
                                //t?m giá tr? l?n nh?t trong d?ng
                                foreach (char ch in dataTable)
                                {
                                    num++;
                                    if (num > max)
                                    {
                                        max = num;
                                    }
                                }
                                //th?c hi?n thông tin c?a b?ng sau 2 l?n
                                if (times == 2)
                                {
                                    //canh gi?a cho b?ng
                                    if (max <= numLineTable)
                                    {
                                        canhGiua = numLineTable - max;
                                        canhGiua = canhGiua / 2;
                                        for (int cg = 0; cg <= canhGiua; cg++)
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                    Console.Write("|");
                                   Console.ResetColor();
                                    if (colorTable == "0")
                                    {
                                        Console.BackgroundColor = ConsoleColor.White;
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.Write(dataTable);
                                    if (colorTable == "0")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                    }
                                    //màu
                                    ttl.ColorTTL(colorTable);
                                    if (num == max)
                                    {
                                        Console.Write("");
                                    }
                                    //t?o kho?ng tr?ng 
                                    for (int i = 0; i < max - num; i++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write("|");
                                    //?i?u ki?n canh ??
                                    if (max != 78)
                                    {
                                        Console.WriteLine();
                                    }
                                }
                            }
                            ////ch?n màu cho b?ng
                            if (numNull == 0)
                            {
                                //n?u d? li?u r?ng
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            if (numNull != 0)
                            {
                                //màu
                                ttl.ColorTTL(colorTable);
                            }
                            //canh gi?a cho b?ng
                            if (max <= numLineTable)
                            {
                                canhGiua = numLineTable - max;
                                canhGiua = canhGiua / 2;
                                for (int cg = 0; cg <= canhGiua; cg++)
                                {
                                    Console.Write(" ");
                                }
                            }
                            //th?c hi?n t?o ???ng ngang d?a trên s? max
                            //th?c hi?n t?o ???ng ngang d?a trên s? max
                            if (times == 0)
                            {
                                Console.Write(" ");
                            }
                            if (times == 1)
                            {
                                Console.Write("|");
                            }
                            if (times == 2)
                            {
                                Console.Write("|");
                            }
                            for (int i = 0; i < max; i++)
                            {

                                if (times == 1)
                                {
                                    Console.Write("-");
                                }
                                else
                                {
                                    Console.Write("_");
                                }
                            }
                            if (times == 0)
                            {
                                Console.Write("");
                            }
                            if (times == 1)
                            {
                                Console.Write("|");
                            }
                            if (times == 2)
                            {
                                Console.Write("|");
                            }
                            Console.WriteLine();
                            times++;
                        } while (times < 3);

                        //thi?t l?p giá tr? ban ??u
                        num = 0;
                        num1 = 0;
                        max = 0;
                        times = 0;
                        canhGiua = 0;
                        numNull = 0;
                        //t?o ?ánh d?u cho b?ng
                        string[] danhDau1 = File.ReadAllLines(b);
                        foreach (string line in danhDau1)
                        {
                            //màu
                            ttl.ColorTTL(colorTable);
                            if (nameTable == line)
                            {
                                if (max <= numLineTable)
                                {
                                    canhGiua = numLineTable - max;
                                    canhGiua = canhGiua / 2;
                                    for (int cg = 0; cg <= canhGiua; cg++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.WriteLine("|");
                                    for (int cg = 0; cg <= canhGiua; cg++)
                                    {
                                        Console.Write("=");
                                    }
                                    Console.WriteLine("/");
                                }
                            }
                        }
                    }
                }
                demPin = 0;
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
            return page;
        }
        /// <summary>
        /// danh dau bang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="page"></param>
        /// <param name="nameTable"></param>
        public static void PinTable(string link, string page, string nameTable)
        {
            string str = "";
            string linkXacNhanBang = "";
            string b = "";
            //neu duong dan khac rong
            if (link != "")
            {
                b = link;
                link = link + "\\PinTable.ttl";
                //neu ten bang khac rong
                if (nameTable != "")
                {
                    //loc ky tu
                    HelpTTL ttl = new HelpTTL();
                    str = ttl.Loc2KyTu(nameTable, "pt", "pintable");
                    //n?u file không t?n t?i
                    if (File.Exists(link) == false)
                    {
                        FileStream file = new FileStream(link, FileMode.Create);
                        file.Close();
                    }
                    //neu ten bang khac rong
                    if (str.Replace(" ", "") != "")
                    {
                        linkXacNhanBang = b + "\\Table\\" + page + "\\" + str;
                        //neu bang co ton tai
                        if (Directory.Exists(linkXacNhanBang) == true)
                        {
                            //ghi ten bang vao file
                            TextWriter textNameTablePin = new StreamWriter(link, true);
                            textNameTablePin.WriteLine(str);
                            textNameTablePin.Close();
                            //thong bao cho nguoi dung
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DA PIN BANG [{0}]", str);
                            Console.ReadKey();
                            //copy bang ra trang main
                            DirectoryInfo sourceDircetory = new DirectoryInfo(linkXacNhanBang);
                            DirectoryInfo targetDircetory = new DirectoryInfo(b + "\\Table\\main\\" + str);
                            CopyAll(sourceDircetory, targetDircetory);
                        }
                        //neu bang khong ton tai
                        if (Directory.Exists(linkXacNhanBang) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("KHONG TON TAI BANG [{0}]!", str);
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// danh dau bang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="page"></param>
        /// <param name="nameTable"></param>
        public static void DeletePinTable(string link, string page, string nameTable)
        {
            string str = "";
            string linkXacNhanBang = "";
            string b = "";
            string link1 = "";
            //neu duong dan khac rong
            if (link != "")
            {
                b = link;
                link1 = link + "\\PinTable1.ttl";
                link = link + "\\PinTable.ttl";
                //neu ten bang khac rong
                if (nameTable != "")
                {
                    // loc ky tu
                    HelpTTL ttl = new HelpTTL();
                    str = ttl.Loc2KyTu(nameTable, "dpt", "deletepintable");
                    //n?u file không t?n t?i
                    ttl.TaoFile(link);
                    //neu ten bang khac rong
                    if (str.Replace(" ", "") != "")
                    {
                        linkXacNhanBang = b + "\\Table\\" + page + "\\" + str;
                        //neu bang co ton tai
                        if (Directory.Exists(linkXacNhanBang) == true)
                        {
                            if (Directory.Exists(b + "\\Table\\main\\" + str) == true)
                                //xoa b?ng ? trang chính
                                Directory.Delete(b + "\\Table\\main\\" + str, true);
                            //neu file pin table moi da ton tai
                            if (File.Exists(link1) == true)
                                File.Delete(link1);
                            //t?o file m?i
                            FileStream fn = new FileStream(link1, FileMode.Create);
                            fn.Close();
                            TextWriter tx = new StreamWriter(link1, true);
                            //doc d? li?u t? file cu
                            string[] fileOld = File.ReadAllLines(link);
                            foreach (string lines in fileOld)
                            {
                                if (lines != str)
                                    tx.WriteLine(lines);
                            }
                            tx.Close();
                            //xoa file cu
                            File.Delete(link);
                            //d?i tên file m?i thành file cu
                            File.Move(link1, link);

                        }
                        //neu bang khong ton tai
                        if (Directory.Exists(linkXacNhanBang) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("KHONG TON TAI BANG [{0}]!", str);
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// kiem tra nguoi dung dang goi ten bang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="checkNameTable"></param>
        /// <param name="page"></param>
        public static void CheckTable(string link, string checkNameTable, string page)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            link = link + "/Table\\" + page + "\\" + checkNameTable + "\\";
            string writeTable = "";
            //n?u b?ng có t?n t?i
            if (Directory.Exists(link) == true && checkNameTable != "")
            {
                //thông báo cho ng??i dùng
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("The Table [{0}] Is Open Now: ", checkNameTable);
                writeTable = Console.ReadLine();
                if (writeTable != "")
                {
                    //nh?p n?i dung m?i
                    TextWriter file = new StreamWriter(link + "\\" + checkNameTable + ".ttl", true);
                    file.WriteLine(writeTable);
                    file.Close();
                }

            }
        }
        /// <summary>
        /// doi ten bang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="nameTable"></param>
        public static void ChangeName(string link, string page, string nameTable)
        {
            string str = "";
            string newName = "";
            //neu duong dan khac rong
            if (link != "" && nameTable != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(nameTable, "cnt", "changenametable");
                link = link + "\\Table\\" + page + "\\";
                //neu bang co ton tai
                if (Directory.Exists(link + str) == true && str.Replace(" ", "") != "")
                {
                    Console.Write("NEW NAME FOR TABLE [{0}]: ", str);
                    newName = Console.ReadLine();
                    newName = newName.ToLower();
                    newName = newName.Replace(" ", "");
                    if (newName != "")
                    {
                        //t?o th? m?c v?i tên m?i
                        DirectoryInfo folder = new DirectoryInfo(link + "\\" + newName + "\\");
                        folder.Create();
                        //sao chép d? li?u qua file t?m
                        string[] fileTrongThuMuc = Directory.GetFiles(link + str);
                        foreach (string files in fileTrongThuMuc)
                        {
                            //n?u file ?ó không ph?i file tên
                            if (files != link + str + "\\name.ttl")
                            {
                                FileStream fileNew = new FileStream(link + "copy.ttl", FileMode.Create);
                                fileNew.Close();
                                TextWriter textCopy = new StreamWriter(link + "copy.ttl", true);
                                string[] thongTin = File.ReadAllLines(files);
                                foreach (string lines in thongTin)
                                {
                                    textCopy.WriteLine(lines);
                                }
                                textCopy.Close();
                            }
                        }
                        //t?o file thông tin v?i tên m?i
                        FileStream file = new FileStream(link + newName + "\\" + newName + ".ttl", FileMode.Create);
                        file.Close();
                        //sao chép d? li?u m?i vào file
                        TextWriter textNewData = new StreamWriter(link + newName + "\\" + newName + ".ttl", true);
                        string[] newData = File.ReadAllLines(link + "copy.ttl");
                        foreach (string linesNew in newData)
                        {
                            textNewData.WriteLine(linesNew);
                        }
                        textNewData.Close();
                        //t?o file tên v?i tên m?i
                        FileStream fileName = new FileStream(link + newName + "\\name.ttl", FileMode.Create);
                        fileName.Close();
                        TextWriter text = new StreamWriter(link + newName + "\\name.ttl", false);
                        text.WriteLine(newName);
                        text.Close();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("DA DOI TEN BANG THANH CONG..");
                        //xóa th? m?c c?
                        Directory.Delete(link + str, true);
                        //xóa file copy
                        if (File.Exists(link + "copy.ttl") == true)
                        {
                            FileInfo fileD = new FileInfo(link + "copy.ttl");
                            fileD.Delete();
                        }
                        Console.ReadKey();
                    }
                    if (Directory.Exists(link + str) == false && str.Replace(" ", "") == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("TEN BANG KHONG DUOC BO TRONG!");
                        Console.ReadKey();
                    }
                }
            }

        }
        /// <summary>
        /// xoa bang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="page"></param>
        /// <param name="nameTable"></param>
        public static void DeleteTable(string link, string page, string nameTable)
        {
            string str = "";
            //neu duong dan khac rong
            if (link != "")
            {
                //neu ten bang khac rong
                if (nameTable != "")
                {
                    // loc ky tu
                    HelpTTL ttl = new HelpTTL();
                    str = ttl.Loc2KyTu(nameTable, "dt", "deletetable");
                }
                //neu ten bang khac rong
                if (str.Replace(" ", "") != "")
                {
                    link = link + "\\Table\\" + page + "\\" + str + "\\";
                    //neu bang khong ton tai
                    if (Directory.Exists(link) == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("KHONG TIM THAY BANG {0}!", str);
                        Console.ReadKey();
                    }
                    //neu bang co ton tai
                    if (Directory.Exists(link) == true)
                    {
                        Directory.Delete(link, true);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("DA XOA!");
                        Console.ReadKey();
                    }
                }
            }
        }
        /// <summary>
        /// them bang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="page"></param>
        public static void AddTable(string link, string page)
        {
            string dataTable = "";
            string nameTable = "";
            link = link + "\\Table\\" + page + "\\";
            try
            {
                //nh?p ???ng d?n d? li?u t? file vào b?ng
                Console.Write("DATA FOR THE TABLE (LINK) IS A FILE: ");
                dataTable = Console.ReadLine();
                if (link != "")
                {
                    //neu duong dan co ton tai
                    if (File.Exists(dataTable) == true)
                    {
                        //nh?p tên b?ng
                        Console.Write("NAME TABLE: ");
                        nameTable = Console.ReadLine();
                        //ki?m tra tên có b? trùng không
                        string[] checkName = Directory.GetDirectories(link);
                        foreach (string linkFolder in checkName)
                        {
                            if (link + nameTable != linkFolder)
                            {
                                //kh?i t?o d? li?u b?ng
                                DirectoryInfo folder = new DirectoryInfo(link + nameTable + "\\");
                                folder.Create();
                                FileStream file = new FileStream(link + nameTable + "\\" + nameTable + ".ttl", FileMode.Create);
                                file.Close();
                                FileStream fileName = new FileStream(link + nameTable + "\\name.ttl", FileMode.Create);
                                fileName.Close();
                                //thêm tên vào b?ng
                                TextWriter name = new StreamWriter(link + nameTable + "\\name.ttl", false);
                                name.WriteLine(nameTable);
                                name.Close();
                                //thêm d? li?u vào b?ng
                                TextWriter line = new StreamWriter(link + nameTable + "\\" + nameTable + ".ttl");
                                string[] data = File.ReadAllLines(dataTable);
                                foreach (string s in data)
                                {
                                    line.WriteLine(s);
                                }
                                line.Close();
                            }
                            if (link + nameTable == linkFolder)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("TRUNG TEN!");
                                Console.ReadKey();
                            }

                        }
                        //thong bao cho nguoi dung
                        if (Directory.Exists(link + nameTable) == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("THEM BANG THANH CONG :D");
                            Console.ReadKey();
                        }
                    }
                    //neu duong dan khong ton tai
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("KHONG TIM THAY DU LIEU... :(");
                        Console.ReadKey();
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
        /// <summary>
        /// hien thi cong viec ngau nhien
        /// </summary>
        /// <param name="link"></param>
        public static void CVNgauNhien(string link)
        {
            //neu duong dan khac rong
            if (link != "")
            {
                //thay doi duong dan
                link = link + "\\Cong Viec Ngau Nhien.ttl";
                //neu duong dan co ton tai
                if (File.Exists(link) == true)
                {
                    //hien thi cong viec trong file
                    string[] file = File.ReadAllLines(link);
                    foreach (string lines in file)
                    {
                        Console.WriteLine("+" + lines);
                    }
                }
            }
        }
        /// <summary>
        /// ghi cong viec ngau nhien
        /// </summary>
        /// <param name="link"></param>
        public static void NgauNhien(string link)
        {
            string randomCV = "";
            //neu duong dan khac rong
            if (link != "")
            {
                //thay doi duong dan
                link = link + "\\Cong Viec Ngau Nhien.ttl";
                FileStream f = new FileStream(link, FileMode.Create);
                f.Close();
                //ghi cong viec ngau nhien vao duong dan
                do
                {
                    //Xoa man hinh
                    Console.Clear();
                    //hien thi cong viec trong file
                    string[] file = File.ReadAllLines(link);
                    foreach (string lines in file)
                    {
                        Console.WriteLine("+" + lines);
                    }
                    Console.Write("GHI CONG VIEC BAN DU DINH LAM: ");
                    randomCV = Console.ReadLine();
                    //neu cong viec du dinh khac rong
                    if (randomCV != "")
                    {
                        //ghi cong viec vao file
                        //neu file chua ton tai
                        if (File.Exists(link) == false)
                        {
                            //tao file moi
                            FileStream fileNew = new FileStream(link, FileMode.Create);
                            fileNew.Close();
                        }
                        //neu file cong viec da ton tai
                        if (File.Exists(link) == true)
                        {
                            //ghi cong viec moi vao file
                            TextWriter textNewCV = new StreamWriter(link, true);
                            if (randomCV.Replace(" ", "").ToLower() != "exit")
                                textNewCV.WriteLine(randomCV);
                            textNewCV.Close();
                            //thong bao cho nguoi dung
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DA CAP NHAT CONG VIEC MOI :D");
                        }
                    }
                    //neu nguoi dung khong nhap gi het
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("CONG VIEC KHONG DUOC DE TRONG!");
                       Console.ResetColor();
                    }
                } while (randomCV.Replace(" ", "").ToLower() != "exit");

            }
            Console.ReadKey();

        }
        /// <summary>
        /// lua chon cong viec ngau nhien
        /// </summary>
        /// <param name="link"></param>
        public static void RandomSelection(string link)
        {
            Random rd = new Random();
            int num = 0;
            int cV = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                //thay doi duong dan
                link = link + "\\Cong Viec Ngau Nhien.ttl";
                //neu thu muc ton tai
                if (File.Exists(link) == true)
                {
                    //lay tong so cong viec trong thu muc
                    string[] file = File.ReadAllLines(link);
                    foreach (string lines in file)
                    {
                        num++;
                    }
                    //neu num lon hon 1
                    if (num > 1)
                    {
                        //chay ngau nhien cong viec tu 1 den 2
                        cV = rd.Next(1, num);
                        num = 0;
                        //lay danh sach cong viec trong file de so sanh
                        string[] file1 = File.ReadAllLines(link);
                        foreach (string lines in file1)
                        {
                            num++;
                            //neu num = cv
                            if (num == cV)
                            {
                                //ghi cong viec ngau nhien da chon vao danh sach
                                TextWriter textCongViecDaChon = new StreamWriter(link, false);
                                textCongViecDaChon.WriteLine("- CONG VIEC [" + lines + "] DA DUOC CHON VAO LUC > " + DateTime.Now);
                                textCongViecDaChon.Close();
                                //THONG BAO CHO NGUOI DUNG
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("DA CHON CONG VIEC CHO BAN :D");
                            }
                        }
                    }
                    //neu num nho hon 1
                    if (num <= 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("CAN NHIEU HON MOT CONG VIEC DE LUA CHON NGAU NHIEN!");
                        //xoa du lieu trong file
                        TextWriter textDelete = new StreamWriter(link);
                        textDelete.Close();
                    }
                }
                //neu thu muc chua ton tai
                if (File.Exists(link) == false)
                {
                    //thong bao cho nguoi dung biet
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("KHONG TIM THAY DANH SACH CONG VIEC! :(");
                }
            }
           Console.ResetColor();
            Console.ReadKey();
        }
        /// <summary>
        /// ghi nhan cong viec dang hoat dong
        /// </summary>
        /// <param name="link"></param>
        public static void Starup(string link)
        {
            // phuong thuc tro giup
            HelpTTL ttl = new HelpTTL();
            // tao file
            ttl.TaoFile(link);
            // doc file
            string[] rF = File.ReadAllLines(link);
            foreach(string lines in rF){
                try{
                    ttl.MoDuongDan(lines);
                }
                catch{

                }
            }
        }
        /// <summary>
        /// hien thi tong so bang dang co
        /// </summary>
        /// <param name="link"></param>
        public static void HienThiTongSoBang(string link)
        {
            int dem = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                //thay doi duong dan
                link = link + "\\Table\\";
                //neu duong dan co ton tai
                if (Directory.Exists(link) == true)
                {
                    //do so luong thu muc dang co trong file
                    string[] folderPage = Directory.GetDirectories(link);
                    foreach (string folderInFolder in folderPage)
                    {
                        //neu duong dan la mot thu muc
                        if (Directory.Exists(folderInFolder) == true)
                        {
                            //lay cac thu muc trong trang
                            string[] tables = Directory.GetDirectories(folderInFolder);
                            foreach (string table in tables)
                            {
                                dem++;
                            }
                        }
                    }
                }
                Console.WriteLine("TONG SO BANG DANG SU DUNG: {0}", dem);
            }
        }
        /// <summary>
        /// hien thi so ban da pin
        /// </summary>
        /// <param name="link"></param>
        public static void DemSoBangDaPin(string link)
        {
            int dem = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                //thay doi duong dan
                link = link + "\\PinTable.ttl";
                //neu duong dan co ton tai
                if (File.Exists(link) == true)
                {
                    //do so luong thu muc dang co trong file
                    string[] folders = File.ReadAllLines(link);
                    foreach (string folderInFolder in folders)
                    {
                        dem++;
                    }
                }
                //hien so thu muc dang co trong thu muc
                Console.WriteLine("PIN TABLE: {0}", dem);
            }
        }
        /// <summary>
        /// hien thi so trang dang su dung
        /// </summary>
        /// <param name="link"></param>
        public static void HienThiTongSoTrangDangSuDung(string link)
        {
            int dem = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                //thay doi duong dan
                link = link + "\\Table\\";
                //neu duong dan co ton tai
                if (Directory.Exists(link) == true)
                {
                    //do so luong thu muc dang co trong file
                    string[] folders = Directory.GetDirectories(link);
                    foreach (string folderInFolder in folders)
                    {
                        dem++;
                    }
                }
                //hien so thu muc dang co trong thu muc
                Console.WriteLine("SO TRANG DANG SU DUNG: {0}", dem);
            }
        }
        /// <summary>
        /// hien thi so bieu do dang su dung
        /// </summary>
        /// <param name="link"></param>
        public static void BieuDoDangSuDung(string link)
        {
            int dem = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                //thay doi duong dan
                link = link + "\\BieuDo\\";
                //neu duong dan co ton tai
                if (Directory.Exists(link) == true)
                {
                    //do so luong thu muc dang co trong file
                    string[] folders = Directory.GetDirectories(link);
                    foreach (string folderInFolder in folders)
                    {
                        dem++;
                    }

                }
                //hien so thu muc dang co trong thu muc
                Console.WriteLine("SO BIEU DO DANG SU DUNG: {0}", dem);
            }
        }
        /// <summary>
        /// nhung viec can lam trong 1 ngay
        /// </summary>
        /// <param name="link"></param>
        public static void DanhSachViecTrongMotNgay(string link)
        {
            int demKyTu = 0;
            int dem = 0;
            var today = DateTime.Now;
            var duration = new TimeSpan(0, 0, 0, 0);
            DateTime newday = today.Add(duration);
            string done = "";
            string amopm = "";
            string linkNumLineTable = "";
            int numLineTable = 0;
            string b = link;
            string c = link + "\\Table\\main\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\";
            string linkTable = link + "\\Table\\main\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".ttl";
            link = link + "\\DanhSachCongViec.ttl";
            HelpTTL ttl = new HelpTTL();
            // neu file chua ton tai
            if (File.Exists(link) == false)
            {
                FileStream fN = new FileStream(link, FileMode.Create);
                fN.Close();
                // ghi du lieu vao file
                TextWriter tx = new StreamWriter(link, true);
                tx.WriteLine(DateTime.Now);
                tx.Close();
            }
            //neu link khac rong
            if (b != "")
            {
                linkNumLineTable = b + "\\NumLineTable.ttl";
                //neu duong dan ton tai
                if (File.Exists(linkNumLineTable) == true)
                {
                    //lay so canh bang
                    string[] fileNumLineTable = File.ReadAllLines(linkNumLineTable);
                    foreach (string numLTB in fileNumLineTable)
                    {
                        numLineTable = int.Parse(numLTB);
                    }
                }
            }
            if (Directory.Exists(b + "\\NgauNhien\\") == false)
            {
                DirectoryInfo folder = new DirectoryInfo(b + "\\NgauNhien\\");
                folder.Create();
            }
            //n?u ch?a có file ngày hôm nay
            if (Directory.Exists(c) == false)
            {
                //t?o folder
                DirectoryInfo folder = new DirectoryInfo(c);
                folder.Create();
                //t?o tên th? m?c
                ttl.TaoFile(b + "\\Table\\main\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year, "\\name.ttl");
                ttl.GhiDuLieuVaoFile(b + "\\Table\\main\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\name.ttl", DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year, true);
                //t?o file n?i dung
                FileStream file = new FileStream(linkTable, FileMode.Create);
                file.Close();
            }
            //neu du lieu file co ton tai
            if (File.Exists(link) == true)
            {
                do
                {
                    // xoa man hinh
                    Console.Clear();
                    amopm = "";
                    amopm = amopm + newday.ToString("tt");
                    //tao khoang trong
                    for (int i = 0; i <= numLineTable / 6; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("-- DANH SACH CONG VIEC --");
                    string[] DSVCL = File.ReadAllLines(link);
                    foreach (string s in DSVCL)
                    {
                        dem++;
                        if (done != s)
                        {
                            if (dem == 1)
                            {
                                //tao danh sach moi dua tren nhung cong viec chua hoan thanh
                                FileStream fileNewDS = new FileStream(link, FileMode.Create);
                                fileNewDS.Close();
                            }
                            Console.Write("*> ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(s);
                            //xuong dong cho dong dau tien
                            if (dem == 1)
                            {
                                //doc so ky tu trong dong
                                foreach (char ch in s)
                                {
                                    demKyTu++;
                                }
                                //neu ky tu trong hoat dong be hon 68
                                if (demKyTu <= numLineTable)
                                {
                                    //tao khoang trong
                                    for (int i = 0; i <= numLineTable / 3 - demKyTu - 9; i++)
                                    {
                                        Console.Write(".");
                                    }
                                    //hien tinh trang hoat dong
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("TRANG THAI");
                                   Console.ResetColor();
                                }
                                demKyTu = 0;
                            }
                            //hien thi tinh trang cho cac dong khac 1
                            if (dem != 1)
                            {
                                //doc so ky tu trong dong
                                foreach (char ch in s)
                                {
                                    demKyTu++;
                                }
                                //neu ky tu trong hoat dong be hon 68
                                if (demKyTu <= numLineTable)
                                {
                                    //tao khoang trong
                                    for (int i = 0; i <= numLineTable / 3 - demKyTu - 3; i++)
                                    {
                                        Console.Write(".");
                                    }
                                    //hien tinh trang hoat dong
                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                    Console.WriteLine("dead");
                                   Console.ResetColor();
                                }
                                demKyTu = 0;
                            }

                            //ghi nhung viec chua lam xong vao danh sach moi
                            TextWriter textDSM = new StreamWriter(link, true);
                            textDSM.WriteLine(s);
                            textDSM.Close();
                        }
                        else if (done == s)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("*> ");
                            Console.Write("[" + s + "]");
                           Console.ResetColor();
                            //n?u t?m th?y ho?t ??ng có trong danh sách
                            Console.Write("... DA GHI NHAN HOAT DONG LUC {0}h{1}m..\n", DateTime.Now.Hour, DateTime.Now.Minute);
                            TextWriter file = new StreamWriter(linkTable, true);
                            file.WriteLine(s + " (da hoan thanh) luc: " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + " " + amopm);
                            file.Close();
                            //truy?n d? li?u ?? v? s? ?? ho?t ??ng
                            SoDo(done, b);
                        }
                       Console.ResetColor();
                    }
                    //hien thi bieu do
                    HienThiBDDS(b);
                    Console.Write("Ghi cong viec da hoan thanh(+ them cong viec | ++ them cong viec %)\n- ");
                    done = Console.ReadLine();
                    done = done.ToLower();
                    done = done.Replace(" ", "");
                    dem = 0;
                    if (done == "+")
                    {
                        Console.Write("GHI THEM CONG VIEC VAO DANH SACH: ");
                        done = Console.ReadLine();
                        done = done.ToLower();
                        done = done.Replace(" ", "");
                        //neu duong dan khac rong
                        if (done != "")
                        {
                            //ghi cong viec moi vao danh sach
                            TextWriter textNewCV = new StreamWriter(link, true);
                            textNewCV.WriteLine(done);
                            textNewCV.Close();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("DA THEM THANH CONG :D");
                            done = "";
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("KHONG TIM THAY CONG VIEC CAN THEM!");
                            Console.ReadKey();
                        }
                       Console.ResetColor();
                    }
                    // danh sach cong viec phan tram
                    if (done == "++")
                    {
                        //tao bieu do
                        NewBDDS(b);
                    }
                    //kiem tra ban co dang goi ten bang
                    CheckBDDS(b, done);
                } while (done != "exit");
            }
        }
        /// <summary>
        /// kiem tra du lieu nhap vao co phai ten bang
        /// </summary>
        /// <param name="link"></param>
        /// <param name="data"></param>
        public static void CheckBDDS(string link, string data)
        {
            int newNum = 0;
            //neu data va duong link khac rong
            if (data != "" && link != "")
            {
                //thay doi duong dan
                link = link + "\\BDDS\\";
                //kiem tra ten file
                if (Directory.Exists(link + data) == true)
                {
                    //thay doi so lieu trongfile
                    Console.Write("NUM: ");
                    int.TryParse(Console.ReadLine(), out newNum);
                    //ghi du lieu moi vao file
                    TextWriter newText = new StreamWriter(link + data + "\\num2", false);
                    newText.WriteLine(newNum);
                    newText.Close();
                }
            }
        }
        /// <summary>
        /// hien thi bieu do
        /// </summary>
        /// <param name="link"></param>
        public static void HienThiBDDS(string link)
        {
            string nameBD = "";
            string moTa = "";
            int num1 = 0;
            int num2 = 0;
            float num11 = 0;
            float num22 = 0;
            int dem = 0;
            Console.WriteLine();
            try
            {
                //neu duong dan khac rong
                if (link != "")
                {
                    //thiet lap lai duong dan
                    link = link + "\\BDDS\\";
                    //neu duong dan co ton tai
                    if (Directory.Exists(link) == true)
                    {
                        //lay cac file trong thu muc
                        string[] folders = Directory.GetDirectories(link);
                        foreach (string manyFolder in folders)
                        {
                            //neu do la mot thu muc
                            if (Directory.Exists(manyFolder) == true)
                            {
                                //lay file ten thu muc
                                if (File.Exists(manyFolder + "\\name") == true)
                                {
                                    //lay ten thu muc
                                    string[] name = File.ReadAllLines(manyFolder + "\\name");
                                    foreach (string linesName in name)
                                    {
                                        nameBD = linesName;
                                    }
                                }
                                //lay file mo ta
                                if (File.Exists(manyFolder + "\\mota") == true)
                                {
                                    //lay ten thu muc
                                    string[] fileMoTa = File.ReadAllLines(manyFolder + "\\mota");
                                    foreach (string linesMoTa in fileMoTa)
                                    {
                                        moTa = linesMoTa;
                                    }
                                }
                                //lay file tong trong file so
                                if (File.Exists(manyFolder + "\\num") == true)
                                {
                                    //lay ten thu muc
                                    string[] fileNum1 = File.ReadAllLines(manyFolder + "\\num");
                                    foreach (string linesNum in fileNum1)
                                    {
                                        num1 = int.Parse(linesNum);
                                        num11 = num11 + num1;
                                    }
                                }
                                if (File.Exists(manyFolder + "\\num2") == true)
                                {
                                    //lay ten thu muc
                                    string[] fileNum2 = File.ReadAllLines(manyFolder + "\\num2");
                                    foreach (string linesNum2 in fileNum2)
                                    {
                                        num2 = int.Parse(linesNum2);
                                        num22 = num22 + num2;
                                    }
                                }
                            }
                            if (num1 > 0 && num2 > 0)
                            {
                                //ve bieu do
                                for (int i = 0; i <= num1 / 2; i++)
                                {
                                    dem++;
                                    if (i <= num2 * 100 / num1)
                                    {
                                        if (num2 * 100 / num1 <= 100)
                                        {
                                            Console.BackgroundColor = ConsoleColor.Green;
                                            Console.Write(" ");
                                        }
                                        else
                                        {
                                            Console.BackgroundColor = ConsoleColor.Red;
                                            Console.Write(" ");
                                        }
                                    }
                                    if (dem == 1)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write(num2 * 100 / num1 + "%");
                                       Console.ResetColor();
                                    }
                                }
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Write("|");
                               Console.ResetColor();
                                Console.Write(num2 + " - " + num1);
                            }
                            Console.WriteLine(" [" + nameBD + "] ({0})", moTa);
                            Console.BackgroundColor = ConsoleColor.Black;
                            dem = 0;
                        }
                        Console.WriteLine(string.Format("{0:0.00}% | {1} - {2}", num22 * 100 / num11, num22, num11));
                    }
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
        /// <summary>
        /// tao bieu do ++ trong danh sach
        /// </summary>
        /// <param name="link"></param>
        public static void NewBDDS(string link)
        {
            string news = "";
            string name = "";
            string moTa = "";
            int num = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                //thay doi duong dan
                link = link + "\\BDDS\\";
                //neu thu muc chua ton tai
                if (Directory.Exists(link) == false)
                {
                    DirectoryInfo newFolder = new DirectoryInfo(link);
                    newFolder.Create();
                }
                //neu duong dan da ton tai
                if (Directory.Exists(link) == true)
                {
                    //ghi ten thu muc moi
                    Console.Write("GHI TEN THU MUC MOI: ");
                    news = Console.ReadLine();
                    name = news;
                    news = news.ToLower();
                    news = news.Replace(" ", "");
                    //ghi mo ta
                    Console.Write("GHI MO TA: ");
                    moTa = Console.ReadLine();
                    //neu ten thu muc moi khac rong
                    if (news != "" && moTa != "")
                    {
                        //tao thu muc moi
                        DirectoryInfo newFolder = new DirectoryInfo(link + "\\" + news);
                        newFolder.Create();
                        //tao file ten
                        FileStream fileNew = new FileStream(link + "\\" + news + "\\name", FileMode.Create);
                        fileNew.Close();
                        //ghi ten file
                        TextWriter nameFile = new StreamWriter(link + "\\" + news + "\\name", false);
                        nameFile.WriteLine(name);
                        nameFile.Close();
                        //tao file mo ta
                        FileStream fileMoTa = new FileStream(link + "\\" + news + "\\mota", FileMode.Create);
                        fileMoTa.Close();
                        //ghi mo ta
                        TextWriter moTaFile = new StreamWriter(link + "\\" + news + "\\mota", false);
                        moTaFile.WriteLine(moTa);
                        moTaFile.Close();
                        //tao file ghi thong tin du lieu
                        FileStream fileNum = new FileStream(link + "\\" + news + "\\num", FileMode.Create);
                        fileNum.Close();
                        //nhap so cho file
                        Console.Write("NHAP DU LIEU SO CHO FILE: ");
                        int.TryParse(Console.ReadLine(), out num);
                        if (num > 0)
                        {
                            //ghi du lieu vao file
                            TextWriter numFile = new StreamWriter(link + "\\" + news + "\\num", false);
                            numFile.WriteLine(num);
                            numFile.Close();
                            //tao file num2
                            FileStream fileNum2 = new FileStream(link + "\\" + news + "\\num2", FileMode.Create);
                            fileNum2.Close();
                            //ghi du lieu vao file num2
                            TextWriter numFile2 = new StreamWriter(link + "\\" + news + "\\num2", false);
                            numFile2.WriteLine("0");
                            numFile2.Close();
                        }


                    }
                }
            }
        }
        /// <summary>
        /// kenh chat
        /// </summary>
        /// <param name="link"></param>
        public static void ChatChannel(string link)
        {
            string cauTraLoi = "";
            string capNhatCauTraLoi = "";
            string str = "";
            string inPut = "";
            int demCauTraLoi = 0;
            int numCauTraLoi = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                HelpTTL ttl = new HelpTTL();
                //duong dan moi dan toi bo nao
                link = link + "\\Brain\\";
                //neu duong dan chua ton tai
                if (Directory.Exists(link) == false)
                {
                    //tao thu muc
                    DirectoryInfo newFolder = new DirectoryInfo(link);
                    newFolder.Create();
                }
                do
                {
                    try
                    {
                        ttl.FeelingBot("o");
                        Console.Write("...\nYOU> ");
                        inPut = Console.ReadLine();
                        inPut = inPut.ToLower();
                        inPut = inPut.Replace(" ", "");
                        //neu duong dan da ton tai
                        if (Directory.Exists(link) == true)
                        {
                            //loc ky tu
                            str = ttl.Loc2KyTu(inPut, "capnhat", "+");
                            //ket qua sau khi so sanh chu
                            Console.ForegroundColor = ConsoleColor.Yellow;
                           Console.ResetColor();
                            //neu ban cap nhat cau tra loi va file chua cau tra loi da ton tai
                            if (str.Replace(" ", "") != "" && File.Exists(link + str + ".ttl") == true)
                            {
                                //fellingbot
                                ttl.FeelingBot("o");
                                Console.Write("GHI CAU TRA LOI MOI CHO CAU HOI [{0}]: ", str);
                                capNhatCauTraLoi = Console.ReadLine();
                                //neu cau tra loi khac rong
                                if (capNhatCauTraLoi != "")
                                {
                                    //cap nhat cau tra loi moi cho cau hoi
                                    TextWriter textCauTraLoiMoi = new StreamWriter(link + str + ".ttl", true);
                                    textCauTraLoiMoi.WriteLine(capNhatCauTraLoi);
                                    textCauTraLoiMoi.Close();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    //fellingbot
                                    ttl.FeelingBot("^");
                                    Console.WriteLine("DA CAP NHAT CAU TRA LOI {0} CHO CAU HOI {1} :D..", capNhatCauTraLoi, str);
                                }
                                //neu nguoi dung khong nhap cau tra loi moi
                                if (capNhatCauTraLoi == "")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    //fellingbot
                                    ttl.FeelingBot("!");
                                    Console.WriteLine("BAN CHUA NHAP CAU TRA LOI MOI CHO CAU HOI {0}! :|", str);
                                }
                               Console.ResetColor();
                                Console.ReadKey();

                            }
                            //neu duong dan chua ton tai
                            if (File.Exists(link + inPut + ".ttl") == false && inPut != "" && str == "")
                            {
                                //tao duong dan moi
                                FileStream fileNew = new FileStream(link + inPut + ".ttl", FileMode.Create);
                                fileNew.Close();
                                //fellingbot
                                ttl.FeelingBot("?");
                                //ghi noi dung cho file
                                Console.WriteLine("- BAN CO THE HUONG DAN TOI TRA LOI CHO CAU HOI? [{0}] :D???", inPut);
                                cauTraLoi = Console.ReadLine();
                                //neu cau tra loi khac rong
                                if (cauTraLoi != "")
                                {
                                    //ghi cau tra loi vao file
                                    TextWriter textCauTraLoi = new StreamWriter(link + inPut + ".ttl", true);
                                    textCauTraLoi.WriteLine(cauTraLoi);
                                    textCauTraLoi.Close();
                                    //thong bao cho nguoi dung
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    //fellingbot
                                    ttl.FeelingBot("^");
                                    Console.WriteLine("CAU TRA LOI DA DUOC GHI NHAN VAO HE THONG! :D");
                                }
                                //neu nguoi dung khong nhap cau tra loi
                                if (cauTraLoi == "")
                                {
                                    //xoa du lieu
                                    File.Delete(link + inPut + ".ttl");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    //fellingbot
                                    ttl.FeelingBot("!");
                                    Console.WriteLine("KHONG TIM THAY PHAN TRA LOI! XOA DU LIEU DA KHOI TAO... :|");
                                }
                               Console.ResetColor();
                                Console.ReadKey();
                            }
                            //neu duong dan da ton tai
                            if (File.Exists(link + inPut + ".ttl") == true && inPut != "" && str.Replace(" ", "") == "")
                            {
                                //fellingbot
                                ttl.FeelingBot("o");
                                Random rd = new Random();
                                //doc du lieu trong file
                                string[] file = File.ReadAllLines(link + inPut + ".ttl");
                                foreach (string lines in file)
                                {
                                    demCauTraLoi++;
                                    //neu co 1 cau tra loi
                                }
                                //neu co 1 cau tra loi
                                //neu cau tra loi nhieu hon 1 cau
                                if (demCauTraLoi > 0)
                                {
                                    //chay ngau nhien cau tra loi cho cau hoi
                                    numCauTraLoi = rd.Next(0, demCauTraLoi);
                                    //hien thi cau tra loi
                                    for (int i = 0; i < file.Length; i++)
                                    {
                                        if (i == numCauTraLoi)
                                        {
                                            Console.WriteLine(file[i]);
                                        }
                                    }
                                }
                                demCauTraLoi = 0;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //fellingbot
                        ttl.FeelingBot("!");
                        Console.WriteLine("BAN CO THE BO QUA CAC DAU CAM XUC KHI HOI? TOI.");
                    }
                    Console.ReadKey();
                } while (inPut != "exit");
            }
        }
        /// <summary>
        /// hien thi so do hoat dong
        /// </summary>
        /// <param name="data"></param>
        /// <param name="link"></param>
        public static void SoDo(string data, string link)
        {
            int demFolder = 0;
            string link1 = "";
            string b = "";
            b = link + "\\Chart\\";
            link = link + "\\Chart\\Chart" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\";
            link1 = link + DateTime.Now.Hour + "-" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".ttl";
            //n?u th? m?c có t?n t?i
            if (Directory.Exists(b) == true)
            {
                //ti?n hành l?y ???ng d?n vào th? m?c
                string[] DirectorySum = Directory.GetDirectories(b);
                foreach (string linkD in DirectorySum)
                {
                    //??m s? th? m?c
                    demFolder++;
                }
                //n?u s? th? m?c v??t quá s? cho phép
                if (demFolder >= 366)
                {
                    //ti?n hành xóa t?t c?
                    Directory.Delete(b, true);
                }
            }
            //n?u ???ng d?n vào th? m?c không t?m th?y
            if (Directory.Exists(link) == false)
            {
                //ti?n hành t?o th? m?c m?i
                DirectoryInfo folder = new DirectoryInfo(link);
                folder.Create();
            }
            //n?u file không t?m th?y
            if (File.Exists(link1) == false)
            {
                //ti?n hành t?o file
                FileStream newFile = new FileStream(link1, FileMode.Create);
                newFile.Close();
            }
            //ghi thông tin vào file v?a t?o
            TextWriter text = new StreamWriter(link1, true);
            text.WriteLine(DateTime.Now.Hour);
            text.Close();
        }
        /// <summary>
        /// ghi dong thoi gian
        /// </summary>
        /// <param name="link"></param>
        public static void TimeLines(string link)
        {
            int num = 0;
            string chosse = "";
            char yn = ' ';
            int dem = 0;
            string linkTimeLines = link + "\\TimeLines\\";
            //neu duong dan khac rong
            if (link != "")
            {
                //neu thu muc dong thoi gian khong ton tai
                if (Directory.Exists(linkTimeLines) == false)
                {
                    //tao thu muc dong thoi gian
                    DirectoryInfo newTimeLines = new DirectoryInfo(linkTimeLines);
                    newTimeLines.Create();
                }
                //neu thu muc dong thoi gian da ton tai
                if (Directory.Exists(linkTimeLines) == true)
                {
                    //hien thi thong bao lua chon cho nguoi dung
                    do
                    {
                        Console.WriteLine("[1]DANG THOI GIAN HOAT DONG CUA NGAY HOM NAY...\n[2]XEM DONG THOI GIAN...");
                        chosse = Console.ReadLine();
                        if (chosse == "1")
                        {
                            link = link + "\\Table\\main\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + "\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".ttl";
                            //kiem tra du lieu hoat dong cua ngay hom nay
                            if (File.Exists(link) == true)
                            {
                                string[] DuLieuHoatDong = File.ReadAllLines(link);
                                foreach (string lines in DuLieuHoatDong)
                                {
                                    dem++;
                                }
                            }
                            //neu co du lieu hoat dong ngay hom nay
                            if (dem > 0)
                            {
                                Console.WriteLine("DA TIM THAY HOAT DONG HOM NAY CUA BAN, BAN CO MUON DANG LEN DONG THOI GIAN [Y][N]");
                                char.TryParse(Console.ReadLine(), out yn);
                                //neu nguoi dung chon co
                                if (yn == 'y' || yn == 'Y')
                                {
                                    //tao file hoat dong ngay hom nay vao thu muc timelines
                                    FileStream fileNew = new FileStream(linkTimeLines + "\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".ttl", FileMode.Create);
                                    fileNew.Close();
                                    //ghi du lieu hoat dong ngay hom nay len file timeLines
                                    TextWriter textTimeLines = new StreamWriter(linkTimeLines + "\\" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + ".ttl", true);
                                    textTimeLines.WriteLine(DateTime.Now.DayOfWeek + " - " + DateTime.Now);
                                    //doc du lieu file hoat dong cua ngay hom nay
                                    string[] fileNgayHomNay = File.ReadAllLines(link);
                                    foreach (string lines in fileNgayHomNay)
                                    {
                                        textTimeLines.WriteLine(lines);
                                    }
                                    textTimeLines.Close();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("DA DANG HOAT DONG HOM NAY :D");
                                   Console.ResetColor();
                                }
                            }
                        }
                        if (chosse == "2")
                        {
                            //lay cac file trong thu muc
                            string[] getFile = Directory.GetFiles(linkTimeLines);
                            foreach (string linesTimeFile in getFile)
                            {
                                //neu co ton tai file
                                if (File.Exists(linesTimeFile) == true)
                                {
                                    //doc du lieu trong file
                                    string[] linesFile = File.ReadAllLines(linesTimeFile);
                                    foreach (string lines in linesFile)
                                    {
                                        num++;
                                        if (num == 1)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("|");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.Write("# ");
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write(lines);
                                           Console.ResetColor();
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Cyan;
                                            Console.Write("| -");
                                           Console.ResetColor();
                                            Console.WriteLine(lines);
                                        }
                                    }
                                    num = 0;
                                }
                            }
                            Console.WriteLine();
                        }
                    } while (chosse != "exit");
                }

            }
        }
        //////////////////////////////////STAGE\\\\\\\\\\\\\\\\\\\\\\//////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\(CHUONG TRINH NHAM GIAM SAT CAC HOAT DONG CUA NGUOI DUNG KHAC)
        // canh bao gia doan
        public static void CanhBaoGiaiDoan(string link)
        {
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            int ngayDaQua = 0;
            int numMax = 0;
            int numGateOpen = 0;
            int iHTL = 0;
            string sNGTB = "";
            HelpTTL ttl = new HelpTTL();
            try
            {
                // neu thu muc chua cac giai doan dang ton tai
                if (Directory.Exists(link + "/Stage") == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n+DANH SACH CAP NHAT+\n");
                   Console.ResetColor();
                   Console.ResetColor();
                    // lay cac thu muc trong thu muc
                    string[] getD = Directory.GetDirectories(link + "/Stage");
                    foreach (string ds in getD)
                    {
                        DirectoryInfo dI = new DirectoryInfo(ds);
                        // lay du lieu trong file
                        numMax = ttl.LayDuLieuTrongFile(ds, "maximumdays");
                        ngay = ttl.LayDuLieuTrongFile(ds, "ngay");
                        thang = ttl.LayDuLieuTrongFile(ds, "thang");
                        nam = ttl.LayDuLieuTrongFile(ds, "nam");
                        iHTL = ttl.LayDuLieuTrongFile(ds, "hienthiloi");
                        sNGTB = ttl.LayDuLieuTrongFile1(ds + "/ngayguithongbao");
                        ttl.TaoFile(ds + "/tinhngaydaqua.txt");
                        // tinh ngay
                        ngayDaQua = ttl.TinhNgay(ngay, thang, nam, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                        Console.Write("+[");
                        // canh bao cho nguoi dung
                        if ((ngayDaQua * 100 / numMax) < 100)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("WARNING!");
                            // tinh numgateopen de mo cong neu hoat dong duoc bao cao moi
                            numGateOpen = 100 - (ngayDaQua * 100 / numMax);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("SAFE");
                        }
                       Console.ResetColor();
                        // hien thi ten stage
                        Console.Write("][" + dI.Name + "]");
                        // Console.Write(" {0}% ",ngayDaQua * 100 / numMax);
                        Console.Write(ttl.TraVeDuLieuThoiGian(ngayDaQua));
                        // ghi du lieu vao file tinh ngay da qua
                        ttl.GhiDuLieuVaoFile(ds + "/tinhngaydaqua.txt",ttl.TraVeDuLieuThoiGian(ngayDaQua),false);
                        if (numMax < ngayDaQua)
                            ttl.GhiDuLieuVaoFile(ds + "/maximumdays", ngayDaQua, true);
                        Console.Write("- MAXIMUM DAYS: {0} - HT: ", numMax);
                        // neu ngay hien thi loi lon hon hoac bang so ngay hien tai thi gui thong bao den ThongBaoTTL
                        if (iHTL <= ngayDaQua && iHTL > 0 && sNGTB != DateTime.Now.Day + "" && File.Exists(ds + "/ngayguithongbao") == true)
                        {
                            // gui thong bao den file thong bao cua he thong
                            ttl.UploadTBTTL(link + "/ThongBaoTTL/thongbao", "STAGE", ttl.LayDuLieuTrongFile1(ds + "/khacphucloi"));
                            // cap nhat ngay gui thong bao
                            ttl.GhiDuLieuVaoFile(ds + "/ngayguithongbao", DateTime.Now.Day, true);
                            // hien thi thong bao cho nguoi dung
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("DA GUI THONG BAO!");
                        }
                       Console.ResetColor();
                        /////////////////////////////
                        // hien thi gate
                         //   DirectoryInfo dI = new DirectoryInfo(ds);
                        // lay du lieu trong file
                        numMax = ttl.LayDuLieuTrongFile(ds, "maximumdays");
                        ngay = ttl.LayDuLieuTrongFile(ds, "ngay");
                        thang = ttl.LayDuLieuTrongFile(ds, "thang");
                        nam = ttl.LayDuLieuTrongFile(ds, "nam");
                        // tinh ngay
                        ngayDaQua = ttl.TinhNgay(ngay, thang, nam, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                        numGateOpen = 0;
                        // tinh numgateopen de mo cong neu hoat dong duoc bao cao moi
                        numGateOpen = 100 - (ngayDaQua * 100 / numMax);
                        // neu numgateopen > 0 mo cong
                        if (numGateOpen > 0)
                            ttl.TheGateIsOpen(numGateOpen, ds + "/Gate", dI.Name);
                        /////////////////////////////
                        // hien thi lich su theo ngay
                        if (File.Exists(ds + "/" + ngayDaQua) == true)
                        {
                            string[] readFile = File.ReadAllLines(ds + "/" + ngayDaQua);
                            foreach (string lines in readFile)
                            {
                                Console.WriteLine("\t----'" + lines + "'----");
                            }
                        }
                         Console.WriteLine();
                        // neu ngay ht < ngay max
                        if (ngayDaQua < numMax)
                        {
                            ttl.ShowFileWithSpace(numMax, 10, 10, ngayDaQua, ttl.LayDuLieuTrongFile1(ds + "/Rule/" + ngayDaQua));
                            Console.WriteLine();
                        }
                        Console.WriteLine("------------------------------------");
                        numMax = 0;
                        iHTL = 0;
                        sNGTB = "";
                    }
                }
            }
            catch (Exception e)
            {
                ttl.HienThiThongBao("STAGE!", e.Message, 16, link);
            }
        }
        // tao luat le cho stage
        public static void RuleStage(string link)
        {
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            int ngayHT = 0;
            string str = "";
            string strData = "";
            HelpTTL ttl = new HelpTTL();
            Console.Write("NAME STAGE: ");
            str = Console.ReadLine();
            str = str.ToLower().Replace(" ", "");
            // neu ten giai doan co ton tai
            if (Directory.Exists(link + "/" + str) == true)
            {
                // lay du lieu trong file
                ngay = ttl.LayDuLieuTrongFile(link + "/" + str, "ngay");
                thang = ttl.LayDuLieuTrongFile(link + "/" + str, "thang");
                nam = ttl.LayDuLieuTrongFile(link + "/" + str, "nam");
                // tinh ngay
                ngayHT = ttl.TinhNgay(ngay, thang, nam, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                // tao file trong thu muc rule
                ttl.TaoFile(link + "/" + str + "/Rule/" + ngayHT);
                // ghi du lieu vao file
                Console.Write("NEW DATA[{0}] :", ngayHT);
                strData = Console.ReadLine();
                ttl.GhiDuLieuVaoFile(link + "/" + str + "/Rule/" + ngayHT, strData, true);
            }
        }
        // ghi ten cho gate stage
        public static void NameGateStage(string link)
        {
            // goi phuong thuc tro giup ttl
            HelpTTL ttl = new HelpTTL();
            string strNameGateStage = "";
            string strNameStage = "";
            // CHON STAGE CAN MO
            Console.Write("STAGE: ");
            strNameStage = Console.ReadLine();
            // neu giai doan can mo co ton tai
            if (Directory.Exists(link + "/" + strNameStage.Replace(" ", "").ToLower()) == true)
            {
                Console.Write("NAME GATE: ");
                strNameGateStage = Console.ReadLine();
                // ghi du lieu moi vao file
                ttl.GhiDuLieuVaoFile(link + "/" + strNameStage.Replace(" ", "").ToLower() + "/Gate", strNameGateStage, true);
            }

        }
        // them lich su cho giai doan
        public static void HistoryStage(string link)
        {
            string nameStage = "";
            int ngay = 0;
            int thang = 0;
            int ngayDaQua = 0;
            int nam = 0;
            string duLieu = "";
            Console.Write("STAGE: ");
            nameStage = Console.ReadLine();
            nameStage = nameStage.ToLower().Replace(" ", "");
            // neu duong dan co ton tai
            if (Directory.Exists(link + "/" + nameStage) == true)
            {
                HelpTTL ttl = new HelpTTL();
                ngay = ttl.LayDuLieuTrongFile(link + "/" + nameStage, "/ngay");
                thang = ttl.LayDuLieuTrongFile(link + "/" + nameStage, "/thang");
                nam = ttl.LayDuLieuTrongFile(link + "/" + nameStage, "/nam");
                ngayDaQua = ttl.TinhNgay(ngay, thang, nam, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                // tao file ghi du lieu
                ttl.TaoFile(link + "/" + nameStage, ngayDaQua);
                // ghi du lieu vao file
                Console.Write("GHI LAI SU KIEN NGAY THU {0} CUA GIAI DOAN [{1}]> ", ngayDaQua, nameStage);
                duLieu = Console.ReadLine();
                // ghi du lieu vao file
                ttl.GhiDuLieuVaoFile(link + "/" + nameStage + "/" + ngayDaQua, duLieu, true);
            }
        }
        /// <summary>
        /// new stage, mo mot giai doan moi
        /// </summary>
        /// <param name="link"></param>
        public static void NewStage(string link)
        {
            string nameStage = "";
            //ghi ten giai doan moi
            Console.Write("GHI TEN GIAI DOAN MOI: ");
            nameStage = Console.ReadLine();
            nameStage = nameStage.ToLower();
            nameStage = nameStage.Replace(" ", "");
            //neu ten giai doan khac rong
            if (nameStage != "")
            {
                //thiet lap ten giai doan moi voi duong dan
                link = link + "\\" + nameStage;
            }
            //neu giai doan moi chua ton tai
            if (Directory.Exists(link) == false && nameStage != "")
            {
                //tao giai doan moi cho nguoi dung
                DirectoryInfo FolderNewStage = new DirectoryInfo(link);
                FolderNewStage.Create();
                //tao file ghi du lieu
                FileStream NewFileStage = new FileStream(link + "/" + nameStage, FileMode.Create);
                NewFileStage.Close();
                //ghi du lieu ngay tao file
                TextWriter TextDayStage = new StreamWriter(link + "/" + nameStage, true);
                TextDayStage.WriteLine(DateTime.Now + " (STAGE START: " + nameStage + ")");
                TextDayStage.Close();
                //thong bao cho nguoi dung
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DA KHOI TAO GIAI DOAN THANH CONG :D");
            }
            else if (nameStage == "")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("KHONG TIM THAY TEN!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("TRUNG TEN!");
            }
           Console.ResetColor();
            Console.ReadKey();
        }
        /// <summary>
        /// mo giai doan cua nguoi dung
        /// </summary>
        /// <param name="link"></param>
        public static void OpenStage(string link)
        {
            int dem = 0;
            string addStage = "";
            string stage = "";
            string str = "";
            Console.Write("CHON GIAI DOAN CAN MO: ");
            stage = Console.ReadLine();
            stage = stage.ToLower();
            stage = stage.Replace(" ", "");
            int numShow = 0;
            int numSetShow = 0;
            //THỂ LỆ:
            //-NẾU NGƯỜI CHƠI CÓ NHIỀU HƠN HOẶC BẰNG 20 LẦN NHẬP VÀO FILE THÌ QUÁ TRÌNH SẼ ĐƯỢC ĐÁNH DẤU LÀ THẤT BẠI
            //-NẾU NGƯỜI CHƠI CÓ ÍT HƠN 20 LẦN NHẬP VÀO FILE THÌ CHƯƠNG TRÌNH SẼ HIỂN THỊ THÔNG BÁO KHẮC PHỤC SỰ CỐ
            //neu ten giai doan khac rong
            if (stage != "")
            {
                //thiet lap duong dan voi ten giai doan
                link = link + "/" + stage;
            }
            //neu duong dan co ton tai
            if (Directory.Exists(link) == true && stage != "")
            {
                HelpTTL ttl = new HelpTTL();
                // tao file ngay thang nam trong thu muc
                ttl.TaoFile(link, "ngay");
                ttl.TaoFile(link, "thang");
                ttl.TaoFile(link, "nam");
                ttl.TaoFile(link, "dem.txt");
                ttl.TaoFileVaGhiDuLieu(link + "/maximumdays", "1");
                ttl.TaoFile(link, "khacphucloi");
                ttl.GhiDuLieuVaoFile(link + "/failure", "0", true);
                ttl.TaoThuMuc(link + "/Rule");
                ttl.TaoThuMuc(link + "/Base");
                ttl.TaoFile(link, "Gate");
                ttl.TaoFile(link, "Show");
                do
                {
                    str = "";
                    numShow = 0;
                    addStage = "";
                    // lay du lieu tu file hien thi
                    try
                    {
                        numSetShow = ttl.LayDuLieuTrongFile(link + "/Show");
                    }
                    catch
                    {
                        File.Delete(link + "/Show");
                        ttl.TaoFile(link, "Show");
                    }
                    //xoa man hinh
                    Console.Clear();
                    //neu thu luc la mot file
                    if (File.Exists(link + "/" + stage) == true)
                    {
                        // dem so dong trong file
                        dem = ttl.DemSoDongTrongFile(link + "/" + stage);
                        //doc du lieu trong file
                        string[] ReadFile = File.ReadAllLines(link + "/" + stage);
                        foreach (string lines in ReadFile)
                        {
                            if (numShow == 0 || numShow >= (dem - numSetShow))
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("|\\/|");
                                Console.Write("|\\/|-");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write(lines);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("]");
                            }
                            if (numShow <= (dem - numSetShow) && numShow == 1)
                            {
                                Console.WriteLine("|\\/|");
                                Console.Write("|\\/|-");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("[");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("............");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("]");
                            }
                            numShow++;
                        }
                       Console.ResetColor();
                        Console.Write("GATE: ");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(ttl.LayDuLieuTrongFile1(link + "/Gate"));
                       Console.ResetColor();
                        Console.WriteLine("[+]CAP NHAT NOI DUNG MOI CUA GIAI DOAN({0})\nDA TIM THAY {1} GIAI DOAN CUA CONG VIEC {2}. DANG HIEN THI {3} GIAI DOAN CUOI CUA CONG VIEC {4}.", stage, dem, stage, numSetShow, stage);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(" [≡] ");
                       Console.ResetColor();
                        Console.WriteLine("BASE " + ttl.XacDinhSLThuMucVaFile(link + "/Base"));
                        // ghi du lieu vao file dem
                        ttl.GhiDuLieuVaoFile(link + "/dem.txt",dem,false);
                    }
                    addStage = Console.ReadLine();
                    addStage = addStage.ToLower().Replace(" ", "");
                    //them giai doan
                    if (addStage == "+")
                    {
                        Console.Write("THEM GIAI DOAN MOI: ");
                        addStage = Console.ReadLine();
                        //neu giai doan moi khac rong
                        if (addStage != "")
                        {
                            //them giai doan moi
                            TextWriter TextNewStage = new StreamWriter(link + "/" + stage, true);
                            TextNewStage.WriteLine(DateTime.Now + " (NEW STAGE: " + addStage + ")");
                            TextNewStage.Close();
                            // ghi du lieu ngay thang nam vao file
                            ttl.GhiDuLieuVaoFile(link + "/ngay", DateTime.Now.Day, true);
                            ttl.GhiDuLieuVaoFile(link + "/thang", DateTime.Now.Month, true);
                            ttl.GhiDuLieuVaoFile(link + "/nam", DateTime.Now.Year, true);
                        }
                    }
                    // BASE
                    if (addStage == "base")
                        ttl.MoDuongDan(link + "/Base");
                    // set num show stage
                    str = ttl.Loc2KyTu(addStage, "setnumshow", "sns");
                    if (str != "")
                        ttl.GhiDuLieuVaoFile(link + "/Show", str, true);
                    dem = 0;
                } while (addStage != "exit");

            }
            //neu duong dan khong ton tai
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("KHONG TIM THAY TEN!");
                Console.ReadKey();
            }
           Console.ResetColor();
        }
        //HSD//////////////////////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\//////////////////////////\\\\\\\\\\\\
        //tim san pham
        public static void SearchSP(string link)
        {
            int num = 0;
            char cSearch1 = ' ';
            char cSearch2 = ' ';
            string search = "";
            int soSPS = 0;
            num = 0;
            Console.Write("SAN PHAM CAN TIM: ");
            search = Console.ReadLine();
            search = search.ToLower();
            //neu tim kiem khac rong
            if (search != "")
            {
                //doc ky tu trong ten
                foreach (char ch in search)
                {
                    num++;
                    if (num == 1)
                    {
                        cSearch1 = ch;
                    }
                }
                //lay thu muc
                string[] folders = Directory.GetDirectories(link);
                foreach (string folder in folders)
                {
                    //Console.WriteLine(folder);
                    if (File.Exists(folder + "/TimKiem.hsd") == true)
                    {
                        //doc du lieu trong file
                        string[] readFile = File.ReadAllLines(folder + "/TimKiem.hsd");
                        foreach (string nameFile in readFile)
                        {
                            num = 0;
                            //Console.WriteLine(nameFile);
                            //doc ky tu trong ten
                            foreach (char ch in nameFile)
                            {
                                //Console.Write(ch + " ");
                                num++;
                                if (num == 1)
                                {
                                    cSearch2 = ch;
                                    //Console.ForegroundColor = ConsoleColor.Red;
                                    //Console.WriteLine(cSearch2);
                                    //Console.ForegroundColor = ConsoleColor.Gray;
                                }
                                if (cSearch1 == cSearch2 && num == 2)
                                {
                                    //neu file ten san pham co ton tai
                                    if (File.Exists(folder + "/TenSanPham.hsd") == true)
                                    {
                                        //lay ten san pham
                                        string[] fileName = File.ReadAllLines(folder + "/TenSanPham.hsd");
                                        foreach (string nameSP in fileName)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("> " + nameSP);
                                        }
                                        soSPS++;
                                    }
                                    //neu file ten san pham khong ton tai
                                    if (File.Exists(folder + "/TenSanPham.hsd") == false)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("> " + nameFile);
                                        soSPS++;
                                    }
                                }
                            }
                        }
                    }
                }
                //Console.WriteLine(cSearch1);
                //Console.WriteLine(cSearch2);
            }
            //neu tim thay san pham
            if (soSPS > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("DA TIM THAY {0} SAN PHAM..", soSPS);
            }
            //neu khong tim thay san pham
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("KHONG TIM THAY SAN PHAM!");
            }
            soSPS = 0;
            cSearch2 = ' ';
           Console.ResetColor();
            Console.ReadKey();
        }
        //xuat mang
        public static void XuatMang(string[] HSD, int SPCanXoa, int numPinMax, string link)
        {
            int dem = 0;
            int demSoPinConLai = 0;
            link = link + "/Thong Bao/PinTable.ttl";
            //dem so luong bang con lai duoc pin

            if (File.Exists(link) == true)
            {
                string[] line = File.ReadAllLines(link);
                foreach (string lines in line)
                {
                    demSoPinConLai++;
                }
            }
            foreach (string sanPham in HSD)
            {
                dem++;
                if (sanPham == "xoa")
                {
                    Console.Write("[" + dem + "]" + sanPham);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" [" + SPCanXoa + "]");
                   Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("[" + dem + "]" + sanPham);
                }
            }
        }
        //cai so phan tram cho san pham
        public static void PercentSP(string link, string percent)
        {
            string str = "";
            int p = 0;
            string linkFilePercentSP = link + "/Percent.hsd";
            //neu duong dan khac rong
            if (link != "" && percent != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(percent, "sp", "setpercent");
                if (str.Replace(" ", "") != "")
                {
                    try
                    {
                        //chuyen doi du lieu sang phan tram
                        p = int.Parse(str);
                    }
                    catch
                    {
                        Console.WriteLine(p + "%");
                    }
                    //ghi du lieu vao file
                    if (File.Exists(linkFilePercentSP) == false)
                    {
                        //tao file
                        FileStream newFileP = new FileStream(linkFilePercentSP, FileMode.Create);
                        newFileP.Close();
                    }
                    if (File.Exists(linkFilePercentSP) == true)
                    {
                        TextWriter text = new StreamWriter(linkFilePercentSP, false);
                        text.WriteLine(p);
                        text.Close();
                        //thong bao cho nguoi dung
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(p + "%");
                       Console.ResetColor();
                    }
                }

            }
        }
        //them san pham moi
        public static void ThemSanPham(string link)
        {
            string tenSanPham = "";
            string tenSanPhamDeXemChoDe = "";
            int gioiHanNgayConLaiSP = 0;
            int soLuongSanPham = 0;
            string donViSP = "";
            string linkNgaySX = "";
            string linkThangSX = "";
            string linkNamSX = "";
            string linkNgayHH = "";
            string linkThangHH = "";
            string linkNamHH = "";
            string linkGioiHanNgayChoSP = "";
            string linkSoLuongSanPham = "";
            string linkTenSP = "";
            string linkTimKiem = "";
            string linkNgayNhapKho = "";
            string linkDonViSP = "";
            DateTime dateNSX = new DateTime();
            DateTime dateNHH = new DateTime();
            //neu duong dan da duoc thiet lap
            //nhap ten san pham
            Console.Write("NHAP TEN SAN PHAM: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            tenSanPham = Console.ReadLine();
            Console.Write("NHAP SO LUONG HIEN TAI: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            int.TryParse(Console.ReadLine(), out soLuongSanPham);
            if (link != "")
            {
                //giu lai ten san pham luc ban dau de luc sau coi cho de
                tenSanPhamDeXemChoDe = tenSanPham;
                //chuyen doi du lieu de de tim kiem
                tenSanPham = tenSanPham.ToLower();
                tenSanPham = tenSanPham.Replace(" ", "");
                //cac duong dan khac
                link = link + "\\" + tenSanPham;
                linkNgaySX = link + "\\NgaySX.hsd";
                linkThangSX = link + "\\ThangSX.hsd";
                linkNamSX = link + "\\NamSX.hsd";
                linkNgayHH = link + "\\NgayHH.hsd";
                linkThangHH = link + "\\ThangHH.hsd";
                linkNamHH = link + "\\NamHH.hsd";
                linkGioiHanNgayChoSP = link + "\\GHN.hsd";
                linkSoLuongSanPham = link + "\\SoLuongSanPham.hsd";
                linkTenSP = link + "\\TenSanPham.hsd";
                linkTimKiem = link + "\\TimKiem.hsd";
                linkNgayNhapKho = link + "\\NgayNhapKho.hsd";
                linkDonViSP = link + "\\DonVi.hsd";
            }
            //neu san pham da ton tai
            if (Directory.Exists(link) == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SAN PHAM DA TON TAI!");
               Console.ResetColor();
            }
            //neu san pham chua ton tai
            if (Directory.Exists(link) == false && soLuongSanPham > 0)
            {
                //tao san pham moi
                DirectoryInfo SanPhamMoi = new DirectoryInfo(link);
                SanPhamMoi.Create();
                //tao file dong vi cho san pham
                FileStream fileDonViSP = new FileStream(linkDonViSP, FileMode.Create);
                fileDonViSP.Close();
                //tao file ten san pham
                FileStream fileTenSP = new FileStream(linkTenSP, FileMode.Create);
                fileTenSP.Close();
                //nhap ten san pham
                TextWriter tenSP = new StreamWriter(linkTenSP, false);
                tenSP.WriteLine(tenSanPhamDeXemChoDe);
                tenSP.Close();
                //tao file tiem kiem theo ten san pham
                FileStream fileTimKiemTheoTenSP = new FileStream(linkTimKiem, FileMode.Create);
                fileTimKiemTheoTenSP.Close();
                //nhap ten san pham se duoc tiem kiem
                TextWriter tenSPTK = new StreamWriter(linkTimKiem, false);
                //ghi vao file
                tenSPTK.WriteLine(tenSanPham);
                tenSPTK.Close();
                //tao file so luong cua san pham
                FileStream fileSL = new FileStream(linkSoLuongSanPham, FileMode.Create);
                fileSL.Close();
                //nhap so luong hien tai
                TextWriter soLuong = new StreamWriter(linkSoLuongSanPham, false);
                soLuong.WriteLine(soLuongSanPham);
                soLuong.Close();
                //nhap gioi han han su dung con lai cho san pham
               Console.ResetColor();
                Console.Write("NHAP GIOI HAN SO NGAY CON LAI CHO SAN PHAM, NEU GIOI HAN = 0 THI SAN PHAM SE TU CAP NHAT GIOI HAN CON LAI LA 30 NGAY: ");
                int.TryParse(Console.ReadLine(), out gioiHanNgayConLaiSP);
                //tu dong chuyen ve 30 neu nguoi dung khong nhap so ngay gioi han
                if (gioiHanNgayConLaiSP <= 30)
                {
                    gioiHanNgayConLaiSP = 30;
                }
                //nhap du lieu gioi han ngay cho san pham
                FileStream fileGHN = new FileStream(linkGioiHanNgayChoSP, FileMode.Create);
                fileGHN.Close();
                TextWriter GHNSP = new StreamWriter(linkGioiHanNgayChoSP, false);
                GHNSP.WriteLine(gioiHanNgayConLaiSP);
                GHNSP.Close();
                //nhap don vi san pham
                do
                {
                    Console.Write("NHAP DON VI CUA SAN PHAM [");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(tenSanPham);
                   Console.ResetColor();
                    Console.Write("]: ");
                    donViSP = Console.ReadLine();
                    //neu don vi san pham bo trong
                    if (donViSP == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("CHUA CO DON VI CUA SAN PHAM [{0}]!: ", tenSanPham);
                       Console.ResetColor();
                    }
                } while (donViSP == "");
                //ghi du lieu vao file
                TextWriter textDonVi = new StreamWriter(linkDonViSP, false);
                textDonVi.WriteLine(donViSP);
                textDonVi.Close();
                try
                {
                    //nhap ngay thang nam san xuat cua san pham       
                    Console.Write("NHAP NGAY THANG NAM ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("SAN XUAT ");
                   Console.ResetColor();
                    Console.Write("CUA SAN PHAM ", tenSanPham);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("[{0}]", tenSanPham);
                   Console.ResetColor();
                    //nhap ngay san xuat
                    Console.Write("+ NGAY/THANG/NAM SAN XUAT: ");
                    dateNSX = DateTime.Parse(Console.ReadLine());

                    //nhap ngay thang nam het han cua san pham
                    Console.Write("NHAP NGAY THANG NAM ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("HET HAN ");
                   Console.ResetColor();
                    Console.Write("CUA SAN PHAM ", tenSanPham);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("[{0}]", tenSanPham);
                   Console.ResetColor();
                    Console.Write("+ NGAY/THANG/NAM HET HAN: ");
                    dateNHH = DateTime.Parse(Console.ReadLine());

                    //tao file ngay san xuat
                    FileStream fileNgaySX = new FileStream(linkNgaySX, FileMode.Create);
                    fileNgaySX.Close();
                    //ghi du lieu
                    TextWriter ngaySanXuat = new StreamWriter(linkNgaySX, false);
                    ngaySanXuat.WriteLine(dateNSX.Day);
                    ngaySanXuat.Close();
                    //tao file thang san xuat
                    FileStream fileThangSX = new FileStream(linkThangSX, FileMode.Create);
                    fileThangSX.Close();
                    //ghi du lieu
                    TextWriter thangSanXuat = new StreamWriter(linkThangSX, false);
                    thangSanXuat.WriteLine(dateNSX.Month);
                    thangSanXuat.Close();
                    //tao file nam san xuat
                    FileStream fileNamSX = new FileStream(linkNamSX, FileMode.Create);
                    fileNamSX.Close();
                    //ghi du lieu
                    TextWriter namSanXuat = new StreamWriter(linkNamSX, false);
                    namSanXuat.WriteLine(dateNSX.Year);
                    namSanXuat.Close();
                    //tao file ngay het han
                    FileStream fileNgayHH = new FileStream(linkNgayHH, FileMode.Create);
                    fileNgayHH.Close();
                    //ghi du lieu
                    TextWriter ngayHetHan = new StreamWriter(linkNgayHH, false);
                    ngayHetHan.WriteLine(dateNHH.Day);
                    ngayHetHan.Close();
                    //tao file thang het han
                    FileStream fileThangHH = new FileStream(linkThangHH, FileMode.Create);
                    fileThangHH.Close();
                    //ghi du lieu
                    TextWriter thangHetHan = new StreamWriter(linkThangHH, false);
                    thangHetHan.WriteLine(dateNHH.Month);
                    thangHetHan.Close();
                    //tao file nam het han
                    FileStream fileNamHH = new FileStream(linkNamHH, FileMode.Create);
                    fileNamHH.Close();
                    //ghi du lieu
                    TextWriter namHetHan = new StreamWriter(linkNamHH, false);
                    namHetHan.WriteLine(dateNHH.Year);
                    namHetHan.Close();
                }
                catch (Exception e)
                {
                    Directory.Delete(link, true);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e + "\nSAI DINH DANG CHO PHEP..HUY BO SAN PHAM [{0}]", tenSanPham);
                   Console.ResetColor();
                }

                //neu da khoi tao xong du lieu
                if (Directory.Exists(link) == true)
                {
                    //nhap ngay nhap kho cua san pham
                    FileStream fileNgayNhapKho = new FileStream(linkNgayNhapKho, FileMode.Create);
                    fileNgayNhapKho.Close();
                    //ghi ngay nhap kho
                    TextWriter ngayNhapKho = new StreamWriter(linkNgayNhapKho, false);
                    ngayNhapKho.WriteLine(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.DayOfWeek + " at " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                    ngayNhapKho.Close();
                    //hien thong tin san pham vua duoc tao
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DU LIEU DA DUOC KHOI TAO..");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("TEN SAN PHAM: ");
                    Console.WriteLine(tenSanPhamDeXemChoDe);
                   Console.ResetColor();
                    Console.Write("SO LUONG: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(soLuongSanPham);
                   Console.ResetColor();
                    Console.Write("DON VI: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(donViSP);
                   Console.ResetColor();
                    Console.Write("NGAY NHAP KHO: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + " " + DateTime.Now.DayOfWeek + " at " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                   Console.ResetColor();
                    Console.Write("HAN SU DUNG: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("{0}/{1}/{2}", dateNSX.Day, dateNSX.Month, dateNSX.Year);
                   Console.ResetColor();
                    Console.Write(" DEN NGAY: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0}/{1}/{2}\n- CHUONG TRINH SE THONG BAO KHI SAN PHAM CON {3} NGAY", dateNHH.Day, dateNHH.Month, dateNHH.Year, gioiHanNgayConLaiSP);
                }
            }
            if (soLuongSanPham <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SO LUONG KHONG DUOC DE TRONG!");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// kiem tra han su dung cua san pham
        /// </summary>
        /// <param name="link"></param>
        /// <param name="chosse"></param>
        public static void KiemTraHanSuDung(string link, string chosse)
        {
            double dem = 0;
            string tenSanPham = "";
            int loaiSP = 0;
            int ngayHH = 0;
            int thangHH = 0;
            int namHH = 0;
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            int soLuongSanPham = 0;
            int gioiHanNgayConLaiCuaSP = 0;
            int ngaySX = 0;
            int thangSX = 0;
            int namSX = 0;
            string donViSP = "";
            string ngayNhapKho = "";
            string linkNgayHH = "";
            string linkThangHH = "";
            string linkNamHH = "";
            string linkGioiHanNgayChoSP = "";
            string linkSoLuongSanPham = "";
            string linkNgaySX = "";
            string linkThangSX = "";
            string linkNamSX = "";
            string linkTenSP = "";
            string linkNgayNhapKho = "";
            string linkDonViSP = "";
            int demGuessTheDate = 0;
            int numPersent1 = 0;
            int numPersent2 = 0;
            //int numPersent2 = 0;
            //neu da co su lua chon san pham
            if (chosse != "")
            {
                tenSanPham = chosse;
            }
            //neu su lua chon la rong
            if (chosse == "2")
            {
                //ghi ten san pham can kiem tra han su dung
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Ghi ten san pham can kiem tra: ");
                tenSanPham = Console.ReadLine();
            }
            if (tenSanPham != "")
            {
                //chuyen doi du lieu de de tim kiem
                tenSanPham = tenSanPham.ToLower();
                tenSanPham = tenSanPham.Replace(" ", "");
                //cac duong dan khac
                link = link + "/" + tenSanPham;
                linkNgaySX = link + "/NgaySX.hsd";
                linkThangSX = link + "/ThangSX.hsd";
                linkNamSX = link + "/NamSX.hsd";
                linkNgayHH = link + "/NgayHH.hsd";
                linkThangHH = link + "/ThangHH.hsd";
                linkNamHH = link + "/NamHH.hsd";
                linkGioiHanNgayChoSP = link + "/GHN.hsd";
                linkSoLuongSanPham = link + "/SoLuongSanPham.hsd";
                linkTenSP = link + "/TenSanPham.hsd";
                linkNgayNhapKho = link + "/NgayNhapKho.hsd";
                linkDonViSP = link + "/DonVi.hsd";
            }
            //neu san pham co ton tai
            if (Directory.Exists(link) == true && tenSanPham != "")
            {
                //neu file don vi co ton tai
                if (File.Exists(linkDonViSP) == true)
                {
                    string[] DonViSP = File.ReadAllLines(linkDonViSP);
                    foreach (string DV in DonViSP)
                    {
                        donViSP = DV;
                    }
                }
                //neu file ngay het han co ton tai
                if (File.Exists(linkNgayHH) == true)
                {
                    string[] TTNgayHH = File.ReadAllLines(linkNgayHH);
                    foreach (string lineFileNgayHH in TTNgayHH)
                    {
                        ngayHH = int.Parse(lineFileNgayHH);
                    }
                }
                //neu file thang het han co ton tai
                if (File.Exists(linkThangHH) == true)
                {
                    string[] TTThangHH = File.ReadAllLines(linkThangHH);
                    foreach (string lineFileThangHH in TTThangHH)
                    {
                        thangHH = int.Parse(lineFileThangHH);
                    }
                }
                //neu file nAM het han co ton tai
                if (File.Exists(linkNamHH) == true)
                {
                    string[] TTNamHH = File.ReadAllLines(linkNamHH);
                    foreach (string lineFileNamHH in TTNamHH)
                    {
                        namHH = int.Parse(lineFileNamHH);
                    }
                }
                //neu file gioi han ngay co ton tai
                if (File.Exists(linkGioiHanNgayChoSP) == true)
                {
                    string[] fileGHN = File.ReadAllLines(linkGioiHanNgayChoSP);
                    foreach (string soNgayGioHan in fileGHN)
                    {
                        gioiHanNgayConLaiCuaSP = int.Parse(soNgayGioHan);
                    }
                }
                //neu file so luong co ton tai
                if (File.Exists(linkSoLuongSanPham) == true)
                {
                    string[] fileSLSP = File.ReadAllLines(linkSoLuongSanPham);
                    foreach (string soLSP in fileSLSP)
                    {
                        soLuongSanPham = int.Parse(soLSP);
                    }
                }
                //neu file ngay san xuat co ton tai
                if (File.Exists(linkNgaySX) == true)
                {
                    string[] TTNgaySX = File.ReadAllLines(linkNgaySX);
                    foreach (string lineFileNgaySX in TTNgaySX)
                    {
                        ngaySX = int.Parse(lineFileNgaySX);
                    }
                }
                //neu file thang het han co ton tai
                if (File.Exists(linkThangSX) == true)
                {
                    string[] TTThangSX = File.ReadAllLines(linkThangSX);
                    foreach (string lineFileThangSX in TTThangSX)
                    {
                        thangSX = int.Parse(lineFileThangSX);
                    }
                }
                //neu file nAM het han co ton tai
                if (File.Exists(linkNamSX) == true)
                {
                    string[] TTNamSX = File.ReadAllLines(linkNamSX);
                    foreach (string lineFileNamSX in TTNamSX)
                    {
                        namSX = int.Parse(lineFileNamSX);
                    }
                }
                //neu ten san pham co ton tai
                if (File.Exists(linkTenSP) == true)
                {
                    string[] nameSP = File.ReadAllLines(linkTenSP);
                    foreach (string name in nameSP)
                    {
                        tenSanPham = name;
                    }
                }
                //neu file ngay nhap kho co ton tai
                if (File.Exists(linkNgayNhapKho) == true)
                {
                    //lay du lieu ngay nhap kho
                    string[] duLieuNgayNhap = File.ReadAllLines(linkNgayNhapKho);
                    foreach (string ngayNK in duLieuNgayNhap)
                    {
                        ngayNhapKho = ngayNK;
                    }
                }
                //du lieu ngay hom nay
                ngay = DateTime.Now.Day;
                thang = DateTime.Now.Month;
                nam = DateTime.Now.Year;
                //loai bo duong dan thong bao

                //thuat toan tinh cac loai san pham
                //san pham con trong tinh trang tot
                if (namHH > nam)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nSAN PHAM CON TOT");
                    //Console.WriteLine(ngaySX);
                    //Console.WriteLine(thangSX);
                    //Console.WriteLine(namSX);
                    //Console.WriteLine(ngayHH);
                    //Console.WriteLine(thangHH);
                    //Console.WriteLine(namHH);
                    //Console.WriteLine(tenSanPham);
                    loaiSP = 0;
                }
                //san pham con han su dung duoi 1 nam
                else if (namHH == nam && thangHH >= thang && ngayHH > ngay)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nSAN PHAM SAP HET HAN!");
                    //Console.WriteLine(ngaySX);
                    //Console.WriteLine(thangSX);
                    //Console.WriteLine(namSX);
                    //Console.WriteLine(ngayHH);
                    //Console.WriteLine(thangHH);
                    //Console.WriteLine(namHH);
                    //Console.WriteLine(tenSanPham);
                    loaiSP = 1;
                }
                //san pham da trong tinh trang hu hai
                else if (namHH <= nam && thangHH <= thang)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nSAN PHAM DA HET HAN!");
                    //Console.WriteLine(ngaySX);
                    //Console.WriteLine(thangSX);
                    //Console.WriteLine(namSX);
                    //Console.WriteLine(ngayHH);
                    //Console.WriteLine(thangHH);
                    //Console.WriteLine(namHH);
                    //Console.WriteLine(tenSanPham );
                    loaiSP = 2;
                }
                //hien thi persent cua san pham
                var datP1 = new DateTime(namSX, thangSX, ngaySX);
                var datP2 = new DateTime(namHH, thangHH, ngayHH);
                //dem num persent1
                //var datHH1 = new DateTime(n, , DateTime.Now.Day);
                for (int ctr = 0; ctr <= ctr + 1; ctr++)
                {
                    //??m s? ng?y
                    numPersent1++;
                    //hi?n ng?y
                    //Console.WriteLine(guessTheDate.AddDays(ctr).ToString("d"));
                    //?i?u ki?n d?ng v?ng l?pyp
                    if (datP1.AddDays(ctr).Day == datP2.Day && datP1.AddDays(ctr).Month == datP2.Month && datP1.AddDays(ctr).Year == datP2.Year)
                    {
                        break;
                    }
                }
                //dem num persent2
                for (int ctr = 0; ctr <= ctr + 1; ctr++)
                {
                    //??m s? ng?y
                    numPersent2++;
                    //hi?n ng?y
                    //Console.WriteLine(guessTheDate.AddDays(ctr).ToString("d"));
                    //?i?u ki?n d?ng v?ng l?pyp
                    if (datP1.AddDays(ctr).Day == ngay && datP1.AddDays(ctr).Month == thang && datP1.AddDays(ctr).Year == nam)
                    {
                        break;
                    }
                }
                //persent
                Console.WriteLine("PERSENT LEFT {0}%", 100 - (numPersent2 * 100 / numPersent1));
                //neu don vi cua san pham bang rong
                if (donViSP == "")
                {
                    donViSP = "KHONG TIM THAY";
                }
                //neu la san pham loai 0 va san pham loai 1
                //san pham loai 0 la san pham con tot
                //san pham loai 1 la san pham sap het han
                //hien thi ngay se hien thi thong bao
                var guessTheDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
                if (loaiSP == 0 || loaiSP == 1)
                {
                    dem = 0;
                    var dat = new DateTime(nam, thang, ngay);
                    var datHH = new DateTime(namHH, thangHH, ngayHH);
                    for (int ctr = 0; ctr <= ctr + 1; ctr++)
                    {
                        //??m s? ng?y
                        dem++;
                        //hi?n ng?y
                        //Console.WriteLine(dat.AddDays(ctr).ToString("d"));
                        //?i?u ki?n d?ng v?ng l?pyp
                        if (dat.AddDays(ctr).Day == datHH.Day && dat.AddDays(ctr).Month == datHH.Month && dat.AddDays(ctr).Year == datHH.Year)
                        {
                            break;
                        }
                    }
                    if ((dem - 1) <= gioiHanNgayConLaiCuaSP)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("-TEN SAN PHAM: " + tenSanPham);
                        Console.WriteLine("-SO LUONG SAN PHAM : " + soLuongSanPham);
                        Console.WriteLine("-DON VI SAN PHAM : " + donViSP);
                        Console.WriteLine("-NGAY NHAP KHO : " + ngayNhapKho);
                        Console.WriteLine("-HAN SU DUNG: {0}/{1}/{2} DEN NGAY {3}/{4}/{5}", ngaySX, thangSX, namSX, ngayHH, thangHH, namHH);
                        Console.WriteLine("-SO NGAY CON LAI: {0} NGAY", (dem - 1));
                        Console.WriteLine("-SO NGAY GIOI HAN CUA SAN PHAM LA: " + gioiHanNgayConLaiCuaSP + " NGAY");
                        Console.WriteLine("-BAN NEN CO BIEN PHAP KHAC PHUC! :|");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("-TEN SAN PHAM: " + tenSanPham);
                        Console.WriteLine("-SO LUONG SAN PHAM : " + soLuongSanPham);
                        Console.WriteLine("-DON VI SAN PHAM : " + donViSP);
                        Console.WriteLine("-NGAY NHAP KHO : " + ngayNhapKho);
                        Console.WriteLine("-HAN SU DUNG: {0}/{1}/{2} DEN NGAY {3}/{4}/{5}", ngaySX, thangSX, namSX, ngayHH, thangHH, namHH);
                        Console.WriteLine("-SO NGAY CON LAI: {0} NGAY", (dem - 1));
                        Console.WriteLine("-SO NGAY GIOI HAN CUA SAN PHAM LA: " + gioiHanNgayConLaiCuaSP + " NGAY");
                        Console.Write("-THONG BAO SE DUOC HIEN THI VAO NGAY: ");
                        //hien thi ngay se hien thi thong bao
                        for (int ctr = 0; ctr <= ctr + 1; ctr++)
                        {
                            //??m s? ng?y
                            demGuessTheDate++;
                            //hi?n ng?y
                            if (demGuessTheDate == (dem - 1) - gioiHanNgayConLaiCuaSP)
                                Console.WriteLine(guessTheDate.AddDays(ctr).ToString("d"));
                            //?i?u ki?n d?ng v?ng l?pyp
                            //if (dat1.AddDays(ctr).Day == DateTime.Now.Day && dat1.AddDays(ctr).Month == DateTime.Now.Month && dat1.AddDays(ctr).Year == DateTime.Now.Year)
                            //{
                            if (demGuessTheDate == (dem - 1) - gioiHanNgayConLaiCuaSP)
                                break;
                            //}
                        }
                        //Console.WriteLine(demGuessTheDate);
                        Console.WriteLine("-SAN PHAM VAN CON TRONG TINH TRANG TOT :D");

                    }
                }
                //neu la san pham loai 2
                //san pham loai 2 la san pham da het han
                else if (loaiSP == 2)
                {
                    //Console.WriteLine(ngayHH);
                    //Console.WriteLine(thangHH);
                    //Console.WriteLine(namHH);
                    //Console.WriteLine(ngaySX);
                    //Console.WriteLine(thangSX);
                    //Console.WriteLine(namSX);
                    dem = 0;
                    var dat1 = new DateTime(namHH, thangHH, ngayHH);
                    //var datHH1 = new DateTime(n, , DateTime.Now.Day);
                    for (int ctr = 0; ctr <= ctr + 1; ctr++)
                    {
                        //??m s? ng?y
                        dem++;
                        //hi?n ng?y
                        //Console.WriteLine(dat.AddDays(ctr).ToString("d"));
                        //?i?u ki?n d?ng v?ng l?pyp
                        if (dat1.AddDays(ctr).Day == DateTime.Now.Day && dat1.AddDays(ctr).Month == DateTime.Now.Month && dat1.AddDays(ctr).Year == DateTime.Now.Year)
                        {
                            break;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-TEN SAN PHAM: " + tenSanPham);
                    Console.WriteLine("-SO LUONG SAN PHAM : " + soLuongSanPham);
                    Console.WriteLine("-DON VI SAN PHAM : " + donViSP);
                    Console.WriteLine("-NGAY NHAP KHO : " + ngayNhapKho);
                    Console.WriteLine("-HAN SU DUNG: {0}/{1}/{2} DEN NGAY {3}/{4}/{5}", ngaySX, thangSX, namSX, ngayHH, thangHH, namHH);
                    Console.WriteLine("-SAN PHAM DA QUA {0} NGAY DE SU DUNG", dem);
                    Console.WriteLine("-SAN PHAM DA QUA HAN SU DUNG! :(");
                    //dem so san pham da qua han su dung                 
                }
            }
            //neu khong tim thay san pham
            if (Directory.Exists(link) == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("KHONG TIM THAY SAN PHAM! {0}", tenSanPham);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// kiem tra tat ca san pham dang co trong kho
        /// </summary>
        /// <param name="link"></param>
        public static void KiemTraKho(string link)
        {
            char yn = ' ';
            int loaiSP = 0;
            int soLanKiemTra = 0;
            int soSPTot = 0;
            int soSPSapHH = 0;
            int soSPDaHetHan = 0;
            string donViSP = "";
            string tenSanPhamDeXemChoDe = "";
            string linkSPCanXoa = "";
            string linkNgayHH = "";
            string linkThangHH = "";
            string linkNamHH = "";
            string linkGioiHanNgayChoSP = "";
            string linkSoLuongSanPham = "";
            string linkNgaySX = "";
            string linkThangSX = "";
            string linkNamSX = "";
            string linkTenSP = "";
            string linkThongBao = "";
            string linkSPTot = "";
            string linkSPSapHH = "";
            string linkSPDaHH = "";
            string linkTimKiem = "";
            string tenSanPham = "";
            string linkNgayNhapKho = "";
            string ngayNhapKho = "";
            string linkDonViSP = "";
            string sanPhamDaXoa = "";
            int p = 0;
            double dem = 0;
            int ngayHH = 0;
            int thangHH = 0;
            int namHH = 0;
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            int soLuongSanPham = 0;
            int gioiHanNgayConLaiCuaSP = 0;
            int ngaySX = 0;
            int thangSX = 0;
            int namSX = 0;
            int demSoSP1 = 0;
            int demCh = 0;
            int sp30 = 0;
            //int demGuessTheDate = 0;
            int numPersent1 = 0;
            int numPersent2 = 0;
            linkThongBao = link + "\\Thong Bao";
            linkSPTot = linkThongBao + "\\San Pham Con Tot\\San Pham Con Tot.txt";
            linkSPSapHH = linkThongBao + "\\San Pham Sap Het Han\\San Pham Sap Het Han.txt";
            linkSPDaHH = linkThongBao + "\\San Pham Da Het Han\\San Pham Da Het Han.txt";
            linkSPCanXoa = linkThongBao + "\\San Pham Can Xoa.txt";
            //thong bao viec hien cac san pham trong luc kiem tra kho
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("BAN CO MUON CHUONG TRINH HIEN THONG TIN TUNG SAN PHAM TRONG KHO? CANH BAO: VIEC HIEN QUA NHIEU SAN PHAM CUNG MOT LUC CO THE DAN DEN TINH TRANG HOA MAT, CHONG MAT, BAN NEN CAN NHAC KY TRUOC KHI CHON. :D [Y][N]");
            char.TryParse(Console.ReadLine(), out yn);
           Console.ResetColor();
            //tao bang cho cac san pham
            //neu thu muc san phan con tot chua co
            if (Directory.Exists(linkThongBao + "\\San Pham Con Tot\\") == false)
            {
                DirectoryInfo folderSPTot = new DirectoryInfo(linkThongBao + "\\San Pham Con Tot\\");
                folderSPTot.Create();
                //tao file ten bang san pham tot
                FileStream fileNameSPTot = new FileStream(linkThongBao + "\\San Pham Con Tot\\name.hsd", FileMode.Create);
                fileNameSPTot.Close();
                //ghi ten bang
                TextWriter tenBangSPTot = new StreamWriter(linkThongBao + "\\San Pham Con Tot\\name.hsd", false);
                tenBangSPTot.WriteLine("San Pham Con Tot");
                tenBangSPTot.Close();
            }
            //neu thu muc san phan sap het han
            if (Directory.Exists(linkThongBao + "\\San Pham Sap Het Han\\") == false)
            {
                DirectoryInfo folderSPSapHH = new DirectoryInfo(linkThongBao + "\\San Pham Sap Het Han\\");
                folderSPSapHH.Create();
                //tao file ten bang sap het han
                FileStream fileNameSPSapHH = new FileStream(linkThongBao + "\\San Pham Sap Het Han\\name.hsd", FileMode.Create);
                fileNameSPSapHH.Close();
                //ghi ten bang
                TextWriter tenBangSPSapHH = new StreamWriter(linkThongBao + "\\San Pham Sap Het Han\\name.hsd", false);
                tenBangSPSapHH.WriteLine("San Pham Sap Het Han");
                tenBangSPSapHH.Close();
            }
            //neu thu muc san phan da het han
            if (Directory.Exists(linkThongBao + "\\San Pham Da Het Han\\") == false)
            {
                DirectoryInfo folderSPDaHH = new DirectoryInfo(linkThongBao + "\\San Pham Da Het Han\\");
                folderSPDaHH.Create();
                //tao file ten bang dan het han
                FileStream fileNameSPDaHH = new FileStream(linkThongBao + "\\San Pham Da Het Han\\name.hsd", FileMode.Create);
                fileNameSPDaHH.Close();
                //ghi ten bang
                TextWriter tenBangSPDaHH = new StreamWriter(linkThongBao + "\\San Pham Da Het Han\\name.hsd", false);
                tenBangSPDaHH.WriteLine("San Pham Da Het Han");
                tenBangSPDaHH.Close();
            }
            //neu thu muc thong bao chua co
            if (Directory.Exists(linkThongBao) == false)
            {
                DirectoryInfo folderThongBao = new DirectoryInfo(linkThongBao);
                folderThongBao.Create();
            }
            //lay so percent san pham can tim
            if (File.Exists(link + "/Percent.hsd") == true)
            {
                string[] filePercent = File.ReadAllLines(link + "/Percent.hsd");
                foreach (string numPercent in filePercent)
                {
                    p = int.Parse(numPercent);
                }
            }
            //tao du lieu cua cac san pham can xoa
            FileStream fileDelete = new FileStream(linkSPCanXoa, FileMode.Create);
            fileDelete.Close();
            //tao du lieu moi cho san pham con tot
            FileStream fileSPTot = new FileStream(linkSPTot, FileMode.Create);
            fileSPTot.Close();
            //tao du lieu moi cho san pham sap het han        
            FileStream fileSPSapHH = new FileStream(linkSPSapHH, FileMode.Create);
            fileSPSapHH.Close();
            //tao du lieu moi cho san pham da het han
            FileStream fileSPDaHH = new FileStream(linkSPDaHH, FileMode.Create);
            fileSPDaHH.Close();
            //lay tat ca san pham dang co
            string[] linkTatCaSanPham = Directory.GetDirectories(link);
            foreach (string cacSanPham in linkTatCaSanPham)
            {
                ngayNhapKho = "";
                //loai bo duong dan thong bao
                if (cacSanPham != linkThongBao)
                {
                    try
                    {
                        //dem so lan kiem tra san pham
                        soLanKiemTra++;
                        demSoSP1++;
                        donViSP = "";
                        if (Directory.Exists(cacSanPham) == true)
                        {
                            numPersent2 = 0;
                            numPersent1 = 0;
                            demCh = 0;
                            loaiSP = 0;
                            //giu lai ten san pham luc ban dau de luc sau coi cho de
                            tenSanPhamDeXemChoDe = tenSanPham;
                            //chuyen doi du lieu de de tim kiem
                            tenSanPham = tenSanPham.ToLower();
                            tenSanPham = tenSanPham.Replace(" ", "");
                            //cac duong dan khac
                            dem = 0;
                            linkNgaySX = cacSanPham + "\\NgaySX.hsd";
                            linkThangSX = cacSanPham + "\\ThangSX.hsd";
                            linkNamSX = cacSanPham + "\\NamSX.hsd";
                            linkNgayHH = cacSanPham + "\\NgayHH.hsd";
                            linkThangHH = cacSanPham + "\\ThangHH.hsd";
                            linkNamHH = cacSanPham + "\\NamHH.hsd";
                            linkGioiHanNgayChoSP = cacSanPham + "\\GHN.hsd";
                            linkSoLuongSanPham = cacSanPham + "\\SoLuongSanPham.hsd";
                            linkTenSP = cacSanPham + "\\TenSanPham.hsd";
                            linkTimKiem = link + "\\TimKiem.hsd";
                            linkNgayNhapKho = cacSanPham + "\\NgayNhapKho.hsd";
                            linkDonViSP = cacSanPham + "\\DonVi.hsd";
                            //neu file don vi co ton tai
                            if (File.Exists(linkDonViSP) == true)
                            {
                                string[] DonViSP = File.ReadAllLines(linkDonViSP);
                                foreach (string DV in DonViSP)
                                {
                                    donViSP = DV;
                                }
                            }
                            //neu file ten san pham co ton tai
                            if (File.Exists(linkTenSP) == true)
                            {
                                string[] TenSP = File.ReadAllLines(linkTenSP);
                                foreach (string tenSP in TenSP)
                                {
                                    tenSanPham = tenSP;
                                }
                            }
                            //neu ten san pham khong ton tai
                            if (File.Exists(linkTenSP) == false)
                            {
                                tenSanPham = cacSanPham;
                            }
                            //neu file ngay het han co ton tai
                            if (File.Exists(linkNgayHH) == true)
                            {
                                string[] TTNgayHH = File.ReadAllLines(linkNgayHH);
                                foreach (string lineFileNgayHH in TTNgayHH)
                                {
                                    ngayHH = int.Parse(lineFileNgayHH);
                                }
                            }
                            //neu file thang het han co ton tai
                            if (File.Exists(linkThangHH) == true)
                            {
                                string[] TTThangHH = File.ReadAllLines(linkThangHH);
                                foreach (string lineFileThangHH in TTThangHH)
                                {
                                    thangHH = int.Parse(lineFileThangHH);
                                }
                            }
                            //neu file nAM het han co ton tai
                            if (File.Exists(linkNamHH) == true)
                            {
                                string[] TTNamHH = File.ReadAllLines(linkNamHH);
                                foreach (string lineFileNamHH in TTNamHH)
                                {
                                    namHH = int.Parse(lineFileNamHH);
                                }
                            }
                            //neu file gioi han ngay co ton tai
                            if (File.Exists(linkGioiHanNgayChoSP) == true)
                            {
                                string[] fileGHN = File.ReadAllLines(linkGioiHanNgayChoSP);
                                foreach (string soNgayGioHan in fileGHN)
                                {
                                    gioiHanNgayConLaiCuaSP = int.Parse(soNgayGioHan);
                                }
                            }
                            //neu file so luong co ton tai
                            if (File.Exists(linkSoLuongSanPham) == true)
                            {
                                string[] fileSLSP = File.ReadAllLines(linkSoLuongSanPham);
                                foreach (string soLSP in fileSLSP)
                                {
                                    soLuongSanPham = int.Parse(soLSP);
                                }
                            }
                            //neu file ngay san xuat co ton tai
                            if (File.Exists(linkNgaySX) == true)
                            {
                                string[] TTNgaySX = File.ReadAllLines(linkNgaySX);
                                foreach (string lineFileNgaySX in TTNgaySX)
                                {
                                    ngaySX = int.Parse(lineFileNgaySX);
                                }
                            }
                            //neu file thang het han co ton tai
                            if (File.Exists(linkThangSX) == true)
                            {
                                string[] TTThangSX = File.ReadAllLines(linkThangSX);
                                foreach (string lineFileThangSX in TTThangSX)
                                {
                                    thangSX = int.Parse(lineFileThangSX);
                                }
                            }
                            //neu file nam het han co ton tai
                            if (File.Exists(linkNamSX) == true)
                            {
                                string[] TTNamSX = File.ReadAllLines(linkNamSX);
                                foreach (string lineFileNamSX in TTNamSX)
                                {
                                    namSX = int.Parse(lineFileNamSX);
                                }
                            }
                            //neu file ngay nhap kho co ton tai
                            if (File.Exists(linkNgayNhapKho) == true)
                            {
                                //lay du lieu ngay nhap kho
                                string[] duLieuNgayNhap = File.ReadAllLines(linkNgayNhapKho);
                                foreach (string ngayNK in duLieuNgayNhap)
                                {
                                    ngayNhapKho = ngayNK;
                                }
                            }
                            //du lieu ngay hom nay
                            ngay = DateTime.Now.Day;
                            thang = DateTime.Now.Month;
                            nam = DateTime.Now.Year;
                            //thuat toan tinh cac loai san pham
                            //san pham con trong tinh trang tot
                            if (namHH > nam)
                            {
                                if (yn == 'Y' || yn == 'y')
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\nSAN PHAM CON TOT");
                                }
                                //Console.WriteLine(ngaySX);
                                //Console.WriteLine(thangSX);
                                //Console.WriteLine(namSX);
                                //Console.WriteLine(ngayHH);
                                //Console.WriteLine(thangHH);
                                //Console.WriteLine(namHH);
                                //Console.WriteLine(tenSanPham);
                                loaiSP = 0;
                            }
                            //san pham con han su dung duoi 1 nam
                            else if (namHH == nam && thangHH >= thang && ngayHH > ngay)
                            {
                                if (yn == 'Y' || yn == 'y')
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("\nSAN PHAM SAP HET HAN!");
                                }
                                //Console.WriteLine(ngaySX);
                                //Console.WriteLine(thangSX);
                                //Console.WriteLine(namSX);
                                //Console.WriteLine(ngayHH);
                                //Console.WriteLine(thangHH);
                                //Console.WriteLine(namHH);
                                //Console.WriteLine(tenSanPham);
                                loaiSP = 1;
                            }
                            //san pham da trong tinh trang hu hai
                            else if (namHH <= nam && thangHH <= thang)
                            {
                                if (yn == 'Y' || yn == 'y')
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nSAN PHAM DA HET HAN!");
                                }
                                //Console.WriteLine(ngaySX);
                                //Console.WriteLine(thangSX);
                                //Console.WriteLine(namSX);
                                //Console.WriteLine(ngayHH);
                                //Console.WriteLine(thangHH);
                                //Console.WriteLine(namHH);
                                //Console.WriteLine(tenSanPham);                        
                                loaiSP = 2;

                            }
                            //neu don vi cua san pham bang rong
                            if (donViSP == "")
                            {
                                donViSP = "...";
                            }
                            //hien thi persent cua san pham
                            var datP1 = new DateTime(namSX, thangSX, ngaySX);
                            var datP2 = new DateTime(namHH, thangHH, ngayHH);
                            //dem num persent1
                            //var datHH1 = new DateTime(n, , DateTime.Now.Day);
                            for (int ctr = 0; ctr <= ctr + 1; ctr++)
                            {
                                //??m s? ng?y
                                numPersent1++;
                                //hi?n ng?y
                                //Console.WriteLine(guessTheDate.AddDays(ctr).ToString("d"));
                                //?i?u ki?n d?ng v?ng l?pyp
                                if (datP1.AddDays(ctr).Day == datP2.Day && datP1.AddDays(ctr).Month == datP2.Month && datP1.AddDays(ctr).Year == datP2.Year)
                                {
                                    break;
                                }
                            }
                            //dem num persent2
                            for (int ctr = 0; ctr <= ctr + 1; ctr++)
                            {
                                //??m s? ng?y
                                numPersent2++;
                                //hi?n ng?y
                                //Console.WriteLine(guessTheDate.AddDays(ctr).ToString("d"));
                                //?i?u ki?n d?ng v?ng l?pyp
                                if (datP1.AddDays(ctr).Day == ngay && datP1.AddDays(ctr).Month == thang && datP1.AddDays(ctr).Year == nam)
                                {
                                    break;
                                }
                            }
                            //persent
                            Console.Write("PERSENT LEFT {0}%", 100 - (numPersent2 * 100 / numPersent1));
                            if ((100 - (numPersent2 * 100 / numPersent1)) <= p)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(" >! " + tenSanPham);
                                sp30++;
                               Console.ResetColor();
                            }
                            else
                                Console.WriteLine();
                            //neu la san pham loai 0 va san pham loai 1
                            //san pham loai 0 la san pham con tot
                            //san pham loai 1 la san pham sap het han
                            if (loaiSP == 0 || loaiSP == 1)
                            {
                                dem = 0;
                                var dat = new DateTime(nam, thang, ngay);
                                var datHH = new DateTime(namHH, thangHH, ngayHH);
                                for (int ctr = 0; ctr <= ctr + 1; ctr++)
                                {
                                    //??m s? ngày
                                    dem++;
                                    //hi?n ngày
                                    //Console.WriteLine(dat.AddDays(ctr).ToString("d"));
                                    //?i?u ki?n d?ng v?ng l?pyp
                                    if (dat.AddDays(ctr).Day == datHH.Day && dat.AddDays(ctr).Month == datHH.Month && dat.AddDays(ctr).Year == datHH.Year)
                                    {
                                        break;
                                    }
                                }
                                if ((dem - 1) <= gioiHanNgayConLaiCuaSP)
                                {
                                    if (yn == 'Y' || yn == 'y')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("-TEN SAN PHAM: " + tenSanPham);
                                        Console.WriteLine("-SO LUONG SAN PHAM : " + soLuongSanPham);
                                        Console.WriteLine("-DON VI SAN PHAM : " + donViSP);
                                        Console.WriteLine("-NGAY NHAP KHO : " + ngayNhapKho);
                                        Console.WriteLine("-HAN SU DUNG: {0}/{1}/{2} DEN NGAY {3}/{4}/{5}", ngaySX, thangSX, namSX, ngayHH, thangHH, namHH);
                                        Console.WriteLine("-SO NGAY CON LAI: {0} NGAY", (dem - 1));
                                        Console.WriteLine("-SO NGAY GIOI HAN CUA SAN PHAM LA: " + gioiHanNgayConLaiCuaSP + " NGAY");
                                        Console.WriteLine("-BAN NEN CO BIEN PHAP KHAC PHUC! :|");
                                    }
                                    //dem so san pham sap het han
                                    soSPSapHH++;
                                    TextWriter SPGanHH = new StreamWriter(linkSPSapHH, true);
                                    //ghi du lieu moi vao file san pham sap het han
                                    SPGanHH.WriteLine("SAN PHAM: " + tenSanPham + " - SO LUONG: " + soLuongSanPham + "(" + donViSP + ") - NGAY CON LAI: " + (dem - 1) + " NGAY! - " + (100 - (numPersent2 * 100 / numPersent1)) + "%");
                                    SPGanHH.Close();
                                }
                                else
                                {
                                    if (yn == 'Y' || yn == 'y')
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("-TEN SAN PHAM: " + tenSanPham);
                                        Console.WriteLine("-SO LUONG SAN PHAM : " + soLuongSanPham);
                                        Console.WriteLine("-DON VI SAN PHAM : " + donViSP);
                                        Console.WriteLine("-NGAY NHAP KHO : " + ngayNhapKho);
                                        Console.WriteLine("-HAN SU DUNG: {0}/{1}/{2} DEN NGAY {3}/{4}/{5}", ngaySX, thangSX, namSX, ngayHH, thangHH, namHH);
                                        Console.WriteLine("-SO NGAY CON LAI: {0} NGAY", (dem - 1));
                                        Console.WriteLine("-SO NGAY GIOI HAN CUA SAN PHAM LA: " + gioiHanNgayConLaiCuaSP + " NGAY");
                                        Console.WriteLine("-SAN PHAM CON TOT :D");
                                    }
                                    //dem so san pham tot
                                    soSPTot++;
                                    //ghi du lieu moi cho san pham con tot
                                    TextWriter SPConTot = new StreamWriter(linkSPTot, true);
                                    //ghi du lieu moi vao file san pham con tot
                                    SPConTot.WriteLine("SAN PHAM: " + tenSanPham + " - SO LUONG: " + soLuongSanPham + "(" + donViSP + ") - NGAY CON LAI: " + (dem - 1) + " NGAY - " + (100 - (numPersent2 * 100 / numPersent1)) + "%");
                                    //hien thi canh bao !
                                    if ((100 - (numPersent2 * 100 / numPersent1)) <= p)
                                    {
                                        SPConTot.Write("          ", p);
                                        //doc so ky tu ten san pham
                                        foreach (char ch in tenSanPham)
                                        {
                                            demCh++;
                                        }
                                        for (int i = 0; i < demCh; i++)
                                        {
                                            SPConTot.Write("'");
                                        }
                                        SPConTot.Write("\\_[sp < {0}%]", p);
                                        SPConTot.WriteLine();
                                    }
                                    SPConTot.Close();
                                }
                            }
                            //neu la san pham loai 2
                            //san pham loai 2 la san pham da het han
                            else if (loaiSP == 2)
                            {
                                //Console.WriteLine(ngayHH);
                                //Console.WriteLine(thangHH);
                                //Console.WriteLine(namHH);
                                //Console.WriteLine(ngaySX);
                                //Console.WriteLine(thangSX);
                                //Console.WriteLine(namSX);
                                dem = 0;
                                var dat1 = new DateTime(namHH, thangHH, ngayHH);
                                //var datHH1 = new DateTime(n, , DateTime.Now.Day);
                                for (int ctr = 0; ctr <= ctr + 1; ctr++)
                                {
                                    //??m s? ngày
                                    dem++;
                                    //hi?n ngày
                                    //Console.WriteLine(dat.AddDays(ctr).ToString("d"));
                                    //?i?u ki?n d?ng v?ng l?pyp
                                    if (dat1.AddDays(ctr).Day == DateTime.Now.Day && dat1.AddDays(ctr).Month == DateTime.Now.Month && dat1.AddDays(ctr).Year == DateTime.Now.Year)
                                    {
                                        break;
                                    }
                                }
                                //neu nguoi dung chon co thien thong tin san pham
                                if (yn == 'Y' || yn == 'y')
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("-TEN SAN PHAM: " + tenSanPham);
                                    Console.WriteLine("-SO LUONG SAN PHAM : " + soLuongSanPham);
                                    Console.WriteLine("-DON VI SAN PHAM : " + donViSP);
                                    Console.WriteLine("-NGAY NHAP KHO : " + ngayNhapKho);
                                    Console.WriteLine("-HAN SU DUNG: {0}/{1}/{2} DEN NGAY {3}/{4}/{5}", ngaySX, thangSX, namSX, ngayHH, thangHH, namHH);
                                    Console.WriteLine("-SAN PHAM DA QUA {0} NGAY DE SU DUNG", dem);
                                    Console.WriteLine("-SAN PHAM DA QUA HAN SU DUNG! :(");
                                }
                                //ghi du lieu moi cho san pham da het han
                                TextWriter SPDaHH = new StreamWriter(linkSPDaHH, true);
                                //ghi du lieu moi vao file san pham da het han
                                SPDaHH.WriteLine("SAN PHAM: " + tenSanPham + " - SO LUONG: " + soLuongSanPham + "(" + donViSP + ") - DA QUA " + dem + " NGAY! - " + (100 - (numPersent2 * 100 / numPersent1)) + "%");
                                SPDaHH.Close();
                                //dem so san pham da qua han su dung
                                soSPDaHetHan++;
                                //ghi du lieu cho cac san pham da qua han de xoa
                                TextWriter SPQuaHan = new StreamWriter(linkSPCanXoa, true);
                                tenSanPham = tenSanPham.ToLower();
                                tenSanPham = tenSanPham.Replace(" ", "");
                                SPQuaHan.WriteLine(tenSanPham);
                                SPQuaHan.Close();
                            }
                        }
                        //neu khong tim thay san pham
                        if (Directory.Exists(link) == false)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("KHONG TIM THAY SAN PHAM! {0}", tenSanPham);
                        }
                    }
                    catch (Exception)
                    {
                        sanPhamDaXoa = sanPhamDaXoa + "\n" + cacSanPham;
                        Directory.Delete(cacSanPham, true);
                    }
                }
            }
            //xuat so lan da kiem tra kho
            if (soLanKiemTra > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n+ DA HOAN TAT KIEM TRA {0} SAN PHAM TRONG KHO...", soLanKiemTra);
            }
            //neu co san pham con tot
            if (soSPTot > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n+ SO SAN PHAM CON SU DUNG DUOC: {0} SAN PHAM.", soSPTot);
            }
            //neu co san pham sap het han
            if (soSPSapHH > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n+ SO SAN PHAM SAP HET HAN: {0} SAN PHAM.", soSPSapHH);
            }
            //neu co san pham da het han
            if (soSPDaHetHan > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n+ SO SAN PHAM DA HET HAN: {0} SAN PHAM.", soSPDaHetHan);
            }
            //san pham duoi hoac bang p phan tram date
            if (sp30 > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("+ SAN PHAM DUOI {0}% DATE {1} SP", p, sp30);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-SAN PHAM DA XOA DO SAI THONG TIN!\n" + sanPhamDaXoa);
           Console.ResetColor();
            Console.ReadKey();
        }
        /// <summary>
        /// hien thi thong tin san pham
        /// </summary>
        /// <param name="link"></param>
        /// <param name="link1"></param>
        public static void ThongTinSanPham(string link, string link1)
        {

            link = link + "/Thong Bao/";
            int num = 0;
            int max = 0;
            int num1 = 0;
            int numNull = 0;
            int times = 0;
            int canhGiua = 0;
            string b = link + "\\PinTable.ttl";
            string nameTable = "";
            string linkInformationTable = "";
            int demPin = 0;
            string colorTable = "";
            string linkNumTable = "";
            int numLineTable = 0;
            try
            {
                //neu duong dan khac rong
                if (link1 != "")
                {
                    linkNumTable = link1 + "\\NumLineTable.ttl";
                    //neu duong dan ton tai
                    if (File.Exists(linkNumTable) == true)
                    {
                        //lay so canh bang
                        string[] fileNumLineTable = File.ReadAllLines(linkNumTable);
                        foreach (string numLTB in fileNumLineTable)
                        {
                            numLineTable = int.Parse(numLTB);
                        }
                    }
                }
                //n?u file không t?n t?i
                if (File.Exists(b) == false)
                {
                    FileStream file = new FileStream(b, FileMode.Create);
                    file.Close();
                }
                string[] findLinkTable = Directory.GetDirectories(link);
                foreach (string linkTable in findLinkTable)
                {
                    //??m pin
                    demPin++;
                    //n?u th? m?c có t?n t?i
                    if (Directory.Exists(linkTable) == true)
                    {
                        string[] findTable = Directory.GetFiles(linkTable);
                        foreach (string tables in findTable)
                        {
                            if (tables != linkTable + "\\name.hsd")
                            {
                                linkInformationTable = tables;
                            }

                        }
                        //n?u file không t?n t?i
                        if (File.Exists(linkTable + "\\name.hsd") == false)
                        {
                            nameTable = linkInformationTable;
                        }
                        //n?u file có t?n t?i
                        if (File.Exists(linkTable + "\\name.hsd") == true)
                        {
                            string[] name = File.ReadAllLines(linkTable + "\\name.hsd");
                            foreach (string nameT in name)
                            {
                                //màu
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                nameTable = nameT;
                                //t?o ?ánh d?u cho b?ng
                                Console.WriteLine();
                                string[] danhDau = File.ReadAllLines(b);
                                foreach (string line in danhDau)
                                {
                                    if (nameTable == line)
                                    {
                                        if (max <= numLineTable)
                                        {
                                            //canh giua cho bang
                                            canhGiua = numLineTable - max;
                                            canhGiua = canhGiua / 2;
                                        }
                                        for (int cg = 0; cg <= canhGiua; cg++)
                                        {
                                            Console.Write(" ");
                                        }
                                        Console.Write("|");
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine("[{0}]", demPin);
                                       Console.ResetColor();
                                    }
                                }
                            }
                        }
                        string[] lineTable = File.ReadAllLines(linkInformationTable);
                        //ki?m tra giá tr? max trong tên c?a b?ng
                        foreach (char ch in nameTable)
                        {
                            num1++;
                            if (num1 > max)
                            {
                                max = num1;
                            }
                        }
                        do
                        {
                            //th?c hi?n tên c?a b?ng sau 1 l?n
                            if (times == 1)
                            {
                                //canh gi?a cho b?ng
                                if (max <= numLineTable)
                                {
                                    //canh giua cho bang
                                    canhGiua = numLineTable - max;
                                    canhGiua = canhGiua / 2;
                                    for (int cg = 0; cg <= canhGiua; cg++)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("|");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                                Console.Write(nameTable);
                                //t?o kho?ng tr?ng
                                for (int i = 0; i < max - num1; i++)
                                {
                                    Console.Write(" ");
                                }
                                //ch?n màu cho b?ng
                                if (numNull == 0)
                                {
                                    //n?u d? li?u r?ng
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
                                if (numNull != 0)
                                {
                                    //màu
                                    if (nameTable == "San Pham Con Tot")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }
                                    else if (nameTable == "San Pham Sap Het Han")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                    }
                                    else if (nameTable == "San Pham Da Het Han")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                Console.Write("|");
                                //?i?u ki?n canh ??
                                if (max != numLineTable)
                                {
                                    Console.WriteLine();
                                }

                            }
                            foreach (string s in lineTable)
                            {
                                numNull++;
                                num = 0;
                                //t?m giá tr? l?n nh?t trong d?ng
                                foreach (char ch in s)
                                {
                                    num++;
                                    if (num > max)
                                    {
                                        max = num;
                                    }
                                }
                                //th?c hi?n thông tin c?a b?ng sau 2 l?n
                                if (times == 2)
                                {
                                    //canh gi?a cho b?ng
                                    if (max <= numLineTable)
                                    {
                                        //canh giua cho bang
                                        canhGiua = numLineTable - max;
                                        canhGiua = canhGiua / 2;
                                        for (int cg = 0; cg <= canhGiua; cg++)
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                    Console.Write("|");
                                   Console.ResetColor();
                                    if (colorTable == "7")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                    }
                                    Console.Write(s);
                                    if (colorTable == "7")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                    }
                                    //ch?n màu cho b?ng
                                    //màu
                                    if (nameTable == "San Pham Con Tot")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }
                                    else if (nameTable == "San Pham Sap Het Han")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                    }
                                    else if (nameTable == "San Pham Da Het Han")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    if (num == max)
                                    {
                                        Console.Write("");
                                    }
                                    //t?o kho?ng tr?ng 
                                    for (int i = 0; i < max - num; i++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write("|");
                                    //?i?u ki?n canh ??
                                    if (max != 78)
                                    {
                                        Console.WriteLine();
                                    }
                                }
                            }
                            ////ch?n màu cho b?ng
                            if (numNull == 0)
                            {
                                //n?u d? li?u r?ng
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            if (numNull != 0)
                            {
                                //màu
                                if (nameTable == "San Pham Con Tot")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else if (nameTable == "San Pham Sap Het Han")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                else if (nameTable == "San Pham Da Het Han")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                            //canh gi?a cho b?ng
                            if (max <= numLineTable)
                            {
                                //canh giua cho bang
                                canhGiua = numLineTable - max;
                                canhGiua = canhGiua / 2;
                                for (int cg = 0; cg <= canhGiua; cg++)
                                {
                                    Console.Write(" ");
                                }
                            }
                            //th?c hi?n t?o ???ng ngang d?a trên s? max
                            if (times == 0)
                            {
                                Console.Write(" ");
                            }
                            if (times == 1)
                            {
                                Console.Write("|");
                            }
                            if (times == 2)
                            {
                                Console.Write("|");
                            }
                            for (int i = 0; i < max; i++)
                            {

                                if (times == 1)
                                {
                                    Console.Write("-");
                                }
                                else
                                {
                                    Console.Write("_");
                                }
                            }
                            if (times == 0)
                            {
                                Console.Write("");
                            }
                            if (times == 1)
                            {
                                Console.Write("|");
                            }
                            if (times == 2)
                            {
                                Console.Write("|");
                            }
                            Console.WriteLine();
                            times++;
                        } while (times < 3);
                        //thi?t l?p giá tr? ban ??u
                        num = 0;
                        num1 = 0;
                        max = 0;
                        times = 0;
                        canhGiua = 0;
                        numNull = 0;
                        //t?o ?ánh d?u cho b?ng     
                        string[] danhDau11 = File.ReadAllLines(b);
                        foreach (string line in danhDau11)
                        {
                            //mau
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            if (nameTable == line)
                            {
                                if (max <= numLineTable)
                                {
                                    //canh giua cho bang
                                    canhGiua = numLineTable - max;
                                    canhGiua = canhGiua / 2;
                                    for (int cg = 0; cg <= canhGiua; cg++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.WriteLine("|");
                                }
                            }
                        }
                    }
                }
                demPin = 0;
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
        }
        // tao kho moi
        public static void KhoMoi(string link)
        {
            string nameKho = "";
            Console.Write("TAO KHO MOI: " + link);
            nameKho = Console.ReadLine();
            if (nameKho != "" && Directory.Exists(link + nameKho) == false)
            {
                DirectoryInfo nD = new DirectoryInfo(link + nameKho);
                nD.Create();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("DA CAP NHAT KHO MOI");
               Console.ResetColor();
                Console.ReadKey();
            }
        }
        /// <summary>
        /// hien thi so san pham dang co trong kho
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static string SoSanPhamHienDangCo(string link)
        {
            int TSP = 0;
            string b = link;
            string tenKho = "";
            link = link + "\\Thong Bao\\";
            string nameWarehouse = link + "\\tenkho.txt";
            string linkTongSoSP = link + "\\Tong So San Pham\\";
            string linkSoSanPham = linkTongSoSP + "\\Tong So San Pham.hsd";
            //dem so san pham dang co
            if (Directory.Exists(b) == true)
            {
                string[] tongSoSP = Directory.GetDirectories(b);
                foreach (string SP in tongSoSP)
                {
                    TSP++;
                }
            }
            //neu file chua ton tai
            if (Directory.Exists(linkTongSoSP) == false)
            {
                DirectoryInfo folderTongSoSP = new DirectoryInfo(linkTongSoSP);
                folderTongSoSP.Create();
            }
            FileStream fileTongSoSP = new FileStream(linkSoSanPham, FileMode.Create);
            fileTongSoSP.Close();
            //kiem tra ten kho
            if (File.Exists(nameWarehouse) == false)
            {
                //  tạo file
                FileStream fN = new FileStream(nameWarehouse, FileMode.Create);
                fN.Close();
                // ghi ten kho
                Console.Write(">GHI TEN KHO: ");
                tenKho = Console.ReadLine();
                if (tenKho.Replace(" ", "") == "")
                    tenKho = b;
                // ghi du lieu vào file
                TextWriter tx = new StreamWriter(nameWarehouse, false);
                tx.Write(tenKho);
                tx.Close();
            }
            if (File.Exists(nameWarehouse) == true)
            {
                string[] fileNameKho = File.ReadAllLines(nameWarehouse);
                foreach (string nameKho in fileNameKho)
                {
                    tenKho = nameKho;
                }
            }
            //tao file ghi ten bang
            FileStream fileName = new FileStream(linkTongSoSP + "\\name.hsd", FileMode.Create);
            fileName.Close();
            //ghi ten bang
            TextWriter nameTable = new StreamWriter(linkTongSoSP + "\\name.hsd", false);
            //neu khong co ten kho
            if (tenKho == "")
            {
                nameTable.WriteLine("KHO...");
            }
            //neu co ten kho
            if (tenKho != "")
            {
                nameTable.WriteLine("KHO " + tenKho.ToUpper());
            }
            nameTable.Close();
            //ghi so san pham hien co
            TextWriter soSPHienCo = new StreamWriter(linkSoSanPham, false);
            soSPHienCo.WriteLine("DA TIM THAY [" + (TSP - 1) + "] SAN PHAM TRONG KHO " + tenKho.ToUpper());
            soSPHienCo.WriteLine("THOI GIAN CAP NHAT MOI NHAT: " + DateTime.Now);
            soSPHienCo.Close();
            return tenKho;
        }
        /// <summary>
        /// xoa san pham thu cong
        /// </summary>
        /// <param name="link"></param>
        public static void XoaSanPhamThuCong(string link)
        {
            int soLuongCanXoa = 0;
            int soLuongHienTaiCuaSanPham = 0;
            int soLuongMoiChoSanPham = 0;
            string donViSP = "";
            string nameSP = "";
            char yn = ' ';
            //neu duong dan khac rong
            if (link != "")
            {
                //ghi ten san pham can xoa
                Console.Write("GHI TEN SAN PHAM CAN XOA: ");
                nameSP = Console.ReadLine();
                nameSP = nameSP.ToLower();
                nameSP = nameSP.Replace(" ", "");
                //neu ten san pham khac rong
                if (nameSP != "")
                {
                    //thiet lap ket noi toi san pham can xoa
                    link = link + "\\" + nameSP;
                    //neu san pham co ton tai
                    if (Directory.Exists(link) == true && nameSP != "")
                    {
                        //hien ten san pham
                        //neu file name san pham co ton tai
                        if (File.Exists(link + "\\TenSanPham.hsd") == true)
                        {
                            Console.Write("+TEN SAN PHAM: ");
                            string[] fileNameSP = File.ReadAllLines(link + "\\TenSanPham.hsd");
                            foreach (string name in fileNameSP)
                            {
                                Console.WriteLine(name);
                            }
                        }
                        //hien so luong san pham
                        //neu file so luong co ton tai
                        if (File.Exists(link + "\\SoLuongSanPham.hsd") == true)
                        {
                            Console.Write("+SO LUONG HIEN TAI: ");
                            string[] fileSLSP = File.ReadAllLines(link + "\\SoLuongSanPham.hsd");
                            foreach (string soLuongSP in fileSLSP)
                            {
                                Console.Write(soLuongSP);
                                soLuongHienTaiCuaSanPham = int.Parse(soLuongSP);
                            }
                        }
                        //hien thi don vi san pham
                        //neu file dong vi san pham co ton tai
                        if (File.Exists(link + "\\DonVi.hsd") == true)
                        {
                            string[] fileDonVi = File.ReadAllLines(link + "\\DonVi.hsd");
                            foreach (string DonVi in fileDonVi)
                            {
                                Console.WriteLine(" ({0})", DonVi);
                                donViSP = DonVi;
                            }
                        }
                        //nhap so luong can xoa
                        Console.Write("\nNHAP SO LUONG CAN XOA: ");
                        int.TryParse(Console.ReadLine(), out soLuongCanXoa);
                        //neu so luong can xoa lon hon hoac bang so luong dang co cua san pham, thi san pham se bi xoa khoi kho
                        if (soLuongCanXoa >= soLuongHienTaiCuaSanPham)
                        {
                            //xac nhan san pham
                            Console.Write("SO LUONG LON HON HOAC BANG SO LUONG DANG CO! SAN PHAM SE BI XOA HOAN TOAN! BAN CO MUON TIEP TUC? [Y][N]");
                            char.TryParse(Console.ReadLine(), out yn);
                            if (yn == 'Y' || yn == 'y')
                            {
                                //xoa san pham khoi kho
                                Directory.Delete(link, true);
                                //thong bao cho nguoi dung
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("SAN PHAM DA DUOC XOA KHOI KHO!");
                            }
                            else
                            {
                                //thong bao cho nguoi dung
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("SAN PHAM VAN CON TRONG KHO BAN CO THE KIEM TRA LAI.. :D");
                            }
                        }
                        //new so luong can xoa be hon so luong hien tai
                        if (soLuongCanXoa < soLuongHienTaiCuaSanPham)
                        {
                            soLuongMoiChoSanPham = soLuongHienTaiCuaSanPham - soLuongCanXoa;
                            //xoa so luong cu cua san pham
                            TextWriter xoaSoLuongCu = new StreamWriter(link + "\\SoLuongSanPham.hsd");
                            xoaSoLuongCu.Close();
                            //ghi so luong moi cho san pham
                            TextWriter soLuongMoi = new StreamWriter(link + "\\SoLuongSanPham.hsd", false);
                            soLuongMoi.WriteLine(soLuongMoiChoSanPham);
                            soLuongMoi.Close();
                            //thong bao cho nguoi dung
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("-SO LUONG MOI CUA SAN PHAM [{0}] LA {1} {2}...", nameSP, soLuongMoiChoSanPham, donViSP);
                        }
                    }
                    //neu san pham khong ton tai
                    if (Directory.Exists(link) == false)
                    {
                        //thong bao cho nguoi dung
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("KHONG TIM THAY SAN PHAM [{0}]..", nameSP);
                    }
                }
                //neu nguoi dung khong nhap ten san pham
                if (nameSP == "")
                {
                    //thong bao cho nguoi dung
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("TEN SAN PHAM KHONG DUOC DE TRONG!");
                }

            }
           Console.ResetColor();
            Console.ReadKey();
        }
        /// <summary>
        /// xoa san pham da het han
        /// </summary>
        /// <param name="link"></param>
        public static void XoaSanPham(string link)
        {
            char yn = ' ';
            int dem = 0;
            string b = link;
            link = link + "\\Thong Bao\\San Pham Can Xoa.txt";
            //tim so file can xoa
            string[] nhungSPHetHan = File.ReadAllLines(link);
            foreach (string SP in nhungSPHetHan)
            {
                dem++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("> ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(SP);
            }
            if (dem > 0)
            {
               Console.ResetColor();
                //thong bao cho nguoi dung
                Console.Write("TIM THAY {0} SAN PHAM DA QUA HAN SU DUNG, BAN CO MUON XOA CAC SAN PHAM NAY? [Y][N]", dem);
                char.TryParse(Console.ReadLine(), out yn);
            }
            if (dem == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("KHONG TIN THAY SAN PHAM NAO CAN XOA!");
            }
            if (yn == 'Y' || yn == 'y')
            {
                //neu file san pham da het han ton tai
                if (File.Exists(link) == true)
                {
                    string[] SPHetHan = File.ReadAllLines(link);
                    foreach (string linkDelete in SPHetHan)
                    {
                        //neu duong dan vao san pham can xoa ton tai
                        if (Directory.Exists(b + "\\" + linkDelete) == true)
                        {
                            Directory.Delete(b + "\\" + linkDelete, true);
                        }
                    }
                }
            }
            //xoa du lieu trong file
            if (File.Exists(link) == true)
            {
                TextWriter file = new StreamWriter(link);
                file.Close();
            }
        }
        /// <summary>
        /// kiem tra ket noi du lieu
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static string LinkConnectHSD(string link, string sDisk)
        {
            string newLink = "";
            //neu duong dan bang rong
            {
                link = sDisk + "/TTL/HSD/";
            }
            //neu duong dan da duoc thiet lap
            if (Directory.Exists(link) == true)
            {
                //lay du lieu file trong thu muc
                string[] getFile = Directory.GetFiles(link);
                foreach (string file in getFile)
                {
                    //new file co ton tai
                    if (File.Exists(file) == true)
                    {
                        //lay du lieu trong file
                        string[] getLink = File.ReadAllLines(file);
                        foreach (string linkConnect in getLink)
                        {
                            newLink = linkConnect;
                        }
                    }
                }
            }
            return newLink;
        }
        /// <summary>
        /// kiem tra ket noi du lieu
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public static string LinkConnectMusic(string link, string sDisk)
        {
            string newLink = "";
            //neu duong dan bang rong
            {
                link = sDisk + "/TTL/Music/";
            }
            //neu duong dan da duoc thiet lap
            if (Directory.Exists(link) == true)
            {
                //lay du lieu file trong thu muc
                string[] getFile = Directory.GetFiles(link);
                foreach (string file in getFile)
                {
                    //new file co ton tai
                    if (File.Exists(file) == true)
                    {
                        //lay du lieu trong file
                        string[] getLink = File.ReadAllLines(file);
                        foreach (string linkConnect in getLink)
                        {
                            newLink = linkConnect;
                        }
                    }
                }
            }
            return newLink;
        }
        //XE MAY/////////////////////////\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\//////////////////////////////////////\\\\\\\\
        /// <summary>
        /// xuat mang
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="link"></param>
        public static void XuatMang(string[] arr, string link)
        {
            int dem = 0;
            foreach (string j in arr)
            {
                dem++;
                if (link != "" || Directory.Exists(link) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("* ");
                }
                if (link == "" || Directory.Exists(link) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("* ");
                }
               Console.ResetColor();
                Console.WriteLine("[" + dem + "] " + j);
            }
        }
        /// <summary>
        /// su kien thay nhot
        /// </summary>
        /// <param name="link"></param>
        public static void MoiThayNhot(string link)
        {
            string linkKm1 = "";
            string linkKm2 = "";
            int soKmDaDuTinh = 0;
            int gioiHanSoKm = 0;
            int soKmTruocSoNhotHienTai = 0;
            string bienSoXe = "";
            int soKmMoiHienTai = 0;
            Console.Write("Nhap bien so xe: ");
            bienSoXe = Console.ReadLine();
            bienSoXe = bienSoXe.Replace(" ", "");
            if (Directory.Exists(link + bienSoXe) == true && bienSoXe != "")
            {
                HelpTTL ttl = new HelpTTL();
                //n?u t?m th?y bi?n s? xe
                BSXD(bienSoXe);
                linkKm1 = link + bienSoXe + "\\SoKmDau.bsx";
                linkKm2 = link + bienSoXe + "\\SoKmCuoi.bsx";
                // linkKm3 = link + bienSoXe + "\\SoKmVuaNhap.bsx";
                // linkKm4 = link + bienSoXe + "\\SoKmConLai.bsx";
                if (File.Exists(linkKm1) == false)
                {
                    FileStream fileNew = new FileStream(linkKm1, FileMode.Create);
                    fileNew.Close();
                    TextWriter fileKhoiTaoSoNhot = new StreamWriter(linkKm1);
                    fileKhoiTaoSoNhot.WriteLine("0");
                    fileKhoiTaoSoNhot.Close();
                }
                if (File.Exists(linkKm2) == false)
                {
                    FileStream fileNew = new FileStream(linkKm2, FileMode.Create);
                    fileNew.Close();
                }
                string[] fileNhot = File.ReadAllLines(linkKm1);
                foreach (string s in fileNhot)
                {
                    soKmTruocSoNhotHienTai = int.Parse(s);
                }
                //ki?m tra s? km hi?n t?i có trong h? th?ng
                string[] soKmHienTai = File.ReadAllLines(linkKm1);
                foreach (string s1 in soKmHienTai)
                {
                    Console.WriteLine("So Km hien tai " + s1 + " km");
                }
                //nh?p s? km hi?n t?i
                Console.Write("Nhap so km hien tai: ");
                int.TryParse(Console.ReadLine(), out soKmMoiHienTai);
                TextWriter fileNhotMoi = new StreamWriter(linkKm1, false);
                //n?u s? km hi?n t?i l?n h?n km có trong h? th?ng
                if (soKmMoiHienTai > soKmTruocSoNhotHienTai)
                {
                    Console.Write("Nhap gioi han km cho nhot vua thay: ");
                    int.TryParse(Console.ReadLine(), out gioiHanSoKm);
                    //n?u nh?p ?úng
                    if (gioiHanSoKm > 0)
                    {
                        //nh?p gi?i h?n cho l?n thay nh?t m?i nh?t
                        fileNhotMoi.WriteLine(soKmMoiHienTai);
                        fileNhotMoi.Close();
                        soKmDaDuTinh = soKmMoiHienTai + gioiHanSoKm;
                        TextWriter soNhotDuTinh = new StreamWriter(linkKm2, false);
                        soNhotDuTinh.WriteLine(soKmDaDuTinh);
                        soNhotDuTinh.Close();
                        // xoa du lieu trong file km vua nhap va km con lai
                        ttl.GhiDuLieuVaoFile(link + bienSoXe + "\\SoKmVuaNhap.bsx", 0, true);
                        ttl.GhiDuLieuVaoFile(link + bienSoXe + "\\SoKmConLai.bsx", 0, true);
                        ttl.GhiDuLieuVaoFile(link + bienSoXe + "\\SoKmVuotMuc.bsx", 0, true);
                    }
                    //n?u nh?p sai
                    if (gioiHanSoKm <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("So km khong chinh xac!");
                    }
                }
                //n?u s? km hi?n t?i bé h?n ho?c b?ng km có trong h? th?ng
                else if (soKmMoiHienTai <= soKmTruocSoNhotHienTai)
                {
                    //n?u nh?p sai th? s? km v?n gi? nguyên
                    fileNhotMoi.WriteLine(soKmTruocSoNhotHienTai);
                    fileNhotMoi.Close();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("So km khong chinh xac!");
                }
                //xu?t d? li?u m?i c?p nh?t
                Console.ForegroundColor = ConsoleColor.Green;
                string[] soKmHienTaiSauKhiNhap = File.ReadAllLines(linkKm1);
                foreach (string s1 in soKmHienTaiSauKhiNhap)
                {
                    Console.WriteLine("So Km hien tai " + s1);
                }
                string[] soKmDuTinh = File.ReadAllLines(linkKm2);
                foreach (string s2 in soKmDuTinh)
                {
                    Console.WriteLine("So Km du tinh " + s2);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("KHONG TIM THAY BIEN SO XE! [" + bienSoXe + "]");
            }
        }
        /// <summary>
        /// kiem tra so nhot con lai
        /// </summary>
        /// <param name="link"></param>
        public static void KiemTraNhot(string link)
        {
            int soKmConLai = 0;
            int num1 = 0;
            int num2 = 0;
            int soKmHienTai = 0;
            string bienSoXe = "";
            string linkKm1 = "";
            string linkKm2 = "";
            string linkKm3 = "";
            string linkKm4 = "";
            string linkKm5 = "";
            Console.Write("Nhap bien so xe: ");
            bienSoXe = Console.ReadLine();
            bienSoXe = bienSoXe.Replace(" ", "");
            if (Directory.Exists(link + bienSoXe) == true && bienSoXe != "")
            {
                //n?u t?m th?y bi?n s? xe
                BSXD(bienSoXe);
                linkKm1 = link + bienSoXe + "\\SoKmDau.bsx";
                linkKm2 = link + bienSoXe + "\\SoKmCuoi.bsx";
                linkKm3 = link + bienSoXe + "\\SoKmVuaNhap.bsx";
                linkKm4 = link + bienSoXe + "\\SoKmConLai.bsx";
                linkKm5 = link + bienSoXe + "\\SoKmVuotMuc.bsx";
                //ki?m tra ?i?u ki?n th? 1
                string[] file1 = File.ReadAllLines(linkKm1);
                foreach (string num in file1)
                {
                    num1 = int.Parse(num);
                }
                //ki?m tra ?i?u ki?n th? 1
                string[] file2 = File.ReadAllLines(linkKm2);
                foreach (string num in file2)
                {
                    num2 = int.Parse(num);
                }
                Console.Write("Nhap so km hien tai: ");
                int.TryParse(Console.ReadLine(), out soKmHienTai);
                if (soKmHienTai > num1 && soKmHienTai < num2)
                {
                    soKmConLai = num2 - soKmHienTai;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("So km con lai: " + soKmConLai);
                    //ki?m tra d? li?u
                    if (File.Exists(linkKm3) == false)
                    {
                        FileStream duLieuKmHienTai = new FileStream(linkKm3, FileMode.Create);
                        duLieuKmHienTai.Close();
                    }
                    if (File.Exists(linkKm4) == false)
                    {
                        FileStream duLieuKmConLai = new FileStream(linkKm4, FileMode.Create);
                        duLieuKmConLai.Close();
                    }
                    //ki?m tra ?i?u ki?n
                    if (File.Exists(linkKm5) == false)
                    {
                        FileStream duLieuVuotMuc = new FileStream(linkKm5, FileMode.Create);
                        duLieuVuotMuc.Close();
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    soKmConLai = num2 - soKmHienTai;
                    //nh?p d? li?u km v??t m?c cho phép
                    TextWriter textVuotMuc = new StreamWriter(linkKm5, false);
                    textVuotMuc.WriteLine(0);
                    textVuotMuc.Close();
                    //nh?p d? li?u km m?i nh?t
                    TextWriter text = new StreamWriter(linkKm3, false);
                    text.WriteLine(soKmHienTai);
                    text.Close();
                    //nh?p s? km c?n l?i
                    TextWriter text1 = new StreamWriter(linkKm4, false);
                    text1.WriteLine(soKmConLai);
                    text1.Close();
                }
                if (soKmHienTai > num1 && soKmHienTai > num2)
                {
                    //ki?m tra d? li?u
                    if (File.Exists(linkKm3) == false)
                    {
                        FileStream duLieuKmHienTai = new FileStream(linkKm3, FileMode.Create);
                        duLieuKmHienTai.Close();
                    }
                    if (File.Exists(linkKm4) == false)
                    {
                        FileStream duLieuKmConLai = new FileStream(linkKm4, FileMode.Create);
                        duLieuKmConLai.Close();
                    }
                    //nh?p d? li?u km m?i nh?t
                    TextWriter text = new StreamWriter(linkKm3, false);
                    text.WriteLine(soKmHienTai);
                    text.Close();
                    //nh?p s? km c?n l?i
                    TextWriter text1 = new StreamWriter(linkKm4, false);
                    text1.WriteLine(soKmConLai);
                    text1.Close();
                    //ki?m tra ?i?u ki?n
                    if (File.Exists(linkKm5) == false)
                    {
                        FileStream duLieuVuotMuc = new FileStream(linkKm5, FileMode.Create);
                        duLieuVuotMuc.Close();
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    soKmConLai = num2 - soKmHienTai;
                    Console.WriteLine("Ban da chay vuot qua muc " + -soKmConLai + " km");
                    //nh?p d? li?u km v??t m?c cho phép
                    TextWriter textVuotMuc = new StreamWriter(linkKm5, false);
                    textVuotMuc.WriteLine(-soKmConLai);
                    textVuotMuc.Close();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("KHONG TIM THAY BIEN SO XE! [" + bienSoXe + "]");
            }
        }
        /// <summary>
        /// them bien so xe moi
        /// </summary>
        /// <param name="link"></param>
        public static void ThemBienSoXe(string link)
        {
            char yn = ' ';
            string bienSoXeMoi = "";
            string tenXe = "";
            string nhaSanXuat = "";
            string linkThongTinXe = "";
            string linkTable1 = "";
            //n?u ???ng d?n ?? ???c thi?t l?p
            if (link != "")
            {
                Console.Write("Nhap ten xe: ");
                tenXe = Console.ReadLine();
                if (tenXe != "")
                {
                    Console.Write("Nhap ten nha san xuat: ");
                    nhaSanXuat = Console.ReadLine();
                }
                if (nhaSanXuat != "")
                {
                    Console.Write("Nhap bien so xe cua ban: ");
                    bienSoXeMoi = Console.ReadLine();
                    bienSoXeMoi = bienSoXeMoi.ToLower();
                    bienSoXeMoi = bienSoXeMoi.Replace(" ", "");
                    linkTable1 = link + "\\Table\\" + bienSoXeMoi;
                }
            }
            //n?u bi?n s? xe ?? ???c thi?t l?p
            if (bienSoXeMoi != "" && tenXe != "" && nhaSanXuat != "")
            {
                tenXe = tenXe.ToUpper();
                nhaSanXuat = nhaSanXuat.ToUpper();
                linkThongTinXe = link + bienSoXeMoi + "\\ThongTinXe.bsx";
                Console.WriteLine("[{0}] la bien so xe cua ban ban se cap nhat vao he thong? [Y][N]", bienSoXeMoi);
                char.TryParse(Console.ReadLine(), out yn);
                if (yn == 'Y' || yn == 'y')
                {
                    DirectoryInfo newBienSoXe = new DirectoryInfo(link + bienSoXeMoi);
                    newBienSoXe.Create();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bien so xe cua ban da duoc cap nhat tren he thong. Ban co the bat dau kiem tra tinh trang xe ngay bay gio :D");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tu choi cap nhat!");
                }
                FileStream file = new FileStream(linkThongTinXe, FileMode.Create);
                file.Close();
                TextWriter textThongTinXe = new StreamWriter(linkThongTinXe, false);
                textThongTinXe.WriteLine("TEN XE: " + tenXe);
                textThongTinXe.WriteLine("NHA SAN XUAT: " + nhaSanXuat);
                textThongTinXe.WriteLine("BIEN SO: " + bienSoXeMoi);
                textThongTinXe.Close();
            }
            //neu thu muc bien so xe trong thu muc [table] neu bang chua ton tai
            if (Directory.Exists(linkTable1) == false)
            {
                //tao thu muc
                DirectoryInfo newFolderBSX = new DirectoryInfo(linkTable1);
                newFolderBSX.Create();
                //tao file trong thu muc moi tao
                FileStream fileNewBSX = new FileStream(linkTable1 + "\\" + bienSoXeMoi, FileMode.Create);
                fileNewBSX.Close();
                //tao file ten bien so xe
                FileStream fileNameBSX = new FileStream(linkTable1 + "\\name.bsx", FileMode.Create);
                fileNameBSX.Close();
                //ghi bien so xe
                TextWriter textNameBSX = new StreamWriter(linkTable1 + "\\name.bsx", false);
                textNameBSX.WriteLine(bienSoXeMoi);
                textNameBSX.Close();
            }
        }
        /// <summary>
        /// xoa du lieu xe dang co
        /// </summary>
        /// <param name="link"></param>
        public static void XoaDuLieu(string link)
        {
            string b = link;
            int chosse = 0;
            string bienSoXeCanXoa = "";
            Console.Write("Ghi bien so xe can xoa: ");
            bienSoXeCanXoa = Console.ReadLine();
            bienSoXeCanXoa = bienSoXeCanXoa.Replace(" ", "");
            if (Directory.Exists(link + bienSoXeCanXoa) == true)
            {
                //n?u t?m th?y bi?n s? xe
                BSXD(bienSoXeCanXoa);
                link = link + bienSoXeCanXoa;
                Console.WriteLine("[1] xoa bien so xe");
                Console.WriteLine("[2] xoa du lieu cua xe");
                int.TryParse(Console.ReadLine(), out chosse);
                if (chosse == 1)
                {
                    Directory.Delete(b + "/Table/" + bienSoXeCanXoa, true);
                    Directory.Delete(link, true);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bien so xe da duoc xoa!");
                }
                if (chosse == 2)
                {
                    string[] file = Directory.GetFiles(link);
                    foreach (string s in file)
                    {
                        FileInfo fileDelete = new FileInfo(s);
                        fileDelete.Delete();
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thong tin xe da duoc xoa!");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("KHONG TIM THAY BIEN SO XE! [" + bienSoXeCanXoa + "]");
            }
        }
        /// <summary>
        /// kiem tra tinh trang xe
        /// </summary>
        /// <param name="link"></param>
        /// <param name="link1"></param>
        public static void TinhTrangXe(string link, string link1)
        {
            string bienSoXe = "";
            string linkTable1 = "";
            string colorTable = "";
            int numKmConLai = 0;
            int numKmVuotMuc = 0;
            int numKmVuaNhap = 0;
            int numKmCuoi = 0;
            string b = link + "\\Table\\";
            Console.Write("Nhap bien so xe: ");
            bienSoXe = Console.ReadLine();
            bienSoXe = bienSoXe.Replace(" ", "");
            linkTable1 = link + "\\Table\\" + bienSoXe;
            link = link + bienSoXe;
            HelpTTL ttl = new HelpTTL();
            // numKmConLai = ttl.LayDuLieuTrongFile(link + "\\SoKmConLai.bsx");
            // numKmVuotMuc = ttl.LayDuLieuTrongFile(link + "\\SoKmVuotMuc.bsx");
            //neu thu muc bien so se da ton tai
            if (Directory.Exists(linkTable1) == true)
            {
                //xoa du lieu cu trong bang
                TextWriter textDelete = new StreamWriter(linkTable1 + "\\" + bienSoXe);
                textDelete.Close();
                //nhap thong tin cua xe vao bang
                TextWriter textTTX = new StreamWriter(linkTable1 + "\\" + bienSoXe, true);
                if (File.Exists(link + "\\ThongTinXe.bsx") == true)
                {
                    string[] fileTTX = File.ReadAllLines(link + "\\ThongTinXe.bsx");
                    foreach (string thongTinXe in fileTTX)
                    {
                        textTTX.WriteLine(thongTinXe);
                    }
                }
                textTTX.Write("SO KM DAU: ");
                //lay so km dau
                if (File.Exists(link + "\\SoKmDau.bsx") == true)
                {
                    string[] fileTTXKmDau = File.ReadAllLines(link + "\\SoKmDau.bsx");
                    foreach (string thongTinXeKmDau in fileTTXKmDau)
                    {
                        textTTX.WriteLine(thongTinXeKmDau + " KM");
                    }
                }
                textTTX.Write("SO KM CUOI: ");
                //lay so km cuoi
                if (File.Exists(link + "\\SoKmCuoi.bsx") == true)
                {
                    string[] fileTTXKmCuoi = File.ReadAllLines(link + "\\SoKmCuoi.bsx");
                    foreach (string thongTinXeKmCuoi in fileTTXKmCuoi)
                    {
                        textTTX.WriteLine(thongTinXeKmCuoi + " KM");
                        numKmCuoi = int.Parse(thongTinXeKmCuoi);
                    }
                }
                textTTX.Write("SO KM VUA NHAP: ");
                //lay so km vua nhap
                if (File.Exists(link + "\\SoKmVuaNhap.bsx") == true)
                {
                    string[] fileTTXKmVuaNhap = File.ReadAllLines(link + "\\SoKmVuaNhap.bsx");
                    foreach (string thongTinXeKmVuaNhap in fileTTXKmVuaNhap)
                    {
                        textTTX.WriteLine(thongTinXeKmVuaNhap + " KM");
                        numKmVuaNhap = int.Parse(thongTinXeKmVuaNhap);
                    }
                }
                textTTX.Write("SO KM CON LAI: ");
                //lay so km con lai
                if (File.Exists(link + "\\SoKmConLai.bsx") == true)
                {
                    string[] fileTTXKmConLai = File.ReadAllLines(link + "\\SoKmConLai.bsx");
                    foreach (string thongTinXeKmConLai in fileTTXKmConLai)
                    {
                        textTTX.WriteLine(thongTinXeKmConLai + " KM");
                        numKmConLai = int.Parse(thongTinXeKmConLai);
                    }
                }
                textTTX.Write("SO KM VUOT MUC: ");
                //lay so km vuot muc
                if (File.Exists(link + "\\SoKmVuotMuc.bsx") == true)
                {
                    string[] fileTTXKmVuotMuc = File.ReadAllLines(link + "\\SoKmVuotMuc.bsx");
                    foreach (string thongTinXeKmVuotMuc in fileTTXKmVuotMuc)
                    {
                        textTTX.WriteLine(thongTinXeKmVuotMuc + " KM");
                        numKmVuotMuc = int.Parse(thongTinXeKmVuotMuc);
                    }
                }
                textTTX.Close();
            }
            //mau cho bang
            if ((numKmVuaNhap * 100 / numKmCuoi) > 30 && numKmVuotMuc == 0)
                colorTable = "1";
            if ((numKmVuaNhap * 100 / numKmCuoi) <= 30 && numKmVuotMuc == 0)
                colorTable = "2";
            if ((numKmVuaNhap * 100 / numKmCuoi) <= 30 && numKmVuotMuc > 0)
                colorTable = "3";
            //n?u bi?n s? xe ?úng
            BSXD(bienSoXe);
            //h??ng d?n s? d?ng
            HDSD();
            //bang
            ttl.ShowFileTTL(linkTable1, bienSoXe, colorTable);
        }
        //n?u bi?n s? xe ?úng
        public static void BSXD(string bienSoXe)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[ {0} ]", bienSoXe);
           Console.ResetColor();
        }
        //h??ng d?n s? d?ng
        public static void HDSD()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("CON TREN 30% KM ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("CON DUOI 30% KM ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("VUOT MUC CHO PHEP ");
        }
        //kiem tra ket noi
        public static string ConnectXM(string link)
        {
            string duongDanMoi = "";
            //thiet lap duong dan chinh
            link = @"C:\\TTL\\XeMay\\";
            //neu thu muc co ton tai
            if (Directory.Exists(link) == true)
            {
                //lay du lieu
                string[] getFile = Directory.GetFiles(link);
                foreach (string file in getFile)
                {
                    //lay du lieu trong file
                    string[] getLink = File.ReadAllLines(file);
                    foreach (string newLink in getLink)
                    {
                        duongDanMoi = newLink;
                    }
                }
            }
            return duongDanMoi;
        }
        ////////////////////////////////////////////////////////////////////NHAC NHO\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\///////////////////////////////
        ////// <summary>
        /// xuat mang
        /// </summary>
        /// <param name="NhacNho"></param>
        public static void XuatMang(string[] NhacNho)
        {
            for (int i = 0; i < NhacNho.Length; i++)
            {
                Console.WriteLine("[" + (i + 1) + "] " + NhacNho[i]);
            }
        }
        // xoa nhac nho cu~
        public static void XoaNhacNhoCu(string link)
        {
            int ngay = 0;
            int thang = 0;
            int nam = 0;
            HelpTTL ttl = new HelpTTL();
            string[] gF = Directory.GetDirectories(link);
            foreach (string nn in gF)
            {
                ngay = 0;
                thang = 0;
                nam = 0;
                ngay = ttl.LayDuLieuTrongFile(nn + "/Day.ttl");
                thang = ttl.LayDuLieuTrongFile(nn + "/Month.ttl");
                nam = ttl.LayDuLieuTrongFile(nn + "/Year.ttl");
                // xoa nhac nho neu nam nhac nho < nam hien tai
                if (nam < DateTime.Now.Year)
                    Directory.Delete(nn, true);
            }
        }
        /// <summary>
        /// them nhac nho moi
        /// </summary>
        /// <param name="link"></param>
        public static void ThemNhacNho(string link, string b)
        {
            string nameNN = "";
            string contentNN = "";
            string link7Day = b + "/7Day";
            DateTime date = new DateTime();
            //neu duong dan khac rong
            if (link != "")
            {
                HelpTTL ttl = new HelpTTL();
                //ghi nhac nho moi
                Console.Write("TEN NHAC NHO CUA BAN: ");
                nameNN = Console.ReadLine();
                nameNN = nameNN.ToLower();
                nameNN = nameNN.Replace(" ", "");
                link = link + "\\" + nameNN + "\\";
                //neu nhac nho chua ton tai
                //tien hanh tao nhac nho
                if (nameNN == "")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("TEN NHAC NHO KHONG DUOC DE TRONG!");
                }
                if (Directory.Exists(link) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("TRUNG TEN!");
                }
                if (nameNN != "" && Directory.Exists(link) == false)
                {
                    //tao nhac nho
                    DirectoryInfo newNN = new DirectoryInfo(link);
                    newNN.Create();
                    //ghi noi dung cua nhac nho
                    do
                    {
                        Console.Write("NOI DUNG CUA NHAC NHO: ");
                        contentNN = Console.ReadLine();
                        //neu noi dung cua nhac nho bang rong
                        if (contentNN == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NOI DUNG KHONG DUOC DE TRONG!");
                           Console.ResetColor();
                        }
                    } while (contentNN == "");
                    try
                    {
                        //nhap ngay thang nam hien thi nhac nho
                        Console.Write("NGAY/THANG/NAM> ");
                        date = DateTime.Parse(Console.ReadLine());
                        //tao file noi dung nhac nho
                        ttl.TaoFile(link, "Content.ttl");
                        //ghi noi dung nhac nho vao file
                        ttl.GhiDuLieuVaoFile(link + "\\Content.ttl", contentNN, true);
                        //tao file ngay hien thi nhac nho
                        ttl.TaoFile(link, "Day.ttl");
                        //ghi noi dung nhac nho vao file
                        ttl.GhiDuLieuVaoFile(link + "\\Day.ttl", date.Day, true);
                        //tao file thang nhac nho
                        ttl.TaoFile(link, "Month.ttl");
                        //ghi noi dung nhac nho vao file
                        ttl.GhiDuLieuVaoFile(link + "\\Month.ttl", date.Month, true);
                        //tao file nam hien thi nhac nho
                        ttl.TaoFile(link, "Year.ttl");
                        //ghi noi dung nhac nho vao file
                        ttl.GhiDuLieuVaoFile(link + "\\Year.ttl", date.Year, true);
                        //tao file ten nhac nho
                        ttl.TaoFile(link, "name.ttl");
                        //ghi noi dung nhac nho vao file
                        ttl.GhiDuLieuVaoFile(link + "\\name.ttl", nameNN, true);
                        Console.ForegroundColor = ConsoleColor.Green;
                        // tao file vao chuong trinh 7day
                        ttl.TaoFile(link7Day, date.Day + "-" + date.Month);
                        //ghi noi dung nhac nho vao file
                        ttl.GhiDuLieuVaoFile(link7Day + "/" + date.Day + "-" + date.Month, "<[NHAC NHO] " + contentNN + ">", false);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("DA THEM NHAC NHO :D");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        Directory.Delete(link, true);
                        Console.ReadKey();
                    }
                }
               Console.ResetColor();
                Console.ReadKey();
            }
        }
        /// <summary>
        /// xoa nhac nho
        /// </summary>
        /// <param name="link"></param>
        public static void XoaNhacNho(string link)
        {
            string nameNN = "";
            //neu duong dan khac rong
            if (link != "")
            {
                //ghi ten nhac nho can xoa
                Console.Write("TEN NHAC NHO CAN XOA: ");
                nameNN = Console.ReadLine();
                nameNN = nameNN.ToLower();
                nameNN = nameNN.Replace(" ", "");
                link = link + "\\" + nameNN;
                //neu duong dan co ton tai
                if (Directory.Exists(link) == true)
                {
                    //xoa nhac nho
                    Directory.Delete(link, true);
                    //thong bao cho nguoi dung
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DA XOA!");
                    Console.ReadKey();
                }
                //neu duong dan khong ton tai
                else
                {
                    //thong bao cho nguoi dung
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("KHONG TIM THAY NHAC NHO TREN!");
                    Console.ReadKey();
                }
            }
           Console.ResetColor();
        }
        /// <summary>
        /// thay doi noi dung cua nhac nho
        /// </summary>
        /// <param name="link"></param>
        public static void ThayDoiNoiDungNhacNho(string link)
        {
            string nameNN = "";
            string newContent = "";
            //neu duong dan khac rong
            if (link != "")
            {
                //ghi ten nhac nho can thay doi noi dung
                Console.Write("GHI TEN NHAC NHO CAN THAY DOI NOI DUNG: ");
                nameNN = Console.ReadLine();
                nameNN = nameNN.ToLower();
                nameNN = nameNN.Replace(" ", "");
                link = link + "\\" + nameNN;
                //neu duong dan co ton tai
                if (Directory.Exists(link) == true)
                {
                    //hien thi nhac nho cu
                    string[] fileNN = File.ReadAllLines(link + "\\Content.ttl");
                    foreach (string linesNN in fileNN)
                    {
                        Console.WriteLine("> " + linesNN);
                    }
                    //xoa noi dung cu
                    TextWriter deleteContent = new StreamWriter(link + "\\Content.ttl");
                    deleteContent.Close();
                    //ghi noi dung moi cho nhac nho tren
                    do
                    {
                        Console.Write("GHI NHAC NHO MOI: ");
                        newContent = Console.ReadLine();
                        //thong bao neu nhac nho bi bo trong
                        if (newContent == "")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NOI DUNG KHONG DUOC DE TRONG!");
                           Console.ResetColor();
                        }
                    } while (newContent == "");
                    //them noi dung moi vao nhac nho
                    TextWriter textNewContent = new StreamWriter(link + "\\Content.ttl", true);
                    textNewContent.WriteLine(newContent);
                    textNewContent.Close();
                    //thong bao cho nguoi dung
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("DA THEM NOI DUNG MOI VAO NHAC NHO :D");
                }
                //neu duong dan khong ton tai
                else
                {
                    //thong bao cho nguoi dung
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("KHONG TIM THAY NHAC NHO TREN!");
                }
            }
            Console.ReadKey();
           Console.ResetColor();
        }
        /// <summary>
        /// hien thi nhac nho
        /// </summary>
        /// <param name="link"></param>
        public static void ShowNhacNho(string link)
        {
            int num = 0;
            int demNN = 0;
            string nameNN = "";
            int dayNN = 0;
            int monthNN = 0;
            int yearNN = 0;
            int ngayNN = 100;
            int numHT = 0;
            int max = 0;
            int max1 = 0;
            int max2 = 0;
            //neu duong dan khac rong va file nhac nho co ton tai
            if (link != "" && Directory.Exists(link + "\\NhacNho\\") == true)
            {
                HelpTTL ttl = new HelpTTL();
                link = link + "\\NhacNho\\";
                //lay cac thu muc nhac nho
                string[] FoldersNN = Directory.GetDirectories(link);
                foreach (string LinkNN in FoldersNN)
                {
                    demNN++;
                    //neu duong dan la mot thu muc
                    if (Directory.Exists(LinkNN) == true)
                    {

                        dayNN = ttl.LayDuLieuTrongFile(LinkNN + "\\Day.ttl");
                        monthNN = ttl.LayDuLieuTrongFile(LinkNN + "\\Month.ttl");
                        yearNN = ttl.LayDuLieuTrongFile(LinkNN + "\\Year.ttl");
                        //neu ngay thang nam hien tai bang ngay thang nam trong nhac nho
                        if (DateTime.Now.Day == dayNN && DateTime.Now.Month == monthNN && DateTime.Now.Year == yearNN)
                        {
                            numHT++;
                            //hien thi thong bao nhac nho va gioi han so lan hien thong bao voi bien nun hien thi
                            if (DateTime.Now.Day == dayNN && numHT == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("\nDANG HIEN THI NHAC NHO NGAY {0} THANG {1} NAM {2}...", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                            }
                            //hien thi ten thong bao
                            string[] nameNhacNho = File.ReadAllLines(LinkNN + "\\name.ttl");
                            foreach (string lines in nameNhacNho)
                            {
                                nameNN = lines;
                            }
                            //hien thi nhac nho cho nguoi dung
                            string[] NhacNho = File.ReadAllLines(LinkNN + "\\Content.ttl");
                            foreach (string linesNN in NhacNho)
                            {
                                //tim dong co ky tu dai nhat
                                foreach (char ch in nameNN)
                                {
                                    max1++;
                                }
                                foreach (char chc in linesNN)
                                {
                                    max2++;
                                }
                                //so sach xem so nao lon nhat
                                if (max1 > max2)
                                {
                                    max = max1;
                                }
                                if (max1 <= max2)
                                {
                                    max = max2;
                                }
                                max = max + 1;
                                //hien thi nhac nho voi max
                                //ke vien tren
                                Console.Write(" ");
                                for (int i = 0; i < max; i++)
                                {
                                    Console.Write("_");
                                }
                                Console.WriteLine();
                                //hien thi nhac nho voi vien hai ben de noi bat noi dung cho nguoi dung
                                Console.Write("|");
                                Console.ResetColor();
                                Console.Write(nameNN);
                                //tao khoang trong trong nhac nho
                                for (int i = 0; i < max - max1; i++)
                                {
                                    Console.Write(" ");
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("|");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("|>" + linesNN);
                                //tao khoang trong trong nhac nho
                                for (int i = 0; i < max - max2 - 1; i++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write("|");
                                Console.WriteLine();
                                //ke vien duoi
                                Console.Write("|");
                                for (int i = 0; i < max; i++)
                                {
                                    Console.Write("_");
                                }
                                Console.Write("|");
                                Console.WriteLine();
                            }
                            num = 1;
                            max1 = 0;
                            max2 = 0;
                            max = 0;
                        }
                        //tim so ngay hien thi nhac nho gan nhatShowBD
                        if (yearNN == DateTime.Now.Year && monthNN == DateTime.Now.Month && dayNN < ngayNN)
                        {
                            ngayNN = dayNN;
                        }
                    }
                }
            }
           Console.ResetColor();
            ////hien thi thong bao nhac nho neu duong dan co ton tai
            if (Directory.Exists(link) == true && num == 0)
            {
                //hien thi thong bao nhac nho
                if (DateTime.Now.Day != dayNN)
                {
                    //neu ngay nhac nho bang 100
                    if (ngayNN == 100)
                    {
                        Console.WriteLine("\nKHONG TIM THAY NHAC NHO GAN NHAT TRONG THANG {0}...", DateTime.Now.Month);
                    }
                    //neu ngay nhac nho khac 100
                    if (ngayNN != 100)
                    {
                        Console.WriteLine("\nDANG CO {0} NHAC NHO, NHAC NHO GAN NHAT VAO NGAY {1} THANG {2} NAM {3}...", demNN, ngayNN, DateTime.Now.Month, DateTime.Now.Year);
                    }

                }
            }
        }
        //////////////////////////////////BIEU DO\\\\\\\\\\\\\\\\\\\\\\\\\////////////////////
        /// <summary>
        /// hien thi bieu do
        /// </summary>
        /// <param name="link"></param>
        public static void ShowBD(string link)
        {
            int dem,dem1 = 0;
            int demYear = 0;
            int ngayBD = 0;
            int thangBD = 0;
            int namBD = 0;
            int ngayKT = 0;
            int thangKT = 0;
            int namKT = 0;
            string linkSD = "";
            string linkP = "";
            string linkDelete = "";
            HelpTTL ttl = new HelpTTL();
            var datBD = new DateTime();
            var datKT = new DateTime();
            try
            {
                //neu duong dan khac rong
                if (link != "")
                    linkSD = link + "/BieuDo/";
                //neu duong dan co ton tai, lay cac thu muc trong duong dan
                if (Directory.Exists(linkSD) == true)
                {
                    string[] getFolder = Directory.GetDirectories(linkSD);
                    foreach (string linkFolder in getFolder)
                    {
                        //duong dan xoa thu muc neu thu muc bi loi
                        linkDelete = linkFolder;
                        //neu duong dan toi thu muc la dung
                        if (Directory.Exists(linkFolder) == true)
                        {
                            // tao file
                            ttl.TaoFile(linkFolder + "/Percent.txt");
                            // lay duong dan
                            linkP = linkFolder + "/Percent.txt";
                            //lay du kien trong file
                            datBD = new DateTime(ttl.LayDuLieuTrongFile(linkFolder + "/yearBD.ttl"), ttl.LayDuLieuTrongFile(linkFolder + "/monthBD.ttl"), ttl.LayDuLieuTrongFile(linkFolder + "/dayBD.ttl"));
                            datKT = new DateTime(ttl.LayDuLieuTrongFile(linkFolder + "/yearKT.ttl"), ttl.LayDuLieuTrongFile(linkFolder + "/monthKT.ttl"), ttl.LayDuLieuTrongFile(linkFolder + "/dayKT.ttl"));
                        }
                        //hien thi bieu do                 
                        //tinh ngay
                        dem = ttl.TinhNgay(datBD.Day,datBD.Month,datBD.Year,datKT.Day,datKT.Month,datKT.Year);
                        dem1 = ttl.TinhNgay(datBD.Day,datBD.Month,datBD.Year,DateTime.Now.Day,DateTime.Now.Month,DateTime.Now.Year);                 
                        //dem tong so nam cua bieu do
                        for (int ctrYear = namBD; ctrYear <= namKT; ctrYear++)
                        {
                            //??m s? ngày
                            demYear++;
                            //hi?n ngày
                            //Console.WriteLine(dat.AddDays(ctr).ToString("d"));
                            //?i?u ki?n d?ng v?ng l?pyp
                        }
                        //xoa thu muc
                        if (dem1 * 100 / dem > 100)
                            Directory.Delete(linkFolder, true);
                        //hien thi so do
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("\n {0}", ttl.LayDuLieuTrongFileStr(linkFolder + "/nameBD.ttl").ToUpper());
                        Console.ResetColor();
                        Console.WriteLine(" ({0}/{1}/{2} -> {3}/{4}/{5})",datBD.Day,datBD.Month,datBD.Year,datKT.Day,datKT.Month,datKT.Year);
                        Console.Write("|");
                        //Console.Write("[{0}-{1}-{2}]", dat.Day, dat.Month, dat.Year);
                        for (int i = 0; i < ttl.LayDuLieuTrongFile(link + "/NumLineTable.ttl") / 2; i++)
                        {
                            //mau
                            if ((dem1 * 100 / dem) < 30)
                                Console.ForegroundColor = ConsoleColor.Green;
                            else if ((dem1 * 100 / dem) < 80)
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            else
                                Console.ForegroundColor = ConsoleColor.Red;

                            Console.Write("_");
                        }
                        Console.WriteLine("_>");
                        //chay chuan doan phan tram
                        for (int phanTram = 0; phanTram < (dem1 * 100 / dem) * ttl.LayDuLieuTrongFile(link + "/NumLineTable.ttl") / 2 * 0.01 + 1; phanTram++)
                        {
                            // phan tram <= 100
                            if((dem1 * 100 / dem) * ttl.LayDuLieuTrongFile(link + "/NumLineTable.ttl") / 2 * 0.01 + 1 <= 100)
                                Console.Write(" ");
                            // khac
                            else
                                break;
                        }
                        Console.WriteLine("^{0}/{1}/{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                        //tao khoang trong cho phan tran so do
                        for (int numPS = 0; numPS < (dem1 * 100 / dem) * ttl.LayDuLieuTrongFile(link + "/NumLineTable.ttl") / 2 * 0.01 + 1; numPS++)
                        {
                            // phan tram <= 100
                            if((dem1 * 100 / dem) * ttl.LayDuLieuTrongFile(link + "/NumLineTable.ttl") / 2 * 0.01 + 1 <= 100)
                                Console.Write(" ");
                            // khac
                            else
                                break;
                        }
                        //mau
                        if ((dem1 * 100 / dem) < 30)
                            Console.ForegroundColor = ConsoleColor.Green;
                        else if ((dem1 * 100 / dem) < 80)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else{
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine(dem1 * 100 / dem + "%");
                        // ghi du lieu phan tram vao file
                        ttl.GhiDuLieuVaoFile(linkP,dem1 * 100 / dem  + "%",false);
                        Console.ResetColor();
                        //}
                        dem = 0;
                        dem1 = 0;
                        demYear = 0;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Directory.Delete(linkDelete, true);
            }
        }
        /// <summary>
        /// them bieu do moi
        /// </summary>
        /// <param name="link"></param>
        public static void AddBD(string link)
        {
            string nameBD = "";
            DateTime dtBD = new DateTime();
            DateTime dtKT = new DateTime();
            try
            {
                HelpTTL ttl = new HelpTTL();
                //nhap ten bieu do
                Console.Write("NHAP TEN BIEU DO: ");
                nameBD = Console.ReadLine();
                nameBD = nameBD.ToLower();
                nameBD = nameBD.Replace(" ", "");
                //ghi du lieu
                //neu duong dan khac rong
                if (nameBD != "" && link != "")
                {
                    //neu file thu muc chua ton tai
                    DirectoryInfo newFolder = new DirectoryInfo(link);
                    newFolder.Create();
                    //kiem tra duong dan xem bieu do co ton tai chua
                    link = link + "\\" + nameBD;
                    //neu file da ton tai
                    if (Directory.Exists(link) == true && nameBD != "")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("DU LIEU DA TON TAI!");
                        Console.ReadKey();
                    }
                    //neu duong dan chua ton tai
                    if (Directory.Exists(link) == false)
                    {
                        //tao thu muc bieu do moi
                        DirectoryInfo newBD = new DirectoryInfo(link);
                        newBD.Create();
                        //tao ne file bieu do
                        FileStream fileNameBD = new FileStream(link + "\\nameBD.ttl", FileMode.Create);
                        fileNameBD.Close();
                        //ghi ten bieu do vao file
                        TextWriter textNameBD = new StreamWriter(link + "\\nameBD.ttl", false);
                        textNameBD.WriteLine(nameBD);
                        textNameBD.Close();
                        //ghi ngay thang nam bat dau va ngay thang nam ket thuc cua bieu do
                        //ngay thang nam bat dau
                        Console.WriteLine("NGAY/THANG/NAM BAT DAU BIEU DO");
                        dtBD = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("NGAY/THANG/NAM KET THUC BIEU DO");
                        dtKT = DateTime.Parse(Console.ReadLine());
                        // tao file
                        ttl.TaoFile(link + "\\dayBD.ttl");
                        ttl.TaoFile(link + "\\monthBD.ttl");
                        ttl.TaoFile(link + "\\yearBD.ttl");
                        // nhap du lieu vao file
                        ttl.TaoFile(link + "\\dayKT.ttl");
                        ttl.TaoFile(link + "\\monthKT.ttl");
                        ttl.TaoFile(link + "\\yearKT.ttl");
                        // nhap du lieu vao file
                        // ngay/thang/nam bat dau
                        ttl.GhiDuLieuVaoFile(link + "\\dayBD.ttl", dtBD.Day, true);
                        ttl.GhiDuLieuVaoFile(link + "\\monthBD.ttl", dtBD.Month, true);
                        ttl.GhiDuLieuVaoFile(link + "\\yearBD.ttl", dtBD.Year, true);
                        // ngay/thang/nam ket thuc
                        ttl.GhiDuLieuVaoFile(link + "\\dayKT.ttl", dtKT.Day, true);
                        ttl.GhiDuLieuVaoFile(link + "\\monthKT.ttl", dtKT.Month, true);
                        ttl.GhiDuLieuVaoFile(link + "\\yearKT.ttl", dtKT.Year, true);
                        //thong bao cho nguoi dung
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("TAO DU LIEU THANH CONG :D");
                        Console.ReadKey();
                    }
                }
            }
            // xoa du lieu neu nhap sai
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                //xoa file
                Directory.Delete(link, true);
            }
            Console.ResetColor();
        }
        ///////////////////////////////////////TABLES/////////////////////////////////
        // thêm nhiều dòng mới cho bảng
        public static void NewLines(string c, string link)
        {
            int soDong = 0;
            string str = "";
            int numF = 0;
            int numFS = 0;
            //neu duong dan khac rong
            if (link != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "nls", "newlines");
                try
                {
                    soDong = int.Parse(str);
                }
                catch
                {

                }
                //neu co ten cua cot
                if (str.Replace(" ", "") != "" && soDong > 0 && soDong <= 1000)
                {
                    // lay du lieu trong file set
                    string[] getFileSet = Directory.GetFiles(link + "/set");
                    foreach (string fileSet in getFileSet)
                    {
                        numFS++;
                    }
                    // lấy file trong thu mục
                    string[] getFile = Directory.GetFiles(link);
                    foreach (string files in getFile)
                    {
                        numF++;
                    }

                    // tạo file
                    for (int i = 1; i <= (numF - 1) + soDong; i++)
                    {
                        if (File.Exists(link + "/line" + i + ".txt") == false)
                        {
                            FileStream f = new FileStream(link + "/line" + i + ".txt", FileMode.Create);
                            f.Close();
                            // ghi du lieu vao file
                            TextWriter tx = new StreamWriter(link + "/line" + i + ".txt", true);
                            for (int ii = 0; ii < numFS; ii++)
                            {
                                tx.WriteLine(" ");
                            }
                            tx.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// them cot moi
        /// </summary>
        /// <param name="c"></param>
        /// <param name="link"></param>
        public static void NewColumn(string c, string link)
        {
            int dem = 0;
            //int demCot = 0;
            string str = "";
            int demChar = 0;
            int xacNhan = 1;
            //string newData = "";
            //int numChieuNgang = 0;
            //neu duong dan khac rong
            if (link != "")
            {
                //neu ten bang khac rong
                if (c != "")
                {
                    // loc ky tu
                    HelpTTL ttl = new HelpTTL();
                    str = ttl.Loc2KyTu(c, "nc", "newcolumn");
                    //neu co ten cua cot
                    if (str.Replace(" ", "") != "")
                    {
                        do
                        {
                            dem++;
                            //neu duong dan khac rong va duong da co ton tai bang
                            if (link != "" && Directory.Exists(link) == true)
                            {
                                ttl.TaoThuMuc(link + "/ProtectColumn/");
                                ttl.TaoThuMuc(link + "/Name");
                                ttl.TaoFile(link + "/ProtectColumn/ProtectColumn");
                                //neu file khoang trong ke tiep da ton tai
                                if (File.Exists(link + "\\set\\space" + dem + ".txt") == true)
                                {
                                    dem++;
                                    xacNhan = 0;
                                }
                                //neu file dong ke tiep chua ton tai
                                if (File.Exists(link + "\\set\\space" + dem + ".txt") == false)
                                {
                                    //tao file khoang trong ke tiep
                                    FileStream fileNew = new FileStream(link + "\\set\\space" + dem + ".txt", FileMode.Create);
                                    fileNew.Close();
                                    //doc ky tu cua ten bang
                                    foreach (char ch in str)
                                    {
                                        demChar++;
                                    }
                                    //ghi so khoang cach ngang cua o
                                    // do
                                    // {
                                    //     Console.Write("GHI CHIEU NGANG CUA COT > {0} : ", demChar + 1);
                                    //     int.TryParse(Console.ReadLine(), out numChieuNgang);
                                    // } while (numChieuNgang <= demChar + 1);
                                    TextWriter newNum = new StreamWriter(link + "\\set\\space" + dem + ".txt", false);
                                    newNum.WriteLine(demChar + 2);
                                    newNum.Close();
                                    xacNhan = 1;
                                    //ghi ten cot
                                    TextWriter textNameColumn = new StreamWriter(link + "/Name/name.txt", true);
                                    textNameColumn.WriteLine(str.ToLower());
                                    textNameColumn.Close();
                                    //ghi du lieu moi vao cot
                                    //lay cac file co chua thong tin hang ngang
                                    string[] files = Directory.GetFiles(link);
                                    foreach (string file in files)
                                    {
                                        //neu du lieu file khac file name
                                        if (file != link + "/Name/name.txt")
                                        {
                                            //demCot++;
                                            ////ghi noi dung moi vao file
                                            TextWriter textNewColumn = new StreamWriter(file, true);

                                            textNewColumn.WriteLine(" ");
                                            ////}
                                            textNewColumn.Close();
                                        }

                                    }
                                }
                            }
                        } while (xacNhan != 1);
                    }
                }
            }
        }
        /// <summary>
        /// tao mau sac cho tung chu
        /// </summary>
        /// <param name="c"></param>
        /// <param name="link"></param>
        public static void Rainbow(string c, string link, string b, string nameTable)
        {
            string str = "";
            string color = "";
            //neu duong dan khac rong
            if (link != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "color");
                //neu ten can to mau khac rong~
                if (str.Replace(" ", "") != "")
                {
                    // xoa chu dang co ra khoi nhung file khac cung cap
                    ttl.XoaChuTrongFileTrongThuMucCungCap(str, link + nameTable + "/Rainbow/");
                    Console.Write("color ");
                    color = Console.ReadLine();
                    //neu mau sac khac rong~
                    if (color.Replace(" ", "") != "")
                    {
                        // neu file chua ton tai
                        ttl.TaoFile(link + nameTable + "/Rainbow/" + color.Replace(" ", "").ToLower());
                        // ghi du lieu vao file
                        ttl.GhiDuLieuVaoFile(link + nameTable + "/Rainbow/" + color.Replace(" ", "").ToLower(), str, false);
                    }
                }
                // xoa mau sac
                str = ttl.Loc1KyTu(c, "deletecolor");
                //neu ten can to mau khac rong~
                if (str.Replace(" ", "") != "")
                {
                    // xoa chu dang co ra khoi nhung file khac cung cap
                    ttl.XoaChuTrongFileTrongThuMucCungCap(str, link + nameTable + "/Rainbow/");
                }
            }
        }
        // tao bang moi
        public static void NewTable(string c, string link, string b)
        {
            string str = "";
            //neu duong dan khac rong
            if (link != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "createtable");
                //neu bang da ton tai
                if (Directory.Exists(link + str) == true && str.Replace(" ", "") != "")
                {
                    //thong bao cho nguoi dung
                    ttl.HienThiThongBao("TABLE!", "TEN BANG DA TON TAI!", 64, b);
                }
                if (Directory.Exists(link + str) == false && str.Replace(" ", "") != "")
                {
                    //tao thu muc chua bang moi
                    DirectoryInfo newFolder = new DirectoryInfo(link + str);
                    newFolder.Create();
                    //thong bao cho nguoi dung
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("BANG {0} DA DUOC TAO..", str);
                   Console.ResetColor();
                    Console.ReadKey();
                    // tao thu muc rainbow
                    ttl.TaoThuMuc(link + str + "/Rainbow");
                }
            }

        }
        /// <summary>
        /// them dong moi cho bang
        /// </summary>
        /// <param name="line"></param>
        public static void NewLine(string link)
        {
            int dem = 0;
            //int demDataInput = 0;
            int xacNhan = 0;
            //string newData = "";
            do
            {
                dem++;
                //neu duong dan khac rong va duong da co ton tai bang
                if (link != "" && Directory.Exists(link) == true)
                {
                    //neu file dong ke tiep da ton tai
                    if (File.Exists(link + "line" + dem + ".txt") == true)
                    {
                        dem++;
                        xacNhan = 0;
                    }
                    //neu file dong ke tiep chua ton tai
                    if (File.Exists(link + "line" + dem + ".txt") == false)
                    {
                        do
                        {
                            //tao file dong ke tiep
                            FileStream fileNew = new FileStream(link + "line" + dem + ".txt", FileMode.Create);
                            fileNew.Close();
                            xacNhan = 1;
                        } while (File.Exists(link + "line" + dem + ".txt") == false);

                    }
                }
            } while (xacNhan != 1);
            //thong bao cho nguoi dung
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DONG THU {0} DA DUOC TAO, HAY NHAP DU LIEU CHO COT...", dem);
           Console.ResetColor();
            //tao vong lap nhap du lieu
            //hien thi ten cot can nhap du lieu
            //dem so cot cua bang
            string[] file = File.ReadAllLines(link + "/Name/name.txt");
            TextWriter newTextData = new StreamWriter(link + "line" + dem + ".txt", true);
            foreach (string lines in file)
            {

                //Console.Write("NHAP DU LIEU CHO COT [{0}]>", lines);
                //newData = Console.ReadLine();
                ////neu du lieu nhap vao khac rong
                //if (newData != "")
                //{
                //    demDataInput++;
                //    //ghi du lieu moi vao file
                //    newTextData.WriteLine(newData);
                //}
                ////neu nguoi dung khong nhap du lieu
                //if (newData == "")
                //{
                //    demDataInput++;
                //ghi du lieu moi vao file
                newTextData.WriteLine(" ");
                //}
            }
            newTextData.Close();
        }
        /// <summary>
        /// mo bang
        /// </summary>
        /// <param name="c"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        public static string OpenTable(string c, string link, string b)
        {
            string str = "";
            //neu duong dan khac rong
            if (link != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "opentable","opt");
                if (Directory.Exists(link + "/" + str) == true){
                    // tao thu muc chua thoi gian truy cap
                    ttl.TaoThuMuc(link + str + "/Date");
                    // tao file
                    ttl.TaoFile(link + str + "/Date/day.txt");
                    ttl.TaoFile(link + str + "/Date/month.txt");
                    ttl.TaoFile(link + str + "/Date/year.txt");
                    // ghi ngay truy cap thu muc
                    ttl.GhiDuLieuVaoFile(link + str + "/Date/day.txt", DateTime.Now.Day, true);
                    ttl.GhiDuLieuVaoFile(link + str + "/Date/month.txt", DateTime.Now.Month, true);
                    ttl.GhiDuLieuVaoFile(link + str + "/Date/year.txt", DateTime.Now.Year, true);
                    return str;
                }
                else
                {
                    ttl.HienThiThongBao("TABLE!", "KHONG TIM THAY TEN BANG '" + str + "'", 32, b);
                    return "";
                }
            }
           Console.ResetColor();
            return str;
        }
        /// <summary>
        /// thay d?i toàn b? kích thu?c b?ng
        /// </summary>
        /// <param name="c"></param>
        /// <param name="linkTable"></param>
        /// <param name="nameTable"></param>
        public static void ChangeAllTable(string c, string linkTable, string nameTable)
        {
            string str = "";
            int numSpace = 0;
            string link = "";
            //neu duong dan khac rong
            if (linkTable != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "cas", "changeallspace");
                try
                {
                    numSpace = int.Parse(str);
                }
                catch
                {

                }
                if (numSpace != 0)
                {
                    link = linkTable + "/" + nameTable + "/set/";
                    //láy các file trong thu muc
                    string[] files = Directory.GetFiles(link);
                    foreach (string file in files)
                    {
                        TextWriter tx = new StreamWriter(file, false);
                        tx.WriteLine(numSpace);
                        tx.Close();
                    }
                }
            }
        }
        /// <summary>
        /// xoa dong trong bang
        /// </summary>
        /// <param name="c"></param>
        /// <param name="link"></param>
        /// <param name="link1"></param>
        public static void DeleteLineTables(string c, string linkTable, string nameTable)
        {
            string chu = "";
            string chu1 = "";
            int xacNhan = 0;
            int numLine = 0;
            int numSumLine = 0;
            int numCheck = 0;
            int numLineF = 0;
            int numLineL = 0;
            int numDeleteLine = 0;
            int numName = 0;
            int numFixLine = 0;
            int numXacNhanXoa = 0;
            int numFilePTL = 0;
            string linkAccess = "";
            string sNumLine = "";
            //neu thu muc chua file protect line chua ton tai
            if (Directory.Exists(linkTable + "/" + nameTable + "/ProtectLine") == false)
            {
                //tao thu muc moi
                DirectoryInfo newFolder = new DirectoryInfo(linkTable + "/" + nameTable + "/ProtectLine");
                newFolder.Create();
            }
            //neu file chua du lieu bao ve dong chua ton tai
            if (File.Exists(linkTable + "/" + nameTable + "/ProtectLine/ProtectLine") == false)
            {
                //tao file moi
                FileStream fileNew = new FileStream(linkTable + "/" + nameTable + "/ProtectLine/ProtectLine", FileMode.Create);
                fileNew.Close();
            }
            //neu duong dan khac rong
            if (linkTable != "" && c != "" && nameTable != "")
            {
                //do ky tu trong nhap vao
                foreach (char ch in c)
                {
                    //cong chuoi
                    chu = chu + ch;
                    if (xacNhan == 1)
                    {
                        chu1 = chu1 + ch;
                    }
                    //tim kiem tu khoa
                    if (chu == "deleteline" || chu == "dl")
                    {
                        //Console.ForegroundColor = ConsoleColor.Green;
                        //Console.WriteLine(chu);
                        //Console.ForegroundColor = ConsoleColor.Gray;
                        xacNhan = 1;
                    }
                }
                //ket qua sau khi so sanh chu
                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.Write(" + ::::" + chu1);
                //Console.ForegroundColor = ConsoleColor.Gray;
                if (chu1 != "")
                {
                    try
                    {
                        numLine = int.Parse(chu1);
                    }
                    catch
                    {

                    }
                    sNumLine = sNumLine + numLine;
                    //kiem tra dong can xoa co dang duoc bao ve
                    string[] fileProtectLine = File.ReadAllLines(linkTable + "/" + nameTable + "/ProtectLine/ProtectLine");
                    foreach (string linesFileProtect in fileProtectLine)
                    {
                        //neu dong can xoa dang duoc bao ve
                        if (sNumLine == linesFileProtect)
                        {
                            numLine = 0;
                        }
                    }
                    //neu so dong can xoa khac 0
                    if (numLine != 0)
                    {
                        //thay doi dia chi truy cap
                        linkAccess = linkTable + "/" + nameTable + "/line" + numLine + ".txt";
                        //neu file co ton tai
                        if (File.Exists(linkAccess) == true)
                        {
                            //dem so dong dang co trong file
                            string[] fileRead = File.ReadAllLines(linkAccess);
                            foreach (string lines in fileRead)
                            {
                                numSumLine++;
                            }
                            //xoa du lieu trong file
                            FileStream fileNew = new FileStream(linkAccess, FileMode.Create);
                            fileNew.Close();
                            //tao khoang trong trong file de tranh loi mat cot chia trong bang, ghi du lieu
                            TextWriter textFile = new StreamWriter(linkAccess, true);
                            do
                            {
                                numCheck++;
                                textFile.WriteLine(" ");
                            } while (numCheck <= numSumLine);
                            textFile.Close();
                        }
                    }
                }
                //neu chu1 == ""
                if (chu1 == "" && xacNhan == 1)
                {
                    //nhap du lieu cua dong dau tien
                    Console.Write("FIRST LINE>");
                    int.TryParse(Console.ReadLine(), out numLineF);
                    //nhap du lieu dong cuoi cung
                    Console.Write("LAST LINE>");
                    int.TryParse(Console.ReadLine(), out numLineL);
                    //neu du lieu cua dong dau va dong cuoi co ton tai trong bang
                    if (File.Exists(linkTable + "/" + nameTable + "/line" + numLineF + ".txt") == true && File.Exists(linkTable + "/" + nameTable + "/line" + numLineF + ".txt") == true)
                    {
                        //doc du lieu trong file name
                        string[] fileName = File.ReadAllLines(linkTable + "/" + nameTable + "/Name/name.txt");
                        foreach (string linesName in fileName)
                        {
                            numName++;
                        }
                        //xoa du lieu cua nhieu dong trong bang
                        if (numLineL > numLineF)
                        {
                            numDeleteLine = numLineF;
                            do
                            {
                                numXacNhanXoa = 0;
                                //kiem tra du lieu trong file protect line
                                string[] filePTL = File.ReadAllLines(linkTable + "/" + nameTable + "/ProtectLine/ProtectLine");
                                foreach (string linesFPL in filePTL)
                                {
                                    try
                                    {
                                        numFilePTL = int.Parse(linesFPL);
                                    }
                                    catch
                                    {

                                    }
                                    //neu dong can xoa dang co du lieu bao ve trong file
                                    if (numDeleteLine == numFilePTL)
                                        numXacNhanXoa = 1;
                                }
                                //neu xac nhan xoa bang 0
                                if (numXacNhanXoa == 0)
                                {
                                    //xoa du lieu trong file line
                                    TextWriter text = new StreamWriter(linkTable + "/" + nameTable + "/line" + numDeleteLine + ".txt");
                                    text.Close();
                                    //ghi khoang trong vao file de sua loi bang
                                    TextWriter text1 = new StreamWriter(linkTable + "/" + nameTable + "/line" + numDeleteLine + ".txt");
                                    do
                                    {
                                        numFixLine++;
                                        text1.WriteLine(" ");
                                    } while (numFixLine <= numName);
                                    numFixLine = 0;
                                    text1.Close();
                                }
                                numDeleteLine++;
                            } while (numDeleteLine <= numLineL);
                        }
                    }
                }
            }
        }
        // cai dat so dong hien thi
        public static void SetLineShow(int num1, int num2, string linkTable, string nameTable)
        {
            if (num2 >= num1 && num1 > 0 && num2 > 0)
            {
                HelpTTL ttl = new HelpTTL();
                // tao thu muc
                ttl.TaoThuMuc(linkTable + nameTable + "/SetLineShow");
                //tai file 1
                ttl.TaoFile(linkTable + nameTable + "/SetLineShow/setline1");
                // ghi du lieu vao file
                ttl.GhiDuLieuVaoFile(linkTable + nameTable + "/SetLineShow/setline1", num1, true);
                //tao file 2
                ttl.TaoFile(linkTable + nameTable + "/SetLineShow/setline2");
                // ghi du lieu vao file
                ttl.GhiDuLieuVaoFile(linkTable + nameTable + "/SetLineShow/setline2", num2, true);
                // xoa file line0 (dung de sua loi move column vs copy column) -neu khong co dong nay khi su dung 2 chuc nang kia se bi loi~ tu dong' 0 tro di
                if (File.Exists(linkTable + nameTable + "/line0.txt") == true)
                    File.Delete(linkTable + nameTable + "/line0.txt");

            }
            // xoa file slst
            if (num1 < 0 || num2 < 0)
                Directory.Delete(linkTable + nameTable + "/SetLineShow", true);

        }
        //kill line xoa dong va khoang trang cua dong
        public static void KillLine(string c, string linkTable, string nameTable, int numFile, string b)
        {
            string str = "";
            int numLine = 0;
            string linkAccess = "";
            string sNumLine = "";
            //neu duong dan khac rong
            if (linkTable != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "kl", "killline");
                if (str.Replace(" ", "") != "")
                {
                    try
                    {
                        numLine = int.Parse(str);
                    }
                    catch
                    {

                    }
                    sNumLine = sNumLine + numLine;
                    //thay doi duong dan
                    linkAccess = linkTable + "/" + nameTable + "/ProtectLine/";
                    //neu thu muc chua file chua ton tai
                    if (Directory.Exists(linkAccess) == false)
                    {
                        //tao thu muc moi
                        DirectoryInfo newFolder = new DirectoryInfo(linkAccess);
                        newFolder.Create();
                    }
                    //neu file ghi du lieu chua ton tai
                    if (File.Exists(linkAccess + "ProtectLine") == false)
                    {
                        //tao file moi chua cac dong chong ghi
                        FileStream fileNew = new FileStream(linkAccess + "ProtectLine", FileMode.Create);
                        fileNew.Close();
                    }
                    //kiem tra dong can xoa co dang duoc bao ve
                    string[] fileProtectLine = File.ReadAllLines(linkTable + "/" + nameTable + "/ProtectLine/ProtectLine");
                    foreach (string linesFileProtect in fileProtectLine)
                    {
                        //neu dong can xoa dang duoc bao ve
                        if (sNumLine == linesFileProtect)
                        {
                            numLine = 0;
                        }
                    }
                    //neu so dong can xoa khac 0
                    if (numLine >= 0 && numLine <= numFile)
                    {
                        //thay doi dia chi truy cap
                        linkAccess = linkTable + "/" + nameTable + "/line" + numLine + ".txt";
                        //neu duong dan da ton tai tien hanh thay doi noi dung trong file
                        if (File.Exists(linkAccess) == true)
                        {
                            //xoa file
                            File.Delete(linkAccess);
                        }
                    }
                    // thong bao cho nguoi dung
                    if (numLine < 0 || numLine > numFile)
                        ttl.HienThiThongBao("TABLE!", "KHONG TIM THAY DONG (" + numLine + ") TRONG BANG!", 16, b);
                }
            }
        }
        /// <summary>
        /// hien thi bang, show table
        /// </summary>
        /// <param name="link"></param>
        public static void ShowTableTKB(string link, string c, string cc, string nameTable, string linkXuatFile)
        {
            string linkSet = "";
            string linkSet1 = "";
            int numLineTable = 0;
            int numGachGiua = 0;
            int dem = 0;
            int demChar = 0;
            int demChar1 = 0;
            int demChar2 = 0;
            int demCharElse = 0;
            int dem1 = 0;
            int dem2 = 0;
            int demSpace = 0;
            int demSpace1 = 0;
            int demSpaceFixBug = 0;
            int numSpace = 0;
            int numSpace1 = 0;
            int numExit = 0;
            int saveFile = 0;
            int numProtect = 0;
            int xacNhan = 0;
            string sLine = "";
            string sLine1 = "";
            string linkColorTables = link + "/ColorTable/Color";
            string linkColorWordTables = link + "/ColorWordTable/Color";
            string colorTables = "";
            string colorWordTables = "";
            int iShowBV = 0;
            int numLine1 = 0;
            int numLine2 = 0;
            int iWhen = 0;
            int iNumPer1, iNumPer2 = 0;
            int iNumTrue, iNumFasle = 0;
            string sShowPercent, sShowWhen, sShowF, bShowTrueFalse = "";
            string sShowElse = "";
            HelpTTL ttl = new HelpTTL();
            // lay du lieu percent
            iNumPer1 = ttl.LayDuLieuTrongFile(link + "/Percent/Column1.txt");
            iNumPer2 = ttl.LayDuLieuTrongFile(link + "/Percent/Column2.txt");
            // lay du lieu true false
            iNumTrue = ttl.LayDuLieuTrongFile(link + "/TrueFalse/Column1.txt");
            iNumFasle = ttl.LayDuLieuTrongFile(link + "/TrueFalse/Column2.txt");
            // Console.WriteLine(iNumPer1 + " = " + iNumPer2);
            // Console.ReadKey();
            // //xoa man hinh
            // Console.Clear();
            //neu duong dan khac rong va duong da co ton tai
            if (link != "" && nameTable != "")
            {
                //thay doi duong dan
                linkSet = link + "set";
                linkSet1 = link + "set1";
                //lay du lieu mau trong file mau bang
                if (File.Exists(linkColorTables) == true)
                {
                    string[] fileColorTable = File.ReadAllLines(linkColorTables);
                    foreach (string linesColor in fileColorTable)
                    {
                        colorTables = linesColor;
                    }
                }
                //lay du lieu trong file mau chu cua bang
                if (File.Exists(linkColorWordTables) == true)
                {
                    string[] fileColorWordTable = File.ReadAllLines(linkColorWordTables);
                    foreach (string linesColorWord in fileColorWordTable)
                    {
                        colorWordTables = linesColorWord;
                    }
                }
                //neu duong dan dem thu muc cai dat 2 da ton tai thi xoa thu muc
                if (Directory.Exists(linkSet1) == true)
                {
                    Directory.Delete(linkSet1, true);
                }
                //tao duong dan neu thu muc chua ton tai
                if (Directory.Exists(linkSet) == false)
                {
                    DirectoryInfo newFolder = new DirectoryInfo(linkSet);
                    newFolder.Create();
                }
                if (Directory.Exists(linkSet1) == false)
                {
                    DirectoryInfo newFolder = new DirectoryInfo(linkSet1);
                    newFolder.Create();
                }
                //lay du lieu trong thu muc ten
                if (File.Exists(link + "/Name/name.txt") == true)
                {
                    //dem ky tu trong ten cot
                    string[] fileName = File.ReadAllLines(link + "/Name/name.txt");
                    foreach (string name in fileName)
                    {
                        //doc ky tu trong ten cot
                        foreach (char ch in name)
                        {
                            demChar++;
                        }
                    }
                    //dem so lan tao thanh chan
                    string[] fileName2 = File.ReadAllLines(link + "/Name/name.txt");
                    foreach (string name in fileName2)
                    {
                        dem1++;
                    }
                    //lay so khoang trong cua numspace cho gach dau
                    string[] filesSpace = Directory.GetFiles(linkSet);
                    foreach (string file in filesSpace)
                    {
                        //dem so ky tu de giam thieu loi
                        dem2++;
                        //doc du lieu trong file
                        string[] fileSpace = File.ReadAllLines(file);
                        foreach (string fileNumSpace in fileSpace)
                        {
                            numSpace = int.Parse(fileNumSpace);
                        }
                        //lay numspace1
                        if (numSpace > 0)
                        {
                            numSpace1 = numSpace + numSpace1;
                        }
                    }
                    //Console.WriteLine(numSpace1);
                    ttl.ColorTTL(colorTables);
                    //hien thi gach dau
                    Console.Write(" ");
                    // xuat thong tin bang ra file
                    ttl.Write(linkXuatFile, " ");
                    for (int i = 0; i <= demChar + dem1 + numSpace1 + dem2 - 2; i++)
                    {
                        Console.Write("_");
                        // xuat thong tin bang ra file
                        ttl.Write(linkXuatFile, "_");
                    }
                    numGachGiua = demChar + dem1 + numSpace1 + dem2 - 2;
                    Console.WriteLine();
                    // xuat thong tin bang ra file
                    ttl.WriteLine(linkXuatFile, "");
                    //hien thi gach cuoi
                    //hien thi ten thu muc
                    demChar = 0;
                    numSpace = 0;
                    string[] fileName1 = File.ReadAllLines(link + "/Name/name.txt");
                    foreach (string name in fileName1)
                    {
                        iShowBV = 0;
                        //hien thi mau cua bang
                        ttl.ColorTTL(colorTables);
                        demSpace++;
                        Console.Write("|");
                        // xuat thong tin bang ra file
                        ttl.Write(linkXuatFile, "|");
                        // giữ màu bảng luôn là màu trắng
                        Console.ForegroundColor = ConsoleColor.White;
                        // kiem tra ten cot co dang duoc bao ve
                        string[] filePTC = File.ReadAllLines(link + "/ProtectColumn/ProtectColumn");
                        foreach (string lines in filePTC)
                        {
                            if (name.ToLower() == lines.ToLower().Replace(" ", ""))
                            {
                                iShowBV = 1;
                            }
                        }
                        // neu ten bang da khong duoc bao ve ten bang se chuyen sang mau trang
                        if (iShowBV == 0)
                            Console.ForegroundColor = ConsoleColor.White;
                        // thay doi mau neu cot co cau hoi
                        if (Directory.Exists(link + "/Question/" + name.ToLower().Replace(" ", "")) == true)
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        // neu ten bang dang duoc bao ve ten bang se chuyen sang mau do
                        if (iShowBV == 1)
                            Console.ForegroundColor = ConsoleColor.Red;
                        //hien thi ten bang
                        Console.Write(name.ToUpper());
                        // xuat thong tin bang ra file
                        ttl.Write(linkXuatFile, name.ToUpper());
                        //doc ky tu trong ten cot
                        foreach (char ch in name)
                        {
                            demChar++;
                        }
                        //tao khoang cach o cot thu n
                        if (File.Exists(link + "set\\space" + demSpace + ".txt") == true)
                        {
                            //doc du lieu trong file
                            string[] fileSpace = File.ReadAllLines(link + "set\\space" + demSpace + ".txt");
                            foreach (string fileNumSpace in fileSpace)
                            {
                                numSpace = int.Parse(fileNumSpace);
                            }
                            //tao khoang trong
                            for (int i = 0; i <= numSpace; i++)
                            {
                                Console.Write(" ");
                                // xuat thong tin bang ra file
                                ttl.Write(linkXuatFile, " ");
                            }
                            //ghi du lieu moi vao file file set1
                            //tao thu muc moi vao file set1
                            FileStream fileNew = new FileStream(linkSet1 + "\\space" + demSpace + ".txt", FileMode.Create);
                            fileNew.Close();
                            //ghi du lieu moi vao file moi
                            TextWriter newText = new StreamWriter(linkSet1 + "\\space" + demSpace + ".txt", false);
                            newText.WriteLine(demChar + numSpace + 1);
                            newText.Close();
                            demChar = 0;
                            numSpace = 0;
                        }
                    }
                    //hien thi mau cua bang
                    ttl.ColorTTL(colorTables);
                    Console.Write("|");
                    // xuat thong tin bang ra file
                    ttl.Write(linkXuatFile, "|");
                    Console.WriteLine();
                    // xuat thong tin bang ra file
                    ttl.WriteLine(linkXuatFile, "");
                    demChar = 0;
                }
                //hien thi mau cua bang
                ttl.ColorTTL(colorTables);
                //hien thi gach giua
                Console.Write("|");
                // xuat thong tin bang ra file
                ttl.Write(linkXuatFile, "|");
                string[] filesSpace20 = Directory.GetFiles(linkSet1);
                foreach (string file in filesSpace20)
                {
                    demSpace1++;
                    //neu trung file
                    if (File.Exists(link + "set1/space" + demSpace1 + ".txt") == true)
                    {
                        //doc du lieu trong file
                        string[] fileSpace = File.ReadAllLines(link + "set1/space" + demSpace1 + ".txt");
                        foreach (string fileNumSpace in fileSpace)
                        {
                            numSpace = int.Parse(fileNumSpace);
                        }
                        for (int i = 0; i < numSpace; i++)
                        {
                            Console.Write("-");
                            // xuat thong tin bang ra file

                            ttl.Write(linkXuatFile, "-");
                        }
                        if (demSpace1 < dem1)
                        {
                            Console.Write("+");
                            // xuat thong tin bang ra file

                            ttl.Write(linkXuatFile, "+");
                        }
                    }
                }
                Console.Write("|");
                // xuat thong tin bang ra file
                ttl.Write(linkXuatFile, "|");
                Console.WriteLine();
                // xuat thong tin bang ra file
                ttl.WriteLine(linkXuatFile, "");
                demSpaceFixBug = demSpace1;
                demSpace1 = 0;
                demSpace = 0;
                numSpace = 0;
                //lay du lieu trong thu muc noi dung, hien thi noi dung tung dong
                if (Directory.Exists(link + "/SetLineShow") == true)
                {
                    // lay du lieu numline1
                    string[] rF1 = File.ReadAllLines(link + "/SetLineShow/setline1");
                    foreach (string line1 in rF1)
                    {
                        numLine1 = int.Parse(line1);
                    }
                    string[] rF2 = File.ReadAllLines(link + "/SetLineShow/setline2");
                    foreach (string line2 in rF2)
                    {
                        numLine2 = int.Parse(line2);
                    }
                    for (int ii = numLine1; ii <= numLine2; ii++)
                    {
                        numLineTable++;
                        // neu file la file du lieu
                        // neu duong dan khonng ton tai thay doi cac dong lon hon tro ve voi can bang
                        if (File.Exists(link + "line" + ii + ".txt") == false)
                        {
                            saveFile = ii;
                            do
                            {
                                //neu file lon hon file hien tai co ton tai(dong tiep theo co ton tai)
                                if (File.Exists(link + "line" + (ii + 1) + ".txt") == true)
                                {
                                    File.Move(link + "line" + (ii + 1) + ".txt", link + "line" + (ii) + ".txt");
                                    numExit = 0;
                                    ii++;
                                }
                                //neu dong ke tiep khong ton tai
                                if (File.Exists(link + "line" + (ii + 1) + ".txt") == false)
                                    numExit = 1;
                            } while (numExit == 0);
                            // Console.ReadKey();
                            //dem = saveFile;
                        }
                        if (File.Exists(link + "line" + ii + ".txt") == true)
                        {
                            // // percent
                            // Console.WriteLine(String.Format("{0:0.00}%",ttl.PercentInTable(link + "line" + ii + ".txt",iNumPer1,iNumPer2)));
                            // when?
                            FileInfo fIn = new FileInfo(link + "line" + ii + ".txt");
                            iWhen = ttl.TinhNgay(fIn.CreationTime.Day, fIn.CreationTime.Month, fIn.CreationTime.Year, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                            //hien thi thong tin trong file
                            string[] fileContent = File.ReadAllLines(link + "line" + ii + ".txt");
                            foreach (string lines in fileContent)
                            {
                                //hien thi mau cua bang
                                ttl.ColorTTL(colorTables);
                                demSpace1++;
                                //tao khoang cach o cot thu n
                                if (File.Exists(link + "set1/space" + demSpace1 + ".txt") == true)
                                {
                                    //doc du lieu trong file
                                    string[] fileSpace = File.ReadAllLines(link + "set1/space" + demSpace1 + ".txt");
                                    foreach (string fileNumSpace in fileSpace)
                                    {
                                        numSpace = int.Parse(fileNumSpace);
                                    }
                                    //dem ky tu trong noi dung cot
                                    foreach (char ch in lines)
                                    {
                                        demChar1++;
                                    }
                                    //neu thong tin cot it hon ten cot va khoang trong dang ton tai
                                    if (demChar1 <= numSpace && demChar1 > 0)
                                    {
                                        Console.Write("|");
                                        // xuat thong tin bang ra file
                                        ttl.Write(linkXuatFile, "|");
                                        ttl.ColorTTL(colorWordTables);
                                        //hien thi thong tin bang
                                        //neu dong trong file bang voi c tien hanh hien noi thong
                                        //chuyen thong tin in hoa thanh in thuong
                                        sLine = lines;
                                        sLine1 = lines;
                                        sLine = sLine.ToLower();
                                        sLine1 = sLine1.ToLower();
                                        sLine1 = sLine1.Replace(" ", "");
                                        //doc du lieu trong file pin
                                        string[] filePin = File.ReadAllLines(link + "Pin/Pin");
                                        foreach (string linesPin in filePin)
                                        {
                                            //neu dong pin == voi dong hien tai thi doi xac nhan = 1
                                            if (sLine1 == linesPin)
                                                xacNhan = 1;
                                        }
                                        //in thong tin can tim kiem trong bang
                                        if (cc == lines || cc == sLine || xacNhan == 1 || lines == DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year || lines == DateTime.Now.Day + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year || lines == "0" + DateTime.Now.Day + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year || lines == "0" + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year)
                                        {
                                            Console.BackgroundColor = ConsoleColor.White;
                                            Console.ForegroundColor = ConsoleColor.Black;
                                            Console.Write(lines);
                                            // xuat thong tin bang ra file
                                            ttl.Write(linkXuatFile, lines);
                                            Console.BackgroundColor = ConsoleColor.Black;
                                            // hien thi mau chu
                                            ttl.ColorTTL(colorWordTables);
                                        }
                                        // cac truong hop khac
                                        else
                                        {
                                            // when?
                                            if (lines == "when?")
                                            {
                                                sShowWhen = ttl.TraVeDuLieuThoiGian(iWhen);
                                                //dem ky tu trong noi dung cot
                                                foreach (char ch in sShowWhen)
                                                {
                                                    demCharElse++;
                                                }
                                                if (demCharElse <= numSpace)
                                                {
                                                    Console.Write(sShowWhen);
                                                    // xuat thong tin bang ra file
                                                    ttl.Write(linkXuatFile, sShowWhen);
                                                }
                                                //dem lai so char 1
                                                demChar1 = demChar1 + demCharElse - 5;
                                                // cai dat hien thi
                                                sShowElse = sShowWhen;
                                            }
                                            // percent?
                                            else if (lines == "percent?")
                                            {
                                                sShowPercent = ttl.PercentInTable(link + "line" + ii + ".txt", iNumPer1, iNumPer2) + "%(" + (int)ttl.PercentInTable(link + "line" + ii + ".txt", iNumPer1, iNumPer2) / 100 + ")";
                                                //dem ky tu trong noi dung cot
                                                foreach (char ch in sShowPercent)
                                                {
                                                    demCharElse++;
                                                }
                                                if (demCharElse <= numSpace)
                                                {
                                                    Console.Write(sShowPercent);
                                                    // xuat thong tin bang ra file
                                                    ttl.Write(linkXuatFile, sShowPercent);
                                                }
                                                //dem lai so char 1
                                                demChar1 = demChar1 + demCharElse - 8;
                                                // cai dat hien thi
                                                sShowElse = sShowPercent;
                                            }
                                            // truefalse?
                                            else if (lines == "truefalse?")
                                            {
                                                bShowTrueFalse =  ttl.TrueFalse(link + "line" + ii + ".txt", iNumTrue, iNumFasle).ToUpper();
                                                //dem ky tu trong noi dung cot
                                                foreach (char ch in bShowTrueFalse)
                                                {
                                                    demCharElse++;
                                                }
                                                if (demCharElse <= numSpace)
                                                {
                                                    Console.Write(bShowTrueFalse);
                                                    // xuat thong tin bang ra file
                                                    ttl.Write(linkXuatFile, bShowTrueFalse);
                                                }
                                                //dem lai so char 1
                                                demChar1 = demChar1 + demCharElse - 10;
                                                // cai dat hien thi
                                                sShowElse = bShowTrueFalse;
                                                // 
                                                Console.ResetColor();
                                            }
                                            // duong dan
                                            else if(File.Exists(lines) == true){
                                                sShowF = ttl.LayDuLieuTrongFileStr(lines);
                                                //dem ky tu trong noi dung cot
                                                foreach (char ch in sShowF)
                                                {
                                                    demCharElse++;
                                                }
                                                if (demCharElse <= numSpace)
                                                {
                                                    Console.Write(sShowF);
                                                    // xuat thong tin bang ra file
                                                    ttl.Write(linkXuatFile, sShowF);
                                                }
                                                //dem lai so char 1
                                                demChar1 =  demCharElse;
                                                // cai dat hien thi
                                                sShowElse = sShowF;
                                            }
                                            // con lai
                                            else
                                            {
                                                // to mau cho nhieu chu
                                                ttl.ColorTTL(colorWordTables);
                                                // to mau cho chu
                                                ttl.Rainbow(colorWordTables, lines, link + "Rainbow");
                                                Console.Write(lines);
                                                // xuat thong tin bang ra file
                                                ttl.Write(linkXuatFile, lines);
                                             
                                            }
                                        }
                                        //tao khoang trong
                                        for (int i = 0; i <= numSpace - demChar1 - 1; i++)
                                        {
                                            Console.Write(" ");
                                            // xuat thong tin bang ra file
                                            ttl.Write(linkXuatFile, " ");
                                        }
                                        //khoi dong lai bien xac nhan
                                        xacNhan = 0;
                                    }
                                    //neu thong tin cot nhieu hon hoac bang ten cot va khoang trong dang ton tai
                                    if (demChar1 > numSpace && demChar1 > 0)
                                    {
                                        // khac
                                        if (demCharElse == 0)
                                        {
                                            //hien thi mau cua bang
                                            ttl.ColorTTL(colorTables);
                                            ////hien thi thong tin cot vua voi khoang trang con lai cua cot
                                            Console.Write("|");
                                            // xuat thong tin bang ra file
                                            ttl.Write(linkXuatFile, "|");
                                            // to mau cho nhieu chu
                                            ttl.ColorTTL(colorWordTables);
                                            // to mau cho chu 1 chu
                                            ttl.Rainbow(colorWordTables, lines, link + "Rainbow");
                                            
                                            //thong tin khong phai la duong dan toi file
                                            if(File.Exists(lines) == false){ 
                                                // khac
                                                foreach (char ch in lines)
                                                {
                                                    demChar2++;
                                                    if (demChar2 < numSpace - 2)
                                                    {
                                                        Console.Write(ch);
                                                        // xuat thong tin bang ra file
                                                        ttl.Write(linkXuatFile, ch + "");
                                                    }
                                                }
                                                // // tao khoang trong
                                                // for (int i = 0; i <= numSpace - demChar2; i++)
                                                // {
                                                //     Console.Write(" ");
                                                //     // xuat thong tin bang ra file
                                                //     ttl.Write(linkXuatFile, " ");
                                                // }
                                            }
                                            // thong tin la duong dan toi file
                                            if(File.Exists(lines) == true){
                                                 // khac
                                                foreach (char ch in ttl.LayDuLieuTrongFileStr(lines))
                                                {
                                                    demChar2++;
                                                    if (demChar2 < numSpace - 2)
                                                    {
                                                        Console.Write(ch);
                                                        // xuat thong tin bang ra file
                                                        ttl.Write(linkXuatFile, ch + "");
                                                    }
                                                }
                                                // tao khoang trong
                                                  //tao khoang trong
                                                for (int i = 0; i <= numSpace - demChar2 - 4; i++)
                                                {
                                                    Console.Write(" ");
                                                    // xuat thong tin bang ra file
                                                    ttl.Write(linkXuatFile, " ");
                                                }
                                            }
                                        }
                                        // when?
                                        if (demCharElse != 0)
                                        {
                                            // to mau cho nhieu chu
                                            ttl.ColorTTL(colorWordTables);
                                            // to mau cho chu 1 chu
                                            ttl.Rainbow(colorWordTables, lines, link + "Rainbow");
                                            foreach (char ch in sShowElse)
                                            {
                                                demChar2++;
                                                if (demChar2 < numSpace - 2)
                                                {
                                                    Console.Write(ch);
                                                    // xuat thong tin bang ra file
                                                    ttl.Write(linkXuatFile, ch + "");
                                                }
                                            }
                                        }
                                        Console.Write("...");
                                        // xuat thong tin bang ra file 
                                        ttl.Write(linkXuatFile, "...");
                                    }
                                    demChar2 = 0;
                                    demChar1 = 0;
                                    numSpace = 0;
                                    demCharElse = 0;
                                }
                            }
                        }
                        demSpace1 = 0;
                        //hien thi mau cua bang
                        ttl.ColorTTL(colorTables);
                        //va loi dong ao
                        if (File.Exists(link + "line" + (ii) + ".txt") == true)
                        {
                            Console.Write("|");
                            // xuat thong tin bang ra file
                            ttl.Write(linkXuatFile, "|");
                        }
                       Console.ResetColor();
                        if (Directory.Exists(link + "/SetLineShow") == true && File.Exists(link + "line" + (ii) + ".txt") == true)
                        {
                            // hien thi so dong
                            Console.Write(" {0}", numLine1);
                            // xuat thong tin bang ra file
                            ttl.Write(linkXuatFile, " " + numLine1);
                            
                            numLine1++;
                            //mo file protect
                            string[] fileProtect = File.ReadAllLines(link + "/ProtectLine/ProtectLine");
                            foreach (string lineProtect in fileProtect)
                            {
                                try
                                {
                                    numProtect = int.Parse(lineProtect);
                                }
                                catch
                                {

                                }
                                //so sanh du lieu
                                if (numLine1 == numProtect + 1)
                                    Console.Write(" P");
                            }
                        }
                        // //hien thi so dong neu show line table = 1
                        // if(showLineTable == 1 && File.Exists(link + "line" + (ii - 1) + ".txt") == true &&  Directory.Exists(link + "/SetLineShow") == false)
                        // {
                        //     Console.Write(" {0}",numLineTable - 1);
                        //     //sua loi khong tim thay thu muc protect line neu thu muc nay chua ton tai
                        //     //neu thuc muc protect chua ton tai
                        //     if(Directory.Exists(link + "/ProtectLine") == false)
                        //     {
                        //         //tao thu muc moi
                        //         DirectoryInfo newFolder = new DirectoryInfo(link + "/ProtectLine");
                        //         newFolder.Create();
                        //     }
                        //     //neu file trong thu muc protect chua ton tai
                        //     if(File.Exists(link + "/ProtectLine/ProtectLine") == false)
                        //     {
                        //         //tao file moi
                        //         FileStream fileNew = new FileStream(link + "/ProtectLine/ProtectLine",FileMode.Create);
                        //         fileNew.Close();
                        //     }
                        //     //mo file protect
                        //     string[] fileProtect = File.ReadAllLines(link + "/ProtectLine/ProtectLine");
                        //     foreach(string lineProtect in fileProtect)
                        //     {
                        //         try
                        //         {
                        //             numProtect = int.Parse(lineProtect);
                        //         }
                        //         catch
                        //         {

                        //         }
                        //         //so sanh du lieu
                        //         if(numLineTable == numProtect + 1)
                        //             Console.Write(" P");
                        //     }                     
                        // }
                        //va loi dong ao
                        if (File.Exists(link + "line" + (ii) + ".txt") == true)
                        {
                            Console.WriteLine();
                            // xuat thong tin bang ra file
                            ttl.WriteLine(linkXuatFile, "");
                        }

                    }
                }
                // hien thi tat ca du lieu
                if (Directory.Exists(link + "/SetLineShow") == false)
                {
                    string[] Folder1 = Directory.GetFiles(link);
                    foreach (string files in Folder1)
                    {
                        numLineTable++;
                        dem++;
                        //neu file la file du lieu
                        //neu duong dan khonng ton tai thay doi cac dong lon hon tro ve voi can bang
                        if (File.Exists(link + "line" + dem + ".txt") == false)
                        {
                            saveFile = dem;
                            do
                            {
                                //neu file lon hon file hien tai co ton tai(dong tiep theo co ton tai)
                                if (File.Exists(link + "line" + (dem + 1) + ".txt") == true)
                                {
                                    File.Move(link + "line" + (dem + 1) + ".txt", link + "line" + (dem) + ".txt");
                                    numExit = 0;
                                    dem++;
                                }
                                //neu dong ke tiep khong ton tai
                                if (File.Exists(link + "line" + (dem + 1) + ".txt") == false)
                                    numExit = 1;
                            } while (numExit == 0);
                            // Console.ReadKey();
                            //dem = saveFile;
                        }
                        if (File.Exists(link + "line" + (dem - 1) + ".txt") == true)
                        {
                            // when?
                            FileInfo fIn = new FileInfo(link + "line" + (dem - 1) + ".txt");
                            iWhen = ttl.TinhNgay(fIn.CreationTime.Day, fIn.CreationTime.Month, fIn.CreationTime.Year, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
                            //hien thi thong tin trong file
                            string[] fileContent = File.ReadAllLines(link + "line" + (dem - 1) + ".txt");
                            foreach (string lines in fileContent)
                            {
                                //hien thi mau cua bang
                                ttl.ColorTTL(colorTables);
                                demSpace1++;
                                //tao khoang cach o cot thu n
                                //lay file trong thu muc cai dat
                                string[] filesSpace1 = Directory.GetFiles(linkSet1);
                                foreach (string file in filesSpace1)
                                {

                                    //neu trung file
                                    if (file == link + "set1\\space" + demSpace1 + ".txt")
                                    {
                                        //doc du lieu trong file
                                        string[] fileSpace = File.ReadAllLines(file);
                                        foreach (string fileNumSpace in fileSpace)
                                        {
                                            numSpace = int.Parse(fileNumSpace);
                                        }
                                        //dem ky tu trong noi dung cot
                                        foreach (char ch in lines)
                                        {
                                            demChar1++;
                                        }
                                        //neu thong tin cot it hon ten cot va khoang trong dang ton tai
                                        if (demChar1 <= numSpace && demChar1 > 0)
                                        {
                                            Console.Write("|");
                                            // xuat thong tin bang ra file
                                            ttl.Write(linkXuatFile, "|");
                                            ttl.ColorTTL(colorWordTables);
                                            //hien thi thong tin bang
                                            //neu dong trong file bang voi c tien hanh hien noi thong
                                            //chuyen thong tin in hoa thanh in thuong
                                            sLine = lines;
                                            sLine1 = lines;
                                            sLine = sLine.ToLower();
                                            sLine1 = sLine1.ToLower();
                                            sLine1 = sLine1.Replace(" ", "");
                                            //doc du lieu trong file pin
                                            string[] filePin = File.ReadAllLines(link + "Pin/Pin");
                                            foreach (string linesPin in filePin)
                                            {
                                                //neu dong pin == voi dong hien tai thi doi xac nhan = 1
                                                if (sLine1 == linesPin)
                                                    xacNhan = 1;
                                            }
                                            //in thong tin can tim kiem trong bang
                                            if (cc == lines || cc == sLine || xacNhan == 1 || lines == DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year || lines == DateTime.Now.Day + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year || lines == "0" + DateTime.Now.Day + "/0" + DateTime.Now.Month + "/" + DateTime.Now.Year || lines == "0" + DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year)
                                            {
                                                Console.BackgroundColor = ConsoleColor.White;
                                                Console.ForegroundColor = ConsoleColor.Black;
                                                Console.Write(lines);
                                                Console.BackgroundColor = ConsoleColor.Black;
                                                ttl.ColorTTL(colorWordTables);
                                            }
                                            // cac truong hop khac
                                            else
                                            {
                                                // when?
                                                if (lines == "when?")
                                                {
                                                    sShowWhen = ttl.TraVeDuLieuThoiGian(iWhen);
                                                    //dem ky tu trong noi dung cot
                                                    foreach (char ch in sShowWhen)
                                                    {
                                                        demCharElse++;
                                                    }
                                                    if (demCharElse <= numSpace)
                                                    {
                                                        Console.Write(sShowWhen);
                                                        // xuat thong tin bang ra file
                                                        ttl.Write(linkXuatFile, sShowWhen);
                                                    }
                                                    //dem lai so char 1
                                                    demChar1 = demChar1 + demCharElse - 5;
                                                    // cai dat hien thi
                                                    sShowElse = sShowWhen;
                                                }
                                                // percent?
                                                else if (lines == "percent?")
                                                {
                                                    sShowPercent = ttl.PercentInTable(link + "line" + (dem - 1) + ".txt", iNumPer1, iNumPer2) + "%(" + (int)ttl.PercentInTable(link + "line" + (dem - 1) + ".txt", iNumPer1, iNumPer2) / 100 + ")";
                                                    //dem ky tu trong noi dung cot
                                                    foreach (char ch in sShowPercent)
                                                    {
                                                        demCharElse++;
                                                    }
                                                    if (demCharElse <= numSpace)
                                                    {
                                                        Console.Write(sShowPercent);
                                                        // xuat thong tin bang ra file
                                                        ttl.Write(linkXuatFile, sShowPercent);
                                                    }
                                                    //dem lai so char 1
                                                    demChar1 = demChar1 + demCharElse - 8;
                                                    // cai dat hien thi
                                                    sShowElse = sShowPercent;
                                                }
                                                // truefalse?
                                                else if (lines == "truefalse?")
                                                {
                                                    bShowTrueFalse =  ttl.TrueFalse(link + "line" + (dem - 1) + ".txt", iNumTrue, iNumFasle).ToUpper();
                                                    //dem ky tu trong noi dung cot
                                                    foreach (char ch in bShowTrueFalse)
                                                    {
                                                        demCharElse++;
                                                    }
                                                    if (demCharElse <= numSpace)
                                                    {
                                                        Console.Write(bShowTrueFalse);
                                                        // xuat thong tin bang ra file
                                                        ttl.Write(linkXuatFile, bShowTrueFalse);
                                                    }
                                                    //dem lai so char 1
                                                    demChar1 = demChar1 + demCharElse - 10;
                                                    // cai dat hien thi
                                                    sShowElse = bShowTrueFalse;
                                                    // 
                                                    Console.ResetColor();
                                                }
                                                // duong dan
                                                else if(File.Exists(lines) == true){
                                                    sShowF = ttl.LayDuLieuTrongFileStr(lines);
                                                    //dem ky tu trong noi dung cot
                                                    foreach (char ch in sShowF)
                                                    {
                                                        demCharElse++;
                                                    }
                                                    if (demCharElse <= numSpace)
                                                    {
                                                        Console.Write(sShowF);
                                                        // xuat thong tin bang ra file
                                                        ttl.Write(linkXuatFile, sShowF);
                                                    }
                                                    //dem lai so char 1
                                                    demChar1 = demCharElse;
                                                    // cai dat hien thi
                                                    sShowElse = sShowF;
                                                }
                                                // con lai
                                                else
                                                {
                                                    // to mau cho nhieu chu
                                                    ttl.ColorTTL(colorWordTables);
                                                    // to mau cho chu
                                                    ttl.Rainbow(colorWordTables, lines, link + "Rainbow");
                                                    Console.Write(lines);
                                                    // xuat thong tin bang ra file
                                                    ttl.Write(linkXuatFile, lines);
                                                    // ghi thong bao vao file tro ly
                                                   
                                                }
                                            }
                                            //tao khoang trong con lai
                                            for (int i = 0; i <= numSpace - demChar1 - 1; i++)
                                            {
                                                Console.Write(" ");
                                                // xuat thong tin bang ra file
                                                ttl.Write(linkXuatFile, " ");
                                            }
                                            //khoi dong lai bien xac nhan
                                            xacNhan = 0;
                                        }
                                        //neu thong tin cot nhieu hon hoac bang ten cot va khoang trong dang ton tai
                                        if (demChar1 > numSpace && demChar1 > 0)
                                        {
                                            // khac
                                            if (demCharElse == 0)
                                            {
                                                //hien thi mau cua bang
                                                ttl.ColorTTL(colorTables);
                                                ////hien thi thong tin cot vua voi khoang trang con lai cua cot
                                                Console.Write("|");
                                                // xuat thong tin bang ra file
                                                ttl.Write(linkXuatFile, "|");
                                                // to mau cho nhieu chu
                                                ttl.ColorTTL(colorWordTables);
                                                // to mau cho chu 1 chu
                                                ttl.Rainbow(colorWordTables, lines, link + "Rainbow");
                                                
                                                //thong tin khong phai la duong dan toi file
                                                if(File.Exists(lines) == false){ 
                                                    // khac
                                                    foreach (char ch in lines)
                                                    {
                                                        demChar2++;
                                                        if (demChar2 < numSpace - 2)
                                                        {
                                                            Console.Write(ch);
                                                            // xuat thong tin bang ra file
                                                            ttl.Write(linkXuatFile, ch + "");
                                                        }
                                                    }
                                                    // // tao khoang trong
                                                    // for (int i = 0; i <= numSpace - demChar2; i++)
                                                    // {
                                                    //     Console.Write(" ");
                                                    //     // xuat thong tin bang ra file
                                                    //     ttl.Write(linkXuatFile, " ");
                                                    // }
                                                }
                                                // thong tin la duong dan toi file
                                                if(File.Exists(lines) == true){
                                                    // khac
                                                    foreach (char ch in ttl.LayDuLieuTrongFileStr(lines))
                                                    {
                                                        demChar2++;
                                                        if (demChar2 < numSpace - 2)
                                                        {
                                                            Console.Write(ch);
                                                            // xuat thong tin bang ra file
                                                            ttl.Write(linkXuatFile, ch + "");
                                                        }
                                                    }
                                                    // tao khoang trong
                                                    //tao khoang trong
                                                    for (int i = 0; i <= numSpace - demChar2 - 4; i++)
                                                    {
                                                        Console.Write(" ");
                                                        // xuat thong tin bang ra file
                                                        ttl.Write(linkXuatFile, " ");
                                                    }
                                                }
                                            }
                                            // when?
                                            if (demCharElse != 0)
                                            {
                                                // to mau cho nhieu chu
                                                ttl.ColorTTL(colorWordTables);
                                                // to mau cho chu 1 chu
                                                ttl.Rainbow(colorWordTables, lines, link + "Rainbow");
                                                foreach (char ch in sShowElse)
                                                {
                                                    demChar2++;
                                                    if (demChar2 < numSpace - 2)
                                                    {
                                                        Console.Write(ch);
                                                        // xuat thong tin bang ra file
                                                        ttl.Write(linkXuatFile, ch + "");
                                                    }
                                                }
                                            }
                                            Console.Write("...");
                                            // xuat thong tin bang ra file 
                                            ttl.Write(linkXuatFile, "...");
                                        }
                                        demChar2 = 0;
                                        demChar1 = 0;
                                        numSpace = 0;
                                        demCharElse = 0;
                                    }
                                }
                            }
                        }
                        demSpace1 = 0;
                        //hien thi mau cua bang
                        ttl.ColorTTL(colorTables);
                        //va loi dong ao
                        if (File.Exists(link + "line" + (dem - 1) + ".txt") == true)
                        {
                            Console.Write("|");
                            // xuat thong tin bang ra file
                            ttl.Write(linkXuatFile, "|");
                        }
                       Console.ResetColor();
                        //hien thi so dong neu show line table = 1 || dung de thiet lap slt khi bang moi thanh lap
                        if (File.Exists(link + "line" + (dem - 1) + ".txt") == true)
                        {
                            Console.Write(" {0}", numLineTable - 1);
                            // xuat thong tin bang ra file
                            ttl.Write(linkXuatFile, " " + (numLineTable - 1));
                            //sua loi khong tim thay thu muc protect line neu thu muc nay chua ton tai
                            //neu thuc muc protect chua ton tai
                            if (Directory.Exists(link + "/ProtectLine") == false)
                            {
                                //tao thu muc moi
                                DirectoryInfo newFolder = new DirectoryInfo(link + "/ProtectLine");
                                newFolder.Create();
                            }
                            //neu file trong thu muc protect chua ton tai
                            if (File.Exists(link + "/ProtectLine/ProtectLine") == false)
                            {
                                //tao file moi
                                FileStream fileNew = new FileStream(link + "/ProtectLine/ProtectLine", FileMode.Create);
                                fileNew.Close();
                            }
                            //mo file protect
                            string[] fileProtect = File.ReadAllLines(link + "/ProtectLine/ProtectLine");
                            foreach (string lineProtect in fileProtect)
                            {
                                try
                                {
                                    numProtect = int.Parse(lineProtect);
                                }
                                catch
                                {

                                }
                                //so sanh du lieu
                                if (numLineTable == numProtect + 1)
                                    Console.Write(" P");
                            }
                        }
                        //va loi dong ao
                        if (File.Exists(link + "line" + (dem - 1) + ".txt") == true)
                        {
                            Console.WriteLine();
                            // xuat thong tin bang ra file
                            ttl.WriteLine(linkXuatFile, "");
                        }
                    }
                }
                //hien thi mau cua bang
                ttl.ColorTTL(colorTables);
                //hien thi gach cuoi
                Console.Write("|");
                ttl.Write(linkXuatFile, "|");
                string[] filesSpace2 = Directory.GetFiles(linkSet1);
                foreach (string file in filesSpace2)
                {
                    demSpace1++;
                    //neu trung file
                    if (File.Exists(link + "set1/space" + demSpace1 + ".txt") == true)
                    {
                        //doc du lieu trong file
                        string[] fileSpace = File.ReadAllLines(link + "set1/space" + demSpace1 + ".txt");
                        foreach (string fileNumSpace in fileSpace)
                        {
                            numSpace = int.Parse(fileNumSpace);
                        }
                        for (int i = 0; i < numSpace; i++)
                        {
                            Console.Write("_");
                            // xuat thong tin bang ra file
                            ttl.Write(linkXuatFile, "_");
                        }
                        if (demSpace1 < dem1)
                        {
                            Console.Write("|");
                            // xuat thong tin bang ra file
                            ttl.Write(linkXuatFile, "|");
                        }
                    }
                }
                Console.Write("|");
                // xuat thong tin bang ra file
                ttl.Write(linkXuatFile, "|");
                Console.WriteLine();
                // xuat thong tin bang ra file
                ttl.WriteLine(linkXuatFile, "");
            }
            // chuc nang mo rong
            Console.ForegroundColor = ConsoleColor.White;
            //  MENU TABLE
            if (c == "menu")
                ttl.MenuForTable(numLineTable, link, dem, numExit, saveFile, demSpace1, numSpace, linkSet1, demChar1, sLine, sLine1, xacNhan, cc);
            // FILE PIN
            if (c == "pin")
                ttl.DuLieuPin(link);
            Console.ResetColor();;

        }
        //thay doi khoang cach giua cac trang
        public static void ChangeSpaceTable(string c, string linkTable, string nameTable)
        {
            int num = 0;
            int num1 = 0;
            int newSpaceTable = 0;
            string str = "";
            string linkAccess = "";
            //neu duong dan khac rong
            if (linkTable != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "csc", "changespacecolumn");
                if (str.Replace(" ", "") != "")
                {
                    //tao truy cap de kiem tra ten bang
                    linkAccess = linkTable + "/" + nameTable + "/Name/name.txt";
                    //hien thi file link access
                    string[] fileLinkAccess = File.ReadAllLines(linkAccess);
                    foreach (string lines in fileLinkAccess)
                    {
                        num++;
                        if (str == lines)
                            num1 = num;
                        //hien thi so dong trong file
                        //Console.WriteLine(lines);
                    }
                    // Console.WriteLine(num1);
                    // Console.ReadKey();
                    //neu so duong dan khac 0
                    if (num1 > 0)
                    {
                        //thay doi duong dan
                        linkAccess = linkTable + "/" + nameTable + "/set/space" + num1 + ".txt";
                        //doc du lieu dang co trong file space
                        string[] fileReadSpace = File.ReadAllLines(linkAccess);
                        foreach (string lineNumSpace in fileReadSpace)
                        {
                            //ghi du lieu moi
                            Console.Write("NEW NUM SPACE({0})?>", lineNumSpace);
                        }
                        int.TryParse(Console.ReadLine(), out newSpaceTable);
                        //new khoang trong moi khac 0;
                        if (newSpaceTable > 0)
                        {
                            //ghi du lieu moi cho khoang trong
                            TextWriter textNewNumSpace = new StreamWriter(linkAccess, false);
                            textNewNumSpace.WriteLine(newSpaceTable);
                            textNewNumSpace.Close();
                        }
                    }
                }
            }
        }
        //ghi de dong
        public static void OverrideLine(string c, string linkTable, string nameTable)
        {
            string str = "";
            int numLine = 0;
            int numSpace = 0;
            int space = 0;
            string sNumLine = "";
            string linkAccess = "";
            string linkAccess1 = "";
            string overRide = "";
            string linkSpaceTableColumn = "";
            //neu duong dan khac rong
            if (linkTable != "" && c != "")
            {

                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "orl", "overrideline");
                if (str.Replace(" ", "") != "")
                {
                    try
                    {
                        numLine = int.Parse(str);
                    }
                    catch
                    {

                    }
                    //kiem tra dong ghi de co duoc bao ve hay khong
                    sNumLine = sNumLine + numLine;
                    //neu thu muc protect file chua ton tai
                    if (Directory.Exists(linkTable + "/" + nameTable + "/ProtectLine/") == false)
                    {
                        //tao thu muc moi
                        DirectoryInfo newFolder = new DirectoryInfo(linkTable + "/" + nameTable + "/ProtectLine/");
                        newFolder.Create();
                        //tao file moi
                        FileStream fileNew = new FileStream(linkTable + "/" + nameTable + "/ProtectLine/ProtectLine", FileMode.Create);
                        fileNew.Close();
                    }
                    string[] fileProtectLine = File.ReadAllLines(linkTable + "/" + nameTable + "/ProtectLine/ProtectLine");
                    foreach (string lines in fileProtectLine)
                    {
                        //neu dong dang duoc bao ve bang voi dong can ghi de
                        if (lines == sNumLine)
                        {
                            numLine = 0;
                            break;
                        }
                    }
                    //thay doi duong dan neu num line khac 0
                    if (numLine != 0)
                    {
                        //bat dau ghi de
                        //dem so dong trong file bang cach dem file ten bang
                        linkAccess = linkTable + "/" + nameTable + "/line" + numLine + ".txt";
                    }
                    //neu file co ton tai
                    if (File.Exists(linkAccess) == true)
                    {
                        linkAccess1 = linkAccess;
                        //bat dau ghi de
                        FileStream fileOverRide = new FileStream(linkAccess1, FileMode.Create);
                        fileOverRide.Close();
                        TextWriter textOverrideLine = new StreamWriter(linkAccess1, true);
                        //dem so dong trong file bang cach dem file ten bang
                        linkAccess = linkTable + "/" + nameTable + "/Name/name.txt";
                        string[] fileName = File.ReadAllLines(linkAccess);
                        foreach (string nameFile in fileName)
                        {
                            numSpace++;
                            linkSpaceTableColumn = linkTable + "/" + nameTable + "/set/space" + numSpace + ".txt";
                            //lay khoang cach
                            string[] fileSpace = File.ReadAllLines(linkSpaceTableColumn);
                            foreach (string lineSpace in fileSpace)
                            {
                                try
                                {
                                    space = int.Parse(lineSpace);
                                }
                                catch
                                {

                                }
                            }
                            //hien thi ten cot
                            Console.Write("|" + nameFile.ToUpper());
                            //ve khoang trong
                            for (int i = 0; i <= space; i++)
                                Console.Write(" ");
                            Console.Write("|\n ");
                            //ghi du lieu moi
                            overRide = Console.ReadLine();
                            //neu du lieu vao la rong
                            if (overRide == "")
                            {
                                overRide = " ";
                            }
                            //chuyen du lieu moi vao file
                            textOverrideLine.WriteLine(overRide);
                        }
                        textOverrideLine.Close();
                    }
                }
            }
        }
        // //change name table
        // public static void ChangeNameTable(string c,string linkTable,string nameTable)
        // {
        //     string newNameColumn = "";
        //     string linkAccess = "";
        //     string linkAccess1 = "";
        //     char ok = ' ';
        //     linkAccess = linkTable + "/" + nameTable + "/Name/name.txt";
        //     linkAccess1 = linkTable + "/" + nameTable + "/name1.txt";
        //     //doi ten file
        //     File.Move(linkAccess,linkAccess1);
        //     //tao file ten cot moi
        //     FileStream fileNewNameColumn = new FileStream(linkAccess,FileMode.Create);
        //     fileNewNameColumn.Close();
        //     //ghi du lieu vao file ten cot moi
        //     TextWriter textNewNameColumn = new StreamWriter(linkAccess,true); 
        //     //hien thi ten cac column cu~
        //     string[] fileNameColumn = File.ReadAllLines(linkAccess1);
        //     foreach(string nameColumn in fileNameColumn)
        //     {
        //         // kiem tra du lieu trong file co trung voi du lieu trong file bao ve
        //         string[] rF = File.ReadAllLines(linkTable + "/" + nameTable + "/ProtectColumn/ProtectColumn");
        //         foreach(string lines in rF){
        //             //neu du lieu trong file khac vs du lieu dang co trong file bao ve
        //             if(lines.Replace(" ","").ToLower() == nameColumn.Replace(" ","").ToLower())
        //                 ok = '1';
        //         }
        //         //neu ten file khong duoc dang ky bao ve
        //         if(ok != '1'){
        //             Console.Write(nameColumn.ToUpper());
        //             Console.Write(" > ");
        //             //ghi ten cot moi
        //             newNameColumn = Console.ReadLine();
        //             newNameColumn = newNameColumn.Replace(" ","").ToLower();
        //             //neu khong co du lieu nhap vao giu nguyen ten ban dau
        //             if(newNameColumn == "")
        //                 newNameColumn = nameColumn;
        //             //ghi du lieu ten cot moi vao file
        //             textNewNameColumn.WriteLine(newNameColumn);
        //         }
        //         // neu ten file dang duoc bao ve
        //         if(ok == '1'){
        //             Console.ForegroundColor = ConsoleColor.Red;
        //             Console.WriteLine(nameColumn.ToUpper());
        //             //ghi du lieu ten cot moi vao file
        //             textNewNameColumn.WriteLine(nameColumn.ToLower().Replace(" ",""));
        //            Console.ResetColor();
        //         }
        //         ok = ' ';
        //     }
        //     textNewNameColumn.Close();
        //     //xoa file ten cu
        //     File.Delete(linkAccess1);
        // }
        //xoa bang
        public static void DeleteTables(string c, string linkTKB)
        {
            string str = "";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "dt", "deletetable");
                //neu ten bang can xoa co ton tai
                if (Directory.Exists(linkTKB + "/" + str) == true && str.Replace(" ", "") != "")
                {
                    Directory.Delete(linkTKB + "/" + str, true);
                }
            }
        }
        //them mau cho bang
        public static void ColorTables(string c, string linkTKB, string nameTable)
        {
            string str = "";
            string linkColorTables = linkTKB + "/" + nameTable + "/ColorTable/Color";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "" && nameTable != "")
            {
                //neu file chua ton tai
                if (File.Exists(linkColorTables) == false || Directory.Exists(linkTKB + "/" + nameTable + "/ColorTable") == false)
                {
                    //tao thu muc moi
                    DirectoryInfo newFolderColor = new DirectoryInfo(linkTKB + "/" + nameTable + "/ColorTable");
                    newFolderColor.Create();
                    //tao file moi
                    FileStream fileNewColorTables = new FileStream(linkColorTables, FileMode.Create);
                    fileNewColorTables.Close();
                }
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "cct", "changecolortable");
                //neu str khac rong
                if (str.Replace(" ", "") != "")
                {
                    //ghi du lieu mau sac vao file
                    TextWriter textColorTables = new StreamWriter(linkColorTables, false);
                    textColorTables.WriteLine(str);
                    textColorTables.Close();
                }
            }
        }
        //them mau cho chu
        public static void ColorTablesWord(string c, string linkTKB, string nameTable)
        {
            string str = "";
            string linkColorWordTables = linkTKB + "/" + nameTable + "/ColorWordTable/Color";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "" && nameTable != "")
            {
                //neu file chua ton tai
                if (File.Exists(linkColorWordTables) == false || Directory.Exists(linkTKB + "/" + nameTable + "/ColorWordTable") == false)
                {
                    //tao thu muc moi
                    DirectoryInfo newFolderColor = new DirectoryInfo(linkTKB + "/" + nameTable + "/ColorWordTable");
                    newFolderColor.Create();
                    //tao file moi
                    FileStream fileNewColorTables = new FileStream(linkColorWordTables, FileMode.Create);
                    fileNewColorTables.Close();
                }
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "ccwt", "changecolorwordtable");
                //neu str khac rong
                if (str.Replace(" ", "") != "")
                {
                    //ghi du lieu mau sac vao file
                    TextWriter textColorWordTables = new StreamWriter(linkColorWordTables, false);
                    textColorWordTables.WriteLine(str);
                    textColorWordTables.Close();
                }
            }
        }
        //chong ghi de cho dong
        public static void ProtectOverRideLine(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numLine = 0;
            int lineProtect = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "" && nameTable != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "ptl", "protectline");
                //neu chu 1 khac rong
                if (str.Replace(" ", "") != "" && Directory.Exists(linkAccess) == true)
                {
                    try
                    {
                        lineProtect = int.Parse(str);
                    }
                    catch
                    {

                    }
                    //thay doi duong dan
                    linkAccess = linkTKB + "/" + nameTable + "/ProtectLine/";
                    //neu thu muc chua file chua ton tai
                    if (Directory.Exists(linkAccess) == false)
                    {
                        //tao thu muc moi
                        DirectoryInfo newFolder = new DirectoryInfo(linkAccess);
                        newFolder.Create();
                    }
                    //neu file ghi du lieu chua ton tai
                    if (File.Exists(linkAccess + "ProtectLine") == false)
                    {
                        //tao file moi chua cac dong chong ghi
                        FileStream fileNew = new FileStream(linkAccess + "ProtectLine", FileMode.Create);
                        fileNew.Close();
                    }
                    //ghi du lieu vao file
                    if (lineProtect != 0)
                    {
                        TextWriter textFile = new StreamWriter(linkAccess + "ProtectLine", true);
                        textFile.WriteLine(lineProtect);
                        textFile.Close();
                    }
                    //neu chu 1 = all, nguoi dung chon bao ve tat cac cac dong dan co trong bang
                    if (str == "all")
                    {
                        //ghi du lieu moi vao file
                        FileStream fileProtectLineAll = new FileStream(linkAccess + "ProtectLine", FileMode.Create);
                        fileProtectLineAll.Close();
                        TextWriter textFilePA = new StreamWriter(linkAccess + "ProtectLine", true);
                        //lay tat ca cac dong dang co trong bang
                        string[] fileLine = Directory.GetFiles(linkTKB + "/" + nameTable + "/");
                        foreach (string files in fileLine)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkTKB + "/" + nameTable + "/line" + numLine + ".txt") == true)
                            {
                                //ghi du lieu vao file
                                textFilePA.WriteLine(numLine);
                            }
                            numLine++;
                        }
                        textFilePA.Close();
                    }
                }
            }
        }
        //xoa bao ve dong
        public static void DeleteProtectOverRideLine(string c, string linkTKB, string nameTable)
        {
            string str = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "" && nameTable != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "dptl", "deleteprotectline");
                //neu str khac rong va duong dan co ton tai
                if (str.Replace(" ", "") != "" && Directory.Exists(linkAccess) == true)
                {
                    //thay doi duong dan
                    linkAccess = linkTKB + "/" + nameTable + "/ProtectLine/ProtectLine";
                    //tao file moi
                    FileStream fileNew = new FileStream(linkAccess + "1", FileMode.Create);
                    fileNew.Close();
                    //ghi du lieu moi vao file
                    TextWriter textFileProtect = new StreamWriter(linkAccess + "1", true);
                    //doc du lieu file chinh
                    string[] fileProtect = File.ReadAllLines(linkAccess);
                    foreach (string lines in fileProtect)
                    {
                        //ghi du lieu moi vao file protect1
                        if (lines != str)
                        {
                            textFileProtect.WriteLine(lines);
                        }
                    }
                    textFileProtect.Close();
                    //xoa file chinh
                    File.Delete(linkAccess);
                    //doi file chuyen doi thanh file chinh
                    File.Move(linkAccess + "1", linkAccess);
                }
            }
        }
        //chong ghi de cho cot
        public static void ProtectOverRideColumn(string c, string linkTKB, string nameTable)
        {
            string str = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "" && nameTable != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "ptc", "protectcolumn");
                //neu chu 1 khac rong
                if (str.Replace(" ", "") != "" && Directory.Exists(linkAccess) == true)
                {
                    //thay doi duong dan
                    linkAccess = linkTKB + "/" + nameTable + "/ProtectColumn/";
                    //neu thu muc chua file chua ton tai
                    ttl.TaoThuMuc(linkAccess);
                    ttl.TaoFile(linkAccess + "ProtectColumn");
                    //doc du lieu trong file name
                    string[] fileName = File.ReadAllLines(linkTKB + "/" + nameTable + "/Name/name.txt");
                    foreach (string linesName in fileName)
                    {
                        //neu str == linesName thi ghi du lieu vao file bao ve cot
                        if (str == linesName)
                        {
                            //ghi du lieu vao file
                            TextWriter textFile = new StreamWriter(linkAccess + "ProtectColumn", true);
                            textFile.WriteLine(str);
                            textFile.Close();
                        }
                    }
                    //neu chu 1 = all, nguoi dung chon bao ve tat cac cac dong dan co trong bang
                    if (str == "all")
                    {
                        //ghi du lieu moi vao file
                        FileStream fileProtectLineAll = new FileStream(linkAccess + "ProtectColumn", FileMode.Create);
                        fileProtectLineAll.Close();
                        TextWriter textFilePC = new StreamWriter(linkAccess + "ProtectColumn", true);
                        //lay tat ca cac dong dang co trong bang
                        string[] fileName1 = File.ReadAllLines(linkTKB + "/" + nameTable + "/Name/name.txt");
                        foreach (string lines in fileName1)
                        {
                            //ghi du lieu vao file
                            textFilePC.WriteLine(lines);
                        }
                        textFilePC.Close();
                    }
                }
            }
        }
        //xoa chong ghi de cho cot
        public static void DeleteProtectOverRideColumn(string c, string linkTKB, string nameTable)
        {
            string str = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "" && nameTable != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "dptc", "deleteprotectcolumn");
                //neu str khac rong va duong dan co ton tai
                if (str.Replace(" ", "") != "" && Directory.Exists(linkAccess) == true)
                {
                    //doc cac du lieu trong file name
                    string[] fileName = File.ReadAllLines(linkTKB + "/" + nameTable + "/Name/name.txt");
                    foreach (string linesName in fileName)
                    {
                        //neu chu can xoa trung voi ten bang
                        if (str == linesName)
                        {
                            //thay doi duong dan
                            linkAccess = linkTKB + "/" + nameTable + "/ProtectColumn/ProtectColumn";
                            //tao file moi
                            FileStream fileNew = new FileStream(linkAccess + "1", FileMode.Create);
                            fileNew.Close();
                            //ghi du lieu moi vao file
                            TextWriter textFileProtect = new StreamWriter(linkAccess + "1", true);
                            //doc du lieu file chinh
                            string[] fileProtect = File.ReadAllLines(linkAccess);
                            foreach (string lines in fileProtect)
                            {
                                //ghi du lieu moi vao file protect1
                                if (lines != str)
                                {
                                    textFileProtect.WriteLine(lines);
                                }
                            }
                            textFileProtect.Close();
                            //xoa file chinh
                            File.Delete(linkAccess);
                            //doi file chuyen doi thanh file chinh
                            File.Move(linkAccess + "1", linkAccess);
                        }
                    }
                    // xoa cac cot dang duoc bao ve
                    if (str == "all")
                    {
                        FileStream fN = new FileStream(linkTKB + "/" + nameTable + "/ProtectColumn/ProtectColumn", FileMode.Create);
                        fN.Close();
                    }
                }
            }
        }
        //chen bang
        public static void InsertTable(string c, string linkTKB, string nameTable1)
        {
            string str = "";
            string newNameTable = "";
            int numInsertTable = 0;
            int num = 0;
            int numFile = 0;
            int numFixFileLine = 0;
            int numLineName = 0;
            string linkAccess = linkTKB + "/" + nameTable1 + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "ist", "inserttable");
                //neu str khac rong
                if (str.Replace(" ", "") != "")
                {
                    //kiem tra so bang dang muon chen
                    try
                    {
                        numInsertTable = int.Parse(str);
                    }
                    catch
                    {

                    }
                    //lay du lieu trong file name, dem so dong
                    if (File.Exists(linkTKB + "/" + nameTable1 + "/Name/name.txt") == true)
                    {
                        string[] fileName = File.ReadAllLines(linkTKB + "/" + nameTable1 + "/Name/name.txt");
                        foreach (string lines in fileName)
                        {
                            numLineName++;
                        }
                    }
                    //neu dong chen vao bang be hon hoac bang so cot dang co trong bang thi tien hanh chien cot voi ten moi
                    if (numInsertTable <= numLineName)
                    {
                        //ghi ten moi vao bang
                        Console.Write("NEW NAME [{0}]> ", numInsertTable);
                        newNameTable = Console.ReadLine();
                        //tat caplock
                        newNameTable = newNameTable.ToLower();
                        //xoa khoang trang
                        newNameTable = newNameTable.Replace(" ", "");
                        //neu so bang chen khac 0
                        if (numInsertTable != 0 && newNameTable != "")
                        {
                            //tao file ten moi
                            FileStream fileNew = new FileStream(linkAccess + "name1.txt", FileMode.Create);
                            fileNew.Close();
                            //ghi du lieu moi vao file
                            TextWriter textNewFileName = new StreamWriter(linkAccess + "name1.txt", true);
                            //doc du lieu trong file cu
                            string[] fileName = File.ReadAllLines(linkAccess + "/Name/name.txt");
                            foreach (string lines in fileName)
                            {
                                num++;
                                //ghi cac dong khac vao file
                                if (num != numInsertTable)
                                {
                                    textNewFileName.WriteLine(lines);
                                }
                                //neu dong can tao bang bang voi dong dang ghi hien tai
                                if (num == numInsertTable)
                                {
                                    textNewFileName.WriteLine(newNameTable);
                                    textNewFileName.WriteLine(lines);
                                }
                            }
                            textNewFileName.Close();
                            //xoa file cu
                            File.Delete(linkAccess + "/Name/name.txt");
                            //doi file moi thanh file cu
                            File.Move(linkAccess + "name1.txt", linkAccess + "/Name/name.txt");
                            //tao khoang trong moi cho file
                            //neu file khoang trong da ton tai
                            if (Directory.Exists(linkAccess + "set") == true)
                            {
                                //lay cac file co trong thu muc
                                string[] getFiles = Directory.GetFiles(linkAccess + "set");
                                foreach (string files in getFiles)
                                {
                                    //dem so file dang co trong thu muc
                                    numFile++;
                                }
                                //tao 1 file moi
                                FileStream fileNewSpace = new FileStream(linkAccess + "set/space" + (numFile + 1) + ".txt", FileMode.Create);
                                fileNewSpace.Close();
                                //ghi du lieu vao file voi tham so 10
                                TextWriter textNewSpace = new StreamWriter(linkAccess + "set/space" + (numFile + 1) + ".txt", false);
                                textNewSpace.WriteLine("10");
                                textNewSpace.Close();
                            }
                            //lay cac file trong file goc
                            string[] fileLines = Directory.GetFiles(linkAccess);
                            foreach (string files in fileLines)
                            {
                                if (files != linkAccess + "/Name/name.txt")
                                {
                                    //tao 1 file moi de ghi du lieu dong moi
                                    FileStream fileNewLine = new FileStream(files + "1", FileMode.Create);
                                    fileNewLine.Close();
                                    //ghi du lieu cu vao file moi
                                    TextWriter textNewLine = new StreamWriter(files + "1", true);
                                    //neu do khong file file ten
                                    //mo file sua du lieu
                                    string[] fileLine = File.ReadAllLines(files);
                                    foreach (string lines in fileLine)
                                    {
                                        numFixFileLine++;
                                        //ghi du lieu cu vao file moi
                                        if (numFixFileLine != numInsertTable)
                                        {
                                            textNewLine.WriteLine(lines);
                                        }
                                        //neu so dong can chen khoang trong == voi so dong hien tai tien hanh tao mot khoang trong de tranh bi loi bang
                                        if (numFixFileLine == numInsertTable)
                                        {
                                            textNewLine.WriteLine(" ");
                                            textNewLine.WriteLine(lines);
                                        }
                                    }
                                    textNewLine.Close();
                                    //xoa file cu
                                    File.Delete(files);
                                    //doi file moi ve dinh dang cu
                                    File.Move(files + "1", files);
                                    numFixFileLine = 0;
                                }
                            }
                        }
                    }
                }
            }
        }
        //xoa cot
        public static void DeleteColumnTable(string c, string linkTKB, string nameTable, string b)
        {
            string str = "";
            int num = 0;
            int num1 = 0;
            int numDeleteLine = 0;
            int numFixFileLine = 0;
            int numNewLine = 0;
            int numName = 0;
            int numFileName = 0;
            int numFileSpaces = 0;
            int numNewFileLineFileFileLine = 0;
            int numDeleteColumn = 0;
            int numLineDeleteColumns = 0;
            int numFileLineTable = 0;
            int numDelete = 0;
            int numDelete1 = 0;
            int numDelete2 = 0;
            int numNameChangeFilesSpace = 0;
            int oldSpace = 0;
            int iThucHien = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            char yn = ' ';
            //neu duong dan khac rong
            if (linkTKB != "" && c != "" && nameTable != "")
            {
                HelpTTL ttl = new HelpTTL();
                //tao thu muc chua vi tri xoa nhieu cot
                if (Directory.Exists(linkAccess + "DeleteColumns/") == false)
                {
                    //tao thu muc moi
                    DirectoryInfo newFolderDeleteColumns = new DirectoryInfo(linkAccess + "DeleteColumns/");
                    newFolderDeleteColumns.Create();
                    //tao file moi
                    FileStream fileNewDeleteColumns = new FileStream(linkAccess + "DeleteColumns/DeleteColumns", FileMode.Create);
                    fileNewDeleteColumns.Close();
                }
                // loc ky tu
                str = ttl.Loc2KyTu(c, "dct", "deletecolumntable");
                //neu str khac rong va duong dan co ton tai
                if (str.Replace(" ", "") != "" && Directory.Exists(linkAccess) == true)
                {
                    // kiem tra ten cot co dang duoc bao ve
                    string[] filePTC = File.ReadAllLines(linkTKB + nameTable + "/ProtectColumn/ProtectColumn");
                    foreach (string lines in filePTC)
                    {
                        if (str == lines)
                        {
                            iThucHien = 1;
                            ttl.HienThiThongBao("TABLE!", "COT (" + str + ") DANG DUOC BAO VE!", 48, b);
                        }
                    }
                    // neu ten file khong co trong file
                    if (iThucHien == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("COT >{0}< XE BI XOA BAN CO MUON TIEP TUC THUC HIEN?[y][n]", str);
                       Console.ResetColor();
                        char.TryParse(Console.ReadLine(), out yn);
                        if (yn == 'y' || yn == 'Y')
                        {
                            // xoa ten cot o phan question
                            if (Directory.Exists(linkAccess + "Question/" + str.Replace(" ", "").ToLower()) == true)
                                Directory.Delete(linkAccess + "Question/" + str.Replace(" ", "").ToLower(), true);
                            // 
                            FileStream fileNewDeleteColumns = new FileStream(linkAccess + "DeleteColumns/DeleteColumns", FileMode.Create);
                            fileNewDeleteColumns.Close();
                            //ghi vi tri dong can xoa trong file
                            TextWriter textLineDeleteColumn = new StreamWriter(linkAccess + "DeleteColumns/DeleteColumns", true);
                            //thay doi duong dan
                            linkAccess = linkTKB + "/" + nameTable + "/Name/name.txt";
                            //kiem tra ten file co o nhieu vi tri hay khong
                            string[] fileProtect = File.ReadAllLines(linkAccess);
                            foreach (string lines in fileProtect)
                            {
                                numLineDeleteColumns++;
                                //neu du lieu trung voi ten bang chuyen vi tri hien tai cua bang vao num1
                                if (lines == str)
                                {
                                    //ghi du lieu so dong tim duoc vao file
                                    textLineDeleteColumn.WriteLine(numLineDeleteColumns);
                                    //dem so dong tim duoc trong file
                                    numDeleteColumn++;
                                }
                            }
                            textLineDeleteColumn.Close();
                            //thay doi ten bang neu tim thay ten bang can xoa dang co trong bang
                            if (numDeleteColumn != 0)
                            {
                                //thay doi duong dan
                                linkAccess = linkTKB + "/" + nameTable + "/Name/name.txt";
                                //tao file moi
                                FileStream fileNew = new FileStream(linkAccess + "1", FileMode.Create);
                                fileNew.Close();
                                //ghi du lieu moi vao file
                                TextWriter textFileProtect = new StreamWriter(linkAccess + "1", true);
                                //doc du lieu file chinh
                                string[] fileProtect1 = File.ReadAllLines(linkAccess);
                                foreach (string lines in fileProtect1)
                                {
                                    num++;
                                    //ghi du lieu moi vao file protect1
                                    if (lines != str)
                                    {
                                        textFileProtect.WriteLine(lines);
                                    }
                                    //neu du lieu trung voi ten bang chuyen vi tri hien tai cua bang vao num1
                                    if (lines == str)
                                    {
                                        num1 = num;
                                        numDeleteLine = num;
                                    }
                                }
                                textFileProtect.Close();
                                //xoa file chinh
                                File.Delete(linkAccess);
                                //doi file chuyen doi thanh file chinh
                                File.Move(linkAccess + "1", linkAccess);
                            }
                            //xoa du lieu khoang cach, neu ten cua cot la 1 tien hanh xoa 1 cot
                            if (numDeleteColumn == 1)
                            {
                                //thay doi duong dan
                                linkAccess = linkTKB + "/" + nameTable + "/set/space" + num1 + ".txt";
                                //xoa file
                                File.Delete(linkAccess);
                                //chuyen cac file khoang cach lon hon ve voi file hien tai
                                do
                                {
                                    //neu file lon hon ton tai, thay doi ve vi tri phu hop
                                    if (File.Exists(linkTKB + "/" + nameTable + "/set/space" + (num1 + 1) + ".txt") == true)
                                    {
                                        File.Move(linkTKB + "/" + nameTable + "/set/space" + (num1 + 1) + ".txt", linkTKB + "/" + nameTable + "/set/space" + num1 + ".txt");
                                        num1++;
                                    }
                                } while (File.Exists(linkTKB + "/" + nameTable + "/set/space" + (num1 + 1) + ".txt") == true);
                                //sua du lieu trong cac file line
                                string[] fileLines = Directory.GetFiles(linkTKB + "/" + nameTable + "/");
                                foreach (string files in fileLines)
                                {
                                    numFixFileLine++;
                                    //neu file dong co ton tai
                                    if (File.Exists(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt") == true)
                                    {
                                        //ghi du lieu moi vao file, tao file moi
                                        FileStream fileNewLine = new FileStream(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt" + numFixFileLine, FileMode.Create);
                                        fileNewLine.Close();
                                        //ghi du lieu moi vao file
                                        TextWriter textFile = new StreamWriter(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt" + numFixFileLine, true);
                                        //doc du lieu file cu de ghi du lieu vao file moi
                                        string[] fileOldLine = File.ReadAllLines(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt");
                                        foreach (string lines in fileOldLine)
                                        {
                                            numNewLine++;
                                            //neu dong trong file khac voi dong da xoa khoi bang thi khong ghi vao file moi
                                            if (numNewLine != numDeleteLine)
                                            {
                                                textFile.WriteLine(lines);
                                            }
                                        }
                                        textFile.Close();
                                        numNewLine = 0;
                                        //xoa file cu
                                        File.Delete(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt");
                                        //doi ten file moi thanh file cu
                                        File.Move(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt" + numFixFileLine, linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt");
                                    }
                                }
                                numFixFileLine = 0;
                                //kiem tra du lieu xoa co nhieu hon 1 bang
                                string[] getFileName = File.ReadAllLines(linkTKB + "/" + nameTable + "/Name/name.txt");
                                foreach (string linesName in getFileName)
                                {
                                    numName++;
                                }
                                //lay du lieu trong file khoang trang
                                string[] getFileSpace = Directory.GetFiles(linkTKB + "/" + nameTable + "/set/");
                                foreach (string files in getFileSpace)
                                {
                                    numFileSpaces++;
                                    if (numFileSpaces > numName)
                                    {
                                        //xoa file khoang trang du
                                        File.Delete(files);
                                    }
                                }
                                //kiem tra du lieu trong cac file line neu du lieu nhieu hon so hien thi dang co tren bang tien hanh xoa
                                //sua du lieu trong file name
                                string[] fileName = File.ReadAllLines(linkTKB + "/" + nameTable + "/Name/name.txt");
                                foreach (string linesFileName in fileName)
                                {
                                    numFileName++;
                                }
                                string[] fileLines1 = Directory.GetFiles(linkTKB + "/" + nameTable + "/");
                                foreach (string files in fileLines1)
                                {
                                    numFixFileLine++;
                                    //neu file dong co ton tai
                                    if (File.Exists(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt") == true)
                                    {
                                        //tao file moi
                                        FileStream fileNewLine = new FileStream(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt" + numFixFileLine, FileMode.Create);
                                        fileNewLine.Close();
                                        //ghi du lieu vao file moi
                                        TextWriter textNewFile = new StreamWriter(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt" + numFixFileLine, true);
                                        //doc file line
                                        string[] fileLines2 = File.ReadAllLines(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt");
                                        foreach (string lines in fileLines2)
                                        {
                                            numNewFileLineFileFileLine++;
                                            //neu dong moi < hoac bang dong cu
                                            if (numNewFileLineFileFileLine <= numFileName)
                                            {
                                                //ghi du lieu moi vao file moi
                                                textNewFile.WriteLine(lines);
                                            }
                                        }
                                        numNewFileLineFileFileLine = 0;
                                        textNewFile.Close();
                                        //xoa file cu
                                        File.Delete(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt");
                                        //doi file moi thanh file cu
                                        File.Move(linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt" + numFixFileLine, linkTKB + "/" + nameTable + "/line" + numFixFileLine + ".txt");
                                    }
                                }
                            }
                            //neu ten cot tim thay o nhieu vi tri tron file
                            if (numDeleteColumn > 1)
                            {
                                numName = 0;
                                numFileSpaces = 0;
                                //sua cac file trong thu muc set
                                //lay cac file line trong bang
                                string[] fileLine = Directory.GetFiles(linkTKB + "/" + nameTable + "/");
                                foreach (string files in fileLine)
                                {
                                    numFileLineTable++;
                                    //neu file line co ton tai
                                    if (File.Exists(linkTKB + "/" + nameTable + "/line" + numFileLineTable + ".txt") == true)
                                    {
                                        numDelete2 = 0;
                                        //lay du lieu trong file xoa cac cot
                                        string[] fileDC = File.ReadAllLines(linkTKB + "/" + nameTable + "/DeleteColumns/DeleteColumns");
                                        foreach (string lineDC in fileDC)
                                        {
                                            numDelete1 = 0;
                                            try
                                            {
                                                numDelete1 = int.Parse(lineDC);
                                            }
                                            catch
                                            {

                                            }
                                            //neu numDelete1 khac 0 tien hanh xoa du lieu trong file
                                            if (numDelete1 != 0)
                                            {
                                                numDelete++;
                                                //xoa du lieu trong file
                                                var file = new List<string>(File.ReadAllLines(linkTKB + "/" + nameTable + "/line" + numFileLineTable + ".txt"));
                                                file.RemoveAt(numDelete1 - numDelete2 - 1);
                                                File.WriteAllLines(linkTKB + "/" + nameTable + "/line" + numFileLineTable + ".txt", file.ToArray());
                                                // Console.WriteLine(numDelete1 + "-" + (numDelete1 - numDelete2));
                                                // Console.ReadKey();
                                                numDelete2++;
                                            }
                                        }
                                    }
                                }
                                //kiem tra du lieu xoa co nhieu hon 1 bang
                                string[] getFileName = File.ReadAllLines(linkTKB + "/" + nameTable + "/Name/name.txt");
                                foreach (string linesName in getFileName)
                                {
                                    numName++;
                                }
                                //su dung vong do de thay doi ten file
                                //lay du lieu trong file khoang trang
                                string[] getFileSpace = Directory.GetFiles(linkTKB + "/" + nameTable + "/set/");
                                foreach (string files in getFileSpace)
                                {
                                    numFileSpaces++;
                                    if (numFileSpaces <= numName)
                                    {
                                        Console.WriteLine(files);
                                        //tao file moi
                                        FileStream fileNewSpace = new FileStream(linkTKB + "/" + nameTable + "/set/" + numFileSpaces, FileMode.Create);
                                        fileNewSpace.Close();
                                        //doc du lieu file cu
                                        string[] fileSpaceR = File.ReadAllLines(files);
                                        foreach (string linesS in fileSpaceR)
                                        {
                                            try
                                            {
                                                oldSpace = int.Parse(linesS);
                                            }
                                            catch
                                            {

                                            }
                                        }
                                        //ghi du lieu vao file moi tao
                                        TextWriter textNewFile = new StreamWriter(linkTKB + "/" + nameTable + "/set/" + numFileSpaces, false);
                                        textNewFile.WriteLine(oldSpace);
                                        textNewFile.Close();
                                        //xoa file cu
                                        File.Delete(files);
                                    }
                                    if (numFileSpaces > numName)
                                    {
                                        File.Delete(files);
                                    }
                                }
                                //khoi dong lai bien diem dong trong thu muc space
                                //lay du lieu trong file space
                                string[] fileSpaceChangeName = Directory.GetFiles(linkTKB + "/" + nameTable + "/set/");
                                foreach (string filesSpace in fileSpaceChangeName)
                                {
                                    numNameChangeFilesSpace++;
                                    //doi ten file
                                    File.Move(filesSpace, linkTKB + "/" + nameTable + "/set/space" + numNameChangeFilesSpace + ".txt");
                                }
                            }
                        }
                    }
                }
            }
        }
        //chen dong
        public static void InsertLine(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNewLine = 0;
            int numLinesNameTable = 0;
            int numLineFile = 0;
            int numFileLine = 0;
            int numFixLineFileInsert = 0;
            int numChangeFileLine = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "isl", "insertline");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    try
                    {
                        numNewLine = int.Parse(str);
                    }
                    catch
                    {

                    }
                    //thay doi duong dan
                    linkAccess = linkTKB + "/" + nameTable + "/Name/name.txt";
                    //lay so dong dan co trong file name
                    string[] fileNameTable = File.ReadAllLines(linkAccess);
                    foreach (string linesName in fileNameTable)
                    {
                        numLinesNameTable++;
                    }
                    //lay cac file co trong thu muc
                    string[] fileLines = Directory.GetFiles(linkTKB + "/" + nameTable + "/");
                    foreach (string files in fileLines)
                    {
                        numFileLine++;
                        //neu file lon hon ton tai
                        if (File.Exists(linkTKB + "/" + nameTable + "/line" + numFileLine + ".txt") == true)
                        {
                            //dem so file line dang co
                            numLineFile++;
                        }
                    }
                    //neu dong can chen it hon so hoac bang so dong dang co
                    if (numNewLine <= numLineFile)
                    {
                        //tien hanh chen dong
                        //thay doi tu file lon nhat den file nho nhat
                        do
                        {
                            //thay doi file tu cao den thap
                            File.Move(linkTKB + "/" + nameTable + "/line" + (numLineFile - numChangeFileLine) + ".txt", linkTKB + "/" + nameTable + "/line" + (numLineFile - numChangeFileLine + 1) + ".txt");
                            numChangeFileLine++;
                        } while (numChangeFileLine <= (numLineFile - numNewLine));
                        //tao file chen
                        FileStream fileInsert = new FileStream(linkTKB + "/" + nameTable + "/line" + numNewLine + ".txt", FileMode.Create);
                        fileInsert.Close();
                        //ghi du lieu vao file
                        TextWriter textFileInsert = new StreamWriter(linkTKB + "/" + nameTable + "/line" + numNewLine + ".txt", true);
                        do
                        {
                            numFixLineFileInsert++;
                            //tao khoang trong vao dong moi de tranh loi bang
                            textFileInsert.WriteLine(" ");
                        } while (numFixLineFileInsert <= numLinesNameTable);
                        textFileInsert.Close();
                    }
                }
            }
        }
        //hien thi thong tin trong 1 cot
        public static void ShowColumn(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "sc", "showcolumn");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    //kiem tra xem ten bang hien thi co ton tai hay khong
                    string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                    foreach (string linesName in fileNameTable)
                    {
                        numNameTable++;
                        //neu ten bang can kiem tra co ton tai trong bang
                        if (linesName == str)
                        {
                            numShowColumn = numNameTable;
                        }
                    }
                    //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                    if (numShowColumn != 0)
                    {
                        //khoi dong lai bien num name table
                        numNameTable = 0;
                        //lay cac file line co trong bang
                        string[] folderTable = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable)
                        {
                            numNameTable++;
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    numRunFileLine++;
                                    //neu dong hien thi o vi tri cot
                                    if (numShowColumn == numRunFileLine)
                                    {
                                        Console.WriteLine("[{0}] {1}({2})", str.ToUpper(), linesColumn, numNameTable);
                                    }
                                }
                                numRunFileLine = 0;
                            }
                        }
                        Console.ReadKey();
                    }
                }
            }
        }
        //hien thi thong tin trong 1 cot theo so dong
        public static void ShowColumnLine(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            int num1 = 0;
            int num2 = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "scl", "showcolumnline");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    Console.Write("LINE1>");
                    int.TryParse(Console.ReadLine(), out num1);
                    Console.Write("LINE2>");
                    int.TryParse(Console.ReadLine(), out num2);
                    //kiem tra xem ten bang hien thi co ton tai hay khong
                    string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                    foreach (string linesName in fileNameTable)
                    {
                        numNameTable++;
                        //neu ten bang can kiem tra co ton tai trong bang
                        if (linesName == str)
                        {
                            numShowColumn = numNameTable;
                        }
                    }
                    //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                    if (numShowColumn != 0)
                    {
                        //khoi dong lai bien num name table
                        numNameTable = 0;
                        //chay vong for
                        for (int i = num1; i <= num2; i++)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + i + ".txt") == true)
                            {
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + i + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    numRunFileLine++;
                                    //neu dong hien thi o vi tri cot
                                    if (numShowColumn == numRunFileLine)
                                    {
                                        Console.WriteLine("[{0}] {1}({2})", str.ToUpper(), linesColumn, i);
                                    }
                                }
                                numRunFileLine = 0;
                            }
                        }
                        Console.ReadKey();
                    }
                }
            }
        }
        //tinh tong cot
        public static void GetSumColumn(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            long numSumColumn = 0;
            long numInFile = 0;
            long numMax = 0;
            long numMin = 0;
            double numSum = 0;
            string sDifferent = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            double numPercent = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "gsc", "getsumcolumn");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    Console.Write("REMOVED> ");
                    sDifferent = Console.ReadLine();
                    //kiem tra xem ten bang hien thi co ton tai hay khong
                    string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                    foreach (string linesName in fileNameTable)
                    {
                        numNameTable++;
                        //neu ten bang can kiem tra co ton tai trong bang
                        if (linesName == str)
                        {
                            numShowColumn = numNameTable;
                        }
                    }
                    //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                    if (numShowColumn != 0)
                    {
                        //khoi dong lai bien num name table
                        numNameTable = 0;
                        //lay cac file line co trong bang
                        string[] folderTable = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    numInFile = 0;
                                    numRunFileLine++;
                                    //neu dong hien thi o vi tri cot
                                    if (numShowColumn == numRunFileLine)
                                    {
                                        numPercent++;
                                        //chuyen doi so trong file thanh so nguyen
                                        try
                                        {
                                            numInFile = long.Parse(linesColumn);
                                        }
                                        catch
                                        {

                                        }
                                        //tim cac gia tri khac tim thay trong file
                                        if (linesColumn != " " && linesColumn != sDifferent)
                                            numSum++;
                                    }
                                    // tim max
                                    numMax = ttl.TimMax(numInFile, numMax);
                                    // tim min
                                    numMin = ttl.TimMin(numInFile, numMin);
                                    //neu so trong file khac 0, bat dau tinh tong
                                    if (numInFile != 0)
                                        numSumColumn = numInFile + numSumColumn;
                                }
                                numRunFileLine = 0;
                            }
                            numNameTable++;
                        }
                        //hien thi tong trong cot
                        Console.WriteLine(string.Format("SUM COLUMN [{0}]: {1:0,0} - GTTT: {2} - PERCENT: {3:0.00}% - MAX: {4:0,0} - MIN: {5:0,0}", str, numSumColumn, numSum, numSum * 100 / numPercent, numMax, numMin));
                        Console.ReadKey();
                    }
                }
            }
        }
        // hoan doi vi tri 2 cot vs nhau
        public static void MoveColumn(string c, string linkTKB, string nameTable, string b)
        {
            string nameColumn1 = "";
            string nameColumn2 = "";
            int numColumn1 = 0;
            int numColumn2 = 0;
            int numNameTable = 0;
            string linkAccess = "";
            int numRunFileLine = 0;
            string strLine = "";
            string strName1 = "";
            string strName2 = "";
            bool bTF = false;
            if (linkTKB != "")
            {
                HelpTTL ttl = new HelpTTL();
                Console.Write("NAME COLUMN>");
                nameColumn1 = Console.ReadLine();
                // kiem tra ten cot trong file
                bTF = ttl.KiemTraDuLieuTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn1.ToLower().Replace(" ", ""));
                // neu du lieu ten cot co ton tai
                if (bTF == true)
                {
                    bTF = false;
                    Console.Write("| {0} |<=>", nameColumn1.ToUpper());
                    nameColumn2 = Console.ReadLine();
                    // kiem tra ten cot trong file
                    bTF = ttl.KiemTraDuLieuTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn2.ToLower().Replace(" ", ""));
                    //neu ten cot co ton tai trong file
                    if (bTF == true && nameColumn1.Replace(" ", "").ToLower() != nameColumn2.Replace(" ", "").ToLower())
                    {
                        numColumn1 = ttl.TraVeSoDongTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn1.ToLower().Replace(" ", ""));
                        numColumn2 = ttl.TraVeSoDongTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn2.ToLower().Replace(" ", ""));
                        // tao file
                        ttl.TaoFile(linkTKB + "/" + nameTable + "/" + numColumn1);
                        ttl.TaoFile(linkTKB + "/" + nameTable + "/" + numColumn2);
                        // lay cac file trong thu muc
                        //khoi dong lai bien num name table
                        numNameTable = 0;
                        linkAccess = linkTKB + "/" + nameTable + "/";
                        // TAO FILE MOI
                        //lay cac file line co trong bang
                        string[] folderTable = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    //neu dong hien thi o vi tri cot
                                    if (numColumn1 == numRunFileLine)
                                    {
                                        ttl.WriteLine(linkTKB + "/" + nameTable + "/" + numColumn1, linesColumn);
                                    }
                                    //neu dong hien thi o vi tri cot
                                    if (numColumn2 == numRunFileLine)
                                    {
                                        ttl.WriteLine(linkTKB + "/" + nameTable + "/" + numColumn2, linesColumn);
                                    }
                                    numRunFileLine++;
                                }
                                numRunFileLine = 0;
                            }
                            numNameTable++;
                        }
                        numNameTable = 0;
                        // GHI DU LIEU CUA FILE MOI TAO VAO TAT CA CAC FILE TRONG TABLE C1
                        //lay cac file line co trong bang
                        string[] folderTable1 = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable1)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                // tao file moi
                                ttl.TaoFile(linkAccess + "line" + numNameTable + "new.txt");
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    //c1
                                    if (numRunFileLine == numColumn2)
                                    {
                                        strLine = ttl.TraDuLieuSoNDongTrongFile(linkAccess + numColumn1, numNameTable);
                                        ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt", strLine);
                                    }
                                    if (numRunFileLine != numColumn2)
                                    {
                                        ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt", linesColumn);
                                    }
                                    numRunFileLine++;
                                }
                                numRunFileLine = 0;
                                // xoa file
                                File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                // doi file moi thanh file cu~
                                File.Move(linkAccess + "line" + numNameTable + "new.txt", linkAccess + "line" + numNameTable + ".txt");
                            }
                            numNameTable++;
                        }
                        numNameTable = 0;
                        // GHI DU LIEU CUA FILE MOI TAO VAO TAT CA CAC FILE TRONG TABLE C2
                        //lay cac file line co trong bang
                        string[] folderTable2 = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable2)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                // tao file moi
                                ttl.TaoFile(linkAccess + "line" + numNameTable + "new.txt");
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    if (numRunFileLine == numColumn1)
                                    {
                                        strLine = ttl.TraDuLieuSoNDongTrongFile(linkAccess + numColumn2, numNameTable);
                                        ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt", strLine);
                                    }
                                    if (numRunFileLine != numColumn1)
                                    {
                                        ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt", linesColumn);
                                    }
                                    numRunFileLine++;
                                }
                                numRunFileLine = 0;
                                // xoa file
                                File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                // doi file moi thanh file cu~
                                File.Move(linkAccess + "line" + numNameTable + "new.txt", linkAccess + "line" + numNameTable + ".txt");
                            }
                            numNameTable++;
                        }
                        //xoa file
                        File.Delete(linkTKB + "/" + nameTable + "/" + numColumn1);
                        File.Delete(linkTKB + "/" + nameTable + "/" + numColumn2);
                        // doi ten bang
                        strName1 = ttl.TraDuLieuSoNDongTrongFile(linkAccess + "/Name/name.txt", numColumn1 + 1);
                        strName2 = ttl.TraDuLieuSoNDongTrongFile(linkAccess + "/Name/name.txt", numColumn2 + 1);
                        // ghi du lieu vao file
                        ttl.GhiDuLieuVaoFileOViTriThuN(linkAccess + "/Name/name.txt", numColumn1, strName2);
                        ttl.GhiDuLieuVaoFileOViTriThuN(linkAccess + "/Name/name.txt", numColumn2, strName1);
                    }
                }
                //hien thi thong bao trong file
                if (bTF == false)
                    ttl.HienThiThongBao("NO FOUND NAME COLUMN!", "TEN BANG KHONG TON TAI!", 16, b);
            }
        }
        // copy column
        // hoan doi vi tri 2 cot vs nhau
        public static void CopyColumn(string c, string linkTKB, string nameTable, string b)
        {
            string nameColumn1 = "";
            string nameColumn2 = "";
            int numColumn1 = 0;
            int numColumn2 = 0;
            int numNameTable = 0;
            string linkAccess = "";
            int numRunFileLine = 0;
            string strLine = "";
            // string strName1 = "";
            // string strName2 = "";
            bool bTF = false;
            if (linkTKB != "")
            {
                HelpTTL ttl = new HelpTTL();
                Console.Write("NAME COLUMN>");
                nameColumn1 = Console.ReadLine();
                // kiem tra ten cot trong file
                bTF = ttl.KiemTraDuLieuTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn1.ToLower().Replace(" ", ""));
                // neu du lieu ten cot co ton tai
                if (bTF == true)
                {
                    bTF = false;
                    Console.Write("| {0} | =>", nameColumn1.ToUpper());
                    nameColumn2 = Console.ReadLine();
                    // kiem tra ten cot trong file
                    bTF = ttl.KiemTraDuLieuTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn2.ToLower().Replace(" ", ""));
                    //neu ten cot co ton tai trong file
                    if (bTF == true && nameColumn1.Replace(" ", "").ToLower() != nameColumn2.Replace(" ", "").ToLower())
                    {
                        numColumn1 = ttl.TraVeSoDongTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn1.ToLower().Replace(" ", ""));
                        numColumn2 = ttl.TraVeSoDongTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn2.ToLower().Replace(" ", ""));
                        // tao file
                        ttl.TaoFile(linkTKB + "/" + nameTable + "/" + numColumn1);
                        ttl.TaoFile(linkTKB + "/" + nameTable + "/" + numColumn2);
                        // lay cac file trong thu muc
                        //khoi dong lai bien num name table
                        numNameTable = 0;
                        linkAccess = linkTKB + "/" + nameTable + "/";
                        // TAO FILE MOI
                        //lay cac file line co trong bang
                        string[] folderTable = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    //neu dong hien thi o vi tri cot
                                    if (numColumn1 == numRunFileLine)
                                    {
                                        ttl.WriteLine(linkTKB + "/" + nameTable + "/" + numColumn1, linesColumn);
                                    }
                                    //neu dong hien thi o vi tri cot
                                    if (numColumn2 == numRunFileLine)
                                    {
                                        ttl.WriteLine(linkTKB + "/" + nameTable + "/" + numColumn2, linesColumn);
                                    }
                                    numRunFileLine++;
                                }
                                numRunFileLine = 0;
                            }
                            numNameTable++;
                        }
                        numNameTable = 0;
                        // GHI DU LIEU CUA FILE MOI TAO VAO TAT CA CAC FILE TRONG TABLE C1
                        //lay cac file line co trong bang
                        string[] folderTable1 = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable1)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                // tao file moi
                                ttl.TaoFile(linkAccess + "line" + numNameTable + "new.txt");
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    //c1
                                    if (numRunFileLine == numColumn2)
                                    {
                                        strLine = ttl.TraDuLieuSoNDongTrongFile(linkAccess + numColumn1, numNameTable);
                                        // ghi du lieu moi vao file
                                        ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt", strLine);
                                    }
                                    if (numRunFileLine != numColumn2)
                                    {
                                        ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt", linesColumn);
                                    }
                                    numRunFileLine++;
                                }
                                numRunFileLine = 0;
                                // xoa file
                                File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                // doi file moi thanh file cu~
                                File.Move(linkAccess + "line" + numNameTable + "new.txt", linkAccess + "line" + numNameTable + ".txt");
                            }
                            numNameTable++;
                        }
                        // numNameTable = 0;
                        // // GHI DU LIEU CUA FILE MOI TAO VAO TAT CA CAC FILE TRONG TABLE C2
                        // //lay cac file line co trong bang
                        // string[] folderTable2 = Directory.GetFiles(linkAccess);
                        // foreach(string files in folderTable2)
                        // {                          
                        //     //neu file line co ton tai
                        //     if(File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                        //     {
                        //         // tao file moi
                        //         ttl.TaoFile(linkAccess + "line" + numNameTable + "new.txt");
                        //         //hien thi thong tin cua file
                        //         string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                        //         foreach(string linesColumn in showFileLineInColumn)
                        //         {
                        //             if(numRunFileLine == numColumn1)
                        //             {
                        //                 strLine = ttl.TraDuLieuSoNDongTrongFile(linkAccess + numColumn2,numNameTable);
                        //                 ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt",strLine);
                        //             }
                        //             if(numRunFileLine != numColumn1)
                        //             {
                        //                 ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt",linesColumn);
                        //             }
                        //             numRunFileLine++;
                        //         }
                        //         numRunFileLine = 0;
                        //         // xoa file
                        //         File.Delete(linkAccess + "line" + numNameTable + ".txt");
                        //         // doi file moi thanh file cu~
                        //         File.Move(linkAccess + "line" + numNameTable + "new.txt",linkAccess + "line" + numNameTable + ".txt");
                        //     }
                        //     numNameTable++;
                        // }
                        //xoa file
                        File.Delete(linkTKB + "/" + nameTable + "/" + numColumn1);
                        File.Delete(linkTKB + "/" + nameTable + "/" + numColumn2);
                        // // doi ten bang
                        // strName1 = ttl.TraDuLieuSoNDongTrongFile(linkAccess + "/Name/name.txt",numColumn1 + 1);
                        // strName2 = ttl.TraDuLieuSoNDongTrongFile(linkAccess + "/Name/name.txt",numColumn2 + 1);
                        // // ghi du lieu vao file
                        // ttl.GhiDuLieuVaoFileOViTriThuN(linkAccess + "/Name/name.txt",numColumn1,strName2);
                        // ttl.GhiDuLieuVaoFileOViTriThuN(linkAccess + "/Name/name.txt",numColumn2,strName1);
                    }
                }
                //hien thi thong bao trong file
                if (bTF == false)
                    ttl.HienThiThongBao("NO FOUND NAME COLUMN!", "TEN BANG KHONG TON TAI!", 16, b);
            }
        }
        // copy column
        // thay doi thong tin trong cot vs the <a>
        public static void CopyColumnWithTagA(string c, string linkTKB, string nameTable, string b)
        {
            string nameColumn1 = "";
            string nameColumn2 = "";
            int numColumn1 = 0;
            int numColumn2 = 0;
            int numNameTable = 0;
            string linkAccess = "";
            int numRunFileLine = 0;
            string strLine = "";
            // string strName1 = "";
            // string strName2 = "";
            bool bTF = false;
            if (linkTKB != "")
            {
                HelpTTL ttl = new HelpTTL();
                Console.Write("NAME COLUMN>");
                nameColumn1 = Console.ReadLine();
                // kiem tra ten cot trong file
                bTF = ttl.KiemTraDuLieuTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn1.ToLower().Replace(" ", ""));
                // neu du lieu ten cot co ton tai
                if (bTF == true)
                {
                    bTF = false;
                    Console.Write("| {0} | =>", nameColumn1.ToUpper());
                    nameColumn2 = Console.ReadLine();
                    // kiem tra ten cot trong file
                    bTF = ttl.KiemTraDuLieuTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn2.ToLower().Replace(" ", ""));
                    //neu ten cot co ton tai trong file
                    if (bTF == true && nameColumn1.Replace(" ", "").ToLower() != nameColumn2.Replace(" ", "").ToLower())
                    {
                        numColumn1 = ttl.TraVeSoDongTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn1.ToLower().Replace(" ", ""));
                        numColumn2 = ttl.TraVeSoDongTrongFile(linkTKB + "/" + nameTable + "/Name/name.txt", nameColumn2.ToLower().Replace(" ", ""));
                        // tao file
                        ttl.TaoFile(linkTKB + "/" + nameTable + "/" + numColumn1);
                        ttl.TaoFile(linkTKB + "/" + nameTable + "/" + numColumn2);
                        // lay cac file trong thu muc
                        //khoi dong lai bien num name table
                        numNameTable = 0;
                        linkAccess = linkTKB + "/" + nameTable + "/";
                        // TAO FILE MOI
                        //lay cac file line co trong bang
                        string[] folderTable = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    //neu dong hien thi o vi tri cot
                                    if (numColumn1 == numRunFileLine)
                                    {
                                        ttl.WriteLine(linkTKB + "/" + nameTable + "/" + numColumn1, linesColumn);
                                    }
                                    //neu dong hien thi o vi tri cot
                                    if (numColumn2 == numRunFileLine)
                                    {
                                        ttl.WriteLine(linkTKB + "/" + nameTable + "/" + numColumn2, linesColumn);
                                    }
                                    numRunFileLine++;
                                }
                                numRunFileLine = 0;
                            }
                            numNameTable++;
                        }
                        numNameTable = 0;
                        // GHI DU LIEU CUA FILE MOI TAO VAO TAT CA CAC FILE TRONG TABLE C1
                        //lay cac file line co trong bang
                        string[] folderTable1 = Directory.GetFiles(linkAccess);
                        foreach (string files in folderTable1)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                            {
                                // tao file moi
                                ttl.TaoFile(linkAccess + "line" + numNameTable + "new.txt");
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    //c1
                                    if (numRunFileLine == numColumn2)
                                    {
                                        strLine = ttl.TraDuLieuSoNDongTrongFile(linkAccess + numColumn1, numNameTable);
                                        // ghi du lieu moi vao file
                                        ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt", "<a href=\"" + strLine + "\" target=\"_blank\">" + strLine + "</a>");
                                    }
                                    if (numRunFileLine != numColumn2)
                                    {
                                        ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt", linesColumn);
                                    }
                                    numRunFileLine++;
                                }
                                numRunFileLine = 0;
                                // xoa file
                                File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                // doi file moi thanh file cu~
                                File.Move(linkAccess + "line" + numNameTable + "new.txt", linkAccess + "line" + numNameTable + ".txt");
                            }
                            numNameTable++;
                        }
                        // numNameTable = 0;
                        // // GHI DU LIEU CUA FILE MOI TAO VAO TAT CA CAC FILE TRONG TABLE C2
                        // //lay cac file line co trong bang
                        // string[] folderTable2 = Directory.GetFiles(linkAccess);
                        // foreach(string files in folderTable2)
                        // {                          
                        //     //neu file line co ton tai
                        //     if(File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                        //     {
                        //         // tao file moi
                        //         ttl.TaoFile(linkAccess + "line" + numNameTable + "new.txt");
                        //         //hien thi thong tin cua file
                        //         string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                        //         foreach(string linesColumn in showFileLineInColumn)
                        //         {
                        //             if(numRunFileLine == numColumn1)
                        //             {
                        //                 strLine = ttl.TraDuLieuSoNDongTrongFile(linkAccess + numColumn2,numNameTable);
                        //                 ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt",strLine);
                        //             }
                        //             if(numRunFileLine != numColumn1)
                        //             {
                        //                 ttl.WriteLine(linkAccess + "line" + numNameTable + "new.txt",linesColumn);
                        //             }
                        //             numRunFileLine++;
                        //         }
                        //         numRunFileLine = 0;
                        //         // xoa file
                        //         File.Delete(linkAccess + "line" + numNameTable + ".txt");
                        //         // doi file moi thanh file cu~
                        //         File.Move(linkAccess + "line" + numNameTable + "new.txt",linkAccess + "line" + numNameTable + ".txt");
                        //     }
                        //     numNameTable++;
                        // }
                        //xoa file
                        File.Delete(linkTKB + "/" + nameTable + "/" + numColumn1);
                        File.Delete(linkTKB + "/" + nameTable + "/" + numColumn2);
                        // // doi ten bang
                        // strName1 = ttl.TraDuLieuSoNDongTrongFile(linkAccess + "/Name/name.txt",numColumn1 + 1);
                        // strName2 = ttl.TraDuLieuSoNDongTrongFile(linkAccess + "/Name/name.txt",numColumn2 + 1);
                        // // ghi du lieu vao file
                        // ttl.GhiDuLieuVaoFileOViTriThuN(linkAccess + "/Name/name.txt",numColumn1,strName2);
                        // ttl.GhiDuLieuVaoFileOViTriThuN(linkAccess + "/Name/name.txt",numColumn2,strName1);
                    }
                }
                //hien thi thong bao trong file
                if (bTF == false)
                    ttl.HienThiThongBao("NO FOUND NAME COLUMN!", "TEN BANG KHONG TON TAI!", 16, b);
            }
        }
        // FIX LOI MAT DONG TRONG TABLE (LỖI NÀY DẪN ĐẾN VIỆC BẠN KHÔNG THỂ CHÈN DÒNG TRONG BẢNG VS BẠN BỊ MẤT DỮ LIỆU)
        public static void FixErrorTable(string c, string linkTKB, string nameTable, string b)
        {
            int numLine = 0;
            char yn = ' ';
            string linkAccess = linkTKB + "/" + nameTable;
            HelpTTL ttl = new HelpTTL();
            // tao thu muc chua file
            ttl.TaoThuMuc(linkAccess + "/FileError");
            // copy file line 1 tu table vao thu muc
            if (File.Exists(linkAccess + "/line1.txt") == true)
                File.Copy(linkAccess + "/line1.txt", linkAccess + "/FileError/line1.txt");
            // thong bao loi~
            if (File.Exists(linkAccess + "/FileError/line1.txt") == false && File.Exists(linkAccess + "/line1.txt") == false)
            {
                ttl.HienThiThongBao("NO FOUND LINE1!", "KHONG TIM THAY DONG CAN SUA LOI~! LOI~ SE DUOC VA' VS DU LIEU = NULL!", 16, b);
                numLine = ttl.DemSoDongTrongFile(linkAccess + "/Name/name.txt");
                ttl.TaoFile(linkAccess + "/line1.txt");
                // ghi du lieu vao file
                for (int i = 0; i < numLine; i++)
                {
                    ttl.WriteLine(linkAccess + "/line1.txt", " ");
                }
            }
            // va loi~
            if (File.Exists(linkAccess + "/FileError/line1.txt") == true && File.Exists(linkAccess + "/line1.txt") == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("TIM THAY PHAN VA LOI~ BAN CO MUON VA LOI~ [LINE1] KHONG?[Y][N]");
                char.TryParse(Console.ReadLine(), out yn);
                // 
                if (yn == 'y')
                {
                    File.Copy(linkAccess + "/FileError/line1.txt", linkAccess + "/line1.txt");
                }
            }
        }
        // Thêm câu hỏi truy vấn trước khi nhập dữ liệu vào cột
        public static void Question(string c, string linkTKB, string nameTable, string b)
        {
            char yn = ' ';
            bool tf = false;
            string strNameColumn = "";
            string strNewQuestion = "";
            string linkAccess = linkTKB + nameTable + "/";
            // goi phuong thuc tro giup
            HelpTTL ttl = new HelpTTL();
            // tao thu muc chua cac cau truy van
            ttl.TaoThuMuc(linkAccess + "Question");
            Console.Write("NAME COLUMN: ");
            strNameColumn = Console.ReadLine();
            // kiem tra ten bang trong file chua ten bang?
            tf = ttl.KiemTraDuLieuTrongFile(linkAccess + "/Name/name.txt", strNameColumn);
            // neu ten bang co trong file
            if (tf == true)
            {
                // tao thu muc chua ten cot trong thu muc chua cac cau truy van
                ttl.TaoThuMuc(linkAccess + "Question/" + strNameColumn.ToLower().Replace(" ", ""));
                // tao cau hoi?
                Console.Write("NEW QUESTION: ");
                strNewQuestion = Console.ReadLine();
                // pass
                Console.Write("PASS[Y/N]: ");
                char.TryParse(Console.ReadLine(), out yn);
                // neu cau hoi khac rong~ va bang y hoac n
                if (strNewQuestion.Replace(" ", "") != "" && yn == 'y' || strNewQuestion.Replace(" ", "") != "" && yn == 'Y' || strNewQuestion.Replace(" ", "") != "" && yn == 'N' || strNewQuestion.Replace(" ", "") != "" && yn == 'n')
                {
                    try
                    {
                        // tao thu muc chua cau hoi truy van
                        ttl.TaoThuMuc(linkAccess + "Question/" + strNameColumn.ToLower().Replace(" ", "") + "/" + strNewQuestion.Replace(" ", "").ToLower());
                        // tao file chua cau hoi
                        ttl.TaoFile(linkAccess + "Question/" + strNameColumn.ToLower().Replace(" ", "") + "/" + strNewQuestion.Replace(" ", "").ToLower() + "/question");
                        // ghi du lieu vao file chua cau hoi
                        ttl.GhiDuLieuVaoFile(linkAccess + "Question/" + strNameColumn.ToLower().Replace(" ", "") + "/" + strNewQuestion.Replace(" ", "").ToLower() + "/question", strNewQuestion, true);
                        // tao file chua phan sai cua cau hoi
                        ttl.TaoFile(linkAccess + "Question/" + strNameColumn.ToLower().Replace(" ", "") + "/" + strNewQuestion.Replace(" ", "").ToLower() + "/yn");
                        // ghi du lieu vao file chua cau tra loi cua cau hoi
                        ttl.GhiDuLieuVaoFile(linkAccess + "Question/" + strNameColumn.ToLower().Replace(" ", "") + "/" + strNewQuestion.Replace(" ", "").ToLower() + "/yn", "" + yn, true);
                    }
                    catch
                    {
                        // xoa thu muc chua cau hoi
                        Directory.Delete(linkAccess + "Question/" + strNameColumn.ToLower().Replace(" ", ""), true);
                        ttl.HienThiThongBao("LOI~ KY TU", "KY TU TRONG CAU HOI KHONG HOP LE!", 16, b);
                    }
                }
            }

        }
        // percent in table
        public static void PercentInTable(string c, string linkTKB, string nameTable, string b)
        {
            string sNameColumn1 = "";
            string sNameColumn2 = "";
            HelpTTL ttl = new HelpTTL();
            // xoa thu muc
            if (Directory.Exists(linkTKB + nameTable + "/Percent") == true)
                Directory.Delete(linkTKB + nameTable + "/Percent", true);
            // tao thu muc
            ttl.TaoThuMuc(linkTKB + nameTable + "/Percent");
            // ghi ten cot 1 va cot 2
            Console.Write("Column 1> ");
            sNameColumn1 = Console.ReadLine();
            Console.Write("Column 2> ");
            sNameColumn2 = Console.ReadLine();
            // // xoa khoang trong va viet thuong ten cot
            // sNameColumn1 = sNameColumn1.ToLower().Replace(" ","");
            // sNameColumn2 = sNameColumn2.ToLower().Replace(" ","");
            // tao file co ten cot neu no khac rong
            if (sNameColumn1 != "" && sNameColumn2 != "")
            {
                try
                {
                    // tao file
                    ttl.TaoFile(linkTKB + nameTable + "/Percent/Column1.txt");
                    ttl.TaoFile(linkTKB + nameTable + "/Percent/Column2.txt");
                    // ghi du lieu vao file
                    ttl.GhiDuLieuVaoFile(linkTKB + nameTable + "/Percent/Column1.txt", ttl.TraVeSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt", sNameColumn1), true);
                    ttl.GhiDuLieuVaoFile(linkTKB + nameTable + "/Percent/Column2.txt", ttl.TraVeSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt", sNameColumn2), true);
                }
                catch (Exception e)
                {
                    ttl.HienThiThongBao("LOI~ KY TU", e + "", 16, b);
                }
            }
        }
        // true false
        public static void TrueFalse(string c, string linkTKB, string nameTable, string b)
        {
            string sNameColumn1 = "";
            string sNameColumn2 = "";
            HelpTTL ttl = new HelpTTL();
            // xoa thu muc
            if (Directory.Exists(linkTKB + nameTable + "/TrueFalse") == true)
                Directory.Delete(linkTKB + nameTable + "/TrueFalse", true);
            // tao thu muc
            ttl.TaoThuMuc(linkTKB + nameTable + "/TrueFalse");
            // ghi ten cot 1 va cot 2
            Console.Write("Column 1> ");
            sNameColumn1 = Console.ReadLine();
            Console.Write("Column 2> ");
            sNameColumn2 = Console.ReadLine();
            // // xoa khoang trong va viet thuong ten cot
            // sNameColumn1 = sNameColumn1.ToLower().Replace(" ","");
            // sNameColumn2 = sNameColumn2.ToLower().Replace(" ","");
            // tao file co ten cot neu no khac rong
            if (sNameColumn1 != "" && sNameColumn2 != "")
            {
                try
                {
                    // tao file
                    ttl.TaoFile(linkTKB + nameTable + "/TrueFalse/Column1.txt");
                    ttl.TaoFile(linkTKB + nameTable + "/TrueFalse/Column2.txt");
                    // ghi du lieu vao file
                    ttl.GhiDuLieuVaoFile(linkTKB + nameTable + "/TrueFalse/Column1.txt", ttl.TraVeSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt", sNameColumn1), true);
                    ttl.GhiDuLieuVaoFile(linkTKB + nameTable + "/TrueFalse/Column2.txt", ttl.TraVeSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt", sNameColumn2), true);
                }
                catch (Exception e)
                {
                    ttl.HienThiThongBao("LOI~ KY TU", e + "", 16, b);
                }
            }
        }
        // FILE TXT
        public static void FileTXT(string c, string linkTKB){
            // goi lop help ttl
            HelpTTL ttl = new HelpTTL();
            // tao file
            ttl.TaoFile(linkTKB + "File.txt");
            // mo file
            ttl.MoDuongDan(linkTKB + "File.txt");
        }
        // tim thong tin trong cot va ghi du lieu vao cot
        public static void FindDataAndWriteInColumn(string c,string linkTKB, string nameTable){
            // goi tro giup
            HelpTTL ttl = new HelpTTL();
            string sNameColumn1 = "";
            string sNameColumn2 = "";
            string sNewValue = "";
            string sFindValue = "";
            Console.Write("TEN COT CAN TIM DU LIEU: ");
            sNameColumn1 = Console.ReadLine();
            Console.Write("GHI DU LIEU CAN TIM: ");
            sFindValue = Console.ReadLine();
            Console.Write("TEN COT SE GHI DU LIEU: ");
            sNameColumn2 = Console.ReadLine();
            Console.Write("GHI GIA TRI MOI: ");
            sNewValue = Console.ReadLine();
            // lay file trong thu muc
            string[] getFile = Directory.GetFiles(linkTKB + nameTable);
            foreach(string file in getFile){
                // doc du lieu trong file
                // kiem tra du lieu trong file
                if(sFindValue.Replace(" ","").ToLower() == ttl.TraDuLieuSoNDongTrongFile(file,ttl.TraVeSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt",sNameColumn1) + 1) && ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt",sNameColumn2.Replace(" ","").ToLower()) == true){
                    // // du lieu cot 1
                    // Console.Write(ttl.TraDuLieuSoNDongTrongFile(file,ttl.TraVeSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt",sNameColumn1) + 1) + "\t");
                    // // du lieu cot 2
                    // Console.WriteLine(ttl.TraVeSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt",sNameColumn2) + 1);
                    // neu gia tri moi la mot chuoi rong
                    if(sNewValue.Replace(" ","") == "")
                        // chuyen chuoi thanh 1 khoang trong
                        sNewValue = " ";
                    // thay doi du lieu
                    ttl.GhiDuLieuVaoFileOViTriThuN(file,ttl.TraVeSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt",sNameColumn2),sNewValue);
                }
                
            }
        }
        //tinh tong cot theo dong
        public static void GetSumColumnWithLine(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            long numSumColumn = 0;
            long numInFile = 0;
            int numSum = 0;
            long numMax = 0;
            long numMin = 0;
            double numPercent = 0;
            string sDifferent = "";
            int num1 = 0;
            int num2 = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "scwl", "sumcolumnwithline");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    Console.Write("REMOVED> ");
                    sDifferent = Console.ReadLine();
                    Console.Write("LINE1> ");
                    int.TryParse(Console.ReadLine(), out num1);
                    Console.Write("LINE2> ");
                    int.TryParse(Console.ReadLine(), out num2);
                    //kiem tra xem ten bang hien thi co ton tai hay khong
                    string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                    foreach (string linesName in fileNameTable)
                    {
                        numNameTable++;
                        //neu ten bang can kiem tra co ton tai trong bang
                        if (linesName == str)
                        {
                            numShowColumn = numNameTable;
                        }
                    }
                    //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                    if (numShowColumn != 0)
                    {
                        //khoi dong lai bien num name table
                        numNameTable = 0;
                        for (int i = num1; i <= num2; i++)
                        {
                            //neu file line co ton tai
                            if (File.Exists(linkAccess + "line" + i + ".txt") == true)
                            {
                                //hien thi thong tin cua file
                                string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + i + ".txt");
                                foreach (string linesColumn in showFileLineInColumn)
                                {
                                    numInFile = 0;
                                    numRunFileLine++;
                                    //neu dong hien thi o vi tri cot
                                    if (numShowColumn == numRunFileLine)
                                    {
                                        numPercent++;
                                        //chuyen doi so trong file thanh so nguyen
                                        try
                                        {
                                            numInFile = long.Parse(linesColumn);
                                        }
                                        catch
                                        {

                                        }
                                        //tim cac gia tri khac tim thay trong file
                                        if (linesColumn != " " && linesColumn != sDifferent)
                                            numSum++;
                                    }
                                    // tim max
                                    numMax = ttl.TimMax(numInFile, numMax);
                                    // tim min
                                    numMin = ttl.TimMin(numInFile, numMin);
                                    //neu so trong file khac 0, bat dau tinh tong
                                    //neu so trong file khac 0, bat dau tinh tong
                                    if (numInFile != 0)
                                        numSumColumn = numInFile + numSumColumn;
                                }
                                numRunFileLine = 0;
                            }
                            numNameTable++;
                        }
                        //hien thi tong trong cot
                        Console.WriteLine(string.Format("SUM COLUMN [{0}]: {1:0,0} - GTTT: {2} - PERCENT: {3:0.00}% - MAX: {4:0,0} - MIN: {5:0,0}", str, numSumColumn, numSum, numSum * 100 / numPercent, numMax, numMin));
                        Console.ReadKey();
                    }
                }
            }
        }
        //tinh tong dong
        public static void GetSumLine(string c, string linkTKB, string nameTable)
        {
            string str = "";
            long numSumLine = 0;
            long numLine = 0;
            double numSum = 0;
            string sDifferent = "";
            double numPercent = 0;
            long numMax = 0;
            long numMin = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "gsl", "getsumline");
                //neu str khac rong
                if (str.Replace(" ", "") != "")
                {
                    //kiem tra file can lay du lieu co ton tai
                    if (File.Exists(linkTKB + "/" + nameTable + "/line" + str + ".txt") == true)
                    {
                        Console.Write("REMOVED>");
                        sDifferent = Console.ReadLine();
                        //doc cac dong trong file
                        string[] fileLineSum = File.ReadAllLines(linkTKB + "/" + nameTable + "/line" + str + ".txt");
                        foreach (string lines in fileLineSum)
                        {
                            numLine = 0;
                            numPercent++;
                            try
                            {
                                numLine = long.Parse(lines);
                            }
                            catch
                            {

                            }
                            //tinh gia tri tim thay trong dong
                            if (lines != " " && lines != sDifferent)
                                numSum++;
                            //neu num line khac 0
                            if (numLine != 0)
                            {
                                //tinh tong
                                numSumLine = numLine + numSumLine;
                            }
                            // tim max
                            numMax = ttl.TimMax(numLine, numMax);
                            //tim min
                            numMin = ttl.TimMin(numLine, numMin);
                        }
                        //hien thi ket qua
                        Console.WriteLine(string.Format("SUM COLUMN [{0}]: {1:0,0} - GTTT: {2} - PERCENT: {3:0.00}% - MAX: {4:0,0} - MIN: {5:0,0}", str, numSumLine, numSum, numSum * 100 / numPercent, numMax, numMin));
                        Console.ReadKey();
                    }
                }
            }
        }
        //thay doi thong tin trong bang co dong chi dinh
        public static void ChangeInformationInColumn(string c, string linkTKB, string nameTable, int numLine1, int numline2, string b)
        {
            int num = 0;
            int num1 = 0;
            int line = 0;
            bool xacNhan = false;
            bool xacNhanTenCot = false;
            string newData = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool bTF = false;
            double dOldData = 0;
            double dNewData = 0;
            double dStr = 0;
            string str = "";
            int run = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                HelpTTL ttl = new HelpTTL();
                // tao thu muc tien doan
                ttl.TaoThuMuc(b + "FLARES");

                //doc du lieu trong file bao ve cot
                xacNhan = ttl.KiemTraDuLieuTrongFile(linkAccess + "ProtectColumn/ProtectColumn", c);
                xacNhanTenCot = ttl.KiemTraDuLieuTrongFile(linkAccess + "/Name/name.txt", c);
                //so sanh du lieu nhap vao voi file ten cua bang
                if (xacNhanTenCot == true && xacNhan == false)
                {
                    //doc dulieu trong file de so sanh du lieu nhap vao
                    string[] fileName = File.ReadAllLines(linkAccess + "/Name/name.txt");
                    foreach (string lines in fileName)
                    {
                        num++;
                        //neu du lieu nhap vao trung voi ten bang
                        if (c == lines)
                        {
                            //ghi so dong can thay doi du lieu
                            Console.Write("LINE> ");
                            int.TryParse(Console.ReadLine(), out line);
                            // neu thu muc chua so dong can hien thi dang ton tai
                            if (Directory.Exists(linkTKB + "/" + nameTable + "/SetLineShow") == true)
                            {
                                // neu dong can them du lieu < num2 va > num1
                                if (line <= numline2 && line >= numLine1)
                                {
                                    //lay du lieu cac file line trong bang
                                    string[] fileLines = Directory.GetFiles(linkAccess);
                                    foreach (string files in fileLines)
                                    {
                                        //neu file nguoi dung chon co ton tai
                                        if (File.Exists(linkAccess + "line" + line + ".txt") == true)
                                        {
                                            //tao file moi
                                            FileStream fileNew = new FileStream(linkAccess + "line" + line + ".txt" + line, FileMode.Create);
                                            fileNew.Close();
                                            //ghi du lieu tu file cu vao file moi
                                            TextWriter textFile = new StreamWriter(linkAccess + "line" + line + ".txt" + line, true);
                                            try
                                            {
                                                //doc cac dong trong file line do nguoi dung chi dinh
                                                string[] fileLine = File.ReadAllLines(linkAccess + "line" + line + ".txt");
                                                foreach (string lines1 in fileLine)
                                                {
                                                    num1++;
                                                    //neu du dong hien tai khac voi dong can sua trong file
                                                    if (num1 != num)
                                                    {
                                                        textFile.WriteLine(lines1);
                                                    }
                                                    //neu dong hien tai trung voi dong can sua trong file
                                                    if (num1 == num)
                                                    {
                                                        Console.Write("NEW DATA ({0})>", lines1);
                                                        //ghi du lieu moi vao file
                                                        newData = Console.ReadLine();
                                                        // su dung bien so run de tim phep tinh nguoi dung yeu cau
                                                        if (run == 0)
                                                        {
                                                            str = ttl.Loc1KyTu(newData, "+");
                                                            if (str.Replace(" ", "") != "")
                                                                run = 1;
                                                        }
                                                        if (run == 0)
                                                        {
                                                            str = ttl.Loc1KyTu(newData, "-");
                                                            if (str.Replace(" ", "") != "")
                                                                run = 2;
                                                        }
                                                        if (run == 0)
                                                        {
                                                            str = ttl.Loc1KyTu(newData, "*");
                                                            if (str.Replace(" ", "") != "")
                                                                run = 3;
                                                        }
                                                        if (run == 0)
                                                        {
                                                            str = ttl.Loc1KyTu(newData, "/");
                                                            if (str.Replace(" ", "") != "")
                                                                run = 4;
                                                        }
                                                        if (str != "")
                                                        {
                                                            try
                                                            {
                                                                dOldData = double.Parse(lines1);
                                                            }
                                                            catch { }
                                                        }
                                                        // neu du lieu moi khong yeu cau tu file.txt
                                                        if(newData != "file.txt" && newData.Replace(" ","") != "getvalue" && newData != "date?"){
                                                            // neu du lieu cu~ != 0
                                                            if (dOldData != 0)
                                                            {
                                                                dStr = double.Parse(str);
                                                                if (run == 1)
                                                                    dNewData = dOldData + dStr;
                                                                if (run == 2)
                                                                    dNewData = dOldData - dStr;
                                                                if (run == 3)
                                                                    dNewData = dOldData * dStr;
                                                                if (run == 4)
                                                                    dNewData = dOldData / dStr;
                                                                // ghi du lieu vao file
                                                                textFile.WriteLine("{0:0,0}", dNewData);
                                                            }
                                                            // neu du lieu cu~ == 0
                                                            if (dOldData == 0)
                                                            {
                                                                // truy van du lieu truoc khi nhap thong tin vao cot
                                                                bTF = ttl.TruyVanTable(linkAccess + "/Question/" + c, newData);
                                                                //neu du lieu moi la khoang trong
                                                                if (newData == "")
                                                                    newData = " ";
                                                                // nhap du lieu neu truy van = true
                                                                if (bTF == false)
                                                                    newData = lines1;
                                                                // loc ky tu html
                                                                textFile.WriteLine(ttl.LocKyTuVsTheHtml(newData));
                                                            }
                                                        }
                                                        // ghi du lieu tu file.txt
                                                        if(newData == "file.txt")
                                                            textFile.WriteLine(ttl.LayDuLieuTrongFileStr(linkTKB + "/File.txt"));
                                                        // tai du lieu cua dong vao file.txt
                                                        if(newData.Replace(" ","") == "getvalue"){
                                                            // ghi lai du lieu cu~
                                                            textFile.WriteLine(lines1);
                                                            // ghi du lieu vao file txt
                                                            ttl.GhiDuLieuVaoFile(linkTKB + "/File.txt",lines1,true);
                                                            // mo file txt
                                                            ttl.MoDuongDan(linkTKB + "/File.txt");
                                                        }
                                                        // Date now
                                                        if(newData == "date?")
                                                            textFile.WriteLine(DateTime.Now + " " + DateTime.Now.DayOfWeek);
                                                        
                                                        //  gui thong bao cho nguoi dung
                                                        if(File.Exists(b +"FLARES/" + newData.ToLower().Replace(" ","")) == true){
                                                            
                                                            ttl.MoDuongDan(b +"FLARES/" + newData.ToLower().Replace(" ",""));
                            
                                                        }

                                                    }
                                                }
                                                textFile.Close();
                                                //xoa file cu
                                                File.Delete(linkAccess + "line" + line + ".txt");
                                                //chuyen file moi thanh file cu
                                                File.Move(linkAccess + "line" + line + ".txt" + line, linkAccess + "line" + line + ".txt");
                                                break;
                                            }
                                            catch
                                            {
                                                // don du lieu dang mo
                                                textFile.Close();
                                                // thong bao cho nguoi dung
                                                ttl.HienThiThongBao("KHONG TIM THAY DU LIEU CAN XU LY!", "DU LIEU SAI DINH DANG!", 16, b);
                                            }
                                        }
                                    }
                                }
                                // bao loi neu nguoi dung nhap sai
                                if (line > numline2 || line < numLine1)
                                    ttl.HienThiThongBao("TABLE!", "CHE DO HIEN THI CHI HO TRO TU DONG " + numLine1 + " > " + numline2 + ".", 16, b);
                            }
                            // neu thu muc chua dong can hien thi khong ton tai
                            if (Directory.Exists(linkTKB + "/" + nameTable + "/SetLineShow") == false)
                            {
                                //lay du lieu cac file line trong bang
                                string[] fileLines = Directory.GetFiles(linkAccess);
                                foreach (string files in fileLines)
                                {
                                    //neu file nguoi dung chon co ton tai
                                    if (File.Exists(linkAccess + "line" + line + ".txt") == true)
                                    {
                                        //tao file moi
                                        FileStream fileNew = new FileStream(linkAccess + "line" + line + ".txt" + line, FileMode.Create);
                                        fileNew.Close();
                                        //ghi du lieu tu file cu vao file moi
                                        TextWriter textFile = new StreamWriter(linkAccess + "line" + line + ".txt" + line, true);
                                        try
                                        {
                                            //doc cac dong trong file line do nguoi dung chi dinh
                                            string[] fileLine = File.ReadAllLines(linkAccess + "line" + line + ".txt");
                                            foreach (string lines1 in fileLine)
                                            {
                                                num1++;
                                                //neu du dong hien tai khac voi dong can sua trong file
                                                if (num1 != num)
                                                {
                                                    textFile.WriteLine(lines1);
                                                }
                                                //neu dong hien tai trung voi dong can sua trong file
                                                if (num1 == num)
                                                {
                                                    Console.Write("NEW DATA ({0})>", lines1);
                                                    //ghi du lieu moi vao file
                                                    newData = Console.ReadLine();
                                                    // su dung bien so run de tim phep tinh nguoi dung yeu cau
                                                    if (run == 0)
                                                    {
                                                        str = ttl.Loc1KyTu(newData, "+");
                                                        if (str.Replace(" ", "") != "")
                                                            run = 1;
                                                    }
                                                    if (run == 0)
                                                    {
                                                        str = ttl.Loc1KyTu(newData, "-");
                                                        if (str.Replace(" ", "") != "")
                                                            run = 2;
                                                    }
                                                    if (run == 0)
                                                    {
                                                        str = ttl.Loc1KyTu(newData, "*");
                                                        if (str.Replace(" ", "") != "")
                                                            run = 3;
                                                    }
                                                    if (run == 0)
                                                    {
                                                        str = ttl.Loc1KyTu(newData, "/");
                                                        if (str.Replace(" ", "") != "")
                                                            run = 4;
                                                    }
                                                    if (str != "")
                                                    {
                                                        try
                                                        {
                                                            dOldData = double.Parse(lines1);
                                                        }
                                                        catch { }
                                                    }
                                                    // neu du lieu moi khong yeu cau tu file.txt
                                                    if(newData != "file.txt" && newData.Replace(" ","") != "getvalue" && newData != "date?"){
                                                        // neu du lieu cu~ != 0
                                                        if (dOldData != 0)
                                                        {
                                                            dStr = double.Parse(str);
                                                            if (run == 1)
                                                                dNewData = dOldData + dStr;
                                                            if (run == 2)
                                                                dNewData = dOldData - dStr;
                                                            if (run == 3)
                                                                dNewData = dOldData * dStr;
                                                            if (run == 4)
                                                                dNewData = dOldData / dStr;
                                                            // ghi du lieu vao file
                                                            textFile.WriteLine("{0:0,0}", dNewData);
                                                        }
                                                        // neu du lieu cu~ == 0
                                                        if (dOldData == 0)
                                                        {
                                                            // truy van du lieu truoc khi nhap thong tin vao cot
                                                            bTF = ttl.TruyVanTable(linkAccess + "/Question/" + c, newData);
                                                            //neu du lieu moi la khoang trong
                                                            if (newData == "")
                                                                newData = " ";
                                                            // nhap du lieu neu truy van = true
                                                            if (bTF == false)
                                                                newData = lines1;
                                                            // loc ky tu vs html
                                                            textFile.WriteLine(ttl.LocKyTuVsTheHtml(newData));
                                                        }
                                                    }
                                                    // ghi du lieu tu file.txt
                                                    if(newData == "file.txt")
                                                        textFile.WriteLine(ttl.LayDuLieuTrongFileStr(linkTKB + "/File.txt"));
                                                    // tai du lieu cua dong vao file.txt
                                                    if(newData.Replace(" ","") == "getvalue"){
                                                        // ghi lai du lieu cu~
                                                        textFile.WriteLine(lines1);
                                                        // ghi du lieu vao file txt
                                                        ttl.GhiDuLieuVaoFile(linkTKB + "/File.txt",lines1,true);
                                                        // mo file txt
                                                        ttl.MoDuongDan(linkTKB + "/File.txt");
                                                    }
                                                    // Date now
                                                    if(newData == "date?")
                                                        textFile.WriteLine(DateTime.Now + " " + DateTime.Now.DayOfWeek);
                                                    
                                                    //  gui thong bao cho nguoi dung
                                                    if(File.Exists(b +"FLARES/" + newData.ToLower().Replace(" ","")) == true){
                                                            
                                                        ttl.MoDuongDan(b +"FLARES/" + newData.ToLower().Replace(" ",""));
                        
                                                    }
                                                }
                                            }
                                            textFile.Close();
                                            //xoa file cu
                                            File.Delete(linkAccess + "line" + line + ".txt");
                                            //chuyen file moi thanh file cu
                                            File.Move(linkAccess + "line" + line + ".txt" + line, linkAccess + "line" + line + ".txt");
                                            break;
                                        }
                                        catch
                                        {
                                            // don du lieu dang mo
                                            textFile.Close();
                                            // thong bao cho nguoi dung
                                            ttl.HienThiThongBao("KHONG TIM THAY DU LIEU CAN XU LY!", "DU LIEU SAI DINH DANG!", 16, b);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        //pin tables
        public static void PinTables(string c, string linkTKB, string nameTable)
        {
            string str = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                //neu thu muc chu pin chu trong bang chua ton tai
                if (Directory.Exists(linkAccess + "Pin") == false)
                {
                    //tao thu muc moi
                    DirectoryInfo newFolder = new DirectoryInfo(linkAccess + "Pin");
                    newFolder.Create();
                }
                //neu file pin du lieu chua ton tai
                if (File.Exists(linkAccess + "Pin/Pin") == false)
                {
                    //tao file chua cac dong pin
                    FileStream fileNew = new FileStream(linkAccess + "Pin/Pin", FileMode.Create);
                    fileNew.Close();
                }
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "pin");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    //ghi du lieu vao file pin
                    TextWriter textFilePin = new StreamWriter(linkAccess + "Pin/Pin", true);
                    textFilePin.WriteLine(str);
                    textFilePin.Close();
                }
                //xoa cac thong tin trong file pin
                if (str.Replace(" ", "") == "deleteall")
                {
                    TextWriter textFP = new StreamWriter(linkAccess + "Pin/Pin");
                    textFP.Close();
                }
            }
        }
        //xoa du lieu trong file pin
        public static void DeletePinTables(string c, string linkTKB, string nameTable)
        {
            string str = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "" && nameTable != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc2KyTu(c, "dp", "deletepintable");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    //neu file pin 1 da ton tai tien hanh xoa file
                    if (File.Exists(linkAccess + "Pin/Pin1") == true)
                        File.Delete(linkAccess + "Pin/Pin1");
                    //tao file moi
                    FileStream fileNew = new FileStream(linkAccess + "Pin/Pin1", FileMode.Create);
                    fileNew.Close();
                    TextWriter textPin = new StreamWriter(linkAccess + "Pin/Pin1", true);
                    //doc file cu
                    string[] filePin = File.ReadAllLines(linkAccess + "Pin/Pin");
                    foreach (string linesPin in filePin)
                    {
                        //ghi du lieu vao file moi neu dong trong file khac voi dong can xoa
                        if (linesPin != str)
                            textPin.WriteLine(linesPin);
                    }
                    textPin.Close();
                    //xoa file cu
                    File.Delete(linkAccess + "Pin/Pin");
                    //chuyen file moi thanh file ban dau
                    File.Move(linkAccess + "Pin/Pin1", linkAccess + "Pin/Pin");
                }
            }
        }
        // thêm ký tự giống nhau cho nhiều cột
        public static void AllColumn(string c, string linkTKB, string nameTable)
        {
            int line = 0;
            string newString = "";
            int num = 0;
            //neu duong dan khac rong
            if (c.ToLower().Replace(" ", "").Contains("allcolumn") == true)
            {
                // doc du lieu trong file ten bang
                string[] lineNameTable = File.ReadAllLines(linkTKB + "/" + nameTable + "/Name/name.txt");
                foreach (string lines in lineNameTable)
                    num++;
                // do{
                Console.Write("Line>");
                // }while(!int.TryParse(Console.ReadLine(), out line));
                int.TryParse(Console.ReadLine(), out line);
                // nếu dòng người dùng cần ghi có trong hệ thống
                if (File.Exists(linkTKB + "/" + nameTable + "/line" + line + ".txt") == true)
                {
                    // ghi dữ liệu mới vào file với 1 ký tự
                    Console.Write("Write Content>>");
                    newString = Console.ReadLine();
                    if (newString != "")
                    {
                        // xóa dữ liệu file cũ
                        FileStream fileNew = new FileStream(linkTKB + "/" + nameTable + "/line" + line + ".txt", FileMode.Create);
                        fileNew.Close();
                        TextWriter ttlile = new StreamWriter(linkTKB + "/" + nameTable + "/line" + line + ".txt", true);
                        for (int i = 0; i < num; i++)
                        {
                            ttlile.WriteLine(newString);
                        }
                        ttlile.Close();
                    }
                }
            }
        }
        // thay doi noi dung trong cot
        public static void AllLineInColumnReplace(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            string removed = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            bool tF1 = false;
            string sRp1,sRp2 = "";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                 // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c,"alllineincolumn(replace)>");
                //neu ten bang can xoa co ton tai
                if(str.Replace(" ","") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn",str);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt",str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if(tF == false && tF1 == true){
                        Console.Write("REMOVED>");
                        removed = Console.ReadLine();
                        Console.Write("Replace>>");
                        sRp1 = Console.ReadLine();
                        Console.Write(sRp1 + " >> ");
                        sRp2 = Console.ReadLine();
                        //kiem tra xem ten bang hien thi co ton tai hay khong
                        string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                        foreach(string linesName in fileNameTable)
                        {
                            numNameTable++;
                            //neu ten bang can kiem tra co ton tai trong bang
                            if(linesName == str)
                            {
                                numShowColumn = numNameTable;
                            }
                        }
                        //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                        if(numShowColumn != 0)
                        {
                            //khoi dong lai bien num name table
                            numNameTable = 0;
                            //lay cac file line co trong bang
                            string[] folderTable = Directory.GetFiles(linkAccess);
                            foreach(string files in folderTable)
                            {                       
                                //neu file line co ton tai
                                if(File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                                {
                                    // tao file ao?
                                    ttl.TaoFile(linkAccess + "line" + numNameTable + "txt.txt");
                                    // ghi du lieu vao file ao?
                                    TextWriter txF = new StreamWriter(linkAccess + "line" + numNameTable + "txt.txt",true);
                                    //hien thi thong tin cua file
                                    string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                    foreach(string linesColumn in showFileLineInColumn)
                                    {
                                        // ghi du lieu vao file
                                        numRunFileLine++;
                                        //neu dong hien thi khac vi tri cot
                                        if(numShowColumn != numRunFileLine)
                                            txF.WriteLine(linesColumn);
                                        //neu dong hien thi o vi tri cot
                                        if(numShowColumn == numRunFileLine)
                                        {
                                            // thuc hien replace
                                            if(removed.Replace(" ","") != linesColumn.Replace(" ",""))
                                                txF.WriteLine(linesColumn.Replace(sRp1,sRp2));
                                            // ghi lai dong cu
                                            if(removed.Replace(" ","") == linesColumn.Replace(" ",""))
                                                txF.WriteLine(linesColumn);
                                        }
                                    }
                                    numRunFileLine = 0;
                                    txF.Close();
                                    // xoa file cu~
                                    File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                    // doi file ao thanh file cu~
                                    File.Move(linkAccess + "line" + numNameTable + "txt.txt",linkAccess + "line" + numNameTable + ".txt");
                                    // xoa file ao?
                                    File.Delete(linkAccess + "line" + numNameTable + "txt.txt");
                                }
                                numNameTable++;
                            }
                        }
                    }
                }
            }
        }
        // thêm 1 noi dung cho 1 cot
        public static void AllLineInColumn(string c, string linkTKB, string nameTable)
        {
            string str1 = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            string strNewline = "";
            string removed = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            bool tF1 = false;
            double dOldData = 0;
            double dNewData = 0;
            double dStr = 0;
            string str = "";
            int run = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str1 = ttl.Loc1KyTu(c, "alllineincolumn");
                //neu ten bang can xoa co ton tai
                if (str1.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str1);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt", str1);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false && tF1 == true)
                    {
                        Console.Write("REMOVED>");
                        removed = Console.ReadLine();
                        Console.Write("Write Content>>");
                        strNewline = Console.ReadLine();
                        //kiem tra xem ten bang hien thi co ton tai hay khong
                        string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                        foreach (string linesName in fileNameTable)
                        {
                            numNameTable++;
                            //neu ten bang can kiem tra co ton tai trong bang
                            if (linesName == str1)
                            {
                                numShowColumn = numNameTable;
                            }
                        }
                        //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                        if (numShowColumn != 0)
                        {
                            //khoi dong lai bien num name table
                            numNameTable = 0;
                            //lay cac file line co trong bang
                            string[] folderTable = Directory.GetFiles(linkAccess);
                            foreach (string files in folderTable)
                            {
                                //neu file line co ton tai
                                if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                                {
                                    // tao file ao?
                                    ttl.TaoFile(linkAccess + "line" + numNameTable + "txt.txt");
                                    // ghi du lieu vao file ao?
                                    TextWriter txF = new StreamWriter(linkAccess + "line" + numNameTable + "txt.txt", true);
                                    //hien thi thong tin cua file
                                    string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                    foreach (string linesColumn in showFileLineInColumn)
                                    {
                                        // su dung bien so run de tim phep tinh nguoi dung yeu cau
                                        if (run == 0)
                                        {
                                            str = ttl.Loc1KyTu(strNewline, "+");
                                            if (str.Replace(" ", "") != "")
                                                run = 1;
                                        }
                                        if (run == 0)
                                        {
                                            str = ttl.Loc1KyTu(strNewline, "-");
                                            if (str.Replace(" ", "") != "")
                                                run = 2;
                                        }
                                        if (run == 0)
                                        {
                                            str = ttl.Loc1KyTu(strNewline, "*");
                                            if (str.Replace(" ", "") != "")
                                                run = 3;
                                        }
                                        if (run == 0)
                                        {
                                            str = ttl.Loc1KyTu(strNewline, "/");
                                            if (str.Replace(" ", "") != "")
                                                run = 4;
                                        }
                                        if (str != "")
                                        {
                                            try
                                            {
                                                dOldData = double.Parse(linesColumn);
                                            }
                                            catch { }
                                        }
                                        // neu du lieu cu~ != 0
                                        if (dOldData != 0)
                                        {
                                            dStr = double.Parse(str);
                                            if (run == 1)
                                                dNewData = dOldData + dStr;
                                            if (run == 2)
                                                dNewData = dOldData - dStr;
                                            if (run == 3)
                                                dNewData = dOldData * dStr;
                                            if (run == 4)
                                                dNewData = dOldData / dStr;
                                            // ghi du lieu vao file
                                            // textFile.WriteLine("{0:0,0}",dNewData);
                                        }
                                        // ghi du lieu vao file
                                        numRunFileLine++;
                                        //neu dong hien thi khac vi tri cot
                                        if (numShowColumn != numRunFileLine)
                                            txF.WriteLine(linesColumn);
                                        //neu dong hien thi o vi tri cot
                                        if (numShowColumn == numRunFileLine)
                                        {
                                            if (removed.Replace(" ", "") != linesColumn.Replace(" ", ""))
                                            {
                                                // neu du lieu ghi vao file khac rong~
                                                if (strNewline.Replace(" ", "") != "")
                                                    if (dOldData == 0)
                                                        txF.WriteLine(strNewline);
                                                if (dOldData != 0)
                                                    txF.WriteLine("{0:0,0}", dNewData);
                                                // neu du lieu ghi vao file = rong~
                                                if (strNewline.Replace(" ", "") == "")
                                                    txF.WriteLine(" ");
                                            }
                                            if (removed.Replace(" ", "") == linesColumn.Replace(" ", ""))
                                            {
                                                txF.WriteLine(linesColumn);

                                            }
                                        }
                                    }
                                    numRunFileLine = 0;
                                    txF.Close();
                                    // xoa file cu~
                                    File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                    // doi file ao thanh file cu~
                                    File.Move(linkAccess + "line" + numNameTable + "txt.txt", linkAccess + "line" + numNameTable + ".txt");
                                    // xoa file ao?
                                    File.Delete(linkAccess + "line" + numNameTable + "txt.txt");
                                }
                                numNameTable++;
                            }
                        }
                    }
                }
            }
        }


        // goi duong dan va them gia tri cho cot
        // gia tri them vao +1
        public static void CallAndChangeValueInColumn(string c, string linkTKB, string nameTable, string b)
        {
            string str = "";
            string linkFile = "";
            string strLink = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            bool tF1 = false;
            double nD = 0.0f;
            int numChange = 0;
            int num = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "calllinkanduploadvalueincolumn>");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false && tF1 == true)
                    {
                        Console.Write("LINK>>");
                        strLink = Console.ReadLine();
                        if (strLink.Replace(" ", "") != "")
                        {
                            // tim file
                            linkFile = ttl.TimFile(linkAccess, strLink);
                            // tao file ao?
                            ttl.TaoFile(linkFile + ".txt");
                            // ghi du lieu vao file ao?
                            TextWriter txF = new StreamWriter(linkFile + ".txt");
                            // tim vi tri dong can thay doi
                            numChange = ttl.TraVeSoDongTrongFile(linkAccess + "/Name/name.txt", str);
                            // doc du lieu trong file
                            string[] rF = File.ReadAllLines(linkFile);
                            foreach (string lines in rF)
                            {
                                if (num == numChange)
                                {
                                    try
                                    {
                                        nD = double.Parse(lines);
                                        // them +1 vao gia tri can chuyen doi
                                        txF.WriteLine(nD + 1);
                                    }
                                    catch
                                    {
                                        // tra ve du lieu nguyen thuy neu du lieu chuyen doi bi loi
                                        txF.WriteLine(lines);
                                    }
                                }
                                if (num != numChange)
                                    txF.WriteLine(lines);
                                num++;
                            }
                            txF.Close();
                            // xoa file cu~
                            File.Delete(linkFile);
                            // doi file ao thanh file cu~
                            File.Move(linkFile + ".txt", linkFile);
                            // xoa file ao?
                            File.Delete(linkFile + ".txt");
                            // mo duong dan
                            ttl.MoDuongDan(strLink);
                        }
                    }
                }
            }
        }
        // tim kiem va tra du lieu ve dang js
        public static void FindValueWithJS(string c, string linkTKB, string nameTable)
        {
            string nameTableJS = linkTKB + "/TableJS/";
            string strTableJS =  linkTKB + "/TableJS/Table.js";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            string str = "";
            string[] arrName;
            HelpTTL ttl = new HelpTTL();
            int numSD = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                str = ttl.Loc1KyTu(c, "find");
                // 
                ttl.TaoThuMuc(nameTableJS);
                ttl.TaoFile(strTableJS);
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // 
                    if(Directory.Exists(linkTKB + nameTable) == true && Directory.Exists(nameTableJS) == true){
                        // doc so dong trong file
                        if(File.Exists(linkTKB + nameTable + "/Name/name.txt") == true){
                            numSD = ttl.DemSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt");
                            // khoi tao so phan tu trong mang
                            arrName = new string[numSD];
                            // 
                            for(int i = 0;i < arrName.Length;i++){
                                arrName[i] = ttl.DocFileVSSoDong(linkTKB + nameTable + "/Name/name.txt",i);
                                // Console.WriteLine(arrName[i]);
                            }
                            // Console.WriteLine(arrName.Length);
                            // ghi file table js
                            ttl.GhiDuLieuVaoFile(strTableJS,"const techBrands=[\n",false);
                            // lay danh sach file trong thu muc
                            string[] getFile = Directory.GetFiles(linkTKB + nameTable);
                            foreach(string file in getFile){
                                // dung de ghi dong nao co chua thong tin can tim
                                if(ttl.DocFileRTF(file,str) == true)
                                    ttl.GhiDuLieuVaoFile(strTableJS,"{\n",true);
                                // 
                                for(int i = 0;i < arrName.Length;i++){
                                    // loc du lieu chi lay du lieu can tim
                                    if(ttl.DocFileRTF(file,str) == true)
                                        ttl.GhiDuLieuVaoFile(strTableJS, arrName[i] + ":\"" + ttl.DocFileVSSoDong(file,i) + "\"," ,true);
                                }
                                // dung de ghi dong nao co chua thong tin can tim
                                if(ttl.DocFileRTF(file,str) == true)
                                    ttl.GhiDuLieuVaoFile(strTableJS,"\n},\n",true);
                            
                                // Console.WriteLine(file);
                            }
                            ttl.GhiDuLieuVaoFile(strTableJS,"\n]\nconsole.table(techBrands);",true);
                        
                            }


                            ttl.MoDuongDan(nameTableJS + "opentable.bat");
                            // Console.ReadKey();
                        
                    }
                }
            }
        }
        // tao bang moi dua vao du lieu tim thay trong dong
        public static void NewTableWithDataInLine(string c, string linkTKB, string nameTable, string b)
        {
            string str = "";
            int numNameTable = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            string strNewTable = "";
            int numNewLine = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "newtablewithdata=");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    Console.Write("NAME TABLE>");
                    strNewTable = Console.ReadLine();
                    strNewTable = strNewTable.ToLower().Replace(" ", "");
                    if (strNewTable != "")
                    {
                        // neu ten bang da ton tai hien thi thong bao
                        if (Directory.Exists(linkTKB + "/" + strNewTable) == true)
                            ttl.HienThiThongBao("Table!", "TEN BANG DA TON TAI!", 16, b);
                        // kiem tra ten table da ton tai trong thu muc chua
                        if (Directory.Exists(linkTKB + "/" + strNewTable) == false)
                        {
                            // copy thu muc table cu~ qua table moi
                            string[] gD = Directory.GetDirectories(linkAccess);
                            foreach (string d in gD)
                            {
                                // copy thu muc
                                DirectoryInfo d1 = new DirectoryInfo(d);
                                ttl.DirectoryCopy(d, linkTKB + "/" + strNewTable + "/" + d1.Name);
                                // copy file name
                                if (File.Exists(linkTKB + "/" + strNewTable + "/Name/name.txt") == false)
                                    File.Copy(linkAccess + "/Name/name.txt", linkTKB + "/" + strNewTable + "/Name/name.txt");
                            }
                            //khoi dong lai bien num name table
                            numNameTable = 0;
                            //lay cac file line co trong bang
                            string[] folderTable = Directory.GetFiles(linkAccess);
                            foreach (string files in folderTable)
                            {
                                //neu file line co ton tai
                                if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                                {
                                    // doc du lieu trong file de so sanh vs du lieu can copy
                                    string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                    foreach (string linesColumn in showFileLineInColumn)
                                    {
                                        // neu 2 du lieu bang nhau tien hanh copy file
                                        if (str == linesColumn.Replace(" ", "").ToLower())
                                        {
                                            numNewLine++;
                                            File.Copy(linkAccess + "line" + numNameTable + ".txt", linkTKB + "/" + strNewTable + "/line" + numNewLine + ".txt");
                                        }
                                    }
                                }
                                numNameTable++;
                            }
                        }
                    }

                }
            }
        }
        // xoa du lieu tuong ung vs so dong
        public static void DeleteLineWithData(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numFileName = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "deletelinewithdata=");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    //khoi dong lai bien num name table
                    numNameTable = 0;
                    // lay du lieu trong file name
                    numFileName = ttl.DemKyTuTrongFile(linkAccess + "/Name/name.txt");
                    //lay cac file line co trong bang
                    string[] folderTable = Directory.GetFiles(linkAccess);
                    foreach (string files in folderTable)
                    {
                        //neu file line co ton tai
                        if (File.Exists(linkAccess + "line" + numNameTable + ".txt"))
                        {
                            //hien thi thong tin cua file
                            string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                            foreach (string linesColumn in showFileLineInColumn)
                            {
                                // neu du lieu trong dong bang du lieu can xoa
                                if (linesColumn.Replace(" ", "").ToLower() == str.Replace(" ", "").ToLower())
                                {
                                    // xoa file
                                    FileStream fN = new FileStream(linkAccess + "line" + numNameTable + ".txt", FileMode.Create);
                                    fN.Close();
                                    // ghi du lieu vao file
                                    for (int i = 0; i < numFileName; i++)
                                    {
                                        ttl.GhiDuLieuVaoFile(linkAccess + "line" + numNameTable + ".txt", " ", false);
                                    }
                                }
                            }
                        }
                        numNameTable++;
                    }
                }
            }
        }
        // thay doi vi tri dong dua vao so cot theo thu tu giam dan
        public static void SXColumnGD(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            int numRunFileLine1 = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            bool tF1 = false;
            double numSS1 = 0;
            double numSS2 = 0;
            int numRun = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "sxcolumn<");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false && tF1 == true)
                    {
                        //kiem tra xem ten bang hien thi co ton tai hay khong
                        string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                        foreach (string linesName in fileNameTable)
                        {
                            numNameTable++;
                            //neu ten bang can kiem tra co ton tai trong bang
                            if (linesName == str)
                            {
                                numShowColumn = numNameTable;
                            }
                        }
                        //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                        if (numShowColumn != 0)
                        {
                            // dem so file co trong thu muc de chay n lan phep tinh
                            numRun = ttl.DemFileTrongThuMuc(linkAccess);
                            for (int i = 0; i < numRun; i++)
                            {
                                //khoi dong lai bien num name table
                                numNameTable = 0;
                                //lay cac file line co trong bang
                                string[] folderTable = Directory.GetFiles(linkAccess);
                                foreach (string files in folderTable)
                                {
                                    //neu file line co ton tai
                                    if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                                    {
                                        //hien thi thong tin cua file
                                        string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                        foreach (string linesColumn in showFileLineInColumn)
                                        {
                                            numRunFileLine++;
                                            if (numShowColumn == numRunFileLine)
                                            {
                                                try
                                                {
                                                    numSS1 = double.Parse(linesColumn);
                                                }
                                                catch { }
                                            }
                                        }
                                        if (numSS1 != 0)
                                        {
                                            numNameTable = numNameTable + 1;
                                            //neu file line co ton tai
                                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                                            {
                                                string[] showFileLineInColumn1 = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                                foreach (string linesColumn1 in showFileLineInColumn1)
                                                {
                                                    numRunFileLine1++;
                                                    if (numShowColumn == numRunFileLine1)
                                                    {
                                                        try
                                                        {
                                                            numSS2 = double.Parse(linesColumn1);
                                                        }
                                                        catch { }
                                                    }
                                                }
                                            }
                                            // tra bien numnametable ve vi tri ban dau
                                            numNameTable = numNameTable - 1;
                                        }
                                        numRunFileLine = 0;
                                        numRunFileLine1 = 0;
                                        // doi cho file
                                        if (numSS2 > numSS1)
                                            ttl.ChuyenCho2File(linkAccess + "line" + numNameTable + ".txt", linkAccess + "line" + (numNameTable + 1) + ".txt");
                                    }
                                    numNameTable++;
                                }
                            }
                        }
                    }
                }
            }
        }
        // thay doi vi tri dong dua vao so cot theo thu tu tang dan
        public static void SXColumnTD(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            int numRunFileLine1 = 0;
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            bool tF1 = false;
            double numSS1 = 0;
            double numSS2 = 0;
            int numRun = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "sxcolumn>");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false && tF1 == true)
                    {
                        //kiem tra xem ten bang hien thi co ton tai hay khong
                        string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                        foreach (string linesName in fileNameTable)
                        {
                            numNameTable++;
                            //neu ten bang can kiem tra co ton tai trong bang
                            if (linesName == str)
                            {
                                numShowColumn = numNameTable;
                            }
                        }
                        //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                        if (numShowColumn != 0)
                        {
                            // dem so file co trong thu muc de chay n lan phep tinh
                            numRun = ttl.DemFileTrongThuMuc(linkAccess);
                            for (int i = 0; i < numRun; i++)
                            {
                                //khoi dong lai bien num name table
                                numNameTable = 0;
                                //lay cac file line co trong bang
                                string[] folderTable = Directory.GetFiles(linkAccess);
                                foreach (string files in folderTable)
                                {
                                    //neu file line co ton tai
                                    if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                                    {
                                        //hien thi thong tin cua file
                                        string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                        foreach (string linesColumn in showFileLineInColumn)
                                        {
                                            numRunFileLine++;
                                            if (numShowColumn == numRunFileLine)
                                            {
                                                try
                                                {
                                                    numSS1 = double.Parse(linesColumn);
                                                }
                                                catch { }
                                            }
                                        }
                                        if (numSS1 != 0)
                                        {
                                            numNameTable = numNameTable + 1;
                                            //neu file line co ton tai
                                            if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                                            {
                                                string[] showFileLineInColumn1 = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                                foreach (string linesColumn1 in showFileLineInColumn1)
                                                {
                                                    numRunFileLine1++;
                                                    if (numShowColumn == numRunFileLine1)
                                                    {
                                                        try
                                                        {
                                                            numSS2 = double.Parse(linesColumn1);
                                                        }
                                                        catch { }
                                                    }
                                                }
                                            }
                                            // tra bien numnametable ve vi tri ban dau
                                            numNameTable = numNameTable - 1;
                                        }
                                        numRunFileLine = 0;
                                        numRunFileLine1 = 0;
                                        // doi cho file
                                        if (numSS2 < numSS1)
                                            ttl.ChuyenCho2File(linkAccess + "line" + numNameTable + ".txt", linkAccess + "line" + (numNameTable + 1) + ".txt");
                                    }
                                    numNameTable++;
                                }
                            }

                        }
                    }
                }
            }
        }
        // ghi ngay cho tung dong
        public static void WriteInColumnWithDate(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            string removed = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            bool tF1 = false;
            var datBD = new DateTime();
            var datKT = new DateTime();
            int sumDay = 0;
            int numArr = 0;
            int line1 = 0;
            int line2 = 0;
            string[] arrDate;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "writeincolumnwithdate>column");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false && tF1 == true)
                    {
                        Console.Write("DATE1(DAY/MONTH/YEAR): ");
                        datBD = DateTime.Parse(Console.ReadLine());
                        Console.Write("DATE2(DAY/MONTH/YEAR): ");
                        datKT = DateTime.Parse(Console.ReadLine());
                        Console.Write("LINE1> ");
                        int.TryParse(Console.ReadLine(), out line1);
                        Console.Write("LINE2> ");
                        int.TryParse(Console.ReadLine(), out line2);
                        Console.Write("REMOVED>");
                        removed = Console.ReadLine();
                        //kiem tra xem ten bang hien thi co ton tai hay khong
                        string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                        foreach (string linesName in fileNameTable)
                        {
                            numNameTable++;
                            //neu ten bang can kiem tra co ton tai trong bang
                            if (linesName == str)
                            {
                                numShowColumn = numNameTable;
                            }
                        }
                        //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                        if (numShowColumn != 0)
                        {
                            sumDay = ttl.TinhNgay(datBD.Day, datBD.Month, datBD.Year, datKT.Day, datKT.Month, datKT.Year);
                            arrDate = new string[sumDay + 1];
                            for (int ctr = 0; ctr <= ctr + 1; ctr++)
                            {
                                arrDate[ctr] = datBD.AddDays(ctr).ToString("d");
                                // //hi?n ng?y
                                // Console.WriteLine(datBD.AddDays(ctr).ToString("d"));
                                // ?i?u ki?n d?ng v?ng l?pyp
                                if (datBD.AddDays(ctr).Day == datKT.Day && datBD.AddDays(ctr).Month == datKT.Month && datBD.AddDays(ctr).Year == datKT.Year)
                                {
                                    break;
                                }
                            }
                            //khoi dong lai bien num name table
                            numNameTable = 0;
                            //lay cac file line co trong bang
                            string[] folderTable = Directory.GetFiles(linkAccess);
                            foreach (string files in folderTable)
                            {
                                //neu file line co ton tai
                                if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true && numNameTable >= line1 && numNameTable <= line2)
                                {
                                    // tao file ao?
                                    ttl.TaoFile(linkAccess + "line" + numNameTable + "txt.txt");
                                    // ghi du lieu vao file ao?
                                    TextWriter txF = new StreamWriter(linkAccess + "line" + numNameTable + "txt.txt", true);
                                    //hien thi thong tin cua file
                                    string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                    foreach (string linesColumn in showFileLineInColumn)
                                    {
                                        numRunFileLine++;
                                        //neu dong hien thi khac vi tri cot
                                        if (numShowColumn != numRunFileLine)
                                            txF.WriteLine(linesColumn);
                                        //neu dong hien thi o vi tri cot
                                        if (numShowColumn == numRunFileLine)
                                        {
                                            if (removed.Replace(" ", "") != linesColumn.Replace(" ", ""))
                                            {
                                                txF.WriteLine(arrDate[numArr]);
                                                numArr++;
                                            }
                                            if (removed.Replace(" ", "") == linesColumn.Replace(" ", ""))
                                                txF.WriteLine(linesColumn);
                                        }
                                    }
                                    numRunFileLine = 0;
                                    txF.Close();
                                    // xoa file cu~
                                    File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                    // doi file ao thanh file cu~
                                    File.Move(linkAccess + "line" + numNameTable + "txt.txt", linkAccess + "line" + numNameTable + ".txt");
                                    // xoa file ao?
                                    File.Delete(linkAccess + "line" + numNameTable + "txt.txt");
                                }
                                numNameTable++;
                            }
                        }
                    }
                }
            }
        }
        // ghi du lieu so vao cot
        public static void WriteInColumnWithNum(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            string removed = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            bool tF1 = false;
            int num1 = 0;
            int num2 = 0;
            int numArr = 0;
            int line1 = 0;
            int line2 = 0;
            int numSum = 0;
            int[] arrNum;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "writeincolumnwithnum>column");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false && tF1 == true)
                    {
                        Console.Write("NUM1: ");
                        int.TryParse(Console.ReadLine(), out num1);
                        Console.Write("NUM2: ");
                        int.TryParse(Console.ReadLine(), out num2);
                        Console.Write("LINE1> ");
                        int.TryParse(Console.ReadLine(), out line1);
                        Console.Write("LINE2> ");
                        int.TryParse(Console.ReadLine(), out line2);
                        Console.Write("REMOVED>");
                        removed = Console.ReadLine();
                        //kiem tra xem ten bang hien thi co ton tai hay khong
                        string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                        foreach (string linesName in fileNameTable)
                        {
                            numNameTable++;
                            //neu ten bang can kiem tra co ton tai trong bang
                            if (linesName == str)
                            {
                                numShowColumn = numNameTable;
                            }
                        }
                        //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                        if (numShowColumn != 0)
                        {
                            if (num1 < num2)
                            {
                                for (int i = num1; i <= num2; i++)
                                {
                                    numSum++;
                                }
                            }
                            if (num1 > num2)
                            {
                                for (int i = num2; i <= num1; i++)
                                {
                                    numSum++;
                                }
                            }
                            arrNum = new int[numSum + 1];
                            if (num1 < num2)
                            {
                                for (int i = num1; i <= num2; i++)
                                {
                                    arrNum[i - 1] = i;
                                }
                            }
                            if (num1 > num2)
                            {
                                for (int i = num2; i <= num1; i++)
                                {
                                    arrNum[i - 1] = num1 - i + 1;
                                }
                            }
                            //khoi dong lai bien num name table
                            numNameTable = 0;
                            //lay cac file line co trong bang
                            string[] folderTable = Directory.GetFiles(linkAccess);
                            foreach (string files in folderTable)
                            {
                                //neu file line co ton tai
                                if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true && numNameTable >= line1 && numNameTable <= line2)
                                {
                                    // tao file ao?
                                    ttl.TaoFile(linkAccess + "line" + numNameTable + "txt.txt");
                                    // ghi du lieu vao file ao?
                                    TextWriter txF = new StreamWriter(linkAccess + "line" + numNameTable + "txt.txt", true);
                                    //hien thi thong tin cua file
                                    string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                    foreach (string linesColumn in showFileLineInColumn)
                                    {
                                        numRunFileLine++;
                                        //neu dong hien thi khac vi tri cot
                                        if (numShowColumn != numRunFileLine)
                                            txF.WriteLine(linesColumn);
                                        //neu dong hien thi o vi tri cot
                                        if (numShowColumn == numRunFileLine)
                                        {
                                            if (removed.Replace(" ", "") != linesColumn.Replace(" ", ""))
                                            {
                                                txF.WriteLine(arrNum[numArr]);
                                                numArr++;
                                            }
                                            if (removed.Replace(" ", "") == linesColumn.Replace(" ", ""))
                                                txF.WriteLine(linesColumn);
                                        }
                                    }
                                    numRunFileLine = 0;
                                    txF.Close();
                                    // xoa file cu~
                                    File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                    // doi file ao thanh file cu~
                                    File.Move(linkAccess + "line" + numNameTable + "txt.txt", linkAccess + "line" + numNameTable + ".txt");
                                    // xoa file ao?
                                    File.Delete(linkAccess + "line" + numNameTable + "txt.txt");
                                }
                                numNameTable++;
                            }
                        }
                    }
                }
            }
        }
        //upload du lieu tu file len cot
        public static void UploadFileToColumn(string c, string linkTKB, string nameTable, string b)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            string nameFile = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            string strNewLine = "";
            bool tF = false;
            bool tF1 = false;
            int numLineFileUpload = 0;
            int numLineColumn = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(c, "uploadfiletocolumn");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false && tF1 == true)
                    {
                        Console.Write("LINK FILE>");
                        nameFile = Console.ReadLine();
                        // lay du lieu so dong trong file upload
                        numLineFileUpload = ttl.DemSoDongTrongFile(nameFile);
                        numLineColumn = ttl.DemFileTrongThuMuc(linkAccess);
                        // neu so dong trong cot it hon so dong trong file upload hien thi thong bao cho nguoi dung
                        if (numLineFileUpload > (numLineColumn - 1))
                            ttl.HienThiThongBao("ERROR!", "NEED " + (numLineFileUpload - (numLineColumn - 1)) + " LINE TO UPLOAD FILE TO COLUMN!", 16, b);
                        //neu file co ton tai va so dong trong cot be hon hoac bang so dong trong file upload
                        if (File.Exists(nameFile) == true && numLineFileUpload <= (numLineColumn - 1))
                        {
                            //kiem tra xem ten bang hien thi co ton tai hay khong
                            string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                            foreach (string linesName in fileNameTable)
                            {
                                numNameTable++;
                                //neu ten bang can kiem tra co ton tai trong bang
                                if (linesName == str)
                                {
                                    numShowColumn = numNameTable;
                                }
                            }
                            //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                            if (numShowColumn != 0)
                            {
                                //khoi dong lai bien num name table
                                numNameTable = 0;
                                //lay cac file line co trong bang
                                string[] folderTable = Directory.GetFiles(linkAccess);
                                foreach (string files in folderTable)
                                {
                                    //neu file line co ton tai
                                    if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                                    {
                                        // tao file ao?
                                        ttl.TaoFile(linkAccess + "line" + numNameTable + "txt.txt");
                                        // ghi du lieu vao file ao?
                                        TextWriter txF = new StreamWriter(linkAccess + "line" + numNameTable + "txt.txt", true);
                                        //hien thi thong tin cua file
                                        string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                        foreach (string linesColumn in showFileLineInColumn)
                                        {
                                            numRunFileLine++;
                                            //neu dong hien thi khac vi tri cot
                                            if (numShowColumn != numRunFileLine)
                                                txF.WriteLine(linesColumn);
                                            //neu dong hien thi o vi tri cot
                                            if (numShowColumn == numRunFileLine)
                                            {
                                                strNewLine = ttl.TraDuLieuSoNDongTrongFile(nameFile, numNameTable);
                                                if (strNewLine.Replace(" ", "") != "")
                                                    txF.WriteLine(strNewLine);
                                                //va loi dong rong~
                                                if (strNewLine.Replace(" ", "") == "")
                                                    txF.WriteLine(" ");
                                            }
                                        }
                                        numRunFileLine = 0;
                                        txF.Close();
                                        // xoa file cu~
                                        File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                        // doi file ao thanh file cu~
                                        File.Move(linkAccess + "line" + numNameTable + "txt.txt", linkAccess + "line" + numNameTable + ".txt");
                                        // xoa file ao?
                                        File.Delete(linkAccess + "line" + numNameTable + "txt.txt");
                                    }
                                    numNameTable++;
                                }
                            }
                            // thong bao cap nhat thanh cong
                            ttl.HienThiThongBao("CAP NHAT THANH CONG :D", "DA UPLOAD " + numLineFileUpload + " DONG DEN COT " + str.ToUpper(), 0, b);
                        }
                        // thong bao ten file khong ton tai
                        if (File.Exists(nameFile) == false)
                            ttl.HienThiThongBao("NO FOUND NAME FILE!", "UNFOUND FILE NAME " + nameFile, 16, b);
                    }
                }
            }
        }
        // thay doi tat ca  noi dung trong bang
        public static void ChangeContent(string c, string linkTKB, string nameTable)
        {
            int numNameTable = 0;
            string strNewline = "";
            string str = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            //neu duong dan khac rong
            if (linkTKB != "" && c.Replace(" ", "") != "")
            {
                HelpTTL ttl = new HelpTTL();
                Console.Write("CONTENT>");
                str = Console.ReadLine();
                Console.Write("({0}) = ", str);
                strNewline = Console.ReadLine();
                //khoi dong lai bien num name table
                numNameTable = 0;
                //lay cac file line co trong bang
                string[] folderTable = Directory.GetFiles(linkAccess);
                foreach (string files in folderTable)
                {
                    //neu file line co ton tai
                    if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true)
                    {
                        // tao file ao?
                        ttl.TaoFile(linkAccess + "line" + numNameTable + "txt.txt");
                        // ghi du lieu vao file ao?
                        TextWriter txF = new StreamWriter(linkAccess + "line" + numNameTable + "txt.txt", true);
                        //hien thi thong tin cua file
                        string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                        foreach (string linesColumn in showFileLineInColumn)
                        {
                            if (str.Replace(" ", "") == linesColumn.Replace(" ", ""))
                            {
                                // neu du lieu ghi vao file khac rong~
                                if (strNewline.Replace(" ", "") != "")
                                    txF.WriteLine(strNewline);
                                // neu du lieu ghi vao file = rong~
                                if (strNewline.Replace(" ", "") == "")
                                    txF.WriteLine(" ");
                            }
                            if (str.Replace(" ", "") != linesColumn.Replace(" ", ""))
                            {
                                txF.WriteLine(linesColumn);
                            }
                        }
                        txF.Close();
                        // xoa file cu~
                        File.Delete(linkAccess + "line" + numNameTable + ".txt");
                        // doi file ao thanh file cu~
                        File.Move(linkAccess + "line" + numNameTable + "txt.txt", linkAccess + "line" + numNameTable + ".txt");
                        // xoa file ao?
                        File.Delete(linkAccess + "line" + numNameTable + "txt.txt");
                    }
                    numNameTable++;
                }
            }
        }
        // thêm 1 noi dung cho 1 cot
        public static void WriteInColumnWithLine(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            int line1 = 0;
            int line2 = 0;
            string remove = "";
            string strNewline = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            int num = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                HelpTTL ttl = new HelpTTL();
                // ghi ky du lieu giong nhau vao cot vs dong duoc chi dinh
                str = ttl.Loc1KyTu(c, "writeincolumnwithline>column");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false)
                    {
                        Console.Write("LINE1>");
                        int.TryParse(Console.ReadLine(), out line1);
                        Console.Write("LINE2>");
                        int.TryParse(Console.ReadLine(), out line2);
                        Console.Write("Write Content>>");
                        strNewline = Console.ReadLine();
                        Console.Write("Remove!>");
                        remove = Console.ReadLine();
                        //kiem tra xem ten bang hien thi co ton tai hay khong
                        string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                        foreach (string linesName in fileNameTable)
                        {
                            numNameTable++;
                            //neu ten bang can kiem tra co ton tai trong bang
                            if (linesName == str)
                            {
                                numShowColumn = numNameTable;
                            }
                        }
                        //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                        if (numShowColumn != 0)
                        {
                            //khoi dong lai bien num name table
                            numNameTable = 0;
                            //lay cac file line co trong bang
                            string[] folderTable = Directory.GetFiles(linkAccess);
                            foreach (string files in folderTable)
                            {
                                num++;
                                //neu file line co ton tai
                                if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true && num > line1 && num <= line2 + 1)
                                {
                                    // tao file ao?
                                    ttl.TaoFile(linkAccess + "line" + numNameTable + "txt.txt");
                                    // ghi du lieu vao file ao?
                                    TextWriter txF = new StreamWriter(linkAccess + "line" + numNameTable + "txt.txt", true);
                                    //hien thi thong tin cua file
                                    string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                    foreach (string linesColumn in showFileLineInColumn)
                                    {
                                        numRunFileLine++;
                                        //neu dong hien thi khac vi tri cot
                                        if (numShowColumn != numRunFileLine)
                                            txF.WriteLine(linesColumn);
                                        //neu dong hien thi o vi tri cot
                                        if (numShowColumn == numRunFileLine)
                                        {
                                            // neu du lieu ghi vao file khac rong~
                                            if (remove.Replace(" ", "").ToLower() != linesColumn.Replace(" ", "").ToLower())
                                                txF.WriteLine(strNewline);
                                            // neu du lieu ghi vao file = rong~
                                            if (remove.Replace(" ", "").ToLower() == linesColumn.Replace(" ", "").ToLower())
                                                txF.WriteLine(linesColumn);
                                        }
                                    }
                                    numRunFileLine = 0;
                                    txF.Close();
                                    // xoa file cu~
                                    File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                    // doi file ao thanh file cu~
                                    File.Move(linkAccess + "line" + numNameTable + "txt.txt", linkAccess + "line" + numNameTable + ".txt");
                                    // xoa file ao?
                                    File.Delete(linkAccess + "line" + numNameTable + "txt.txt");
                                }
                                numNameTable++;
                            }
                        }
                    }

                }
            }
        }
        // viet noi dung cho cot
        public static void WriteContent(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int numNameTable = 0;
            int numShowColumn = 0;
            int numRunFileLine = 0;
            int line1 = 0;
            int line2 = 0;
            string strNewline = "";
            string linkAccess = linkTKB + "/" + nameTable + "/";
            bool tF = false;
            int num = 0;
            int num1 = 0;
            // number run array
            int num2 = 0;
            // number de chay viet dong
            int num3 = 0;
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                HelpTTL ttl = new HelpTTL();
                // ghi ky du lieu giong nhau vao cot vs dong duoc chi dinh
                str = ttl.Loc1KyTu(c, "writecontent");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false)
                    {
                        Console.Write("LINE1>");
                        int.TryParse(Console.ReadLine(), out line1);
                        Console.Write("LINE2>");
                        int.TryParse(Console.ReadLine(), out line2);
                        //kiem tra xem ten bang hien thi co ton tai hay khong
                        string[] fileNameTable = File.ReadAllLines(linkAccess + "/Name/name.txt");
                        foreach (string linesName in fileNameTable)
                        {
                            numNameTable++;
                            //neu ten bang can kiem tra co ton tai trong bang
                            if (linesName == str)
                            {
                                numShowColumn = numNameTable;
                            }
                        }
                        //neu so hien thi bang can hien thi thong tin khac 0 thi bat dau hien thong tin cua bang
                        if (numShowColumn != 0)
                        {
                            // hien thi ten cot
                            Console.WriteLine("| {0} |", str);
                            // gan gia tri num3 = line1
                            num3 = line1;
                            // viet noi dung cho cot
                            string[] arrNewContent = new string[line2 - line1 + 1];
                            do
                            {
                                Console.Write("- {0} -- ", num3);
                                strNewline = Console.ReadLine();
                                // sua loi khoang trang
                                if (strNewline.Replace(" ", "") != "")
                                    arrNewContent[num1] = strNewline;
                                if (strNewline.Replace(" ", "") == "")
                                    arrNewContent[num1] = " ";
                                num1++;
                                num3++;
                            } while (num1 < arrNewContent.Length);
                            //khoi dong lai bien num name table
                            numNameTable = 0;
                            //lay cac file line co trong bang
                            string[] folderTable = Directory.GetFiles(linkAccess);
                            foreach (string files in folderTable)
                            {
                                num++;
                                //neu file line co ton tai
                                if (File.Exists(linkAccess + "line" + numNameTable + ".txt") == true && num > line1 && num <= line2 + 1)
                                {
                                    // tao file ao?
                                    ttl.TaoFile(linkAccess + "line" + numNameTable + "txt.txt");
                                    // ghi du lieu vao file ao?
                                    TextWriter txF = new StreamWriter(linkAccess + "line" + numNameTable + "txt.txt", true);
                                    //hien thi thong tin cua file
                                    string[] showFileLineInColumn = File.ReadAllLines(linkAccess + "line" + numNameTable + ".txt");
                                    foreach (string linesColumn in showFileLineInColumn)
                                    {
                                        numRunFileLine++;
                                        //neu dong hien thi khac vi tri cot
                                        if (numShowColumn != numRunFileLine)
                                            txF.WriteLine(linesColumn);
                                        //neu dong hien thi o vi tri cot
                                        if (numShowColumn == numRunFileLine)
                                        {
                                            // ghi noi dung vao file
                                            txF.WriteLine(arrNewContent[num2]);
                                            num2++;
                                        }
                                    }
                                    numRunFileLine = 0;
                                    txF.Close();
                                    // xoa file cu~
                                    File.Delete(linkAccess + "line" + numNameTable + ".txt");
                                    // doi file ao thanh file cu~
                                    File.Move(linkAccess + "line" + numNameTable + "txt.txt", linkAccess + "line" + numNameTable + ".txt");
                                    // xoa file ao?
                                    File.Delete(linkAccess + "line" + numNameTable + "txt.txt");
                                }
                                numNameTable++;
                            }
                        }
                    }

                }
            }
        }
        // change name table
        public static void ChangeNameTable(string c, string linkTKB, string nameTable)
        {
            string str = "";
            string strNewName = "";
            bool tF = false;
            bool tF1 = false;
            string newNameColumn = "";
            string linkAccess = "";
            string linkAccess1 = "";
            char ok = ' ';
            //neu duong dan khac rong
            if (linkTKB != "" && c != "")
            {
                HelpTTL ttl = new HelpTTL();
                // ghi ky du lieu giong nhau vao cot vs dong duoc chi dinh
                str = ttl.Loc1KyTu(c, "changenametable");
                //neu ten bang can xoa co ton tai
                if (str.Replace(" ", "") != "")
                {
                    linkAccess = linkTKB + "/" + nameTable + "/";
                    // kiem tra du lieu trong file protect column
                    tF = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/ProtectColumn/ProtectColumn", str);
                    // kiem tra du lieu trong file name
                    tF1 = ttl.KiemTraDuLieuTrongFile(linkTKB + nameTable + "/Name/name.txt", str);
                    // neu ten bang khong duoc bao ve thi ghi du lieu vao file
                    if (tF == false && tF1 == true)
                    {
                        Console.Write("NEW NAME: {0} >> ", str.ToUpper());
                        strNewName = Console.ReadLine();
                        // tao file moi
                        if (strNewName.Replace(" ", "") != "")
                        {
                            ttl.TaoFile(linkAccess + "name1.txt");
                            // GHI DU LIEU VAO FILE moi
                            // doc du lieu file cu~
                            string[] rF = File.ReadAllLines(linkAccess + "/Name/name.txt");
                            foreach (string lines in rF)
                            {
                                if (lines.Replace(" ", "").ToLower() != str.Replace(" ", "").ToLower())
                                    ttl.WriteLine(linkAccess + "name1.txt", lines);
                                if (lines.Replace(" ", "").ToLower() == str.Replace(" ", "").ToLower())
                                    ttl.WriteLine(linkAccess + "name1.txt", strNewName.ToLower());
                            }
                            // xoa file cu~
                            File.Delete(linkAccess + "/Name/name.txt");
                            // doi file moi thanh file cu~
                            File.Move(linkAccess + "name1.txt", linkAccess + "/Name/name.txt");
                        }
                    }
                    // neu khong co ten bang thay doi tat ca ten trong bang?
                    if (tF1 == false)
                    {
                        linkAccess = linkTKB + "/" + nameTable + "/Name/name.txt";
                        linkAccess1 = linkTKB + "/" + nameTable + "/name1.txt";
                        //doi ten file
                        File.Move(linkAccess, linkAccess1);
                        //tao file ten cot moi
                        FileStream fileNewNameColumn = new FileStream(linkAccess, FileMode.Create);
                        fileNewNameColumn.Close();
                        //ghi du lieu vao file ten cot moi
                        TextWriter textNewNameColumn = new StreamWriter(linkAccess, true);
                        //hien thi ten cac column cu~
                        string[] fileNameColumn = File.ReadAllLines(linkAccess1);
                        foreach (string nameColumn in fileNameColumn)
                        {
                            // kiem tra du lieu trong file co trung voi du lieu trong file bao ve
                            string[] rF = File.ReadAllLines(linkTKB + "/" + nameTable + "/ProtectColumn/ProtectColumn");
                            foreach (string lines in rF)
                            {
                                //neu du lieu trong file khac vs du lieu dang co trong file bao ve
                                if (lines.Replace(" ", "").ToLower() == nameColumn.Replace(" ", "").ToLower())
                                    ok = '1';
                            }
                            //neu ten file khong duoc dang ky bao ve
                            if (ok != '1')
                            {
                                Console.Write(nameColumn.ToUpper());
                                Console.Write(" > ");
                                //ghi ten cot moi
                                newNameColumn = Console.ReadLine();
                                newNameColumn = newNameColumn.Replace(" ", "").ToLower();
                                //neu khong co du lieu nhap vao giu nguyen ten ban dau
                                if (newNameColumn == "")
                                    newNameColumn = nameColumn;
                                //ghi du lieu ten cot moi vao file
                                textNewNameColumn.WriteLine(newNameColumn);
                            }
                            // neu ten file dang duoc bao ve
                            if (ok == '1')
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(nameColumn.ToUpper());
                                //ghi du lieu ten cot moi vao file
                                textNewNameColumn.WriteLine(nameColumn.ToLower().Replace(" ", ""));
                               Console.ResetColor();
                            }
                            ok = ' ';
                        }
                        textNewNameColumn.Close();
                        //xoa file ten cu
                        File.Delete(linkAccess1);
                    }
                }
            }
        }
        // change line thay doi dong
        public static void ChangeLines(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int line = 0;
            int lineTo = 0;
            HelpTTL ttl = new HelpTTL();
            str = ttl.Loc1KyTu(c, "changeline");
            // neu str khac rong~
            if (str.Replace(" ", "") != "")
            {
                // chuyen str dong qua so
                line = int.Parse(str);
                // neu so dong co ton tai trong table
                if (File.Exists(linkTKB + nameTable + "/line" + line + ".txt") == true)
                {
                    // ghi so dong muon doi cho~
                    Console.Write("LINE {0} > LINE ", line);
                    int.TryParse(Console.ReadLine(), out lineTo);
                    // neu so dong dang can doi cho co trong table
                    if (File.Exists(linkTKB + nameTable + "/line" + lineTo + ".txt") == true && line != lineTo)
                    {
                        // chuyen doi lan 1
                        File.Copy(linkTKB + nameTable + "/line" + line + ".txt", linkTKB + nameTable + "/lineA" + line + ".txt");
                        // chuyen doi lan 2
                        File.Copy(linkTKB + nameTable + "/line" + lineTo + ".txt", linkTKB + nameTable + "/lineA" + lineTo + ".txt");
                        // ghi du lieu file moi vao file cu~
                        ttl.GhiDuLieuTuFileDenFile(linkTKB + nameTable + "/lineA" + line + ".txt", linkTKB + nameTable + "/line" + lineTo + ".txt", false);
                        ttl.GhiDuLieuTuFileDenFile(linkTKB + nameTable + "/lineA" + lineTo + ".txt", linkTKB + nameTable + "/line" + line + ".txt", false);
                        // xoa file
                        File.Delete(linkTKB + nameTable + "/lineA" + line + ".txt");
                        File.Delete(linkTKB + nameTable + "/lineA" + lineTo + ".txt");
                    }
                }
            }
        }
        // hien thi thong tin dong
        public static void ShowLine(string c, string linkTKB, string nameTable)
        {
            string str = "";
            int line = 0;
            HelpTTL ttl = new HelpTTL();
            str = ttl.Loc1KyTu(c, "showline");
            // neu str khac rong~
            if (str.Replace(" ", "") != "")
            {
                // chuyen str dong qua so
                line = int.Parse(str);
                // neu dong co ton tai trong table
                if (File.Exists(linkTKB + nameTable + "/line" + line + ".txt") == true)
                {
                    ttl.HienThiDuLieuTrongFile(linkTKB + nameTable + "/line" + line + ".txt", 0, 0, " [_SPACE_] ");
                    Console.ReadKey();
                }
            }
        }
        //     /// <summary>
        //     /// ham choi nhac
        //     /// </summary>
        //     /// <param name="link"></param>
        //     public static void PlayMusic(string link)
        //     {

        //         string chosseMusic = "";
        //         string newLink = "";
        //         string nameFile = "";
        //         do
        //         {
        //             //xoa man hinh
        //             Console.Clear();
        //             //hien thi danh sach thu muc
        //             string[] folder = Directory.GetDirectories(link);
        //             foreach (string nameFolder in folder)
        //             {
        //                 Console.WriteLine(nameFolder);
        //             }
        //             //hien thi danh sach file trong thu muc
        //             string[] files = Directory.GetFiles(link);
        //             foreach (string file in files)
        //             {
        //                 nameFile = Path.GetFileName(file);
        //                 Console.WriteLine("> " + nameFile);
        //             }
        //             Console.Write("YOUR LIFE IS MUSIC>");
        //             chosseMusic = Console.ReadLine();
        //             //chuyen duong dan
        //             if (chosseMusic.ToLower().Replace(" ", "") == "changelink")
        //             {
        //                 //hien thi duong dan hien tai
        //                 Console.WriteLine(link);
        //                 Console.Write("New Link: ");
        //                 newLink = Console.ReadLine();
        //                 //neu duong dan khac rong va co ton tai
        //                 if (newLink.Replace(" ", "") != "" && Directory.Exists(newLink) == true)
        //                 {
        //                     Console.ForegroundColor = ConsoleColor.Green;
        //                     Console.WriteLine(newLink);
        //                     //thay doi duong dan
        //                     link = newLink;
        //                 }
        //                 else
        //                 {
        //                     Console.ForegroundColor = ConsoleColor.Red;
        //                     Console.WriteLine(newLink);
        //                 }
        //                Console.ResetColor();
        //             }
        //             //play music
        //             if (chosseMusic.Replace(" ", "") != " " && File.Exists(link + "/" + chosseMusic) == true)
        //             {
        //                 //xoa man hinh
        //                 Console.Clear();
        //                 SoundManager sound = new SoundManager(link + "/" + chosseMusic);
        //                 string cmd;
        //                 Console.WriteLine(chosseMusic + "/play/pause/resume/stop");
        //                 cmd = Console.ReadLine();
        //                 while (cmd.ToLower().Replace(" ", "") != "exit")
        //                 {
        //                     if (cmd == "/play")
        //                     {
        //                         sound.Play();
        //                         cmd = Console.ReadLine();
        //                     }
        //                     else if (cmd == "/pause")
        //                     {
        //                         sound.Pause();
        //                         cmd = Console.ReadLine();
        //                     }
        //                     else if (cmd == "/resume")
        //                     {
        //                         sound.Resume();
        //                         cmd = Console.ReadLine();
        //                     }
        //                     else if (cmd == "/stop")
        //                     {
        //                         sound.Stop();
        //                         cmd = Console.ReadLine();
        //                     }
        //                     else
        //                         cmd = Console.ReadLine();

        //                 }
        //                 //tat nhac
        //                 sound.Stop();
        //             }
        //         } while (chosseMusic != "exit");
        //     }
        // }
        // //thu vien choi nhac
        // public class SoundManager
        // {
        //     WindowsMediaPlayer sound;
        //     public SoundManager(string _filePath)
        //     {
        //         sound = new WindowsMediaPlayer();
        //         sound.URL = _filePath;
        //     }

        //     public void Play()
        //     {
        //         sound.controls.play();
        //     }

        //     public void Next()
        //     {
        //         sound.controls.next();
        //     }
        //     public void Stop()
        //     {
        //         sound.controls.stop();
        //     }

        //     public void Pause()
        //     {
        //         sound.controls.pause();
        //     }

        //     public void Resume()
        //     {
        //         if (sound.status == "Paused")
        //             sound.controls.play();
        //     }

        public static void UploadFiles(string link)
        {
            // thay đổi đường dẫn
            string uploadFile = "";
            link = link + "UploadFiles";
            string link1 = "";
            string link2 = "";
            string nameFile = "";
            int num = 0;
            do
            {
                try
                {
                    // tạo thư mục chứa file upload
                    if (Directory.Exists(link) == false)
                    {
                        DirectoryInfo newD = new DirectoryInfo(link);
                        newD.Create();
                    }
                    // menu
                    Console.WriteLine("[1] NEW");
                    // 
                    uploadFile = Console.ReadLine();
                    if (uploadFile == "1" || uploadFile.Replace(" ", "").ToLower() == "new")
                    {
                        Console.Write("GHI TEN FILE: ");
                        nameFile = Console.ReadLine();
                        // tạo fle
                        if (File.Exists(link + "/" + nameFile) == false)
                        {
                            num = 0;
                            FileStream fN = new FileStream(link + "/" + nameFile, FileMode.Create);
                            fN.Close();
                            // ghi đường dẫn 1
                            Console.Write("Link Connect.. ");
                            link1 = Console.ReadLine();
                            Console.Write("{0} >file ", link1);
                            link2 = Console.ReadLine();
                            // kiểm tra đường dẫn
                            if (link1.Replace(" ", "") != "" && link2.Replace(" ", "") != "")
                            {
                                //ghi dữ liệu vào file
                                TextWriter ttl = new StreamWriter(link + "/" + nameFile, true);
                                ttl.WriteLine(link2);
                                ttl.WriteLine(link1);
                                ttl.Close();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("CAP NHAT THANH CONG!");
                               Console.ResetColor();
                                num = 1;
                            }
                            if (num == 0)
                            {
                                File.Delete(link + "/" + nameFile);
                            }
                        }
                    }
                }
                catch (Exception E)
                {
                    Console.WriteLine(E);
                    Console.ReadKey();
                }

            } while (uploadFile.ToLower().Replace(" ", "") != "exit");
        }
        // hide system
        public static void HideSystem(string link)
        {
            // tao file
            FileStream fN = new FileStream("hidesystem.bat", FileMode.Create);
            fN.Close();
            // ghi du lieu vao file
            TextWriter ttl = new StreamWriter("hidesystem.bat", true);
            ttl.Write("attrib +s +h +r " + link);
            ttl.Close();
            // chạy file
            Process.Start("hidesystem.bat");

        }
        // hide system
        public static void ShowSystem(string link)
        {
            // tao file
            FileStream fN = new FileStream("hidesystem.bat", FileMode.Create);
            fN.Close();
            // ghi du lieu vao file
            TextWriter ttl = new StreamWriter("hidesystem.bat", true);
            ttl.Write("attrib -s -h -r " + link);
            ttl.Close();
            // chạy file
            Process.Start("hidesystem.bat");

        }
        // call
        public static void CallSomething(string data, string b)
        {
            string str = "";
            //neu duong dan khac rong
            if (data != "")
            {
                // loc ky tu
                HelpTTL ttl = new HelpTTL();
                str = ttl.Loc1KyTu(data, "call ");
                if (str.Replace(" ", "") != "")
                    // mo duong dan
                    ttl.MoDuongDan(str);
            }
        }
        // Loading
        // lấy tổng mọi thứ trong thư mục
        // public static int GetSumLoading(string link1, int numSum)
        //     {
        //         try
        //         {
        //             //lấy dữ liệu tổng
        //             string[] allfiles = Directory.GetFiles(link1, "*.*", SearchOption.AllDirectories);
        //             foreach (var file in allfiles)
        //             {
        //                 numSum++;
        //                 FileInfo info = new FileInfo(file);
        //                 // Do something with the Folder or just add them to a list via nameoflist.add();
        //                 //Console.WriteLine(info);
        //             }
        //             string[] allDir = Directory.GetDirectories(link1, "", SearchOption.AllDirectories);
        //             foreach (var d in allDir)
        //             {
        //                 numSum++;
        //                 DirectoryInfo info = new DirectoryInfo(d);
        //                 // Do something with the Folder or just add them to a list via nameoflist.add();
        //                 //Console.WriteLine(info);
        //             }
        //             Console.WriteLine();
        //         }
        //         catch(Exception e)
        //         {
        //             Console.WriteLine(e);
        //         }
        //         return numSum;
        // }
        // 
        public static int GetSumLoading(string link, int numSum)
        {
            try
            {
                // neu du lieu la mot thu muc
                if (Directory.Exists(link) == true)
                {
                    // lay cac file trong thu muc
                    string[] dU = Directory.GetFiles(link);
                    foreach (string lineD in dU)
                    {
                        numSum++;
                    }
                    // lay cac thu muc trong thu muc
                    string[] fU = Directory.GetDirectories(link);
                    foreach (string lineD in fU)
                    {
                        numSum++;
                    }
                }
                // neu du lieu la mot file
                if (File.Exists(link) == true)
                {
                    // doc cac dong trong file
                    string[] rF = File.ReadAllLines(link);
                    foreach (string lineD in rF)
                    {
                        numSum++;
                    }
                }
            }
            catch
            {

            }

            return numSum;
        }
        // hiển thị loading dữ liệu
        public static void Loading(int i, int numSum)
        {
            if (i <= numSum)
            {
                Console.Write("[");
                //ve
                Console.ForegroundColor = ConsoleColor.White;
                // Console.BackgroundColor = ConsoleColor.White;
                for (int ii = 0; ii < (i * 100 / numSum); ii++)
                {
                    Console.Write("#");
                }
                // Console.BackgroundColor = ConsoleColor.Black;
               Console.ResetColor();
                for (int iii = 0; iii < 100 - (i * 100 / numSum); iii++)
                {
                    Console.Write(" ");
                }
                Console.Write("]" + (i * 100 / numSum) + "%\r");
            }
        }
        // hien thi du lieu trong file upload
        public static void ShowFileUpload(string link)
        {
            // neu file co ton tai
            if (File.Exists(link + "/Upload.ttl") == true)
            {
                string[] readFile = File.ReadAllLines(link + "/Upload.ttl");
                foreach (string lines in readFile)
                {
                    Console.Write("(" + lines + ") ");
                }
            }
            Console.WriteLine();
        }
        // thong ke loi gap trong 1 ngay
        public static void SoanNoiDungCanhBao(string link)
        {
            string sKPL = "";
            string str = "";
            int iHTL = 0;
            int iNGTB = 0;
            link = link + "/Stage/";
            do
            {
                // xoa man hinh
                Console.Clear();
                HelpTTL ttl = new HelpTTL();
                // hien thi ten cac thu muc stage
                if (Directory.Exists(link) == true)
                {
                    string[] gD = Directory.GetDirectories(link);
                    foreach (string d in gD)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        ttl.TaoFile(d, "khacphucloi");
                        ttl.TaoFile(d, "hienthiloi");
                        ttl.TaoFile(d, "ngayguithongbao");
                        // sua du lieu ngay gui thong bao
                        iNGTB = ttl.LayDuLieuTrongFile(d + "/ngayguithongbao");
                        if (iNGTB == 0)
                            ttl.GhiDuLieuVaoFile(d + "/ngayguithongbao", "01", true);
                        DirectoryInfo nD = new DirectoryInfo(d);
                        Console.Write("ERROR!> " + nD.Name + "!");
                        // doc du lieu khac phuc loi
                        if (File.Exists(d + "/khacphucloi") == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            ttl.HienThiDuLieuTrongFile(d + "/khacphucloi", 0, -1, "!");
                        }
                        if (File.Exists(d + "/hienthiloi") == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(" - HIEN THI THONG BAO SAU: ");
                            ttl.HienThiDuLieuTrongFile(d + "/hienthiloi", 0, -1, " NGAY.");
                            Console.WriteLine();
                        }
                        iNGTB = 0;
                    }
                   Console.ResetColor();
                }
                Console.Write("ERROR>");
                sKPL = Console.ReadLine();
                sKPL = sKPL.ToLower().Replace(" ", "");
                // nhap du lieu vao file
                if (Directory.Exists(link + sKPL) == true && File.Exists(link + sKPL + "/khacphucloi") == true)
                {
                    Console.Write("GHI THONG TIN CO THE KHAC PHUC LOI!({0})>", sKPL);
                    str = Console.ReadLine();
                    Console.Write("GHI THOI GIAN HE THONG SE NHAC NHO BAN.> ");
                    int.TryParse(Console.ReadLine(), out iHTL);
                    ttl.GhiDuLieuVaoFile(link + sKPL + "/khacphucloi", str, true);
                    ttl.GhiDuLieuVaoFile(link + sKPL + "/hienthiloi", iHTL, true);
                }
            } while (sKPL != "exit");
        }
        // hien thi thong tin file ngau nhien
        public static void ShowLineFileRandom(string link)
        {
            int numLineFile = 0;
            int show = 0;
            int num = 0;
            if (link.Replace(" ", "") != "")
            {
                // goi phuong thuc tro giup khong tham so
                HelpTTL ttl = new HelpTTL();
                // tao file
                ttl.TaoFile(link + "FileShowRandom.txt");
                // dem so dong trong file
                numLineFile = ttl.DemSoDongTrongFile(link + "FileShowRandom.txt");
                // goi ham random
                Random rd = new Random();
                show = rd.Next(0, numLineFile);
                // doc du lieu trong file
                Console.Write("*THONG BAO: (");
                string[] rF = File.ReadAllLines(link + "FileShowRandom.txt");
                foreach (string line in rF)
                {
                    if (num == show)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(line);
                       Console.ResetColor();
                        Console.WriteLine("..) ");
                    }
                    num++;
                }
            }
        }
        // thong bao ttl
        public static void ThongBaoTTL(string b, HelpTTL ttl)
        {
            string strS = "";
            string str = "";
            int numW = 0;
            int numL = 0;
            int num = 0;
            int num1 = 0;
            int num2 = 0;
            int iSL = 0;
            string colorWT = "";
            string[] arrTB = new string[num1];
            // tao thu muc hoat dong thong bao
            ttl.TaoThuMuc(b + "/ThongBaoTTL");
            // tao thu muc chua cai dat thong bao
            ttl.TaoThuMuc(b + "/ThongBaoTTL/Set");
            // tao file chua cai dat chieu rong va chieu dai cho thong bao
            ttl.TaoFile(b + "/ThongBaoTTL/Set/setW");
            ttl.TaoFile(b + "/ThongBaoTTL/Set/setL");
            // mau sac
            ttl.TaoFile(b + "/ThongBaoTTL/Set/colorWordTable");
            // tao file chua du lieu
            ttl.TaoFile(b + "/ThongBaoTTL/thongbao");
            // ghi du lieu trong file vao mang
            if (File.Exists(b + "/ThongBaoTTL/thongbao") == true)
            {
                num1 = ttl.DemSoDongTrongFile(b + "/ThongBaoTTL/thongbao");
                arrTB = new string[num1];
                string[] rF = File.ReadAllLines(b + "/ThongBaoTTL/thongbao");
                foreach (string lines in rF)
                {
                    arrTB[num] = lines;
                    num++;
                }

            }
            do
            {
                // set width
                str = ttl.Loc2KyTu(strS, "setwidth=", "sw=");
                if (str != "")
                    ttl.GhiDuLieuVaoFile(b + "/ThongBaoTTL/Set/setW", str, true);
                // set length
                str = ttl.Loc2KyTu(strS, "setlength=", "sl=");
                if (str != "")
                    ttl.GhiDuLieuVaoFile(b + "/ThongBaoTTL/Set/setL", str, true);
                // set color word table
                str = ttl.Loc2KyTu(strS, "setcolorwordtable", "scwt");
                if (str != "")
                    ttl.GhiDuLieuVaoFile(b + "/ThongBaoTTL/Set/colorWordTable", str, true);
                // lay du lieu tu file
                try
                {
                    // du lieu cai dat table
                    numW = ttl.LayDuLieuTrongFile(b + "/ThongBaoTTL/Set/setW");
                    numL = ttl.LayDuLieuTrongFile(b + "/ThongBaoTTL/Set/setL");
                    // du lieu mau sac
                    colorWT = ttl.LayDuLieuTrongFile1(b + "/ThongBaoTTL/Set/colorWordTable");
                    // lay du lieu dong trong file
                    iSL = ttl.DemSoDongTrongFile(b + "/ThongBaoTTL/thongbao");
                }
                // xoa file neu xay ra loi
                catch
                {
                    // xoa file
                    File.Delete(b + "/ThongBaoTTL/Set/setW");
                    File.Delete(b + "/ThongBaoTTL/Set/setL");
                    // tao file chua cai dat chieu rong va chieu dai cho thong bao
                    ttl.TaoFile(b + "/ThongBaoTTL/Set/setW");
                    ttl.TaoFile(b + "/ThongBaoTTL/Set/setL");
                }
                if (iSL < numL)
                    numL = iSL;
                if (strS != "")
                {
                    // xoa man hinh
                    Console.Clear();
                    // ve bang thong bao
                    Console.Write("┌");
                    for (int i = 0; i < numW; i++)
                    {
                        Console.Write("─");
                    }
                    Console.WriteLine("┐");
                    for (int i = 0; i < numL; i++)
                    {
                        Console.Write("│");
                        if (arrTB[i].Length > numW)
                        {
                            ttl.ColorTTL(colorWT);
                            foreach (char ch in arrTB[i])
                            {
                                if (num2 < numW)
                                    // truong hop se hien dau 3 cham
                                    if (num2 > numW - 4 && num2 < numW)
                                        Console.Write(".");
                                    // truong hop se hien day du noi dung bang ky tu
                                    else
                                        Console.Write(ch);
                                num2++;
                            }
                        }
                        // hien day du noi dung trong line
                        if (arrTB[i].Length <= numW)
                        {
                            ttl.ColorTTL(colorWT);
                            Console.Write(arrTB[i]);
                            for (int i1 = 0; i1 < numW - arrTB[i].Length; i1++)
                            {
                                Console.Write(" ");
                            }
                        }
                       Console.ResetColor();
                        Console.WriteLine("│");
                        num2 = 0;
                    }
                    // ve bang thong bao
                    Console.Write("└");
                    for (int i2 = 0; i2 < numW; i2++)
                    {
                        Console.Write("─");
                    }
                    Console.WriteLine("┘");
                }
                str = "";
               Console.ResetColor();
                Console.Write("BAN CO ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("{0}", ttl.DemKyTuTrongFile(b + "/ThongBaoTTL/thongbao", "#"));
               Console.ResetColor();
                Console.Write(" THONG BAO TTL>");
                strS = Console.ReadLine();
                strS = strS.ToLower().Replace(" ", "");
                // xoa thong bao
                if (strS == "delete")
                {
                    File.Delete(b + "/ThongBaoTTL/thongbao");
                    // tao file chua du lieu
                    ttl.TaoFile(b + "/ThongBaoTTL/thongbao");
                }
            } while (strS != "exit");

        }
        // HTML FOR TABLE
        public static void HTMLForTable(string c, string linkTKB, string nameTable, int numLine2)
        {
            int numtd = 0;
            int iNumPer1, iNumPer2 = 0;
            int iNumTrue, iNumFasle = 0;
            int iNumLine1, iNumLine2 = 0;
            int numLine1 = 0;
            bool bShowNameTable = true;
            // goi tro giup
            HelpTTL ttl = new HelpTTL();
            // tao thu muc va cac file de chay html
            ttl.TaoThuMuc(linkTKB + nameTable + "/HTML");
            ttl.TaoFile(linkTKB + nameTable + "/HTML/table.html");
            ttl.TaoFile(linkTKB + nameTable + "/HTML/styles.css");
            // cau truy van percent?
            // lay du lieu percent
            iNumPer1 = ttl.LayDuLieuTrongFile(linkTKB + nameTable + "/Percent/Column1.txt");
            iNumPer2 = ttl.LayDuLieuTrongFile(linkTKB + nameTable + "/Percent/Column2.txt");
            // lay du lieu percent
            iNumTrue = ttl.LayDuLieuTrongFile(linkTKB + nameTable + "/TrueFalse/Column1.txt");
            iNumFasle = ttl.LayDuLieuTrongFile(linkTKB + nameTable + "/TrueFalse/Column2.txt");
            // Menu
            Console.WriteLine("[1]OPEN SOURCE");
            Console.WriteLine("[2]OPEN FILE HTML");
            Console.WriteLine("[3]OPEN FILE CSS");
            c = Console.ReadLine();
            // mo nguon
            if (c == "1")
            {
                // mo nguon
                ttl.MoDuongDan(linkTKB + nameTable + "/HTML");
            }
            // mo file css
            if (c == "3")
            {
                // tao file neu file chua ton tai
                ttl.TaoFile(linkTKB + nameTable + "/HTML/styles.css");
                // mo file
                ttl.MoDuongDan(linkTKB + nameTable + "/HTML/styles.css");
            }
            // mo web
            if (c == "2")
            {
                Console.WriteLine("[1]ELSE");
                Console.WriteLine("[2]ALL LINE");
                c = Console.ReadLine();
                // all line
                if(c == "1"){
                    Console.Write("LINE 1> ");
                    int.TryParse(Console.ReadLine(), out iNumLine1);
                    Console.Write("LINE 2> ");
                    int.TryParse(Console.ReadLine(), out iNumLine2);
                    // gan so
                    numLine1 = iNumLine1;
                    numLine2 = iNumLine2;
                }
                // HTML
                // neu duong dan co ton tai
                if (File.Exists(linkTKB + nameTable + "/HTML/table.html") == true)
                {
                    // xoa du lieu trong file
                    File.Delete(linkTKB + nameTable + "/HTML/table.html");
                    // tao file moi
                    ttl.TaoFile(linkTKB + nameTable + "/HTML/table.html");
                    // lay so cot trong file name
                    numtd = ttl.DemSoDongTrongFile(linkTKB + nameTable + "/Name/name.txt");
                    TextWriter txF = new StreamWriter(linkTKB + nameTable + "/HTML/table.html", true);
                    // web
                    txF.Write("<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"> <title>{0}</title><!-- ket noi css --><link rel=\"stylesheet\" href=\"styles.css\"><!-- doi hinh nen cho tab --><link rel=\"shortcut icon\" href=\"iconimages.jpg\" type=\"image/x-icon\"></head><body> <div id=\"content\" class=\"container\"><table>", nameTable);
                    // <tr></tr>
                    // all line
                    for (int i = numLine1; i <= numLine2 + 1; i++)
                    {
                        // <td></td>
                        // ghi ten cot
                        if (File.Exists(linkTKB + nameTable + "/Name/name.txt") == true && bShowNameTable == true)
                        {
                            // tr
                            txF.Write("<tr>");
                            for (int i1 = 0; i1 < numtd; i1++)
                            {
                                // td
                                txF.Write("<th>");
                                // content
                                txF.Write(ttl.TraDuLieuSoNDongTrongFile(linkTKB + nameTable + "/Name/name.txt", i1 + 1));
                                // td
                                txF.Write("</th>");
                            }
                            // </tr>
                            txF.Write("</tr>");
                            bShowNameTable = false;
                        }
                        // ghi noi dung trong cot
                        if (File.Exists(linkTKB + nameTable + "/line" + i + ".txt") == true && bShowNameTable == false)
                        {
                            // tr
                            txF.Write("<tr>");
                            for (int i1 = 0; i1 < numtd; i1++)
                            {
                                // td
                                txF.Write("<td>");
                                // content
                                // cau truy van when?
                                if (ttl.TraDuLieuSoNDongTrongFile(linkTKB + nameTable + "/line" + i + ".txt", i1 + 1) == "when?")
                                {
                                    FileInfo fIn = new FileInfo(linkTKB + nameTable + "/line" + i + ".txt");
                                    txF.Write("{0}", ttl.TraVeDuLieuThoiGian(ttl.TinhNgay(fIn.CreationTime.Day, fIn.CreationTime.Month, fIn.CreationTime.Year, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year)));
                                }
                                // cau truy van percent?
                                if (ttl.TraDuLieuSoNDongTrongFile(linkTKB + nameTable + "/line" + i + ".txt", i1 + 1) == "percent?")
                                {
                                    txF.Write(ttl.PercentInTable(linkTKB + nameTable + "/line" + i + ".txt", iNumPer1, iNumPer2) + "%(" + (int)ttl.PercentInTable(linkTKB + nameTable + "/line" + i + ".txt", iNumPer1, iNumPer2) / 100 + ")");
                                }
                                // cau truy van truefalse?
                                if (ttl.TraDuLieuSoNDongTrongFile(linkTKB + nameTable + "/line" + i + ".txt", i1 + 1) == "truefalse?")
                                {
                                    txF.Write(ttl.TrueFalse(linkTKB + nameTable + "/line" + i + ".txt", iNumTrue, iNumFasle).ToUpper());
                                }
                                // truy cap du lieu file
                                if ((File.Exists(ttl.TraDuLieuSoNDongTrongFile(linkTKB + nameTable + "/line" + i + ".txt", i1 + 1)) == true))
                                {
                                    txF.Write(ttl.LayDuLieuTrongFileStr(ttl.TraDuLieuSoNDongTrongFile(linkTKB + nameTable + "/line" + i + ".txt", i1 + 1)));
                                }
                                // khac
                                else
                                {
                                    txF.Write(ttl.TraDuLieuSoNDongTrongFile(linkTKB + nameTable + "/line" + i + ".txt", i1 + 1));
                                }
                                // td
                                txF.Write("</td>");
                            }
                            // them so dong
                            txF.Write("<td>" + i + "</td>");
                            // </tr>
                            txF.Write("</tr>");
                        }
                    }
                    // web
                    txF.Write("</table>");
                    txF.Write("</body>");
                    txF.Write("</html>");
                    txF.Close();
                }
                // mo file
                ttl.MoDuongDan(linkTKB + nameTable + "/HTML/table.html");
            }
            // Console.Write(c + " - " + linkTKB + " - " + nameTable);
            // Console.ReadKey();
        }
        // lop tro giup nang cap ttl
        public class HelpTTL
        {
            // fileds
            private string _tenThongBao;
            private string _thongBao;
            private string _nameFile;
            private int _num;
            private static int _numCount;

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
            public string ThongBao
            {
                get
                {
                    return _thongBao;
                }
                set
                {
                    _thongBao = value;
                }
            }
            public string NameFile
            {
                get
                {
                    return _nameFile;
                }
                set
                {
                    _nameFile = value;
                }
            }
            public string TenThongBao
            {
                get
                {
                    return _tenThongBao;
                }
                set
                {
                    _tenThongBao = value;
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
            // methods
            // phương thức khởi tạo không tham số
            public HelpTTL()
            {
                _thongBao = "ERROR!";
                _nameFile = "";
                _tenThongBao = "ERROR!";
                _num = 16;
            }
            //phương thức khởi tạo có nhieu tham số
            public HelpTTL(string tenThongBao, string thongBao, int num, string nameFile)
            {
                _thongBao = thongBao;
                _nameFile = nameFile;
                _tenThongBao = tenThongBao;
                _num = num;
            }
            // phuong thuc tao file
            public void TaoFile(string duongDanDenThuMuc, string tenFile)
            {
                // kiem tra file da ton tai
                if (File.Exists(duongDanDenThuMuc + "/" + tenFile) == false)
                {
                    // tao file
                    FileStream fileNew = new FileStream(duongDanDenThuMuc + "/" + tenFile, FileMode.Create);
                    fileNew.Close();
                }
            }
            // TAO FILE VA ghi du lieu vao file
            public void TaoFile(string duongDanDenThuMuc, int tenFile)
            {
                // kiem tra file da ton tai
                if (File.Exists(duongDanDenThuMuc + "/" + tenFile) == false)
                {
                    // tao file
                    FileStream fileNew = new FileStream(duongDanDenThuMuc + "/" + tenFile, FileMode.Create);
                    fileNew.Close();
                }
            }
            public void TaoFile(string duongDanDenFile)
            {
                // kiem tra file da ton tai
                if (File.Exists(duongDanDenFile) == false)
                {
                    // tao file
                    FileStream fileNew = new FileStream(duongDanDenFile, FileMode.Create);
                    fileNew.Close();
                }
            }
            public void TaoFileVaGhiDuLieu(string duongDanDenFile, string str)
            {
                // kiem tra file da ton tai
                if (File.Exists(duongDanDenFile) == false)
                {
                    // tao file
                    FileStream fileNew = new FileStream(duongDanDenFile, FileMode.Create);
                    fileNew.Close();
                    // ghi du lieu vao file
                    TextWriter txF = new StreamWriter(duongDanDenFile, false);
                    txF.WriteLine(str);
                    txF.Close();
                }
            }
            // ghi du lieu vao file
            public void GhiDuLieuVaoFile(string tenFile, int duLieu, bool ghiFileMoi)
            {
                // neu file co ton tai va 
                if (File.Exists(tenFile) == true)
                {
                    TextWriter ttlile = new StreamWriter(tenFile, ghiFileMoi);
                    ttlile.WriteLine(duLieu);
                    ttlile.Close();
                }
                
            }
            public void GhiDuLieuVaoFile(string tenFile, string duLieu, bool ghiFileMoi)
            {
                // neu file co ton tai va 
                if (File.Exists(tenFile) == true)
                {
                    TextWriter ttlile = new StreamWriter(tenFile, ghiFileMoi);
                    ttlile.WriteLine(duLieu);
                    ttlile.Close();
                // 
                }
               
            }
            public void Write(string duongDanDenFile, string duLieu)
            {
                if (File.Exists(duongDanDenFile) == true && duongDanDenFile.Replace(" ", "") != "")
                {
                    TextWriter tx = new StreamWriter(duongDanDenFile, true);
                    tx.Write(duLieu);
                    tx.Close();
                }
            }
            public void WriteLine(string duongDanDenFile, string duLieu)
            {
                if (File.Exists(duongDanDenFile) == true && duongDanDenFile.Replace(" ", "") != "")
                {
                    TextWriter tx = new StreamWriter(duongDanDenFile, true);
                    tx.WriteLine(duLieu);
                    tx.Close();
                }

            }
            // phuong thuc dem so dong trong file
            public int DemSoDongTrongFile(string nameFile)
            {
                _numCount = 0;
                string[] readFile = File.ReadAllLines(nameFile);
                foreach (string lines in readFile)
                {
                    _numCount++;
                }
                return _numCount;
            }
            // lay du lieu trong file
            public int LayDuLieuTrongFile(string duongDanDenThuMuc, string tenFile)
            {
                int num = 0;
                // neu file co ton tai
                if (File.Exists(duongDanDenThuMuc + "/" + tenFile) == true)
                {
                    string[] readFile = File.ReadAllLines(duongDanDenThuMuc + "/" + tenFile);
                    foreach (string lines in readFile)
                    {
                        num = int.Parse(lines);
                    }
                }
                return num;
            }
            public int LayDuLieuTrongFile(string duongDanDenFile)
            {
                int num = 0;
                // neu file co ton tai
                if (File.Exists(duongDanDenFile) == true)
                {
                    string[] readFile = File.ReadAllLines(duongDanDenFile);
                    foreach (string lines in readFile)
                    {
                        num = int.Parse(lines);
                    }
                }
                return num;
            }
            public string LayDuLieuTrongFile1(string duongDanDenFile)
            {
                string str = "";
                // neu file co ton tai
                if (File.Exists(duongDanDenFile) == true)
                {
                    string[] readFile = File.ReadAllLines(duongDanDenFile);
                    foreach (string lines in readFile)
                    {
                        str = lines;
                    }
                }
                return str;
            }
            public string LayDuLieuTrongFileStr(string duongDanDenFile)
            {
                string str = "";
                // neu file co ton tai
                if (File.Exists(duongDanDenFile) == true)
                {
                    string[] readFile = File.ReadAllLines(duongDanDenFile);
                    foreach (string lines in readFile)
                    {
                        str = str + lines;
                    }
                }
                return str;
            }
            // tinh ngay
            public int TinhNgay(int dayS, int monthS, int yearS, int dayE, int monthE, int yearE)
            {
                int dem = 0;
                try
                {
                    var datS = new DateTime(yearS, monthS, dayS);
                    var datE = new DateTime(yearE, monthE, dayE);
                    for (int ctr = 0; ctr <= ctr + 1; ctr++)
                    {
                        //hi?n ng?y
                        //Console.WriteLine(dat.AddDays(ctr).ToString("d"));
                        //?i?u ki?n d?ng v?ng l?pyp
                        if (datS.AddDays(ctr).Day == datE.Day && datS.AddDays(ctr).Month == datE.Month && datS.AddDays(ctr).Year == datE.Year)
                        {
                            break;
                        }
                        //??m s? ng?y
                        dem++;
                    }
                }
                catch
                {

                }
                return dem;
            }
            // Tao thu muc
            public void TaoThuMuc(string duongDanDenThuMuc)
            {
                if (Directory.Exists(duongDanDenThuMuc) == false)
                {
                    DirectoryInfo nD = new DirectoryInfo(duongDanDenThuMuc);
                    nD.Create();
                }
            }
            // hien thi du lieu trong 1 file vs khoang cach va tu dong xuong dong
            public void HienThiDuLieuTrongFile(string duongDanDenFile, int khoangCach, int khoangRongHienThi, string space)
            {
                string data = "";
                int num = 0;
                // neu file co ton tai
                if (File.Exists(duongDanDenFile) == true)
                {
                    string[] rF = File.ReadAllLines(duongDanDenFile);
                    if (khoangRongHienThi > 0)
                    {
                        foreach (string lines in rF)
                        {
                            data = data + lines;
                        }
                        // tao khoang cach
                        for (int i = 0; i <= khoangCach; i++)
                        {
                            if (khoangCach != 0)
                                Console.Write(" ");
                            if (khoangCach == 0)
                                Console.Write("");
                        }
                        foreach (char ch in data)
                        {
                            num++;
                            Console.Write(ch);
                            if (num % khoangRongHienThi == 0)
                            {
                                Console.WriteLine();
                                // tao khoang cach
                                for (int i = 0; i <= khoangCach; i++)
                                {
                                    if (khoangCach != 0)
                                        Console.Write(" ");
                                    if (khoangCach == 0)
                                        Console.Write("");
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (string lines in rF)
                        {
                            Console.Write(lines + space);
                        }
                    }
                }
            }
            // den so ky tu trong file
            public int DemKyTuTrongFile(string duongDanDenFile)
            {
                string data = "";
                // neu file co ton tai
                if (File.Exists(duongDanDenFile) == true)
                {
                    string[] rF = File.ReadAllLines(duongDanDenFile);
                    foreach (string item in rF)
                    {
                        data = data + item;
                    }
                }
                return data.Length;
            }
            // dem so ky tu can tim trong file
            public int DemKyTuTrongFile(string duongDanDenFile, string kyTuCanTim)
            {
                int num = 0;
                // neu file co ton tai
                if (File.Exists(duongDanDenFile) == true)
                {
                    string[] rF = File.ReadAllLines(duongDanDenFile);
                    foreach (string item in rF)
                    {
                        if (kyTuCanTim.ToLower().Replace(" ", "") == item.ToLower().Replace(" ", ""))
                            num++;
                    }
                }
                return num;
            }
            // mo duong dan
            public string MoDuongDan(string duongDan)
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
                return duongDan;
            }
            // loc ky tu 1
            public string Loc1KyTu(string str, string strSoSanh1)
            {
                string chu = "";
                string chu1 = "";
                int xacNhan = 0;
                //neu ten bang khac rong
                if (str != "")
                {
                    //loc ky tu
                    foreach (char ch in str)
                    {
                        //cong chuoi
                        chu = chu + ch;
                        if (xacNhan == 1)
                        {
                            chu1 = chu1 + ch;
                        }
                        //tim kiem tu khoa
                        if (chu == strSoSanh1)
                        {
                            //Console.ForegroundColor = ConsoleColor.Green;
                            //Console.WriteLine(chu);
                            //Console.ForegroundColor = ConsoleColor.Gray;
                            xacNhan = 1;
                        }
                    }
                }
                return chu1;
            }
            // loc ky tu 2
            public string Loc2KyTu(string str, string strSoSanh1, string strSoSanh2)
            {
                string chu = "";
                string chu1 = "";
                int xacNhan = 0;
                //neu ten bang khac rong
                if (str != "")
                {
                    //loc ky tu
                    foreach (char ch in str)
                    {
                        //cong chuoi
                        chu = chu + ch;
                        if (xacNhan == 1)
                        {
                            chu1 = chu1 + ch;
                        }
                        //tim kiem tu khoa
                        if (chu == strSoSanh1 || chu == strSoSanh2)
                        {
                            //Console.ForegroundColor = ConsoleColor.Green;
                            //Console.WriteLine(chu);
                            //Console.ForegroundColor = ConsoleColor.Gray;
                            xacNhan = 1;
                        }
                    }
                }
                return chu1;
            }
            // tao mau cho table
            public void ColorTTL(string color)
            {
                color = color.ToLower().Replace(" ", "");
               Console.ResetColor();
                if (color == "black" || color == "1")
                    Console.ForegroundColor = ConsoleColor.Black;
                if (color == "green" || color == "2")
                    Console.ForegroundColor = ConsoleColor.Green;
                if (color == "darkgreen" || color == "3")
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (color == "red" || color == "4")
                    Console.ForegroundColor = ConsoleColor.Red;
                if (color == "darkred" || color == "5")
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                if (color == "blue" || color == "6")
                    Console.ForegroundColor = ConsoleColor.Blue;
                if (color == "darkblue" || color == "7")
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (color == "gray" || color == "8")
                   Console.ResetColor();
                if (color == "darkgray" || color == "9")
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                if (color == "magenta" || color == "10")
                    Console.ForegroundColor = ConsoleColor.Magenta;
                if (color == "darkmagenta" || color == "11")
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                if (color == "yellow" || color == "12")
                    Console.ForegroundColor = ConsoleColor.Yellow;
                if (color == "darkyellow" || color == "13")
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (color == "cyan" || color == "14")
                    Console.ForegroundColor = ConsoleColor.Cyan;
                if (color == "darkcyan" || color == "15")
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                if (color == "white" || color == "16")
                    Console.ForegroundColor = ConsoleColor.White;
            }
            // to mau cho tung chu
            public void Rainbow(string color, string data, string link)
            {
                // lay cac file trong thu muc
                string[] gF = Directory.GetFiles(link);
                foreach (string file in gF)
                {
                    // doc du lieu trong file
                    string[] rF = File.ReadAllLines(file);
                    foreach (string lines in rF)
                    {
                        if (data.ToLower().Replace(" ", "") == lines.ToLower().Replace(" ", ""))
                        {
                            FileInfo nameF = new FileInfo(file);
                            color = nameF.Name;
                        }

                    }
                }
                color = color.ToLower().Replace(" ", "");
               Console.ResetColor();
                if (color == "black")
                    Console.ForegroundColor = ConsoleColor.Black;
                if (color == "green")
                    Console.ForegroundColor = ConsoleColor.Green;
                if (color == "darkgreen")
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                if (color == "red")
                    Console.ForegroundColor = ConsoleColor.Red;
                if (color == "darkred")
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                if (color == "blue")
                    Console.ForegroundColor = ConsoleColor.Blue;
                if (color == "darkblue")
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                if (color == "gray")
                   Console.ResetColor();
                if (color == "darkgray")
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                if (color == "magenta")
                    Console.ForegroundColor = ConsoleColor.Magenta;
                if (color == "darkmagenta")
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                if (color == "yellow")
                    Console.ForegroundColor = ConsoleColor.Yellow;
                if (color == "darkyellow")
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                if (color == "cyan")
                    Console.ForegroundColor = ConsoleColor.Cyan;
                if (color == "darkcyan")
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                if (color == "white")
                    Console.ForegroundColor = ConsoleColor.White;
            }
            // xoa thong tin ra khoi file trong thu muc cung cap
            public void XoaChuTrongFileTrongThuMucCungCap(string data, string link)
            {
                data = data.Replace(" ", "").ToLower();
                // lay file trong thu muc
                string[] gF = Directory.GetFiles(link);
                foreach (string file in gF)
                {
                    // tao 1 file khac file ddau
                    FileStream fN = new FileStream(file + ".ttl", FileMode.Create);
                    fN.Close();
                    // ghi du lieu vao file moi
                    TextWriter tF = new StreamWriter(file + ".txt", true);
                    // doc du lieu trong file
                    string[] rF = File.ReadAllLines(file);
                    foreach (string lines in rF)
                    {
                        // ghi du lieu tu file cu~ vao file neu khac thong tin
                        if (data != lines.Replace(" ", "").ToLower())
                            tF.WriteLine(lines);
                    }
                    tF.Close();
                    // xoa file cu~
                    File.Delete(file);
                    // chuyen file moi thanh file cu~
                    File.Move(file + ".txt", file);
                }
                // xoa cac file co chua duoi
                // lay file trong thu muc
                string[] gF1 = Directory.GetFiles(link);
                foreach (string file in gF1)
                {
                    FileInfo gFile = new FileInfo(file);
                    if (gFile.Extension == ".ttl")
                        File.Delete(file);
                }
                // xoa cac file khac ten file mau sac
                string[] gF2 = Directory.GetFiles(link);
                foreach (string file in gF2)
                {
                    FileInfo gFile = new FileInfo(file);
                    if (gFile.Name.Replace(" ", "").ToLower() != "black" && gFile.Name.Replace(" ", "").ToLower() != "green" && gFile.Name.Replace(" ", "").ToLower() != "darkgreen" && gFile.Name.Replace(" ", "").ToLower() != "red" && gFile.Name.Replace(" ", "").ToLower() != "darkred" && gFile.Name.Replace(" ", "").ToLower() != "blue" && gFile.Name.Replace(" ", "").ToLower() != "darkblue" && gFile.Name.Replace(" ", "").ToLower() != "gray" && gFile.Name.Replace(" ", "").ToLower() != "darkgray" && gFile.Name.Replace(" ", "").ToLower() != "magenta" && gFile.Name.Replace(" ", "").ToLower() != "darkmagenta" && gFile.Name.Replace(" ", "").ToLower() != "cyan" && gFile.Name.Replace(" ", "").ToLower() != "darkcyan" && gFile.Name.Replace(" ", "").ToLower() != "white" && gFile.Name.Replace(" ", "").ToLower() != "yellow" && gFile.Name.Replace(" ", "").ToLower() != "darkyellow")
                        File.Delete(file);
                }
            }
            // menu for table
            public void MenuForTable(int numLineTable, string link, int dem, int numExit, int saveFile, int demSpace1, int numSpace, string linkSet1, int demChar1, string sLine, string sLine1, int xacNhan, string cc)
            {
                numLineTable = 0;
                string linePin = " MENU\n";
                string[] Folder1 = Directory.GetFiles(link);
                foreach (string files in Folder1)
                {
                    numLineTable++;
                    dem++;
                    //neu file la file du lieu
                    //neu duong dan khonng ton tai thay doi cac dong lon hon tro ve voi can bang
                    if (File.Exists(link + "line" + dem + ".txt") == false)
                    {
                        saveFile = dem;
                        do
                        {
                            //neu file lon hon file hien tai co ton tai(dong tiep theo co ton tai)
                            if (File.Exists(link + "line" + (dem + 1) + ".txt") == true)
                            {
                                File.Move(link + "line" + (dem + 1) + ".txt", link + "line" + (dem) + ".txt");
                                numExit = 0;
                                dem++;
                            }
                            //neu dong ke tiep khong ton tai
                            if (File.Exists(link + "line" + (dem + 1) + ".txt") == false)
                                numExit = 1;
                        } while (numExit == 0);
                        // Console.ReadKey();
                        //dem = saveFile;
                    }
                    if (File.Exists(link + "line" + (dem - 1) + ".txt") == true)
                    {
                        //hien thi thong tin trong file
                        string[] fileContent = File.ReadAllLines(link + "line" + (dem - 1) + ".txt");
                        foreach (string lines in fileContent)
                        {
                            //hien thi thong tin bang
                            //neu dong trong file bang voi c tien hanh hien noi thong
                            //chuyen thong tin in hoa thanh in thuong
                            sLine = lines;
                            sLine1 = lines;
                            sLine = sLine.ToLower();
                            sLine1 = sLine1.ToLower();
                            sLine1 = sLine1.Replace(" ", "");
                            //doc du lieu trong file pin
                            string[] filePin = File.ReadAllLines(link + "Pin/Pin");
                            foreach (string linesPin in filePin)
                            {
                                //neu dong pin == voi dong hien tai thi doi xac nhan = 1
                                if (sLine1 == linesPin)
                                    linePin = linePin + "|" + lines + " [" + (numLineTable - 1) + "]\n";
                            }
                        }
                    }
                    demSpace1 = 0;
                }
                Console.WriteLine(linePin);
            }
            // hien thi du lieu trong file pin
            public void DuLieuPin(string link)
            {
                if (File.Exists(link + "Pin/Pin") == true)
                {
                    Console.WriteLine(" PIN");
                    //doc du lieu trong file pin
                    string[] filePin = File.ReadAllLines(link + "Pin/Pin");
                    foreach (string linesPin in filePin)
                    {
                        Console.WriteLine("|" + linesPin);
                    }
                }
            }
            // hien thi du lieu trong file
            public void ShowFileTTL(string link, string nameFile, string colorTable)
            {
                //table
                int numTable = 0;
                int maxTable = 0;
                int num1Table = 0;
                int numNullTable = 0;
                int timesTable = 0;
                int canhGiuaTable = 0;
                string nameTable1 = "";
                int numLineTable = 0;
                if (Directory.Exists(link) == true)
                {
                    try
                    {
                        //n?u file có t?n t?i
                        if (File.Exists(link + "\\name.bsx") == true)
                        {
                            string[] name = File.ReadAllLines(link + "\\name.bsx");
                            foreach (string nameT in name)
                            {
                                //màu
                                if (colorTable == "1")
                                    Console.ForegroundColor = ConsoleColor.Green;
                                if (colorTable == "2")
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                if (colorTable == "3")
                                    Console.ForegroundColor = ConsoleColor.Red;
                                nameTable1 = nameT;
                            }
                        }
                        string[] lineTable = File.ReadAllLines(link + "/" + nameFile);
                        //ki?m tra giá tr? max trong tên c?a b?ng
                        foreach (char ch in nameTable1)
                        {
                            num1Table++;
                            if (num1Table > maxTable)
                            {
                                maxTable = num1Table;
                            }
                        }
                        do
                        {
                            //th?c hi?n tên c?a b?ng sau 1 l?n
                            if (timesTable == 1)
                            {
                                //canh gi?a cho b?ng
                                if (maxTable <= numLineTable)
                                {
                                    canhGiuaTable = numLineTable - maxTable;
                                    canhGiuaTable = canhGiuaTable / 2;
                                    for (int cg = 0; cg <= canhGiuaTable; cg++)
                                    {
                                        Console.Write(" ");
                                    }
                                }
                                Console.Write("|");
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write(nameTable1);
                                //t?o kho?ng tr?ng
                                for (int i = 0; i < maxTable - num1Table; i++)
                                {
                                    Console.Write(" ");
                                }
                                //ch?n màu cho b?ng
                                if (numNullTable == 0)
                                {
                                    //n?u d? li?u r?ng
                                    Console.ForegroundColor = ConsoleColor.Black;
                                }
                                if (numNullTable != 0)
                                {
                                    //màu
                                    if (colorTable == "1")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;

                                    }
                                    if (colorTable == "2")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                    }
                                    if (colorTable == "3")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                }
                                Console.Write("|");
                                //?i?u ki?n canh ??
                                if (maxTable != 78)
                                {
                                    Console.WriteLine();
                                }

                            }
                            foreach (string s in lineTable)
                            {
                                numNullTable++;
                                numTable = 0;
                                //t?m giá tr? l?n nh?t trong d?ng
                                foreach (char ch in s)
                                {
                                    numTable++;
                                    if (numTable > maxTable)
                                    {
                                        maxTable = numTable;
                                    }
                                }
                                //th?c hi?n thông tin c?a b?ng sau 2 l?n
                                if (timesTable == 2)
                                {
                                    //canh gi?a cho b?ng
                                    if (maxTable <= numLineTable)
                                    {
                                        canhGiuaTable = numLineTable - maxTable;
                                        canhGiuaTable = canhGiuaTable / 2;
                                        for (int cg = 0; cg <= canhGiuaTable; cg++)
                                        {
                                            Console.Write(" ");
                                        }
                                    }
                                    Console.Write("|");
                                   Console.ResetColor();
                                    if (colorTable == "7")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                    }
                                    Console.Write(s);
                                    if (colorTable == "7")
                                    {
                                        Console.BackgroundColor = ConsoleColor.Black;
                                    }
                                    //ch?n màu cho b?ng
                                    //màu
                                    if (colorTable == "1")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                    }
                                    if (colorTable == "2")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                    }
                                    if (colorTable == "3")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }
                                    if (numTable == maxTable)
                                    {
                                        Console.Write("");
                                    }
                                    //t?o kho?ng tr?ng 
                                    for (int i = 0; i < maxTable - numTable; i++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write("|");
                                    //?i?u ki?n canh ??
                                    if (maxTable != 78)
                                    {
                                        Console.WriteLine();
                                    }
                                }
                            }
                            ////ch?n màu cho b?ng
                            if (numNullTable == 0)
                            {
                                //n?u d? li?u r?ng
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            if (numNullTable != 0)
                            {
                                //màu
                                if (colorTable == "1")
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                if (colorTable == "2")
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                }
                                if (colorTable == "3")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                }
                            }
                            //canh gi?a cho b?ng
                            if (maxTable <= numLineTable)
                            {
                                canhGiuaTable = numLineTable - maxTable;
                                canhGiuaTable = canhGiuaTable / 2;
                                for (int cg = 0; cg <= canhGiuaTable; cg++)
                                {
                                    Console.Write(" ");
                                }
                            }
                            //th?c hi?n t?o ???ng ngang d?a trên s? max
                            if (timesTable == 0)
                            {
                                Console.Write(" ");
                            }
                            if (timesTable == 1)
                            {
                                Console.Write("|");
                            }
                            if (timesTable == 2)
                            {
                                Console.Write("|");
                            }
                            for (int i = 0; i < maxTable; i++)
                            {

                                if (timesTable == 1)
                                {
                                    Console.Write("-");
                                }
                                else
                                {
                                    Console.Write("_");
                                }
                            }
                            if (timesTable == 0)
                            {
                                Console.Write("");
                            }
                            if (timesTable == 1)
                            {
                                Console.Write("|");
                            }
                            if (timesTable == 2)
                            {
                                Console.Write("|");
                            }
                            Console.WriteLine();
                            timesTable++;
                        } while (timesTable < 3);
                        //thi?t l?p giá tr? ban ??u
                        numTable = 0;
                        num1Table = 0;
                        maxTable = 0;
                        timesTable = 0;
                        canhGiuaTable = 0;
                        numNullTable = 0;
                    }
                    catch (Exception a)
                    {
                        Console.WriteLine(a.Message);
                        Console.ReadKey();
                    }
                }
            }
            // hien thi thong tin trong file vs khoang cach han che
            public void ShowFileWithSpace(int numSum, int numFirst, int numLast, int numShow, string strShow)
            {
                //hien thi cac trang con lai vs khoang cach 10 trang dau va 10 trang cuoi
                for (int i = 1; i <= numSum; i++)
                {
                    //neu i dang o vi tri trang
                    if (i == numShow)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[ {0} ]", strShow.ToUpper());
                       Console.ResetColor();
                    }
                    //hien thi cac trang con lai vs khoang cach 10 trang dau va 10 trang cuoi
                    if (i >= (numShow - numFirst) && i < (numShow + numLast) && i != numShow)
                    {
                        Console.Write(" {0} ", i);
                    }
                }
                // hien thi trang cuoi
                if (numSum - numShow >= 10)
                    Console.Write("...[{0}]", numSum);
            }
            // kiem tra du lieu trong file
            public bool KiemTraDuLieuTrongFile(string linkFile, string strCheck)
            {
                bool tF = false;
                // neu file co ton tai
                if (File.Exists(linkFile) == true)
                {
                    // doc du lieu trong file
                    string[] rF = File.ReadAllLines(linkFile);
                    foreach (string lines in rF)
                    {
                        if (lines.Replace(" ", "").ToLower() == strCheck.Replace(" ", "").ToLower())
                        {
                            tF = true;
                            break;
                        }
                    }
                }
                return tF;
            }
            // tra ve so dong trong file
            public int TraVeSoDongTrongFile(string linkFile, string strCheck)
            {
                int numLine = 0;
                int num = 0;
                // neu file co ton tai
                if (File.Exists(linkFile) == true)
                {
                    // doc du lieu trong file
                    string[] rF = File.ReadAllLines(linkFile);
                    foreach (string lines in rF)
                    {
                        if (lines.Replace(" ", "").ToLower() == strCheck.Replace(" ", "").ToLower())
                        {
                            numLine = num;
                        }
                        num++;
                    }
                }
                return numLine;
            }
            // tra du lieu cua so n dong trong file
            public string TraDuLieuSoNDongTrongFile(string linkFile, int soDong)
            {
                int num = 0;
                string str = "";
                // neu file co ton tai
                if (File.Exists(linkFile) == true)
                {
                    // doc du lieu trong file
                    string[] rF = File.ReadAllLines(linkFile);
                    foreach (string lines in rF)
                    {
                        num++;
                        if (num == soDong)
                        {
                            return lines;
                        }
                    }
                }
                return str;
            }
            // ghi du lieu vao file o vi tri thu n
            public void GhiDuLieuVaoFileOViTriThuN(string nameFile, int viTriThayDoi, string strDongMoi)
            {
                int numRunFileLine = 0;
                string newF = nameFile + "NewFileFromTTL";
                // tao file moi
                FileStream fN = new FileStream(newF, FileMode.Create);
                fN.Close();
                // ghi du lieu vao file
                TextWriter txF = new StreamWriter(newF, true);
                //hien thi thong tin cua file
                string[] showFileLineInColumn = File.ReadAllLines(nameFile);
                foreach (string linesColumn in showFileLineInColumn)
                {
                    if (numRunFileLine == viTriThayDoi)
                        txF.WriteLine(strDongMoi);
                    if (numRunFileLine != viTriThayDoi)
                        txF.WriteLine(linesColumn);
                    numRunFileLine++;
                }
                txF.Close();
                // xoa file
                File.Delete(nameFile);
                // doi file moi thanh file cu~
                File.Move(newF, nameFile);
            }
            //ghi du lieu tu file1 den file1
            public void GhiDuLieuTuFileDenFile(string nameFile1, string nameFile2, bool ghiTiep)
            {
                // neu file 1 va file 2 co ton tai
                if (File.Exists(nameFile1) == true && File.Exists(nameFile2) == true)
                {
                    // ghi tiep vao file
                    if (ghiTiep == true)
                    {
                        TextWriter txF2 = new StreamWriter(nameFile2, true);
                        string[] rF1 = File.ReadAllLines(nameFile1);
                        foreach (string lines in rF1)
                        {
                            txF2.WriteLine(lines);
                        }
                        txF2.Close();
                    }
                    // ghi moi file
                    if (ghiTiep == false)
                    {
                        FileStream fN2 = new FileStream(nameFile2, FileMode.Create);
                        fN2.Close();
                        TextWriter txF2 = new StreamWriter(nameFile2, true);
                        string[] rF1 = File.ReadAllLines(nameFile1);
                        foreach (string lines in rF1)
                        {
                            txF2.WriteLine(lines);
                        }
                        txF2.Close();
                    }
                }
            }
            // tim max
            public long TimMax(long numSoSanh, long numTraVe)
            {
                if (numSoSanh >= numTraVe)
                    numTraVe = numSoSanh;
                return numTraVe;
            }
            // tim min
            public long TimMin(long numSoSanh, long numTraVe)
            {
                if (numTraVe == 0)
                    numTraVe = numSoSanh;
                if (numSoSanh > 0 || numSoSanh < 0)
                    if (numSoSanh <= numTraVe)
                        numTraVe = numSoSanh;
                return numTraVe;
            }
            // bot
            public void FeelingBot(string strFeeling)
            {
                Console.Clear();
                Console.WriteLine("  ___");
                Console.WriteLine("<|{0}-{1}|> ", strFeeling, strFeeling);
                Console.Write("  /*\\");
            }
            //dem file trong thu muc
            public int DemFileTrongThuMuc(string nameFolder)
            {
                int num = 0;
                if (Directory.Exists(nameFolder) == true)
                {
                    string[] gF = Directory.GetFiles(nameFolder);
                    foreach (string file in gF)
                    {
                        num++;
                    }
                }
                return num;
            }
            // tra ve du lieu thoi gian
            public string TraVeDuLieuThoiGian(int day)
            {
                string str = "";
                if (day < 7)
                    str = "~ " + day + " NGAY TRUOC ";
                else if (day < 31)
                    str = "~ " + day / 7 + " TUAN TRUOC ";
                else if (day < 366)
                    str = "~ " + day / 31 + " THANG TRUOC ";
                else if (day > 366)
                    str = "~ " + day / 366 + " NAM TRUOC ";
                return str;
            }
            // gate open
            public void TheGateIsOpen(int num, string nameFile, string name)
            {
                double numCh = 0;
                double numShow = 0;
                if (File.Exists(nameFile) == true)
                {
                    string[] rF = File.ReadAllLines(nameFile);
                    foreach (string lines in rF)
                    {
                        //doc tung ky tu
                        foreach (char ch in lines)
                        {
                            numCh++;
                        }
                    }
                    // Console.WriteLine(num);
                    // Console.WriteLine(numCh);
                    numShow = numCh / 100 * num;
                    // Console.WriteLine(numShow);
                    numCh = 0;
                    foreach (string lines in rF)
                    {
                        //doc tung ky tu
                        foreach (char ch in lines)
                        {
                            numCh++;
                            if (numCh <= numShow)
                                Console.ForegroundColor = ConsoleColor.Green;
                            if (numCh > numShow)
                                Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(ch);
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(" {0}%", num);
                        //Console.ResetColor();
                        // Console.WriteLine(" from -{0}-", name.ToUpper());
                    }
                   Console.ResetColor();
                    Console.WriteLine();
                }
            }
            // truy van table
            public bool TruyVanTable(string tenThuMuc, string str)
            {
                char yn = ' ';
                string strYN = "";
                string ss = "";
                bool rt = true;
                // neu thu muc chua cau truy van co ton tai
                if (Directory.Exists(tenThuMuc) == true && str.Replace(" ", "") != "")
                {
                    // lay cac thu muc trong thu muc chinh
                    string[] gD = Directory.GetDirectories(tenThuMuc);
                    foreach (string d in gD)
                    {
                        ss = "";
                        strYN = "";
                        // doc du lieu trong file du lieu truy van
                        if (File.Exists(d + "/question") == true)
                        {
                            string[] rF = File.ReadAllLines(d + "/question");
                            foreach (string r in rF)
                            {
                                Console.Write(r + "? [Y][N]");
                                char.TryParse(Console.ReadLine(), out yn);
                                strYN = strYN + yn;
                            }
                        }
                        // doc du lieu trong file yn
                        if (File.Exists(d + "/yn") == true)
                        {
                            string[] rF = File.ReadAllLines(d + "/yn");
                            foreach (string r in rF)
                            {
                                ss = r;
                            }
                        }
                        // so sanh du lieu
                        if (ss.ToLower().Replace(" ", "") != strYN.ToLower().Replace(" ", ""))
                        {
                            rt = false;
                        }
                        if (rt == false)
                            break;
                    }
                }
                if (Directory.Exists(tenThuMuc) == true && str.Replace(" ", "") == "")
                    rt = true;
                return rt;
            }
            public void ChuyenCho2File(string strNameFile1, string strNameFile2)
            {
                // neu 2 file co ton tai
                if (File.Exists(strNameFile1) == true && File.Exists(strNameFile2) == true)
                {
                    // copy file 1 thanh file 2 vs duoi .txt
                    File.Copy(strNameFile1, strNameFile2 + ".txt");
                    // copy file 2 thanh file 1 vs duoi .txt
                    File.Copy(strNameFile2, strNameFile1 + ".txt");
                    // xoa file 1 goc vs file 2 goc
                    File.Delete(strNameFile1);
                    File.Delete(strNameFile2);
                    // chuyen file 1 vs file 2 vs duoi .txt thanh file goc
                    File.Move(strNameFile1 + ".txt", strNameFile1);
                    File.Move(strNameFile2 + ".txt", strNameFile2);
                }
            }
            // copy thu muc (nguon INTERNET)
            public void DirectoryCopy(string sourceDir, string destDir)
            {
                DirectoryInfo dir = new DirectoryInfo(sourceDir);
                DirectoryInfo[] dirs = dir.GetDirectories();
                if (!dir.Exists)
                {
                    throw new DirectoryNotFoundException(
                        "Không tìm thấy thư mục: " + sourceDir);
                }
                if (!Directory.Exists(destDir))
                {
                    Directory.CreateDirectory(destDir);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    string temppath = Path.Combine(destDir, file.Name);
                    file.CopyTo(temppath, true);
                }
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDir, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath);
                }
            }
            // tim file
            public string TimFile(string linkFolder, string str)
            {
                // neu duong dan co ton tai
                if (Directory.Exists(linkFolder) == true)
                {
                    string[] gF = Directory.GetFiles(linkFolder);
                    foreach (string file in gF)
                    {
                        string[] rF = File.ReadAllLines(file);
                        foreach (string lines in rF)
                        {
                            if (str.Replace(" ", "").ToLower() == lines.Replace(" ", "").ToLower())
                                return file;
                        }
                    }
                }
                return "";
            }
            // cap nhat thong bao
            public void UploadTBTTL(string strNF, string strTTB, string strNDTB)
            {
                // neu file upload du lieu thong bao chua ton tai
                if (File.Exists(strNF) == false)
                {
                    Console.WriteLine("KHONG TIM THAY TEN FILE! :|");
                    Thread.Sleep(2000);
                }
                if (File.Exists(strNF) == true)
                {
                    // tao file moi
                    FileStream fn = new FileStream(strNF + ".txt", FileMode.Create);
                    fn.Close();
                    // ghi du lieu vao file moi
                    TextWriter txF = new StreamWriter(strNF + ".txt", true);
                    txF.WriteLine("# [{0} FROM: {1}] \n {2}", DateTime.Now, strTTB, strNDTB);
                    // ghi du lieu tu file cu~
                    string[] rF = File.ReadAllLines(strNF);
                    foreach (string lines in rF)
                    {
                        txF.WriteLine(lines);
                    }
                    txF.Close();
                    // xoa file cu~
                    File.Delete(strNF);
                    // doi file moi thanh file cu~
                    File.Move(strNF + ".txt", strNF);
                }
            }
            // tra ve so thu muc va so luong file dang co trong thu muc
            public string XacDinhSLThuMucVaFile(string strD)
            {
                int numD = 0;
                int numF = 0;
                if (Directory.Exists(strD) == true)
                {
                    // lay so luong thu muc
                    string[] gD = Directory.GetDirectories(strD);
                    foreach (string d in gD)
                    {
                        numD++;
                    }
                    // lay so luong file
                    string[] gF = Directory.GetFiles(strD);
                    foreach (string f in gF)
                    {
                        numF++;
                    }
                }
                return numD + " Directoris, " + numF + " Files";
            }
            // tao file moi vs dong moi
            public void TaoFileVsDongMoi(string strNameFile, string strDuocLoaiBo)
            {
                // 
                if (File.Exists(strNameFile) == true)
                {
                    // tao file moi
                    FileStream fN = new FileStream(strNameFile + ".ttl", FileMode.Create);
                    fN.Close();
                    // ghi file moi
                    TextWriter txF = new StreamWriter(strNameFile + ".ttl", true);
                    // doc du lieu tu file cu~
                    string[] rF = File.ReadAllLines(strNameFile);
                    foreach (string lines in rF)
                    {
                        // loc ky tu
                        if (lines.ToLower().Replace(" ", "") != strDuocLoaiBo.ToLower().Replace(" ", ""))
                            txF.WriteLine(lines);
                    }
                    txF.Close();
                    // xoa file cu~
                    File.Delete(strNameFile);
                    // doi file moi thanh file cu~
                    File.Move(strNameFile + ".ttl", strNameFile);
                }
            }
            // phương thức hiển thị thông báo
            public void HienThiThongBao(string tenThongBao, string thongBao, int num, string nameFile)
            {
                // tạo file mới với đường dẫn hiện tại
                FileStream fN = new FileStream(nameFile + "/HelpTTL.vbs", FileMode.Create);
                fN.Close();
                TextWriter tx = new StreamWriter(nameFile + "/HelpTTL.vbs");
                tx.WriteLine("x=msgbox(\"" + thongBao + "\"," + num + ",\"" + tenThongBao + "\")");
                tx.Close();
                // chạy file
                Process.Start("cmd", "/C start" + " " + nameFile + "/HelpTTL.vbs");
            }
            // loc ky tu vs the html
            public string LocKyTuVsTheHtml(string data){
                bool bTF = false;
                int iDem = 0;
                string sData = "";
                // neu du lieu khac khoang trong
                if(data.Replace(" ","") != ""){
                    // <a></a> the duong dan
                    if(data.Contains("<a>")){
                        data = data.Replace("<a>","");
                        data =  "<a href=\"" + data + "\" target=\"_blank\">" + data + "</a>";
                    }
                    // <a></a> the duong dan dowload trang wed xuong trang hien tai
                    if(data.Contains("<adownload>")){
                        // neu duong dan chua duoc chuyen doi tien hanh chuyen doi duong dan
                        if(data.Contains("https://www.youtube.com/embed/") == false && data.Contains("https://www.youtube.com") == true){
                             // chuyen duong dan thanh dang embed
                            data = data.Replace("<adownload>","").Replace("https://www.youtube.com/watch?v=","");
                            // lay 11 ky tu tiep theo
                            foreach(char dt in data){
                                iDem++;
                                if(iDem <= 11)
                                    sData = sData + dt;
                            }
                            data = "<a href=\"https://www.youtube.com/embed/" + sData + "\" download>" + data + "</a>";
                        }
                        // neu duong dan da duoc chuyen doi
                        else{
                            data = data.Replace("<adownload>","");
                            data = "<a href=\"" + data + "\" download>" + data + "</a>";
                        }
                    }
                    // <img> the hinh
                    else if(data.Contains("<img>")){
                        data = data.Replace("<img>","");
                        data =  "<img src=\"" + data + "\" alt=\"Hình ảnh không tồn tại\"  width=\"400px\">";
                    }
                    // <audio> the mp3
                    else if(data.Contains("<audio>")){
                        data = data.Replace("<audio>","");
                        data =  "<audio controls><source src=\"" + data + "\"></audio>";
                    }
                    // <video> the mp4 
                    else if(data.Contains("<video>")){
                        data = data.Replace("<video>","");
                        data =  "<video width=\"600\" height=\"300\" controls><source src=\"" + data + "\"></video>";
                    }
                    // <p> the text
                    else if(data.Contains("<p>")){
                        data = data.Replace("<p>","");
                        data =  "<p>" + data + "</p>";
                    }
                    // <b> the in dam
                    else if(data.Contains("<b>")){
                        data = data.Replace("<b>","");
                        data =  "<b>" + data + "</b>";
                    }
                    // <u> the gach chan
                    else if(data.Contains("<u>")){
                        data = data.Replace("<u>","");
                        data =  "<u>" + data + "</u>";
                    }
                    // <i> the in nghieng
                    else if(data.Contains("<i>")){
                        data = data.Replace("<i>","");
                        data =  "<i>" + data + "</i>";
                    }
                    // <h1> the in bu h1
                    else if(data.Contains("<h1>")){
                        data = data.Replace("<h1>","");
                        data =  "<h1>" + data + "</h1>";
                    }
                    // <h1> the in bu h2
                    else if(data.Contains("<h2>")){
                        data = data.Replace("<h2>","");
                        data =  "<h2>" + data + "</h2>";
                    }
                    // <h1> the in bu h3
                    else if(data.Contains("<h3>")){
                        data = data.Replace("<h3>","");
                        data =  "<h3>" + data + "</h3>";
                    }
                    // <h1> the in bu h4
                    else if(data.Contains("<h4>")){
                        data = data.Replace("<h4>","");
                        data =  "<h4>" + data + "</h4>";
                    }
                    // <h1> the in bu h5
                    else if(data.Contains("<h5>")){
                        data = data.Replace("<h5>","");
                        data =  "<h5>" + data + "</h5>";
                    }
                    // <iframe> the nhung trang wed
                    else if(data.Contains("<iframe>")){
                        // neu duong dan chua duoc chuyen doi tien hanh chuyen doi duong dan
                        if(data.Contains("https://www.youtube.com/embed/") == false && data.Contains("https://www.youtube.com") == true){
                             // chuyen duong dan thanh dang embed
                            data = data.Replace("<iframe>","").Replace("https://www.youtube.com/watch?v=","");
                            // lay 11 ky tu tiep theo
                            foreach(char dt in data){
                                iDem++;
                                if(iDem <= 11)
                                    sData = sData + dt;
                            }
                            data = "<iframe src=\"https://www.youtube.com/embed/" + sData + "\" width=\"600\" height=\"400\"></iframe>";
                        }
                        // neu duong dan da duoc chuyen doi
                        else{
                            data = data.Replace("<iframe>","");
                            data = "<iframe src=\"" + data + "\" width=\"600\" height=\"400\"></iframe>";
                        }
                    }
                    else
                        data = data;
                }
                return data;
            }
            //  // dem so dong trong file
            // public int DemSoDongTrongFile(string nameFile){
            //     int num = 0;
            //     // 
            //     if(File.Exists(nameFile) == true){
            //         string[] rF = File.ReadAllLines(nameFile);
            //         foreach(string line in rF){
            //             num++;
            //         }
            //     }
            //     return num;
            // }
            // tinh percent cho table
            public double PercentInTable(string linkFile, int num1, int num2)
            {
                int numDem = 0;
                int numArr = 0;
                double numColumn1 = 0;
                double numColumn2 = 0;
                string[] arr = new string[2];
                // doc du lieu trong file
                string[] rF = File.ReadAllLines(linkFile);
                foreach (string lines in rF)
                {
                    if (numDem == num1 || numDem == num2)
                    {
                        arr[numArr] = lines;
                        numArr++;
                    }
                    numDem++;
                }
                // tinh phan tram
                try
                {
                    numColumn1 = double.Parse(arr[0]);
                    numColumn2 = double.Parse(arr[1]);
                }
                catch
                {

                }

                return numColumn1 * 100 / numColumn2;
            }
            // tinh tinh true false cho table
            public string TrueFalse(string linkFile, int num1, int num2)
            {
                int numDem = 0;
                int numArr = 0;
                int numColumn1 = 0;
                int numColumn2 = 0;
                bool bTF = false;
                string[] arr = new string[2];
                // doc du lieu trong file
                string[] rF = File.ReadAllLines(linkFile);
                foreach (string lines in rF)
                {
                    if (numDem == num1 || numDem == num2)
                    {
                        arr[numArr] = lines;
                        numArr++;
                    }
                    numDem++;
                }
                // tinh true false
                try
                {
                    numColumn1 = int.Parse(arr[0]);
                    numColumn2 = int.Parse(arr[1]);
                    Console.ForegroundColor = ConsoleColor.Red;
                    if(numColumn1 > numColumn2){
                        bTF = true;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                }
                catch
                {

                }

                return bTF + " ";
            }
              // doc du lieu trong file va tra ve gia tri can tim o so dong
            public string DocFileVSSoDong(string nameFile,int soDong){
                int numSD = 0;
                string strCT = "";
                // neu file co ton tai
                if(File.Exists(nameFile) == true){
                    string[] lines = File.ReadAllLines(nameFile);
                    foreach(string s in lines){
                        if(soDong == numSD)
                            strCT = s;
                        numSD++;
                    }
                }
                return strCT;
            }
             // doc du lieu trong file va tra ve gia tri can tim
            public bool DocFileRTF(string nameFile,string strFind){
                bool bTF = false;
                // neu file co ton tai
                if(File.Exists(nameFile) == true){
                    string[] lines = File.ReadAllLines(nameFile);
                    foreach(string s in lines){
                        if(s.ToLower().Contains(strFind.ToLower()))
                            bTF = true;
                    }
                }
                return bTF;
            }
        }
    }
}

        

//CẢM ƠN VÌ CÓ BẠN Ở BÊN