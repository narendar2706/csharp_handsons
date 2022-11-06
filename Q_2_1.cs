using System;

namespace cs_handsons
{
    class name_concate{
        public static void Main(String[] args){
            Console.WriteLine("enter your first name");
            string f_name=Console.ReadLine();
            Console.WriteLine("enter your last name");
            string l_name=Console.ReadLine();
            String full_name=f_name+" "+l_name;
            Console.WriteLine("Full Name :"+full_name);
        }
        
    }
}
