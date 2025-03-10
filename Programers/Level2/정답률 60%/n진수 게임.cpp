﻿#include <string>
#include <vector>

using namespace std;

char List[] = { '0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F' };

string Invert(int Num, int n)
{
    string R_Value  = "";
    while (Num  / n  != 0)
    {
        string Temp  = R_Value;
        R_Value  = List[Num  % n];
        R_Value  += Temp;
        Num  /= n;
    }
    string Temp  = R_Value;
    R_Value  = List[Num  % n];
    R_Value  += Temp;
    return R_Value;
}

string solution(int n, int t, int m, int p) {
    string answer  = "";
    string Result  = "";
    int Cnt  = 0;
    for (int i  = 0; i  < t  * m; i++) Result  += Invert(i, n);
    for (int i  = p  - 1; i  < Result.length(), Cnt  < t; i  += m)
    {
        answer  += Result[i];
        Cnt++;
    }

    return answer;
}