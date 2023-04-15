//Vũ Văn Nghĩa_20206205
using System;
using System.IO;
using System.Text;
namespace KiThuatLapTrinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int luachon;
            do
            {
                Console.WriteLine("Vũ Văn Nghĩa MSSV: 20206205");
                Console.WriteLine("Vẽ một số cây.");
                Console.WriteLine("1. Vẽ cây số 1:");
                Console.WriteLine("2. Vẽ cây số 2:");
                Console.WriteLine("3. Vẽ cây số 3:");
                Console.WriteLine("4. Vẽ cây số 4:");
                Console.WriteLine("5. Vẽ cây số 5:");
                Console.WriteLine("6. Vẽ cây số 6:");
                Console.WriteLine("7. Vẽ cây số 7:");
                Console.WriteLine("8. Vẽ cây số 8:");
                Console.WriteLine("9. Vẽ cây số 9:");
                Console.WriteLine("10. Vẽ cây số 10:");
                Console.WriteLine("11. Vẽ cây số 11:");
                Console.WriteLine("0. Thoát chương trình.");
                do
                {
                    bool kt = false;
                    do
                    {
                        Console.Write("Mời bạn nhập lựa chọn từ 0 đến 11: ");
                        string nNhap = Console.ReadLine();
                        kt = int.TryParse(nNhap, out luachon);
                    } while (!kt);
                } while (0 > luachon || luachon > 11);
                switch (luachon)
                {
                    case 1:
                        Console.Clear();
                        VeCaySoMot();
                        break;
                    case 2:
                        Console.Clear();
                        VeCaySoHai();
                        break;
                    case 3:
                        Console.Clear();
                        VeCaySoBa();
                        break;
                    case 4:
                        Console.Clear();
                        VeCaySoBon();
                        break;
                    case 5:
                        Console.Clear();
                        VeCaySoNam();
                        break;
                    case 6:
                        Console.Clear();
                        VeCaySoSau();
                        break;
                    case 7:
                        Console.Clear();
                        VeCaySoBay();
                        break;
                    case 8:
                        Console.Clear();
                        VeCaySoTam();
                        break;
                    case 9:
                        Console.Clear();
                        VeCaySoChin();
                        break;
                    case 10:
                        Console.Clear();
                        VeCaySoMuoi();
                        break;
                    case 11:
                        Console.Clear();
                        VeCaySoMMot();
                        break;


                }
            } while (luachon != 0);
            Console.WriteLine("Bạn đã thoát chương trình!");
            Console.ReadKey();
        }

        public static void VeCaySoMot()
        {
            Console.WriteLine("Cây số 1:");
            Console.WriteLine("              v .   ._, |_  .,");
            Console.WriteLine("           `-._\\/  .  \\ /    |/_");
            Console.WriteLine("               \\\\  _\\, y | \\//");
            Console.WriteLine("         _\\_.___\\\\, \\\\/ -.\\||");
            Console.WriteLine("           `7-,--.`._||  / / ,");
            Console.WriteLine("           /'     `-. `./ / |/_.'");
            Console.WriteLine("                     |    |//");
            Console.WriteLine("                     |_    /");
            Console.WriteLine("                     |-   |");
            Console.WriteLine("                     |   =|");
            Console.WriteLine("                     |    |");
            Console.WriteLine("--------------------/ ,  . \\--------._");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoHai()
        {
            Console.WriteLine("Cây số 2:");
            Console.WriteLine("       _-_");
            Console.WriteLine("    /~~   ~~\\");
            Console.WriteLine(" /~~         ~~\\");
            Console.WriteLine("{               }");
            Console.WriteLine(" \\  _-     -_  /");
            Console.WriteLine("   ~  \\\\ //  ~");
            Console.WriteLine("_- -   | | _- _");
            Console.WriteLine("  _ -  | |   -_");
            Console.WriteLine("      // \\\\");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoBa()
        {
            Console.WriteLine("Cây số 3:");
            Console.WriteLine("                                                         .");
            Console.WriteLine("                                              .         ;  ");
            Console.WriteLine("                 .              .              ;%     ;;   ");
            Console.WriteLine("                   ,           ,                :;%  %;   ");
            Console.WriteLine("                    :         ;                   :;%;'     .,   ");
            Console.WriteLine("           ,.        %;     %;            ;        %;'    ,;");
            Console.WriteLine("             ;       ;%;  %%;        ,     %;    ;%;    ,%'");
            Console.WriteLine("              %;       %;%;      ,  ;       %;  ;%;   ,%;' ");
            Console.WriteLine("               ;%;      %;        ;%;        % ;%;  ,%;'");
            Console.WriteLine("                `%;.     ;%;     %;'         `;%%;.%;'");
            Console.WriteLine("                 `:;%.    ;%%. %@;        %; ;@%;%'");
            Console.WriteLine("                    `:%;.  :;bd%;          %;@%;'");
            Console.WriteLine("                      `@%:.  :;%.         ;@@%;'   ");
            Console.WriteLine("                        `@%.  `;@%.      ;@@%;         ");
            Console.WriteLine("                          `@%%. `@%%    ;@@%;        ");
            Console.WriteLine("                            ;@%. :@%%  %@@%;       ");
            Console.WriteLine("                              %@bd%%%bd%%:;     ");
            Console.WriteLine("                                #@%%%%%:;;");
            Console.WriteLine("                                %@@%%%::;");
            Console.WriteLine("                                %@@@%(o);  . '         ");
            Console.WriteLine("                                %@@@o%;:(.,'         ");
            Console.WriteLine("                            `.. %@@@o%::;         ");
            Console.WriteLine("                               `)@@@o%::;         ");
            Console.WriteLine("                                %@@(o)::;        ");
            Console.WriteLine("                               .%@@@@%::;         ");
            Console.WriteLine("                               ;%@@@@%::;.          ");
            Console.WriteLine("                              ;%@@@@%%:;;;. ");
            Console.WriteLine("                          ...;%@@@@@%%:;;;;,.. ");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }

        public static void VeCaySoBon()
        {
            Console.WriteLine("Cây số 4:");
            Console.WriteLine("                                  # #### ####");
            Console.WriteLine("                                ### \\/#|### |/####");
            Console.WriteLine("                               ##\\/#/ \\||/##/_/##/_#");
            Console.WriteLine("                             ###  \\/###|/ \\/ # ###");
            Console.WriteLine("                           ##_\\_#\\_\\## | #/###_/_####");
            Console.WriteLine("                          ## #### # \\ #| /  #### ##/##");
            Console.WriteLine("                           __#_--###`  |{,###---###-~");
            Console.WriteLine("                                     \\ }{");
            Console.WriteLine("                                      }}{");
            Console.WriteLine("                                      }}{");
            Console.WriteLine("                                      {{}");
            Console.WriteLine("                                , -=-~{ .-^- _");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoNam()
        {
            Console.WriteLine("Cây số 5:");
            Console.WriteLine("          &&& &&  & &&");
            Console.WriteLine("      && &\\/&\\|& ()|/ @, &&");
            Console.WriteLine("      &\\/(/&/&||/& /_/)_&/_&");
            Console.WriteLine("   &() &\\/&|()|/&\\/ '%\" & ()");
            Console.WriteLine("  &_\\_&&_\\ |& |&&/&__%_/_& &&");
            Console.WriteLine("&&   && & &| &| /& & % ()& /&&");
            Console.WriteLine(" ()&_---()&\\&\\|&&-&&--%---()~");
            Console.WriteLine("     &&     \\|||");
            Console.WriteLine("             |||");
            Console.WriteLine("             |||");
            Console.WriteLine("             |||");
            Console.WriteLine("       , -=-~  .-^- _");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoSau()
        {
            Console.WriteLine("Cây số 6:");
            Console.WriteLine("    oxoxoo    ooxoo");
            Console.WriteLine("  ooxoxo oo  oxoxooo");
            Console.WriteLine(" oooo xxoxoo ooo ooox");
            Console.WriteLine(" oxo o oxoxo  xoxxoxo");
            Console.WriteLine("  oxo xooxoooo o ooo");
            Console.WriteLine("    ooo\\oo\\  /o/o");
            Console.WriteLine("        \\  \\/ /");
            Console.WriteLine("         |   /");
            Console.WriteLine("         |  |");
            Console.WriteLine("         | D|");
            Console.WriteLine("         |  |");
            Console.WriteLine("         |  |");
            Console.WriteLine("  ______/____\\____");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoBay()
        {
            Console.WriteLine("Cây số 7:");
            Console.WriteLine("       ccee88oo");
            Console.WriteLine("  C8O8O8Q8PoOb o8oo");
            Console.WriteLine(" dOB69QO8PdUOpugoO9bD");
            Console.WriteLine("CgggbU8OU qOp qOdoUOdcb");
            Console.WriteLine("    6OuU  /p u gcoUodpP");
            Console.WriteLine("      \\\\//  /douUP");
            Console.WriteLine("        \\\\////");
            Console.WriteLine("         |||/\\");
            Console.WriteLine("         |||\\/");
            Console.WriteLine("         |||||");
            Console.WriteLine("   .....//||||\\....");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoTam()
        {
            Console.WriteLine("Cây số 8:");
            Console.WriteLine("               ,@@@@@@@,");
            Console.WriteLine("       ,,,.   ,@@@@@@/@@,  .oo8888o.");
            Console.WriteLine("    ,&%%&%&&%,@@@@@/@@@@@@,8888\\88/8o");
            Console.WriteLine("   ,%&\\%&&%&&%,@@@\\@@@/@@@88\\88888/88'");
            Console.WriteLine("   %&&%&%&/%&&%@@\\@@/ /@@@88888\\88888");
            Console.WriteLine("   %&&%/ %&%%&&@@\\ V /@@' `88\\8 `/88'");
            Console.WriteLine("   `&%\\ ` /%&'    |.|        \\ '|8'");
            Console.WriteLine("       |o|        | |         | |");
            Console.WriteLine("       |.|        | |         | |");
            Console.WriteLine("    \\\\/ ._\\//_/__/  ,\\_//__\\\\/.  \\_//__/_");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoChin()
        {
            Console.WriteLine("Cây số 9:");
            Console.WriteLine("                     . . .");
            Console.WriteLine("                   .        .  .     ..    .");
            Console.WriteLine("                .                 .         .  .");
            Console.WriteLine("                                .");
            Console.WriteLine("                               .                ..");
            Console.WriteLine("               .          .            .              .");
            Console.WriteLine("               .            '.,        .               .");
            Console.WriteLine("               .              'b      *");
            Console.WriteLine("                .              '$    #.                ..");
            Console.WriteLine("               .    .           $:   #:               .");
            Console.WriteLine("             ..      .  ..      *#  @):        .   . .");
            Console.WriteLine("                          .     :@,@):   ,.**:'   .");
            Console.WriteLine("              .      .,         :@@*: ..**'      .   .");
            Console.WriteLine("                       '#o.    .:(@'.@*\"'  .");
            Console.WriteLine("               .  .       'bq,..:,@@*'   ,*      .  .");
            Console.WriteLine("                          ,p$q8,:@)'  .p*'      .");
            Console.WriteLine("                   .     '  . '@@Pp@@*'    .  .");
            Console.WriteLine("                    .  . ..    Y7'.'     .  .");
            Console.WriteLine("                              :@):.");
            Console.WriteLine("                             .:@:'.");
            Console.WriteLine("                           .::(@:.      ");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoMuoi()
        {
            Console.WriteLine("Cây số 10:");
            Console.WriteLine("                    / / /");
            Console.WriteLine("                   /        /  /     //    /");
            Console.WriteLine("                /                 /         /  /");
            Console.WriteLine("                                /");
            Console.WriteLine("                               /                //");
            Console.WriteLine("               /          /            /              /");
            Console.WriteLine("               /            '/,        /               /");
            Console.WriteLine("               /              'b      *");
            Console.WriteLine("                /              '$    //                //");
            Console.WriteLine("               /    /           $:   /:               /");
            Console.WriteLine("             //      /  //      */  @):        /   / /");
            Console.WriteLine("                          /     :@,@):   ,/**:'   /");
            Console.WriteLine("              /      /,         :@@*: //**'      /   /");
            Console.WriteLine("                       '/o/    /:(@'/@*\"'  /");
            Console.WriteLine("               /  /       'bq,//:,@@*'   ,*      /  /");
            Console.WriteLine("                          ,p$q8,:@)'  /p*'      /");
            Console.WriteLine("                   /     '  / '@@Pp@@*'    /  /");
            Console.WriteLine("                    /  / //    Y7'.'     /  /");
            Console.WriteLine("                              :@):.");
            Console.WriteLine("                             .:@:'.");
            Console.WriteLine("                           .::(@:.   ");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
        public static void VeCaySoMMot()
        {
            Console.WriteLine("Cây số 11:");
            Console.WriteLine("              _{\\ _{\\{\\/}/}/}__");
            Console.WriteLine("             {/{/\\}{/{/\\}(\\}{/\\} _");
            Console.WriteLine("            {/{/\\}{/{/\\}(_)\\}{/{/\\}  _");
            Console.WriteLine("         {\\{/(\\}\\}{/{/\\}\\}{/){/\\}\\} /\\}");
            Console.WriteLine("        {/{/(_)/}{\\{/)\\}{\\(_){/}/}/}/}");
            Console.WriteLine("       _{\\{/{/{\\{/{/(_)/}/}/}{\\(/}/}/}");
            Console.WriteLine("      {/{/{\\{\\{\\(/}{\\{\\/}/}{\\}(_){\\/}\\}");
            Console.WriteLine("      _{\\{/{\\{/(_)\\}/}{/{/{/\\}\\})\\}{/\\}");
            Console.WriteLine("     {/{/{\\{\\(/}{/{\\{\\{\\/})/}{\\(_)/}/}\\}");
            Console.WriteLine("      {\\{\\/}(_){\\{\\{\\/}/}(_){\\/}{\\/}/})/}");
            Console.WriteLine("       {/{\\{\\/}{/{\\{\\{\\/}/}{\\{\\/}/}\\}(_)");
            Console.WriteLine("      {/{\\{\\/}{/){\\{\\{\\/}/}{\\{\\(/}/}\\}/}");
            Console.WriteLine("       {/{\\{\\/}(_){\\{\\{\\(/}/}{\\(_)/}/}\\}");
            Console.WriteLine("         {/({/{\\{/{\\{\\/}(_){\\/}/}\\}/}(\\}");
            Console.WriteLine("          (_){/{\\/}{\\{\\/}/}{\\{\\)/}/}(_)");
            Console.WriteLine("            {/{/{\\{\\/}{/{\\{\\{\\(_)/}");
            Console.WriteLine("             {/{\\{\\{\\/}/}{\\{\\\\}/}");
            Console.WriteLine("              {){/ {\\/}{\\/} \\}\\}");
            Console.WriteLine("              (_)  \\.-'.-/");
            Console.WriteLine("          __...--- |'-.-'| --...__");
            Console.WriteLine("   _...--\"   .-    |.-.-.|  ' __  \"....__");
            Console.WriteLine(" -\"                |.-.-.|              ");
            Console.WriteLine(" .  '-  '    .--'  | '-.'|    .  '  . '");
            Console.WriteLine("          ' ..     |'-_.-|");
            Console.WriteLine("  .  '  .       _.-|-._ -|-._  .  '  .");
            Console.WriteLine("              .'   |'- .-|   '.");
            Console.WriteLine("  ..-'   ' .  '.   `-._.-�   .'  '  - .");
            Console.WriteLine("   .-' '        '-._______.-'     '  .");
            Console.WriteLine("        .      ~,");
            Console.WriteLine("    .       .       .    ' '-.");
            Console.WriteLine("Nhấn phím bất kì để tiếp tục!");
            Console.ReadKey();
        }
    }
}