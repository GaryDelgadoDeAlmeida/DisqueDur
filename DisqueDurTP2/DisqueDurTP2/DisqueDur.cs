using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DisqueDurTP2
{
    class DisqueDur
    {
        string marque, modele;  //chaîne de caractère
        double capacite, espaceOccupe;
        int NbPartitions, NbFichiers;

        public DisqueDur()
        {
            Console.WriteLine("marque ?"); //Ceci est l'étape de création d'un disque dur
            marque = Console.ReadLine();
            Console.WriteLine("modele ?"); //L'utilisation saisira la marque, le modèle et la capacité du disque dur
            modele = Console.ReadLine();
            Console.WriteLine("Capacité ?");
            capacite = Double.Parse(Console.ReadLine());
            espaceOccupe = 0; // Initialisez les autres valeurs à 0
		    NbPartitions = 0;
		    NbFichiers = 0;
        }
        
        public void diminuerEspOccup()
        {
            // l'espace occupe sera diminue selon les souhaits de l'utilisateur
            int diminution;

            Console.WriteLine("De combien voulez-vous diminuer l'espace occupé ?");
            diminution = Int32.Parse(Console.ReadLine());
            if (espaceOccupe >= diminution)
            {
                espaceOccupe = espaceOccupe - diminution;
            }
            else
            {
                Console.WriteLine("Diminution trop importante. La capacité n'a pas changé");
            }
        }
        
        public void augmenterEspOccup()
        {
            //L'espace occupe sera augmenté selon les souhaits de l'utilisateur
            int augmente;
            double total;

            Console.WriteLine("De combien voulez-vous augmenter l'espace occupé ?");
            augmente = Int32.Parse(Console.ReadLine());
            total = espaceOccupe + augmente;
            if (total <= capacite)
            {
                espaceOccupe = total;
            }
            else
            {
                Console.WriteLine("Votre disque dur n'a pas assez de capacité. L'espace occupé n'a pas changé");
            }
        }
        
        public void ajoutPart()
        {
            //permet à l'utilisateur de créer des partitions supplémentaires
            Console.WriteLine("Combien de partitions voulez-vous ajouter ?");
            NbPartitions = Int32.Parse(Console.ReadLine());
            while (NbPartitions < 0)
            {
                Console.WriteLine("Veuillez entrer un nombre de partition correct");
                NbPartitions = Int32.Parse(Console.ReadLine());
            }
        }
        
        public void supprPart()
        {
            //permet à l'utilisateur de supprimer une partition
            if (NbPartitions > 1)
            {
                NbPartitions = NbPartitions - 1;
                Console.WriteLine("Suppression d'une partition");
            }
            else
            {
                Console.WriteLine("Impossible, vous n'avez pas assez de partition");
            }
        }
        
        public void ajoutFichier()
        {
            // L'utilisateur va pouvoir ajouyer des fichiers sur le disque
            int nb;

            Console.WriteLine("Combien voulez-vous ajouter de fichiers ?");
            nb = Int32.Parse(Console.ReadLine());
            while (nb < 0)
            {
                Console.WriteLine("Entrez une valeur correcte");
                nb = Int32.Parse(Console.ReadLine());
            }
            NbFichiers = NbFichiers + nb;
            Console.WriteLine("NbFichiers : " + NbFichiers);
        }
        
        public void supprFichier()
        {
            int nb;

            Console.WriteLine("Combien voulez-vous supprimer de fichiers ?");
            nb = Int32.Parse(Console.ReadLine());
            if (NbFichiers >= nb)
            {
                NbFichiers = NbFichiers - nb;
                Console.WriteLine("Suppression de fichier réussi");
            }
            else
            {
                Console.WriteLine("Impossible, vous n'avez pas assez de fichiers.");
            }
        }
        
        public void espaceLibre()
        {
            // Calcule et affiche l'espace libre sur le disque
            double espLibre;
            espLibre = capacite - espaceOccupe;
            Console.WriteLine("Espace Libre : " + espLibre);
        }

        public void proprietes()
        {
            // affiche les proprietes du disque
            Console.WriteLine("Marque du disque dur : " + marque);
            Console.WriteLine("Modele du disque dur : " + modele);
            Console.WriteLine("Capacite du disque dur : " + capacite + " Go");
            Console.WriteLine("Espace occupe : " + espaceOccupe + " Go");
            Console.WriteLine("Nombre de partitions sur le disque dur : " + NbPartitions);
            Console.WriteLine("Nombre de fichiers sur le disque dur : " + NbFichiers);
        }
    }
}
