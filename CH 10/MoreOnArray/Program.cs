using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnArray
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }
        private static void Print(int value)
        {
            Console.Write("{0} ", value);
        }
        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int  i in scores)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            //배열 정렬
            Array.Sort(scores);
            //배열 반복하면서 프린터 매소드 실행
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            //배열의 차원을 반환
            Console.WriteLine("Number of dimensions : {0}", scores.Rank);

            //배열 2진 탐색
            Console.WriteLine("Binary Search : 81 is at {0}", Array.BinarySearch<int>(scores, 81));
            //배열에서 90의 인덱스 위치 찾기
            Console.WriteLine("Binary Search : 90 is at {0}", Array.IndexOf(scores, 90));
            //배열의 모든 요소가 int인지 체크
            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));
           
            //지정한 조건에 맞는 첫번째 요소의 인덱스를 반환
            int index = Array.FindIndex<int>(scores,
                delegate(int score)
                {
                    if (score < 60)
                        return true;
                    else
                        return false;
                });
            scores[index] = 61;
            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));
            //배열에서 지정한 차원의 길이 반환
            Console.WriteLine("Old length of scores : {0}", scores.GetLength(0));
            //배열의 길이를 10으로 변환
            Array.Resize<int>(ref scores, 10);

            Console.WriteLine("New length of scores : {0}", scores.Length);

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
            //배열의 요소를 초기화(3번째까진 냅두고 뒤로 7개까지 0으로 채움)
            Array.Clear(scores, 3, 7);

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}
