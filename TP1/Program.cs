class Program
{
  #region OPERATIONS_LOGOS
  const string MAIN_APP_LOGO = @"
    _____                ________   
      /  _  \ ___  ___ ____ \______ \  
     /  /_\  \\  \/  // __ \ |    |  \ 
    /    |    \>    <\  ___/ |    `   \
    \____|__  /__/\_ \\___  >_______  /
            \/      \/    \/        \/ 

 ";
  const string AVAILABLE_OPERATIONS_LOGO = @"
    
________                              __  .__                      
\_____  \ ______   ________________ _/  |_|__| ____   ____   ______
 /   |   \\____ \_/ __ \_  __ \__  \\   __\  |/  _ \ /    \ /  ___/
/    |    \  |_> >  ___/|  | \// __ \|  | |  (  <_> )   |  \\___ \ 
\_______  /   __/ \___  >__|  (____  /__| |__|\____/|___|  /____  >
        \/|__|        \/           \/                    \/     \/ 
";
  const string DEPOSIT_LOGO = @"
************A COMPLETER************
";
  const string WITHDRAWAL_LOGO = @"
************A COMPLETER************
";
  #endregion

  
  public static void Main(string[] args)
  {
    // Il n'est pas possible de quitter le Main car on y retourne
    // systématiquement après une sortie du menu des opérations
    // C'est inhabituel de faire un while(true) mais ça se peut
    // dans certaines circonstances, dont celle-ci.
    while (true)
    {
      // Gérer l'authentification
      


      // Gérer le menu principal (celui des opérations)
      
    }
  }

  
  
  #region UTILITY_FUNCTIONS  
  /// <summary>
  /// Permet d'écrire du texte à la console à un endroit précis
  /// </summary>
  /// <param name="text">Le texte à écrire</param>
  /// <param name="x">La colonne à laquelle écrire le texte</param>
  /// <param name="y">La ligne à laquelle écrire le texte.  La première ligne est en haut et le numéro de ligne augmente en descendant</param>
  static void WriteText(string text, int x, int y)
  {
    Console.SetCursorPosition(x, y);
    Console.Write(text);
  }
  /// <summary>
  /// Permet de signaler une erreur à la console à un endroit précis
  /// </summary>
  /// <param name="text">Le texte à écrire</param>
  /// <param name="x">La colonne à laquelle écrire le texte</param>
  /// <param name="y">La ligne à laquelle écrire le texte.  La première ligne est en haut et le numéro de ligne augmente en descendant</param>
  static void WriteError(string text, int x, int y)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    WriteText(text, x, y);
    Console.ForegroundColor = ConsoleColor.White;
  }
  #endregion
}