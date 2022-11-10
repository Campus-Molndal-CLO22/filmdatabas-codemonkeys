namespace MovieDatabase_Template
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using MovieDatabase;
    using MySql.Data.MySqlClient;
    using MySqlX.XDevAPI.Relational;

    public class MovieCrud
    {

        

        public MovieCrud(string connString) { }
        
        public void AddMovie(Movie movie)

        {

            // Kolla om filmen redan finns, uppdatera i så fall
            //var sql = "UPDATE Movies (Title, Year, LeadRole, Genre) " +
            //       "VALUES (@Title, @Year, @LeadRole, @Genre)";
            // Om inte, lägg till filmen i databasen
            // Lägg till skådespelarna i databasen
            // Lägg till relationen mellan filmen och skådespelarna i databasen
            var sql = "INSERT INTO Movies (Title, Year, LeadRole, Genre) " +
                "VALUES (@Title, @Year, @LeadRole, @Genre) " +
                "ON DUBLICATE KEY UPDATE (@Title, @Year, @LeadRole, @Genre)";

        }

        public void AddActor(Actor actor)
        {
            
            // Kolla om skådespelaren finns i databasen
            var conn = new MySqlConnection(connString);
            var sql = "SELECT * FROM name WHERE Actor = @name";
            var cmd = new MySqlCommand(sql, conn);
            // Uppdatera i så fall annars
            sql = "UPDATE * FROM name WHERE Actor = @name";
            // Lägg till skådespelaren i databasen
            cmd.Parameters.AddWithValue("@Actor", "@name");
        }

        public void AddActorToMovie(Actor actor, Movie movie)
        {

            // Kolla om relationen finns i databasen, i så fall är du klar
            // Annars lägg till relationen mellan filmen och skådespelaren i databasen

        }

        public List<Movie> GetMovies()
        {
            // Hämta alla filmer från databasen
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }

        public List<Movie> GetMoviesContaining(string search)
        {
            // Hämta alla matchande filmer från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }

        public List<Movie> GetMoviesFromYear(int year)
        {
             {
            DataTable dt = new DataTable();

            var connString = "server=ns8.inleed.net;uid=s60127_JamesS;pwd=RT89DwnZ82pglb8G;database=s60127_Codemonkeys";
            var conn = new MySqlConnection(connString);
            conn.Open();

            // Hämta alla matchande filmer från databasen
            string sql = "SELECT year FROM movies WHERE year = @input";
            var cmd = new MySqlCommand(sql, conn);

            // Hämta alla relationer mellan filmer och skådespelare från databasen
            string sql1 = "SELECT * FROM LeadActor";

            // Hämta alla relaterade skådespelare från databasen
            string sql2 = "SELECT name FROM actor WHERE ";

            cmd.Parameters.AddWithValue("@s60127_Codemonkeys", "@input");
            var adt = new MySqlDataAdapter(cmd);
            adt.Fill(dt);

            return dt;

            // Hämta alla matchande filmer från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer

        }

        public List<Movie> GetMovie(int Id)
        {
            // Hämta matchande film från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }

        public List<Movie> GetMovie(string name)
        {
            // Hämta matchande film från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
        }


        public List<Actor> GetActors()
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public List<Actor> GetActorsInMovie(Movie movie)
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public List<Movie> GetMoviesWithActor(Actor actor)
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public List<Movie> GetMoviesWithActor(string actorName)
        {
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public List<Movie> GetMoviesWithActor(int actorId)
        {

            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla matchande filmer från databasen
            // Skapa en lista med skådespelare
            // Lägg till filmerna till skådespelarna
            // Returnera listan med skådespelare
        }

        public void DeleteActor(int actorId)
        {
           var conn=new MovieCrud(string connString);
            conn.Open();
            string sql="Delete from Actor where ID=actorId";
            var cmd=new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("actorId","Actor");
            cmd.ExecuteNonQuery();
            string sql="Delete from LeadActor where ID=actorId";
            cmd.Parameters.AddWithValue("actorId","LeadActor");
            var cmd=new MySqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            // Ta bort skådespelaren från databasen
            // Ta bort alla relationer mellan skådespelaren och filmerna från databasen
        }

        public void DeleteMove(int moveId)
        {
            var conn=new MovieCrud(string connString);
            conn.Open();
            string sql="Delete from Movies where ID=movieId";
            var cmd=new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("movieId","Movies");
            cmd.ExecuteNonQuery();
            string sql="Delete from LeadActor where ID=movieId";
            cmd.Parameters.AddWithValue("movieId","LeadActor");
            var cmd=new MySqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            // Ta bort filmen från databasen
            // Ta bort alla relationer mellan filmen och skådespelarna från databasen
            
        }
    }
}
