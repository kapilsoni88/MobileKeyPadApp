using System.Text;

namespace MobileKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TextDecorder.OldPhonePad("33#")); // Output: E
            Console.WriteLine(TextDecorder.OldPhonePad("227*#")); // Output: B
            Console.WriteLine(TextDecorder.OldPhonePad("4433555 555666#")); // Output: Hello
            Console.WriteLine(TextDecorder.OldPhonePad("8 88777444666* 664#")); // Output: ???

            Console.ReadKey();
        }
    }
}
