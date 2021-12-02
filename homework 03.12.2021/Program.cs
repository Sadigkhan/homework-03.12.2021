{
    Employee maas = new Employee();
    maas.Maas("Sadigkhan", "Gaykhanov", "Developer olmaga calisir", 30);
}
class Employee
{
    public string Ad;
    public string Soyad;
    public string Vezife;
    public int GunlukMaas;
    public int AyliqMaas;
    public void Maas(string Ad,string Soyad,string Vezife,int GunlukMaas)
    {
        AyliqMaas = GunlukMaas * 30;
        Console.WriteLine($"{Ad} {Soyad} {Vezife} {AyliqMaas}");
    }
}
