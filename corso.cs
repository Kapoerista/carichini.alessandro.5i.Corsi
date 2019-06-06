using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
public class Corso
{
    public int CorsoId{get; set;}
    public string Descrizione{get; set;}
    public string GiornoSettimana{get; set;}
    public int OraInizio{get; set;}
    public int OraFine{get; set;}
    public double Prezzo{get; set;}
    public int NumeroLezioni{get; set;}
    public int NumeroMaxPartecipanti{get; set;}
    public int DocenteId{get;}
    public int AmbitoId{get;}

}
public class corsiContex : DbContext
{
    public DbSet<Corso> corsi{get;set;}
    public DbSet<Docente> docenti{get;set;}
    public DbSet<Ambito> ambiti{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=corso.db");
    }
}