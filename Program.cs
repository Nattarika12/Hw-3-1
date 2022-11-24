class Program
{
    static void Main(string[] args) {
        CircularLinkedList<char> l = new CircularLinkedList<char>();
            int number = 0;
            int r = l.GetLength();
        
        while (true)
        {
            char checkInput = char.Parse(Console.ReadLine());
            if ((checkInput != 'J') && (checkInput != 'G') && (checkInput != 'O') && (checkInput != 'R')) {
                break; 
            }

            if (r == 0) {
                if ((checkInput == 'J') || (checkInput == 'G') || (checkInput == 'O')) {
                    l.Add(checkInput);
                    number += 1;
                    r++;
                } else {
                    Console.WriteLine("Invalid pattern.");
                }
            } else if (checkInput == 'R') {
                if (l.Get(l.GetLength() + number - 1) == 'R') {
                    Console.WriteLine("Invalid pattern.");
                } else {
                    l.Add(checkInput);
                    number += 1;
                }
            } else if ((checkInput == 'J') || (checkInput == 'G') || (checkInput == 'O')) {
                if (l.Get(l.GetLength() + number - 1) == 'R') {
                    if (l.Get(l.GetLength() + number - 2) == checkInput) {
                        Console.WriteLine("Invalid pattern.");
                    } else if ((checkInput == 'J') || (checkInput == 'G') || (checkInput == 'O')) {
                        l.Add(checkInput);
                        number += 1;
                    } else { Console.WriteLine("Invalid pattern."); }
                } else if ((l.Get(l.GetLength() + number - 3) == 'G') &&
                           (l.Get(l.GetLength() + number - 2) == 'G') &&
                           (l.Get(l.GetLength() + number - 1) == 'G') && checkInput == 'G') {
                    Console.WriteLine("Invalid pattern.");
                } else {
                    l.Add(checkInput);
                    number += 1;
                }
            }
        }
        Output(l);
    }
    static void Output(CircularLinkedList<char> l) {
         for (int i = 0; i < l.GetLength(); i++) {
            Console.Write("{0} ", l.Get(i));
        }
    }
}