﻿using System.Numerics;

namespace ProjectEuler.Problems
{
    public class LargeSum : IProblem
    {
        public int Id => 13;

        public string Title => "Large sum";

        public string Description => "Work out the first ten digits of the sum of the following one-hundred 50-digit numbers." +
            "\n\t37107287533902102798797998220837590246510135740250" +
            "\n\t46376937677490009712648124896970078050417018260538" +
            "\n\t74324986199524741059474233309513058123726617309629" +
            "\n\t91942213363574161572522430563301811072406154908250" +
            "\n\t23067588207539346171171980310421047513778063246676" +
            "\n\t89261670696623633820136378418383684178734361726757" +
            "\n\t28112879812849979408065481931592621691275889832738" +
            "\n\t44274228917432520321923589422876796487670272189318" +
            "\n\t47451445736001306439091167216856844588711603153276" +
            "\n\t70386486105843025439939619828917593665686757934951" +
            "\n\t62176457141856560629502157223196586755079324193331" +
            "\n\t64906352462741904929101432445813822663347944758178" +
            "\n\t92575867718337217661963751590579239728245598838407" +
            "\n\t58203565325359399008402633568948830189458628227828" +
            "\n\t80181199384826282014278194139940567587151170094390" +
            "\n\t35398664372827112653829987240784473053190104293586" +
            "\n\t86515506006295864861532075273371959191420517255829" +
            "\n\t71693888707715466499115593487603532921714970056938" +
            "\n\t54370070576826684624621495650076471787294438377604" +
            "\n\t53282654108756828443191190634694037855217779295145" +
            "\n\t36123272525000296071075082563815656710885258350721" +
            "\n\t45876576172410976447339110607218265236877223636045" +
            "\n\t17423706905851860660448207621209813287860733969412" +
            "\n\t81142660418086830619328460811191061556940512689692" +
            "\n\t51934325451728388641918047049293215058642563049483" +
            "\n\t62467221648435076201727918039944693004732956340691" +
            "\n\t15732444386908125794514089057706229429197107928209" +
            "\n\t55037687525678773091862540744969844508330393682126" +
            "\n\t18336384825330154686196124348767681297534375946515" +
            "\n\t80386287592878490201521685554828717201219257766954" +
            "\n\t78182833757993103614740356856449095527097864797581" +
            "\n\t16726320100436897842553539920931837441497806860984" +
            "\n\t48403098129077791799088218795327364475675590848030" +
            "\n\t87086987551392711854517078544161852424320693150332" +
            "\n\t59959406895756536782107074926966537676326235447210" +
            "\n\t69793950679652694742597709739166693763042633987085" +
            "\n\t41052684708299085211399427365734116182760315001271" +
            "\n\t65378607361501080857009149939512557028198746004375" +
            "\n\t35829035317434717326932123578154982629742552737307" +
            "\n\t94953759765105305946966067683156574377167401875275" +
            "\n\t88902802571733229619176668713819931811048770190271" +
            "\n\t25267680276078003013678680992525463401061632866526" +
            "\n\t36270218540497705585629946580636237993140746255962" +
            "\n\t24074486908231174977792365466257246923322810917141" +
            "\n\t91430288197103288597806669760892938638285025333403" +
            "\n\t34413065578016127815921815005561868836468420090470" +
            "\n\t23053081172816430487623791969842487255036638784583" +
            "\n\t11487696932154902810424020138335124462181441773470" +
            "\n\t63783299490636259666498587618221225225512486764533" +
            "\n\t67720186971698544312419572409913959008952310058822" +
            "\n\t95548255300263520781532296796249481641953868218774" +
            "\n\t76085327132285723110424803456124867697064507995236" +
            "\n\t37774242535411291684276865538926205024910326572967" +
            "\n\t23701913275725675285653248258265463092207058596522" +
            "\n\t29798860272258331913126375147341994889534765745501" +
            "\n\t18495701454879288984856827726077713721403798879715" +
            "\n\t38298203783031473527721580348144513491373226651381" +
            "\n\t34829543829199918180278916522431027392251122869539" +
            "\n\t40957953066405232632538044100059654939159879593635" +
            "\n\t29746152185502371307642255121183693803580388584903" +
            "\n\t41698116222072977186158236678424689157993532961922" +
            "\n\t62467957194401269043877107275048102390895523597457" +
            "\n\t23189706772547915061505504953922979530901129967519" +
            "\n\t86188088225875314529584099251203829009407770775672" +
            "\n\t11306739708304724483816533873502340845647058077308" +
            "\n\t82959174767140363198008187129011875491310547126581" +
            "\n\t97623331044818386269515456334926366572897563400500" +
            "\n\t42846280183517070527831839425882145521227251250327" +
            "\n\t55121603546981200581762165212827652751691296897789" +
            "\n\t32238195734329339946437501907836945765883352399886" +
            "\n\t75506164965184775180738168837861091527357929701337" +
            "\n\t62177842752192623401942399639168044983993173312731" +
            "\n\t32924185707147349566916674687634660915035914677504" +
            "\n\t99518671430235219628894890102423325116913619626622" +
            "\n\t73267460800591547471830798392868535206946944540724" +
            "\n\t76841822524674417161514036427982273348055556214818" +
            "\n\t97142617910342598647204516893989422179826088076852" +
            "\n\t87783646182799346313767754307809363333018982642090" +
            "\n\t10848802521674670883215120185883543223812876952786" +
            "\n\t71329612474782464538636993009049310363619763878039" +
            "\n\t62184073572399794223406235393808339651327408011116" +
            "\n\t66627891981488087797941876876144230030984490851411" +
            "\n\t60661826293682836764744779239180335110989069790714" +
            "\n\t85786944089552990653640447425576083659976645795096" +
            "\n\t66024396409905389607120198219976047599490197230297" +
            "\n\t64913982680032973156037120041377903785566085089252" +
            "\n\t16730939319872750275468906903707539413042652315011" +
            "\n\t94809377245048795150954100921645863754710598436791" +
            "\n\t78639167021187492431995700641917969777599028300699" +
            "\n\t15368713711936614952811305876380278410754449733078" +
            "\n\t40789923115535562561142322423255033685442488917353" +
            "\n\t44889911501440648020369068063960672322193204149535" +
            "\n\t41503128880339536053299340368006977710650566631954" +
            "\n\t81234880673210146739058568557934581403627822703280" +
            "\n\t82616570773948327592232845941706525094512325230608" +
            "\n\t22918802058777319719839450180888072429661980811197" +
            "\n\t77158542502016545090413245809786882778948721859617" +
            "\n\t72107838435069186155435662884062257473692284509516" +
            "\n\t20849603980134001723930671666823555245252804609722" +
            "\n\t53503534226472524250874054075591789781264330331690";

        public string Solution => $"first ten digits are {GetDigits()}";

        private string GetDigits()
        {
            var sumString = Sum().ToString();
            return sumString[..10];
        }

        private static BigInteger Sum()
        {
            BigInteger result = 0;

            foreach (var number in numbers)
            {
                result += number;
            }

            return result;
        }

        private static readonly BigInteger[] numbers = new[]
        {
            BigInteger.Parse("37107287533902102798797998220837590246510135740250"),
            BigInteger.Parse("46376937677490009712648124896970078050417018260538"),
            BigInteger.Parse("74324986199524741059474233309513058123726617309629"),
            BigInteger.Parse("91942213363574161572522430563301811072406154908250"),
            BigInteger.Parse("23067588207539346171171980310421047513778063246676"),
            BigInteger.Parse("89261670696623633820136378418383684178734361726757"),
            BigInteger.Parse("28112879812849979408065481931592621691275889832738"),
            BigInteger.Parse("44274228917432520321923589422876796487670272189318"),
            BigInteger.Parse("47451445736001306439091167216856844588711603153276"),
            BigInteger.Parse("70386486105843025439939619828917593665686757934951"),
            BigInteger.Parse("62176457141856560629502157223196586755079324193331"),
            BigInteger.Parse("64906352462741904929101432445813822663347944758178"),
            BigInteger.Parse("92575867718337217661963751590579239728245598838407"),
            BigInteger.Parse("58203565325359399008402633568948830189458628227828"),
            BigInteger.Parse("80181199384826282014278194139940567587151170094390"),
            BigInteger.Parse("35398664372827112653829987240784473053190104293586"),
            BigInteger.Parse("86515506006295864861532075273371959191420517255829"),
            BigInteger.Parse("71693888707715466499115593487603532921714970056938"),
            BigInteger.Parse("54370070576826684624621495650076471787294438377604"),
            BigInteger.Parse("53282654108756828443191190634694037855217779295145"),
            BigInteger.Parse("36123272525000296071075082563815656710885258350721"),
            BigInteger.Parse("45876576172410976447339110607218265236877223636045"),
            BigInteger.Parse("17423706905851860660448207621209813287860733969412"),
            BigInteger.Parse("81142660418086830619328460811191061556940512689692"),
            BigInteger.Parse("51934325451728388641918047049293215058642563049483"),
            BigInteger.Parse("62467221648435076201727918039944693004732956340691"),
            BigInteger.Parse("15732444386908125794514089057706229429197107928209"),
            BigInteger.Parse("55037687525678773091862540744969844508330393682126"),
            BigInteger.Parse("18336384825330154686196124348767681297534375946515"),
            BigInteger.Parse("80386287592878490201521685554828717201219257766954"),
            BigInteger.Parse("78182833757993103614740356856449095527097864797581"),
            BigInteger.Parse("16726320100436897842553539920931837441497806860984"),
            BigInteger.Parse("48403098129077791799088218795327364475675590848030"),
            BigInteger.Parse("87086987551392711854517078544161852424320693150332"),
            BigInteger.Parse("59959406895756536782107074926966537676326235447210"),
            BigInteger.Parse("69793950679652694742597709739166693763042633987085"),
            BigInteger.Parse("41052684708299085211399427365734116182760315001271"),
            BigInteger.Parse("65378607361501080857009149939512557028198746004375"),
            BigInteger.Parse("35829035317434717326932123578154982629742552737307"),
            BigInteger.Parse("94953759765105305946966067683156574377167401875275"),
            BigInteger.Parse("88902802571733229619176668713819931811048770190271"),
            BigInteger.Parse("25267680276078003013678680992525463401061632866526"),
            BigInteger.Parse("36270218540497705585629946580636237993140746255962"),
            BigInteger.Parse("24074486908231174977792365466257246923322810917141"),
            BigInteger.Parse("91430288197103288597806669760892938638285025333403"),
            BigInteger.Parse("34413065578016127815921815005561868836468420090470"),
            BigInteger.Parse("23053081172816430487623791969842487255036638784583"),
            BigInteger.Parse("11487696932154902810424020138335124462181441773470"),
            BigInteger.Parse("63783299490636259666498587618221225225512486764533"),
            BigInteger.Parse("67720186971698544312419572409913959008952310058822"),
            BigInteger.Parse("95548255300263520781532296796249481641953868218774"),
            BigInteger.Parse("76085327132285723110424803456124867697064507995236"),
            BigInteger.Parse("37774242535411291684276865538926205024910326572967"),
            BigInteger.Parse("23701913275725675285653248258265463092207058596522"),
            BigInteger.Parse("29798860272258331913126375147341994889534765745501"),
            BigInteger.Parse("18495701454879288984856827726077713721403798879715"),
            BigInteger.Parse("38298203783031473527721580348144513491373226651381"),
            BigInteger.Parse("34829543829199918180278916522431027392251122869539"),
            BigInteger.Parse("40957953066405232632538044100059654939159879593635"),
            BigInteger.Parse("29746152185502371307642255121183693803580388584903"),
            BigInteger.Parse("41698116222072977186158236678424689157993532961922"),
            BigInteger.Parse("62467957194401269043877107275048102390895523597457"),
            BigInteger.Parse("23189706772547915061505504953922979530901129967519"),
            BigInteger.Parse("86188088225875314529584099251203829009407770775672"),
            BigInteger.Parse("11306739708304724483816533873502340845647058077308"),
            BigInteger.Parse("82959174767140363198008187129011875491310547126581"),
            BigInteger.Parse("97623331044818386269515456334926366572897563400500"),
            BigInteger.Parse("42846280183517070527831839425882145521227251250327"),
            BigInteger.Parse("55121603546981200581762165212827652751691296897789"),
            BigInteger.Parse("32238195734329339946437501907836945765883352399886"),
            BigInteger.Parse("75506164965184775180738168837861091527357929701337"),
            BigInteger.Parse("62177842752192623401942399639168044983993173312731"),
            BigInteger.Parse("32924185707147349566916674687634660915035914677504"),
            BigInteger.Parse("99518671430235219628894890102423325116913619626622"),
            BigInteger.Parse("73267460800591547471830798392868535206946944540724"),
            BigInteger.Parse("76841822524674417161514036427982273348055556214818"),
            BigInteger.Parse("97142617910342598647204516893989422179826088076852"),
            BigInteger.Parse("87783646182799346313767754307809363333018982642090"),
            BigInteger.Parse("10848802521674670883215120185883543223812876952786"),
            BigInteger.Parse("71329612474782464538636993009049310363619763878039"),
            BigInteger.Parse("62184073572399794223406235393808339651327408011116"),
            BigInteger.Parse("66627891981488087797941876876144230030984490851411"),
            BigInteger.Parse("60661826293682836764744779239180335110989069790714"),
            BigInteger.Parse("85786944089552990653640447425576083659976645795096"),
            BigInteger.Parse("66024396409905389607120198219976047599490197230297"),
            BigInteger.Parse("64913982680032973156037120041377903785566085089252"),
            BigInteger.Parse("16730939319872750275468906903707539413042652315011"),
            BigInteger.Parse("94809377245048795150954100921645863754710598436791"),
            BigInteger.Parse("78639167021187492431995700641917969777599028300699"),
            BigInteger.Parse("15368713711936614952811305876380278410754449733078"),
            BigInteger.Parse("40789923115535562561142322423255033685442488917353"),
            BigInteger.Parse("44889911501440648020369068063960672322193204149535"),
            BigInteger.Parse("41503128880339536053299340368006977710650566631954"),
            BigInteger.Parse("81234880673210146739058568557934581403627822703280"),
            BigInteger.Parse("82616570773948327592232845941706525094512325230608"),
            BigInteger.Parse("22918802058777319719839450180888072429661980811197"),
            BigInteger.Parse("77158542502016545090413245809786882778948721859617"),
            BigInteger.Parse("72107838435069186155435662884062257473692284509516"),
            BigInteger.Parse("20849603980134001723930671666823555245252804609722"),
            BigInteger.Parse("53503534226472524250874054075591789781264330331690"),
        };
    }
}
