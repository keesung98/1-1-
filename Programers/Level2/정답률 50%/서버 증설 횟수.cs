using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2.정답률_50_
{

    public class Solution
    {
        public int solution(int[] players, int m, int k)
        {
            int answer = 0;
            Queue<int> q = new Queue<int>();                    //server를 저장할 큐

            for (int t = 0; t < 24; t++)
            {
                while (q.Count > 0 && q.Peek() <= t)
                {
                    q.Dequeue();                                //서버가 끝난 시간이 되면 제거
                }

                int required = players[t] / m;                  //필요한 서버 수

                if (required > q.Count)
                {
                    int expansion = required - q.Count;         //필요한 서버 수 - 현재 서버 수
                    answer += expansion;                        //서버 증설 횟수 증가

                    for (int i = 0; i < expansion; i++)
                    {
                        q.Enqueue(t + k);                       //서버가 끝나는 시간을 저장
                    }
                }
            }

            return answer;
        }
    }
}
