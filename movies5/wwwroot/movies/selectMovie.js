import { MovieData } from "./movieData";

export class SelectMovie{
    selectedMovie = []

    constructor(movieData) {
        this.movieData = movieData;
    }

    static inject() { return [MovieData] }

    activate() {
        return this.movieData
            .getAll()
            .then(movies => this.movies = movies);
    }
}