// See https://aka.ms/new-console-template for more information

#region // ---- HARRY POTTER ECRAN TITRE ----
string titre = "Harry Potter Game";
string sousTitre = "un jeu épique !";
Console.WriteLine(titre + ", " + sousTitre);
#endregion

#region ---- AFFICHAGE MENU ----
string format = "{0}. {1}";

// Formatage en une étape
string itemMenu = "nouvelle partie";
Console.WriteLine(format, 1, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());

// Formatage en 2 étapes
//string itemMenu = "nouvelle partie";
//string resultatFormatage = string.Format(format, 1, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
//Console.WriteLine(resultatFormatage);

itemMenu = "charger une partie";
string resultatFormatage = $"{2}. {itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower()}";
Console.WriteLine(resultatFormatage);

itemMenu = "crédits";
resultatFormatage = string.Format(format, 3, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
Console.WriteLine(resultatFormatage);

itemMenu = "quitter";
resultatFormatage = string.Format(format, 4, itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
Console.WriteLine(resultatFormatage);

// Première étape avant formatage
//string itemMenu = "nouvelle partie";
//Console.WriteLine(1 + "." + itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());

//itemMenu = "charger une partie";
//Console.WriteLine(2 + "." + itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
//itemMenu = "crédits";
//Console.WriteLine(3 + "." + itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
//itemMenu = "quitter";
//Console.WriteLine(4 + "." + itemMenu.Substring(0, 1).ToUpper() + itemMenu.Substring(1).ToLower());
#endregion

#region PARTIE SAISIE INFORMATIONS JOUEUR / JOUEUSE
//int j = 0;
//while (j < 2)
//{
//    Console.WriteLine("Test {0}", j);

//    j++;
//}

//int j = 0;
//do
//{
//    Console.WriteLine("Test {0}", j);

//    j++;
//} while (j < 2);

bool estAgeValid = false;
int agePlayer = 0;

while (!estAgeValid)
{
    #region Verif saisie non vide
    bool ageSaisiPasValide = true;
    string ageSaisie = "";
    do
    {
        Console.WriteLine("Ton âge s'il te plaît ?");
        ageSaisie = Console.ReadLine();

        ageSaisiPasValide = string.IsNullOrWhiteSpace(ageSaisie);

    } while (ageSaisiPasValide);
    #endregion

    //if (! string.IsNullOrEmpty(ageSaisie)) //== true)
    //{
    //    Console.WriteLine("Age bien saisie");
    //}
    //else
    //{
    //    Console.WriteLine("Âge obligatoire !");
    //    Environment.Exit(-1);
    //}

    agePlayer = int.Parse(ageSaisie); // int.MaxValue;
                                      // agePlayer = agePlayer + 10;

    int ageMinimum = 12;

    int comparaison = agePlayer.CompareTo(ageMinimum);
    Console.WriteLine(comparaison);

    estAgeValid = comparaison >= 0;
}

// 3° façon if
//if (! (comparaison >= 0))
//{
//    Console.WriteLine("Âge interdit !");
//    Environment.Exit(-1);
//}

// Une ligne sous le if
//if (!estAgeValid)
//    Environment.Exit(-1);

// 2° étape if
// Avant modif avec le while
// if (! estAgeValid)
//{
//    Console.WriteLine("Âge interdit !");
//    Environment.Exit(-1);
//}
if (estAgeValid)
{
    Console.WriteLine("Yes, vous pouvez continuer la saisie !");

    if (agePlayer < 18)
    {
        Console.WriteLine("Attention tu n'es pas majeur-e ...");
    }
    else if (agePlayer < 40)
    {
        Console.WriteLine("Ca va tu n'es pas trop vieux ... !");
    }
    else
    {
        Console.WriteLine("A priori, tu as au moins 40 ou plus ;)");
    }
}

// Premiere étape if
//bool verification = estAgeValid == false;
//if (verification)
//{
//    Console.WriteLine("Âge interdit !");
//    Environment.Exit(-1);
//}

//estAgeValid = estAgeValid || false;

// pour info : Console.WriteLine(int.MinValue);
// pour info : Console.WriteLine(int.MaxValue);


Console.WriteLine(agePlayer);
#endregion

#region ---- DATE DE NAISSANCE ---- 
/*
Console.WriteLine("Quelle est ta date de naissance ?");
string dateSaisie = Console.ReadLine();

DateTime dateEtHeureNaissance = DateTime.Parse(dateSaisie); // Vérification validité date de naissance

DateOnly dateNaissance = DateOnly.FromDateTime(dateEtHeureNaissance);

Console.WriteLine("Tu as saisie " + dateNaissance);
*/
#endregion

#region ---- PREPARATION ARME ---- 
// decimal puissanceArme = 10;

float puissanceArme = 10;
puissanceArme = 15.5f;

Console.WriteLine(puissanceArme);

int valeurParDefaultPuissanceArme = 10;

Console.WriteLine("Choisissez votre arme par défaut pour démarrer le jeu");

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"{i}. Arme {i + 1}");
    Console.WriteLine($"{i}. Arme {i + 1}");
}

// affectation sans cast puissanceArme = valeurParDefaultPuissanceArme;
// force cast int valeurPuissanceX = (int) puissanceArme;

#endregion

#region ---- CHOIX COTE FORCE ---- 
int AfficherForcesEtRetourneSelection()
{
    Console.WriteLine("De quel côté de la force es-tu ?");
    Console.WriteLine("1. Du côté lumineux");
    Console.WriteLine("2. Du côté obscure");
    Console.WriteLine("3. Je ne suis pas un jedi");

    string saisieForce = Console.ReadLine();
    return int.Parse(saisieForce);
}

int typeForce = AfficherForcesEtRetourneSelection(); 

const int forceLumineuse = 1;
const int forceObscure = 2;
const int sansForce = 3;


switch (typeForce)
{
    case forceLumineuse:
        {
            Console.WriteLine("Tu as choisi le côté lumineux");
        } break;
    case forceObscure:
        {
            Console.WriteLine("Tu as choisi le côté obscur");
        }
        break;
    case sansForce:
        {
            Console.WriteLine("Tu n'as pas de choix de force");
        }
        break;
    default:
        {
            Console.WriteLine("Tu n'as rien choisi");
        } break;
}

#endregion

#region ---- INITALISATION MOTEUR DE JEU ----
// APPROCHE MATRICIELLE
int[,] grilleDeJeu = new int[20,20];
const int AUCUN_PERSO = -1;

for (int i = 0; i < grilleDeJeu.GetLength(0); i++) // dimension 0 = ligne 0
{
    for (int j = 0; j <  grilleDeJeu.GetLength(1); j++)
    {
        grilleDeJeu[i, j] = AUCUN_PERSO;
    }
}
#endregion

#region ---- AFFICHAGE CREDIT ----
AffichageCredits(); // Execution ! 

void AffichageCredits() // Corps de méthode, non exécuté tant que pas utilisé
{
    Console.WriteLine("Thomas & co");
    Console.WriteLine("2023");
}

#endregion<