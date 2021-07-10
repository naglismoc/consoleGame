using System;
using System.Collections.Generic;
using System.Text;

namespace consoleGame
{
    class Character
    {
        public string Name { get; set; }
        //public int Level { get; set; }
        public int Speed { get; set; }
        public int AttackXp { get; set; }
        public int DefenceXp { get; set; }
        public int StrengthXp { get; set; }
        public int HitpointsXp { get; set; }
        public int Hitpoints { get; set; }
        public int[] xpTable = {54,
59,
64,
69,
75,
82,
89,
97,
106,
115,
125,
136,
148,
161,
176,
192,
209,
228,
249,
272,
297,
324,
354,
387,
423,
462,
505,
552,
603,
659,
720,
787,
860,
940,
1027,
1122,
1226,
1340,
1465,
1601,
1750,
1913,
2091,
2286,
2499,
2732,
2987,
3265,
3569,
3902,
4266,
4664,
5099,
5575,
6095,
6664,
7286,
7966,
8710,
9523,
10412,
11384,
12447,
13609,
14880,
16269,
17788,
19449,
21265,
23251,
25422,
27796,
30392,
33230,
36333,
39726,
43436,
47492,
51927,
56776,
62078,
67876,
74215,
81146,
88725,
97011,
106071,
115978,
126810,
138654,
151604,
165763,
181245,
198173,
216682,
236920,
259048,
283243,
309697};

        public int Level()
        {
            return (int)((getLevel(AttackXp) + getLevel(DefenceXp) + getLevel(StrengthXp) + getLevel(HitpointsXp)) / 4);
        }
        public int getLevel(int xp)
        {
            for (int i = 0; i < xpTable.Length; i++)
            {
                if(xp < xpTable[i])
                {
                    return i - 1;
                }
            }
            return 0;
        }
        public override string ToString()
        {
            return
                this.Name +" is "+ this.Level()+" lvl. " +
                "hp "+ this.Hitpoints +
                "Attack " + this.getLevel(this.AttackXp) +
                "Defence " + this.getLevel(this.DefenceXp) +
                "Strength " + this.getLevel(this.StrengthXp);
        }
    }
}
