using System;
using System.Text;

namespace BTDD_1911505310114.DiemDanh
{
    class Bai2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // abstract class không thể tạo ra được đối tượng,
            // mà phải thông qua lớp con kế thừa từ nó.
            // SAI
            //Animal animal = new Animal();
            // Error: Cannot crEat14e an instance of the abstract class or interface 'Animal'

            // ĐÚNG
            Animal cat = new Cat();

            // hoặc:
            Cat cat1 = new Cat();

            Cow cow = new Cow();

            // Gọi các phương thức
            cat.Eat14();
            cow.Eat14();

            cat.AnimalSound14();
            cow.AnimalSound14();

            cat.Run14();
            cat.Run14();

            Console.ReadKey();
        }
    }

    // Khai báo abstract class
    public abstract class Animal
    {
        // abstract method
        public abstract void AnimalSound14();

        // virtual method
        public virtual void Eat14()
        {
            Console.WriteLine("Động vật ăn cỏ.");
        }

        // normal method
        public void Run14()
        {
            Console.WriteLine("Chạy bằng 4 chân.");
        }
    }

    // Lớp Cat kế thừa lớp Animal
    public class Cat : Animal
    {
        // abstract method: bắt buộc lớp con phải override lại từ lớp cha.
        // Khi override thì phạm vi truy cập phải giống của lớp cha: public
        public override void AnimalSound14()
        {
            Console.WriteLine("Mèo meow meow.");
        }

        // virtual method: việc override thì không bắt buộc.
        // Lớp con có thể dùng luôn định nghĩa từ lớp cha nếu phù hợp,
        // hoặc override (định nghĩa lại) nếu không phù hợp.
        // Khi override thì phạm vi truy cập phải giống của lớp cha: public
        public override void Eat14()
        {
            Console.WriteLine("Mèo ăn cá.");
        }

        // normal method Run1414() thì dùng luôn của lớp cha không phải làm gì.
    }

    // Lớp Cow kế thừa lớp Animal
    public class Cow : Animal
    {
        public override void AnimalSound14()
        {
            Console.WriteLine("Bò kêu ummuu bò.");
        }
    }
}
   