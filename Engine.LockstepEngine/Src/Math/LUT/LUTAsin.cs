// Copyright 2019 谭杰鹏. All Rights Reserved //https://github.com/JiepengTan 


//#define DONT_USE_GENERATE_CODE                                                              
//------------------------------------------------------------------------------              
// <auto-generated>                                                                           
//     This code was generated by Lockstep.CodeGenerator                                                            
//     Changes to this file may cause incorrect behavior and will be lost if                  
//     the code is regenerated.                                                               
//     https://github.com/JiepengTan/LockstepEngine                                         
// </auto-generated>                                                                          
//------------------------------------------------------------------------------  
using System;
using Lockstep.Math;
namespace Lockstep.Math
{
	public static class LUTAsin
	{
		public static readonly int COUNT;
		public static readonly int HALF_COUNT;
		public static readonly int[] table;
		static LUTAsin()
		{
			COUNT = 4000;
			HALF_COUNT = COUNT >> 1;
			table = new int[]
			{
				-1570796,-1539171,-1526071,-1516017,-1507540,-1500070,-1493317,-1487106,-1481323,-1475892,-1470754,-1465867,-1461197,-1456716,-1452405,-1448245,-1444220,-1440319,-1436531,-1432846,-1429256,-1425755,-1422336,-1418993,-1415721,-1412517,-1409375,-1406294,-1403268,-1400295,-1397374,-1394499,-1391671,-1388886,-1386143,-1383439,-1380773,-1378144,-1375550,-1372989,-1370461,-1367964,-1365496,-1363058,-1360648,-1358264,-1355906,-1353574,-1351266,-1348982,-1346721,-1344481,-1342264,-1340067,-1337891,-1335734,-1333597,-1331478,-1329378,-1327296,-1325230,-1323182,-1321150,-1319134,-1317134,-1315149,-1313179,-1311224,-1309283,-1307356,-1305443,-1303543,-1301656,-1299782,-1297921,-1296071,-1294234,-1292409,-1290595,-1288793,-1287002,-1285221,-1283452,-1281693,-1279944,-1278206,-1276477,-1274758,-1273049,-1271350,-1269659,-1267978,-1266306,-1264642,-1262988,-1261342,-1259704,-1258075,-1256454,-1254841,
				-1253235,-1251638,-1250048,-1248466,-1246891,-1245324,-1243764,-1242211,-1240665,-1239126,-1237594,-1236069,-1234550,-1233038,-1231532,-1230033,-1228540,-1227053,-1225573,-1224098,-1222630,-1221167,-1219711,-1218259,-1216814,-1215375,-1213940,-1212512,-1211089,-1209671,-1208259,-1206851,-1205449,-1204052,-1202661,-1201274,-1199892,-1198515,-1197142,-1195775,-1194412,-1193054,-1191701,-1190352,-1189008,-1187668,-1186333,-1185002,-1183675,-1182353,-1181035,-1179721,-1178412,-1177106,-1175805,-1174507,-1173214,-1171925,-1170639,-1169358,-1168080,-1166806,-1165536,-1164270,-1163007,-1161748,-1160493,-1159241,-1157993,-1156748,-1155507,-1154270,-1153036,-1151805,-1150578,-1149354,-1148133,-1146916,-1145702,-1144491,-1143284,-1142079,-1140878,-1139680,-1138485,-1137293,-1136104,-1134919,-1133736,-1132556,-1131379,-1130205,-1129034,-1127866,-1126701,-1125539,-1124379,-1123223,-1122069,-1120917,
				-1119769,-1118623,-1117480,-1116340,-1115202,-1114067,-1112935,-1111805,-1110678,-1109553,-1108431,-1107311,-1106194,-1105079,-1103967,-1102857,-1101750,-1100645,-1099542,-1098442,-1097345,-1096249,-1095156,-1094065,-1092977,-1091891,-1090807,-1089725,-1088646,-1087568,-1086493,-1085421,-1084350,-1083282,-1082215,-1081151,-1080089,-1079029,-1077971,-1076915,-1075862,-1074810,-1073760,-1072713,-1071667,-1070624,-1069582,-1068542,-1067505,-1066469,-1065435,-1064403,-1063374,-1062345,-1061319,-1060295,-1059273,-1058252,-1057234,-1056217,-1055202,-1054189,-1053177,-1052168,-1051160,-1050154,-1049149,-1048147,-1047146,-1046147,-1045150,-1044154,-1043160,-1042168,-1041177,-1040189,-1039201,-1038216,-1037232,-1036250,-1035269,-1034290,-1033313,-1032337,-1031363,-1030390,-1029419,-1028450,-1027482,-1026515,-1025550,-1024587,-1023625,-1022665,-1021706,-1020749,-1019793,-1018839,-1017886,-1016935,
				-1015985,-1015036,-1014089,-1013144,-1012200,-1011257,-1010316,-1009376,-1008437,-1007500,-1006565,-1005630,-1004697,-1003766,-1002836,-1001907,-1000979,-1000053,-999128,-998205,-997283,-996362,-995442,-994524,-993607,-992691,-991777,-990864,-989952,-989042,-988132,-987224,-986317,-985412,-984508,-983604,-982703,-981802,-980902,-980004,-979107,-978211,-977317,-976423,-975531,-974640,-973750,-972861,-971973,-971087,-970202,-969318,-968434,-967553,-966672,-965792,-964914,-964036,-963160,-962285,-961410,-960538,-959666,-958795,-957925,-957056,-956189,-955322,-954456,-953592,-952729,-951866,-951005,-950145,-949286,-948427,-947570,-946714,-945859,-945005,-944152,-943299,-942448,-941598,-940749,-939901,-939054,-938208,-937362,-936518,-935675,-934833,-933991,-933151,-932311,-931473,-930635,-929799,-928963,-928128,
				-927295,-926462,-925630,-924799,-923969,-923140,-922311,-921484,-920657,-919832,-919007,-918183,-917360,-916538,-915717,-914897,-914077,-913259,-912441,-911624,-910809,-909993,-909179,-908366,-907553,-906742,-905931,-905121,-904312,-903503,-902696,-901889,-901083,-900278,-899474,-898670,-897868,-897066,-896265,-895465,-894665,-893867,-893069,-892272,-891476,-890680,-889886,-889092,-888299,-887506,-886715,-885924,-885134,-884344,-883556,-882768,-881981,-881195,-880409,-879625,-878841,-878057,-877275,-876493,-875712,-874932,-874152,-873373,-872595,-871818,-871041,-870265,-869490,-868715,-867941,-867168,-866396,-865624,-864853,-864082,-863313,-862544,-861775,-861008,-860241,-859475,-858709,-857944,-857180,-856417,-855654,-854891,-854130,-853369,-852609,-851849,-851090,-850332,-849575,-848818,
				-848062,-847306,-846551,-845797,-845043,-844290,-843538,-842786,-842035,-841284,-840534,-839785,-839037,-838288,-837541,-836794,-836048,-835303,-834558,-833814,-833070,-832327,-831584,-830842,-830101,-829361,-828620,-827881,-827142,-826404,-825666,-824929,-824193,-823457,-822721,-821987,-821252,-820519,-819786,-819053,-818322,-817590,-816859,-816129,-815400,-814671,-813942,-813214,-812487,-811760,-811034,-810308,-809583,-808859,-808134,-807411,-806688,-805966,-805244,-804523,-803802,-803082,-802362,-801643,-800924,-800206,-799489,-798771,-798055,-797339,-796624,-795909,-795194,-794480,-793767,-793054,-792342,-791630,-790919,-790208,-789498,-788788,-788079,-787370,-786662,-785954,-785247,-784540,-783834,-783128,-782423,-781718,-781014,-780310,-779607,-778904,-778201,-777500,-776798,-776097,
				-775397,-774697,-773998,-773299,-772600,-771902,-771205,-770508,-769811,-769115,-768419,-767724,-767030,-766335,-765642,-764948,-764255,-763563,-762871,-762180,-761489,-760798,-760108,-759418,-758729,-758040,-757352,-756664,-755977,-755290,-754603,-753917,-753232,-752546,-751862,-751177,-750493,-749810,-749127,-748444,-747762,-747080,-746399,-745718,-745038,-744358,-743678,-742999,-742320,-741642,-740964,-740287,-739610,-738933,-738257,-737581,-736906,-736231,-735556,-734882,-734208,-733535,-732862,-732190,-731517,-730846,-730174,-729504,-728833,-728163,-727493,-726824,-726155,-725487,-724819,-724151,-723484,-722817,-722150,-721484,-720818,-720153,-719488,-718823,-718159,-717495,-716832,-716169,-715506,-714844,-714182,-713521,-712859,-712199,-711538,-710878,-710219,-709559,-708901,-708242,
				-707584,-706926,-706269,-705612,-704955,-704299,-703643,-702987,-702332,-701677,-701023,-700369,-699715,-699061,-698409,-697756,-697104,-696452,-695800,-695149,-694498,-693847,-693197,-692547,-691898,-691249,-690600,-689951,-689303,-688655,-688008,-687361,-686714,-686068,-685422,-684776,-684131,-683486,-682841,-682197,-681553,-680909,-680266,-679623,-678980,-678338,-677696,-677054,-676413,-675772,-675131,-674491,-673851,-673211,-672572,-671933,-671294,-670655,-670017,-669380,-668742,-668105,-667468,-666832,-666196,-665560,-664924,-664289,-663654,-663020,-662386,-661751,-661118,-660485,-659852,-659219,-658587,-657954,-657323,-656691,-656060,-655429,-654799,-654168,-653539,-652909,-652280,-651651,-651022,-650393,-649765,-649138,-648510,-647883,-647256,-646629,-646003,-645377,-644751,-644126,
				-643501,-642876,-642251,-641627,-641003,-640379,-639756,-639133,-638510,-637887,-637265,-636643,-636021,-635400,-634779,-634158,-633538,-632917,-632297,-631678,-631058,-630439,-629820,-629202,-628584,-627965,-627348,-626730,-626113,-625496,-624880,-624263,-623647,-623031,-622416,-621800,-621186,-620571,-619956,-619342,-618728,-618115,-617501,-616888,-616275,-615663,-615050,-614438,-613826,-613215,-612604,-611993,-611382,-610771,-610161,-609551,-608942,-608332,-607723,-607114,-606505,-605897,-605289,-604681,-604073,-603466,-602859,-602252,-601645,-601039,-600433,-599827,-599221,-598616,-598011,-597406,-596801,-596197,-595593,-594989,-594385,-593782,-593179,-592576,-591973,-591371,-590769,-590167,-589565,-588964,-588362,-587761,-587161,-586560,-585960,-585360,-584760,-584161,-583562,-582962,
				-582364,-581765,-581167,-580569,-579971,-579373,-578776,-578179,-577582,-576985,-576389,-575792,-575196,-574601,-574005,-573410,-572815,-572220,-571625,-571031,-570437,-569843,-569249,-568655,-568062,-567469,-566876,-566284,-565691,-565099,-564507,-563916,-563324,-562733,-562142,-561551,-560960,-560370,-559780,-559190,-558600,-558011,-557421,-556832,-556243,-555655,-555066,-554478,-553890,-553302,-552715,-552127,-551540,-550953,-550366,-549780,-549194,-548608,-548022,-547436,-546850,-546265,-545680,-545095,-544511,-543926,-543342,-542758,-542174,-541591,-541007,-540424,-539841,-539258,-538676,-538093,-537511,-536929,-536347,-535766,-535184,-534603,-534022,-533441,-532861,-532280,-531700,-531120,-530540,-529961,-529381,-528802,-528223,-527644,-527066,-526487,-525909,-525331,-524753,-524176,
				-523598,-523021,-522444,-521867,-521290,-520714,-520138,-519562,-518986,-518410,-517834,-517259,-516684,-516109,-515534,-514959,-514385,-513811,-513237,-512663,-512089,-511516,-510942,-510369,-509796,-509224,-508651,-508079,-507507,-506935,-506363,-505791,-505220,-504648,-504077,-503506,-502935,-502365,-501794,-501224,-500654,-500084,-499515,-498945,-498376,-497807,-497238,-496669,-496100,-495532,-494964,-494395,-493827,-493260,-492692,-492125,-491558,-490990,-490424,-489857,-489290,-488724,-488158,-487592,-487026,-486460,-485895,-485329,-484764,-484199,-483634,-483069,-482505,-481941,-481376,-480812,-480248,-479685,-479121,-478558,-477995,-477432,-476869,-476306,-475744,-475181,-474619,-474057,-473495,-472933,-472372,-471810,-471249,-470688,-470127,-469566,-469006,-468445,-467885,-467325,
				-466765,-466205,-465645,-465086,-464527,-463967,-463408,-462849,-462291,-461732,-461174,-460616,-460057,-459499,-458942,-458384,-457827,-457269,-456712,-456155,-455598,-455041,-454485,-453928,-453372,-452816,-452260,-451704,-451149,-450593,-450038,-449483,-448927,-448373,-447818,-447263,-446709,-446154,-445600,-445046,-444492,-443939,-443385,-442831,-442278,-441725,-441172,-440619,-440066,-439514,-438961,-438409,-437857,-437305,-436753,-436201,-435650,-435098,-434547,-433996,-433445,-432894,-432343,-431793,-431242,-430692,-430142,-429592,-429042,-428492,-427942,-427393,-426843,-426294,-425745,-425196,-424647,-424099,-423550,-423002,-422454,-421905,-421357,-420810,-420262,-419714,-419167,-418620,-418072,-417525,-416978,-416432,-415885,-415338,-414792,-414246,-413700,-413154,-412608,-412062,
				-411516,-410971,-410425,-409880,-409335,-408790,-408245,-407701,-407156,-406612,-406067,-405523,-404979,-404435,-403891,-403348,-402804,-402261,-401717,-401174,-400631,-400088,-399545,-399003,-398460,-397918,-397375,-396833,-396291,-395749,-395207,-394666,-394124,-393583,-393041,-392500,-391959,-391418,-390877,-390336,-389796,-389255,-388715,-388175,-387635,-387095,-386555,-386015,-385475,-384936,-384396,-383857,-383318,-382779,-382240,-381701,-381162,-380624,-380085,-379547,-379009,-378470,-377932,-377394,-376857,-376319,-375781,-375244,-374707,-374169,-373632,-373095,-372558,-372022,-371485,-370948,-370412,-369876,-369339,-368803,-368267,-367732,-367196,-366660,-366125,-365589,-365054,-364519,-363983,-363448,-362914,-362379,-361844,-361310,-360775,-360241,-359706,-359172,-358638,-358104,
				-357571,-357037,-356503,-355970,-355436,-354903,-354370,-353837,-353304,-352771,-352238,-351706,-351173,-350641,-350108,-349576,-349044,-348512,-347980,-347448,-346916,-346385,-345853,-345322,-344791,-344259,-343728,-343197,-342666,-342135,-341605,-341074,-340544,-340013,-339483,-338953,-338423,-337893,-337363,-336833,-336303,-335773,-335244,-334715,-334185,-333656,-333127,-332598,-332069,-331540,-331011,-330483,-329954,-329426,-328897,-328369,-327841,-327313,-326785,-326257,-325729,-325201,-324674,-324146,-323619,-323091,-322564,-322037,-321510,-320983,-320456,-319929,-319403,-318876,-318350,-317823,-317297,-316771,-316245,-315718,-315193,-314667,-314141,-313615,-313090,-312564,-312039,-311513,-310988,-310463,-309938,-309413,-308888,-308363,-307839,-307314,-306789,-306265,-305741,-305216,
				-304692,-304168,-303644,-303120,-302596,-302073,-301549,-301025,-300502,-299978,-299455,-298932,-298409,-297886,-297363,-296840,-296317,-295794,-295271,-294749,-294226,-293704,-293182,-292659,-292137,-291615,-291093,-290571,-290049,-289528,-289006,-288484,-287963,-287441,-286920,-286399,-285878,-285356,-284835,-284314,-283794,-283273,-282752,-282231,-281711,-281190,-280670,-280150,-279629,-279109,-278589,-278069,-277549,-277029,-276510,-275990,-275470,-274951,-274431,-273912,-273393,-272873,-272354,-271835,-271316,-270797,-270278,-269759,-269241,-268722,-268203,-267685,-267167,-266648,-266130,-265612,-265094,-264575,-264057,-263540,-263022,-262504,-261986,-261469,-260951,-260434,-259916,-259399,-258882,-258364,-257847,-257330,-256813,-256296,-255779,-255263,-254746,-254229,-253713,-253196,
				-252680,-252163,-251647,-251131,-250615,-250099,-249583,-249067,-248551,-248035,-247519,-247004,-246488,-245972,-245457,-244941,-244426,-243911,-243396,-242880,-242365,-241850,-241335,-240820,-240306,-239791,-239276,-238762,-238247,-237732,-237218,-236704,-236189,-235675,-235161,-234647,-234133,-233619,-233105,-232591,-232077,-231563,-231050,-230536,-230023,-229509,-228996,-228482,-227969,-227456,-226943,-226429,-225916,-225403,-224890,-224378,-223865,-223352,-222839,-222327,-221814,-221301,-220789,-220277,-219764,-219252,-218740,-218228,-217715,-217203,-216691,-216179,-215668,-215156,-214644,-214132,-213621,-213109,-212597,-212086,-211574,-211063,-210552,-210041,-209529,-209018,-208507,-207996,-207485,-206974,-206463,-205952,-205442,-204931,-204420,-203910,-203399,-202889,-202378,-201868,
				-201357,-200847,-200337,-199827,-199317,-198807,-198297,-197787,-197277,-196767,-196257,-195747,-195237,-194728,-194218,-193709,-193199,-192690,-192180,-191671,-191162,-190652,-190143,-189634,-189125,-188616,-188107,-187598,-187089,-186580,-186071,-185563,-185054,-184545,-184037,-183528,-183020,-182511,-182003,-181494,-180986,-180478,-179969,-179461,-178953,-178445,-177937,-177429,-176921,-176413,-175905,-175397,-174890,-174382,-173874,-173367,-172859,-172352,-171844,-171337,-170829,-170322,-169814,-169307,-168800,-168293,-167786,-167279,-166771,-166264,-165758,-165251,-164744,-164237,-163730,-163223,-162717,-162210,-161703,-161197,-160690,-160184,-159677,-159171,-158664,-158158,-157652,-157145,-156639,-156133,-155627,-155121,-154615,-154109,-153603,-153097,-152591,-152085,-151579,-151074,
				-150568,-150062,-149556,-149051,-148545,-148040,-147534,-147029,-146523,-146018,-145512,-145007,-144502,-143997,-143491,-142986,-142481,-141976,-141471,-140966,-140461,-139956,-139451,-138946,-138441,-137936,-137432,-136927,-136422,-135918,-135413,-134908,-134404,-133899,-133395,-132890,-132386,-131881,-131377,-130873,-130368,-129864,-129360,-128856,-128352,-127847,-127343,-126839,-126335,-125831,-125327,-124823,-124319,-123816,-123312,-122808,-122304,-121800,-121297,-120793,-120289,-119786,-119282,-118779,-118275,-117772,-117268,-116765,-116261,-115758,-115254,-114751,-114248,-113745,-113241,-112738,-112235,-111732,-111229,-110726,-110223,-109720,-109216,-108714,-108211,-107708,-107205,-106702,-106199,-105696,-105193,-104691,-104188,-103685,-103182,-102680,-102177,-101675,-101172,-100669,
				-100167,-99664,-99162,-98659,-98157,-97655,-97152,-96650,-96148,-95645,-95143,-94641,-94138,-93636,-93134,-92632,-92130,-91628,-91126,-90623,-90121,-89619,-89117,-88615,-88113,-87612,-87110,-86608,-86106,-85604,-85102,-84600,-84099,-83597,-83095,-82593,-82092,-81590,-81088,-80587,-80085,-79583,-79082,-78580,-78079,-77577,-77076,-76574,-76073,-75571,-75070,-74569,-74067,-73566,-73064,-72563,-72062,-71561,-71059,-70558,-70057,-69556,-69054,-68553,-68052,-67551,-67050,-66549,-66048,-65546,-65045,-64544,-64043,-63542,-63041,-62540,-62039,-61538,-61037,-60536,-60036,-59535,-59034,-58533,-58032,-57531,-57030,-56530,-56029,-55528,-55027,-54527,-54026,-53525,-53024,-52524,-52023,-51522,-51022,-50521,
				-50020,-49520,-49019,-48519,-48018,-47517,-47017,-46516,-46016,-45515,-45015,-44514,-44014,-43513,-43013,-42512,-42012,-41511,-41011,-40511,-40010,-39510,-39009,-38509,-38009,-37508,-37008,-36508,-36007,-35507,-35007,-34506,-34006,-33506,-33005,-32505,-32005,-31505,-31004,-30504,-30004,-29504,-29004,-28503,-28003,-27503,-27003,-26503,-26002,-25502,-25002,-24502,-24002,-23502,-23002,-22501,-22001,-21501,-21001,-20501,-20001,-19501,-19001,-18501,-18000,-17500,-17000,-16500,-16000,-15500,-15000,-14500,-14000,-13500,-13000,-12500,-12000,-11500,-11000,-10500,-10000,-9500,-9000,-8500,-8000,-7500,-7000,-6500,-6000,-5500,-5000,-4500,-4000,-3500,-3000,-2500,-2000,-1500,-1000,-500,
				0,500,1000,1500,2000,2500,3000,3500,4000,4500,5000,5500,6000,6500,7000,7500,8000,8500,9000,9500,10000,10500,11000,11500,12000,12500,13000,13500,14000,14500,15000,15500,16000,16500,17000,17500,18000,18501,19001,19501,20001,20501,21001,21501,22001,22501,23002,23502,24002,24502,25002,25502,26002,26503,27003,27503,28003,28503,29004,29504,30004,30504,31004,31505,32005,32505,33005,33506,34006,34506,35007,35507,36007,36508,37008,37508,38009,38509,39009,39510,40010,40511,41011,41511,42012,42512,43013,43513,44014,44514,45015,45515,46016,46516,47017,47517,48018,48519,49019,49520,
				50020,50521,51022,51522,52023,52524,53024,53525,54026,54527,55027,55528,56029,56530,57030,57531,58032,58533,59034,59535,60036,60536,61037,61538,62039,62540,63041,63542,64043,64544,65045,65546,66048,66549,67050,67551,68052,68553,69054,69556,70057,70558,71059,71561,72062,72563,73064,73566,74067,74569,75070,75571,76073,76574,77076,77577,78079,78580,79082,79583,80085,80587,81088,81590,82092,82593,83095,83597,84099,84600,85102,85604,86106,86608,87110,87612,88113,88615,89117,89619,90121,90623,91126,91628,92130,92632,93134,93636,94138,94641,95143,95645,96148,96650,97152,97655,98157,98659,99162,99664,
				100167,100669,101172,101675,102177,102680,103182,103685,104188,104691,105193,105696,106199,106702,107205,107708,108211,108714,109216,109720,110223,110726,111229,111732,112235,112738,113241,113745,114248,114751,115254,115758,116261,116765,117268,117772,118275,118779,119282,119786,120289,120793,121297,121800,122304,122808,123312,123816,124319,124823,125327,125831,126335,126839,127343,127847,128352,128856,129360,129864,130368,130873,131377,131881,132386,132890,133395,133899,134404,134908,135413,135918,136422,136927,137432,137936,138441,138946,139451,139956,140461,140966,141471,141976,142481,142986,143491,143997,144502,145007,145512,146018,146523,147029,147534,148040,148545,149051,149556,150062,
				150568,151074,151579,152085,152591,153097,153603,154109,154615,155121,155627,156133,156639,157145,157652,158158,158664,159171,159677,160184,160690,161197,161703,162210,162717,163223,163730,164237,164744,165251,165758,166264,166771,167279,167786,168293,168800,169307,169814,170322,170829,171337,171844,172352,172859,173367,173874,174382,174890,175397,175905,176413,176921,177429,177937,178445,178953,179461,179969,180478,180986,181494,182003,182511,183020,183528,184037,184545,185054,185563,186071,186580,187089,187598,188107,188616,189125,189634,190143,190652,191162,191671,192180,192690,193199,193709,194218,194728,195237,195747,196257,196767,197277,197787,198297,198807,199317,199827,200337,200847,
				201357,201868,202378,202889,203399,203910,204420,204931,205442,205952,206463,206974,207485,207996,208507,209018,209529,210041,210552,211063,211574,212086,212597,213109,213621,214132,214644,215156,215668,216179,216691,217203,217715,218228,218740,219252,219764,220277,220789,221301,221814,222327,222839,223352,223865,224378,224890,225403,225916,226429,226943,227456,227969,228482,228996,229509,230023,230536,231050,231563,232077,232591,233105,233619,234133,234647,235161,235675,236189,236704,237218,237732,238247,238762,239276,239791,240306,240820,241335,241850,242365,242880,243396,243911,244426,244941,245457,245972,246488,247004,247519,248035,248551,249067,249583,250099,250615,251131,251647,252163,
				252680,253196,253713,254229,254746,255263,255779,256296,256813,257330,257847,258364,258882,259399,259916,260434,260951,261469,261986,262504,263022,263540,264057,264575,265094,265612,266130,266648,267167,267685,268203,268722,269241,269759,270278,270797,271316,271835,272354,272873,273393,273912,274431,274951,275470,275990,276510,277029,277549,278069,278589,279109,279629,280150,280670,281190,281711,282231,282752,283273,283794,284314,284835,285356,285878,286399,286920,287441,287963,288484,289006,289528,290049,290571,291093,291615,292137,292659,293182,293704,294226,294749,295271,295794,296317,296840,297363,297886,298409,298932,299455,299978,300502,301025,301549,302073,302596,303120,303644,304168,
				304692,305216,305741,306265,306789,307314,307839,308363,308888,309413,309938,310463,310988,311513,312039,312564,313090,313615,314141,314667,315193,315718,316245,316771,317297,317823,318350,318876,319403,319929,320456,320983,321510,322037,322564,323091,323619,324146,324674,325201,325729,326257,326785,327313,327841,328369,328897,329426,329954,330483,331011,331540,332069,332598,333127,333656,334185,334715,335244,335773,336303,336833,337363,337893,338423,338953,339483,340013,340544,341074,341605,342135,342666,343197,343728,344259,344791,345322,345853,346385,346916,347448,347980,348512,349044,349576,350108,350641,351173,351706,352238,352771,353304,353837,354370,354903,355436,355970,356503,357037,
				357571,358104,358638,359172,359706,360241,360775,361310,361844,362379,362914,363448,363983,364519,365054,365589,366125,366660,367196,367732,368267,368803,369339,369876,370412,370948,371485,372022,372558,373095,373632,374169,374707,375244,375781,376319,376857,377394,377932,378470,379009,379547,380085,380624,381162,381701,382240,382779,383318,383857,384396,384936,385475,386015,386555,387095,387635,388175,388715,389255,389796,390336,390877,391418,391959,392500,393041,393583,394124,394666,395207,395749,396291,396833,397375,397918,398460,399003,399545,400088,400631,401174,401717,402261,402804,403348,403891,404435,404979,405523,406067,406612,407156,407701,408245,408790,409335,409880,410425,410971,
				411516,412062,412608,413154,413700,414246,414792,415338,415885,416432,416978,417525,418072,418620,419167,419714,420262,420810,421357,421905,422454,423002,423550,424099,424647,425196,425745,426294,426843,427393,427942,428492,429042,429592,430142,430692,431242,431793,432343,432894,433445,433996,434547,435098,435650,436201,436753,437305,437857,438409,438961,439514,440066,440619,441172,441725,442278,442831,443385,443939,444492,445046,445600,446154,446709,447263,447818,448373,448927,449483,450038,450593,451149,451704,452260,452816,453372,453928,454485,455041,455598,456155,456712,457269,457827,458384,458942,459499,460057,460616,461174,461732,462291,462849,463408,463967,464527,465086,465645,466205,
				466765,467325,467885,468445,469006,469566,470127,470688,471249,471810,472372,472933,473495,474057,474619,475181,475744,476306,476869,477432,477995,478558,479121,479685,480248,480812,481376,481941,482505,483069,483634,484199,484764,485329,485895,486460,487026,487592,488158,488724,489290,489857,490424,490990,491558,492125,492692,493260,493827,494395,494964,495532,496100,496669,497238,497807,498376,498945,499515,500084,500654,501224,501794,502365,502935,503506,504077,504648,505220,505791,506363,506935,507507,508079,508651,509224,509796,510369,510942,511516,512089,512663,513237,513811,514385,514959,515534,516109,516684,517259,517834,518410,518986,519562,520138,520714,521290,521867,522444,523021,
				523598,524176,524753,525331,525909,526487,527066,527644,528223,528802,529381,529961,530540,531120,531700,532280,532861,533441,534022,534603,535184,535766,536347,536929,537511,538093,538676,539258,539841,540424,541007,541591,542174,542758,543342,543926,544511,545095,545680,546265,546850,547436,548022,548608,549194,549780,550366,550953,551540,552127,552715,553302,553890,554478,555066,555655,556243,556832,557421,558011,558600,559190,559780,560370,560960,561551,562142,562733,563324,563916,564507,565099,565691,566284,566876,567469,568062,568655,569249,569843,570437,571031,571625,572220,572815,573410,574005,574601,575196,575792,576389,576985,577582,578179,578776,579373,579971,580569,581167,581765,
				582364,582962,583562,584161,584760,585360,585960,586560,587161,587761,588362,588964,589565,590167,590769,591371,591973,592576,593179,593782,594385,594989,595593,596197,596801,597406,598011,598616,599221,599827,600433,601039,601645,602252,602859,603466,604073,604681,605289,605897,606505,607114,607723,608332,608942,609551,610161,610771,611382,611993,612604,613215,613826,614438,615050,615663,616275,616888,617501,618115,618728,619342,619956,620571,621186,621800,622416,623031,623647,624263,624880,625496,626113,626730,627348,627965,628584,629202,629820,630439,631058,631678,632297,632917,633538,634158,634779,635400,636021,636643,637265,637887,638510,639133,639756,640379,641003,641627,642251,642876,
				643501,644126,644751,645377,646003,646629,647256,647883,648510,649138,649765,650393,651022,651651,652280,652909,653539,654168,654799,655429,656060,656691,657323,657954,658587,659219,659852,660485,661118,661751,662386,663020,663654,664289,664924,665560,666196,666832,667468,668105,668742,669380,670017,670655,671294,671933,672572,673211,673851,674491,675131,675772,676413,677054,677696,678338,678980,679623,680266,680909,681553,682197,682841,683486,684131,684776,685422,686068,686714,687361,688008,688655,689303,689951,690600,691249,691898,692547,693197,693847,694498,695149,695800,696452,697104,697756,698409,699061,699715,700369,701023,701677,702332,702987,703643,704299,704955,705612,706269,706926,
				707584,708242,708901,709559,710219,710878,711538,712199,712859,713521,714182,714844,715506,716169,716832,717495,718159,718823,719488,720153,720818,721484,722150,722817,723484,724151,724819,725487,726155,726824,727493,728163,728833,729504,730174,730846,731517,732190,732862,733535,734208,734882,735556,736231,736906,737581,738257,738933,739610,740287,740964,741642,742320,742999,743678,744358,745038,745718,746399,747080,747762,748444,749127,749810,750493,751177,751862,752546,753232,753917,754603,755290,755977,756664,757352,758040,758729,759418,760108,760798,761489,762180,762871,763563,764255,764948,765642,766335,767030,767724,768419,769115,769811,770508,771205,771902,772600,773299,773998,774697,
				775397,776097,776798,777500,778201,778904,779607,780310,781014,781718,782423,783128,783834,784540,785247,785954,786662,787370,788079,788788,789498,790208,790919,791630,792342,793054,793767,794480,795194,795909,796624,797339,798055,798771,799489,800206,800924,801643,802362,803082,803802,804523,805244,805966,806688,807411,808134,808859,809583,810308,811034,811760,812487,813214,813942,814671,815400,816129,816859,817590,818322,819053,819786,820519,821252,821987,822721,823457,824193,824929,825666,826404,827142,827881,828620,829361,830101,830842,831584,832327,833070,833814,834558,835303,836048,836794,837541,838288,839037,839785,840534,841284,842035,842786,843538,844290,845043,845797,846551,847306,
				848062,848818,849575,850332,851090,851849,852609,853369,854130,854891,855654,856417,857180,857944,858709,859475,860241,861008,861775,862544,863313,864082,864853,865624,866396,867168,867941,868715,869490,870265,871041,871818,872595,873373,874152,874932,875712,876493,877275,878057,878841,879625,880409,881195,881981,882768,883556,884344,885134,885924,886715,887506,888299,889092,889886,890680,891476,892272,893069,893867,894665,895465,896265,897066,897868,898670,899474,900278,901083,901889,902696,903503,904312,905121,905931,906742,907553,908366,909179,909993,910809,911624,912441,913259,914077,914897,915717,916538,917360,918183,919007,919832,920657,921484,922311,923140,923969,924799,925630,926462,
				927295,928128,928963,929799,930635,931473,932311,933151,933991,934833,935675,936518,937362,938208,939054,939901,940749,941598,942448,943299,944152,945005,945859,946714,947570,948427,949286,950145,951005,951866,952729,953592,954456,955322,956189,957056,957925,958795,959666,960538,961410,962285,963160,964036,964914,965792,966672,967553,968434,969318,970202,971087,971973,972861,973750,974640,975531,976423,977317,978211,979107,980004,980902,981802,982703,983604,984508,985412,986317,987224,988132,989042,989952,990864,991777,992691,993607,994524,995442,996362,997283,998205,999128,1000053,1000979,1001907,1002836,1003766,1004697,1005630,1006565,1007500,1008437,1009376,1010316,1011257,1012200,1013144,1014089,1015036,
				1015985,1016935,1017886,1018839,1019793,1020749,1021706,1022665,1023625,1024587,1025550,1026515,1027482,1028450,1029419,1030390,1031363,1032337,1033313,1034290,1035269,1036250,1037232,1038216,1039201,1040189,1041177,1042168,1043160,1044154,1045150,1046147,1047146,1048147,1049149,1050154,1051160,1052168,1053177,1054189,1055202,1056217,1057234,1058252,1059273,1060295,1061319,1062345,1063374,1064403,1065435,1066469,1067505,1068542,1069582,1070624,1071667,1072713,1073760,1074810,1075862,1076915,1077971,1079029,1080089,1081151,1082215,1083282,1084350,1085421,1086493,1087568,1088646,1089725,1090807,1091891,1092977,1094065,1095156,1096249,1097345,1098442,1099542,1100645,1101750,1102857,1103967,1105079,1106194,1107311,1108431,1109553,1110678,1111805,1112935,1114067,1115202,1116340,1117480,1118623,
				1119769,1120917,1122069,1123223,1124379,1125539,1126701,1127866,1129034,1130205,1131379,1132556,1133736,1134919,1136104,1137293,1138485,1139680,1140878,1142079,1143284,1144491,1145702,1146916,1148133,1149354,1150578,1151805,1153036,1154270,1155507,1156748,1157993,1159241,1160493,1161748,1163007,1164270,1165536,1166806,1168080,1169358,1170639,1171925,1173214,1174507,1175805,1177106,1178412,1179721,1181035,1182353,1183675,1185002,1186333,1187668,1189008,1190352,1191701,1193054,1194412,1195775,1197142,1198515,1199892,1201274,1202661,1204052,1205449,1206851,1208259,1209671,1211089,1212512,1213940,1215375,1216814,1218259,1219711,1221167,1222630,1224098,1225573,1227053,1228540,1230033,1231532,1233038,1234550,1236069,1237594,1239126,1240665,1242211,1243764,1245324,1246891,1248466,1250048,1251638,
				1253235,1254841,1256454,1258075,1259704,1261342,1262988,1264642,1266306,1267978,1269659,1271350,1273049,1274758,1276477,1278206,1279944,1281693,1283452,1285221,1287002,1288793,1290595,1292409,1294234,1296071,1297921,1299782,1301656,1303543,1305443,1307356,1309283,1311224,1313179,1315149,1317134,1319134,1321150,1323182,1325230,1327296,1329378,1331478,1333597,1335734,1337891,1340067,1342264,1344481,1346721,1348982,1351266,1353574,1355906,1358264,1360648,1363058,1365496,1367964,1370461,1372989,1375550,1378144,1380773,1383439,1386143,1388886,1391671,1394499,1397374,1400295,1403268,1406294,1409375,1412517,1415721,1418993,1422336,1425755,1429256,1432846,1436531,1440319,1444220,1448245,1452405,1456716,1461197,1465867,1470754,1475892,1481323,1487106,1493317,1500070,1507540,1516017,1526071,1539171,
				1570796,
			};
		}
	}
}