//import {inject} from "aurelia-framework";
import {MovieData} from "./movieData";

//@inject(MovieData)
export class List {

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


