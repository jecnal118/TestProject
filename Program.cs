using System;

namespace First_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{10, 2, 5, 8, 1, 32, 55, -8, 1};
            for(int i = numbers.Length; i>0;i--){
                for(int j = 0; j<i-1; j++){
                    ref int hold = ref numbers[j];
                    ref int next = ref numbers[j+1];
                    if(hold>next){
                        Swap(ref hold, ref next);
                    }
                }
            }
            int i = 0;
            int t = 1;
            int j = -1;
            if(i<t){
                j = 5;
            }
            else{
                j = -5;
            }
            while(j<0){
                j++;
                i*=2;
            }
            do{
                t--;
                j--;
            }while(j>=-10);

            customer cust1 = new customer();
            //cust1.ID = 101;
        }
        static void Swap(ref int x, ref int y){
            int temp = x;
            x = y;
            y = temp;
        }

        public struct customer{
            int ID;
            string firstName;
            string lastName;
        }
    }
}
