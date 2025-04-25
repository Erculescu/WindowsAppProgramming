using System;

public class Persoana
{
	public string Nume { get; set; }
	public int Varsta { get; set; }
	public string Adresa { get; set; }
	public string Sex { get; set; }
	public float Greutate { get; set; }
	public int Inaltime { get; set; }
	public Persoana(string nume,int varsta,string adresa, string sex,
		float greutate,int inaltime)
	{
		Nume = nume;
		Varsta = varsta;
		Adresa = adresa;
		Sex = sex;
		Greutate = greutate;
		Inaltime = inaltime;
	}
	
}
