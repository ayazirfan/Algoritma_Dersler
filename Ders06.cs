namespace AlgoritmaDersler;

public class Ders06
{
    /// <summary>
    /// Parametre olarak aldığı sayının tek olup olmadığını kontrol eder.
    /// </summary>
    /// <param name="n">Girilen sayı</param>
    /// <returns>Tek ise true aksi halde false dönüş yapar</returns>
    public static bool TekMi (int n)
    {
        if ( n % 2 == 1 )
        return true;
        return false;
    }
    /// <summary>
    /// Parametre olarak aldığı sayının çift olup olmadığını kontrol eder.
    /// </summary>
    /// <param name="n">Sayı</param>
    /// <returns>Çift ise true aksi halde false dönüş yapar</returns>

    public static bool CiftMi (int n)
    {
        if ( n%2==0)
        return true;
        return false;

    }
/// <summary>
/// Parametre olarak aldığı sayının mutlak değerini döner.
/// </summary>
/// <param name="n">Girilne sayıyı temsil eder</param>
/// <returns>Girilen sayının mutlak değer dönüş ifadesi olacak</returns>
    public static int MutlakDeger(int n)
    {
        if (n>0)
        {
            return n;        
        }
        else if (n<0)
        {
            return -1*n;
        }
        else
        return 0;
    }
    

}