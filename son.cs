using System;
using System.Collections.Generic;
using System.Text;

namespace homework15
{
    class Son : Father
    {
        public string _humor { get; set; }

        public Son(string name, int age, string humor) : base(name, age)
        {
            _nickName = name;
            _age = age;
            _humor = humor;
        }
        public void Hobby()
        {
            Console.WriteLine("Son hobby is Gaming");
        }
    }
}
