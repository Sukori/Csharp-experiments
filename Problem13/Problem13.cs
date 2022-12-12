﻿/*
 Work out the first ten digits of the sum of the following one-hundred 50-digit numbers.
37107287533902102798797998220837590246510135740250
46376937677490009712648124896970078050417018260538
74324986199524741059474233309513058123726617309629
91942213363574161572522430563301811072406154908250
23067588207539346171171980310421047513778063246676
89261670696623633820136378418383684178734361726757
28112879812849979408065481931592621691275889832738
44274228917432520321923589422876796487670272189318
47451445736001306439091167216856844588711603153276
70386486105843025439939619828917593665686757934951
62176457141856560629502157223196586755079324193331
64906352462741904929101432445813822663347944758178
92575867718337217661963751590579239728245598838407
58203565325359399008402633568948830189458628227828
80181199384826282014278194139940567587151170094390
35398664372827112653829987240784473053190104293586
86515506006295864861532075273371959191420517255829
71693888707715466499115593487603532921714970056938
54370070576826684624621495650076471787294438377604
53282654108756828443191190634694037855217779295145
36123272525000296071075082563815656710885258350721
45876576172410976447339110607218265236877223636045
17423706905851860660448207621209813287860733969412
81142660418086830619328460811191061556940512689692
51934325451728388641918047049293215058642563049483
62467221648435076201727918039944693004732956340691
15732444386908125794514089057706229429197107928209
55037687525678773091862540744969844508330393682126
18336384825330154686196124348767681297534375946515
80386287592878490201521685554828717201219257766954
78182833757993103614740356856449095527097864797581
16726320100436897842553539920931837441497806860984
48403098129077791799088218795327364475675590848030
87086987551392711854517078544161852424320693150332
59959406895756536782107074926966537676326235447210
69793950679652694742597709739166693763042633987085
41052684708299085211399427365734116182760315001271
65378607361501080857009149939512557028198746004375
35829035317434717326932123578154982629742552737307
94953759765105305946966067683156574377167401875275
88902802571733229619176668713819931811048770190271
25267680276078003013678680992525463401061632866526
36270218540497705585629946580636237993140746255962
24074486908231174977792365466257246923322810917141
91430288197103288597806669760892938638285025333403
34413065578016127815921815005561868836468420090470
23053081172816430487623791969842487255036638784583
11487696932154902810424020138335124462181441773470
63783299490636259666498587618221225225512486764533
67720186971698544312419572409913959008952310058822
95548255300263520781532296796249481641953868218774
76085327132285723110424803456124867697064507995236
37774242535411291684276865538926205024910326572967
23701913275725675285653248258265463092207058596522
29798860272258331913126375147341994889534765745501
18495701454879288984856827726077713721403798879715
38298203783031473527721580348144513491373226651381
34829543829199918180278916522431027392251122869539
40957953066405232632538044100059654939159879593635
29746152185502371307642255121183693803580388584903
41698116222072977186158236678424689157993532961922
62467957194401269043877107275048102390895523597457
23189706772547915061505504953922979530901129967519
86188088225875314529584099251203829009407770775672
11306739708304724483816533873502340845647058077308
82959174767140363198008187129011875491310547126581
97623331044818386269515456334926366572897563400500
42846280183517070527831839425882145521227251250327
55121603546981200581762165212827652751691296897789
32238195734329339946437501907836945765883352399886
75506164965184775180738168837861091527357929701337
62177842752192623401942399639168044983993173312731
32924185707147349566916674687634660915035914677504
99518671430235219628894890102423325116913619626622
73267460800591547471830798392868535206946944540724
76841822524674417161514036427982273348055556214818
97142617910342598647204516893989422179826088076852
87783646182799346313767754307809363333018982642090
10848802521674670883215120185883543223812876952786
71329612474782464538636993009049310363619763878039
62184073572399794223406235393808339651327408011116
66627891981488087797941876876144230030984490851411
60661826293682836764744779239180335110989069790714
85786944089552990653640447425576083659976645795096
66024396409905389607120198219976047599490197230297
64913982680032973156037120041377903785566085089252
16730939319872750275468906903707539413042652315011
94809377245048795150954100921645863754710598436791
78639167021187492431995700641917969777599028300699
15368713711936614952811305876380278410754449733078
40789923115535562561142322423255033685442488917353
44889911501440648020369068063960672322193204149535
41503128880339536053299340368006977710650566631954
81234880673210146739058568557934581403627822703280
82616570773948327592232845941706525094512325230608
22918802058777319719839450180888072429661980811197
77158542502016545090413245809786882778948721859617
72107838435069186155435662884062257473692284509516
20849603980134001723930671666823555245252804609722
53503534226472524250874054075591789781264330331690

Ok donc Pour la traduction. Chaque ligne est un nombre de 50 chiffres et il y en a 100.
Il faut additionner tous ces nombres et donner les 10 premiers chiffres de la somme de ces 100 nombres.

Le défi ici est une affaire de mémoire. La somme, c'est facile, mais on va être sur un dépassement de capacité, c'est clair. Et puis créer 100 variables, c'est un peu con aussi.
On peut peut-être passer tout ce texte et parse pour trouver un truc là ?

Avec Excel, pour jouer au filou, L'addition des premiers chiffres (depuis la gauche), ça fait 506.
Bon en réalité les retenues viennent plutôt de l'addition depuis la droite et influence tout ce qu'on a à la gauche.

Toujours selon Excel, qui arrondit en écriture scientifique, je cherche quelque chose de l'ordre de 5.53737623039088 e+51
Donc malgré l'arrondi, j'ai largement les 10 premiers chiffres: 5537376230

Merci excel.

Bon, maintenant que je sais ce que je cherche, je peux chercher comment le trouver sans faire imploser le pc ?
Ben déjà arrondir tous ces nombres en écriture scientifique c'est pas mal en fait ... Techniquement, comment on peut parse tout ce truc ?
Je colle tout ça dans une string et tous les 50, je pop out pour faire une table ? sum of table ? C'est ce que j'avais fait dans le problème 8 largest product serie
On copy paste juste et on filtre les retours à la ligne, alley.

L'ennui c'est qu'un nombre de 50 chiffres c'est pas un int ni un long... C'est déjà trop grand. Je tiens un truc avec mon écriture scientifique.
Par exemple split en 5 int64 de 10 chiffres (int32, n'est juste pas assez fiable).

Si on lit depuis la droite, on sait que c'est (long1 e+40) (long2 e+30) (long3 e+20) (long4 e+10) (long5 e+0)

 */

using System;
using System.IO;

namespace ProjectEuler
{
    public class Problem13
    {
        public static void LargeSum()
        {
            string bigList = "37107287533902102798797998220837590246510135740250\r\n46376937677490009712648124896970078050417018260538\r\n74324986199524741059474233309513058123726617309629\r\n91942213363574161572522430563301811072406154908250\r\n23067588207539346171171980310421047513778063246676\r\n89261670696623633820136378418383684178734361726757\r\n28112879812849979408065481931592621691275889832738\r\n44274228917432520321923589422876796487670272189318\r\n47451445736001306439091167216856844588711603153276\r\n70386486105843025439939619828917593665686757934951\r\n62176457141856560629502157223196586755079324193331\r\n64906352462741904929101432445813822663347944758178\r\n92575867718337217661963751590579239728245598838407\r\n58203565325359399008402633568948830189458628227828\r\n80181199384826282014278194139940567587151170094390\r\n35398664372827112653829987240784473053190104293586\r\n86515506006295864861532075273371959191420517255829\r\n71693888707715466499115593487603532921714970056938\r\n54370070576826684624621495650076471787294438377604\r\n53282654108756828443191190634694037855217779295145\r\n36123272525000296071075082563815656710885258350721\r\n45876576172410976447339110607218265236877223636045\r\n17423706905851860660448207621209813287860733969412\r\n81142660418086830619328460811191061556940512689692\r\n51934325451728388641918047049293215058642563049483\r\n62467221648435076201727918039944693004732956340691\r\n15732444386908125794514089057706229429197107928209\r\n55037687525678773091862540744969844508330393682126\r\n18336384825330154686196124348767681297534375946515\r\n80386287592878490201521685554828717201219257766954\r\n78182833757993103614740356856449095527097864797581\r\n16726320100436897842553539920931837441497806860984\r\n48403098129077791799088218795327364475675590848030\r\n87086987551392711854517078544161852424320693150332\r\n59959406895756536782107074926966537676326235447210\r\n69793950679652694742597709739166693763042633987085\r\n41052684708299085211399427365734116182760315001271\r\n65378607361501080857009149939512557028198746004375\r\n35829035317434717326932123578154982629742552737307\r\n94953759765105305946966067683156574377167401875275\r\n88902802571733229619176668713819931811048770190271\r\n25267680276078003013678680992525463401061632866526\r\n36270218540497705585629946580636237993140746255962\r\n24074486908231174977792365466257246923322810917141\r\n91430288197103288597806669760892938638285025333403\r\n34413065578016127815921815005561868836468420090470\r\n23053081172816430487623791969842487255036638784583\r\n11487696932154902810424020138335124462181441773470\r\n63783299490636259666498587618221225225512486764533\r\n67720186971698544312419572409913959008952310058822\r\n95548255300263520781532296796249481641953868218774\r\n76085327132285723110424803456124867697064507995236\r\n37774242535411291684276865538926205024910326572967\r\n23701913275725675285653248258265463092207058596522\r\n29798860272258331913126375147341994889534765745501\r\n18495701454879288984856827726077713721403798879715\r\n38298203783031473527721580348144513491373226651381\r\n34829543829199918180278916522431027392251122869539\r\n40957953066405232632538044100059654939159879593635\r\n29746152185502371307642255121183693803580388584903\r\n41698116222072977186158236678424689157993532961922\r\n62467957194401269043877107275048102390895523597457\r\n23189706772547915061505504953922979530901129967519\r\n86188088225875314529584099251203829009407770775672\r\n11306739708304724483816533873502340845647058077308\r\n82959174767140363198008187129011875491310547126581\r\n97623331044818386269515456334926366572897563400500\r\n42846280183517070527831839425882145521227251250327\r\n55121603546981200581762165212827652751691296897789\r\n32238195734329339946437501907836945765883352399886\r\n75506164965184775180738168837861091527357929701337\r\n62177842752192623401942399639168044983993173312731\r\n32924185707147349566916674687634660915035914677504\r\n99518671430235219628894890102423325116913619626622\r\n73267460800591547471830798392868535206946944540724\r\n76841822524674417161514036427982273348055556214818\r\n97142617910342598647204516893989422179826088076852\r\n87783646182799346313767754307809363333018982642090\r\n10848802521674670883215120185883543223812876952786\r\n71329612474782464538636993009049310363619763878039\r\n62184073572399794223406235393808339651327408011116\r\n66627891981488087797941876876144230030984490851411\r\n60661826293682836764744779239180335110989069790714\r\n85786944089552990653640447425576083659976645795096\r\n66024396409905389607120198219976047599490197230297\r\n64913982680032973156037120041377903785566085089252\r\n16730939319872750275468906903707539413042652315011\r\n94809377245048795150954100921645863754710598436791\r\n78639167021187492431995700641917969777599028300699\r\n15368713711936614952811305876380278410754449733078\r\n40789923115535562561142322423255033685442488917353\r\n44889911501440648020369068063960672322193204149535\r\n41503128880339536053299340368006977710650566631954\r\n81234880673210146739058568557934581403627822703280\r\n82616570773948327592232845941706525094512325230608\r\n22918802058777319719839450180888072429661980811197\r\n77158542502016545090413245809786882778948721859617\r\n72107838435069186155435662884062257473692284509516\r\n20849603980134001723930671666823555245252804609722\r\n53503534226472524250874054075591789781264330331690";
            

            List<int> nombreFinal = new(100);
            for(int i = 0; i < 50; i++)
            {
                nombreFinal.Add(0);
            }

            int[] additionneur = new int[50];

            int step = 0;

            //while big list pas finie
            while(step < ((100*50) + (99 * 2)))
            {
                step = MakeAdditionneur(step, additionneur, bigList);
                
                Addition(additionneur, nombreFinal);
            }

            Console.WriteLine("Le nombre final est: ");

            for (int i = nombreFinal.Count - 1; i >= 0; i--)
            {
                Console.Write(nombreFinal[i]);
            }
            
            
        }

        /**********************Fonctions************************/

        static int MakeAdditionneur(int step, int[] bufferAdd, string original)
        {
            for (int i = step + 49; i >= step; i--)
            {
                bufferAdd[i - step] = int.Parse(original[i].ToString());
            }

            return step += 52;
        }

        static void Addition(int[] aAdditionner, List<int> final)
        {
            int additionBuffer;
            bool retenue = false;

            int finalLength = final.Count - 50; //parce que final peut avoir plus de 50 chiffres

            for (int i = 0; i < 50; i++)
            {
                additionBuffer = final[i] + aAdditionner[i];

                if (retenue) { additionBuffer++; }

                if (additionBuffer > 9)
                {
                    additionBuffer -= 10; //parce que 9 + 9 est le plus grand cas possible et donne 18; 19 si retenue.
                    retenue = true;
                }
                else
                {
                    retenue = false;
                }


                final[i] = additionBuffer;
            }
            
            if (retenue)
            {
                Retenue(final, finalLength);
                // une fois cette boucle finie, s'il nous reste une retenue, il faut la gérer sur le nombre suivant de final, s'il y en a un, et propager son effet aussi loin que nécessaire
            }

        }

        static void Retenue(List<int> final, int cursor)
        {
            for (int i = final.Count - cursor; i < final.Count; i++)
            {
                if (final[i] < 9)
                {
                    final[i]++;
                    break; // à moins de faire 9 + 1, on n'a pas de retenue, alors stop la boucle
                }
                else
                {
                    final[i] = 0;
                }
        
            }


            if (final[0] == 0) //si on sort de la boucle avec un 0 à la fin de la liste, il faut ajouter 1 après, la retenue
            {
                final.Add(1);
            }
            
        }

    }
}