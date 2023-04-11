using tp.Models;

namespace tp.Services;

public static class MovieService{
    static List<Movie> Movies { get; set;}

    static MovieService(){
        Movies = new List<Movie>
        {
            new Movie { Name = "Perros de la calle", Code="PCA", Category="Acción/thriller", Minutes=99, Review="Una banda organizada es contratada para atracar una empresa y llevarse unos diamantes. Sin embargo, antes de que suene la alarma, la policía ya está allí. Algunos miembros de la banda mueren en el enfrentamiento con las fuerzas del orden, y los demás se reúnen en el lugar convenido."},
            new Movie { Name = "Tiempos violentos", Code="PFI", Category="Thriller", Minutes=153, Review="Jules y Vincent, dos asesinos a sueldo con no demasiadas luces, trabajan para el gángster Marsellus Wallace. Su misión: recuperar un misterioso maletín."},
            new Movie { Name = "Jackie Brown", Code="JBR", Category="Thriller", Minutes=154, Review="Jackie Brown (Pam Grier) es una azafata de vuelo que necesita dinero y hace de correo para Robbie, un mafioso buscado por la policía. Un día es sorprendida en la aduana y acusada de tráfico de drogas y evasión de capital. Sólo podrá evitar su ingreso en prisión, si acepta una propuesta de la policía: ayudarles a llegar hasta Robbie."},
            new Movie { Name = "Kill Bill vol 1", Code="KB1", Category="Acción", Minutes=110, Review="El día de su boda, una asesina profesional (Thurman) sufre el ataque de algunos miembros de su propia banda, que obedecen las órdenes de Bill (David Carradine), el jefe de la organización criminal. Logra sobrevivir al ataque, aunque queda en coma. Cuatro años después despierta dominada por un gran deseo de venganza."},
            new Movie { Name = "Kill Bill vol 2", Code="KB2", Category="Action", Minutes=137, Review="Tras eliminar a algunos miembros de la banda que intentaron asesinarla el día de su boda, 'Mamba Negra' (Uma Thurman) intenta acabar con los demás, especialmente con Bill, su antiguo jefe (David Carradine), que la había dado por muerta."},
            new Movie { Name = "Death proof", Code="DPR", Category="Slasher/acción", Minutes=114, Review="'Death Proof'gira en torno a un psicópata de la carretera llamado 'Especialista Mike', un asesino en serie que va aniquilando a sus víctimas, siempre chicas jóvenes, con su coche de especialista: 'a prueba de muerte'."},
            new Movie { Name = "Bastardos sin gloria", Code="BSG", Category="Acción/thriller", Minutes=146, Review="Segunda Guerra Mundial (1939-1945). En la Francia ocupada por los alemanes, Shosanna Dreyfus (Mélanie Laurent) presencia la ejecución de su familia por orden del coronel Hans Landa (Christoph Waltz). Después de huir a París, adopta una nueva identidad como propietaria de un cine. En otro lugar de Europa, el teniente Aldo Raine (Brad Pitt) adiestra a un grupo de soldados judíos ('los bastardos') para atacar objetivos concretos. Los hombres de Raine y una actriz alemana (Diane Kruger), que trabaja para los aliados, deben llevar a cabo una misión para hacer caer a los jefes del Tercer Reich. El destino quiere que todos se encuentren bajo la marquesina de un cine donde Shosanna espera para vengarse. "},
            new Movie { Name = "Django: desencadenado", Code="DDE", Category="Western/acción", Minutes=165, Review="En Texas, dos años antes de estallar la Guerra Civil Americana, King Schultz (Christoph Waltz), un cazarrecompensas alemán que sigue la pista a unos asesinos para cobrar por sus cabezas, le promete al esclavo negro Django (Jamie Foxx) dejarlo en libertad si le ayuda a atraparlos. Él acepta, pues luego quiere ir a buscar a su esposa Broomhilda (Kerry Washington), esclava en una plantación del terrateniente Calvin Candie (Leonardo DiCaprio). "},
            new Movie { Name = "Los 8 más odiados", Code="8MO", Category="Western/thriller", Minutes=167, Review="Unos años después de la Guerra de Secesión, el cazarrecompensas John Ruth viaja con su fugitiva Daisy Domergue a Red Rock, donde Ruth entregará a la mujer a la justicia. Por el camino se encuentran con Marquis Warren, un antiguo soldado de la Unión, y Chris Mannix, un sureño que afirma ser el sheriff. Los cuatro se refugian de una ventisca en un puerto de montaña donde conocen a otros cuatro rostros desconocidos. Allí, los ocho viajeros descubrirán que puede ser que no lleguen a Red Rock."},
            new Movie { Name = "Erase una vez en Hollywood", Code="EUV", Category="Thriller/drama/comedia", Minutes=165, Review="Hollywood, años 60. La estrella de un western televisivo, Rick Dalton (Leonardo DiCaprio), intenta amoldarse a los cambios del medio al mismo tiempo que su doble (Brad Pitt). La vida de Dalton está ligada completamente a Hollywood, y es vecino de la joven y prometedora actriz y modelo Sharon Tate (Margot Robbie) que acaba de casarse con el prestigioso director Roman Polanski. "}
        };
    }

    public static List<Movie> GetAll() => Movies;

    public static void Add(Movie obj){
       if(obj == null){
         return;
       }

       Movies.Add(obj);
    }

    public static void Delete(string code){
        var movieToDelete = Get(code);

        if (movieToDelete != null){
            Movies.Remove(movieToDelete);
        }
    }
    public static Movie? Get(string code) => Movies.FirstOrDefault(x => x.Code.ToLower() == code.ToLower());
}