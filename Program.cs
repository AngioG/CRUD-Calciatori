using System;

namespace AngiolettiCalcio
{
    class Program
    {
        public struct calciatore
        {
            public string codice, cognome, nome, nazione, ruolo;
            public DateTime nascita;
            public bool primaSquadra;
        }
        static void Main(string[] args)
        {
            calciatore[] squadra = new calciatore[100];
            int num = 0;
            ConsoleKeyInfo scelta = default;
            bool preinseriti = false;
            do
            {
                Console.Clear();

                Console.WriteLine("###########################################");
                Console.WriteLine("#                                         #");
                Console.WriteLine("# [0] Preinserimento dati calciatori      #");
                Console.WriteLine("# [1] Inserisci un calciatore             #");
                Console.WriteLine("# [2] Elenca tutti i calciatori           #");
                Console.WriteLine("# [3] Modifica i dati di un calciatore    #");
                Console.WriteLine("# [4] Rimuovi un calciatore dell'elenco   #");
                Console.WriteLine("# [5] Elenca i giocatori in prima squadra #");
                Console.WriteLine("# [6] Visualizza calciatori per ruolo     #");
                Console.WriteLine("# [7] Elenca i calciatori minorenni       #");
                Console.WriteLine("#                                         #");
                Console.WriteLine("###########################################\n");
                Console.WriteLine("[u] Esci\n\n");

                if (num == 0)
                    Console.WriteLine("Ricorda che non hai ancora inserito nessun giocatore");

                scelta = Console.ReadKey(true);

                Console.Clear();

                switch (scelta.KeyChar.ToString())
                {
                    case "0":           //Preinserimento dati
                        {
                            if (preinseriti)
                            {
                                Console.WriteLine("Hai già inserito questi calciatori nell'elenco");
                            }

                            if(!preinseriti)
                            {
                                calciatore NewCalciatore = default;

                                NewCalciatore.nome = "Marco";
                                NewCalciatore.cognome = "Sau";
                                NewCalciatore.codice = "SAUMRC80P10A783C";
                                NewCalciatore.nazione = "Italia";
                                NewCalciatore.ruolo = "Attaccante";
                                NewCalciatore.primaSquadra = false;
                                NewCalciatore.nascita = DateTime.Parse("1980/09/10");
                                squadra[num] = NewCalciatore;
                                num = num + 1;

                                NewCalciatore.nome = "Aldo";
                                NewCalciatore.cognome = "Baglio";
                                NewCalciatore.codice = "BGLLDA58P28G273U";
                                NewCalciatore.nazione = "Italia";
                                NewCalciatore.ruolo = "Attaccante";
                                NewCalciatore.primaSquadra = true;
                                NewCalciatore.nascita = DateTime.Parse("1958 / 09 / 28");
                                squadra[num] = NewCalciatore;
                                num = num + 1;

                                NewCalciatore.nome = "Giovanni";
                                NewCalciatore.cognome = "Storti";
                                NewCalciatore.codice = "STRGNN57B20F205U";
                                NewCalciatore.nazione = "Italia";
                                NewCalciatore.ruolo = "Portiere";
                                NewCalciatore.primaSquadra = true;
                                NewCalciatore.nascita = DateTime.Parse("1957 / 02 / 20");
                                squadra[num] = NewCalciatore;
                                num = num + 1;

                                NewCalciatore.nome = "Giacomo";
                                NewCalciatore.cognome = "Storti";
                                NewCalciatore.codice = "PRTGCM56D26B301E";
                                NewCalciatore.nazione = "Italia";
                                NewCalciatore.ruolo = "Centrocampista";
                                NewCalciatore.primaSquadra = true;
                                NewCalciatore.nascita = DateTime.Parse("1956 / 04 / 26");
                                squadra[num] = NewCalciatore;
                                num = num + 1;

                                NewCalciatore.nome = "Leone";
                                NewCalciatore.cognome = "Della Muzia";
                                NewCalciatore.codice = "DLLLNE02H15I628F";
                                NewCalciatore.nazione = "Italia";
                                NewCalciatore.ruolo = "Difensore";
                                NewCalciatore.primaSquadra = false;
                                NewCalciatore.nascita = DateTime.Parse("2002 / 06 / 15");
                                squadra[num] = NewCalciatore;
                                num = num + 1;

                                NewCalciatore.nome = "Vadim";
                                NewCalciatore.cognome = "Cantoni";
                                NewCalciatore.codice = "CNTVDM04C14Z154B";
                                NewCalciatore.nazione = "Russia";
                                NewCalciatore.ruolo = "Difensore";
                                NewCalciatore.primaSquadra = false;
                                NewCalciatore.nascita = DateTime.Parse("2004 / 03 / 14");
                                squadra[num] = NewCalciatore;
                                num = num + 1;

                                preinseriti = true;
                                Console.WriteLine("Calciatori inseriti correttamente");
                            }
                         
                            break;
                        }


                    case "1":           //Inserisci dati calciatore
                        {
                            string prova = default;
                            DateTime oggi = DateTime.Today;

                            if (num > 75)
                            {
                                Console.WriteLine("Hai troppi calciatori nella tua squadra");
                                break;
                            }

                            calciatore NewCalciatore = default;

                            Console.Write("Nome del calciatore:  ");
                            prova = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(prova))
                            {
                                Console.WriteLine("Devi inserire un nome!");
                            }
                            NewCalciatore.nome = prova;

                            Console.Write("Cognome del calciatore:  ");
                            prova = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(prova))
                            {
                                Console.WriteLine("Devi inserire un cognome!");
                            }
                            NewCalciatore.cognome = prova;

                            Console.Write("Codice fiscale del calciatore:  ");
                            prova = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(prova))
                            {
                                Console.WriteLine("Devi inserire un nome!");
                            }
                            int x = 0;
                            while (x < num)
                            {
                                if (prova == squadra[x].codice)
                                {
                                    Console.WriteLine("Hai già inserito questo calciatore");
                                    break;
                                }
                                x = x + 1;
                            }
                            NewCalciatore.codice = prova;

                            Console.Write("Provenienza del calciatore:  ");
                            prova = Console.ReadLine();
                            if (String.IsNullOrWhiteSpace(prova))
                            {
                                Console.WriteLine("Devi inserire uno stato!");
                            }
                            NewCalciatore.nazione = prova;

                            Console.Write("Ruolo del calciatore:  ");
                            prova = Console.ReadLine();
                            if (prova == "Portiere" || prova == "Difensore" || prova == "Centrocampista" || prova == "Attaccante")
                                NewCalciatore.ruolo = prova;
                            else
                            {
                                Console.WriteLine("Devi inserire un ruolo tra: Portiere, Difensore, Centrocampista e Attaccante");
                                break;
                            }


                            Console.Write("Data di nascita del calciatore:  ");
                            if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
                            {
                                if (data <= oggi)
                                    NewCalciatore.nascita = data;
                                else
                                    Console.WriteLine("Questo giocatore non è ancora nato");
                            }
                            else
                            {
                                Console.WriteLine("Devi inserire una data valida");
                                break;
                            }


                            do
                            {
                                Console.Write("Inserisci 1 se il calciatore è della prima squadra, altrimenti 0:  ");
                                scelta = Console.ReadKey();
                                if (scelta.KeyChar.ToString() == "1")
                                {
                                    NewCalciatore.primaSquadra = true;
                                }

                                if (scelta.KeyChar.ToString() == "0")
                                {
                                    NewCalciatore.primaSquadra = false;
                                }
                                Console.WriteLine();
                            } while (scelta.KeyChar.ToString() != "0" && scelta.KeyChar.ToString() != "1");

                            squadra[num] = NewCalciatore;
                            num += 1;
                            Console.WriteLine("\nCalciatore inserito correttamente");

                            break;
                        }

                    case "2":
                        {
                            if (num == 0)
                            {
                                Console.WriteLine("Non hai inserito nessun calciatore");
                                break;
                            }

                            int x = 0;

                            Console.WriteLine("\tElenco dei calciatori");

                            while (x < num)
                            {
                                Console.WriteLine(squadra[x].codice);
                                Console.Write(squadra[x].cognome + "\t");
                                Console.WriteLine(squadra[x].nome);
                                Console.WriteLine($"Nato in {squadra[x].nazione} il {squadra[x].nascita.ToString("dd/MM/yyyy")}");
                                Console.WriteLine(squadra[x].ruolo);
                                if (squadra[x].primaSquadra)
                                    Console.WriteLine("Prima squadra");
                                else
                                    Console.WriteLine("Non prima squadra");
                                Console.WriteLine("".PadRight(40, '#'));

                                x = x + 1;
                            }

                            break;
                        }


                    case "3":
                        {
                            if (num == 0)
                            {
                                Console.WriteLine("Non hai inserito nessun calciatore");
                                break;
                            }

                            int x = 0;

                            Console.Write("Insirisci il codice fiscale o il cognome del calciatore:  ");
                            string cerca = Console.ReadLine();
                            bool found = false;

                            while (x < num)
                            {
                                if (squadra[x].cognome == (cerca) || cerca == squadra[x].codice)
                                {
                                    found = true;
                                    break;
                                }
                                x += 1;
                            }


                                if (!found)
                                {
                                    Console.WriteLine("Nessun calciatore trovato");
                                }

                                if (found)
                                {
                                    do
                                    {
                                        Console.Clear();

                                        Console.Write($"{squadra[x].nome} {squadra[x].cognome}");
                                        Console.WriteLine("################################################");
                                        Console.WriteLine("#                                              #");
                                        Console.WriteLine("#       [1] Cambia il nome del calciatore      #");
                                        Console.WriteLine("#      [2] Cambia il cognome del calciatore    #");
                                        Console.WriteLine("#     [3] Cambia il codice del calciatore      #");
                                        Console.WriteLine("#   [4] Cambia la nazionalità del calciatore   #");
                                        Console.WriteLine("#      [5] Cambia il ruolo del calciatore      #");
                                        Console.WriteLine("# [6] Cambia la data di nascita del calciatore #");
                                        Console.WriteLine("#      [7] Cambia la squadra del giocatore     #");
                                        Console.WriteLine("#                                              #");
                                        Console.WriteLine("################################################\n");
                                        Console.WriteLine("[0] Esci");

                                        scelta = Console.ReadKey(true);
                                        string prova = default;

                                        switch (scelta.KeyChar.ToString())
                                        {
                                            case "1":
                                                {
                                                    

                                                    Console.Write($"Nuovo nome del calciatore, prima era {squadra[x].nome}:  ");
                                                    prova = Console.ReadLine();
                                                    if (String.IsNullOrWhiteSpace(prova))
                                                    {
                                                        Console.WriteLine("Devi inserire un nome!");
                                                        break;
                                                    }




                                                    break;
                                                }

                                            case "2":
                                                {
                                                    Console.Write($"Nuovo conome del calciatore, prima era {squadra[x].cognome}:  ");
                                                    prova = Console.ReadLine();
                                                    if (String.IsNullOrWhiteSpace(prova))
                                                        Console.WriteLine("Devi inserire un cognome!");
                                                    else
                                                    {
                                                        squadra[x].cognome = prova;
                                                        Console.WriteLine("Cognome modificato correttamente");
                                                    }

                                                    break;
                                                }

                                            case "3":
                                                {
                                                int a = 0;
                                                bool trovato = false;
                                                Console.Write($"Nuovo codice fiscale del calciatore, prima era {squadra[x].codice}:  ");
                                                    prova = Console.ReadLine();
                                                    if (String.IsNullOrWhiteSpace(prova))
                                                    {
                                                        Console.WriteLine("Devi inserire un codice!");
                                                    }

                                                while (a < num)
                                                {
                                                    if (prova == squadra[a].codice)
                                                    {
                                                        Console.WriteLine("Hai già inserito questo calciatore");
                                                        trovato = true;
                                                        break;
                                                    }
                                                    a = a + 1;
                                                }

                                                if (!trovato)
                                                {
                                                    squadra[x].nome = prova;
                                                    Console.WriteLine("Codice fiscale modificato correttamente");
                                                }
                                                    break;
                                                }

                                            case "4":
                                                {
                                                    Console.Write($"Nuova provenienza del calciatore, prima era {squadra[x].nazione}:  ");
                                                    prova = Console.ReadLine();
                                                    if (String.IsNullOrWhiteSpace(prova))
                                                    {
                                                        Console.WriteLine("Devi inserire una nazione!");
                                                    }
                                                    else
                                                    {
                                                        squadra[x].nazione = prova;
                                                        Console.WriteLine("Provenienza modificata correttamente");
                                                    }

                                                    break;
                                                }

                                            case "5":
                                                {
                                                    Console.Write($"Nuolo del calciatore, prima era {squadra[x].ruolo}:  ");
                                                    prova = Console.ReadLine();
                                                    if (prova == "Portiere" || prova == "Difensore" || prova == "Centrocampista" || prova == "Attaccante")
                                                        squadra[x].ruolo = prova;
                                                    else
                                                    {
                                                        Console.WriteLine("Devi inserire un ruolo tra: Portiere, Difensore, Centrocampista e Attaccante");
                                                        break;
                                                    }

                                                    break;
                                                }

                                            case "6":
                                                {
                                                    Console.Write($"Inserisci la data di nascita del calciatore, prima era {squadra[x].nascita.ToString("dd / MM / yyyy")}");
                                                    if (DateTime.TryParse(Console.ReadLine(), out DateTime data))
                                                    {
                                                        squadra[x].nascita = data;
                                                    }

                                                    break;
                                                }

                                            case "7":
                                                {
                                                    do
                                                    {
                                                        Console.Clear();
                                                        Console.Write("Inserisci 1 se il calciatore è della prima squadra, altrimenti 0, prima ");
                                                        if (squadra[x].primaSquadra)
                                                            Console.Write("era in prima squadra");
                                                        if (!squadra[x].primaSquadra)
                                                            Console.Write("non era in prima squadra");


                                                        scelta = Console.ReadKey();
                                                        if (scelta.KeyChar.ToString() == "1")
                                                        {
                                                            squadra[x].primaSquadra = true;
                                                        }

                                                        if (scelta.KeyChar.ToString() == "0")
                                                        {
                                                            squadra[x].primaSquadra = false;
                                                        }

                                                    } while (scelta.KeyChar.ToString() != "0" || scelta.KeyChar.ToString() != "1");

                                                    break;
                                                }

                                            case "0":
                                                {
                                                    break;
                                                }

                                            default:
                                                {
                                                    Console.WriteLine("Comando errato!");
                                                    break;
                                                }
                                        }

                                    if (scelta.KeyChar.ToString() != "0")
                                    {
                                        Console.WriteLine("Premi un tasto per continuare");
                                        Console.ReadKey(true);
                                    }

                                    } while (scelta.KeyChar.ToString() != "0");
                                }
                                break;
                        }

                    case "4":
                        {
                            if (num == 0)
                            {
                                Console.WriteLine("Non hai inserito nessun calciatore");
                                break;
                            }

                            int x = 0;

                            Console.Write("Insirisci il codice fiscale o il cognome del calciatore da rimuovere dall'elenco:  ");
                            string cerca = Console.ReadLine();
                            bool found = false;

                            while (x < num && !found)
                            {
                                if (cerca == squadra[x].codice || cerca == squadra[x].cognome)
                                {
                                    found = true;
                                }
                                else
                                    x += 1;
                            }

                            if (!found)
                            {
                                Console.WriteLine("Nessun calciatore trovato");
                            }

                            if (found)
                            {
                                squadra[x] = squadra[num - 1];
                                num -= 1;
                                Console.WriteLine($"{ cerca == squadra[x].cognome} { cerca == squadra[x].nome} è statorimosso  correttamente dall'elenxo!");
                            }

                            break;
                        }


                    case "6":
                        {
                            if (num == 0)
                            {
                                Console.WriteLine("Non hai inserito nessun calciatore");
                                break;
                            }

                            int x = 0;

                            Console.Write("Insirisci il ruolo da cercare:  ");
                            string cerca = Console.ReadLine();
                            bool found = false;

                            while (x < num)
                            {
                                if (cerca == squadra[x].ruolo)
                                {
                                    Console.WriteLine(squadra[x].codice);
                                    Console.Write(squadra[x].cognome + "\t");
                                    Console.WriteLine(squadra[x].nome);
                                    Console.WriteLine(squadra[x].nazione);
                                    Console.WriteLine(squadra[x].nascita.ToString("dd/MM/yyyy"));
                                    Console.WriteLine(squadra[x].ruolo);
                                    found = true;
                                    Console.WriteLine("".PadRight(40, '#'));
                                }
                                x = x + 1;
                            }

                            if (!found)
                            {
                                Console.WriteLine("Non hai ancora inserito nessun giocatore con questo ruolo");
                            }

                            break;
                        }


                    case "5":
                        {
                            if (num == 0)
                            {
                                Console.WriteLine("Non hai inserito nessun calciatore");
                                break;
                            }

                            int x = 0;

                            Console.WriteLine("\tElenco dei calciatori");

                            while (x < num)
                            {
                                if (squadra[x].primaSquadra)
                                {
                                    Console.WriteLine(squadra[x].codice);
                                    Console.Write(squadra[x].cognome + "\t");
                                    Console.WriteLine(squadra[x].nome);
                                    Console.WriteLine(squadra[x].nazione);
                                    Console.WriteLine(squadra[x].nascita.ToString("dd/MM/yyyy"));
                                    Console.WriteLine(squadra[x].ruolo);
                                    Console.WriteLine(squadra[x].ruolo);
                                    if (squadra[x].primaSquadra)
                                        Console.WriteLine("Prima squadra");
                                    else
                                        Console.WriteLine("Non prima squadra");
                                    Console.WriteLine("".PadRight(40, '#') + '\n');
                                }
                                x = x + 1;
                            }

                            break;
                        }


                    case "7":
                        {
                            if (num == 0)
                            {
                                Console.WriteLine("Non hai inserito nessun calciatore");
                                break;
                            }

                            int x = 0;
                            DateTime oggi = DateTime.Today;
                            bool found = false;

                            while (x < num)
                            {
                                bool minorenne = false;

                                if ((oggi.Year - squadra[x].nascita.Year) < 18)
                                    minorenne = true;

                                if ((oggi.Year - squadra[x].nascita.Year) == 18)
                                {
                                    if (squadra[x].nascita.Month > oggi.Month)
                                        minorenne = true;

                                    if (squadra[x].nascita.Month == oggi.Month)
                                        if (squadra[x].nascita.Day >= oggi.Day)
                                            minorenne = true;
                                }

                                if (minorenne)
                                {
                                    Console.WriteLine(squadra[x].codice);
                                    Console.Write(squadra[x].cognome + "\t");
                                    Console.WriteLine(squadra[x].nome);
                                    Console.WriteLine(squadra[x].nazione);
                                    Console.WriteLine(squadra[x].nascita.ToString("dd/MM/yyyy"));
                                    Console.WriteLine(squadra[x].ruolo);
                                    found = true;

                                    Console.WriteLine("".PadRight(40, '#'));
                                }
                                x = x + 1;
                            }

                            if (!found)
                                Console.WriteLine("Nessun calciatore minorenne inserito");

                            break;
                        }


                    case "u":
                        {
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Comando errato!");
                            break;
                        }
                }
                if (scelta.KeyChar.ToString() != "u")
                {
                    Console.WriteLine("Premi un tasto per continuare");
                    Console.ReadKey(true);
                }              

            } while (scelta.KeyChar.ToString() != "u");
        }
    }
}
