using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Repositories;

namespace WindowsFormsApp1
{
    public class Controller
    {
        private const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=MovieDatabase;Integrated Security=SSPI;";

        private AddMovieItemDel AddMovieItem;

        private IGenresRepository genresRepository = new SqlGenresRepository(connectionString);
        private IMoviesRepository moviesRepository = new SqlMoviesRepository(connectionString);
        private IPeopleRepository peopleRepository = new SqlPeopleRepository(connectionString);
        private IPersonalRatingsRepository personalRatingsRepository = new SqlPersonalRatingsRepository(connectionString);
        private IRolesRepository rolesRepository = new SqlRolesRepository(connectionString);
        private IStudiosRepository studiosRepository = new SqlStudiosRepository(connectionString);
        private IUsersRepository usersRepository = new SqlUsersRepository(connectionString);

        public void SetAddNewMovieItemDel(AddMovieItemDel del)
        {
            AddMovieItem = del;
        }

        public void AddMovieItems(MovieItems item)
        {
            AddMovieItem(item);
        }

        public Genres FetchGenre(int genreId)
        {
            return genresRepository.FetchGenre(genreId);
        }

        public Movies FetchMovie(int movieId)
        {
            return moviesRepository.FetchMovie(movieId);
        }

        public People FetchPerson(int personId)
        {
            return peopleRepository.FetchPerson(personId);
        }

        public PersonalRatings FetchPersonalRating(int ratingId)
        {
            return personalRatingsRepository.FetchPersonalRating(ratingId);
        }

        public Roles FetchRole(int roleId)
        {
            return rolesRepository.FetchRole(roleId);
        }

        public Studios FetchStudio(int studioId)
        {
            return studiosRepository.FetchStudio(studioId);
        }

        public Users FetchUser(int userId)
        {
            return usersRepository.FetchUser(userId);
        }

        public IReadOnlyList<Genres> GetGenres()
        {
            return genresRepository.RetrieveGenres();
        }

        public IReadOnlyList<Movies> GetMovies()
        {
            return moviesRepository.RetrieveMovies();
        }

        public IReadOnlyList<People> GetPeople()
        {
            return peopleRepository.RetrievePeople();
        }

        public IReadOnlyList<PersonalRatings> GetPersonalRatings()
        {
            return personalRatingsRepository.RetrievePersonalRatings();
        }

        public IReadOnlyList<Roles> GetRoles()
        {
            return rolesRepository.RetrieveRoles();
        }

        public IReadOnlyList<Studios> GetStudios()
        {
            return studiosRepository.RetrieveStudios();
        }

        public IReadOnlyList<Users> GetUsers()
        {
            return usersRepository.RetrieveUsers();
        }

        public Users GetUser(string username)
        {
            return usersRepository.GetUser(username);
        }

        public IReadOnlyList<Movies> GetMoviesByName(string movieName)
        {
            return moviesRepository.GetMoviesByName(movieName);
        }

        public IReadOnlyList<PersonalRatings> GetReviewsForMovie(int movieId)
        {
            return personalRatingsRepository.GetReviewsForMovie(movieId);
        }

        public void CreateGenre(string genre)
        {
            genresRepository.CreateGenre(genre);
        }

        public void CreateMovie(int studioId, string movieName, Int16 releaseDate, decimal imdb, int audience, long domestic, long international, int cost, int genreId, int critic)
        {
            moviesRepository.CreateMovie(studioId, movieName, releaseDate, imdb, audience, domestic, international, cost, genreId, critic);
        }

        public void CreatePerson(string firstName, string lastName)
        {
            peopleRepository.CreatePerson(firstName, lastName);
        }

        public void CreatePersonalRating(int movieId, int authorUserId, int personalRating, string ratingDescription)
        {
            personalRatingsRepository.CreatePersonalRating(movieId, authorUserId, personalRating, ratingDescription);
        }

        public void CreateRole(int personId, int movieId, bool isDirector, bool isActor, int amountPaid)
        {
            rolesRepository.CreateRole(personId, movieId, isDirector, isActor, amountPaid);
        }

        public void CreateStudio(string studioName)
        {
            studiosRepository.CreateStudio(studioName);
        }

        public void CreateUser(string username, string password, string name, string recoveryEmail)
        {
            usersRepository.CreateUser(username, password, name, recoveryEmail);
        }

        public void UpdateMovie(int movieId, int studioId, string movieName, Int16 releaseDate, decimal imdb, int audience, long domestic, long international, int cost, int genreId, int critic)
        {
            moviesRepository.SaveMovie(movieId, studioId, movieName, releaseDate, imdb, audience, domestic, international, cost, genreId, critic);
        }

        public void UpdatePersonalRating(int ratingId, int movieId, int authorUserId, int personalRating, string ratingDescription)
        {
            personalRatingsRepository.SavePersonalRating(ratingId, movieId, authorUserId, personalRating, ratingDescription);
        }

        public void UpdateRole(int roleId, int personId, int movieId, bool isDirector, bool isActor, int amountPaid)
        {
            rolesRepository.SaveRole(roleId, personId, movieId, isDirector, isActor, amountPaid);
        }

        public void UpdateUser(int userId, string username, string password, string name, string recoveryEmail)
        {
            usersRepository.SaveUser(userId, username, password, name, recoveryEmail);
        }
    }
}
