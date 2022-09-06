using System;
using System.ComponentModel.DataAnnotations;


namespace VoyagesFront
{
    public class Utilisateur
    {
        public const string InfoLogin = "le login est un texte compris entre 5 à 50 caractères sans espace";
        public const string InfoNom = "le nom est obligatoire et sa longueur doit être comprise entre 2 et 50 caractères";
        public const string InfoMotDePasse = "le mot de passe de 8 à 20 caractères sans espace est requis";


        [Required(ErrorMessage = InfoNom)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = InfoNom)]

        public string Nom { get; set; }


        [MaxLength(50, ErrorMessage = "le prénom ne peut pas dépasser 50 caractères")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = InfoLogin)]
        [RegularExpression("-_A-Za-z0-9{5,50}", ErrorMessage = InfoLogin)]
        public string Login { get; set; }

        [Required(ErrorMessage = InfoMotDePasse)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = InfoMotDePasse)]
        [DataType(DataType.Password)]

        public string MotDePasse { get; set; }

        [Required(ErrorMessage = "Veuillez confirmer votre mot de passe")]
        [Compare(nameof(MotDePasse), ErrorMessage = "La confirmation du mot de passe diffère du mot de passe")]
        public string ConfirmationMotDePasse { get; set; }

        [Required(ErrorMessage = "Vous devez renseigner votre date de naissance")]
        [DataType(DataType.Date)]
        public DateTime? DateDeNaissance { get; set; }

        public bool LettreDInformation { get; set; } = false;

        [EmailAddress(ErrorMessage = "L'adresse email n'est pas valide")]
        public string Email { get; set; }

        public string Pays { get; set; } = "France";


    }
}