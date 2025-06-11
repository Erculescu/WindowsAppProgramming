using System;

public class Tranzactie
{
	public Tranzactie()
	{
		public int CodProdus { get; set; }
		public string Denumire { get; set; }
	public decimal Pret { get; set; }
	public int Cantitate { get; set; }
	public override string ToString()
    {
        => $"{CodProdus} {Denumire} {Pret} {Cantitate}";
    }
}
}
