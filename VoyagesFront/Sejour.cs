using System;

namespace VoyagesFront 
    {
        
            public class Sejour { 
        
                private DateTime depart, retour;

                public Sejour(DateTime depart)
                {
                    this.depart = depart;
                    this.retour = depart + TimeSpan.FromDays(7);
                }

                public string Nom { get; set; } = "";

                public string Prenom => Nom.Split("")[0];

                public uint Nbpassagers { get; set; } = 1;

                public DateTime Depart
                {
                    get => depart;
                    set
                    
                    {

                        retour = value + Duree;
                        depart = value;
                    }
                }

                public DateTime Retour
                {
                    get => retour;
                    set 

                    {
                        if(value <= Depart)
                        {
                            depart = value - Duree;
                        }
                        retour = value;
                            
                    }
                    
                }

                public TimeSpan Duree => Retour - Depart;

                
            }
            
    }