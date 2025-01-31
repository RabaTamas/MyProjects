using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otthonbazar.Data.Migrations
{
    public partial class SeedAdvertisementsAndCities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1, "Szentendre", "2000" },
                    { 2, "Pilisszentlászló", "2009" },
                    { 3, "Budakalász", "2011" },
                    { 4, "Pomáz", "2013" },
                    { 5, "Csobánka", "2014" },
                    { 6, "Szigetmonostor", "2015" },
                    { 7, "Leányfalu", "2016" },
                    { 8, "Pócsmegyer", "2017" },
                    { 9, "Tahitótfalu-Tótfalu", "2021" },
                    { 10, "Tahitótfalu-Tahi", "2022" },
                    { 11, "Dunabogdány", "2023" },
                    { 12, "Kisoroszi", "2024" },
                    { 13, "Visegrád", "2025" },
                    { 14, "Visegrád-Gizellatelep", "2026" },
                    { 15, "Dömös", "2027" },
                    { 16, "Pilismarót", "2028" },
                    { 17, "Érd", "2030" },
                    { 18, "Sóskút", "2038" },
                    { 19, "Pusztazámor", "2039" },
                    { 20, "Budaörs", "2040" },
                    { 21, "Törökbálint", "2045" },
                    { 22, "Diósd", "2049" },
                    { 23, "Biatorbágy", "2051" },
                    { 24, "Herceghalom", "2053" },
                    { 25, "Bicske", "2060" },
                    { 26, "Óbarok", "2063" },
                    { 27, "Csabdi", "2064" },
                    { 28, "Mány", "2065" },
                    { 29, "Szár", "2066" },
                    { 30, "Újbarok", "2066" },
                    { 31, "Szárliget", "2067" },
                    { 32, "Páty", "2071" },
                    { 33, "Zsámbék", "2072" },
                    { 34, "Tök", "2073" },
                    { 35, "Perbál", "2074" },
                    { 36, "Pilisjászfalu ", "2080" },
                    { 37, "Piliscsaba ", "2081" },
                    { 38, "Solymár", "2083" },
                    { 39, "Pilisszentiván", "2084" },
                    { 40, "Pilisvörösvár", "2085" },
                    { 41, "Tinnye", "2086" },
                    { 42, "Telki", "2089" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 43, "Remeteszőlős", "2090" },
                    { 44, "Etyek", "2091" },
                    { 45, "Budakeszi", "2092" },
                    { 46, "Budajenő", "2093" },
                    { 47, "Nagykovácsi", "2094" },
                    { 48, "Pilisszántó", "2095" },
                    { 49, "Üröm", "2096" },
                    { 50, "Pilisborosjenő", "2097" },
                    { 51, "Pilisszentkereszt", "2098" },
                    { 52, "Pilisszentkereszt-Dobogókő", "2099" },
                    { 53, "Gödöllő", "2100" },
                    { 54, "Szada", "2111" },
                    { 55, "Veresegyház", "2112" },
                    { 56, "Erdőkertes", "2113" },
                    { 57, "Valkó", "2114" },
                    { 58, "Vácszentlászló", "2115" },
                    { 59, "Zsámbok", "2116" },
                    { 60, "Isaszeg", "2117" },
                    { 61, "Dány", "2118" },
                    { 62, "Pécel", "2119" },
                    { 63, "Dunakeszi", "2120" },
                    { 64, "Göd-Alsógöd", "2131" },
                    { 65, "Göd-Felsőgöd", "2132" },
                    { 66, "Sződliget", "2133" },
                    { 67, "Sződ", "2134" },
                    { 68, "Csörög", "2135" },
                    { 69, "Csömör", "2141" },
                    { 70, "Nagytarcsa", "2142" },
                    { 71, "Kistarcsa", "2143" },
                    { 72, "Kerepes ", "2144" },
                    { 73, "Kerepes-Szilasliget", "2145" },
                    { 74, "Mogyoród", "2146" },
                    { 75, "Fót", "2151" },
                    { 76, "Csomád", "2161" },
                    { 77, "őrbottyán", "2162" },
                    { 78, "Vácrátót", "2163" },
                    { 79, "Váchartyán", "2164" },
                    { 80, "Kisnémedi", "2165" },
                    { 81, "Püspökszilágy", "2166" },
                    { 82, "Vácduka", "2167" },
                    { 83, "Aszód", "2170" },
                    { 84, "Kartal", "2173" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 85, "Verseg", "2174" },
                    { 86, "Kálló", "2175" },
                    { 87, "Erdőkürt", "2176" },
                    { 88, "Erdőtarcsa", "2177" },
                    { 89, "Iklad", "2181" },
                    { 90, "Domony", "2182" },
                    { 91, "Galgamácsa", "2183" },
                    { 92, "Vácegres", "2184" },
                    { 93, "Váckisújfalu", "2185" },
                    { 94, "Bag", "2191" },
                    { 95, "Hévízgyörk", "2192" },
                    { 96, "Galgahévíz", "2193" },
                    { 97, "Tura", "2194" },
                    { 98, "Monor", "2200" },
                    { 99, "Péteri", "2209" },
                    { 100, "Vasad", "2211" },
                    { 101, "Csévharaszt", "2212" },
                    { 102, "Monorierdő", "2213" },
                    { 103, "Pánd", "2214" },
                    { 104, "Káva", "2215" },
                    { 105, "Bénye", "2216" },
                    { 106, "Gomba", "2217" },
                    { 107, "Vecsés", "2220" },
                    { 108, "Üllő", "2225" },
                    { 109, "Gyömrő", "2230" },
                    { 110, "Ecser", "2233" },
                    { 111, "Maglód", "2234" },
                    { 112, "Mende", "2235" },
                    { 113, "Sülysáp-Tápiósüly", "2241" },
                    { 114, "Sülysáp-Tápiósáp", "2242" },
                    { 115, "Kóka", "2243" },
                    { 116, "Úri", "2244" },
                    { 117, "Tápiószecső", "2251" },
                    { 118, "Tóalmás", "2252" },
                    { 119, "Tápióság", "2253" },
                    { 120, "Szentmártonkáta", "2254" },
                    { 121, "Szentlőrinckáta", "2255" },
                    { 122, "Ráckeve", "2300" },
                    { 123, "Lórév", "2309" },
                    { 124, "Szigetszentmiklós", "2310" },
                    { 125, "Halásztelek", "2314" },
                    { 126, "Szigethalom", "2315" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 127, "Tököl", "2316" },
                    { 128, "Szigetcsép", "2317" },
                    { 129, "Szigetszentmárton", "2318" },
                    { 130, "Szigetújfalu", "2319" },
                    { 131, "Szigetbecse", "2321" },
                    { 132, "Makád", "2322" },
                    { 133, "Dunaharaszti", "2330" },
                    { 134, "Taksony", "2335" },
                    { 135, "Dunavarsány", "2336" },
                    { 136, "Délegyháza", "2337" },
                    { 137, "Áporka", "2338" },
                    { 138, "Majosháza", "2339" },
                    { 139, "Kiskunlacháza", "2340" },
                    { 140, "Dömsöd", "2344" },
                    { 141, "Apaj", "2345" },
                    { 142, "Bugyi", "2347" },
                    { 143, "Alsónémedi", "2351" },
                    { 144, "Gyál", "2360" },
                    { 145, "Felsőpakony", "2363" },
                    { 146, "Ócsa", "2364" },
                    { 147, "Inárcs", "2365" },
                    { 148, "Kakucs", "2366" },
                    { 149, "Újhartyán", "2367" },
                    { 150, "Dabas", "2370" },
                    { 151, "Dabas-Sári", "2371" },
                    { 152, "Dabas-Gyón", "2373" },
                    { 153, "Tatárszentgyörgy", "2375" },
                    { 154, "Hernád", "2376" },
                    { 155, "Örkény", "2377" },
                    { 156, "Pusztavacs", "2378" },
                    { 157, "Táborfalva", "2381" },
                    { 158, "Dunaújváros", "2400" },
                    { 159, "Dunaújváros-Pálhalma", "2407" },
                    { 160, "Nagyvenyim", "2421" },
                    { 161, "Mezőfalva", "2422" },
                    { 162, "Daruszentmiklós", "2423" },
                    { 163, "Előszállás", "2424" },
                    { 164, "Nagykarácsony", "2425" },
                    { 165, "Baracs ", "2426" },
                    { 166, "Baracs-Apátszállás", "2427" },
                    { 167, "Kisapostag", "2428" },
                    { 168, "Perkáta", "2431" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 169, "Szabadegyháza", "2432" },
                    { 170, "Sárosd", "2433" },
                    { 171, "Hantos", "2434" },
                    { 172, "Nagylók", "2435" },
                    { 173, "Százhalombatta", "2440" },
                    { 174, "Ercsi ", "2451" },
                    { 175, "Ercsi-Sinatelep", "2453" },
                    { 176, "Iváncsa", "2454" },
                    { 177, "Beloiannisz", "2455" },
                    { 178, "Besnyő", "2456" },
                    { 179, "Adony", "2457" },
                    { 180, "Kulcs", "2458" },
                    { 181, "Rácalmás", "2459" },
                    { 182, "Tárnok", "2461" },
                    { 183, "Martonvásár", "2462" },
                    { 184, "Tordas", "2463" },
                    { 185, "Gyúró", "2464" },
                    { 186, "Ráckeresztúr", "2465" },
                    { 187, "Baracska", "2471" },
                    { 188, "Kajászó", "2472" },
                    { 189, "Vál", "2473" },
                    { 190, "Kápolnásnyék", "2475" },
                    { 191, "Pázmánd", "2476" },
                    { 192, "Vereb", "2477" },
                    { 193, "Velence ", "2481" },
                    { 194, "Gárdony ", "2483" },
                    { 195, "Gárdony-Agárd", "2484" },
                    { 196, "Gárdony-Dinnyés", "2485" },
                    { 197, "Pusztaszabolcs", "2490" },
                    { 198, "Esztergom", "2500" },
                    { 199, "Esztergom-Pilisszentlélek", "2508" },
                    { 200, "Esztergom-Kertváros", "2509" },
                    { 201, "Dorog", "2510" },
                    { 202, "Kesztölc", "2517" },
                    { 203, "Leányvár", "2518" },
                    { 204, "Piliscsév", "2519" },
                    { 205, "Csolnok", "2521" },
                    { 206, "Dág", "2522" },
                    { 207, "Sárisáp", "2523" },
                    { 208, "Nagysáp", "2524" },
                    { 209, "Bajna", "2525" },
                    { 210, "Epöl", "2526" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 211, "Máriahalom", "2527" },
                    { 212, "Úny", "2528" },
                    { 213, "Annavölgy", "2529" },
                    { 214, "Tokod ", "2531" },
                    { 215, "Tokodaltáró", "2532" },
                    { 216, "Bajót", "2533" },
                    { 217, "Tát", "2534" },
                    { 218, "Mogyorósbánya", "2535" },
                    { 219, "Nyergesújfalu ", "2536" },
                    { 220, "Lábatlan ", "2541" },
                    { 221, "Süttő", "2543" },
                    { 222, "Neszmély", "2544" },
                    { 223, "Dunaalmás", "2545" },
                    { 224, "Vác", "2600" },
                    { 225, "Nőtincs", "2610" },
                    { 226, "ősagárd", "2610" },
                    { 227, "Felsőpetény", "2611" },
                    { 228, "Kosd", "2612" },
                    { 229, "Rád", "2613" },
                    { 230, "Penc", "2614" },
                    { 231, "Csővár", "2615" },
                    { 232, "Keszeg", "2616" },
                    { 233, "Alsópetény", "2617" },
                    { 234, "Nézsa", "2618" },
                    { 235, "Legénd", "2619" },
                    { 236, "Verőce", "2621" },
                    { 237, "Kismaros", "2623" },
                    { 238, "Szokolya", "2624" },
                    { 239, "Kóspallag", "2625" },
                    { 240, "Nagymaros", "2626" },
                    { 241, "Zebegény", "2627" },
                    { 242, "Szob", "2628" },
                    { 243, "Márianosztra", "2629" },
                    { 244, "Ipolydamásd", "2631" },
                    { 245, "Letkés", "2632" },
                    { 246, "Ipolytölgyes", "2633" },
                    { 247, "Nagybörzsöny", "2634" },
                    { 248, "Vámosmikola", "2635" },
                    { 249, "Tésa", "2636" },
                    { 250, "Perőcsény", "2637" },
                    { 251, "Kemence", "2638" },
                    { 252, "Bernecebaráti", "2639" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 253, "Szendehely", "2640" },
                    { 254, "Berkenye", "2641" },
                    { 255, "Nógrád", "2642" },
                    { 256, "Diósjenő", "2643" },
                    { 257, "Borsosberény", "2644" },
                    { 258, "Nagyoroszi", "2645" },
                    { 259, "Drégelypalánk", "2646" },
                    { 260, "Hont", "2647" },
                    { 261, "Patak", "2648" },
                    { 262, "Dejtár", "2649" },
                    { 263, "Rétság", "2651" },
                    { 264, "Tereske", "2652" },
                    { 265, "Bánk", "2653" },
                    { 266, "Romhány", "2654" },
                    { 267, "Kétbodony", "2655" },
                    { 268, "Kisecset", "2655" },
                    { 269, "Szente", "2655" },
                    { 270, "Szátok", "2656" },
                    { 271, "Tolmács", "2657" },
                    { 272, "Horpács", "2658" },
                    { 273, "Pusztaberki", "2658" },
                    { 274, "Érsekvadkert", "2659" },
                    { 275, "Balassagyarmat", "2660" },
                    { 276, "Ipolyszög", "2660" },
                    { 277, "Patvarc", "2668" },
                    { 278, "Ipolyvece", "2669" },
                    { 279, "őrhalom", "2671" },
                    { 280, "Hugyag", "2672" },
                    { 281, "Csitár", "2673" },
                    { 282, "Iliny", "2674" },
                    { 283, "Nógrádmarcal", "2675" },
                    { 284, "Cserhátsurány", "2676" },
                    { 285, "Herencsény", "2677" },
                    { 286, "Csesztve", "2678" },
                    { 287, "Galgagyörk", "2681" },
                    { 288, "Püspökhatvan", "2682" },
                    { 289, "Acsa", "2683" },
                    { 290, "Nógrádsáp", "2685" },
                    { 291, "Galgaguta", "2686" },
                    { 292, "Bercel", "2687" },
                    { 293, "Vanyarc", "2688" },
                    { 294, "Nógrádkövesd", "2691" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 295, "Szécsénke", "2692" },
                    { 296, "Becske", "2693" },
                    { 297, "Magyarnándor", "2694" },
                    { 298, "Cserháthaláp", "2694" },
                    { 299, "Debercsény", "2694" },
                    { 300, "Terény", "2696" },
                    { 301, "Szanda", "2697" },
                    { 302, "Mohora", "2698" },
                    { 303, "Szügy", "2699" },
                    { 304, "Cegléd", "2700" },
                    { 305, "Tápiószentmárton", "2711" },
                    { 306, "Nyársapát", "2712" },
                    { 307, "Csemő", "2713" },
                    { 308, "Pilis", "2721" },
                    { 309, "Nyáregyháza", "2723" },
                    { 310, "Újlengyel", "2724" },
                    { 311, "Albertirsa", "2730" },
                    { 312, "Dánszentmiklós", "2735" },
                    { 313, "Mikebuda", "2736" },
                    { 314, "Ceglédbercel", "2737" },
                    { 315, "Cegléd-Budai út", "2738" },
                    { 316, "Abony", "2740" },
                    { 317, "Kőröstetétlen", "2745" },
                    { 318, "Jászkarajenő", "2746" },
                    { 319, "Törtel", "2747" },
                    { 320, "Nagykőrös", "2750" },
                    { 321, "Kocsér", "2755" },
                    { 322, "Nagykáta", "2760" },
                    { 323, "Tápióbicske", "2764" },
                    { 324, "Farmos", "2765" },
                    { 325, "Tápiószele", "2766" },
                    { 326, "Tápiógyörgye", "2767" },
                    { 327, "Újszilvás", "2768" },
                    { 328, "Tápiószőlős", "2769" },
                    { 329, "Tatabánya", "2800" },
                    { 330, "Gyermely", "2821" },
                    { 331, "Szomor", "2822" },
                    { 332, "Vértessomló", "2823" },
                    { 333, "Várgesztes", "2824" },
                    { 334, "Tarján", "2831" },
                    { 335, "Héreg", "2832" },
                    { 336, "Vértestolna", "2833" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 337, "Tardos", "2834" },
                    { 338, "Tata-Agostyán", "2835" },
                    { 339, "Baj", "2836" },
                    { 340, "Vértesszőlős", "2837" },
                    { 341, "Oroszlány", "2840" },
                    { 342, "Környe", "2851" },
                    { 343, "Kecskéd", "2852" },
                    { 344, "Kömlőd", "2853" },
                    { 345, "Dad", "2854" },
                    { 346, "Bokod", "2855" },
                    { 347, "Szákszend", "2856" },
                    { 348, "Császár", "2858" },
                    { 349, "Vérteskethely", "2859" },
                    { 350, "Bakonysárkány", "2861" },
                    { 351, "Aka", "2862" },
                    { 352, "Kisbér", "2870" },
                    { 353, "Kisbér-Hánta", "2879" },
                    { 354, "Ászár", "2881" },
                    { 355, "Kerékteleki", "2882" },
                    { 356, "Bársonyos", "2883" },
                    { 357, "Bakonyszombathely", "2884" },
                    { 358, "Bakonybánk", "2885" },
                    { 359, "Réde", "2886" },
                    { 360, "Ácsteszér", "2887" },
                    { 361, "Csatka", "2888" },
                    { 362, "Súr", "2889" },
                    { 363, "Tata", "2890" },
                    { 364, "Szomód", "2896" },
                    { 365, "Dunaszentmiklós", "2897" },
                    { 366, "Kocs", "2898" },
                    { 367, "Naszály", "2899" },
                    { 368, "Komárom", "2900" },
                    { 369, "Komárom-Koppánymonostor", "2903" },
                    { 370, "Mocsa", "2911" },
                    { 371, "Komárom-Szőny", "2921" },
                    { 372, "Almásfüzitő ", "2931" },
                    { 373, "Ács", "2941" },
                    { 374, "Nagyigmánd", "2942" },
                    { 375, "Bábolna", "2943" },
                    { 376, "Tárkány-Ölbőpuszta", "2943" },
                    { 377, "Bana", "2944" },
                    { 378, "Tárkány", "2945" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 379, "Csép", "2946" },
                    { 380, "Ete", "2947" },
                    { 381, "Kisigmánd", "2948" },
                    { 382, "Csém", "2949" },
                    { 383, "Hatvan", "3000" },
                    { 384, "Kerekharaszt", "3009" },
                    { 385, "Heréd", "3011" },
                    { 386, "Nagykökényes", "3012" },
                    { 387, "Ecséd", "3013" },
                    { 388, "Hort", "3014" },
                    { 389, "Csány", "3015" },
                    { 390, "Boldog", "3016" },
                    { 391, "Lőrinci ", "3021" },
                    { 392, "Lőrinci-Mátravidéki erőmû", "3022" },
                    { 393, "Petőfibánya", "3023" },
                    { 394, "Lőrinci-Selyp", "3024" },
                    { 395, "Zagyvaszántó", "3031" },
                    { 396, "Apc", "3032" },
                    { 397, "Rózsaszentmárton", "3033" },
                    { 398, "Szûcsi", "3034" },
                    { 399, "Gyöngyöspata", "3035" },
                    { 400, "Gyöngyöstarján", "3036" },
                    { 401, "Héhalom", "3041" },
                    { 402, "Palotás", "3042" },
                    { 403, "Egyházasdengeleg", "3043" },
                    { 404, "Szirák", "3044" },
                    { 405, "Bér", "3045" },
                    { 406, "Kisbágyon", "3046" },
                    { 407, "Buják", "3047" },
                    { 408, "Szarvasgede", "3051" },
                    { 409, "Csécse", "3052" },
                    { 410, "Ecseg", "3053" },
                    { 411, "Kozárd", "3053" },
                    { 412, "Pásztó", "3060" },
                    { 413, "Jobbágyi", "3063" },
                    { 414, "Szurdokpüspöki", "3064" },
                    { 415, "Pásztó-Hasznos", "3065" },
                    { 416, "Cserhátszentiván", "3066" },
                    { 417, "Bokor", "3066" },
                    { 418, "Kutasó", "3066" },
                    { 419, "Felsőtold", "3067" },
                    { 420, "Garáb", "3067" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 421, "Mátraszőlős", "3068" },
                    { 422, "Alsótold", "3069" },
                    { 423, "Bátonyterenye", "3070" },
                    { 424, "Bátonyterenye-Nagybátony", "3071" },
                    { 425, "Tar", "3073" },
                    { 426, "Sámsonháza", "3074" },
                    { 427, "Nagybárkány", "3075" },
                    { 428, "Kisbárkány", "3075" },
                    { 429, "Márkháza", "3075" },
                    { 430, "Mátraverebély", "3077" },
                    { 431, "Bátonyterenye-Kisterenye", "3078" },
                    { 432, "Pásztó-Mátrakeresztes", "3082" },
                    { 433, "Salgótarján", "3100" },
                    { 434, "Salgótarján-Baglyasalja", "3102" },
                    { 435, "Salgótarján-Zagyvapálfalva", "3104" },
                    { 436, "Salgótarján-Salgóbánya", "3109" },
                    { 437, "Somoskőújfalu", "3121" },
                    { 438, "Cered", "3123" },
                    { 439, "Zabar", "3124" },
                    { 440, "Szilaspogony", "3125" },
                    { 441, "Bárna", "3126" },
                    { 442, "Kazár", "3127" },
                    { 443, "Vizslás", "3128" },
                    { 444, "Lucfalva", "3129" },
                    { 445, "Nagykeresztúr", "3129" },
                    { 446, "Sóshartyán", "3131" },
                    { 447, "Nógrádmegyer", "3132" },
                    { 448, "Magyargéc", "3133" },
                    { 449, "Piliny", "3134" },
                    { 450, "Szécsényfelfalu", "3135" },
                    { 451, "Etes", "3136" },
                    { 452, "Karancsberény", "3137" },
                    { 453, "Ipolytarnóc", "3138" },
                    { 454, "Salgótarján-Zagyvaróna", "3141" },
                    { 455, "Mátraszele", "3142" },
                    { 456, "Mátranovák", "3143" },
                    { 457, "Mátranovák-Bányatelep", "3144" },
                    { 458, "Mátraterenye-Homokterenye", "3145" },
                    { 459, "Mátraterenye-Nádújfalu", "3146" },
                    { 460, "Kazár-Mizserfa", "3147" },
                    { 461, "Rákóczibánya", "3151" },
                    { 462, "Nemti", "3152" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 463, "Dorogháza", "3153" },
                    { 464, "Szuha", "3154" },
                    { 465, "Mátramindszent", "3155" },
                    { 466, "Kishartyán", "3161" },
                    { 467, "Ságújfalu", "3162" },
                    { 468, "Karancsság", "3163" },
                    { 469, "Szalmatercs", "3163" },
                    { 470, "Endrefalva", "3165" },
                    { 471, "Szécsény", "3170" },
                    { 472, "Nagylóc", "3175" },
                    { 473, "Hollókő", "3176" },
                    { 474, "Rimóc", "3177" },
                    { 475, "Varsány", "3178" },
                    { 476, "Nógrádsipek", "3179" },
                    { 477, "Karancsalja", "3181" },
                    { 478, "Karancslapujtő", "3182" },
                    { 479, "Karancskeszi", "3183" },
                    { 480, "Mihálygerge", "3184" },
                    { 481, "Egyházasgerge", "3185" },
                    { 482, "Litke", "3186" },
                    { 483, "Nógrádszakál", "3187" },
                    { 484, "Ludányhalászi", "3188" },
                    { 485, "Gyöngyös", "3200" },
                    { 486, "Gyöngyösoroszi", "3211" },
                    { 487, "Gyöngyöshalász", "3212" },
                    { 488, "Atkár", "3213" },
                    { 489, "Nagyréde", "3214" },
                    { 490, "Gyöngyös-Kékestető", "3221" },
                    { 491, "Gyöngyössolymos", "3231" },
                    { 492, "Gyöngyös-Mátrafüred", "3232" },
                    { 493, "Gyöngyös-Mátraháza", "3233" },
                    { 494, "Mátraszentimre-Galyatető", "3234" },
                    { 495, "Mátraszentimre", "3235" },
                    { 496, "Parád", "3240" },
                    { 497, "Parádsasvár", "3242" },
                    { 498, "Bodony", "3243" },
                    { 499, "Parád-Parádfürdő", "3244" },
                    { 500, "Recsk", "3245" },
                    { 501, "Mátraderecske", "3246" },
                    { 502, "Mátraballa", "3247" },
                    { 503, "Ivád", "3248" },
                    { 504, "Pétervására", "3250" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 505, "Erdőkövesd", "3252" },
                    { 506, "Istenmezeje", "3253" },
                    { 507, "Váraszó", "3254" },
                    { 508, "Fedémes", "3255" },
                    { 509, "Kisfüzes", "3256" },
                    { 510, "Bükkszenterzsébet", "3257" },
                    { 511, "Tarnalelesz", "3258" },
                    { 512, "Szentdomonkos", "3259" },
                    { 513, "Abasár", "3261" },
                    { 514, "Pálosvörösmart", "3261" },
                    { 515, "Markaz", "3262" },
                    { 516, "Domoszló", "3263" },
                    { 517, "Kisnána", "3264" },
                    { 518, "Vécs", "3265" },
                    { 519, "Visonta ", "3271" },
                    { 520, "Visonta-Mátrai Erőmû", "3272" },
                    { 521, "Halmajugra", "3273" },
                    { 522, "Ludas", "3274" },
                    { 523, "Detk", "3275" },
                    { 524, "Karácsond", "3281" },
                    { 525, "Nagyfüged", "3282" },
                    { 526, "Tarnazsadány", "3283" },
                    { 527, "Tarnaméra", "3284" },
                    { 528, "Vámosgyörk", "3291" },
                    { 529, "Adács", "3292" },
                    { 530, "Visznek", "3293" },
                    { 531, "Tarnaörs", "3294" },
                    { 532, "Erk", "3295" },
                    { 533, "Zaránk", "3296" },
                    { 534, "Eger", "3300" },
                    { 535, "Egerbakta", "3321" },
                    { 536, "Hevesaranyos", "3322" },
                    { 537, "Szarvaskő", "3323" },
                    { 538, "Felsőtárkány", "3324" },
                    { 539, "Noszvaj", "3325" },
                    { 540, "Ostoros", "3326" },
                    { 541, "Novaj", "3327" },
                    { 542, "Egerszólát", "3328" },
                    { 543, "Tarnaszentmária", "3331" },
                    { 544, "Sirok", "3332" },
                    { 545, "Terpes", "3333" },
                    { 546, "Szajla", "3334" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 547, "Bükkszék", "3335" },
                    { 548, "Bátor", "3336" },
                    { 549, "Egerbocs", "3337" },
                    { 550, "Egercsehi", "3341" },
                    { 551, "Szúcs", "3341" },
                    { 552, "Bekölce", "3343" },
                    { 553, "Mikófalva", "3344" },
                    { 554, "Mónosbél", "3345" },
                    { 555, "Bélapátfalva", "3346" },
                    { 556, "Bükkszentmárton", "3346" },
                    { 557, "Balaton", "3347" },
                    { 558, "Szilvásvárad", "3348" },
                    { 559, "Nagyvisnyó", "3349" },
                    { 560, "Kál", "3350" },
                    { 561, "Verpelét", "3351" },
                    { 562, "Feldebrő", "3352" },
                    { 563, "Aldebrő", "3353" },
                    { 564, "Tófalu", "3354" },
                    { 565, "Kápolna", "3355" },
                    { 566, "Kompolt", "3356" },
                    { 567, "Nagyút", "3357" },
                    { 568, "Erdőtelek", "3358" },
                    { 569, "Tenk", "3359" },
                    { 570, "Heves", "3360" },
                    { 571, "Boconád", "3368" },
                    { 572, "Tarnabod", "3369" },
                    { 573, "Átány", "3371" },
                    { 574, "Kömlő", "3372" },
                    { 575, "Besenyőtelek", "3373" },
                    { 576, "Dormánd", "3374" },
                    { 577, "Mezőtárkány", "3375" },
                    { 578, "Szihalom", "3377" },
                    { 579, "Mezőszemere", "3378" },
                    { 580, "Egerfarmos", "3379" },
                    { 581, "Pély", "3381" },
                    { 582, "Tarnaszentmiklós", "3382" },
                    { 583, "Hevesvezekény", "3383" },
                    { 584, "Kisköre", "3384" },
                    { 585, "Tiszanána", "3385" },
                    { 586, "Sarud", "3386" },
                    { 587, "Újlőrincfalva", "3387" },
                    { 588, "Poroszló", "3388" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 589, "Füzesabony ", "3390" },
                    { 590, "Egerszalók", "3394" },
                    { 591, "Demjén", "3395" },
                    { 592, "Kerecsend", "3396" },
                    { 593, "Maklár", "3397" },
                    { 594, "Nagytálya", "3398" },
                    { 595, "Andornaktálya", "3399" },
                    { 596, "Mezőkövesd", "3400" },
                    { 597, "Szomolya", "3411" },
                    { 598, "Bogács", "3412" },
                    { 599, "Cserépfalu", "3413" },
                    { 600, "Bükkzsérc", "3414" },
                    { 601, "Tard", "3416" },
                    { 602, "Cserépváralja", "3417" },
                    { 603, "Szentistván", "3418" },
                    { 604, "Mezőnyárád", "3421" },
                    { 605, "Bükkábrány", "3422" },
                    { 606, "Tibolddaróc", "3423" },
                    { 607, "Kács", "3424" },
                    { 608, "Sály", "3425" },
                    { 609, "Borsodgeszt", "3426" },
                    { 610, "Vatta", "3431" },
                    { 611, "Emőd", "3432" },
                    { 612, "Nyékládháza ", "3433" },
                    { 613, "Mályi", "3434" },
                    { 614, "Mezőkeresztes ", "3441" },
                    { 615, "Csincse", "3442" },
                    { 616, "Mezőnagymihály", "3443" },
                    { 617, "Gelej", "3444" },
                    { 618, "Mezőcsát", "3450" },
                    { 619, "Tiszakeszi", "3458" },
                    { 620, "Igrici", "3459" },
                    { 621, "Egerlövő", "3461" },
                    { 622, "Borsodivánka", "3462" },
                    { 623, "Négyes", "3463" },
                    { 624, "Tiszavalk", "3464" },
                    { 625, "Tiszabábolna", "3465" },
                    { 626, "Tiszadorogma", "3466" },
                    { 627, "Ároktő", "3467" },
                    { 628, "Miskolc*", "3500" },
                    { 629, "Ónod", "3551" },
                    { 630, "Muhi", "3552" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 631, "Kistokaj", "3553" },
                    { 632, "Bükkaranyos", "3554" },
                    { 633, "Harsány", "3555" },
                    { 634, "Kisgyőr", "3556" },
                    { 635, "Bükkszentkereszt", "3557" },
                    { 636, "Répáshuta", "3559" },
                    { 637, "Felsőzsolca", "3561" },
                    { 638, "Onga", "3562" },
                    { 639, "Hernádkak", "3563" },
                    { 640, "Hernádnémeti", "3564" },
                    { 641, "Tiszalúc", "3565" },
                    { 642, "Alsózsolca", "3571" },
                    { 643, "Sajólád", "3572" },
                    { 644, "Sajópetri", "3573" },
                    { 645, "Bőcs", "3574" },
                    { 646, "Berzék", "3575" },
                    { 647, "Sajóhídvég", "3576" },
                    { 648, "Köröm", "3577" },
                    { 649, "Girincs", "3578" },
                    { 650, "Kiscsécs", "3578" },
                    { 651, "Kesznyéten", "3579" },
                    { 652, "Tiszaújváros", "3580" },
                    { 653, "Sajóörös", "3586" },
                    { 654, "Tiszapalkonya", "3587" },
                    { 655, "Hejőkürt", "3588" },
                    { 656, "Tiszatarján", "3589" },
                    { 657, "Oszlár", "3591" },
                    { 658, "Nemesbikk", "3592" },
                    { 659, "Hejőbába", "3593" },
                    { 660, "Hejőpapi", "3594" },
                    { 661, "Hejőszalonta", "3595" },
                    { 662, "Szakáld", "3596" },
                    { 663, "Hejőkeresztúr", "3597" },
                    { 664, "Nagycsécs", "3598" },
                    { 665, "Sajószöged", "3599" },
                    { 666, "Ózd", "3600" },
                    { 667, "Ózd-Sajóvárkony", "3603" },
                    { 668, "Ózd-Bánszállás", "3604" },
                    { 669, "Farkaslyuk", "3608" },
                    { 670, "Ózd-Uraj", "3621" },
                    { 671, "Uppony", "3622" },
                    { 672, "Borsodszentgyörgy", "3623" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 673, "Ózd-Szentsimon", "3625" },
                    { 674, "Hangony", "3626" },
                    { 675, "Domaháza", "3627" },
                    { 676, "Kissikátor", "3627" },
                    { 677, "Putnok", "3630" },
                    { 678, "Dubicsány", "3635" },
                    { 679, "Vadna", "3636" },
                    { 680, "Sajógalgóc", "3636" },
                    { 681, "Nagybarca", "3641" },
                    { 682, "Bánhorváti", "3642" },
                    { 683, "Dédestapolcsány", "3643" },
                    { 684, "Tardona", "3644" },
                    { 685, "Mályinka", "3645" },
                    { 686, "Nekézseny", "3646" },
                    { 687, "Csokvaomány", "3647" },
                    { 688, "Csernely", "3648" },
                    { 689, "Bükkmogyorósd", "3648" },
                    { 690, "Lénárddaróc", "3648" },
                    { 691, "Ózd-Center", "3651" },
                    { 692, "Sajónémeti", "3652" },
                    { 693, "Sajópüspöki", "3653" },
                    { 694, "Bánréve", "3654" },
                    { 695, "Hét", "3655" },
                    { 696, "Sajóvelezd", "3656" },
                    { 697, "Sajómercse", "3656" },
                    { 698, "Királd", "3657" },
                    { 699, "Borsodbóta", "3658" },
                    { 700, "Sáta", "3659" },
                    { 701, "Ózd-Hódoscsépány", "3661" },
                    { 702, "Ózd-Somsálybánya", "3662" },
                    { 703, "Arló", "3663" },
                    { 704, "Járdánháza", "3664" },
                    { 705, "Borsodnádasd ", "3671" },
                    { 706, "Borsodnádasd-Lemezgyár", "3672" },
                    { 707, "Kazincbarcika", "3700" },
                    { 708, "Berente", "3704" },
                    { 709, "Szirmabesenyő", "3711" },
                    { 710, "Sajóvámos", "3712" },
                    { 711, "Sajósenye", "3712" },
                    { 712, "Arnót", "3713" },
                    { 713, "Sajópálfala", "3714" },
                    { 714, "Gesztely", "3715" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 715, "Újcsanálos", "3716" },
                    { 716, "Sóstófalva", "3716" },
                    { 717, "Alsódobsza", "3717" },
                    { 718, "Megyaszó", "3718" },
                    { 719, "Sajókaza", "3720" },
                    { 720, "Sajóivánka", "3720" },
                    { 721, "Felsőnyárád", "3721" },
                    { 722, "Dövény", "3721" },
                    { 723, "Jákfalva", "3721" },
                    { 724, "Felsőkelecsény", "3722" },
                    { 725, "Zubogy", "3723" },
                    { 726, "Ragály", "3724" },
                    { 727, "Trizs", "3724" },
                    { 728, "Imola", "3725" },
                    { 729, "Zádorfalva", "3726" },
                    { 730, "Alsószuha", "3726" },
                    { 731, "Szuhafő", "3726" },
                    { 732, "Kelemér", "3728" },
                    { 733, "Gömörszőlős", "3728" },
                    { 734, "Serényfalva", "3729" },
                    { 735, "Szuhakálló", "3731" },
                    { 736, "Kurityán", "3732" },
                    { 737, "Rudabánya", "3733" },
                    { 738, "Szuhogy", "3734" },
                    { 739, "Felsőtelekes", "3735" },
                    { 740, "Alsótelekes", "3735" },
                    { 741, "Kánó", "3735" },
                    { 742, "Izsófalva", "3741" },
                    { 743, "Rudolftelep", "3742" },
                    { 744, "Ormosbánya", "3743" },
                    { 745, "Múcsony", "3744" },
                    { 746, "Szendrőlád", "3751" },
                    { 747, "Szendrő", "3752" },
                    { 748, "Galvács", "3752" },
                    { 749, "Abod", "3753" },
                    { 750, "Szalonna", "3754" },
                    { 751, "Meszes", "3754" },
                    { 752, "Martonyi", "3755" },
                    { 753, "Perkupa", "3756" },
                    { 754, "Varbóc", "3756" },
                    { 755, "Szőlősardó", "3757" },
                    { 756, "Égerszög", "3757" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 757, "Teresztenye", "3757" },
                    { 758, "Jósvafő", "3758" },
                    { 759, "Aggtelek", "3759" },
                    { 760, "Szin", "3761" },
                    { 761, "Szinpetri", "3761" },
                    { 762, "Tornakápolna", "3761" },
                    { 763, "Szögliget", "3762" },
                    { 764, "Bódvaszilas", "3763" },
                    { 765, "Bódvarákó", "3764" },
                    { 766, "Komjáti", "3765" },
                    { 767, "Tornabarakony", "3765" },
                    { 768, "Tornaszentandrás", "3765" },
                    { 769, "Tornanádaska", "3767" },
                    { 770, "Hidvégardó", "3768" },
                    { 771, "Becskeháza", "3768" },
                    { 772, "Bódvalenke", "3768" },
                    { 773, "Tornaszentjakab", "3769" },
                    { 774, "Sajószentpéter", "3770" },
                    { 775, "Sajókápolna", "3773" },
                    { 776, "Sajólászlófalva", "3773" },
                    { 777, "Kondó", "3775" },
                    { 778, "Radostyán", "3776" },
                    { 779, "Parasznya", "3777" },
                    { 780, "Varbó", "3778" },
                    { 781, "Alacska", "3779" },
                    { 782, "Edelény ", "3780" },
                    { 783, "Balajt", "3780" },
                    { 784, "Damak", "3780" },
                    { 785, "Ládbesenyő", "3780" },
                    { 786, "Edelény-Finke", "3783" },
                    { 787, "Lak", "3786" },
                    { 788, "Hegymeg", "3786" },
                    { 789, "Irota", "3786" },
                    { 790, "Szakácsi", "3786" },
                    { 791, "Tomor", "3787" },
                    { 792, "Sajókeresztúr", "3791" },
                    { 793, "Sajóbábony", "3792" },
                    { 794, "Sajóecseg", "3793" },
                    { 795, "Boldva", "3794" },
                    { 796, "Ziliz", "3794" },
                    { 797, "Hangács", "3795" },
                    { 798, "Nyomár", "3795" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 799, "Borsodszirák", "3796" },
                    { 800, "Szikszó", "3800" },
                    { 801, "Selyeb", "3809" },
                    { 802, "Abaújszolnok", "3809" },
                    { 803, "Nyésta", "3809" },
                    { 804, "Alsóvadász", "3811" },
                    { 805, "Homrogd", "3812" },
                    { 806, "Monaj", "3812" },
                    { 807, "Kupa", "3813" },
                    { 808, "Felsővadász", "3814" },
                    { 809, "Gadna", "3815" },
                    { 810, "Abaújlak", "3815" },
                    { 811, "Gagyvendégi", "3816" },
                    { 812, "Gagybátor", "3817" },
                    { 813, "Krasznokvajda", "3821" },
                    { 814, "Büttös", "3821" },
                    { 815, "Kány", "3821" },
                    { 816, "Keresztéte", "3821" },
                    { 817, "Pamlény", "3821" },
                    { 818, "Perecse", "3821" },
                    { 819, "Szászfa", "3821" },
                    { 820, "Rakaca", "3825" },
                    { 821, "Debréte", "3825" },
                    { 822, "Viszló", "3825" },
                    { 823, "Rakacaszend", "3826" },
                    { 824, "Kázsmárk", "3831" },
                    { 825, "Léh", "3832" },
                    { 826, "Rásonysápberencs", "3833" },
                    { 827, "Detek", "3834" },
                    { 828, "Beret", "3834" },
                    { 829, "Baktakék", "3836" },
                    { 830, "Felsőgagy", "3837" },
                    { 831, "Alsógagy", "3837" },
                    { 832, "Csenyéte", "3837" },
                    { 833, "Gagyapáti", "3837" },
                    { 834, "Aszaló", "3841" },
                    { 835, "Halmaj", "3842" },
                    { 836, "Kiskinizs", "3843" },
                    { 837, "Nagykinizs", "3844" },
                    { 838, "Szentistvánbaksa", "3844" },
                    { 839, "Hernádkércs", "3846" },
                    { 840, "Felsődobsza", "3847" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 841, "Csobád", "3848" },
                    { 842, "Forró", "3849" },
                    { 843, "Ináncs", "3851" },
                    { 844, "Hernádszentandrás", "3852" },
                    { 845, "Pere", "3853" },
                    { 846, "Hernádbûd", "3853" },
                    { 847, "Gibárt", "3854" },
                    { 848, "Fancsal", "3855" },
                    { 849, "Encs", "3860" },
                    { 850, "Szalaszend", "3863" },
                    { 851, "Fulókércs", "3864" },
                    { 852, "Fáj", "3865" },
                    { 853, "Szemere", "3866" },
                    { 854, "Litka", "3866" },
                    { 855, "Méra", "3871" },
                    { 856, "Novajidrány", "3872" },
                    { 857, "Garadna", "3873" },
                    { 858, "Hernádvécse", "3874" },
                    { 859, "Hernádpetri", "3874" },
                    { 860, "Pusztaradvány", "3874" },
                    { 861, "Hernádszurdok", "3875" },
                    { 862, "Hidasnémeti", "3876" },
                    { 863, "Tornyosnémeti", "3877" },
                    { 864, "Abaújszántó", "3881" },
                    { 865, "Baskó", "3881" },
                    { 866, "Sima", "3881" },
                    { 867, "Abaújkér", "3882" },
                    { 868, "Abaújalpár", "3882" },
                    { 869, "Boldogkőújfalu", "3884" },
                    { 870, "Boldogkőváralja", "3885" },
                    { 871, "Arka", "3885" },
                    { 872, "Korlát", "3886" },
                    { 873, "Hernádcéce", "3887" },
                    { 874, "Vizsoly", "3888" },
                    { 875, "Vilmány", "3891" },
                    { 876, "Hejce", "3892" },
                    { 877, "Fony", "3893" },
                    { 878, "Mogyoróska", "3893" },
                    { 879, "Regéc", "3893" },
                    { 880, "Göncruszka", "3894" },
                    { 881, "Gönc", "3895" },
                    { 882, "Telkibánya", "3896" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 883, "Zsujta", "3897" },
                    { 884, "Abaújvár", "3898" },
                    { 885, "Pányok", "3898" },
                    { 886, "Kéked", "3899" },
                    { 887, "Szerencs", "3900" },
                    { 888, "Szerencs-Ond", "3902" },
                    { 889, "Bekecs", "3903" },
                    { 890, "Legyesbénye", "3904" },
                    { 891, "Monok", "3905" },
                    { 892, "Golop", "3906" },
                    { 893, "Tállya", "3907" },
                    { 894, "Rátka", "3908" },
                    { 895, "Mád", "3909" },
                    { 896, "Tokaj", "3910" },
                    { 897, "Tarcal", "3915" },
                    { 898, "Bodrogkeresztúr", "3916" },
                    { 899, "Bodrogkisfalud", "3917" },
                    { 900, "Szegi", "3918" },
                    { 901, "Szegilong", "3918" },
                    { 902, "Taktaszada", "3921" },
                    { 903, "Taktaharkány", "3922" },
                    { 904, "Gesztely-Újharangod", "3923" },
                    { 905, "Taktakenéz", "3924" },
                    { 906, "Prügy", "3925" },
                    { 907, "Taktabáj", "3926" },
                    { 908, "Csobaj", "3927" },
                    { 909, "Tiszatardos", "3928" },
                    { 910, "Tiszaladány", "3929" },
                    { 911, "Mezőzombor", "3931" },
                    { 912, "Erdőbénye", "3932" },
                    { 913, "Olaszliszka", "3933" },
                    { 914, "Tolcsva", "3934" },
                    { 915, "Erdőhorváti", "3935" },
                    { 916, "Háromhuta", "3936" },
                    { 917, "Komlóska", "3937" },
                    { 918, "Vámosújfalu", "3941" },
                    { 919, "Sárazsadány", "3942" },
                    { 920, "Bodrogolaszi", "3943" },
                    { 921, "Sátoraljaújhely-Károlyfalva", "3944" },
                    { 922, "Sátoraljaújhely-Rudabányácska", "3945" },
                    { 923, "Sárospatak", "3950" },
                    { 924, "Györgytarló", "3954" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 925, "Kenézlő", "3955" },
                    { 926, "Viss", "3956" },
                    { 927, "Zalkod", "3957" },
                    { 928, "Hercegkút", "3958" },
                    { 929, "Makkoshotyka", "3959" },
                    { 930, "Vajdácska", "3961" },
                    { 931, "Karos", "3962" },
                    { 932, "Karcsa", "3963" },
                    { 933, "Pácin", "3964" },
                    { 934, "Nagyrozvágy", "3965" },
                    { 935, "Kisrozvágy", "3965" },
                    { 936, "Lácacséke", "3967" },
                    { 937, "Tiszakarád", "3971" },
                    { 938, "Tiszacsermely", "3972" },
                    { 939, "Cigánd", "3973" },
                    { 940, "Ricse", "3974" },
                    { 941, "Semjén", "3974" },
                    { 942, "Révleányvár", "3976" },
                    { 943, "Zemplénagárd", "3977" },
                    { 944, "Dámóc", "3978" },
                    { 945, "Sátoraljaújhely", "3980" },
                    { 946, "Alsóberecki", "3985" },
                    { 947, "Felsőberecki", "3985" },
                    { 948, "Bodroghalom", "3987" },
                    { 949, "Sátoraljaújhely-Széphalom", "3988" },
                    { 950, "Mikóháza", "3989" },
                    { 951, "Alsóregmec", "3989" },
                    { 952, "Felsőregmec", "3989" },
                    { 953, "Vilyvitány", "3991" },
                    { 954, "Kovácsvágás", "3992" },
                    { 955, "Vágáshuta", "3992" },
                    { 956, "Füzérradvány", "3993" },
                    { 957, "Pálháza", "3994" },
                    { 958, "Bózsva", "3994" },
                    { 959, "Filkeháza", "3994" },
                    { 960, "Füzérkajata", "3994" },
                    { 961, "Kishuta", "3994" },
                    { 962, "Nagyhuta", "3994" },
                    { 963, "Pusztafalu", "3995" },
                    { 964, "Füzér", "3996" },
                    { 965, "Füzérkomlós", "3997" },
                    { 966, "Nyíri", "3998" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 967, "Hollóháza", "3999" },
                    { 968, "Debrecen*", "4000" },
                    { 969, "Balmazújváros", "4060" },
                    { 970, "Nagyhegyes", "4064" },
                    { 971, "Újszentmargita", "4065" },
                    { 972, "Tiszacsege", "4066" },
                    { 973, "Egyek-Telekháza", "4067" },
                    { 974, "Egyek", "4069" },
                    { 975, "Hortobágy", "4071" },
                    { 976, "Hajdúböszörmény-Nagypród", "4074" },
                    { 977, "Görbeháza", "4075" },
                    { 978, "Hajdúnánás", "4080" },
                    { 979, "Hajdúnánás-Tedej", "4085" },
                    { 980, "Hajdúböszörmény-Hajdúvid", "4086" },
                    { 981, "Hajdúdorog", "4087" },
                    { 982, "Polgár", "4090" },
                    { 983, "Folyás", "4095" },
                    { 984, "Újtikos", "4096" },
                    { 985, "Tiszagyulaháza", "4097" },
                    { 986, "Berettyóújfalu", "4100" },
                    { 987, "Berettyóújfalu-Berettyószentmárton", "4103" },
                    { 988, "Biharkeresztes", "4110" },
                    { 989, "Bojt", "4114" },
                    { 990, "Ártánd ", "4115" },
                    { 991, "Berekböszörmény", "4116" },
                    { 992, "Told ", "4117" },
                    { 993, "Mezőpeterd", "4118" },
                    { 994, "Váncsod", "4119" },
                    { 995, "Szentpéterszeg", "4121" },
                    { 996, "Gáborján", "4122" },
                    { 997, "Hencida", "4123" },
                    { 998, "Esztár", "4124" },
                    { 999, "Pocsaj", "4125" },
                    { 1000, "Kismarja", "4126" },
                    { 1001, "Nagykereki", "4127" },
                    { 1002, "Bedő", "4128" },
                    { 1003, "Derecske", "4130" },
                    { 1004, "Tépe", "4132" },
                    { 1005, "Konyár", "4133" },
                    { 1006, "Mezősas", "4134" },
                    { 1007, "Körösszegapáti", "4135" },
                    { 1008, "Körösszakál", "4136" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1009, "Magyarhomorog", "4137" },
                    { 1010, "Komádi", "4138" },
                    { 1011, "Furta", "4141" },
                    { 1012, "Zsáka", "4142" },
                    { 1013, "Vekerd", "4143" },
                    { 1014, "Darvas", "4144" },
                    { 1015, "Csökmő", "4145" },
                    { 1016, "Újiráz", "4146" },
                    { 1017, "Püspökladány", "4150" },
                    { 1018, "Báránd", "4161" },
                    { 1019, "Szerep-Hosszúhát", "4162" },
                    { 1020, "Szerep", "4163" },
                    { 1021, "Bakonszeg", "4164" },
                    { 1022, "Sárrétudvari", "4171" },
                    { 1023, "Biharnagybajom", "4172" },
                    { 1024, "Nagyrábé", "4173" },
                    { 1025, "Bihartorda", "4174" },
                    { 1026, "Bihardancsháza", "4175" },
                    { 1027, "Sáp", "4176" },
                    { 1028, "Földes", "4177" },
                    { 1029, "Nádudvar", "4181" },
                    { 1030, "Kaba", "4183" },
                    { 1031, "Tetétlen", "4184" },
                    { 1032, "Hajdúszoboszló", "4200" },
                    { 1033, "Ebes", "4211" },
                    { 1034, "Hajdúszovát", "4212" },
                    { 1035, "Hajdúböszörmény", "4220" },
                    { 1036, "Hajdúböszörmény-Bodaszőlő", "4224" },
                    { 1037, "Bököny", "4231" },
                    { 1038, "Geszteréd", "4232" },
                    { 1039, "Balkány", "4233" },
                    { 1040, "Szakoly", "4234" },
                    { 1041, "Biri", "4235" },
                    { 1042, "Bocskaikert", "4241" },
                    { 1043, "Hajdúhadház", "4242" },
                    { 1044, "Téglás", "4243" },
                    { 1045, "Újfehértó", "4244" },
                    { 1046, "Érpatak", "4245" },
                    { 1047, "Nyíregyháza-Butykatelep", "4246" },
                    { 1048, "Hajdúsámson", "4251" },
                    { 1049, "Nyíradony-Tamásipuszta", "4252" },
                    { 1050, "Nyíradony-Aradványpuszta", "4253" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1051, "Nyíradony", "4254" },
                    { 1052, "Nyíracsád", "4262" },
                    { 1053, "Nyírmártonfalva", "4263" },
                    { 1054, "Nyírábrány", "4264" },
                    { 1055, "Fülöp", "4266" },
                    { 1056, "Penészlek", "4267" },
                    { 1057, "Mikepércs", "4271" },
                    { 1058, "Sáránd", "4272" },
                    { 1059, "Hajdúbagos", "4273" },
                    { 1060, "Hosszúpályi", "4274" },
                    { 1061, "Monostorpályi", "4275" },
                    { 1062, "Létavértes-Nagyléta", "4281" },
                    { 1063, "Létavértes-Vértes", "4283" },
                    { 1064, "Kokad", "4284" },
                    { 1065, "Álmosd", "4285" },
                    { 1066, "Bagamér", "4286" },
                    { 1067, "Vámospércs", "4287" },
                    { 1068, "Újléta", "4288" },
                    { 1069, "Nyírbátor", "4300" },
                    { 1070, "Nyírgyulaj", "4311" },
                    { 1071, "Nagykálló", "4320" },
                    { 1072, "Kállósemjén", "4324" },
                    { 1073, "Kisléta", "4325" },
                    { 1074, "Máriapócs", "4326" },
                    { 1075, "Pócspetri", "4327" },
                    { 1076, "Nyírcsászári", "4331" },
                    { 1077, "Nyírderzs", "4332" },
                    { 1078, "Nyírkáta", "4333" },
                    { 1079, "Hodász", "4334" },
                    { 1080, "Kántorjánosi", "4335" },
                    { 1081, "őr", "4336" },
                    { 1082, "Jármi", "4337" },
                    { 1083, "Papos ", "4338" },
                    { 1084, "Nyírvasvári", "4341" },
                    { 1085, "Terem", "4342" },
                    { 1086, "Bátorliget", "4343" },
                    { 1087, "Vállaj", "4351" },
                    { 1088, "Mérk", "4352" },
                    { 1089, "Tiborszállás", "4353" },
                    { 1090, "Fábiánháza", "4354" },
                    { 1091, "Nagyecsed", "4355" },
                    { 1092, "Nyírcsaholy", "4356" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1093, "Nyírbogát", "4361" },
                    { 1094, "Nyírgelse", "4362" },
                    { 1095, "Nyírmihálydi", "4363" },
                    { 1096, "Nyírlugos", "4371" },
                    { 1097, "Nyírbéltek", "4372" },
                    { 1098, "Ömböly", "4373" },
                    { 1099, "Encsencs", "4374" },
                    { 1100, "Piricse", "4375" },
                    { 1101, "Nyírpilis", "4376" },
                    { 1102, "Nyíregyháza", "4400" },
                    { 1103, "Nyíregyháza-Borbánya", "4405" },
                    { 1104, "Nyíregyháza-Sóstófürdő", "4431" },
                    { 1105, "Nyíregyháza-Nyírszőlős", "4432" },
                    { 1106, "Nyíregyháza-Felsősima", "4433" },
                    { 1107, "Kálmánháza", "4434" },
                    { 1108, "Tiszavasvári", "4440" },
                    { 1109, "Szorgalmatos", "4441" },
                    { 1110, "Nagycserkesz", "4445" },
                    { 1111, "Tiszaeszlár-Bashalom", "4446" },
                    { 1112, "Tiszalök-Kisfástanya", "4447" },
                    { 1113, "Tiszalök", "4450" },
                    { 1114, "Tiszadada", "4455" },
                    { 1115, "Tiszadob", "4456" },
                    { 1116, "Nyírtelek", "4461" },
                    { 1117, "Tiszanagyfalu", "4463" },
                    { 1118, "Tiszaeszlár    ", "4464" },
                    { 1119, "Rakamaz", "4465" },
                    { 1120, "Timár", "4466" },
                    { 1121, "Szabolcs", "4467" },
                    { 1122, "Balsa", "4468" },
                    { 1123, "Gávavencsellő-Gáva", "4471" },
                    { 1124, "Gávavencsellő-Vencsellő", "4472" },
                    { 1125, "Tiszabercel", "4474" },
                    { 1126, "Paszab", "4475" },
                    { 1127, "Nyíregyháza-Sóstóhegy", "4481" },
                    { 1128, "Kótaj", "4482" },
                    { 1129, "Buj", "4483" },
                    { 1130, "Ibrány", "4484" },
                    { 1131, "Nagyhalász", "4485" },
                    { 1132, "Tiszatelek-Kétérköz", "4486" },
                    { 1133, "Tiszatelek", "4487" },
                    { 1134, "Beszterec", "4488" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1135, "Újdombrád", "4491" },
                    { 1136, "Dombrád", "4492" },
                    { 1137, "Tiszakanyár", "4493" },
                    { 1138, "Kékcse", "4494" },
                    { 1139, "Döge", "4495" },
                    { 1140, "Szabolcsveresmart", "4496" },
                    { 1141, "Kemecse", "4501" },
                    { 1142, "Vasmegyer", "4502" },
                    { 1143, "Tiszarád", "4503" },
                    { 1144, "Nyírbogdány ", "4511" },
                    { 1145, "Kék", "4515" },
                    { 1146, "Demecser", "4516" },
                    { 1147, "Gégény", "4517" },
                    { 1148, "Berkesz ", "4521" },
                    { 1149, "Nyírtass", "4522" },
                    { 1150, "Pátroha", "4523" },
                    { 1151, "Ajak", "4524" },
                    { 1152, "Rétközberencs", "4525" },
                    { 1153, "Nyírpazony", "4531" },
                    { 1154, "Nyírtura", "4532" },
                    { 1155, "Sényő", "4533" },
                    { 1156, "Székely", "4534" },
                    { 1157, "Nyíribrony", "4535" },
                    { 1158, "Ramocsaháza", "4536" },
                    { 1159, "Nyírkércs", "4537" },
                    { 1160, "Nyírjákó", "4541" },
                    { 1161, "Petneháza", "4542" },
                    { 1162, "Laskod", "4543" },
                    { 1163, "Nyírkarász", "4544" },
                    { 1164, "Gyulaháza", "4545" },
                    { 1165, "Anarcs", "4546" },
                    { 1166, "Szabolcsbáka", "4547" },
                    { 1167, "Nyíregyháza-Oros", "4551" },
                    { 1168, "Napkor", "4552" },
                    { 1169, "Apagy", "4553" },
                    { 1170, "Nyírtét", "4554" },
                    { 1171, "Levelek", "4555" },
                    { 1172, "Magy", "4556" },
                    { 1173, "Besenyőd", "4557" },
                    { 1174, "Ófehértó", "4558" },
                    { 1175, "Baktalórántháza", "4561" },
                    { 1176, "Vaja", "4562" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1177, "Rohod", "4563" },
                    { 1178, "Nyírmada", "4564" },
                    { 1179, "Pusztadobos", "4565" },
                    { 1180, "Ilk", "4566" },
                    { 1181, "Gemzse", "4567" },
                    { 1182, "Kisvárda", "4600" },
                    { 1183, "Jéke", "4611" },
                    { 1184, "Fényeslitke", "4621" },
                    { 1185, "Komoró", "4622" },
                    { 1186, "Tuzsér", "4623" },
                    { 1187, "Tiszabezdéd", "4624" },
                    { 1188, "Záhony", "4625" },
                    { 1189, "Győröcske", "4625" },
                    { 1190, "Zsurk", "4627" },
                    { 1191, "Tiszaszentmárton", "4628" },
                    { 1192, "Pap", "4631" },
                    { 1193, "Nyírlövő", "4632" },
                    { 1194, "Lövőpetri", "4633" },
                    { 1195, "Aranyosapáti", "4634" },
                    { 1196, "Újkenéz", "4635" },
                    { 1197, "Mezőladány", "4641" },
                    { 1198, "Tornyospálca", "4642" },
                    { 1199, "Benk", "4643" },
                    { 1200, "Mándok", "4644" },
                    { 1201, "Tiszamogyorós", "4645" },
                    { 1202, "Eperjeske", "4646" },
                    { 1203, "Mátészalka", "4700" },
                    { 1204, "Szamoskér", "4721" },
                    { 1205, "Nyírmeggyes", "4722" },
                    { 1206, "Tunyogmatolcs", "4731" },
                    { 1207, "Cégénydányád", "4732" },
                    { 1208, "Gyügye", "4733" },
                    { 1209, "Szamosújlak", "4734" },
                    { 1210, "Szamossályi", "4735" },
                    { 1211, "Hermánszeg", "4735" },
                    { 1212, "Kisnamény", "4737" },
                    { 1213, "Darnó", "4737" },
                    { 1214, "Jánkmajtis", "4741" },
                    { 1215, "Csegöld", "4742" },
                    { 1216, "Csengersima", "4743" },
                    { 1217, "Szamosbecs", "4745" },
                    { 1218, "Szamostatárfalva", "4746" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1219, "Kocsord", "4751" },
                    { 1220, "Győrtelek", "4752" },
                    { 1221, "Géberjén", "4754" },
                    { 1222, "Fülpösdaróc", "4754" },
                    { 1223, "Ököritófülpös", "4755" },
                    { 1224, "Rápolt", "4756" },
                    { 1225, "Porcsalma", "4761" },
                    { 1226, "Tyukod", "4762" },
                    { 1227, "Ura", "4763" },
                    { 1228, "Csengerújfalu", "4764" },
                    { 1229, "Csenger", "4765" },
                    { 1230, "Komlódtótfalu", "4765" },
                    { 1231, "Pátyod", "4766" },
                    { 1232, "Szamosangyalos", "4767" },
                    { 1233, "Vásárosnamény", "4800" },
                    { 1234, "Vásárosnamény-Gergelyiugornya", "4803" },
                    { 1235, "Vásárosnamény-Vitka", "4804" },
                    { 1236, "Kisvarsány", "4811" },
                    { 1237, "Nagyvarsány", "4812" },
                    { 1238, "Gyüre ", "4813" },
                    { 1239, "Ópályi", "4821" },
                    { 1240, "Nyírparasznya", "4822" },
                    { 1241, "Nagydobos", "4823" },
                    { 1242, "Szamosszeg", "4824" },
                    { 1243, "Olcsva", "4826" },
                    { 1244, "Tiszaszalka", "4831" },
                    { 1245, "Tiszavid", "4832" },
                    { 1246, "Tiszaadony", "4833" },
                    { 1247, "Tiszakerecseny", "4834" },
                    { 1248, "Mátyus", "4835" },
                    { 1249, "Lónya", "4836" },
                    { 1250, "Jánd", "4841" },
                    { 1251, "Gulács", "4842" },
                    { 1252, "Hetefejércse", "4843" },
                    { 1253, "Csaroda", "4844" },
                    { 1254, "Tákos", "4845" },
                    { 1255, "Fehérgyarmat", "4900" },
                    { 1256, "Nábrád", "4911" },
                    { 1257, "Kérsemjén", "4912" },
                    { 1258, "Panyola", "4913" },
                    { 1259, "Olcsvaapáti", "4914" },
                    { 1260, "Kisar", "4921" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1261, "Tivadar", "4921" },
                    { 1262, "Nagyar", "4922" },
                    { 1263, "Tarpa", "4931" },
                    { 1264, "Márokpapi", "4932" },
                    { 1265, "Beregsurány", "4933" },
                    { 1266, "Beregdaróc", "4934" },
                    { 1267, "Gelénes", "4935" },
                    { 1268, "Vámosatya", "4936" },
                    { 1269, "Barabás", "4937" },
                    { 1270, "Penyige", "4941" },
                    { 1271, "Mánd", "4942" },
                    { 1272, "Nemesborzova", "4942" },
                    { 1273, "Kömörő", "4943" },
                    { 1274, "Túristvándi", "4944" },
                    { 1275, "Szatmárcseke", "4945" },
                    { 1276, "Tiszakóród", "4946" },
                    { 1277, "Tiszacsécse", "4947" },
                    { 1278, "Milota", "4948" },
                    { 1279, "Tiszabecs", "4951" },
                    { 1280, "Uszka", "4952" },
                    { 1281, "Magosliget", "4953" },
                    { 1282, "Sonkád", "4954" },
                    { 1283, "Botpalád", "4955" },
                    { 1284, "Kispalád", "4956" },
                    { 1285, "Zsarolyán", "4961" },
                    { 1286, "Nagyszekeres", "4962" },
                    { 1287, "Kisszekeres", "4963" },
                    { 1288, "Fülesd", "4964" },
                    { 1289, "Kölcse", "4965" },
                    { 1290, "Vámosoroszi", "4966" },
                    { 1291, "Csaholc", "4967" },
                    { 1292, "Túrricse", "4968" },
                    { 1293, "Tisztaberek", "4969" },
                    { 1294, "Rozsály", "4971" },
                    { 1295, "Gacsály", "4972" },
                    { 1296, "Császló", "4973" },
                    { 1297, "Zajta", "4974" },
                    { 1298, "Méhtelek", "4975" },
                    { 1299, "Garbolc", "4976" },
                    { 1300, "Nagyhódos", "4977" },
                    { 1301, "Kishódos", "4977" },
                    { 1302, "Szolnok", "5000" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1303, "Szolnok-Szandaszőllős", "5008" },
                    { 1304, "Zagyvarékas", "5051" },
                    { 1305, "Újszász", "5052" },
                    { 1306, "Szászberek", "5053" },
                    { 1307, "Jászalsószentgyörgy", "5054" },
                    { 1308, "Jászladány", "5055" },
                    { 1309, "Tiszasüly", "5061" },
                    { 1310, "Kőtelek", "5062" },
                    { 1311, "Hunyadfalva", "5063" },
                    { 1312, "Csataszög", "5064" },
                    { 1313, "Nagykörû", "5065" },
                    { 1314, "Besenyszög", "5071" },
                    { 1315, "Szajol", "5081" },
                    { 1316, "Tiszatenyő", "5082" },
                    { 1317, "Kengyel", "5083" },
                    { 1318, "Rákócziújfalu", "5084" },
                    { 1319, "Rákóczifalva", "5085" },
                    { 1320, "Tószeg", "5091" },
                    { 1321, "Tiszavárkony", "5092" },
                    { 1322, "Vezseny", "5093" },
                    { 1323, "Tiszajenő", "5094" },
                    { 1324, "Tiszavárkony-Tiszavárkonyi Szőlők", "5095" },
                    { 1325, "Jászberény", "5100" },
                    { 1326, "Jászfelsőszentgyörgy", "5111" },
                    { 1327, "Jászjákóhalma", "5121" },
                    { 1328, "Jászdózsa", "5122" },
                    { 1329, "Jászárokszállás", "5123" },
                    { 1330, "Jászágó", "5124" },
                    { 1331, "Pusztamonostor", "5125" },
                    { 1332, "Jászfényszaru", "5126" },
                    { 1333, "Jászapáti", "5130" },
                    { 1334, "Jászivány", "5135" },
                    { 1335, "Jászszentandrás", "5136" },
                    { 1336, "Jászkisér", "5137" },
                    { 1337, "Jásztelek", "5141" },
                    { 1338, "Alattyán", "5142" },
                    { 1339, "Jánoshida", "5143" },
                    { 1340, "Jászboldogháza", "5144" },
                    { 1341, "Jászberény-Portelek", "5152" },
                    { 1342, "Törökszentmiklós", "5200" },
                    { 1343, "Tiszapüspöki", "5211" },
                    { 1344, "Törökszentmiklós-Surjány", "5212" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1345, "Fegyvernek-Szapárfalu", "5213" },
                    { 1346, "Örményes", "5222" },
                    { 1347, "Fegyvernek", "5231" },
                    { 1348, "Tiszabő", "5232" },
                    { 1349, "Tiszagyenda", "5233" },
                    { 1350, "Tiszaroff", "5234" },
                    { 1351, "Tiszabura", "5235" },
                    { 1352, "Abádszalók", "5241" },
                    { 1353, "Tiszaderzs", "5243" },
                    { 1354, "Tiszaszőlős", "5244" },
                    { 1355, "Karcag", "5300" },
                    { 1356, "Berekfürdő", "5309" },
                    { 1357, "Kisújszállás", "5310" },
                    { 1358, "Kunmadaras", "5321" },
                    { 1359, "Tiszaszentimre", "5322" },
                    { 1360, "Tiszaszentimre-Újszentgyörgy", "5323" },
                    { 1361, "Tomajmonostora", "5324" },
                    { 1362, "Kenderes", "5331" },
                    { 1363, "Kunhegyes", "5340" },
                    { 1364, "Kenderes-Bánhalma", "5349" },
                    { 1365, "Tiszafüred", "5350" },
                    { 1366, "Tiszafüred-Tiszaörvény", "5358" },
                    { 1367, "Tiszafüred-Kócsújfalu", "5359" },
                    { 1368, "Tiszaigar", "5361" },
                    { 1369, "Tiszaörs", "5362" },
                    { 1370, "Nagyiván", "5363" },
                    { 1371, "Mezőtúr", "5400" },
                    { 1372, "Kétpó", "5411" },
                    { 1373, "Kuncsorba", "5412" },
                    { 1374, "Túrkeve", "5420" },
                    { 1375, "Tiszaföldvár", "5430" },
                    { 1376, "Martfû", "5435" },
                    { 1377, "Kunszentmárton", "5440" },
                    { 1378, "Kunszentmárton-Kungyalu", "5449" },
                    { 1379, "Öcsöd", "5451" },
                    { 1380, "Mesterszállás", "5452" },
                    { 1381, "Mezőhék", "5453" },
                    { 1382, "Tiszaföldvár-Homok", "5461" },
                    { 1383, "Cibakháza", "5462" },
                    { 1384, "Nagyrév", "5463" },
                    { 1385, "Tiszainoka", "5464" },
                    { 1386, "Cserkeszőlő", "5465" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1387, "Tiszakürt", "5471" },
                    { 1388, "Tiszasas", "5474" },
                    { 1389, "Csépa", "5475" },
                    { 1390, "Szelevény", "5476" },
                    { 1391, "Gyomaendrőd-Gyoma", "5500" },
                    { 1392, "Gyomaendrőd-Endrőd", "5502" },
                    { 1393, "Dévaványa", "5510" },
                    { 1394, "Ecsegfalva", "5515" },
                    { 1395, "Körösladány", "5516" },
                    { 1396, "Szeghalom", "5520" },
                    { 1397, "Füzesgyarmat", "5525" },
                    { 1398, "Kertészsziget", "5526" },
                    { 1399, "Bucsa", "5527" },
                    { 1400, "Vésztő", "5530" },
                    { 1401, "Okány", "5534" },
                    { 1402, "Körösújfalu", "5536" },
                    { 1403, "Zsadány", "5537" },
                    { 1404, "Biharugra", "5538" },
                    { 1405, "Körösnagyharsány", "5539" },
                    { 1406, "Szarvas", "5540" },
                    { 1407, "Csabacsûd", "5551" },
                    { 1408, "Kardos", "5552" },
                    { 1409, "Kondoros", "5553" },
                    { 1410, "Hunya", "5555" },
                    { 1411, "Örménykút", "5556" },
                    { 1412, "Békésszentandrás", "5561" },
                    { 1413, "Békéscsaba", "5600" },
                    { 1414, "Csabaszabadi ", "5609" },
                    { 1415, "Csárdaszállás", "5621" },
                    { 1416, "Köröstarcsa", "5622" },
                    { 1417, "Békéscsaba-Gerla", "5623" },
                    { 1418, "Doboz", "5624" },
                    { 1419, "Békés", "5630" },
                    { 1420, "Tarhos", "5641" },
                    { 1421, "Bélmegyer", "5643" },
                    { 1422, "Mezőberény", "5650" },
                    { 1423, "Újkígyós", "5661" },
                    { 1424, "Csanádapáca", "5662" },
                    { 1425, "Medgyesbodzás", "5663" },
                    { 1426, "Medgyesbodzás-Gábortelep", "5664" },
                    { 1427, "Pusztaottlaka", "5665" },
                    { 1428, "Medgyesegyháza  ", "5666" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1429, "Magyarbánhegyes", "5667" },
                    { 1430, "Nagybánhegyes", "5668" },
                    { 1431, "Békéscsaba-Mezőmegyer", "5671" },
                    { 1432, "Murony", "5672" },
                    { 1433, "Kamut", "5673" },
                    { 1434, "Kétsoprony", "5674" },
                    { 1435, "Telekgerendás", "5675" },
                    { 1436, "Gyula", "5700" },
                    { 1437, "Gyula-Gyulavári", "5711" },
                    { 1438, "Szabadkígyós", "5712" },
                    { 1439, "Sarkad", "5720" },
                    { 1440, "Kötegyán", "5725" },
                    { 1441, "Méhkerék", "5726" },
                    { 1442, "Újszalonta", "5727" },
                    { 1443, "Sarkadkeresztúr", "5731" },
                    { 1444, "Mezőgyán", "5732" },
                    { 1445, "Geszt", "5734" },
                    { 1446, "Kétegyháza", "5741" },
                    { 1447, "Elek", "5742" },
                    { 1448, "Lőkösháza", "5743" },
                    { 1449, "Kevermes", "5744" },
                    { 1450, "Dombiratos", "5745" },
                    { 1451, "Kunágota", "5746" },
                    { 1452, "Almáskamarás", "5747" },
                    { 1453, "Nagykamarás", "5751" },
                    { 1454, "Medgyesegyháza-Bánkút", "5752" },
                    { 1455, "Mezőkovácsháza", "5800" },
                    { 1456, "Végegyháza", "5811" },
                    { 1457, "Mezőhegyes", "5820" },
                    { 1458, "Battonya", "5830" },
                    { 1459, "Dombegyház", "5836" },
                    { 1460, "Kisdombegyház", "5837" },
                    { 1461, "Magyardombegyház", "5838" },
                    { 1462, "Orosháza", "5900" },
                    { 1463, "Orosháza-Rákóczitelep", "5903" },
                    { 1464, "Orosháza-Gyopárosfürdő", "5904" },
                    { 1465, "Orosháza-Szentetornya", "5905" },
                    { 1466, "Pusztaföldvár", "5919" },
                    { 1467, "Csorvás", "5920" },
                    { 1468, "Gerendás", "5925" },
                    { 1469, "Nagyszénás", "5931" },
                    { 1470, "Gádoros", "5932" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1471, "Tótkomlós", "5940" },
                    { 1472, "Kardoskút", "5945" },
                    { 1473, "Békéssámson", "5946" },
                    { 1474, "Kaszaper", "5948" },
                    { 1475, "Kecskemét", "6000" },
                    { 1476, "Kecskemét-Méntelek", "6008" },
                    { 1477, "Szentkirály", "6031" },
                    { 1478, "Nyárlőrinc", "6032" },
                    { 1479, "Városföld", "6033" },
                    { 1480, "Helvécia", "6034" },
                    { 1481, "Ballószög", "6035" },
                    { 1482, "Kerekegyháza", "6041" },
                    { 1483, "Fülöpháza", "6042" },
                    { 1484, "Kunbaracs", "6043" },
                    { 1485, "Kecskemét-Hetényegyháza", "6044" },
                    { 1486, "Ladánybene", "6045" },
                    { 1487, "Lajosmizse", "6050" },
                    { 1488, "Felsőlajos ", "6055" },
                    { 1489, "Tiszakécske", "6060" },
                    { 1490, "Tiszakécske-Tiszabög", "6062" },
                    { 1491, "Tiszaug", "6064" },
                    { 1492, "Lakitelek", "6065" },
                    { 1493, "Tiszaalpár-Alpár", "6066" },
                    { 1494, "Tiszaalpár-Tiszaújfalu", "6067" },
                    { 1495, "Izsák", "6070" },
                    { 1496, "Páhi", "6075" },
                    { 1497, "Ágasegyháza", "6076" },
                    { 1498, "Orgovány", "6077" },
                    { 1499, "Jakabszállás", "6078" },
                    { 1500, "Szabadszállás", "6080" },
                    { 1501, "Fülöpszállás", "6085" },
                    { 1502, "Szalkszentmárton", "6086" },
                    { 1503, "Dunavecse", "6087" },
                    { 1504, "Apostag", "6088" },
                    { 1505, "Kunszentmiklós ", "6090" },
                    { 1506, "Kunpeszér", "6096" },
                    { 1507, "Kunadacs", "6097" },
                    { 1508, "Tass", "6098" },
                    { 1509, "Kiskunfélegyháza", "6100" },
                    { 1510, "Gátér", "6111" },
                    { 1511, "Pálmonostora", "6112" },
                    { 1512, "Petőfiszállás", "6113" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1513, "Bugac", "6114" },
                    { 1514, "Bugacpusztaháza", "6114" },
                    { 1515, "Kunszállás", "6115" },
                    { 1516, "Fülöpjakab ", "6116" },
                    { 1517, "Kiskunmajsa", "6120" },
                    { 1518, "Szank", "6131" },
                    { 1519, "Móricgát ", "6132" },
                    { 1520, "Jászszentlászló", "6133" },
                    { 1521, "Kömpöc", "6134" },
                    { 1522, "Csólyospálos", "6135" },
                    { 1523, "Harkakötöny", "6136" },
                    { 1524, "Kiskőrös", "6200" },
                    { 1525, "Kaskantyú", "6211" },
                    { 1526, "Akasztó", "6221" },
                    { 1527, "Csengőd", "6222" },
                    { 1528, "Soltszentimre", "6223" },
                    { 1529, "Tabdi", "6224" },
                    { 1530, "Soltvadkert", "6230" },
                    { 1531, "Bócsa", "6235" },
                    { 1532, "Tázlár", "6236" },
                    { 1533, "Kecel", "6237" },
                    { 1534, "Imrehegy", "6238" },
                    { 1535, "Császártöltés", "6239" },
                    { 1536, "Kalocsa", "6300" },
                    { 1537, "Öregcsertő", "6311" },
                    { 1538, "Solt", "6320" },
                    { 1539, "Újsolt", "6321" },
                    { 1540, "Dunaegyháza", "6323" },
                    { 1541, "Dunatetétlen", "6325" },
                    { 1542, "Harta ", "6326" },
                    { 1543, "Harta-Állampuszta", "6327" },
                    { 1544, "Dunapataj", "6328" },
                    { 1545, "Foktő", "6331" },
                    { 1546, "Uszód", "6332" },
                    { 1547, "Dunaszentbenedek", "6333" },
                    { 1548, "Géderlak", "6334" },
                    { 1549, "Ordas", "6335" },
                    { 1550, "Szakmár", "6336" },
                    { 1551, "Újtelek", "6337" },
                    { 1552, "Homokmégy", "6341" },
                    { 1553, "Drágszél", "6342" },
                    { 1554, "Miske", "6343" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1555, "Hajós", "6344" },
                    { 1556, "Nemesnádudvar", "6345" },
                    { 1557, "Sükösd", "6346" },
                    { 1558, "Érsekcsanád", "6347" },
                    { 1559, "Érsekhalma", "6348" },
                    { 1560, "Bátya", "6351" },
                    { 1561, "Fajsz", "6352" },
                    { 1562, "Dusnok", "6353" },
                    { 1563, "Kiskunhalas", "6400" },
                    { 1564, "Zsana", "6411" },
                    { 1565, "Balotaszállás", "6412" },
                    { 1566, "Kunfehértó", "6413" },
                    { 1567, "Pirtó", "6414" },
                    { 1568, "Kisszállás", "6421" },
                    { 1569, "Tompa", "6422" },
                    { 1570, "Kelebia", "6423" },
                    { 1571, "Csikéria", "6424" },
                    { 1572, "Bácsszőlős", "6425" },
                    { 1573, "Bácsalmás", "6430" },
                    { 1574, "Kunbaja", "6435" },
                    { 1575, "Jánoshalma", "6440" },
                    { 1576, "Kéleshalom ", "6444" },
                    { 1577, "Borota", "6445" },
                    { 1578, "Rém", "6446" },
                    { 1579, "Felsőszentiván", "6447" },
                    { 1580, "Csávoly", "6448" },
                    { 1581, "Mélykút", "6449" },
                    { 1582, "Tataháza", "6451" },
                    { 1583, "Mátételke", "6452" },
                    { 1584, "Bácsbokod", "6453" },
                    { 1585, "Bácsborsód", "6454" },
                    { 1586, "Katymár", "6455" },
                    { 1587, "Madaras", "6456" },
                    { 1588, "Baja", "6500" },
                    { 1589, "Baja-Bajaszentistván", "6503" },
                    { 1590, "Bácsszentgyörgy", "6511" },
                    { 1591, "Szeremle", "6512" },
                    { 1592, "Dunafalva", "6513" },
                    { 1593, "Vaskút", "6521" },
                    { 1594, "Gara", "6522" },
                    { 1595, "Csátalja", "6523" },
                    { 1596, "Dávod", "6524" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1597, "Hercegszántó", "6525" },
                    { 1598, "Nagybaracska", "6527" },
                    { 1599, "Bátmonostor", "6528" },
                    { 1600, "Szentes", "6600" },
                    { 1601, "Nagytőke", "6612" },
                    { 1602, "Derekegyház", "6621" },
                    { 1603, "Nagymágocs", "6622" },
                    { 1604, "Árpádhalom", "6623" },
                    { 1605, "Eperjes", "6624" },
                    { 1606, "Fábiánsebestyén", "6625" },
                    { 1607, "Mindszent", "6630" },
                    { 1608, "Szegvár", "6635" },
                    { 1609, "Mártély", "6636" },
                    { 1610, "Csongrád", "6640" },
                    { 1611, "Felgyő", "6645" },
                    { 1612, "Tömörkény", "6646" },
                    { 1613, "Csanytelek", "6647" },
                    { 1614, "Csongrád-Bokros", "6648" },
                    { 1615, "Szeged*", "6700" },
                    { 1616, "Algyő", "6750" },
                    { 1617, "Újszentiván", "6754" },
                    { 1618, "Kübekháza", "6755" },
                    { 1619, "Tiszasziget", "6756" },
                    { 1620, "Röszke", "6758" },
                    { 1621, "Kistelek", "6760" },
                    { 1622, "Sándorfalva", "6762" },
                    { 1623, "Szatymaz", "6763" },
                    { 1624, "Balástya", "6764" },
                    { 1625, "Csengele", "6765" },
                    { 1626, "Dóc", "6766" },
                    { 1627, "Ópusztaszer", "6767" },
                    { 1628, "Baks", "6768" },
                    { 1629, "Pusztaszer", "6769" },
                    { 1630, "Deszk", "6772" },
                    { 1631, "Klárafalva", "6773" },
                    { 1632, "Ferencszállás", "6774" },
                    { 1633, "Kiszombor", "6775" },
                    { 1634, "Domaszék", "6781" },
                    { 1635, "Mórahalom", "6782" },
                    { 1636, "Ásotthalom", "6783" },
                    { 1637, "Öttömös", "6784" },
                    { 1638, "Pusztamérges", "6785" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1639, "Ruzsa", "6786" },
                    { 1640, "Zákányszék", "6787" },
                    { 1641, "Zsombó", "6792" },
                    { 1642, "Forráskút", "6793" },
                    { 1643, "Üllés", "6794" },
                    { 1644, "Bordány", "6795" },
                    { 1645, "Hódmezővásárhely", "6800" },
                    { 1646, "Hódmezővásárhely-Kútvölgy", "6805" },
                    { 1647, "Hódmezővásárhely-Szikáncs", "6806" },
                    { 1648, "Székkutas", "6821" },
                    { 1649, "Makó", "6900" },
                    { 1650, "Makó-Rákos", "6903" },
                    { 1651, "Királyhegyes", "6911" },
                    { 1652, "Kövegy", "6912" },
                    { 1653, "Csanádpalota", "6913" },
                    { 1654, "Pitvaros", "6914" },
                    { 1655, "Csanádalberti", "6915" },
                    { 1656, "Ambrózfalva", "6916" },
                    { 1657, "Nagyér", "6917" },
                    { 1658, "Maroslele", "6921" },
                    { 1659, "Földeák", "6922" },
                    { 1660, "Óföldeák", "6923" },
                    { 1661, "Apátfalva", "6931" },
                    { 1662, "Magyarcsanád", "6932" },
                    { 1663, "Nagylak", "6933" },
                    { 1664, "Sárbogárd", "7000" },
                    { 1665, "Sárbogárd-Sárszentmiklós", "7003" },
                    { 1666, "Alap", "7011" },
                    { 1667, "Alsószentiván", "7012" },
                    { 1668, "Cece", "7013" },
                    { 1669, "Sáregres", "7014" },
                    { 1670, "Igar", "7015" },
                    { 1671, "Mezőszilas", "7017" },
                    { 1672, "Sárbogárd-Pusztaegres", "7018" },
                    { 1673, "Sárbogárd-Sárhatvan", "7019" },
                    { 1674, "Dunaföldvár", "7020" },
                    { 1675, "Bölcske", "7025" },
                    { 1676, "Madocsa", "7026" },
                    { 1677, "Paks-Dunakömlőd", "7027" },
                    { 1678, "Paks", "7030" },
                    { 1679, "Pusztahencse", "7038" },
                    { 1680, "Németkér", "7039" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1681, "Vajta", "7041" },
                    { 1682, "Pálfa", "7042" },
                    { 1683, "Bikács", "7043" },
                    { 1684, "Nagydorog", "7044" },
                    { 1685, "Györköny", "7045" },
                    { 1686, "Sárszentlőrinc", "7047" },
                    { 1687, "Kajdacs", "7051" },
                    { 1688, "Kölesd", "7052" },
                    { 1689, "Tengelic", "7054" },
                    { 1690, "Szedres", "7056" },
                    { 1691, "Medina", "7057" },
                    { 1692, "Belecska", "7061" },
                    { 1693, "Keszőhidegkút", "7062" },
                    { 1694, "Szárazd", "7063" },
                    { 1695, "Gyönk", "7064" },
                    { 1696, "Miszla", "7065" },
                    { 1697, "Udvari", "7066" },
                    { 1698, "Varsád", "7067" },
                    { 1699, "Kistormás", "7068" },
                    { 1700, "Szakadát", "7071" },
                    { 1701, "Diósberény", "7072" },
                    { 1702, "Simontornya", "7081" },
                    { 1703, "Kisszékely", "7082" },
                    { 1704, "Tolnanémedi", "7083" },
                    { 1705, "Pincehely", "7084" },
                    { 1706, "Nagyszékely", "7085" },
                    { 1707, "Ozora", "7086" },
                    { 1708, "Fürged", "7087" },
                    { 1709, "Tamási", "7090" },
                    { 1710, "Pári", "7091" },
                    { 1711, "Nagykónyi", "7092" },
                    { 1712, "Értény", "7093" },
                    { 1713, "Koppányszántó", "7094" },
                    { 1714, "Iregszemcse", "7095" },
                    { 1715, "Újireg", "7095" },
                    { 1716, "Nagyszokoly", "7097" },
                    { 1717, "Magyarkeszi", "7098" },
                    { 1718, "Felsőnyék", "7099" },
                    { 1719, "Szekszárd", "7100" },
                    { 1720, "Szálka", "7121" },
                    { 1721, "Kakasd", "7122" },
                    { 1722, "Tolna", "7130" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1723, "Tolna-Mözs", "7131" },
                    { 1724, "Bogyiszló", "7132" },
                    { 1725, "Fadd", "7133" },
                    { 1726, "Gerjen", "7134" },
                    { 1727, "Dunaszentgyörgy", "7135" },
                    { 1728, "Fácánkert", "7136" },
                    { 1729, "Bátaszék", "7140" },
                    { 1730, "Pörböly", "7142" },
                    { 1731, "őcsény", "7143" },
                    { 1732, "Decs", "7144" },
                    { 1733, "Sárpilis", "7145" },
                    { 1734, "Várdomb", "7146" },
                    { 1735, "Alsónána", "7147" },
                    { 1736, "Alsónyék", "7148" },
                    { 1737, "Báta", "7149" },
                    { 1738, "Bonyhád", "7150" },
                    { 1739, "Bonyhádvarasd", "7158" },
                    { 1740, "Kisdorog", "7159" },
                    { 1741, "Cikó", "7161" },
                    { 1742, "Grábóc", "7162" },
                    { 1743, "Mőcsény", "7163" },
                    { 1744, "Bátaapáti", "7164" },
                    { 1745, "Mórágy", "7165" },
                    { 1746, "Sióagárd", "7171" },
                    { 1747, "Harc", "7172" },
                    { 1748, "Zomba", "7173" },
                    { 1749, "Kéty", "7174" },
                    { 1750, "Felsőnána", "7175" },
                    { 1751, "Murga", "7176" },
                    { 1752, "Tevel", "7181" },
                    { 1753, "Závod", "7182" },
                    { 1754, "Kisvejke", "7183" },
                    { 1755, "Lengyel", "7184" },
                    { 1756, "Mucsfa", "7185" },
                    { 1757, "Aparhant", "7186" },
                    { 1758, "Nagyvejke", "7186" },
                    { 1759, "Bonyhád-Majos", "7187" },
                    { 1760, "Szárász", "7188" },
                    { 1761, "Hőgyész", "7191" },
                    { 1762, "Szakály", "7192" },
                    { 1763, "Regöly", "7193" },
                    { 1764, "Kalaznó", "7194" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1765, "Mucsi", "7195" },
                    { 1766, "Dombóvár", "7200" },
                    { 1767, "Dalmand", "7211" },
                    { 1768, "Kocsola", "7212" },
                    { 1769, "Szakcs", "7213" },
                    { 1770, "Lápafő", "7214" },
                    { 1771, "Várong", "7214" },
                    { 1772, "Nak", "7215" },
                    { 1773, "Dúzs", "7224" },
                    { 1774, "Csibrák", "7225" },
                    { 1775, "Kurd", "7226" },
                    { 1776, "Gyulaj", "7227" },
                    { 1777, "Döbrököz", "7228" },
                    { 1778, "Kapospula", "7251" },
                    { 1779, "Attala", "7252" },
                    { 1780, "Csoma", "7253" },
                    { 1781, "Szabadi", "7253" },
                    { 1782, "Nagyberki", "7255" },
                    { 1783, "Kercseliget", "7256" },
                    { 1784, "Mosdós", "7257" },
                    { 1785, "Baté", "7258" },
                    { 1786, "Kaposkeresztúr", "7258" },
                    { 1787, "Taszár", "7261" },
                    { 1788, "Kaposhomok", "7261" },
                    { 1789, "Fonó", "7271" },
                    { 1790, "Gölle", "7272" },
                    { 1791, "Büssü", "7273" },
                    { 1792, "Kazsok", "7274" },
                    { 1793, "Igal", "7275" },
                    { 1794, "Somogyszil", "7276" },
                    { 1795, "Gadács", "7276" },
                    { 1796, "Kisgyalán", "7279" },
                    { 1797, "Bonnya", "7281" },
                    { 1798, "Kisbárapáti", "7282" },
                    { 1799, "Fiad", "7282" },
                    { 1800, "Somogyacsa", "7283" },
                    { 1801, "Somogydöröcske", "7284" },
                    { 1802, "Törökkoppány", "7285" },
                    { 1803, "Kára", "7285" },
                    { 1804, "Szorosad", "7285" },
                    { 1805, "Komló", "7300" },
                    { 1806, "Mánfa ", "7304" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1807, "Mecsekpölöske", "7305" },
                    { 1808, "Liget", "7331" },
                    { 1809, "Magyaregregy", "7332" },
                    { 1810, "Kárász", "7333" },
                    { 1811, "Vékény", "7333" },
                    { 1812, "Szalatnak", "7334" },
                    { 1813, "Köblény", "7334" },
                    { 1814, "Csikóstőttős", "7341" },
                    { 1815, "Mágocs", "7342" },
                    { 1816, "Nagyhajmás", "7343" },
                    { 1817, "Mekényes", "7344" },
                    { 1818, "Alsómocsolád", "7345" },
                    { 1819, "Bikal", "7346" },
                    { 1820, "Egyházaskozár", "7347" },
                    { 1821, "Hegyhátmaróc", "7348" },
                    { 1822, "Tófû", "7348" },
                    { 1823, "Szászvár", "7349" },
                    { 1824, "Máza", "7351" },
                    { 1825, "Györe", "7352" },
                    { 1826, "Izmény", "7353" },
                    { 1827, "Váralja", "7354" },
                    { 1828, "Nagymányok", "7355" },
                    { 1829, "Kismányok", "7356" },
                    { 1830, "Jágónak", "7357" },
                    { 1831, "Kaposszekcső", "7361" },
                    { 1832, "Vásárosdombó", "7362" },
                    { 1833, "Gerényes", "7362" },
                    { 1834, "Tarrós", "7362" },
                    { 1835, "Sásd", "7370" },
                    { 1836, "Felsőegerszeg", "7370" },
                    { 1837, "Meződ", "7370" },
                    { 1838, "Oroszló", "7370" },
                    { 1839, "Palé", "7370" },
                    { 1840, "Varga", "7370" },
                    { 1841, "Vázsnok", "7370" },
                    { 1842, "Kisvaszar", "7381" },
                    { 1843, "Ág", "7381" },
                    { 1844, "Tékes", "7381" },
                    { 1845, "Tormás", "7383" },
                    { 1846, "Baranyaszentgyörgy", "7383" },
                    { 1847, "Szágy", "7383" },
                    { 1848, "Baranyajenő", "7384" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1849, "Gödre-Gödreszentmárton  ", "7385" },
                    { 1850, "Gödre-Gödrekeresztúr", "7386" },
                    { 1851, "Mindszentgodisa", "7391" },
                    { 1852, "Kisbeszterce", "7391" },
                    { 1853, "Kishajmás", "7391" },
                    { 1854, "Bakóca", "7393" },
                    { 1855, "Magyarhertelend", "7394" },
                    { 1856, "Bodolyabér", "7394" },
                    { 1857, "Magyarszék", "7396" },
                    { 1858, "Kaposvár", "7400" },
                    { 1859, "Orci", "7400" },
                    { 1860, "Zselickislak", "7400" },
                    { 1861, "Juta", "7431" },
                    { 1862, "Hetes", "7432" },
                    { 1863, "Csombárd", "7432" },
                    { 1864, "Mezőcsokonya", "7434" },
                    { 1865, "Somogysárd", "7435" },
                    { 1866, "Újvárfalva", "7436" },
                    { 1867, "Bodrog", "7439" },
                    { 1868, "Magyaregres", "7441" },
                    { 1869, "Várda", "7442" },
                    { 1870, "Somogyjád", "7443" },
                    { 1871, "Alsóbogát", "7443" },
                    { 1872, "Edde", "7443" },
                    { 1873, "Osztopán", "7444" },
                    { 1874, "Somogyaszaló", "7452" },
                    { 1875, "Kaposvár-Kaposfüred", "7451" },
                    { 1876, "Mernye", "7453" },
                    { 1877, "Somodor", "7454" },
                    { 1878, "Somogygeszti", "7455" },
                    { 1879, "Felsőmocsolád", "7456" },
                    { 1880, "Ecseny", "7457" },
                    { 1881, "Polány", "7458" },
                    { 1882, "Kaposvár-Toponár", "7461" },
                    { 1883, "Magyaratád", "7463" },
                    { 1884, "Patalom", "7463" },
                    { 1885, "Ráksi", "7464" },
                    { 1886, "Szentgáloskér", "7465" },
                    { 1887, "Zimány", "7471" },
                    { 1888, "Szentbalázs", "7472" },
                    { 1889, "Cserénfa", "7472" },
                    { 1890, "Gálosfa", "7473" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1891, "Hajmás", "7473" },
                    { 1892, "Kaposgyarmat", "7473" },
                    { 1893, "Simonfa", "7474" },
                    { 1894, "Zselicszentpál", "7474" },
                    { 1895, "Bőszénfa", "7475" },
                    { 1896, "Kaposszerdahely", "7476" },
                    { 1897, "Szenna", "7477" },
                    { 1898, "Patca", "7477" },
                    { 1899, "Szilvásszentmárton", "7477" },
                    { 1900, "Zselickisfalud", "7477" },
                    { 1901, "Bárdudvarnok", "7478" },
                    { 1902, "Sántos", "7479" },
                    { 1903, "Nagyatád", "7500" },
                    { 1904, "Ötvöskónyi", "7511" },
                    { 1905, "Mike", "7512" },
                    { 1906, "Rinyaszentkirály", "7513" },
                    { 1907, "Tarany", "7514" },
                    { 1908, "Somogyudvarhely", "7515" },
                    { 1909, "Berzence", "7516" },
                    { 1910, "Bolhás", "7517" },
                    { 1911, "Kaposmérő", "7521" },
                    { 1912, "Kaposújlak", "7522" },
                    { 1913, "Kaposfő", "7523" },
                    { 1914, "Kisasszond", "7523" },
                    { 1915, "Kiskorpád", "7524" },
                    { 1916, "Jákó", "7525" },
                    { 1917, "Csököly", "7526" },
                    { 1918, "Gige", "7527" },
                    { 1919, "Rinyakovácsi", "7527" },
                    { 1920, "Kadarkút", "7530" },
                    { 1921, "Kőkút", "7530" },
                    { 1922, "Hencse", "7532" },
                    { 1923, "Hedrehely", "7533" },
                    { 1924, "Visnye", "7533" },
                    { 1925, "Lad", "7535" },
                    { 1926, "Patosfa", "7536" },
                    { 1927, "Homokszentgyörgy", "7537" },
                    { 1928, "Kálmáncsa", "7538" },
                    { 1929, "Szulok", "7539" },
                    { 1930, "Kutas", "7541" },
                    { 1931, "Kisbajom", "7542" },
                    { 1932, "Beleg", "7543" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1933, "Szabás", "7544" },
                    { 1934, "Nagykorpád", "7545" },
                    { 1935, "Lábod", "7551" },
                    { 1936, "Rinyabesenyő", "7552" },
                    { 1937, "Görgeteg", "7553" },
                    { 1938, "Csokonyavisonta", "7555" },
                    { 1939, "Rinyaújlak", "7556" },
                    { 1940, "Barcs-Somogytarnóca", "7557" },
                    { 1941, "Nagybajom", "7561" },
                    { 1942, "Pálmajor", "7561" },
                    { 1943, "Segesd", "7562" },
                    { 1944, "Somogyszob", "7563" },
                    { 1945, "Kaszó", "7564" },
                    { 1946, "Barcs", "7570" },
                    { 1947, "Komlósd", "7582" },
                    { 1948, "Péterhida", "7582" },
                    { 1949, "Babócsa", "7584" },
                    { 1950, "Rinyaújnép", "7584" },
                    { 1951, "Somogyaracs", "7584" },
                    { 1952, "Háromfa", "7585" },
                    { 1953, "Bakháza", "7585" },
                    { 1954, "Bolhó", "7586" },
                    { 1955, "Heresznye", "7587" },
                    { 1956, "Vízvár", "7588" },
                    { 1957, "Bélavár", "7589" },
                    { 1958, "Pécs*", "7600" },
                    { 1959, "Kökény", "7639" },
                    { 1960, "Erzsébet", "7661" },
                    { 1961, "Kátoly", "7661" },
                    { 1962, "Kékesd", "7661" },
                    { 1963, "Szellő", "7661" },
                    { 1964, "Máriakéménd", "7663" },
                    { 1965, "Berkesd", "7664" },
                    { 1966, "Pereked", "7664" },
                    { 1967, "Szilágy", "7664" },
                    { 1968, "Pogány", "7666" },
                    { 1969, "Keszü", "7668" },
                    { 1970, "Gyód", "7668" },
                    { 1971, "Bicsérd", "7671" },
                    { 1972, "Aranyosgadány", "7671" },
                    { 1973, "Zók", "7671" },
                    { 1974, "Boda", "7672" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 1975, "Kővágószőlős", "7673" },
                    { 1976, "Cserkút", "7673" },
                    { 1977, "Bakonya", "7675" },
                    { 1978, "Kővágótöttös", "7675" },
                    { 1979, "Orfû ", "7677" },
                    { 1980, "Abaliget", "7678" },
                    { 1981, "Husztót", "7678" },
                    { 1982, "Kovácsszénája", "7678" },
                    { 1983, "Hetvehely", "7681" },
                    { 1984, "Okorvölgy", "7681" },
                    { 1985, "Szentkatalin", "7681" },
                    { 1986, "Bükkösd", "7682" },
                    { 1987, "Helesfa", "7683" },
                    { 1988, "Cserdi", "7683" },
                    { 1989, "Dinnyeberki", "7683" },
                    { 1990, "Hosszúhetény", "7694" },
                    { 1991, "Mecseknádasd", "7695" },
                    { 1992, "Óbánya", "7695" },
                    { 1993, "Ófalu", "7695" },
                    { 1994, "Hidas", "7696" },
                    { 1995, "Mohács", "7700" },
                    { 1996, "Bár", "7711" },
                    { 1997, "Dunaszekcső", "7712" },
                    { 1998, "Mohács-Újmohács", "7714" },
                    { 1999, "Mohács-Sárhát", "7715" },
                    { 2000, "Homorúd", "7716" },
                    { 2001, "Kölked", "7717" },
                    { 2002, "Udvar", "7718" },
                    { 2003, "Pécsvárad", "7720" },
                    { 2004, "Apátvarasd", "7720" },
                    { 2005, "Lovászhetény", "7720" },
                    { 2006, "Martonfa", "7720" },
                    { 2007, "Zengővárkony", "7720" },
                    { 2008, "Erdősmecske", "7723" },
                    { 2009, "Feked", "7724" },
                    { 2010, "Szebény", "7725" },
                    { 2011, "Véménd", "7726" },
                    { 2012, "Palotabozsok", "7727" },
                    { 2013, "Somberek", "7728" },
                    { 2014, "Görcsönydoboka", "7728" },
                    { 2015, "Nagypall", "7731" },
                    { 2016, "Fazekasboda", "7732" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2017, "Geresdlak", "7733" },
                    { 2018, "Maráza", "7733" },
                    { 2019, "Himesháza", "7735" },
                    { 2020, "Erdősmárok", "7735" },
                    { 2021, "Szûr", "7735" },
                    { 2022, "Székelyszabar", "7737" },
                    { 2023, "Nagykozár", "7741" },
                    { 2024, "Bogád", "7742" },
                    { 2025, "Romonya", "7743" },
                    { 2026, "Ellend", "7744" },
                    { 2027, "Olasz", "7745" },
                    { 2028, "Hásságy", "7745" },
                    { 2029, "Belvárdgyula", "7747" },
                    { 2030, "Birján", "7747" },
                    { 2031, "Szederkény", "7751" },
                    { 2032, "Monyoród", "7751" },
                    { 2033, "Versend", "7752" },
                    { 2034, "Szajk", "7753" },
                    { 2035, "Bóly", "7754" },
                    { 2036, "Töttös", "7755" },
                    { 2037, "Borjád", "7756" },
                    { 2038, "Kisbudmér", "7756" },
                    { 2039, "Nagybudmér", "7756" },
                    { 2040, "Pócsa", "7756" },
                    { 2041, "Babarc", "7757" },
                    { 2042, "Liptód", "7757" },
                    { 2043, "Lánycsók", "7759" },
                    { 2044, "Kisnyárád", "7759" },
                    { 2045, "Kozármisleny", "7761" },
                    { 2046, "Lothárd", "7761" },
                    { 2047, "Magyarsarlós", "7761" },
                    { 2048, "Pécsudvard", "7762" },
                    { 2049, "Egerág", "7763" },
                    { 2050, "Áta", "7763" },
                    { 2051, "Kisherend", "7763" },
                    { 2052, "Szemely", "7763" },
                    { 2053, "Szőkéd", "7763" },
                    { 2054, "Újpetre", "7766" },
                    { 2055, "Kiskassa", "7766" },
                    { 2056, "Peterd", "7766" },
                    { 2057, "Pécsdevecser", "7766" },
                    { 2058, "Vokány", "7768" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2059, "Kistótfalu", "7768" },
                    { 2060, "Palkonya", "7771" },
                    { 2061, "Villánykövesd", "7772" },
                    { 2062, "Ivánbattyán", "7772" },
                    { 2063, "Villány", "7773" },
                    { 2064, "Kisjakabfalva", "7773" },
                    { 2065, "Márok", "7774" },
                    { 2066, "Magyarbóly", "7775" },
                    { 2067, "Illocska", "7775" },
                    { 2068, "Kislippó", "7775" },
                    { 2069, "Lapáncsa", "7775" },
                    { 2070, "Lippó", "7781" },
                    { 2071, "Ivándárda", "7781" },
                    { 2072, "Sárok", "7781" },
                    { 2073, "Bezedek", "7782" },
                    { 2074, "Majs", "7783" },
                    { 2075, "Nagynyárád", "7784" },
                    { 2076, "Sátorhely", "7785" },
                    { 2077, "Siklós", "7800" },
                    { 2078, "Kisharsány", "7800" },
                    { 2079, "Nagytótfalu", "7800" },
                    { 2080, "Szalánta", "7811" },
                    { 2081, "Bisse", "7811" },
                    { 2082, "Bosta", "7811" },
                    { 2083, "Csarnóta", "7811" },
                    { 2084, "Szilvás", "7811" },
                    { 2085, "Túrony", "7811" },
                    { 2086, "Garé", "7812" },
                    { 2087, "Szava", "7813" },
                    { 2088, "Ócsárd", "7814" },
                    { 2089, "Babarcszőlős", "7814" },
                    { 2090, "Kisdér", "7814" },
                    { 2091, "Siklósbodony", "7814" },
                    { 2092, "Harkány", "7815" },
                    { 2093, "Diósviszló", "7817" },
                    { 2094, "Márfa", "7817" },
                    { 2095, "Rádfalva", "7817" },
                    { 2096, "Nagyharsány", "7822" },
                    { 2097, "Siklósnagyfalu", "7823" },
                    { 2098, "Kistapolca", "7823" },
                    { 2099, "Egyházasharaszti", "7824" },
                    { 2100, "Old", "7825" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2101, "Alsószentmárton", "7826" },
                    { 2102, "Beremend", "7827" },
                    { 2103, "Kásád", "7827" },
                    { 2104, "Pellérd", "7831" },
                    { 2105, "Görcsöny", "7833" },
                    { 2106, "Regenye", "7833" },
                    { 2107, "Szőke", "7833" },
                    { 2108, "Baksa", "7834" },
                    { 2109, "Tengeri", "7834" },
                    { 2110, "Téseny", "7834" },
                    { 2111, "Bogádmindszent", "7836" },
                    { 2112, "Ózdfalu", "7836" },
                    { 2113, "Hegyszentmárton", "7837" },
                    { 2114, "Vajszló", "7838" },
                    { 2115, "Besence", "7838" },
                    { 2116, "Hirics", "7838" },
                    { 2117, "Lúzsok", "7838" },
                    { 2118, "Nagycsány", "7838" },
                    { 2119, "Páprád", "7838" },
                    { 2120, "Piskó", "7838" },
                    { 2121, "Vejti", "7838" },
                    { 2122, "Zaláta", "7839" },
                    { 2123, "Kemse", "7839" },
                    { 2124, "Sámod", "7841" },
                    { 2125, "Adorjás", "7841" },
                    { 2126, "Baranyahídvég", "7841" },
                    { 2127, "Kisszentmárton", "7841" },
                    { 2128, "Kórós", "7841" },
                    { 2129, "Kémes", "7843" },
                    { 2130, "Cún", "7843" },
                    { 2131, "Drávapiski", "7843" },
                    { 2132, "Szaporca", "7843" },
                    { 2133, "Tésenfa", "7843" },
                    { 2134, "Drávacsepely", "7846" },
                    { 2135, "Kovácshida", "7847" },
                    { 2136, "Drávaszerdahely", "7847" },
                    { 2137, "Ipacsfa", "7847" },
                    { 2138, "Drávacsehi", "7849" },
                    { 2139, "Drávapalkonya", "7850" },
                    { 2140, "Drávaszabolcs", "7851" },
                    { 2141, "Gordisa", "7853" },
                    { 2142, "Matty", "7854" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2143, "Szigetvár", "7900" },
                    { 2144, "Botykapeterd", "7900" },
                    { 2145, "Csertő", "7900" },
                    { 2146, "Nagypeterd", "7912" },
                    { 2147, "Nyugotszenterzsébet", "7912" },
                    { 2148, "Nagyváty", "7912" },
                    { 2149, "Szentdénes", "7913" },
                    { 2150, "Rózsafa", "7914" },
                    { 2151, "Bánfa", "7914" },
                    { 2152, "Katádfa", "7914" },
                    { 2153, "Dencsháza", "7915" },
                    { 2154, "Szentegát", "7915" },
                    { 2155, "Lakócsa", "7918" },
                    { 2156, "Szentborbás", "7918" },
                    { 2157, "Tótújfalu", "7918" },
                    { 2158, "Somogyhatvan", "7921" },
                    { 2159, "Somogyapáti", "7922" },
                    { 2160, "Basal", "7923" },
                    { 2161, "Patapoklosi", "7923" },
                    { 2162, "Somogyviszló", "7924" },
                    { 2163, "Somogyhárságy", "7925" },
                    { 2164, "Magyarlukafa", "7925" },
                    { 2165, "Vásárosbéc", "7926" },
                    { 2166, "Mozsgó", "7932" },
                    { 2167, "Almáskeresztúr", "7932" },
                    { 2168, "Szulimán", "7932" },
                    { 2169, "Almamellék", "7934" },
                    { 2170, "Ibafa", "7935" },
                    { 2171, "Csebény", "7935" },
                    { 2172, "Horváthertelend", "7935" },
                    { 2173, "Szentlászló", "7936" },
                    { 2174, "Boldogasszonyfa", "7937" },
                    { 2175, "Szentlőrinc", "7940" },
                    { 2176, "Csonkamindszent", "7940" },
                    { 2177, "Kacsóta", "7940" },
                    { 2178, "Szabadszentkirály", "7951" },
                    { 2179, "Gerde", "7951" },
                    { 2180, "Pécsbagota", "7951" },
                    { 2181, "Velény", "7951" },
                    { 2182, "Királyegyháza", "7953" },
                    { 2183, "Magyarmecske", "7954" },
                    { 2184, "Gilvánfa", "7954" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2185, "Gyöngyfa", "7954" },
                    { 2186, "Kisasszonyfa", "7954" },
                    { 2187, "Magyartelek", "7954" },
                    { 2188, "Okorág ", "7957" },
                    { 2189, "Kákics ", "7958" },
                    { 2190, "Sellye", "7960" },
                    { 2191, "Drávaiványi", "7960" },
                    { 2192, "Drávasztára", "7960" },
                    { 2193, "Marócsa", "7960" },
                    { 2194, "Sósvertike", "7960" },
                    { 2195, "Sumony", "7960" },
                    { 2196, "Csányoszró", "7964" },
                    { 2197, "Bogdása", "7966" },
                    { 2198, "Drávafok", "7967" },
                    { 2199, "Drávakeresztúr", "7967" },
                    { 2200, "Markóc", "7967" },
                    { 2201, "Felsőszentmárton", "7968" },
                    { 2202, "Hobol", "7971" },
                    { 2203, "Gyöngyösmellék", "7972" },
                    { 2204, "Teklafalu", "7973" },
                    { 2205, "Bürüs", "7973" },
                    { 2206, "Endrőc", "7973" },
                    { 2207, "Várad", "7973" },
                    { 2208, "Kétújfalu", "7975" },
                    { 2209, "Zádor", "7976" },
                    { 2210, "Szörény", "7976" },
                    { 2211, "Kastélyosdombó", "7977" },
                    { 2212, "Drávagárdony", "7977" },
                    { 2213, "Potony", "7977" },
                    { 2214, "Drávatamási", "7979" },
                    { 2215, "Pettend", "7980" },
                    { 2216, "Nemeske", "7981" },
                    { 2217, "Kistamási", "7981" },
                    { 2218, "Merenye", "7981" },
                    { 2219, "Molvány", "7981" },
                    { 2220, "Tótszentgyörgy", "7981" },
                    { 2221, "Nagydobsza", "7985" },
                    { 2222, "Kisdobsza", "7985" },
                    { 2223, "Istvándi", "7987" },
                    { 2224, "Darány", "7988" },
                    { 2225, "Székesfehérvár", "8000" },
                    { 2226, "Székesfehérvár-Börgönd", "8019" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2227, "Csór", "8041" },
                    { 2228, "Moha", "8042" },
                    { 2229, "Iszkaszentgyörgy", "8043" },
                    { 2230, "Kincsesbánya", "8044" },
                    { 2231, "Isztimér", "8045" },
                    { 2232, "Bakonykúti", "8046" },
                    { 2233, "Sárkeresztes", "8051" },
                    { 2234, "Fehérvárcsurgó", "8052" },
                    { 2235, "Bodajk", "8053" },
                    { 2236, "Balinka-Eszény", "8054" },
                    { 2237, "Balinka", "8055" },
                    { 2238, "Bakonycsernye", "8056" },
                    { 2239, "Mór", "8060" },
                    { 2240, "Nagyveleg", "8065" },
                    { 2241, "Pusztavám", "8066" },
                    { 2242, "Magyaralmás", "8071" },
                    { 2243, "Söréd", "8072" },
                    { 2244, "Csákberény", "8073" },
                    { 2245, "Csókakő", "8074" },
                    { 2246, "Bodmér", "8080" },
                    { 2247, "Zámoly", "8081" },
                    { 2248, "Gánt", "8082" },
                    { 2249, "Csákvár", "8083" },
                    { 2250, "Vértesboglár", "8085" },
                    { 2251, "Felcsút", "8086" },
                    { 2252, "Alcsútdoboz", "8087" },
                    { 2253, "Tabajd", "8088" },
                    { 2254, "Vértesacsa", "8089" },
                    { 2255, "Pátka", "8092" },
                    { 2256, "Lovasberény", "8093" },
                    { 2257, "Pákozd", "8095" },
                    { 2258, "Sukoró", "8096" },
                    { 2259, "Nadap", "8097" },
                    { 2260, "Várpalota", "8100" },
                    { 2261, "Pétfürdő", "8105" },
                    { 2262, "Tés", "8109" },
                    { 2263, "Seregélyes", "8111" },
                    { 2264, "Zichyújfalu", "8112" },
                    { 2265, "Tác", "8121" },
                    { 2266, "Csősz", "8122" },
                    { 2267, "Soponya", "8123" },
                    { 2268, "Káloz", "8124" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2269, "Sárkeresztúr", "8125" },
                    { 2270, "Sárszentágota", "8126" },
                    { 2271, "Aba", "8127" },
                    { 2272, "Enying", "8130" },
                    { 2273, "Enying-Balatonbozsok", "8131" },
                    { 2274, "Lepsény", "8132" },
                    { 2275, "Mezőszentgyörgy", "8133" },
                    { 2276, "Mátyásdomb", "8134" },
                    { 2277, "Dég", "8135" },
                    { 2278, "Lajoskomárom", "8136" },
                    { 2279, "Mezőkomárom", "8137" },
                    { 2280, "Szabadhídvég", "8138" },
                    { 2281, "Úrhida", "8142" },
                    { 2282, "Sárszentmihály", "8143" },
                    { 2283, "Sárkeszi", "8144" },
                    { 2284, "Nádasdladány", "8145" },
                    { 2285, "Jenő", "8146" },
                    { 2286, "Szabadbattyán", "8151" },
                    { 2287, "Kőszárhegy", "8152" },
                    { 2288, "Polgárdi", "8154" },
                    { 2289, "Kisláng", "8156" },
                    { 2290, "Füle", "8157" },
                    { 2291, "ősi", "8161" },
                    { 2292, "Küngös", "8162" },
                    { 2293, "Csajág", "8163" },
                    { 2294, "Balatonfőkajár", "8164" },
                    { 2295, "Balatonvilágos", "8171" },
                    { 2296, "Balatonakarattya", "8172" },
                    { 2297, "Balatonkenese", "8174" },
                    { 2298, "Balatonfûzfő", "8175" },
                    { 2299, "Berhida", "8181" },
                    { 2300, "Berhida-Peremartongyártelep", "8182" },
                    { 2301, "Papkeszi", "8183" },
                    { 2302, "Balatonfûzfő-Fûzfőgyártelep", "8184" },
                    { 2303, "Öskü", "8191" },
                    { 2304, "Hajmáskér", "8192" },
                    { 2305, "Sóly", "8193" },
                    { 2306, "Vilonya", "8194" },
                    { 2307, "Királyszentistván", "8195" },
                    { 2308, "Litér", "8196" },
                    { 2309, "Veszprém", "8200" },
                    { 2310, "Balatonalmádi", "8220" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2311, "Szentkirályszabadja", "8225" },
                    { 2312, "Alsóörs", "8226" },
                    { 2313, "Felsőörs", "8227" },
                    { 2314, "Lovas", "8228" },
                    { 2315, "Csopak", "8229" },
                    { 2316, "Paloznak", "8229" },
                    { 2317, "Balatonfüred", "8230" },
                    { 2318, "Balatonszőlős", "8233" },
                    { 2319, "Tihany", "8237" },
                    { 2320, "Aszófő", "8241" },
                    { 2321, "Balatonudvari", "8242" },
                    { 2322, "Örvényes", "8242" },
                    { 2323, "Balatonakali", "8243" },
                    { 2324, "Dörgicse", "8244" },
                    { 2325, "Pécsely", "8245" },
                    { 2326, "Vászoly", "8245" },
                    { 2327, "Tótvázsony", "8246" },
                    { 2328, "Hidegkút", "8247" },
                    { 2329, "Nemesvámos", "8248" },
                    { 2330, "Veszprémfajsz", "8248" },
                    { 2331, "Zánka ", "8251" },
                    { 2332, "Balatonszepezd", "8252" },
                    { 2333, "Révfülöp", "8253" },
                    { 2334, "Kővágóörs", "8254" },
                    { 2335, "Kékkút", "8254" },
                    { 2336, "Balatonrendes", "8255" },
                    { 2337, "Kővágóörs-Pálköve", "8255" },
                    { 2338, "Ábrahámhegy", "8256" },
                    { 2339, "Salföld", "8256" },
                    { 2340, "Badacsonytomaj-Badacsonyörs", "8257" },
                    { 2341, "Badacsonytomaj", "8258" },
                    { 2342, "Badacsonytomaj-Badacsony", "8261" },
                    { 2343, "Badacsonytördemic", "8263" },
                    { 2344, "Szigliget", "8264" },
                    { 2345, "Hegymagas", "8265" },
                    { 2346, "Mencshely", "8271" },
                    { 2347, "Szentantalfa", "8272" },
                    { 2348, "Balatoncsicsó", "8272" },
                    { 2349, "Óbudavár", "8272" },
                    { 2350, "Szentjakabfa", "8272" },
                    { 2351, "Tagyon", "8272" },
                    { 2352, "Monoszló", "8273" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2353, "Köveskál", "8274" },
                    { 2354, "Balatonhenye", "8275" },
                    { 2355, "Szentbékkálla", "8281" },
                    { 2356, "Mindszentkálla", "8282" },
                    { 2357, "Káptalantóti", "8283" },
                    { 2358, "Nemesgulács", "8284" },
                    { 2359, "Kisapáti", "8284" },
                    { 2360, "Gyulakeszi", "8286" },
                    { 2361, "Nagyvázsony", "8291" },
                    { 2362, "Barnag", "8291" },
                    { 2363, "Pula", "8291" },
                    { 2364, "Vöröstó", "8291" },
                    { 2365, "Öcs", "8292" },
                    { 2366, "Kapolcs", "8294" },
                    { 2367, "Vigántpetend", "8294" },
                    { 2368, "Taliándörögd", "8295" },
                    { 2369, "Monostorapáti", "8296" },
                    { 2370, "Hegyesd", "8296" },
                    { 2371, "Tapolca-Diszel", "8297" },
                    { 2372, "Tapolca", "8300" },
                    { 2373, "Raposka", "8300" },
                    { 2374, "Zalahaláp", "8308" },
                    { 2375, "Sáska", "8308" },
                    { 2376, "Nemesvita", "8311" },
                    { 2377, "Balatonederics", "8312" },
                    { 2378, "Balatongyörök", "8313" },
                    { 2379, "Vonyarcvashegy", "8314" },
                    { 2380, "Gyenesdiás", "8315" },
                    { 2381, "Várvölgy", "8316" },
                    { 2382, "Vállus", "8316" },
                    { 2383, "Lesencefalu", "8317" },
                    { 2384, "Lesencetomaj", "8318" },
                    { 2385, "Lesenceistvánd", "8319" },
                    { 2386, "Uzsa", "8321" },
                    { 2387, "Sümeg", "8330" },
                    { 2388, "Mihályfa", "8341" },
                    { 2389, "Kisvásárhely", "8341" },
                    { 2390, "Szalapa", "8341" },
                    { 2391, "Óhíd", "8342" },
                    { 2392, "Zalaerdőd", "8344" },
                    { 2393, "Hetyefő", "8344" },
                    { 2394, "Dabronc", "8345" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2395, "Gógánfa", "8346" },
                    { 2396, "Ukk", "8347" },
                    { 2397, "Rigács", "8348" },
                    { 2398, "Megyer", "8348" },
                    { 2399, "Zalameggyes", "8348" },
                    { 2400, "Zalagyömörő", "8349" },
                    { 2401, "Sümegprága", "8351" },
                    { 2402, "Bazsi", "8352" },
                    { 2403, "Zalaszántó", "8353" },
                    { 2404, "Vindornyalak", "8353" },
                    { 2405, "Karmacs", "8354" },
                    { 2406, "Vindornyafok", "8354" },
                    { 2407, "Zalaköveskút", "8354" },
                    { 2408, "Vindornyaszőlős", "8355" },
                    { 2409, "Kisgörbő", "8356" },
                    { 2410, "Nagygörbő", "8356" },
                    { 2411, "Sümegcsehi", "8357" },
                    { 2412, "Döbröce", "8357" },
                    { 2413, "Keszthely", "8360" },
                    { 2414, "Nemesbük", "8371" },
                    { 2415, "Cserszegtomaj", "8372" },
                    { 2416, "Rezi", "8373" },
                    { 2417, "Hévíz", "8380" },
                    { 2418, "Sármellék", "8391" },
                    { 2419, "Zalavár", "8392" },
                    { 2420, "Szentgyörgyvár", "8393" },
                    { 2421, "Alsópáhok", "8394" },
                    { 2422, "Felsőpáhok", "8395" },
                    { 2423, "Ajka", "8400" },
                    { 2424, "Úrkút", "8409" },
                    { 2425, "Veszprém-Kádárta", "8411" },
                    { 2426, "Veszprém-Gyulafirátót", "8412" },
                    { 2427, "Eplény", "8413" },
                    { 2428, "Olaszfalu", "8414" },
                    { 2429, "Nagyesztergár", "8415" },
                    { 2430, "Dudar", "8416" },
                    { 2431, "Csetény", "8417" },
                    { 2432, "Bakonyoszlop", "8418" },
                    { 2433, "Csesznek", "8419" },
                    { 2434, "Zirc", "8420" },
                    { 2435, "Bakonynána", "8422" },
                    { 2436, "Szápár", "8423" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2437, "Jásd", "8424" },
                    { 2438, "Lókút", "8425" },
                    { 2439, "Pénzesgyőr", "8426" },
                    { 2440, "Bakonybél", "8427" },
                    { 2441, "Borzavár", "8428" },
                    { 2442, "Porva", "8429" },
                    { 2443, "Bakonyszentkirály", "8430" },
                    { 2444, "Bakonyszentlászló", "8431" },
                    { 2445, "Fenyőfő", "8432" },
                    { 2446, "Bakonygyirót", "8433" },
                    { 2447, "Románd", "8434" },
                    { 2448, "Gic", "8435" },
                    { 2449, "Veszprémvarsány", "8438" },
                    { 2450, "Sikátor", "8439" },
                    { 2451, "Herend", "8440" },
                    { 2452, "Márkó", "8441" },
                    { 2453, "Hárskút", "8442" },
                    { 2454, "Bánd", "8443" },
                    { 2455, "Szentgál", "8444" },
                    { 2456, "Városlőd", "8445" },
                    { 2457, "Csehbánya", "8445" },
                    { 2458, "Kislőd", "8446" },
                    { 2459, "Ajka-Ajkarendek", "8447" },
                    { 2460, "Ajka-Bakonygyepes", "8448" },
                    { 2461, "Magyarpolány", "8449" },
                    { 2462, "Ajka-Padragkút", "8451" },
                    { 2463, "Halimba", "8452" },
                    { 2464, "Szőc", "8452" },
                    { 2465, "Nyirád", "8454" },
                    { 2466, "Pusztamiske", "8455" },
                    { 2467, "Noszlop", "8456" },
                    { 2468, "Bakonypölöske", "8457" },
                    { 2469, "Oroszi", "8458" },
                    { 2470, "Devecser", "8460" },
                    { 2471, "Kolontár", "8468" },
                    { 2472, "Kamond", "8469" },
                    { 2473, "Káptalanfa", "8471" },
                    { 2474, "Bodorfa", "8471" },
                    { 2475, "Nemeshany", "8471" },
                    { 2476, "Gyepükaján", "8473" },
                    { 2477, "Csabrendek", "8474" },
                    { 2478, "Veszprémgalsa", "8475" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2479, "Hosztót", "8475" },
                    { 2480, "Szentimrefalva", "8475" },
                    { 2481, "Zalaszegvár", "8476" },
                    { 2482, "Tüskevár", "8477" },
                    { 2483, "Apácatorna", "8477" },
                    { 2484, "Kisberzseny", "8477" },
                    { 2485, "Somlójenő", "8478" },
                    { 2486, "Borszörcsök", "8479" },
                    { 2487, "Somlóvásárhely", "8481" },
                    { 2488, "Doba", "8482" },
                    { 2489, "Somlószőlős", "8483" },
                    { 2490, "Kisszőlős", "8483" },
                    { 2491, "Nagyalásony", "8484" },
                    { 2492, "Somlóvecse", "8484" },
                    { 2493, "Vid", "8484" },
                    { 2494, "Dabrony", "8485" },
                    { 2495, "Karakószörcsök", "8491" },
                    { 2496, "Kerta", "8492" },
                    { 2497, "Iszkáz", "8493" },
                    { 2498, "Kiscsősz", "8494" },
                    { 2499, "Csögle", "8495" },
                    { 2500, "Nagypirit", "8496" },
                    { 2501, "Kispirit", "8496" },
                    { 2502, "Adorjánháza", "8497" },
                    { 2503, "Egeralja", "8497" },
                    { 2504, "Pápa", "8500" },
                    { 2505, "Pápa-Borsosgyőr", "8511" },
                    { 2506, "Nyárád", "8512" },
                    { 2507, "Mihályháza", "8513" },
                    { 2508, "Mezőlak", "8514" },
                    { 2509, "Békás", "8515" },
                    { 2510, "Kemeneshőgyész", "8516" },
                    { 2511, "Magyargencs", "8517" },
                    { 2512, "Kemenesszentpéter", "8518" },
                    { 2513, "Nagyacsád", "8521" },
                    { 2514, "Nemesgörzsöny", "8522" },
                    { 2515, "Egyházaskesző", "8523" },
                    { 2516, "Várkesző", "8523" },
                    { 2517, "Marcaltő-Ihász", "8531" },
                    { 2518, "Marcaltő", "8532" },
                    { 2519, "Malomsok", "8533" },
                    { 2520, "Takácsi", "8541" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2521, "Vaszar", "8542" },
                    { 2522, "Gecse", "8543" },
                    { 2523, "Nagygyimót", "8551" },
                    { 2524, "Vanyola", "8552" },
                    { 2525, "Lovászpatona", "8553" },
                    { 2526, "Nagydém", "8554" },
                    { 2527, "Bakonytamási", "8555" },
                    { 2528, "Pápateszér", "8556" },
                    { 2529, "Bakonyszentiván", "8557" },
                    { 2530, "Bakonyság", "8557" },
                    { 2531, "Csót", "8558" },
                    { 2532, "Adásztevel", "8561" },
                    { 2533, "Nagytevel", "8562" },
                    { 2534, "Homokbödöge", "8563" },
                    { 2535, "Ugod", "8564" },
                    { 2536, "Béb", "8565" },
                    { 2537, "Bakonykoppány", "8571" },
                    { 2538, "Bakonyszücs", "8572" },
                    { 2539, "Bakonyjákó", "8581" },
                    { 2540, "Németbánya", "8581" },
                    { 2541, "Farkasgyepû", "8582" },
                    { 2542, "Pápa-Kéttornyúlak", "8591" },
                    { 2543, "Nóráp", "8591" },
                    { 2544, "Dáka", "8592" },
                    { 2545, "Pápadereske", "8593" },
                    { 2546, "Pápasalamon", "8594" },
                    { 2547, "Kup", "8595" },
                    { 2548, "Pápakovácsi", "8596" },
                    { 2549, "Ganna", "8597" },
                    { 2550, "Döbrönte", "8597" },
                    { 2551, "Pápa-Tapolcafő", "8598" },
                    { 2552, "Siófok", "8600" },
                    { 2553, "Nyim", "8612" },
                    { 2554, "Balatonendréd", "8613" },
                    { 2555, "Bálványos", "8614" },
                    { 2556, "Kőröshegy ", "8617" },
                    { 2557, "Kereki", "8618" },
                    { 2558, "Pusztaszemes", "8619" },
                    { 2559, "Zamárdi", "8621" },
                    { 2560, "Szántód", "8622" },
                    { 2561, "Balatonföldvár", "8623" },
                    { 2562, "Balatonszárszó", "8624" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2563, "Szólád", "8625" },
                    { 2564, "Teleki", "8626" },
                    { 2565, "Kötcse", "8627" },
                    { 2566, "Nagycsepely", "8628" },
                    { 2567, "Balatonboglár", "8630" },
                    { 2568, "Ordacsehi", "8635" },
                    { 2569, "Balatonszemes", "8636" },
                    { 2570, "Balatonőszöd", "8637" },
                    { 2571, "Balatonlelle", "8638" },
                    { 2572, "Fonyód", "8640" },
                    { 2573, "Balatonfenyves", "8646" },
                    { 2574, "Balatonmáriafürdő", "8647" },
                    { 2575, "Balatonkeresztúr ", "8648" },
                    { 2576, "Balatonberény", "8649" },
                    { 2577, "Balatonszabadi", "8651" },
                    { 2578, "Siójut", "8652" },
                    { 2579, "Ádánd", "8653" },
                    { 2580, "Ságvár", "8654" },
                    { 2581, "Som", "8655" },
                    { 2582, "Nagyberény", "8656" },
                    { 2583, "Bábonymegyer", "8658" },
                    { 2584, "Tab", "8660" },
                    { 2585, "Lulla", "8660" },
                    { 2586, "Sérsekszőlős", "8660" },
                    { 2587, "Torvaj", "8660" },
                    { 2588, "Zala", "8660" },
                    { 2589, "Bedegkér", "8666" },
                    { 2590, "Somogyegres", "8666" },
                    { 2591, "Kánya", "8667" },
                    { 2592, "Tengőd", "8668" },
                    { 2593, "Miklósi", "8669" },
                    { 2594, "Kapoly", "8671" },
                    { 2595, "Zics", "8672" },
                    { 2596, "Somogymeggyes", "8673" },
                    { 2597, "Nágocs", "8674" },
                    { 2598, "Andocs", "8675" },
                    { 2599, "Karád", "8676" },
                    { 2600, "Látrány", "8681" },
                    { 2601, "Visz", "8681" },
                    { 2602, "Somogytúr", "8683" },
                    { 2603, "Somogybabod", "8684" },
                    { 2604, "Gamás", "8685" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2605, "Balatonboglár-Szőlőskislak", "8691" },
                    { 2606, "Szőlősgyörök", "8692" },
                    { 2607, "Gyugy", "8692" },
                    { 2608, "Lengyeltóti", "8693" },
                    { 2609, "Kisberény", "8693" },
                    { 2610, "Hács", "8694" },
                    { 2611, "Buzsák", "8695" },
                    { 2612, "Táska", "8696" },
                    { 2613, "Öreglak", "8697" },
                    { 2614, "Somogyvár", "8698" },
                    { 2615, "Pamuk", "8698" },
                    { 2616, "Somogyvámos", "8699" },
                    { 2617, "Marcali", "8700" },
                    { 2618, "Csömend", "8700" },
                    { 2619, "Somogyszentpál", "8705" },
                    { 2620, "Nikla", "8706" },
                    { 2621, "Pusztakovácsi", "8707" },
                    { 2622, "Libickozma", "8707" },
                    { 2623, "Somogyfajsz", "8708" },
                    { 2624, "Marcali-Horvátkút", "8709" },
                    { 2625, "Balatonszentgyörgy ", "8710" },
                    { 2626, "Vörs", "8711" },
                    { 2627, "Balatonújlak", "8712" },
                    { 2628, "Kéthely", "8713" },
                    { 2629, "Marcali-Bize", "8714" },
                    { 2630, "Kelevíz", "8714" },
                    { 2631, "Mesztegnyő", "8716" },
                    { 2632, "Hosszúvíz", "8716" },
                    { 2633, "Gadány", "8716" },
                    { 2634, "Szenyér", "8717" },
                    { 2635, "Nemeskisfalud", "8717" },
                    { 2636, "Tapsony", "8718" },
                    { 2637, "Böhönye", "8719" },
                    { 2638, "Vése", "8721" },
                    { 2639, "Nemesdéd", "8722" },
                    { 2640, "Varászló", "8723" },
                    { 2641, "Inke", "8724" },
                    { 2642, "Iharosberény", "8725" },
                    { 2643, "Iharos", "8726" },
                    { 2644, "Somogycsicsó", "8726" },
                    { 2645, "Pogányszentpéter", "8728" },
                    { 2646, "Hollád", "8731" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2647, "Tikos", "8731" },
                    { 2648, "Sávoly", "8732" },
                    { 2649, "Főnyed", "8732" },
                    { 2650, "Szegerdő", "8732" },
                    { 2651, "Somogysámson", "8733" },
                    { 2652, "Somogyzsitfa", "8734" },
                    { 2653, "Csákány", "8735" },
                    { 2654, "Szőkedencs", "8736" },
                    { 2655, "Somogysimonyi", "8737" },
                    { 2656, "Nemesvid", "8738" },
                    { 2657, "Nagyszakácsi", "8739" },
                    { 2658, "Zalaapáti", "8741" },
                    { 2659, "Bókaháza", "8741" },
                    { 2660, "Esztergályhorváti", "8742" },
                    { 2661, "Zalaszabar", "8743" },
                    { 2662, "Orosztony", "8744" },
                    { 2663, "Kerecseny", "8745" },
                    { 2664, "Nagyrada", "8746" },
                    { 2665, "Garabonc", "8747" },
                    { 2666, "Zalamerenye", "8747" },
                    { 2667, "Zalakaros", "8749" },
                    { 2668, "Zalakomár-Kiskomárom", "8751" },
                    { 2669, "Zalakomár-Komárváros", "8752" },
                    { 2670, "Balatonmagyaród", "8753" },
                    { 2671, "Galambok", "8754" },
                    { 2672, "Nagyrécse", "8756" },
                    { 2673, "Csapi", "8756" },
                    { 2674, "Kisrécse", "8756" },
                    { 2675, "Zalasárszeg", "8756" },
                    { 2676, "Pacsa", "8761" },
                    { 2677, "Zalaigrice", "8761" },
                    { 2678, "Szentpéterúr", "8762" },
                    { 2679, "Gétye", "8762" },
                    { 2680, "Dióskál", "8764" },
                    { 2681, "Zalaszentmárton", "8764" },
                    { 2682, "Egeraracsa", "8765" },
                    { 2683, "Felsőrajk", "8767" },
                    { 2684, "Alsórajk", "8767" },
                    { 2685, "Pötréte", "8767" },
                    { 2686, "Hahót", "8771" },
                    { 2687, "Zalaszentbalázs", "8772" },
                    { 2688, "Börzönce", "8772" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2689, "Pölöskefő", "8773" },
                    { 2690, "Kacorlak", "8773" },
                    { 2691, "Gelse", "8774" },
                    { 2692, "Gelsesziget", "8774" },
                    { 2693, "Kilimán", "8774" },
                    { 2694, "Magyarszerdahely", "8776" },
                    { 2695, "Bocska", "8776" },
                    { 2696, "Magyarszentmiklós", "8776" },
                    { 2697, "Hosszúvölgy", "8777" },
                    { 2698, "Fûzvölgy", "8777" },
                    { 2699, "Homokkomárom", "8777" },
                    { 2700, "Újudvar", "8778" },
                    { 2701, "Zalacsány", "8782" },
                    { 2702, "Ligetfalva", "8782" },
                    { 2703, "Tilaj", "8782" },
                    { 2704, "Kehidakustány", "8784" },
                    { 2705, "Zalaszentgrót-Zalakoppány", "8785" },
                    { 2706, "Kallósd", "8785" },
                    { 2707, "Zalaszentlászló", "8788" },
                    { 2708, "Sénye", "8788" },
                    { 2709, "Zalaszentgrót-Zalaudvarnok", "8789" },
                    { 2710, "Zalaszentgrót", "8790" },
                    { 2711, "Zalavég", "8792" },
                    { 2712, "Tekenye", "8793" },
                    { 2713, "Zalaszentgrót-Csáford", "8795" },
                    { 2714, "Türje", "8796" },
                    { 2715, "Batyk", "8797" },
                    { 2716, "Zalabér", "8798" },
                    { 2717, "Pakod", "8799" },
                    { 2718, "Dötk", "8799" },
                    { 2719, "Nagykanizsa", "8800" },
                    { 2720, "Nagykanizsa-Palin", "8808" },
                    { 2721, "Nagykanizsa-Sánc", "8809" },
                    { 2722, "Nagybakónak", "8821" },
                    { 2723, "Zalaújlak", "8822" },
                    { 2724, "Sand", "8824" },
                    { 2725, "Miháld", "8825" },
                    { 2726, "Pat", "8825" },
                    { 2727, "Zalaszentjakab", "8827" },
                    { 2728, "Nagykanizsa-Miklósfa", "8831" },
                    { 2729, "Liszó", "8832" },
                    { 2730, "Murakeresztúr", "8834" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2731, "Fityeház", "8835" },
                    { 2732, "Csurgó", "8840" },
                    { 2733, "Csurgónagymarton", "8840" },
                    { 2734, "Szenta", "8849" },
                    { 2735, "Gyékényes", "8851" },
                    { 2736, "Zákány", "8852" },
                    { 2737, "Zákányfalu", "8853" },
                    { 2738, "őrtilos", "8854" },
                    { 2739, "Belezna", "8855" },
                    { 2740, "Surd", "8856" },
                    { 2741, "Nemespátró", "8857" },
                    { 2742, "Porrog", "8858" },
                    { 2743, "Porrogszentkirály", "8858" },
                    { 2744, "Porrogszentpál", "8858" },
                    { 2745, "Somogybükkösd", "8858" },
                    { 2746, "Szepetnek", "8861" },
                    { 2747, "Semjénháza", "8862" },
                    { 2748, "Molnári", "8863" },
                    { 2749, "Tótszerdahely", "8864" },
                    { 2750, "Tótszentmárton", "8865" },
                    { 2751, "Becsehely", "8866" },
                    { 2752, "Petrivente", "8866" },
                    { 2753, "Letenye", "8868" },
                    { 2754, "Kistolmács", "8868" },
                    { 2755, "Murarátka", "8868" },
                    { 2756, "Zajk", "8868" },
                    { 2757, "Muraszemenye", "8872" },
                    { 2758, "Szentmargitfalva", "8872" },
                    { 2759, "Csörnyeföld", "8873" },
                    { 2760, "Dobri", "8874" },
                    { 2761, "Kerkaszentkirály", "8874" },
                    { 2762, "Tormafölde", "8876" },
                    { 2763, "Tornyiszentmiklós", "8877" },
                    { 2764, "Lovászi", "8878" },
                    { 2765, "Szécsisziget", "8879" },
                    { 2766, "Kerkateskánd", "8879" },
                    { 2767, "Sormás", "8881" },
                    { 2768, "Eszteregnye", "8882" },
                    { 2769, "Rigyác", "8883" },
                    { 2770, "Borsfa", "8885" },
                    { 2771, "Valkonya", "8885" },
                    { 2772, "Oltárc", "8886" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2773, "Bázakerettye", "8887" },
                    { 2774, "Lasztonya", "8887" },
                    { 2775, "Lispeszentadorján", "8888" },
                    { 2776, "Kiscsehi", "8888" },
                    { 2777, "Maróc", "8888" },
                    { 2778, "Bánokszentgyörgy", "8891" },
                    { 2779, "Várfölde", "8891" },
                    { 2780, "Szentliszló", "8893" },
                    { 2781, "Bucsuta", "8893" },
                    { 2782, "Pusztamagyaród", "8895" },
                    { 2783, "Pusztaszentlászló", "8896" },
                    { 2784, "Söjtör", "8897" },
                    { 2785, "Zalaegerszeg", "8900" },
                    { 2786, "Zalaegerszeg-Andráshida", "8904" },
                    { 2787, "Nagykutas", "8911" },
                    { 2788, "Kiskutas", "8911" },
                    { 2789, "Kispáli", "8912" },
                    { 2790, "Nagypáli", "8912" },
                    { 2791, "Egervár", "8913" },
                    { 2792, "Gősfa", "8913" },
                    { 2793, "Lakhegy", "8913" },
                    { 2794, "Vasboldogasszony", "8914" },
                    { 2795, "Nemesrádó", "8915" },
                    { 2796, "Milejszeg", "8917" },
                    { 2797, "Csonkahegyhát", "8918" },
                    { 2798, "Németfalu", "8918" },
                    { 2799, "Kustánszeg", "8919" },
                    { 2800, "Zalaszentiván", "8921" },
                    { 2801, "Alibánfa", "8921" },
                    { 2802, "Pethőhenye", "8921" },
                    { 2803, "Zalaszentlőrinc", "8921" },
                    { 2804, "Nemesapáti", "8923" },
                    { 2805, "Alsónemesapáti", "8924" },
                    { 2806, "Búcsúszentlászló", "8925" },
                    { 2807, "Nemessándorháza", "8925" },
                    { 2808, "Nemesszentandrás", "8925" },
                    { 2809, "Kisbucsa", "8926" },
                    { 2810, "Nemeshetés", "8928" },
                    { 2811, "Pölöske", "8929" },
                    { 2812, "Kemendollár", "8931" },
                    { 2813, "Vöckönd", "8931" },
                    { 2814, "Pókaszepetk", "8932" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2815, "Gyûrûs", "8932" },
                    { 2816, "Zalaistvánd", "8932" },
                    { 2817, "Bezeréd", "8934" },
                    { 2818, "Nagykapornak", "8935" },
                    { 2819, "Almásháza", "8935" },
                    { 2820, "Misefa", "8935" },
                    { 2821, "Orbányosfa", "8935" },
                    { 2822, "Padár", "8935" },
                    { 2823, "Zalaszentmihály", "8936" },
                    { 2824, "Bocfölde", "8943" },
                    { 2825, "Csatár", "8943" },
                    { 2826, "Sárhida", "8944" },
                    { 2827, "Bak", "8945" },
                    { 2828, "Tófej", "8946" },
                    { 2829, "Baktüttös", "8946" },
                    { 2830, "Pusztaederics", "8946" },
                    { 2831, "Zalatárnok", "8947" },
                    { 2832, "Szentkozmadombja", "8947" },
                    { 2833, "Nova", "8948" },
                    { 2834, "Barlahida", "8948" },
                    { 2835, "Mikekarácsonyfa", "8949" },
                    { 2836, "Gutorfölde", "8951" },
                    { 2837, "Csertalakos", "8951" },
                    { 2838, "Szentpéterfölde", "8953" },
                    { 2839, "Ortaháza", "8954" },
                    { 2840, "Páka", "8956" },
                    { 2841, "Kányavár", "8956" },
                    { 2842, "Pördefölde", "8956" },
                    { 2843, "Csömödér", "8957" },
                    { 2844, "Hernyék", "8957" },
                    { 2845, "Kissziget", "8957" },
                    { 2846, "Zebecke", "8957" },
                    { 2847, "Iklódbördőce", "8958" },
                    { 2848, "Lenti", "8960" },
                    { 2849, "Gosztola", "8960" },
                    { 2850, "Lenti-Lentikápolna", "8966" },
                    { 2851, "Gáborjánháza", "8969" },
                    { 2852, "Bödeháza", "8969" },
                    { 2853, "Szijártóháza", "8969" },
                    { 2854, "Zalaszombatfa", "8969" },
                    { 2855, "Zalabaksa", "8971" },
                    { 2856, "Kerkabarabás", "8971" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2857, "Csesztreg", "8973" },
                    { 2858, "Alsószenterzsébet", "8973" },
                    { 2859, "Felsőszenterzsébet", "8973" },
                    { 2860, "Kerkafalva", "8973" },
                    { 2861, "Kerkakutas", "8973" },
                    { 2862, "Magyarföld", "8973" },
                    { 2863, "Ramocsa", "8973" },
                    { 2864, "Szentgyörgyvölgy", "8975" },
                    { 2865, "Nemesnép", "8976" },
                    { 2866, "Márokföld", "8976" },
                    { 2867, "Resznek", "8977" },
                    { 2868, "Baglad", "8977" },
                    { 2869, "Lendvajakabfa", "8977" },
                    { 2870, "Rédics", "8978" },
                    { 2871, "Belsősárd", "8978" },
                    { 2872, "Külsősárd", "8978" },
                    { 2873, "Lendvadedes", "8978" },
                    { 2874, "Gellénháza", "8981" },
                    { 2875, "Lickóvadamos", "8981" },
                    { 2876, "Nagylengyel", "8983" },
                    { 2877, "Babosdöbréte", "8983" },
                    { 2878, "Ormándlak", "8983" },
                    { 2879, "Petrikeresztúr", "8984" },
                    { 2880, "Gombosszeg", "8984" },
                    { 2881, "Iborfia", "8984" },
                    { 2882, "Becsvölgye", "8985" },
                    { 2883, "Pórszombat", "8986" },
                    { 2884, "Pusztaapáti", "8986" },
                    { 2885, "Szilvágy", "8986" },
                    { 2886, "Kálócfa", "8988" },
                    { 2887, "Kozmadombja", "8988" },
                    { 2888, "Dobronhegy", "8989" },
                    { 2889, "Pálfiszeg", "8990" },
                    { 2890, "Teskánd", "8991" },
                    { 2891, "Böde", "8991" },
                    { 2892, "Hottó", "8991" },
                    { 2893, "Bagod", "8992" },
                    { 2894, "Boncodfölde", "8992" },
                    { 2895, "Hagyárosbörönd", "8992" },
                    { 2896, "Zalaboldogfa", "8992" },
                    { 2897, "Zalaszentgyörgy", "8994" },
                    { 2898, "Kávás", "8994" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2899, "Salomvár", "8995" },
                    { 2900, "Keménfa", "8995" },
                    { 2901, "Zalacséb", "8996" },
                    { 2902, "Zalaháshágy", "8997" },
                    { 2903, "Vaspör", "8998" },
                    { 2904, "Ozmánbük", "8998" },
                    { 2905, "Zalalövő", "8999" },
                    { 2906, "Csöde", "8999" },
                    { 2907, "Győr*", "9000" },
                    { 2908, "Vámosszabadi", "9061" },
                    { 2909, "Kisbajcs", "9062" },
                    { 2910, "Vének", "9062" },
                    { 2911, "Nagybajcs", "9063" },
                    { 2912, "Vámosszabadi-Szitásdomb", "9064" },
                    { 2913, "Gönyû", "9071" },
                    { 2914, "Nagyszentjános", "9072" },
                    { 2915, "Bőny", "9073" },
                    { 2916, "Rétalap", "9074" },
                    { 2917, "Győrújbarát", "9081" },
                    { 2918, "Nyúl", "9082" },
                    { 2919, "Écs", "9083" },
                    { 2920, "Győrság", "9084" },
                    { 2921, "Pázmándfalu", "9085" },
                    { 2922, "Töltéstava", "9086" },
                    { 2923, "Bakonypéterd", "9088" },
                    { 2924, "Lázi", "9089" },
                    { 2925, "Pannonhalma", "9090" },
                    { 2926, "Ravazd", "9091" },
                    { 2927, "Tarjánpuszta", "9092" },
                    { 2928, "Győrasszonyfa", "9093" },
                    { 2929, "Tápszentmiklós", "9094" },
                    { 2930, "Táp", "9095" },
                    { 2931, "Nyalka", "9096" },
                    { 2932, "Mezőörs", "9097" },
                    { 2933, "Pér-Mindszentpuszta", "9098" },
                    { 2934, "Pér", "9099" },
                    { 2935, "Tét", "9100" },
                    { 2936, "Tényő", "9111" },
                    { 2937, "Sokorópátka", "9112" },
                    { 2938, "Koroncó", "9113" },
                    { 2939, "Győrszemere", "9121" },
                    { 2940, "Felpéc", "9122" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2941, "Kajárpéc", "9123" },
                    { 2942, "Gyömöre", "9124" },
                    { 2943, "Szerecseny", "9125" },
                    { 2944, "Gyarmat", "9126" },
                    { 2945, "Csikvánd", "9127" },
                    { 2946, "Mórichida", "9131" },
                    { 2947, "Árpás", "9132" },
                    { 2948, "Kisbabot", "9133" },
                    { 2949, "Rábaszentmiklós", "9133" },
                    { 2950, "Bodonhely", "9134" },
                    { 2951, "Rábaszentmihály", "9135" },
                    { 2952, "Rábacsécsény", "9136" },
                    { 2953, "Mérges", "9136" },
                    { 2954, "Ikrény", "9141" },
                    { 2955, "Rábapatona", "9142" },
                    { 2956, "Enese", "9143" },
                    { 2957, "Kóny", "9144" },
                    { 2958, "Bágyogszovát", "9145" },
                    { 2959, "Rábapordány", "9146" },
                    { 2960, "Dör", "9147" },
                    { 2961, "Abda", "9151" },
                    { 2962, "Börcs", "9152" },
                    { 2963, "Öttevény", "9153" },
                    { 2964, "Mosonszentmiklós", "9154" },
                    { 2965, "Lébény", "9155" },
                    { 2966, "Győrsövényház", "9161" },
                    { 2967, "Bezi", "9162" },
                    { 2968, "Fehértó", "9163" },
                    { 2969, "Markotabödöge", "9164" },
                    { 2970, "Rábcakapi", "9165" },
                    { 2971, "Cakóháza", "9165" },
                    { 2972, "Tárnokréti", "9165" },
                    { 2973, "Bősárkány", "9167" },
                    { 2974, "Jánossomorja-Hanságliget", "9167" },
                    { 2975, "Acsalag", "9168" },
                    { 2976, "Csorna-Földsziget", "9168" },
                    { 2977, "Barbacs", "9169" },
                    { 2978, "Maglóca", "9169" },
                    { 2979, "Győrújfalu", "9171" },
                    { 2980, "Győrzámoly", "9172" },
                    { 2981, "Győrladamér", "9173" },
                    { 2982, "Dunaszeg", "9174" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 2983, "Dunaszentpál", "9175" },
                    { 2984, "Mecsér", "9176" },
                    { 2985, "Ásványráró", "9177" },
                    { 2986, "Hédervár", "9178" },
                    { 2987, "Kimle", "9181" },
                    { 2988, "Károlyháza", "9182" },
                    { 2989, "Mosonszentmiklós-Mosonújhely", "9183" },
                    { 2990, "Kunsziget", "9184" },
                    { 2991, "Mosonmagyaróvár", "9200" },
                    { 2992, "Feketeerdő", "9211" },
                    { 2993, "Levél", "9221" },
                    { 2994, "Hegyeshalom", "9222" },
                    { 2995, "Bezenye", "9223" },
                    { 2996, "Rajka", "9224" },
                    { 2997, "Dunakiliti", "9225" },
                    { 2998, "Dunasziget", "9226" },
                    { 2999, "Halászi", "9228" },
                    { 3000, "Máriakálnok", "9231" },
                    { 3001, "Darnózseli", "9232" },
                    { 3002, "Lipót", "9233" },
                    { 3003, "Kisbodak", "9234" },
                    { 3004, "Püski", "9235" },
                    { 3005, "Dunaremete", "9235" },
                    { 3006, "Jánossomorja-Mosonszentjános", "9241" },
                    { 3007, "Jánossomorja-Pusztasomorja", "9242" },
                    { 3008, "Jánossomorja-Újtanya", "9243" },
                    { 3009, "Várbalog", "9243" },
                    { 3010, "Újrónafő", "9244" },
                    { 3011, "Mosonszolnok", "9245" },
                    { 3012, "Mosonudvar", "9246" },
                    { 3013, "Csorna", "9300" },
                    { 3014, "Pásztori", "9311" },
                    { 3015, "Szilsárkány", "9312" },
                    { 3016, "Rábacsanak", "9313" },
                    { 3017, "Egyed", "9314" },
                    { 3018, "Sobor", "9315" },
                    { 3019, "Rábaszentandrás", "9316" },
                    { 3020, "Szany", "9317" },
                    { 3021, "Farád", "9321" },
                    { 3022, "Rábatamási", "9322" },
                    { 3023, "Jobaháza", "9323" },
                    { 3024, "Bogyoszló", "9324" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 3025, "Potyond", "9324" },
                    { 3026, "Sopronnémeti", "9325" },
                    { 3027, "Szil", "9326" },
                    { 3028, "Vág", "9327" },
                    { 3029, "Rábasebes", "9327" },
                    { 3030, "Kapuvár", "9330" },
                    { 3031, "Kapuvár-Öntésmajor", "9339" },
                    { 3032, "Kisfalud", "9341" },
                    { 3033, "Mihályi", "9342" },
                    { 3034, "Beled", "9343" },
                    { 3035, "Edve", "9343" },
                    { 3036, "Vásárosfalu", "9343" },
                    { 3037, "Rábakecöl", "9344" },
                    { 3038, "Páli", "9345" },
                    { 3039, "Magyarkeresztúr", "9346" },
                    { 3040, "Vadosfa", "9346" },
                    { 3041, "Zsebeháza", "9346" },
                    { 3042, "Babót", "9351" },
                    { 3043, "Veszkény", "9352" },
                    { 3044, "Szárföld", "9353" },
                    { 3045, "Osli", "9354" },
                    { 3046, "Hövej", "9361" },
                    { 3047, "Himod", "9362" },
                    { 3048, "Gyóró", "9363" },
                    { 3049, "Cirák", "9364" },
                    { 3050, "Dénesfa", "9365" },
                    { 3051, "Vitnyéd", "9371" },
                    { 3052, "Csapod", "9372" },
                    { 3053, "Pusztacsalád", "9373" },
                    { 3054, "Iván", "9374" },
                    { 3055, "Répceszemere", "9375" },
                    { 3056, "Csáfordjánosfa", "9375" },
                    { 3057, "Csér", "9375" },
                    { 3058, "Sopron", "9400" },
                    { 3059, "Sopron-Sopronkőhida", "9407" },
                    { 3060, "Sopron-Brennbergbánya", "9408" },
                    { 3061, "Fertőrákos", "9421" },
                    { 3062, "Harka", "9422" },
                    { 3063, "Ágfalva", "9423" },
                    { 3064, "Fertőd", "9431" },
                    { 3065, "Fertőd-Tőzeggyármajor", "9433" },
                    { 3066, "Sarród-Fertőújlak", "9434" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 3067, "Sarród", "9435" },
                    { 3068, "Fertőszéplak", "9436" },
                    { 3069, "Hegykő", "9437" },
                    { 3070, "Sarród-Nyárliget", "9438" },
                    { 3071, "Agyagosszergény", "9441" },
                    { 3072, "Fertőendréd", "9442" },
                    { 3073, "Petőháza", "9443" },
                    { 3074, "Fertőszentmiklós", "9444" },
                    { 3075, "Röjtökmuzsaj", "9451" },
                    { 3076, "Ebergőc", "9451" },
                    { 3077, "Lövő", "9461" },
                    { 3078, "Völcsej", "9462" },
                    { 3079, "Sopronhorpács", "9463" },
                    { 3080, "Und", "9464" },
                    { 3081, "Nemeskér", "9471" },
                    { 3082, "Újkér", "9472" },
                    { 3083, "Egyházasfalu", "9473" },
                    { 3084, "Szakony", "9474" },
                    { 3085, "Gyalóka", "9474" },
                    { 3086, "Répcevis", "9475" },
                    { 3087, "Zsira", "9476" },
                    { 3088, "Pinnye", "9481" },
                    { 3089, "Nagylózs", "9482" },
                    { 3090, "Sopronkövesd", "9483" },
                    { 3091, "Pereszteg", "9484" },
                    { 3092, "Nagycenk", "9485" },
                    { 3093, "Hidegség", "9491" },
                    { 3094, "Fertőhomok", "9492" },
                    { 3095, "Fertőboz", "9493" },
                    { 3096, "Sopron-Balf", "9494" },
                    { 3097, "Kópháza", "9495" },
                    { 3098, "Celldömölk", "9500" },
                    { 3099, "Kemenesmihályfa", "9511" },
                    { 3100, "Ostffyasszonyfa", "9512" },
                    { 3101, "Csönge", "9513" },
                    { 3102, "Kenyeri", "9514" },
                    { 3103, "Pápoc", "9515" },
                    { 3104, "Vönöck", "9516" },
                    { 3105, "Kemenessömjén", "9517" },
                    { 3106, "Kemenesszentmárton", "9521" },
                    { 3107, "Kemenesmagasi", "9522" },
                    { 3108, "Szergény", "9523" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 3109, "Mersevát", "9531" },
                    { 3110, "Külsővat", "9532" },
                    { 3111, "Nemesszalók", "9533" },
                    { 3112, "Marcalgergelyi", "9534" },
                    { 3113, "Vinár", "9534" },
                    { 3114, "Celldömölk-Izsákfa", "9541" },
                    { 3115, "Boba", "9542" },
                    { 3116, "Nemeskocs", "9542" },
                    { 3117, "Kemenespálfa", "9544" },
                    { 3118, "Jánosháza", "9545" },
                    { 3119, "Karakó", "9547" },
                    { 3120, "Nemeskeresztúr", "9548" },
                    { 3121, "Keléd", "9549" },
                    { 3122, "Mesteri", "9551" },
                    { 3123, "Vásárosmiske", "9552" },
                    { 3124, "Köcsk", "9553" },
                    { 3125, "Kemeneskápolna", "9553" },
                    { 3126, "Egyházashetye", "9554" },
                    { 3127, "Borgáta", "9554" },
                    { 3128, "Kissomlyó", "9555" },
                    { 3129, "Duka", "9556" },
                    { 3130, "Nagysimonyi", "9561" },
                    { 3131, "Tokorcs", "9561" },
                    { 3132, "Sárvár", "9600" },
                    { 3133, "Sárvár-Rábasömjén", "9608" },
                    { 3134, "Sárvár-Lánkapuszta", "9609" },
                    { 3135, "Csénye", "9611" },
                    { 3136, "Bögöt", "9612" },
                    { 3137, "Porpác", "9612" },
                    { 3138, "Ölbő", "9621" },
                    { 3139, "Szeleste", "9622" },
                    { 3140, "Répceszentgyörgy", "9623" },
                    { 3141, "Chernelházadamonya", "9624" },
                    { 3142, "Bő", "9625" },
                    { 3143, "Gór", "9625" },
                    { 3144, "Hegyfalu", "9631" },
                    { 3145, "Sajtoskál", "9632" },
                    { 3146, "Simaság", "9633" },
                    { 3147, "Lócs", "9634" },
                    { 3148, "Iklanberény", "9634" },
                    { 3149, "Zsédeny", "9635" },
                    { 3150, "Pósfa", "9636" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 3151, "Rábapaty", "9641" },
                    { 3152, "Jákfa", "9643" },
                    { 3153, "Uraiújfalu", "9651" },
                    { 3154, "Nick", "9652" },
                    { 3155, "Répcelak", "9653" },
                    { 3156, "Csánig", "9654" },
                    { 3157, "Vasegerszeg", "9661" },
                    { 3158, "Tompaládony", "9662" },
                    { 3159, "Mesterháza", "9662" },
                    { 3160, "Nemesládony", "9663" },
                    { 3161, "Nagygeresd", "9664" },
                    { 3162, "Vámoscsalád", "9665" },
                    { 3163, "Sitke", "9671" },
                    { 3164, "Gérce", "9672" },
                    { 3165, "Káld", "9673" },
                    { 3166, "Vashosszúfalu", "9674" },
                    { 3167, "Bögöte", "9675" },
                    { 3168, "Hosszúpereszteg", "9676" },
                    { 3169, "Sótony", "9681" },
                    { 3170, "Nyőgér", "9682" },
                    { 3171, "Bejcgyertyános", "9683" },
                    { 3172, "Egervölgy", "9684" },
                    { 3173, "Szemenye", "9685" },
                    { 3174, "Szombathely", "9700" },
                    { 3175, "Szombathely-Herény", "9707" },
                    { 3176, "Szombathely-Szentkirály", "9719" },
                    { 3177, "Gencsapáti", "9721" },
                    { 3178, "Perenye", "9722" },
                    { 3179, "Gyöngyösfalu", "9723" },
                    { 3180, "Lukácsháza ", "9724" },
                    { 3181, "Kőszegszerdahely", "9725" },
                    { 3182, "Cák", "9725" },
                    { 3183, "Kőszegdoroszló", "9725" },
                    { 3184, "Velem", "9726" },
                    { 3185, "Bozsok", "9727" },
                    { 3186, "Kőszeg", "9730" },
                    { 3187, "Horvátzsidány", "9733" },
                    { 3188, "Kiszsidány", "9733" },
                    { 3189, "Ólmod", "9733" },
                    { 3190, "Peresznye", "9734" },
                    { 3191, "Csepreg", "9735" },
                    { 3192, "Tormásliget", "9736" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 3193, "Bük", "9737" },
                    { 3194, "Tömörd", "9738" },
                    { 3195, "Nemescsó", "9739" },
                    { 3196, "Kőszegpaty", "9739" },
                    { 3197, "Pusztacsó", "9739" },
                    { 3198, "Bük-Bükfürdő", "9740" },
                    { 3199, "Vassurány", "9741" },
                    { 3200, "Salköveskút", "9742" },
                    { 3201, "Söpte", "9743" },
                    { 3202, "Vasasszonyfa", "9744" },
                    { 3203, "Meszlen", "9745" },
                    { 3204, "Acsád", "9746" },
                    { 3205, "Vasszilvágy", "9747" },
                    { 3206, "Vát", "9748" },
                    { 3207, "Nemesbőd", "9749" },
                    { 3208, "Vép", "9751" },
                    { 3209, "Bozzai", "9752" },
                    { 3210, "Kenéz", "9752" },
                    { 3211, "Pecöl", "9754" },
                    { 3212, "Megyehíd", "9754" },
                    { 3213, "Ikervár", "9756" },
                    { 3214, "Meggyeskovácsi", "9757" },
                    { 3215, "Táplánszentkereszt", "9761" },
                    { 3216, "Tanakajd", "9762" },
                    { 3217, "Vasszécseny", "9763" },
                    { 3218, "Csempeszkopács", "9764" },
                    { 3219, "Meggyeskovácsi-Ilonapuszta", "9764" },
                    { 3220, "Rum", "9766" },
                    { 3221, "Rábatöttös", "9766" },
                    { 3222, "Zsennye", "9766" },
                    { 3223, "Balogunyom", "9771" },
                    { 3224, "Kisunyom", "9772" },
                    { 3225, "Sorokpolány", "9773" },
                    { 3226, "Sorkifalud", "9774" },
                    { 3227, "Gyanógeregye", "9774" },
                    { 3228, "Sorkikápolna", "9774" },
                    { 3229, "Nemeskolta", "9775" },
                    { 3230, "Püspökmolnári", "9776" },
                    { 3231, "Rábahídvég", "9777" },
                    { 3232, "Egyházashollós", "9781" },
                    { 3233, "Nemesrempehollós", "9782" },
                    { 3234, "Egyházasrádóc", "9783" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 3235, "Rádóckölked", "9784" },
                    { 3236, "Harasztifalu", "9784" },
                    { 3237, "Nagykölked", "9784" },
                    { 3238, "Sé", "9789" },
                    { 3239, "Torony", "9791" },
                    { 3240, "Dozmat", "9791" },
                    { 3241, "Bucsu", "9792" },
                    { 3242, "Narda", "9793" },
                    { 3243, "Felsőcsatár", "9794" },
                    { 3244, "Vaskeresztes", "9795" },
                    { 3245, "Pornóapáti", "9796" },
                    { 3246, "Horvátlövő", "9796" },
                    { 3247, "Nárai", "9797" },
                    { 3248, "Ják", "9798" },
                    { 3249, "Szentpéterfa", "9799" },
                    { 3250, "Vasvár", "9800" },
                    { 3251, "Andrásfa", "9811" },
                    { 3252, "Telekes", "9812" },
                    { 3253, "Gersekarát", "9813" },
                    { 3254, "Sárfimizdó", "9813" },
                    { 3255, "Halastó", "9814" },
                    { 3256, "Győrvár", "9821" },
                    { 3257, "Hegyhátszentpéter", "9821" },
                    { 3258, "Pácsony", "9823" },
                    { 3259, "Olaszfa", "9824" },
                    { 3260, "Oszkó", "9825" },
                    { 3261, "Petőmihályfa", "9826" },
                    { 3262, "Bérbaltavár", "9831" },
                    { 3263, "Nagytilaj", "9832" },
                    { 3264, "Csehi", "9833" },
                    { 3265, "Csehimindszent", "9834" },
                    { 3266, "Mikosszéplak", "9835" },
                    { 3267, "Csipkerek", "9836" },
                    { 3268, "Kám", "9841" },
                    { 3269, "Alsóújlak", "9842" },
                    { 3270, "Körmend", "9900" },
                    { 3271, "Körmend-Horvátnádalja", "9909" },
                    { 3272, "Magyarnádalja", "9909" },
                    { 3273, "Molnaszecsőd", "9912" },
                    { 3274, "Magyarszecsőd", "9912" },
                    { 3275, "Szarvaskend", "9913" },
                    { 3276, "Döröske", "9913" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 3277, "Nagymizdó", "9913" },
                    { 3278, "Döbörhegy", "9914" },
                    { 3279, "Nádasd", "9915" },
                    { 3280, "Hegyháthodász", "9915" },
                    { 3281, "Hegyhátsál", "9915" },
                    { 3282, "Katafa", "9915" },
                    { 3283, "Halogy", "9917" },
                    { 3284, "Daraboshegy", "9917" },
                    { 3285, "Felsőmarác", "9918" },
                    { 3286, "Csákánydoroszló", "9919" },
                    { 3287, "Vasalja", "9921" },
                    { 3288, "Pinkamindszent", "9922" },
                    { 3289, "Kemestaródfa", "9923" },
                    { 3290, "Ivánc", "9931" },
                    { 3291, "Hegyhátszentmárton", "9931" },
                    { 3292, "Viszák", "9932" },
                    { 3293, "őrimagyarósd", "9933" },
                    { 3294, "Hegyhátszentjakab", "9934" },
                    { 3295, "Felsőjánosfa", "9934" },
                    { 3296, "Szaknyér", "9934" },
                    { 3297, "Szőce", "9935" },
                    { 3298, "Kisrákos", "9936" },
                    { 3299, "Pankasz", "9937" },
                    { 3300, "Nagyrákos", "9938" },
                    { 3301, "Szatta", "9938" },
                    { 3302, "őriszentpéter", "9941" },
                    { 3303, "Ispánk", "9941" },
                    { 3304, "Szalafő", "9942" },
                    { 3305, "Kondorfa", "9943" },
                    { 3306, "Bajánsenye", "9944" },
                    { 3307, "Kerkáskápolna", "9944" },
                    { 3308, "Kercaszomor", "9945" },
                    { 3309, "Magyarszombatfa", "9946" },
                    { 3310, "Velemér", "9946" },
                    { 3311, "Rátót", "9951" },
                    { 3312, "Gasztony", "9952" },
                    { 3313, "Vasszentmihály", "9953" },
                    { 3314, "Nemesmedves", "9953" },
                    { 3315, "Rönök", "9954" },
                    { 3316, "Szentgotthárd-Rábafüzes", "9955" },
                    { 3317, "Rábagyarmat", "9961" },
                    { 3318, "Csörötnek", "9962" }
                });

            migrationBuilder.InsertData(
                table: "Cityies",
                columns: new[] { "Id", "Name", "Zip" },
                values: new object[,]
                {
                    { 3319, "Magyarlak", "9962" },
                    { 3320, "Szentgotthárd", "9970" },
                    { 3321, "Szentgotthárd-Farkasfa", "9981" },
                    { 3322, "Apátistvánfalva", "9982" },
                    { 3323, "Kétvölgy", "9982" },
                    { 3324, "Orfalu", "9982" },
                    { 3325, "Alsószölnök", "9983" },
                    { 3326, "Szakonyfalu", "9983" },
                    { 3327, "Felsőszölnök", "9985" }
                });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "Address", "AdvertisementType", "BuildDate", "CityId", "Description", "HalfRoom", "ImageUrl", "Price", "Room", "Size" },
                values: new object[,]
                {
                    { 1, "Kiss Ernő utca", 1, 2011, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 3, "adv-image1.jpg", 36.5m, 2, 120 },
                    { 2, "Diófa utca", 0, 2011, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 2, "adv-image2.jpg", 44m, 3, 140 },
                    { 3, "Arany János utca", 1, 2017, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 2, "adv-image3.jpg", 324.1m, 4, 270 },
                    { 4, "Epreskert utca", 1, 2011, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 1, "adv-image4.jpg", 30m, 2, 120 },
                    { 5, "Irinyi utca", 1, 2006, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 1, "adv-image5.jpg", 13.3m, 1, 42 },
                    { 6, "Magyar tudósok krt", 0, 2008, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 2, "adv-image6.jpg", 56m, 2, 88 },
                    { 7, "Bartók Béla", 1, 2010, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 2, "adv-image7.jpg", 43m, 3, 91 },
                    { 8, "Gárdonyi tér", 1, 2003, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 1, "adv-image8.jpg", 21.5m, 2, 56 },
                    { 9, "Műegyetem rakpart", 0, 1999, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 2, "adv-image9.jpg", 29.9m, 2, 61 },
                    { 10, "Teve utca", 0, 2002, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 2, "adv-image10.jpg", 24.5m, 2, 83 },
                    { 11, "Váci út", 1, 2011, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 3, "adv-image11.jpg", 31m, 1, 78 },
                    { 12, "Dagály utca", 3, 2012, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 1, "adv-image12.jpg", 42m, 3, 99 },
                    { 13, "Visegrádi utca", 1, 2013, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 1, "adv-image13.jpg", 28.5m, 2, 58 },
                    { 14, "Háros utca", 2, 2009, 4, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", 2, "adv-image14.jpg", 47.2m, 3, 114 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Advertisements",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1495);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1496);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1497);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1498);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1499);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1500);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1501);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1502);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1503);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1504);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1505);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1506);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1507);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1508);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1509);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1510);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1511);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1512);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1513);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1514);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1515);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1516);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1517);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1518);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1519);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1520);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1521);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1522);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1523);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1524);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1525);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1526);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1527);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1528);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1529);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1530);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1531);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1532);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1533);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1534);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1536);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1537);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1538);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1539);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1540);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1541);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1542);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1543);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1544);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1545);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1546);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1547);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1548);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1549);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1550);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1551);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1553);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1554);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1555);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1556);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1557);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1558);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1559);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1560);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1561);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1562);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1563);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1564);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1565);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1566);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1567);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1568);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1569);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1570);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1571);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1572);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1573);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1574);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1575);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1576);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1577);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1578);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1579);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1580);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1581);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1582);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1583);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1584);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1585);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1586);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1587);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1588);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1589);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1590);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1591);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1592);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1593);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1594);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1596);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1597);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1598);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1599);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1600);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1601);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1602);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1603);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1604);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1605);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1606);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1607);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1608);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1609);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1610);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1611);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1612);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1613);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1614);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1615);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1616);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1617);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1618);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1619);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1620);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1621);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1622);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1623);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1624);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1625);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1626);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1627);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1628);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1629);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1630);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1631);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1632);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1633);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1634);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1635);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1636);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1637);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1638);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1639);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1640);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1641);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1642);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1643);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1644);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1645);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1646);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1647);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1648);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1649);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1650);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1651);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1652);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1653);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1654);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1655);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1656);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1657);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1658);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1659);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1660);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1661);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1662);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1663);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1664);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1665);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1666);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1667);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1668);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1669);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1670);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1671);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1672);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1673);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1674);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1675);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1676);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1677);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1678);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1679);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1680);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1681);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1682);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1683);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1684);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1685);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1686);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1687);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1688);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1689);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1690);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1691);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1692);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1693);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1694);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1695);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1696);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1697);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1698);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1699);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1700);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1701);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1702);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1703);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1704);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1705);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1706);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1707);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1708);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1709);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1710);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1712);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1713);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1714);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1715);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1716);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1717);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1718);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1719);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1720);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1721);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1722);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1723);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1724);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1725);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1726);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1727);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1728);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1729);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1730);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1731);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1733);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1734);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1735);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1736);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1737);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1738);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1739);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1740);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1741);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1742);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1743);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1744);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1745);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1746);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1747);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1748);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1749);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1750);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1751);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1752);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1753);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1754);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1755);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1756);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1757);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1758);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1759);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1760);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1761);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1762);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1763);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1764);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1765);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1766);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1767);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1768);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1770);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1771);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1772);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1773);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1774);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1775);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1776);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1777);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1778);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1779);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1780);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1781);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1782);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1783);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1784);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1785);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1786);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1787);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1788);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1789);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1790);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1791);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1792);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1793);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1794);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1795);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1796);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1797);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1798);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1799);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1800);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1801);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1802);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1803);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1804);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1805);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1806);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1807);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1808);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1809);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1810);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1811);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1812);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1813);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1814);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1815);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1816);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1817);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1818);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1819);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1820);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1821);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1822);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1823);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1824);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1825);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1826);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1827);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1828);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1829);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1830);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1831);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1832);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1833);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1834);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1835);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1836);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1837);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1838);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1839);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1840);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1841);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1842);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1843);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1844);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1845);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1846);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1847);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1848);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1849);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1850);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1851);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1852);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1853);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1854);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1855);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1856);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1857);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1858);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1859);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1860);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1861);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1862);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1863);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1864);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1865);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1866);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1867);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1868);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1869);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1870);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1871);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1872);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1873);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1874);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1875);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1876);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1877);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1878);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1879);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1880);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1881);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1882);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1883);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1884);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1885);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1886);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1887);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1888);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1889);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1890);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1891);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1892);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1893);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1894);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1895);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1896);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1897);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1898);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1899);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1900);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1901);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1902);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1903);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1904);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1905);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1906);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1907);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1908);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1909);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1910);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1911);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1912);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1913);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1914);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1915);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1916);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1917);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1918);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1919);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1920);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1921);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1922);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1923);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1924);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1925);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1926);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1927);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1928);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1929);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1930);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1931);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1932);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1933);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1934);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1935);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1936);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1937);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1938);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1939);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1940);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1941);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1942);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1943);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1944);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1945);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1946);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1947);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1948);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1949);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1950);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1951);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1952);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1953);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1954);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1955);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1956);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1957);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1958);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1959);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1960);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1961);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1962);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1963);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1964);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1965);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1966);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1967);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1968);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1969);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1970);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1971);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1972);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1973);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1974);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1975);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1976);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1977);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1978);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1979);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1980);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1981);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1982);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1983);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1984);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1985);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1986);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1987);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1988);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1989);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1990);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1991);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1992);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1993);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1994);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1995);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1996);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1997);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1998);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1999);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2001);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2002);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2003);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2004);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2005);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2006);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2007);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2008);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2009);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2010);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2011);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2012);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2013);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2014);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2015);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2016);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2017);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2018);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2019);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2020);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2022);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2023);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2024);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2025);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2026);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2027);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2028);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2029);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2030);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2031);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2032);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2033);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2034);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2035);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2036);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2037);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2038);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2039);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2040);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2041);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2043);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2044);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2045);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2046);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2047);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2049);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2050);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2051);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2052);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2053);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2054);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2055);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2056);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2057);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2058);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2059);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2060);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2061);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2062);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2063);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2064);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2065);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2066);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2067);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2068);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2069);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2070);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2071);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2072);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2074);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2075);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2076);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2077);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2078);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2079);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2080);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2081);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2082);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2083);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2084);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2085);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2086);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2087);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2088);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2089);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2090);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2091);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2092);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2093);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2094);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2095);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2096);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2097);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2098);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2099);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2100);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2101);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2102);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2103);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2104);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2105);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2106);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2107);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2108);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2109);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2110);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2111);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2112);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2113);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2114);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2115);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2116);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2117);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2119);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2121);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2122);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2123);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2124);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2125);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2126);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2127);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2128);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2129);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2130);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2131);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2132);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2133);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2134);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2135);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2136);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2137);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2138);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2139);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2141);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2142);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2143);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2144);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2145);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2146);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2147);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2148);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2149);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2150);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2151);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2152);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2153);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2154);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2155);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2156);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2157);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2158);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2159);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2160);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2161);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2162);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2163);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2164);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2165);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2166);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2167);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2168);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2169);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2170);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2171);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2172);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2173);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2174);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2175);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2176);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2177);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2178);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2179);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2180);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2181);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2182);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2183);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2184);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2185);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2186);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2187);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2188);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2189);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2190);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2191);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2192);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2193);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2194);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2195);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2196);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2197);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2198);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2199);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2200);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2201);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2202);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2203);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2204);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2205);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2206);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2207);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2208);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2209);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2210);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2212);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2215);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2216);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2217);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2218);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2219);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2220);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2222);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2223);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2225);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2226);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2227);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2228);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2230);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2231);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2232);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2233);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2234);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2235);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2236);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2237);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2238);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2239);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2240);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2241);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2242);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2243);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2244);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2245);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2246);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2247);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2248);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2249);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2250);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2251);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2252);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2253);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2254);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2255);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2256);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2257);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2258);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2259);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2260);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2261);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2262);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2263);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2264);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2265);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2266);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2267);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2268);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2269);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2270);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2271);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2272);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2273);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2274);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2275);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2276);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2277);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2278);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2279);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2280);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2281);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2282);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2283);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2284);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2285);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2286);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2287);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2288);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2289);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2290);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2291);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2292);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2293);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2294);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2295);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2296);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2297);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2298);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2299);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2300);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2301);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2302);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2303);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2304);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2305);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2306);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2307);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2308);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2309);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2310);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2311);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2312);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2313);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2314);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2315);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2316);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2317);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2318);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2319);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2320);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2321);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2322);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2323);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2324);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2325);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2326);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2327);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2328);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2329);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2330);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2331);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2332);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2333);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2334);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2335);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2336);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2337);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2338);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2339);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2340);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2341);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2342);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2343);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2344);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2345);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2346);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2347);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2348);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2349);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2350);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2351);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2352);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2353);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2354);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2355);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2356);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2358);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2359);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2360);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2361);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2362);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2363);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2364);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2365);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2366);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2367);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2368);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2369);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2370);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2371);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2372);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2373);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2374);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2375);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2376);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2377);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2378);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2379);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2380);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2381);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2382);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2383);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2384);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2385);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2386);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2387);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2388);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2389);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2390);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2391);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2392);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2393);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2394);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2395);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2396);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2397);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2398);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2399);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2400);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2401);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2402);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2403);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2404);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2405);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2406);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2407);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2408);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2409);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2410);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2411);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2412);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2413);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2414);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2415);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2416);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2417);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2418);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2419);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2420);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2421);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2422);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2423);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2424);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2425);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2426);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2427);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2428);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2429);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2430);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2431);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2432);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2433);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2434);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2435);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2436);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2437);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2438);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2439);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2440);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2441);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2442);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2443);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2444);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2445);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2446);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2447);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2448);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2449);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2450);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2451);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2452);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2453);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2454);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2455);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2456);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2457);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2458);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2459);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2460);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2461);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2462);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2463);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2464);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2465);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2466);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2467);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2468);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2469);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2470);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2471);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2472);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2473);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2474);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2475);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2476);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2477);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2479);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2480);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2481);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2482);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2483);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2484);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2485);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2486);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2487);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2488);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2489);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2490);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2491);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2492);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2493);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2494);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2495);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2496);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2497);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2498);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2499);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2500);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2501);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2502);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2503);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2504);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2505);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2506);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2507);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2508);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2509);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2510);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2511);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2512);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2513);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2514);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2515);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2516);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2517);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2518);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2519);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2520);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2521);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2522);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2523);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2524);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2525);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2526);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2527);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2529);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2530);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2531);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2532);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2533);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2534);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2535);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2536);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2537);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2538);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2539);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2540);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2541);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2542);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2543);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2544);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2545);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2546);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2547);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2548);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2549);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2550);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2551);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2552);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2553);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2554);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2555);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2556);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2557);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2558);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2559);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2560);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2561);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2562);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2563);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2564);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2565);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2566);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2567);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2568);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2569);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2570);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2571);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2572);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2573);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2574);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2575);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2576);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2577);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2578);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2579);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2580);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2581);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2582);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2583);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2584);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2585);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2586);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2587);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2588);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2589);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2590);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2591);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2592);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2593);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2594);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2595);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2596);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2597);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2598);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2599);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2600);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2601);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2602);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2603);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2604);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2605);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2606);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2607);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2608);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2609);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2610);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2611);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2612);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2613);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2614);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2615);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2616);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2617);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2618);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2619);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2620);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2621);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2622);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2623);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2624);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2625);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2626);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2627);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2628);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2629);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2630);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2631);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2632);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2633);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2634);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2635);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2636);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2637);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2638);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2639);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2640);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2641);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2642);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2643);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2644);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2645);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2646);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2647);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2648);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2649);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2650);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2651);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2652);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2653);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2654);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2655);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2656);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2657);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2658);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2659);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2660);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2661);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2662);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2663);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2664);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2665);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2666);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2667);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2668);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2669);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2670);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2671);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2672);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2673);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2674);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2675);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2676);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2677);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2678);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2679);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2680);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2681);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2682);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2683);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2684);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2685);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2686);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2687);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2688);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2689);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2690);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2691);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2692);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2693);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2694);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2695);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2696);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2697);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2698);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2699);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2700);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2701);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2702);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2703);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2704);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2705);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2706);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2707);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2708);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2709);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2710);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2711);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2712);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2713);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2714);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2715);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2716);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2717);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2718);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2719);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2720);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2721);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2722);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2723);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2724);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2725);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2726);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2727);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2728);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2729);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2730);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2731);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2732);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2733);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2734);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2735);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2736);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2737);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2738);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2739);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2740);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2741);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2742);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2743);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2744);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2745);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2746);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2747);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2748);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2749);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2750);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2751);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2752);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2753);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2754);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2755);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2756);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2757);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2758);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2759);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2760);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2761);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2762);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2763);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2764);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2765);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2766);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2767);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2768);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2769);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2770);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2771);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2772);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2773);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2774);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2775);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2776);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2777);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2778);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2779);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2780);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2781);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2782);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2783);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2784);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2785);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2786);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2787);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2788);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2789);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2790);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2791);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2792);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2793);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2794);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2795);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2796);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2797);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2798);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2799);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2800);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2801);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2802);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2803);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2804);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2805);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2806);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2807);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2808);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2809);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2810);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2811);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2812);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2813);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2814);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2815);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2816);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2817);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2818);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2819);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2820);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2821);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2822);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2823);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2824);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2825);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2826);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2827);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2828);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2829);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2830);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2831);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2832);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2833);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2834);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2835);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2836);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2837);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2838);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2839);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2840);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2841);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2842);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2843);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2844);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2845);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2846);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2847);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2848);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2849);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2850);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2851);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2852);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2853);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2854);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2855);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2856);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2857);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2858);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2859);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2860);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2861);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2862);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2863);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2864);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2865);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2866);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2867);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2868);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2869);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2870);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2871);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2872);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2873);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2874);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2875);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2876);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2877);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2878);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2879);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2880);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2881);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2882);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2883);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2884);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2885);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2886);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2887);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2888);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2889);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2890);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2891);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2892);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2893);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2894);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2895);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2896);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2897);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2898);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2899);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2900);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2901);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2902);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2903);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2904);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2905);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2906);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2907);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2908);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2909);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2910);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2911);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2912);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2913);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2914);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2915);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2916);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2917);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2918);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2919);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2920);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2921);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2922);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2923);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2924);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2925);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2926);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2927);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2928);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2929);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2930);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2931);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2932);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2933);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2934);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2935);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2936);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2937);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2938);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2939);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2940);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2941);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2942);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2943);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2944);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2945);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2946);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2947);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2948);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2949);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2950);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2951);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2952);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2953);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2954);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2955);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2956);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2957);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2958);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2959);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2960);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2961);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2962);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2963);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2964);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2965);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2966);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2967);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2968);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2969);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2970);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2971);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2972);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2973);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2974);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2975);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2976);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2977);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2978);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2979);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2980);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2981);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2982);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2983);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2984);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2985);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2986);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2987);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2988);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2989);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2990);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2991);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2992);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2993);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2994);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2995);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2996);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2997);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2998);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2999);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3001);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3002);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3003);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3004);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3005);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3006);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3007);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3008);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3009);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3010);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3011);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3012);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3013);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3014);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3015);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3016);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3017);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3018);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3019);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3020);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3021);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3022);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3023);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3024);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3025);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3026);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3027);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3028);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3029);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3030);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3031);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3032);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3033);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3034);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3035);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3036);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3037);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3038);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3039);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3040);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3041);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3042);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3043);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3044);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3045);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3046);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3047);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3048);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3049);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3050);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3051);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3052);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3053);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3054);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3055);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3056);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3057);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3058);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3059);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3060);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3061);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3062);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3063);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3064);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3065);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3066);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3067);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3068);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3069);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3070);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3071);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3072);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3073);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3074);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3075);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3076);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3077);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3078);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3079);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3080);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3081);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3082);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3083);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3084);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3085);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3086);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3087);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3088);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3089);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3090);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3091);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3092);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3093);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3094);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3095);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3096);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3097);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3098);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3099);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3100);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3101);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3102);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3103);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3104);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3105);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3106);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3107);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3108);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3109);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3110);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3111);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3112);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3113);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3114);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3115);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3116);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3117);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3118);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3119);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3120);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3121);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3122);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3123);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3124);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3125);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3126);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3127);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3128);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3129);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3130);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3131);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3132);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3133);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3134);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3135);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3136);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3137);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3138);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3139);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3140);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3141);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3142);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3143);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3144);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3145);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3146);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3147);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3148);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3149);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3150);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3151);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3152);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3153);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3154);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3155);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3156);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3157);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3158);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3159);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3160);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3161);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3162);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3163);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3164);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3165);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3166);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3167);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3168);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3169);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3170);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3171);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3172);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3173);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3174);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3175);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3176);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3177);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3178);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3179);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3180);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3181);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3182);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3183);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3184);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3185);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3186);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3187);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3188);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3189);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3190);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3191);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3192);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3193);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3194);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3195);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3196);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3197);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3198);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3199);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3200);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3201);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3202);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3203);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3204);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3205);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3206);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3207);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3208);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3209);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3210);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3211);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3212);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3213);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3214);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3215);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3216);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3217);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3218);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3219);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3220);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3221);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3222);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3223);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3224);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3225);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3226);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3227);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3228);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3229);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3230);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3231);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3232);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3233);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3234);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3235);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3236);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3237);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3238);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3239);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3240);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3241);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3242);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3243);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3244);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3245);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3246);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3247);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3248);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3249);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3250);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3251);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3252);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3253);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3254);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3255);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3256);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3257);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3258);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3259);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3260);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3261);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3262);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3263);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3264);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3265);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3266);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3267);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3268);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3269);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3270);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3271);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3272);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3273);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3274);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3275);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3276);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3277);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3278);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3279);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3280);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3281);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3282);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3283);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3284);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3285);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3286);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3287);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3288);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3289);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3290);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3291);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3292);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3293);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3294);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3295);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3296);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3297);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3298);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3299);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3300);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3301);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3302);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3303);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3304);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3305);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3306);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3307);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3308);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3309);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3310);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3311);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3312);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3313);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3314);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3315);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3316);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3317);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3318);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3319);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3320);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3321);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3322);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3323);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3324);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3325);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3326);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3327);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cityies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
