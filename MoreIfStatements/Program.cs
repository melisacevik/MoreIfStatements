internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetMax(2, 10));
        Console.ReadLine();
    }

    static int GetMax(int num1, int num2)
    {

        #region basic exp.

        int result;

        if (num1 > num2)              // bir koşul ya doğrudur ya yanlıştır.
        {
            result = num1;            // eğer num1 num2den büyükse; sonuç num1'dir. max'ı alıyoruz.
        }
        else
        {
            result = num2;
        }

        return result;              //işlem bittikten sonra void Main kısmına geç ve istediğin iki sayısı yazdır.




        #endregion

    }

}