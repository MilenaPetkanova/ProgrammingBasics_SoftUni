using System;
class IsoscelesTriangle
{
    // Write a program that prints an isosceles triangle of 9 copyright symbols ©
    // Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding 
    //to UTF-8 and assign a Unicode-friendly font in the console. 
    // Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, 
    //regardless of how much effort you put to fix it.
    
    static void Main()
    {
        // The symbol was displayed incorrectly, because of my under old version of Windows. //
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string a = @"   
                                ©    
                               © © 
                              ©   ©
                             ©     © 
                            © © © © ©
                   ";

        Console.WriteLine(a);
    }
}

// Another one:
static void Main()
{
    char A = (char)169;
    int outside = 2;
    int inside = 1;
    Console.WriteLine("   {0}", A);
    for (int i = 0; i <2 ; i++)
	{
		Console.WriteLine("{0}{1}{2}{3}", new string(' ', outside), A, new string(' ', inside), A);
        outside--;
        inside+=2;
	}
    Console.WriteLine("{0} {0} {0} {0}", A);
            
}