namespace MovieDatabase_Template
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Globalization;
    using System.Linq;
    using System.Reflection.Metadata.Ecma335;
    using System.Text;
    using System.Threading.Tasks;
    using MovieDatabase;
    using MySql.Data.MySqlClient;
    using MySqlX.XDevAPI.Relational;

    public class MovieCrud
    {
        private string connString=File.ReadAllLines("C:\Users\tinas\OneDrive\Dokument\connString.txt");
        
        public MovieCrud(string connString)   
        {
                       
        }
        public void AddMovie(Movie movie)

        {
            var conn = new MySqlConnection(connString);
            conn.Open();
            var sql = "Select * from Movie where title=movie";
            var cmd = new MySqlCommand(sql, conn);
            if (movie != null)
            {
                sql = "Update Movie set (Title,Year,Genre) ";
            }
            else
            {
                cmd.Parameters.AddWithValue("Movie", "Title, Year, Genre");             
            }
            
            cmd =new MySqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public void AddActor(Actor actor)
        {

            // Kolla om skådespelaren finns i databasen
            var conn = new MySqlConnection(connString);
            conn.Open();
            // Updatera isåfall
            // Lägg till skådespelarna i databasen
            var sql = "SELECT * FROM name WHERE Actor = @name";
            var cmd = new MySqlCommand(sql, conn);

            if (actor != null)
            {
                sql = "Update Movie set (name,birthYear,movieId)";
            }
            else
            {
                cmd.Parameters.AddWithValue("Actor", "name, birthYear");
            }
            
            cmd.ExecuteNonQuery();
            conn.Close();

            
           
        }

        public void AddActorToMovie(Actor actor, Movie movie)
        {

            // Kolla om relationen finns i databasen, i så fall är du klar
            // Annars lägg till relationen mellan filmen och skådespelaren i databasen
            var conn = new MySqlConnection(connString);
            conn.Open();
            // Updatera isåfall
            // Lägg till skådespelarna i databasen
            var sql = "SELECT JOIN Casting.movieId = Actor.actorId";
            sql = "SELECT * FROM Actor";
            var cmd = new MySqlCommand(sql, conn);


            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public List<Movie> GetMovies()
        {
            // Hämta alla filmer från databasen
            // Hämta alla skådespelare från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer

            return null;
        }

        public List<Movie> GetMoviesContaining(string search)
        {
            // Hämta alla matchande filmer från databasen
            // Hämta alla relationer mellan filmer och skådespelare från databasen
            // Hämta alla relaterade skådespelare från databasen
            // Skapa en lista med filmer
            // Lägg till skådespelarna till filmerna
            // Returnera listan med filmer
            return null;
        }

        public List<Movie> GetMoviesFromYear(int year)
        {
            
            DataTable dt = new DataTable();


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
            conn.Close();

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
                string sql = "Select IMDB_link from Movie where id=Id"
                string link="";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo 
                {FileName=link,UseShellExecute=true});
                return null;
            }

        public List<Movie> GetMovie(string name)
        {

                // Hämta matchande film från databasen
                // Hämta alla relationer mellan filmer och skådespelare från databasen
                // Hämta alla relaterade skådespelare från databasen
                // Skapa en lista med filmer
                // Lägg till skådespelarna till filmerna
                // Returnera listan med filmer
                string sql = "Select IMDB_link from Movie where id=Id"
                string link="";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo 
                {FileName=link,UseShellExecute=true});
                return null;
                
            }


        public List<Actor> GetActors()
        {

                // Hämta alla skådespelare från databasen
                // Hämta alla relationer mellan filmer och skådespelare från databasen
                // Hämta alla matchande filmer från databasen
                // Skapa en lista med skådespelare
                // Lägg till filmerna till skådespelarna
                // Returnera listan med skådespelare
                return null;
            }

        public List<Actor> GetActorsInMovie(Movie movie)
        {

                // Hämta alla skådespelare från databasen
                // Hämta alla relationer mellan filmer och skådespelare från databasen
                // Hämta alla matchande filmer från databasen
                // Skapa en lista med skådespelare
                // Lägg till filmerna till skådespelarna
                // Returnera listan med skådespelare
                return null;
            }

        public List<Movie> GetMoviesWithActor(Actor actor)
        {

                // Hämta alla skådespelare från databasen
                // Hämta alla relationer mellan filmer och skådespelare från databasen
                // Hämta alla matchande filmer från databasen
                // Skapa en lista med skådespelare
                // Lägg till filmerna till skådespelarna
                // Returnera listan med skådespelare
                return null;
            }

        public List<Movie> GetMoviesWithActor(string actorName)
        {

                // Hämta alla skådespelare från databasen
                // Hämta alla relationer mellan filmer och skådespelare från databasen
                // Hämta alla matchande filmer från databasen
                // Skapa en lista med skådespelare
                // Lägg till filmerna till skådespelarna
                // Returnera listan med skådespelare
                return null;
            }

        public List<Movie> GetMoviesWithActor(int actorId)
        {

                // Hämta alla skådespelare från databasen
                // Hämta alla relationer mellan filmer och skådespelare från databasen
                // Hämta alla matchande filmer från databasen
                // Skapa en lista med skådespelare
                // Lägg till filmerna till skådespelarna
                // Returnera listan med skådespelare
                return null;
            }

        public void DeleteActor(int actorId)
        {
            
            var conn = new MySqlConnection(connString);
            conn.Open();
            string sql="Delete from Actor where ID=actorId";
            var cmd=new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("actorId","Actor");
            cmd.ExecuteNonQuery();
            sql="Delete from LeadActor where ID=actorId";
            cmd.Parameters.AddWithValue("actorId","LeadActor");
            cmd=new MySqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            // Ta bort skådespelaren från databasen
            // Ta bort alla relationer mellan skådespelaren och filmerna från databasen
        }

        public void DeleteMove(int moveId)
        {
            var conn = new MySqlConnection(connString);
            conn.Open();
            string sql="Delete from Movies where ID=movieId";
            var cmd=new MySqlCommand(sql,conn);
            cmd.Parameters.AddWithValue("movieId","Movies");
            cmd.ExecuteNonQuery();
            sql="Delete from LeadActor where ID=movieId";
            cmd.Parameters.AddWithValue("movieId","LeadActor");
            cmd=new MySqlCommand(sql,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
           
            // Ta bort filmen från databasen
            // Ta bort alla relationer mellan filmen och skådespelarna från databasen
            
        }
    }
}
