namespace HTML_Generator {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to HTML Generator, HTML Pages Generated in SWAG C# and not CRINGE JS!!!");
            while (true) {
                Console.WriteLine("Press Any Key to Generate a New Website!");
                Console.ReadKey();
                GENERATE();
                Thread.Sleep(250);
                Console.WriteLine();
            }
        }
        static void GENERATE() {
            string[] Webpage = {"<!DOCTYPE html><html lang=\"en\"><head><meta charset=\"UTF-8\"><meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\"><style>",
                                "</style><title>Generated in C#</title></head><body>",
                                "</body></html>"
            };
            string HTML = "";
            string CSS = "body{margin:0;display:flex;width:100%;height:100vh;}";
            Random rng = new Random();
            for (int a = 0; a < 4; a++) {
                HTML += $"<div id=\"a{a}\">";
                CSS += Flex($"a{a}");
                for (int b = 0; b < rng.Next(3, 6); b++) {
                    HTML += $"<div id=\"a{a}b{b}\">";
                    CSS += Flex($"a{a}b{b}");
                    for (int c = 0; c < rng.Next(2, 4); c++) {
                        HTML += $"<div id=\"a{a}b{b}c{c}\">";
                        CSS += Flex($"a{a}b{b}c{c}");
                        for (int d = 0; d < rng.Next(1, 4); d++) {
                            HTML += $"<div id=\"a{a}b{b}c{c}d{d}\">";
                            CSS += Flex($"a{a}b{b}c{c}d{d}");
                            for (int e = 0; e < rng.Next(1, 4); e++) {
                                HTML += $"<div id=\"a{a}b{b}c{c}d{d}e{e}\">";
                                CSS += Flex($"a{a}b{b}c{c}d{d}e{e}");
                                for (int f = 0; f < rng.Next(1, 4); f++) {
                                    HTML += $"<div id=\"a{a}b{b}c{c}d{d}e{e}f{f}\">";
                                    CSS += Flex($"a{a}b{b}c{c}d{d}e{e}f{f}");
                                    HTML += "</div>";
                                }
                                HTML += "</div>";
                            }
                            HTML += "</div>";
                        }
                        HTML += "</div>";
                    }
                    HTML += "</div>";
                }
                HTML += "</div>";
            }
            HTML += "<h1 class=\"welcome\">Welcome to my Website!</h1>";
            CSS += ".welcome{position:fixed;font-size:xxx-large;margin:auto;}";
            string output = Webpage[0] + CSS + Webpage[1] + HTML + Webpage[2];
            StreamWriter Website = new StreamWriter("C:\\Users\\MCA-20\\Documents\\HTML\\C#\\CSharp_Website.html");
            Website.Write(output);
            Website.Close();
            Console.WriteLine("Enjoy your newly generated Website!");
        }
        static string Flex(string id) {
            Random rgn = new Random();
            int bol = rgn.Next(2);
            string dir;
            if (bol == 0) {
                dir = "flex-direction:column;";
            } else {
                dir = "flex-direction:row;";
            }
            return $"#{id}" + "{" + $"background-color:rgb({rgn.Next(256)},{rgn.Next(256)},{rgn.Next(256)});display:flex;{dir}flex:1;" + "}";
        }
    }
}