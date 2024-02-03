namespace AlgoritmaDersler;

public class Daire
{
    public const double pi =3.14; 
    /// <summary>
    /// Daireni alanini hesaplar
    /// </summary>
    /// <param name="r">Yaricap</param>
    /// <returns>Alan degeridir.</returns>

public static double AlaniHesapla(double r)
{
return pi*r*r;
}
/// <summary>
/// Dairenin Alanınınhesaplar.
/// </summary>
/// <param name="r">Yarıçap</param>
/// <param name="aci">Gördüğü açı</param>
/// <returns>Alan değeri</returns>
public static double AlaniHesapla(double r, double aci)
{
return pi*r*r*aci/360;
}


}

